Option Explicit On

Imports System.IO

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpamDirectoryDest = My.Settings.SpamDirectoryDest
        SpamDirectorySource = My.Settings.SpamDirectorySource
    End Sub


    Private Sub B_ShowSpamList_Click(sender As Object, e As EventArgs) Handles B_ShowSpamList.Click

        Dim myPath As String = "Notepad++.exe"

        Dim pr As New Process

        pr.StartInfo.FileName = myPath

        pr.StartInfo.Arguments = """" & Application.StartupPath & "\SpamList.xml" & """"

        pr.Start()

    End Sub


    Private Sub B_XmlReadWrite_Click(sender As Object, e As EventArgs) Handles B_XmlReadWrite.Click
        FrmXmlReadWrite.Show()
    End Sub


    Private Sub B_AddToSPAM_Click(sender As Object, e As EventArgs) Handles B_AddToSPAM.Click
        Dim Content As SpamInfo

        Content._OriginalText = T_AddToSPAM.Text
        Content._SearchText = ConvertOriginalToSearchText(T_AddToSPAM.Text)
        AppendSpamList(Application.StartupPath & "\SpamList.xml", "/SpamList/General/Item", "Entry", Content)
    End Sub


    Private Sub B_ScanEmails_Click(sender As Object, e As EventArgs) Handles B_ScanEmails.Click
        Dim FullPath As String
        Dim Result As Integer

        SpamListCnt = ReadSpamList(Application.StartupPath & "\SpamList.xml", SpamTextArray)

        ' Verzeichnis, dessen Dateien ermittelt werden sollen
        Dim sPath As String

        ' ggf. abschließenden Backslash entfernen
        sPath = SpamDirectorySource
        If sPath.EndsWith("\") And sPath.Length > 3 Then
            sPath = sPath.Substring(0, sPath.Length - 1)
        End If

        ' Directory-Object erstellen
        Dim oDir As New System.IO.DirectoryInfo(sPath)

        ' alle Dateien des Ordners
        Dim oFiles As System.IO.FileInfo() = oDir.GetFiles()

        ' Datei-Array durchlaufen und in 
        ' ListBox übertragen
        Dim oFile As System.IO.FileInfo
        ListBox1.Items.Clear()

        For Each oFile In oFiles
            FullPath = Path.Combine(sPath, oFile.Name)

            Result = ScanEmail(FullPath)
            If Result > 0 Then
                ListBox1.Items.Add(oFile.Name)
                'My.Computer.FileSystem.MoveFile(Path.Combine(SpamDirectorySource, oFile.Name), Path.Combine(SpamDirectoryDest, oFile.Name))
                ReplaceSubject(Path.Combine(SpamDirectorySource, oFile.Name))
                Application.DoEvents()
            End If
        Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        My.Computer.FileSystem.MoveFile("C:\TestDir1\test.txt", "C:\TestDir2\test.txt")
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FileName As String
        OpenFileDialog1.ShowDialog()
        FileName = OpenFileDialog1.FileName
    End Sub


    Private Sub EmailDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailDirectoryToolStripMenuItem.Click
        Dim LclFileName As String
        OpenFileDialog1.ShowDialog()
        LclFileName = OpenFileDialog1.FileName
        SpamDirectorySource = IO.Path.GetDirectoryName(LclFileName)
        My.Settings.SpamDirectorySource = SpamDirectorySource
        My.Settings.Save()
    End Sub


    Private Sub SpamDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpamDirectoryToolStripMenuItem.Click
        Dim LclFileName As String
        OpenFileDialog1.ShowDialog()
        LclFileName = OpenFileDialog1.FileName
        SpamDirectoryDest = IO.Path.GetDirectoryName(LclFileName)
        My.Settings.SpamDirectoryDest = SpamDirectoryDest
        My.Settings.Save()
    End Sub

End Class