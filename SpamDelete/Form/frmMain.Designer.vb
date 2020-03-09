<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.B_ScanEmails = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.T_CurrentEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T_CheckLastDays = New System.Windows.Forms.TextBox()
        Me.Grp_Modify = New System.Windows.Forms.GroupBox()
        Me.B_XmlReadWrite = New System.Windows.Forms.Button()
        Me.B_ShowSpamList = New System.Windows.Forms.Button()
        Me.T_AddToSPAM = New System.Windows.Forms.TextBox()
        Me.B_AddToSPAM = New System.Windows.Forms.Button()
        Me.Ch_ModifySpamList = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Grp_Modify.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_ScanEmails
        '
        Me.B_ScanEmails.Location = New System.Drawing.Point(37, 69)
        Me.B_ScanEmails.Name = "B_ScanEmails"
        Me.B_ScanEmails.Size = New System.Drawing.Size(234, 120)
        Me.B_ScanEmails.TabIndex = 4
        Me.B_ScanEmails.Text = "Scan emails"
        Me.B_ScanEmails.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(328, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 31)
        Me.TextBox1.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(510, 109)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(602, 454)
        Me.ListBox1.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1136, 40)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailDirectoryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EmailDirectoryToolStripMenuItem
        '
        Me.EmailDirectoryToolStripMenuItem.Name = "EmailDirectoryToolStripMenuItem"
        Me.EmailDirectoryToolStripMenuItem.Size = New System.Drawing.Size(310, 44)
        Me.EmailDirectoryToolStripMenuItem.Text = "Email Directory"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(37, 519)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(405, 31)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "***********MurxSpam***************"
        '
        'T_CurrentEmail
        '
        Me.T_CurrentEmail.Location = New System.Drawing.Point(37, 245)
        Me.T_CurrentEmail.Name = "T_CurrentEmail"
        Me.T_CurrentEmail.Size = New System.Drawing.Size(266, 31)
        Me.T_CurrentEmail.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "scanning email..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Marked as SPAM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 482)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Spam marker"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(104, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 28)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Check last x days"
        '
        'T_CheckLastDays
        '
        Me.T_CheckLastDays.Location = New System.Drawing.Point(37, 313)
        Me.T_CheckLastDays.Name = "T_CheckLastDays"
        Me.T_CheckLastDays.Size = New System.Drawing.Size(44, 31)
        Me.T_CheckLastDays.TabIndex = 22
        '
        'Grp_Modify
        '
        Me.Grp_Modify.Controls.Add(Me.B_XmlReadWrite)
        Me.Grp_Modify.Controls.Add(Me.B_ShowSpamList)
        Me.Grp_Modify.Controls.Add(Me.T_AddToSPAM)
        Me.Grp_Modify.Controls.Add(Me.B_AddToSPAM)
        Me.Grp_Modify.Location = New System.Drawing.Point(37, 588)
        Me.Grp_Modify.Name = "Grp_Modify"
        Me.Grp_Modify.Size = New System.Drawing.Size(1075, 309)
        Me.Grp_Modify.TabIndex = 23
        Me.Grp_Modify.TabStop = False
        Me.Grp_Modify.Text = "Modify"
        '
        'B_XmlReadWrite
        '
        Me.B_XmlReadWrite.Location = New System.Drawing.Point(291, 202)
        Me.B_XmlReadWrite.Name = "B_XmlReadWrite"
        Me.B_XmlReadWrite.Size = New System.Drawing.Size(235, 65)
        Me.B_XmlReadWrite.TabIndex = 6
        Me.B_XmlReadWrite.Text = "XML Read / Write"
        Me.B_XmlReadWrite.UseVisualStyleBackColor = True
        '
        'B_ShowSpamList
        '
        Me.B_ShowSpamList.Location = New System.Drawing.Point(32, 202)
        Me.B_ShowSpamList.Name = "B_ShowSpamList"
        Me.B_ShowSpamList.Size = New System.Drawing.Size(232, 65)
        Me.B_ShowSpamList.TabIndex = 5
        Me.B_ShowSpamList.Text = "Show SPAM list"
        Me.B_ShowSpamList.UseVisualStyleBackColor = True
        '
        'T_AddToSPAM
        '
        Me.T_AddToSPAM.Location = New System.Drawing.Point(199, 65)
        Me.T_AddToSPAM.Name = "T_AddToSPAM"
        Me.T_AddToSPAM.Size = New System.Drawing.Size(848, 31)
        Me.T_AddToSPAM.TabIndex = 4
        '
        'B_AddToSPAM
        '
        Me.B_AddToSPAM.Location = New System.Drawing.Point(30, 58)
        Me.B_AddToSPAM.Name = "B_AddToSPAM"
        Me.B_AddToSPAM.Size = New System.Drawing.Size(163, 44)
        Me.B_AddToSPAM.TabIndex = 3
        Me.B_AddToSPAM.Text = "Add to SPAM"
        Me.B_AddToSPAM.UseVisualStyleBackColor = True
        '
        'Ch_ModifySpamList
        '
        Me.Ch_ModifySpamList.AutoSize = True
        Me.Ch_ModifySpamList.Location = New System.Drawing.Point(37, 414)
        Me.Ch_ModifySpamList.Name = "Ch_ModifySpamList"
        Me.Ch_ModifySpamList.Size = New System.Drawing.Size(207, 29)
        Me.Ch_ModifySpamList.TabIndex = 7
        Me.Ch_ModifySpamList.Text = "Modify SPAM list"
        Me.Ch_ModifySpamList.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 922)
        Me.Controls.Add(Me.Ch_ModifySpamList)
        Me.Controls.Add(Me.Grp_Modify)
        Me.Controls.Add(Me.T_CheckLastDays)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_CurrentEmail)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_ScanEmails)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Spam Delete"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Grp_Modify.ResumeLayout(False)
        Me.Grp_Modify.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_ScanEmails As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents T_CurrentEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents T_CheckLastDays As TextBox
    Friend WithEvents Grp_Modify As GroupBox
    Friend WithEvents B_XmlReadWrite As Button
    Friend WithEvents B_ShowSpamList As Button
    Friend WithEvents T_AddToSPAM As TextBox
    Friend WithEvents B_AddToSPAM As Button
    Friend WithEvents Ch_ModifySpamList As CheckBox
End Class
