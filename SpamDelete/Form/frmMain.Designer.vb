<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.B_AddToSPAM = New System.Windows.Forms.Button()
        Me.T_AddToSPAM = New System.Windows.Forms.TextBox()
        Me.B_ShowSpamList = New System.Windows.Forms.Button()
        Me.B_XmlReadWrite = New System.Windows.Forms.Button()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T_CheckLastDays = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_AddToSPAM
        '
        Me.B_AddToSPAM.Location = New System.Drawing.Point(12, 85)
        Me.B_AddToSPAM.Name = "B_AddToSPAM"
        Me.B_AddToSPAM.Size = New System.Drawing.Size(234, 44)
        Me.B_AddToSPAM.TabIndex = 0
        Me.B_AddToSPAM.Text = "Add to SPAM"
        Me.B_AddToSPAM.UseVisualStyleBackColor = True
        '
        'T_AddToSPAM
        '
        Me.T_AddToSPAM.Location = New System.Drawing.Point(305, 85)
        Me.T_AddToSPAM.Name = "T_AddToSPAM"
        Me.T_AddToSPAM.Size = New System.Drawing.Size(665, 31)
        Me.T_AddToSPAM.TabIndex = 1
        '
        'B_ShowSpamList
        '
        Me.B_ShowSpamList.Location = New System.Drawing.Point(12, 224)
        Me.B_ShowSpamList.Name = "B_ShowSpamList"
        Me.B_ShowSpamList.Size = New System.Drawing.Size(234, 55)
        Me.B_ShowSpamList.TabIndex = 2
        Me.B_ShowSpamList.Text = "Show SPAM list"
        Me.B_ShowSpamList.UseVisualStyleBackColor = True
        '
        'B_XmlReadWrite
        '
        Me.B_XmlReadWrite.Location = New System.Drawing.Point(25, 468)
        Me.B_XmlReadWrite.Name = "B_XmlReadWrite"
        Me.B_XmlReadWrite.Size = New System.Drawing.Size(131, 65)
        Me.B_XmlReadWrite.TabIndex = 3
        Me.B_XmlReadWrite.Text = "XML Read / Write"
        Me.B_XmlReadWrite.UseVisualStyleBackColor = True
        '
        'B_ScanEmails
        '
        Me.B_ScanEmails.Location = New System.Drawing.Point(12, 153)
        Me.B_ScanEmails.Name = "B_ScanEmails"
        Me.B_ScanEmails.Size = New System.Drawing.Size(234, 48)
        Me.B_ScanEmails.TabIndex = 4
        Me.B_ScanEmails.Text = "Scan emails"
        Me.B_ScanEmails.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(604, 181)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 31)
        Me.TextBox1.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(447, 332)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(787, 579)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1397, 40)
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
        Me.TextBox4.Location = New System.Drawing.Point(25, 678)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(405, 31)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "***********MurxSpam***************"
        '
        'T_CurrentEmail
        '
        Me.T_CurrentEmail.Location = New System.Drawing.Point(310, 181)
        Me.T_CurrentEmail.Name = "T_CurrentEmail"
        Me.T_CurrentEmail.Size = New System.Drawing.Size(266, 31)
        Me.T_CurrentEmail.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 153)
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
        Me.Label2.Location = New System.Drawing.Point(442, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Marked as SPAM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Spam marker"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 73)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(173, 332)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(232, 31)
        Me.TextBox2.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(99, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 28)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Check last x days"
        '
        'T_CheckLastDays
        '
        Me.T_CheckLastDays.Location = New System.Drawing.Point(37, 395)
        Me.T_CheckLastDays.Name = "T_CheckLastDays"
        Me.T_CheckLastDays.Size = New System.Drawing.Size(44, 31)
        Me.T_CheckLastDays.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(330, 510)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 31)
        Me.TextBox3.TabIndex = 23
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1397, 929)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.T_CheckLastDays)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_CurrentEmail)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_ScanEmails)
        Me.Controls.Add(Me.B_XmlReadWrite)
        Me.Controls.Add(Me.B_ShowSpamList)
        Me.Controls.Add(Me.T_AddToSPAM)
        Me.Controls.Add(Me.B_AddToSPAM)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Spam Delete"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_AddToSPAM As Button
    Friend WithEvents T_AddToSPAM As TextBox
    Friend WithEvents B_ShowSpamList As Button
    Friend WithEvents B_XmlReadWrite As Button
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
    Friend WithEvents Button1 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents T_CheckLastDays As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
