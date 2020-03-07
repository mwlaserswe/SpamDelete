Option Explicit On

Imports System.Xml
Imports mshtml
Public Class FrmXmlReadWrite



    '''' Storage of employee data.
    '''Public _firstName As String
    '''Public _id As Integer
    '''Public _lastName As String
    '''Public _salary As Integer



    Dim wb As New WebBrowser


    Private Sub B_InitXML_Click(sender As Object, e As EventArgs) Handles B_InitXML.Click
        Dim Result As MsgBoxStyle

        Result = MsgBox("Achtung! Der Inhalt der XML-Datei wird gelöscht!", MsgBoxStyle.OkCancel, "Spam Delete")
        If Result = vbOK Then
            InitSpamList(Application.StartupPath & "\SpamList.xml")
        End If


    End Sub

    Private Sub B_ReadXML_Click_1(sender As Object, e As EventArgs) Handles B_ReadXML.Click
        Dim Cnt As Integer
        Dim SpamTextArray() As SpamInfo
        Dim TstString As String
        Dim TstL As Integer

        ListBox1.Items.Clear()

        Cnt = ReadSpamList(Application.StartupPath & "\SpamList.xml", SpamTextArray)
        If Cnt > 0 Then

            For i = 0 To Cnt - 1

                ListBox1.Items.Add(SpamTextArray(i)._OriginalText & ": " & SpamTextArray(i)._SearchText)
            Next i

        End If

    End Sub

    Private Sub B_AppendXML_Click_1(sender As Object, e As EventArgs) Handles B_AppendXML.Click
        Dim Content As SpamInfo

        'AppendSpamList(Application.StartupPath & "\SpamList.xml", "/SpamList/General/Item", "Entry", T_TestSpamText.Text)
        Content._OriginalText = "Datum und Uhrzeit"
        Content._SearchText = Now
        AppendSpamList(Application.StartupPath & "\SpamList.xml", "/SpamList/General/Item", "Entry", Content)
    End Sub

End Class
