Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub


    Private Sub B_ShowSpamList_Click(sender As Object, e As EventArgs) Handles B_ShowSpamList.Click

        Dim myPath As String = "Notepad++.exe"

        Dim pr As New Process

        pr.StartInfo.FileName = myPath

        pr.StartInfo.Arguments = """" & Application.StartupPath & "\SpamList.xml" & """"

        pr.Start()

    End Sub


    '   C:\Users\Weing\AppData\Local\Microsoft\Windows Live Mail\Mwlaser (we 28a\MyVbTestSpam



    Private Sub B_XmlReadWrite_Click(sender As Object, e As EventArgs) Handles B_XmlReadWrite.Click
        frmXmlReadWrite.Show()
    End Sub

    Private Sub B_AddToSPAM_Click(sender As Object, e As EventArgs) Handles B_AddToSPAM.Click
        Dim Content As SpamInfo

        Content._OriginalText = "Größe"
        Content._SearchText = "Gr;;e"
        AppendSpamList(Application.StartupPath & "\SpamList.xml", "/SpamList/General/Item", "Entry", Content)
    End Sub

    Private Sub B_ScanEmails_Click(sender As Object, e As EventArgs) Handles B_ScanEmails.Click
        Dim FullPath As String
        Dim Result As Integer

        SpamListCnt = ReadSpamList(Application.StartupPath & "\SpamList.xml", SpamTextArray)

        ' Verzeichnis, dessen Dateien ermittelt werden sollen
        Dim sPath As String

        ' ggf. abschließenden Backslash entfernen
        sPath = "C:\Users\Weing\AppData\Local\Microsoft\Windows Live Mail\Mwlaser (we 28a\MyVbTestSpam\"
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
            FullPath = sPath & "/" & oFile.Name

            Result = ScanEmail(FullPath)
            If Result > 0 Then
                ListBox1.Items.Add(oFile.Name)
            End If
        Next






        'FullPath = "C:\Users\Weing\AppData\Local\Microsoft\Windows Live Mail\Mwlaser (we 28a\MyVbTestSpam\1AD54E1A-00000001.eml"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '''' Verzeichnis, dessen Dateien ermittelt werden sollen
        '''Dim sPath As String

        '''' ggf. abschließenden Backslash entfernen
        '''sPath = "C:\Users\Weing\AppData\Local\Microsoft\Windows Live Mail\Mwlaser (we 28a\MyVbTestSpam\"
        '''If sPath.EndsWith("\") And sPath.Length > 3 Then
        '''    sPath = sPath.Substring(0, sPath.Length - 1)
        '''End If

        '''' Directory-Object erstellen
        '''Dim oDir As New System.IO.DirectoryInfo(sPath)

        '''' alle Dateien des Ordners
        '''Dim oFiles As System.IO.FileInfo() = oDir.GetFiles()

        '''' Datei-Array durchlaufen und in 
        '''' ListBox übertragen
        '''Dim oFile As System.IO.FileInfo
        '''ListBox1.Items.Clear
        '''For Each oFile In oFiles
        '''    ListBox1.Items.Add(oFile.Name)
        '''Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.FileSystem.MoveFile("C:\TestDir1\test.txt", "C:\TestDir2\test.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Input As String
        Dim a As Integer
        Dim NewString As String

        NewString = ""
        Input = TextBox2.Text
        For Each c As Char In Input.ToCharArray 'Input ist ein String

            If Not Char.IsLetter(c) _
                Or c = "Ä" _
                Or c = "ä" _
                Or c = "Ö" _
                Or c = "ö" _
                Or c = "Ü" _
                Or c = "ü" _
                Or c = "ß" _
            Then

                NewString = NewString & ";"
            Else
                NewString = NewString & c
            End If

        Next

        TextBox3.Text = NewString

    End Sub
End Class