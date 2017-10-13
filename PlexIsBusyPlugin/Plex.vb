
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading.Tasks

Namespace PlexIsBusyPlugin
    Public Class Plex

        Private m_plex_xml As XDocument
        Public Sub New(ByVal _xml As XDocument)
            m_plex_xml = _xml
        End Sub

#Region "Shared Functions"


        Public Shared Async Function DownloadPlexStatusXML(ByVal _url As Uri, ByVal _plex_token As String) As Task(Of String)

            Dim m_http_client As HttpClient = New HttpClient
            Dim m_http_response As HttpResponseMessage
            Dim m_content As HttpContent
            Dim m_local_tmp_filepath As String = String.Empty

            m_http_client.BaseAddress = _url


            If Not String.IsNullOrWhiteSpace(_plex_token) Then
                m_http_client.DefaultRequestHeaders.Add("X-Plex-Token", _plex_token)
            End If

            m_http_response = Await m_http_client.GetAsync(_url)
            m_http_response.EnsureSuccessStatusCode()

            Await m_http_response.Content.LoadIntoBufferAsync()

            m_content = m_http_response.Content
            m_local_tmp_filepath = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, IO.Path.GetRandomFileName)

            Using _filestream As New IO.FileStream(m_local_tmp_filepath, IO.FileMode.Create, IO.FileAccess.Write)
                Await m_content.CopyToAsync(_filestream)
            End Using

            Return m_local_tmp_filepath

        End Function

        Public Shared Async Function GetPlexToken(ByVal plexuser As String, ByVal plexpassword As String) As Task(Of String)

            Dim m_http_client As HttpClient = New HttpClient
            Dim m_http_response As HttpResponseMessage
            Dim m_content As String
            Dim m_auth_bytes As Byte()
            Dim m_auth As String
            Dim m_http_conent = New FormUrlEncodedContent(New List(Of KeyValuePair(Of String, String))() From {New KeyValuePair(Of String, String)("type", "POST")})
            Dim m_result_xml As XDocument
            Dim m_token As String = String.Empty

            m_http_client.BaseAddress = New Uri("https://plex.tv")

            m_auth_bytes = System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", plexuser, plexpassword))
            m_auth = System.Convert.ToBase64String(m_auth_bytes)

            m_http_client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", m_auth)
            m_http_client.DefaultRequestHeaders.Add("X-Plex-Client-Identifier", "WSAPMPlexIsBusyPlugin")
            m_http_client.DefaultRequestHeaders.Add("X-Plex-Product", "WSAPMPlexIsBusyPlugin")
            m_http_client.DefaultRequestHeaders.Add("X-Plex-Version", "1.0.1")

            m_http_response = Await m_http_client.PostAsync("/users/sign_in.xml", m_http_conent)

            m_http_response.EnsureSuccessStatusCode()

            m_content = Await m_http_response.Content.ReadAsStringAsync()

            m_result_xml = XDocument.Parse(m_content)

            For Each _token_element In m_result_xml.Descendants("user").Descendants("authentication-token")
                m_token = _token_element.Value
            Next

            Return m_token

        End Function

#End Region

