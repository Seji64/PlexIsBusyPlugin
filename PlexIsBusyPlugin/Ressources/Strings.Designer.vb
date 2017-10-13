﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace PlexIsBusyPlugin.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class Strings
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PlexIsBusyPlugin.Strings", GetType(Strings).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Detaillierter Mediennutzungsbericht anzeigen ähnelt.
        '''</summary>
        Public Shared ReadOnly Property CheckBox_detailed_report() As String
            Get
                Return ResourceManager.GetString("CheckBox_detailed_report", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Token konnte nicht abgerufen werden! {0} Fehlerdetails: {1} {2} ähnelt.
        '''</summary>
        Public Shared ReadOnly Property Get_Plex_Token_Fail_Message() As String
            Get
                Return ResourceManager.GetString("Get_Plex_Token_Fail_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Token erfolgreich abgerufen! ähnelt.
        '''</summary>
        Public Shared ReadOnly Property Get_Plex_Token_Success_Message() As String
            Get
                Return ResourceManager.GetString("Get_Plex_Token_Success_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Authentifizierungs Token ähnelt.
        '''</summary>
        Public Shared ReadOnly Property GroupBox_Authentication_Token_Header() As String
            Get
                Return ResourceManager.GetString("GroupBox_Authentication_Token_Header", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Hier kann bzw. muss ein Plex Authentifierungs Token eingetragen werden.
        '''
        '''Dies ist nötig wenn dein Plex Server einen Anmeldung verlangt.
        '''Sollte dein Plex Server diese nicht benötigen kannst du das Feld einfach leer lassen.
        '''
        '''Ansonsten trage deinen Plex Benutzername und Kennwort ein und klicke auf &apos;Token holen&apos; ähnelt.
        '''</summary>
        Public Shared ReadOnly Property GroupBox_Authentication_Token_HelpText() As String
            Get
                Return ResourceManager.GetString("GroupBox_Authentication_Token_HelpText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Einstellungen ähnelt.
        '''</summary>
        Public Shared ReadOnly Property GroupBox_General_Settings_Header() As String
            Get
                Return ResourceManager.GetString("GroupBox_General_Settings_Header", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Gib hier deine Plex Server URL ein. 
        '''
        '''Wenn WASPM auf dem selben PC/Server wie Plex läuft,
        '''kann diese Einstellung auf dem Standarwert belassen werden ähnelt.
        '''</summary>
        Public Shared ReadOnly Property GroupBox_General_Settings_HelpText() As String
            Get
                Return ResourceManager.GetString("GroupBox_General_Settings_HelpText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Konfiguration testen ähnelt.
        '''</summary>
        Public Shared ReadOnly Property GroupBox_Test_Settings_Header() As String
            Get
                Return ResourceManager.GetString("GroupBox_Test_Settings_Header", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Hier kannst du testen ob deine konfiguration korrekt ist. ähnelt.
        '''</summary>
        Public Shared ReadOnly Property GroupBox_Test_Settings_HelpText() As String
            Get
                Return ResourceManager.GetString("GroupBox_Test_Settings_HelpText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Plex ist beschäftigt! (Medienanzahl: {0}) ähnelt.
        '''</summary>
        Public Shared ReadOnly Property PluginCheckSuspendResult_Message() As String
            Get
                Return ResourceManager.GetString("PluginCheckSuspendResult_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Verbindungstest fehlgeschlagen - Bitte überprüfe deine Einstellungen {0} Fehlerdetails: {1} {2} ähnelt.
        '''</summary>
        Public Shared ReadOnly Property Test_Settings_Fail_Message() As String
            Get
                Return ResourceManager.GetString("Test_Settings_Fail_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Verbindungstest erfolgreich! ähnelt.
        '''</summary>
        Public Shared ReadOnly Property Test_Settings_Success_Message() As String
            Get
                Return ResourceManager.GetString("Test_Settings_Success_Message", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
