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
        Me.B_AddToSPAM = New System.Windows.Forms.Button()
        Me.T_AddToSPAM = New System.Windows.Forms.TextBox()
        Me.B_ShowSpamList = New System.Windows.Forms.Button()
        Me.B_XmlReadWrite = New System.Windows.Forms.Button()
        Me.B_ScanEmails = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpamDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
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
        Me.TextBox1.Location = New System.Drawing.Point(507, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(435, 224)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(535, 429)
        Me.ListBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(5, 795)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(965, 31)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "ABCDE"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(5, 852)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(965, 31)
        Me.TextBox3.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(244, 489)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 74)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 40)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailDirectoryToolStripMenuItem, Me.SpamDirectoryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EmailDirectoryToolStripMenuItem
        '
        Me.EmailDirectoryToolStripMenuItem.Name = "EmailDirectoryToolStripMenuItem"
        Me.EmailDirectoryToolStripMenuItem.Size = New System.Drawing.Size(313, 44)
        Me.EmailDirectoryToolStripMenuItem.Text = "Email Directory"
        '
        'SpamDirectoryToolStripMenuItem
        '
        Me.SpamDirectoryToolStripMenuItem.Name = "SpamDirectoryToolStripMenuItem"
        Me.SpamDirectoryToolStripMenuItem.Size = New System.Drawing.Size(313, 44)
        Me.SpamDirectoryToolStripMenuItem.Text = "Spam Directory"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(25, 678)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(405, 31)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "***********MurxSpam***************"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 929)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpamDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox4 As TextBox
End Class