#Region "Private Functions"

        Private Function GetPlexUserObject(ByVal _xml_element As XElement) As PlexUser

            Dim m_plex_user As New PlexUser

            If _xml_element.HasAttributes = True Then

                If Not IsNothing(_xml_element.Attribute("title").Value) Then
                    m_plex_user.title = _xml_element.Attribute("title").Value
                End If

                If Not IsNothing(_xml_element.Attribute("id").Value) Then
                    m_plex_user.id = CInt(_xml_element.Attribute("id").Value)
                End If

                If Not IsNothing(_xml_element.Attribute("thumb").Value) Then
                    m_plex_user.thumb = _xml_element.Attribute("thumb").Value
                End If

            End If

            Return m_plex_user

        End Function

        Private Function GetPlexPlayerObject(ByVal _xml_element As XElement) As PlexPlayer

            Dim m_plex_player As New PlexPlayer

            If _xml_element.HasAttributes = True Then

                If Not IsNothing(_xml_element.Attribute("title").Value) Then
                    m_plex_player.title = _xml_element.Attribute("title").Value
                End If

                If Not IsNothing(_xml_element.Attribute("address").Value) Then
                    m_plex_player.address = _xml_element.Attribute("address").Value
                End If

                If Not IsNothing(_xml_element.Attribute("device").Value) Then
                    m_plex_player.device = _xml_element.Attribute("device").Value
                End If

                If Not IsNothing(_xml_element.Attribute("state").Value) Then
                    m_plex_player.state = _xml_element.Attribute("state").Value
                End If

            End If

            Return m_plex_player

        End Function


#End Region

        Public Function GetMediaContainerSize() As Integer

            Dim m_rt_value As Integer = 0

            For Each _element In m_plex_xml.Descendants("MediaContainer")

                If _element.HasAttributes = True Then
                    m_rt_value = CInt(_element.Attribute("size").Value)
                End If

            Next

            Return m_rt_value

        End Function

        Public Function GetNowPlaying() As PlexNowPlaying

            Dim m_plex_now_playing As New PlexNowPlaying

            m_plex_now_playing.MediaCount = GetMediaContainerSize()

            For Each _element In m_plex_xml.Descendants("MediaContainer").Descendants("Video")

                Dim m_plex_video As New PlexVideo

                If _element.HasAttributes = True Then

                    If Not IsNothing(_element.Attribute("title").Value) Then
                        m_plex_video.Title = _element.Attribute("title").Value
                    End If

                    If Not IsNothing(_element.Attribute("type").Value) Then
                        m_plex_video.Type = _element.Attribute("type").Value
                    End If

                End If

                For Each _user_element In _element.Descendants("User")
                    m_plex_video.User = GetPlexUserObject(_user_element)
                Next

                For Each _player_element In _element.Descendants("Player")
                    m_plex_video.Player = GetPlexPlayerObject(_player_element)
                Next

                m_plex_now_playing.Videos.Add(m_plex_video)

            Next

            For Each _element In m_plex_xml.Descendants("MediaContainer").Descendants("Track")

                Dim m_plex_track As New PlexTrack

                If _element.HasAttributes = True Then

                    If Not IsNothing(_element.Attribute("title").Value) Then
                        m_plex_track.Title = _element.Attribute("title").Value
                    End If

                    If Not IsNothing(_element.Attribute("type").Value) Then
                        m_plex_track.Type = _element.Attribute("type").Value
                    End If

                End If

                For Each _user_element In _element.Descendants("User")
                    m_plex_track.User = GetPlexUserObject(_user_element)
                Next

                For Each _player_element In _element.Descendants("Player")
                    m_plex_track.Player = GetPlexPlayerObject(_player_element)
                Next

                m_plex_now_playing.Tracks.Add(m_plex_track)

            Next

            For Each _element In m_plex_xml.Descendants("MediaContainer").Descendants("Photo")

                Dim m_plex_photo As New PlexPhoto

                If _element.HasAttributes = True Then

                    If Not IsNothing(_element.Attribute("title").Value) Then
                        m_plex_photo.Title = _element.Attribute("title").Value
                    End If

                    If Not IsNothing(_element.Attribute("type").Value) Then
                        m_plex_photo.Type = _element.Attribute("type").Value
                    End If

                End If

                For Each _user_element In _element.Descendants("User")
                    m_plex_photo.User = GetPlexUserObject(_user_element)
                Next

                For Each _player_element In _element.Descendants("Player")
                    m_plex_photo.Player = GetPlexPlayerObject(_player_element)
                Next

                m_plex_now_playing.Photos.Add(m_plex_photo)

            Next

            Return m_plex_now_playing

        End Function

    End Class


End Namespace