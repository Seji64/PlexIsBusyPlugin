Imports System.Windows.Controls
Imports Wsapm.Extensions

Namespace PlexIsBusyPlugin
    Public Class PlexIsBusyPluginControl
        Inherits UserControl
        Implements IWsapmPluginSettingsControl

        Dim _settingsviewmodel As SettingsViewModel
        Public Sub New()

            InitializeComponent()

            _settingsviewmodel = New SettingsViewModel

            Me.DataContext = _settingsviewmodel

        End Sub

        Public Sub SetSettings(settings As Object) Implements IWsapmPluginSettingsControl.SetSettings

            Dim mysettings As PlexIsBusyPluginSettings = CType(settings, PlexIsBusyPluginSettings)

            _settingsviewmodel.Settings = mysettings

        End Sub

        Public Function GetSettingsBeforeSave() As Object Implements IWsapmPluginSettingsControl.GetSettingsBeforeSave

            Return _settingsviewmodel.Settings

        End Function
    End Class

End Namespace
