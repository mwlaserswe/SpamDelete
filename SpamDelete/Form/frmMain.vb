Option Explicit On

Imports System.IO

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SpamDirectorySource = My.Settings.SpamDirectorySource
        T_CheckLastDays.Text = My.Settings.NumberOfDays
        Grp_Modify.Visible = False
    End Sub



    Private Sub B_ShowSpamList_Click_1(sender As Object, e As EventArgs) Handles B_ShowSpamList.Click

        Dim myPath As String = "Notepad++.exe"

        Dim pr As New Process

        pr.StartInfo.FileName = myPath

        pr.StartInfo.Arguments = """" & Application.StartupPath & "\SpamList.xml" & """"

        pr.Start()

    End Sub


    Private Sub B_XmlReadWrite_Click_1(sender As Object, e As EventArgs) Handles B_XmlReadWrite.Click
        FrmXmlReadWrite.Show()
    End Sub


    Private Sub B_AddToSPAM_Click_1(sender As Object, e As EventArgs) Handles B_AddToSPAM.Click
        Dim Content As SpamInfo

        Content._OriginalText = T_AddToSPAM.Text
        Content._SearchText = ConvertOriginalToSearchText(T_AddToSPAM.Text)
        AppendSpamList(Application.StartupPath & "\SpamList.xml", "/SpamList/General/Item", "Entry", Content)
    End Sub

    '''Private Function IsFileYounger(FileName) As Boolean
    '''    Dim TageszahlInDatum As String
    '''    Dim DateIdx As Integer

    '''    TageszahlInDatum = DateAdd("d", DateIdx - 1, "1.1.2000")
    '''End Function


    Private Sub B_ScanEmails_Click(sender As Object, e As EventArgs) Handles B_ScanEmails.Click
        Dim FullPath As String
        Dim Result As Integer
        Dim InfoText As String


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

        InfoText = ""

        For Each oFile In oFiles
            FullPath = Path.Combine(sPath, oFile.Name)

            'InfoText = oFile.Name

            'TextBox2.Text = System.IO.File.GetCreationTime(FullPath)
            'TextBox2.Text = System.IO.File.GetLastWriteTime(FullPath)

            Dim FileDate As Date
            Dim LastDate As Date
            Dim DateDiff As Integer
            FileDate = File.GetLastWriteTime(FullPath)
            LastDate = DateAdd("d", -T_CheckLastDays.Text, Today)
            DateDiff = DateTime.Compare(FileDate, LastDate)
            'DateDiff = DateAndTime.DateDiff(DateInterval.Day, FileDate, LastDate)

            InfoText = FileDate & " " & oFile.Name

            If DateDiff > 0 Then


                T_CurrentEmail.Text = oFile.Name
                Application.DoEvents()

                Result = ScanEmail(FullPath)
                If Result > 0 Then
                    InfoText = InfoText & " ==> SPAM"

                    'My.Computer.FileSystem.MoveFile(Path.Combine(SpamDirectorySource, oFile.Name), Path.Combine(SpamDirectoryDest, oFile.Name))
                    ReplaceSubject(Path.Combine(SpamDirectorySource, oFile.Name))
                    Application.DoEvents()
                Else
                    InfoText = InfoText & " ==> ok"
                End If

                ListBox1.Items.Add(InfoText)

            Else
                InfoText = InfoText & "."
            End If

            'ListBox1.Items.Add(InfoText)
        Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        My.Computer.FileSystem.MoveFile("C:\TestDir1\test.txt", "C:\TestDir2\test.txt")
    End Sub


    Private Sub EmailDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailDirectoryToolStripMenuItem.Click
        FolderBrowserDialog1.SelectedPath = SpamDirectorySource
        FolderBrowserDialog1.Description = "Bitte die Inbox von Windows Live Mail wählen"
        FolderBrowserDialog1.ShowDialog()
        SpamDirectorySource = FolderBrowserDialog1.SelectedPath

        My.Settings.SpamDirectorySource = SpamDirectorySource
        My.Settings.Save()
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = NumberLinesScanned & " Lines"
    End Sub

    Private Sub T_CheckLastDays_TextChanged(sender As Object, e As EventArgs) Handles T_CheckLastDays.TextChanged
        If IsNumeric(T_CheckLastDays.Text) Then
            Select Case T_CheckLastDays.Text
                Case 0
                    Label4.Text = "Check today only"
                Case 1
                    Label4.Text = "Check yesterday and today"
                Case Else
                    Label4.Text = "Check last " & T_CheckLastDays.Text & " days"
            End Select

            My.Settings.NumberOfDays = CInt(T_CheckLastDays.Text)
            My.Settings.Save()
        End If

    End Sub

    Private Sub Ch_ModifySpamList_CheckedChanged(sender As Object, e As EventArgs) Handles Ch_ModifySpamList.CheckedChanged
        Grp_Modify.Visible = Ch_ModifySpamList.Checked
    End Sub


End Class