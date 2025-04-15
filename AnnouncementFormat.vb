Public Class AnnouncementFormat

    Dim clicked As Boolean = True
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles titleLbl.Click

    End Sub

    Private Sub seeMoreTimer_Tick(sender As Object, e As EventArgs) Handles seeMoreTimer.Tick
        If (clicked = True) Then
            Height += 35
            If (Height >= MaximumSize.Height) Then
                seeMoreTimer.Stop()
                clicked = False
            End If
        Else
            Height -= 35
            If (Height <= MinimumSize.Height) Then
                seeMoreTimer.Stop()
                clicked = True
            End If
        End If
    End Sub

    Private Sub AnnouncementFormat_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        seeMoreTimer.Start()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim del = New Delete
        del.Show()
    End Sub
End Class
