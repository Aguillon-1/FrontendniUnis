<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sectionFormat
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
        Me.sectionTitleName = New System.Windows.Forms.Label()
        Me.sectionPicture = New CMS_Frontend.CircularPictureBox()
        CType(Me.sectionPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(86, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 3
        '
        'sectionTitleName
        '
        Me.sectionTitleName.AutoSize = True
        Me.sectionTitleName.BackColor = System.Drawing.Color.Transparent
        Me.sectionTitleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionTitleName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sectionTitleName.Location = New System.Drawing.Point(137, 25)
        Me.sectionTitleName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sectionTitleName.Name = "sectionTitleName"
        Me.sectionTitleName.Size = New System.Drawing.Size(196, 29)
        Me.sectionTitleName.TabIndex = 5
        Me.sectionTitleName.Text = "SECTION NAME"
        '
        'sectionPicture
        '
        Me.sectionPicture.BackColor = System.Drawing.Color.DimGray
        Me.sectionPicture.Location = New System.Drawing.Point(25, 0)
        Me.sectionPicture.Name = "sectionPicture"
        Me.sectionPicture.Size = New System.Drawing.Size(83, 76)
        Me.sectionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sectionPicture.TabIndex = 9
        Me.sectionPicture.TabStop = False
        '
        'sectionFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.sectionPicture)
        Me.Controls.Add(Me.sectionTitleName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "sectionFormat"
        Me.Size = New System.Drawing.Size(370, 76)
        CType(Me.sectionPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents sectionTitleName As Label
    Friend WithEvents sectionPicture As CircularPictureBox
End Class
