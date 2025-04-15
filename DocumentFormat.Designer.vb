<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentFormat
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.deleteButton = New FontAwesome.Sharp.IconButton()
        Me.downloadButton = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date"
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Transparent
        Me.deleteButton.FlatAppearance.BorderSize = 0
        Me.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.ForeColor = System.Drawing.Color.DarkRed
        Me.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.deleteButton.IconColor = System.Drawing.Color.DarkRed
        Me.deleteButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.deleteButton.IconSize = 23
        Me.deleteButton.Location = New System.Drawing.Point(307, 89)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(28, 27)
        Me.deleteButton.TabIndex = 10
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'downloadButton
        '
        Me.downloadButton.BackColor = System.Drawing.Color.Transparent
        Me.downloadButton.FlatAppearance.BorderSize = 0
        Me.downloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.downloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadButton.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.downloadButton.IconColor = System.Drawing.Color.Black
        Me.downloadButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.downloadButton.IconSize = 25
        Me.downloadButton.Location = New System.Drawing.Point(273, 89)
        Me.downloadButton.Name = "downloadButton"
        Me.downloadButton.Size = New System.Drawing.Size(28, 27)
        Me.downloadButton.TabIndex = 9
        Me.downloadButton.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.IconButton1.Enabled = False
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.File
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(16, 19)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(84, 79)
        Me.IconButton1.TabIndex = 6
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'DocumentFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.downloadButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconButton1)
        Me.Margin = New System.Windows.Forms.Padding(15)
        Me.Name = "DocumentFormat"
        Me.Size = New System.Drawing.Size(350, 119)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents downloadButton As FontAwesome.Sharp.IconButton
    Friend WithEvents deleteButton As FontAwesome.Sharp.IconButton
End Class
