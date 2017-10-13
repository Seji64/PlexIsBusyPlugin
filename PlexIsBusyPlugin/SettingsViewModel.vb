Imports System.Windows
Imports System.Windows.Input
Imports Xceed.Wpf.Toolkit

Namespace PlexIsBusyPlugin
    Public Class SettingsViewModel
        Inherits PropertyChangedBase

        Private m_settings As New PlexIsBusyPluginSettings
        Public Property Settings As PlexIsBusyPluginSettings
            Set(value As PlexIsBusyPluginSettings)
                m_settings = value
                RaisePropertyChanged("Settings")
            End Set
            Get
                Return m_settings
            End Get
        End Property

        Public ReadOnly Property GetPlexTokenCommad As ICommand
            Get
                Return New DelegateCommand(AddressOf GetPlexToken)
            End Get
        End Property

        Private Async Sub GetPlexToken(ByVal parameter As Object)

            Dim m_passwordbox As WatermarkPasswordBox = CType(parameter, WatermarkPasswordBox)

            Try

                Dim m_token As String = String.Empty

                m_token = Await Plex.GetPlexToken(Me.Settings.PlexUsername, m_passwordbox.Password)

                Me.Settings.PlexToken = m_token

                Xceed.Wpf.Toolkit.MessageBox.Show(Resources.Strings.Get_Plex_Token_Success_Message, "PlexIsBusyPlugin", MessageBoxButton.OK, MessageBoxImage.Information)

            Catch ex As Exception
                Xceed.Wpf.Toolkit.MessageBox.Show(String.Format(Resources.Strings.Get_Plex_Token_Fail_Message, vbNewLine, vbNewLine, ex.Message), "PlexIsBusyPlugin - Error", MessageBoxButton.OK, MessageBoxImage.Error)
            End Try

        End Sub

        Public ReadOnly Property TestConfigCommad As ICommand
            Get
                Return New DelegateCommand(AddressOf TestConfig)
            End Get
        End Property

        Private Async Sub TestConfig(ByVal parameter As Object)

            Dim m_plex_query_url As Uri = Nothing
            Dim m_plex_xml_path As String = String.Empty
            Dim m_plex_media_xml As XDocument
            Dim m_plex_helper As Plex

            Try

                Uri.TryCreate(New Uri(Me.Settings.PlexURL), "/status/sessions", m_plex_query_url)
                m_plex_xml_path = Await Plex.DownloadPlexStatusXML(m_plex_query_url, Me.Settings.PlexToken)
                m_plex_media_xml = XDocument.Parse(My.Computer.FileSystem.ReadAllText(m_plex_xml_path, System.Text.Encoding.UTF8))

                m_plex_helper = New Plex(m_plex_media_xml)

                m_plex_helper.GetMediaContainerSize()

                Xceed.Wpf.Toolkit.MessageBox.Show(Resources.Strings.Test_Settings_Success_Message, "PlexIsBusyPlugin", MessageBoxButton.OK, MessageBoxImage.Information)

            Catch ex As Exception
                Xceed.Wpf.Toolkit.MessageBox.Show(String.Format(Resources.Strings.Test_Settings_Fail_Message, vbNewLine, vbNewLine, ex.Message), "PlexIsBusyPlugin - Error", MessageBoxButton.OK, MessageBoxImage.Error)
            End Try

        End Sub

    End Class

End Namespace
