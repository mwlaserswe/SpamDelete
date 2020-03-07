<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmXmlReadWrite
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.B_AppendXML = New System.Windows.Forms.Button()
        Me.B_ReadXML = New System.Windows.Forms.Button()
        Me.B_InitXML = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(37, 111)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(496, 254)
        Me.ListBox1.TabIndex = 4
        '
        'B_AppendXML
        '
        Me.B_AppendXML.Location = New System.Drawing.Point(208, 23)
        Me.B_AppendXML.Name = "B_AppendXML"
        Me.B_AppendXML.Size = New System.Drawing.Size(155, 62)
        Me.B_AppendXML.TabIndex = 24
        Me.B_AppendXML.Text = "Append XML"
        Me.B_AppendXML.UseVisualStyleBackColor = True
        '
        'B_ReadXML
        '
        Me.B_ReadXML.Location = New System.Drawing.Point(37, 23)
        Me.B_ReadXML.Name = "B_ReadXML"
        Me.B_ReadXML.Size = New System.Drawing.Size(155, 62)
        Me.B_ReadXML.TabIndex = 23
        Me.B_ReadXML.Text = "Read XML"
        Me.B_ReadXML.UseVisualStyleBackColor = True
        '
        'B_InitXML
        '
        Me.B_InitXML.Location = New System.Drawing.Point(378, 23)
        Me.B_InitXML.Name = "B_InitXML"
        Me.B_InitXML.Size = New System.Drawing.Size(155, 62)
        Me.B_InitXML.TabIndex = 22
        Me.B_InitXML.Text = "Init XML"
        Me.B_InitXML.UseVisualStyleBackColor = True
        '
        'FrmXmlReadWrite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 397)
        Me.Controls.Add(Me.B_AppendXML)
        Me.Controls.Add(Me.B_ReadXML)
        Me.Controls.Add(Me.B_InitXML)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "FrmXmlReadWrite"
        Me.Text = "XML Read / Write"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents B_AppendXML As Button
    Friend WithEvents B_ReadXML As Button
    Friend WithEvents B_InitXML As Button
End Class
