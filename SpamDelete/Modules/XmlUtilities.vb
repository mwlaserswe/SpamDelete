Option Explicit On

Imports System.Xml

Module XmlUtilities
    Public Structure SpamInfo
        Public _OriginalText As String
        Public _SearchText As String
    End Structure



    Public Function ReadSpamList(FileName As String, ByRef SpamTextList() As SpamInfo) As Integer
        Dim ReadSpam As SpamInfo
        Dim xmlDoc As New XmlDocument()
        Dim dmy As String

        xmlDoc.Load(FileName)
        Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/SpamList/General/Item")
        'Dim ID As String = "", WKN As String = "", ISIN As String = ""

        Dim NodeList As XmlNodeList

        NodeList = xmlDoc.DocumentElement.SelectNodes("/SpamList/General/Item/Entry")
        ReDim SpamTextList(0)
        Dim Cnt As Integer
        Cnt = 0
        For Each node As XmlNode In NodeList
            ReadSpam._OriginalText = node.SelectSingleNode("OriginalText").InnerText
            ReadSpam._SearchText = node.SelectSingleNode("SearchText").InnerText
            SpamTextList(Cnt) = ReadSpam
            Cnt = Cnt + 1
            ReDim Preserve SpamTextList(Cnt)
        Next
        ReDim Preserve SpamTextList(Cnt - 1)

        ReadSpamList = Cnt

    End Function



    '''Public Sub InitSpamList(FileName As String, SpamItem As SpamInfo)
    '''    ' Create XmlWriterSettings.
    '''    Dim settings As XmlWriterSettings = New XmlWriterSettings()
    '''    settings.Indent = True
    '''    settings.NewLineOnAttributes = True

    '''    ' Create XmlWriter.
    '''    Using writer As XmlWriter = XmlWriter.Create(FileName, settings)
    '''        ' Begin writing.
    '''        writer.WriteStartDocument()
    '''        writer.WriteStartElement("SpamList") ' Root.

    '''        writer.WriteStartElement("General")
    '''        writer.WriteStartElement("Item")


    '''        '=====================================
    '''        writer.WriteStartElement("Entry")
    '''        writer.WriteElementString("OriginalText", "Müller")
    '''        writer.WriteElementString("SearchText", "M;ller")
    '''        writer.WriteEndElement()
    '''        '====================================

    '''        '=====================================
    '''        writer.WriteStartElement("Entry")
    '''        writer.WriteElementString("OriginalText", "Düse")
    '''        writer.WriteElementString("SearchText", "D;se")
    '''        writer.WriteEndElement()
    '''        '====================================




    '''        writer.WriteEndElement()
    '''        writer.WriteEndElement()

    '''        ' End document.
    '''        writer.WriteEndElement()
    '''        writer.WriteEndDocument()
    '''    End Using
    '''End Sub

    Public Sub InitSpamList(FileName As String)
        ' Create XmlWriterSettings.
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True
        settings.NewLineOnAttributes = True

        ' Create XmlWriter.
        Dim writer As XmlWriter
        writer = XmlWriter.Create(FileName, settings)
        '    ' Begin writing.
        writer.WriteStartDocument()
        writer.WriteStartElement("SpamList")    'Start "SpamList"
        writer.WriteStartElement("General")     'Start "General"
        writer.WriteStartElement("Item")        'Start "Item"


        ''''=== 1. Eintrag  ==================================
        '''writer.WriteStartElement("Entry")       'Start "Entry"
        '''writer.WriteElementString("OriginalText", "12Müller")
        '''writer.WriteElementString("SearchText", "12M;ller")
        '''writer.WriteEndElement()                'End "Entry"
        ''''==================================================

        ''''=== 2. Eintrag  ==================================
        '''writer.WriteStartElement("Entry")       'Start "Entry"
        '''writer.WriteElementString("OriginalText", "34Düse")
        '''writer.WriteElementString("SearchText", "34D;se")
        '''writer.WriteEndElement()                'End "Entry"
        ''''==================================================

        writer.WriteEndElement()                'End "SpamList"
        writer.WriteEndElement()                'End "General"
        writer.WriteEndElement()                'End "Item"
        writer.WriteEndDocument()
        writer.Close()
    End Sub


    Public Sub AppendSpamList(FileName As String, ElementPath As String, Element As String, Content As SpamInfo)
        Dim doc As System.Xml.XmlDocument
        Dim editor, editor2 As System.Xml.XPath.XPathNavigator
        Dim writer As System.Xml.XmlWriter

        'doc = New System.Xml.XmlDocument       ' wenn anfangs nicht "Imports System.Xml" steht 
        doc = New XmlDocument
        doc.Load(FileName)

        For Each editor In doc.CreateNavigator.Select(ElementPath)      ' z.B ("/SpamList/General")
            editor2 = editor.SelectSingleNode(Element)                  ' z.B ("Item")
            'If Not IsNothing(editor2) Then
            '    editor2.DeleteSelf()
            'End If

            writer = editor.AppendChild()
            writer.WriteStartElement(Element)
            writer.WriteElementString("OriginalText", Content._OriginalText)
            writer.WriteElementString("SearchText", Content._SearchText)
            writer.WriteEndElement()
            writer.Close()


            'SpamElement.SelectSingleNode("OriginalText") = Content._OriginalText


            ''das sieht dann so aus: <Test au_lname="A" au_fname="bcdef" />
            ''writer.WriteStartElement("Test")
            ''writer.WriteAttributeString("au_lname", "A")
            ''writer.WriteAttributeString("au_fname", "bcdef")

        Next

        doc.Save(FileName)
    End Sub

End Module
