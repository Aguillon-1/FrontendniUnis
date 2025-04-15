<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class officerFormat
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
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.positionLbl = New System.Windows.Forms.Label()
        Me.userPic = New CMS_Frontend.CircularPictureBox()
        CType(Me.userPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.Location = New System.Drawing.Point(62, 11)
        Me.nameLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(44, 16)
        Me.nameLbl.TabIndex = 2
        Me.nameLbl.Text = "Name"
        '
        'positionLbl
        '
        Me.positionLbl.AutoSize = True
        Me.positionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionLbl.Location = New System.Drawing.Point(61, 32)
        Me.positionLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.positionLbl.Name = "positionLbl"
        Me.positionLbl.Size = New System.Drawing.Size(51, 15)
        Me.positionLbl.TabIndex = 3
        Me.positionLbl.Text = "Position"
        '
        'userPic
        '
        Me.userPic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.userPic.Location = New System.Drawing.Point(6, 3)
        Me.userPic.Name = "userPic"
        Me.userPic.Size = New System.Drawing.Size(51, 50)
        Me.userPic.TabIndex = 5
        Me.userPic.TabStop = False
        '
        'officerFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.userPic)
        Me.Controls.Add(Me.positionLbl)
        Me.Controls.Add(Me.nameLbl)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "officerFormat"
        Me.Size = New System.Drawing.Size(354, 57)
        CType(Me.userPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLbl As Label
    Friend WithEvents positionLbl As Label
    Friend WithEvents userPic As CircularPictureBox
End Class
