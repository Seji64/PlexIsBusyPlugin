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

    End Class

End Namespace
