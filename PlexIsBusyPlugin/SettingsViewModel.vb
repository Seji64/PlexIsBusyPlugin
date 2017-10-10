Imports System.Collections.ObjectModel
Imports System.Windows.Data

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

    End Class

End Namespace
