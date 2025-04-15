Public Class Announcement

    Dim filterclick As Boolean = True

    Public Sub New()

        InitializeComponent()
        filterPanel.Hide()
        textBoxPanel.BackColor = Color.Transparent

    End Sub

    Private Sub textBoxPanel_Paint(sender As Object, e As PaintEventArgs) Handles textBoxPanel.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub filterBttn_Click(sender As Object, e As EventArgs) Handles filterBttn.Click
        textBoxPanel.BackColor = Color.Transparent
        If (filterclick = True) Then
            filterPanel.Show()
            filterclick = False
        Else
            filterPanel.Hide()
            filterclick = True
        End If
    End Sub

    Private Sub Announcement_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        filterPanel.Hide()
        textBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub AnnouncementFormat2_MouseClick(sender As Object, e As MouseEventArgs) Handles AnnouncementFormat2.MouseClick
        filterPanel.Hide()
        textBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub announcementPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles announcementPanel.MouseClick
        filterPanel.Hide()
        textBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub searchBttn_Click(sender As Object, e As EventArgs) Handles searchBttn.Click
        filterPanel.Hide()
        textBoxPanel.BackColor = Color.Transparent
    End Sub

    Private Sub textBoxPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles textBoxPanel.MouseClick

    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        textBoxPanel.BackColor = System.Drawing.SystemColors.Highlight
    End Sub
End Class
