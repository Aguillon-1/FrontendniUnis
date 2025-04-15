<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Me.CircularPictureBox2 = New CMS_Frontend.CircularPictureBox()
        Me.CircularPictureBox1 = New CMS_Frontend.CircularPictureBox()
        CType(Me.CircularPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(88, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(89, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Role"
        '
        'CircularPictureBox2
        '
        Me.CircularPictureBox2.Image = Global.CMS_Frontend.My.Resources.Resources.Ellipse_1
        Me.CircularPictureBox2.Location = New System.Drawing.Point(9, 9)
        Me.CircularPictureBox2.Name = "CircularPictureBox2"
        Me.CircularPictureBox2.Size = New System.Drawing.Size(71, 64)
        Me.CircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CircularPictureBox2.TabIndex = 4
        Me.CircularPictureBox2.TabStop = False
        '
        'CircularPictureBox1
        '
        Me.CircularPictureBox1.Location = New System.Drawing.Point(11, 13)
        Me.CircularPictureBox1.Name = "CircularPictureBox1"
        Me.CircularPictureBox1.Size = New System.Drawing.Size(71, 64)
        Me.CircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CircularPictureBox1.TabIndex = 3
        Me.CircularPictureBox1.TabStop = False
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CircularPictureBox2)
        Me.Controls.Add(Me.CircularPictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserProfile"
        Me.Size = New System.Drawing.Size(247, 80)
        CType(Me.CircularPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CircularPictureBox1 As CircularPictureBox
    Friend WithEvents CircularPictureBox2 As CircularPictureBox
End Class
