Imports System.ComponentModel.Composition
Imports System.Text
Imports Wsapm.Extensions

Namespace PlexIsBusyPlugin
    <Export(GetType(WsapmPluginBase))>
    <WsapmPlugin("PlexIsBusy", "v1.0.0", "{328DE8EF-D715-49B7-8C30-10008CA14822}")>
    Public Class PlexIsBusyPlugin
        Inherits WsapmPluginAdvancedBase

        Private m_settingsControl As PlexIsBusyPluginControl

        Public Sub New()
            MyBase.New(GetType(PlexIsBusyPluginSettings))
        End Sub

        Public Overrides ReadOnly Property SettingsControl As Object
            Get
                If IsNothing(m_settingsControl) Then
                    m_settingsControl = New PlexIsBusyPluginControl
                End If

                Return m_settingsControl
            End Get
        End Property

        Protected Overrides Function CheckPluginPolicy() As PluginCheckSuspendResult

            Dim m_pluginSettings As PlexIsBusyPluginSettings = CType(Me.CurrentSettings, PlexIsBusyPluginSettings)
            Dim m_plex_media As New Plex.MediaContainer
            Dim m_plex_xml_path As String = String.Empty
            Dim m_log_message As New StringBuilder

            Try

                If String.IsNullOrWhiteSpace(m_pluginSettings.PlexURL) = False Then

                    Dim m_plex_query_url As Uri = Nothing

                    Uri.TryCreate(New Uri(m_pluginSettings.PlexURL), "/status/sessions", m_plex_query_url)

                    m_plex_xml_path = HttpHelper.DownloadFile2Temp(m_plex_query_url).Result

                    If String.IsNullOrWhiteSpace(m_plex_xml_path) = False AndAlso IO.File.Exists(m_plex_xml_path) Then

                        m_plex_media = XMLHelper.XMLDeSerialize(m_plex_media, m_plex_xml_path)

                        If IsNothing(m_plex_media) = False AndAlso IsNothing(m_plex_media.size) = False Then

                            If m_plex_media.size > 0 Then

                                m_log_message.Append(String.Format("Plex is busy! (Media Count: {0})", m_plex_media.size))

                                If IsNothing(m_plex_media.Video) = False Then

                                    For Each _video In m_plex_media.Video

                                        m_log_message.AppendLine("")
                                        m_log_message.AppendLine("Type: Video")
                                        m_log_message.AppendLine(String.Format("Video Title: {0}", _video.title))
                                        m_log_message.AppendLine(String.Format("Player Name: {0}", _video.Player.title))
                                        m_log_message.AppendLine(String.Format("User Name: {0}", _video.User.title))
                                        m_log_message.AppendLine("################################################")

                                    Next

                                End If

                                If IsNothing(m_plex_media.Track) = False Then

                                    For Each _track In m_plex_media.Track

                                        m_log_message.AppendLine("")
                                        m_log_message.AppendLine("Type: Music/Track")
                                        m_log_message.AppendLine(String.Format("Track/Music Title: {0}", _track.title))
                                        m_log_message.AppendLine(String.Format("Player Name: {0}", _track.Player.title))
                                        m_log_message.AppendLine(String.Format("User Name: {0}", _track.User.title))
                                        m_log_message.AppendLine("################################################")

                                    Next

                                End If


                                If IsNothing(m_plex_media.Photo) = False Then

                                    For Each _photo In m_plex_media.Track

                                        m_log_message.AppendLine("")
                                        m_log_message.AppendLine("Type: Photo")
                                        m_log_message.AppendLine(String.Format("Photo Title: {0}", _photo.title))
                                        m_log_message.AppendLine(String.Format("Player Name: {0}", _photo.Player.title))
                                        m_log_message.AppendLine(String.Format("User Name: {0}", _photo.User.title))
                                        m_log_message.AppendLine("################################################")

                                    Next

                                End If

                                Return New PluginCheckSuspendResult(True, m_log_message.ToString)

                            Else
                                'Plex is not Busy
                                Return New PluginCheckSuspendResult(False, String.Empty)
                            End If

                        Else
                            Throw New Exception("Failed to deserialize XML!")
                        End If

                    Else
                        Throw New Exception("Failed to get Plex Session Status!")
                    End If
                Else
                    Throw New Exception("No valid Settings!")
                End If

            Catch ex As Exception
                Return New PluginCheckSuspendResult(False, String.Empty)
            Finally

                'CleanUp
                If IO.File.Exists(m_plex_xml_path) Then
                    IO.File.Delete(m_plex_xml_path)
                End If

            End Try

        End Function

        Protected Overrides Function Initialize() As Boolean
            Return True
        End Function

        Protected Overrides Function LoadDefaultSettings() As Object
            Return New PlexIsBusyPluginSettings
        End Function

        Protected Overrides Function Prepare() As Boolean
            Return True
        End Function

        Protected Overrides Function TearDown() As Boolean
            Return True
        End Function
    End Class

End Namespace
