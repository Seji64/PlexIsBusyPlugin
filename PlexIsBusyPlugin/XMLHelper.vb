Imports System.IO
Imports System.Xml.Serialization
Namespace PlexIsBusyPlugin
    Module XMLHelper

        ''' <summary>
        ''' Diese Funktion serialisiert ein Objekt  und speichert es als XML-Format Datei im UTF-8 Zeichensatz
        ''' </summary>
        ''' <param name="Obj">Das zu serialisierende Objekt</param>
        ''' <param name="FileName">Die XML Datei in der das Ergebnis gespeichert werden soll</param>
        Public Sub XMLSerialize(ByVal Obj As Object, ByVal FileName As String)
            Dim XML As New XmlSerializer(Obj.GetType)
            Dim FS As New StreamWriter(FileName, False, System.Text.Encoding.UTF8)
            XML.Serialize(FS, Obj)
            FS.Close()
        End Sub

        ''' <summary>
        ''' Diese Funktion deserialisiert eine XML Datei mit dem UTF-8 Zeichensatz und gibt das Ergebnis in ein Objekt zurück
        ''' </summary>
        ''' <param name="FileName">Die XML Datei aus der gelesen werden soll</param>
        Public Function XMLDeSerialize(ByVal Obj As Object, ByVal FileName As String) As Object
            Dim XML As New XmlSerializer(Obj.GetType)
            Dim FS As New StreamReader(FileName, System.Text.Encoding.UTF8)
            Dim RetObj As Object = XML.Deserialize(FS)
            FS.Close()
            Return RetObj

        End Function

    End Module

End Namespace
