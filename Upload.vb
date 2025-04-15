Public Class Upload

    Public Sub New()

        InitializeComponent()
        NoteUploadConfirmation1.Hide()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles titleLbl.Click

    End Sub

    Private Sub postButton_Click(sender As Object, e As EventArgs) Handles postButton.Click
        NoteUploadConfirmation1.BringToFront()
        NoteUploadConfirmation1.Show()
    End Sub
End Class
