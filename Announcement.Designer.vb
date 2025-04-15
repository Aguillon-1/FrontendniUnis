<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Announcement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.announcementPanel = New System.Windows.Forms.Panel()
        Me.AnnouncementFormat2 = New CMS_Frontend.AnnouncementFormat()
        Me.textBoxPanel = New System.Windows.Forms.Panel()
        Me.searchBttn = New FontAwesome.Sharp.IconButton()
        Me.filterBttn = New FontAwesome.Sharp.IconButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filterPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.announcementPanel.SuspendLayout()
        Me.textBoxPanel.SuspendLayout()
        Me.filterPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(417, 17)
        Me.TextBox1.TabIndex = 2
        '
        'announcementPanel
        '
        Me.announcementPanel.Controls.Add(Me.AnnouncementFormat2)
        Me.announcementPanel.Location = New System.Drawing.Point(38, 79)
        Me.announcementPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.announcementPanel.Name = "announcementPanel"
        Me.announcementPanel.Size = New System.Drawing.Size(1600, 887)
        Me.announcementPanel.TabIndex = 3
        '
        'AnnouncementFormat2
        '
        Me.AnnouncementFormat2.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.AnnouncementFormat2.Location = New System.Drawing.Point(-2, 2)
        Me.AnnouncementFormat2.Margin = New System.Windows.Forms.Padding(2)
        Me.AnnouncementFormat2.MaximumSize = New System.Drawing.Size(1600, 686)
        Me.AnnouncementFormat2.MinimumSize = New System.Drawing.Size(1600, 91)
        Me.AnnouncementFormat2.Name = "AnnouncementFormat2"
        Me.AnnouncementFormat2.Size = New System.Drawing.Size(1600, 91)
        Me.AnnouncementFormat2.TabIndex = 1
        '
        'textBoxPanel
        '
        Me.textBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.textBoxPanel.Controls.Add(Me.TextBox1)
        Me.textBoxPanel.Location = New System.Drawing.Point(38, 33)
        Me.textBoxPanel.Name = "textBoxPanel"
        Me.textBoxPanel.Size = New System.Drawing.Size(417, 21)
        Me.textBoxPanel.TabIndex = 2
        '
        'searchBttn
        '
        Me.searchBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.searchBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBttn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.searchBttn.IconColor = System.Drawing.Color.Black
        Me.searchBttn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.searchBttn.IconSize = 20
        Me.searchBttn.Location = New System.Drawing.Point(461, 34)
        Me.searchBttn.Name = "searchBttn"
        Me.searchBttn.Size = New System.Drawing.Size(29, 21)
        Me.searchBttn.TabIndex = 2
        Me.searchBttn.UseVisualStyleBackColor = False
        '
        'filterBttn
        '
        Me.filterBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.filterBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filterBttn.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.filterBttn.IconColor = System.Drawing.Color.Black
        Me.filterBttn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.filterBttn.IconSize = 20
        Me.filterBttn.Location = New System.Drawing.Point(496, 34)
        Me.filterBttn.Name = "filterBttn"
        Me.filterBttn.Size = New System.Drawing.Size(29, 21)
        Me.filterBttn.TabIndex = 4
        Me.filterBttn.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton1.FlatAppearance.BorderSize = 3
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(20, 19)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Admins"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posted by:"
        '
        'filterPanel
        '
        Me.filterPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filterPanel.Controls.Add(Me.Label1)
        Me.filterPanel.Controls.Add(Me.RadioButton1)
        Me.filterPanel.Controls.Add(Me.RadioButton3)
        Me.filterPanel.Controls.Add(Me.RadioButton2)
        Me.filterPanel.Location = New System.Drawing.Point(531, 34)
        Me.filterPanel.Name = "filterPanel"
        Me.filterPanel.Size = New System.Drawing.Size(102, 98)
        Me.filterPanel.TabIndex = 4
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton3.FlatAppearance.BorderSize = 3
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(20, 44)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(74, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Registrar"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton2.FlatAppearance.BorderSize = 3
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(20, 69)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Officers"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Announcement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.filterPanel)
        Me.Controls.Add(Me.filterBttn)
        Me.Controls.Add(Me.textBoxPanel)
        Me.Controls.Add(Me.searchBttn)
        Me.Controls.Add(Me.announcementPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1681, 978)
        Me.MinimumSize = New System.Drawing.Size(1681, 978)
        Me.Name = "Announcement"
        Me.Size = New System.Drawing.Size(1681, 978)
        Me.announcementPanel.ResumeLayout(False)
        Me.textBoxPanel.ResumeLayout(False)
        Me.textBoxPanel.PerformLayout()
        Me.filterPanel.ResumeLayout(False)
        Me.filterPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AnnouncementFormat2 As AnnouncementFormat
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents announcementPanel As Panel
    Friend WithEvents textBoxPanel As Panel
    Friend WithEvents searchBttn As FontAwesome.Sharp.IconButton
    Friend WithEvents filterBttn As FontAwesome.Sharp.IconButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents filterPanel As FlowLayoutPanel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
