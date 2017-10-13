Namespace PlexIsBusyPlugin
    Public Class PlexIsBusyPluginSettings
        Inherits PropertyChangedBase

        Private m_plexurl As String = "http://127.0.0.1:32400"
        Public Property PlexURL As String
            Set(value As String)
                m_plexurl = value
                RaisePropertyChanged("PlexURL")
            End Set
            Get
                Return m_plexurl
            End Get
        End Property

        Private m_plexusername As String = String.Empty

        Public Property PlexUsername As String
            Set(value As String)
                m_plexusername = value
                RaisePropertyChanged("PlexUsername")
            End Set
            Get
                Return m_plexusername
            End Get
        End Property


        Private m_plextoken As String = String.Empty

        Public Property PlexToken As String
            Set(value As String)
                m_plextoken = value
                RaisePropertyChanged("PlexToken")
            End Set
            Get
                Return m_plextoken
            End Get
        End Property

        Private m_detailed_report As Boolean = False

        Public Property DetailedReport As Boolean
            Set(value As Boolean)
                m_detailed_report = value
                RaisePropertyChanged("DetailedReport")
            End Set
            Get
                Return m_detailed_report
            End Get
        End Property

    End Class

End Namespace
