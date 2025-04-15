Public Class NoteFormat
    Private Sub NoteFormat_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.Click
        Dim notepreview = New NoteView
        notepreview.Show()
    End Sub

    Private Sub NoteFormat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim del = New Delete
        del.Show()
    End Sub
End Class
