<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.notifPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoteNotifFormat1 = New CMS_Frontend.noteNotifFormat()
        Me.AnnouncementNotifFormat1 = New CMS_Frontend.announcementNotifFormat()
        Me.ModifiedNotifFormat1 = New CMS_Frontend.ModifiedNotifFormat()
        Me.notifPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'notifPanel
        '
        Me.notifPanel.AutoScroll = True
        Me.notifPanel.Controls.Add(Me.ModifiedNotifFormat1)
        Me.notifPanel.Controls.Add(Me.NoteNotifFormat1)
        Me.notifPanel.Controls.Add(Me.AnnouncementNotifFormat1)
        Me.notifPanel.Location = New System.Drawing.Point(12, 39)
        Me.notifPanel.Name = "notifPanel"
        Me.notifPanel.Size = New System.Drawing.Size(468, 209)
        Me.notifPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOTIFICATION"
        '
        'NoteNotifFormat1
        '
        Me.NoteNotifFormat1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NoteNotifFormat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoteNotifFormat1.Dock = System.Windows.Forms.DockStyle.Top
        Me.NoteNotifFormat1.Location = New System.Drawing.Point(0, 83)
        Me.NoteNotifFormat1.Name = "NoteNotifFormat1"
        Me.NoteNotifFormat1.Size = New System.Drawing.Size(451, 93)
        Me.NoteNotifFormat1.TabIndex = 1
        '
        'AnnouncementNotifFormat1
        '
        Me.AnnouncementNotifFormat1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AnnouncementNotifFormat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AnnouncementNotifFormat1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AnnouncementNotifFormat1.Location = New System.Drawing.Point(0, 0)
        Me.AnnouncementNotifFormat1.Margin = New System.Windows.Forms.Padding(0)
        Me.AnnouncementNotifFormat1.Name = "AnnouncementNotifFormat1"
        Me.AnnouncementNotifFormat1.Size = New System.Drawing.Size(451, 83)
        Me.AnnouncementNotifFormat1.TabIndex = 0
        '
        'ModifiedNotifFormat1
        '
        Me.ModifiedNotifFormat1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ModifiedNotifFormat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ModifiedNotifFormat1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModifiedNotifFormat1.Location = New System.Drawing.Point(0, 176)
        Me.ModifiedNotifFormat1.Name = "ModifiedNotifFormat1"
        Me.ModifiedNotifFormat1.Size = New System.Drawing.Size(451, 91)
        Me.ModifiedNotifFormat1.TabIndex = 2
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(492, 260)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.notifPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notification"
        Me.Text = "Notification"
        Me.notifPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents notifPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AnnouncementNotifFormat1 As announcementNotifFormat
    Friend WithEvents NoteNotifFormat1 As noteNotifFormat
    Friend WithEvents ModifiedNotifFormat1 As ModifiedNotifFormat
End Class
