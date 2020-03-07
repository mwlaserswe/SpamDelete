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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B_AddToSPAM
        '
        Me.B_AddToSPAM.Location = New System.Drawing.Point(12, 85)
        Me.B_AddToSPAM.Name = "B_AddToSPAM"
        Me.B_AddToSPAM.Size = New System.Drawing.Size(120, 44)
        Me.B_AddToSPAM.TabIndex = 0
        Me.B_AddToSPAM.Text = "Add to SPAM"
        Me.B_AddToSPAM.UseVisualStyleBackColor = True
        '
        'T_AddToSPAM
        '
        Me.T_AddToSPAM.Location = New System.Drawing.Point(178, 85)
        Me.T_AddToSPAM.Name = "T_AddToSPAM"
        Me.T_AddToSPAM.Size = New System.Drawing.Size(665, 31)
        Me.T_AddToSPAM.TabIndex = 1
        Me.T_AddToSPAM.Text = "DemoSpam"
        '
        'B_ShowSpamList
        '
        Me.B_ShowSpamList.Location = New System.Drawing.Point(12, 284)
        Me.B_ShowSpamList.Name = "B_ShowSpamList"
        Me.B_ShowSpamList.Size = New System.Drawing.Size(144, 67)
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
        Me.B_ScanEmails.Size = New System.Drawing.Size(120, 61)
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
        Me.ListBox1.Size = New System.Drawing.Size(535, 529)
        Me.ListBox1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 69)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Move file"
        Me.Button2.UseVisualStyleBackColor = True
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 730)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(270, 44)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "String aufbereiten"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 929)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_ScanEmails)
        Me.Controls.Add(Me.B_XmlReadWrite)
        Me.Controls.Add(Me.B_ShowSpamList)
        Me.Controls.Add(Me.T_AddToSPAM)
        Me.Controls.Add(Me.B_AddToSPAM)
        Me.Name = "FrmMain"
        Me.Text = "Spam Delete"
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
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
End Class
