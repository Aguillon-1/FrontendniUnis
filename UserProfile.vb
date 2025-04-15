Public Class UserProfile

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserProfile_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim user = New Profile
        user.Show()
        user.Location = New Point(1595, 0)
    End Sub

    Private Sub UserProfile_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub UserProfile_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover

    End Sub

    Private Sub UserProfile_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
    End Sub
End Class
