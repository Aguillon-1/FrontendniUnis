Imports FontAwesome.Sharp

Public Class FinalMainForm

    Dim pullUpGeneral As Boolean = True
    Dim dropDownSections As Boolean = True
    Dim buttonNo As Integer

    Private currentBtn As IconButton
    Public Sub New()

        InitializeComponent()
        sectionPanel.Hide()
        Announcement1.Hide()
        SectionFormat1.Hide()
        Notes1.Hide()
        Upload1.Hide()
        Section1.Hide()
        Home1.BringToFront()
        Documents1.Hide()
        Grades1.Hide()
        homeButton.BackColor = Color.FromArgb(93, 242, 167)
        homePanelU.BackColor = Color.FromArgb(109, 206, 39)
        homePanelB.BackColor = Color.FromArgb(109, 206, 39)


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub exitButton_Click_1(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim ex = New FinalExit()
        ex.Show()
    End Sub

    Private Sub generalButton_Click(sender As Object, e As EventArgs) Handles generalButton.Click
        generalDropDownTimer.Start()
    End Sub

    Private Sub sectionButton_Click(sender As Object, e As EventArgs) Handles sectionButton.Click
        sectionDropDownTimer.Start()
    End Sub

    Private Sub generalDropDownTimer_Tick(sender As Object, e As EventArgs) Handles generalDropDownTimer.Tick
        If (pullUpGeneral = True) Then
            generalButton.Image = My.Resources.dropdown
            generalPanel.Height -= 20
            If (generalPanel.Height <= generalPanel.MinimumSize.Height) Then
                generalDropDownTimer.Stop()
                pullUpGeneral = False
                generalPanel.Hide()
            End If
        Else
            generalButton.Image = My.Resources.white_pullup
            generalPanel.Show()
            generalPanel.Height += 20
            If (generalPanel.Height >= generalPanel.MaximumSize.Height) Then
                generalDropDownTimer.Stop()
                pullUpGeneral = True

            End If

        End If
    End Sub

    Private Sub sectionDropDownTimer_Tick(sender As Object, e As EventArgs) Handles sectionDropDownTimer.Tick
        sectionPanel.Show()
        If (dropDownSections = True) Then
            sectionButton.Image = My.Resources.white_pullup
            sectionPanel.Height += 20
            If (sectionPanel.Height >= sectionPanel.MaximumSize.Height) Then
                sectionDropDownTimer.Stop()
                dropDownSections = False
            End If
        Else
            sectionButton.Image = My.Resources.dropdown
            sectionPanel.Height -= 20
            If (sectionPanel.Height <= sectionPanel.MinimumSize.Height) Then
                sectionDropDownTimer.Stop()
                dropDownSections = True
                sectionPanel.Hide()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BSCS2BButton_Click(sender As Object, e As EventArgs) Handles BSCS2BButton.Click
        sectionButton.Text = BSCS2BButton.Text
        SectionFormat1.Show()
        Section1.BringToFront()
        Section1.Show()
        sectionDropDownTimer.Start()

    End Sub

    Private Sub announcementButton_Click(sender As Object, e As EventArgs) Handles announcementButton.Click
        docPanelR.BackColor = Color.Transparent
        docPanelL.BackColor = Color.Transparent
        gradesPanelR.BackColor = Color.Transparent
        gradesPanelL.BackColor = Color.Transparent
        calendarL.BackColor = Color.Transparent
        calendarR.BackColor = Color.Transparent
        annL.BackColor = Color.FromArgb(109, 206, 39)
        annR.BackColor = Color.FromArgb(109, 206, 39)
        notesL.BackColor = Color.Transparent
        notesR.BackColor = Color.Transparent
        uploadL.BackColor = Color.Transparent
        uploadR.BackColor = Color.Transparent
        homePanelU.BackColor = Color.Transparent
        homePanelB.BackColor = Color.Transparent
        notifU.BackColor = Color.Transparent
        notifB.BackColor = Color.Transparent
        homeButton.BackColor = Color.Transparent
        Announcement1.BringToFront()
        Announcement1.Show()
    End Sub

    Private Sub notesButton_Click(sender As Object, e As EventArgs) Handles notesButton.Click
        docPanelR.BackColor = Color.Transparent
        docPanelL.BackColor = Color.Transparent
        gradesPanelR.BackColor = Color.Transparent
        gradesPanelL.BackColor = Color.Transparent
        calendarL.BackColor = Color.Transparent
        calendarR.BackColor = Color.Transparent
        annL.BackColor = Color.Transparent
        annR.BackColor = Color.Transparent
        notesL.BackColor = Color.FromArgb(109, 206, 39)
        notesR.BackColor = Color.FromArgb(109, 206, 39)
        uploadL.BackColor = Color.Transparent
        uploadR.BackColor = Color.Transparent
        homePanelU.BackColor = Color.Transparent
        homePanelB.BackColor = Color.Transparent
        notifU.BackColor = Color.Transparent
        notifB.BackColor = Color.Transparent
        homeButton.BackColor = Color.Transparent
        Notes1.BringToFront()
        Notes1.Show()
    End Sub

    Private Sub uploadButton_Click(sender As Object, e As EventArgs) Handles uploadButton.Click
        docPanelR.BackColor = Color.Transparent
        docPanelL.BackColor = Color.Transparent
        gradesPanelR.BackColor = Color.Transparent
        gradesPanelL.BackColor = Color.Transparent
        calendarL.BackColor = Color.Transparent
        calendarR.BackColor = Color.Transparent
        annL.BackColor = Color.Transparent
        annR.BackColor = Color.Transparent
        notesL.BackColor = Color.Transparent
        notesR.BackColor = Color.Transparent
        uploadL.BackColor = Color.FromArgb(109, 206, 39)
        uploadR.BackColor = Color.FromArgb(109, 206, 39)
        homePanelU.BackColor = Color.Transparent
        homePanelB.BackColor = Color.Transparent
        homeButton.BackColor = Color.Transparent
        notifU.BackColor = Color.Transparent
        notifB.BackColor = Color.Transparent

        Upload1.BringToFront()
        Upload1.Show()
    End Sub

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        docPanelR.BackColor = Color.Transparent
        docPanelL.BackColor = Color.Transparent
        gradesPanelR.BackColor = Color.Transparent
        gradesPanelL.BackColor = Color.Transparent
        calendarL.BackColor = Color.Transparent
        calendarR.BackColor = Color.Transparent
        annL.BackColor = Color.Transparent
        annR.BackColor = Color.Transparent
        notesL.BackColor = Color.Transparent
        notesR.BackColor = Color.Transparent
        uploadL.BackColor = Color.Transparent
        uploadR.BackColor = Color.Transparent
        homePanelU.BackColor = Color.FromArgb(109, 206, 39)
        homePanelB.BackColor = Color.FromArgb(109, 206, 39)
        notifU.BackColor = Color.Transparent
        notifB.BackColor = Color.Transparent


        Home1.BringToFront()
    End Sub

    Private Sub notifButton_Click(sender As Object, e As EventArgs) Handles notifButton.Click
        docPanelR.BackColor = Color.Transparent
        docPanelL.BackColor = Color.Transparent
        gradesPanelR.BackColor = Color.Transparent
        gradesPanelL.BackColor = Color.Transparent
        calendarL.BackColor = Color.Transparent
        calendarR.BackColor = Color.Transparent
        annL.BackColor = Color.Transparent
        annR.BackColor = Color.Transparent
        notesL.BackColor = Color.Transparent
        notesR.BackColor = Color.Transparent
        uploadL.BackColor = Color.Transparent
        uploadR.BackColor = Color.Transparent
        homeButton.BackColor = Color.FromArgb(27, 66, 56)
        homePanelU.BackColor = Color.Transparent
        homePanelB.BackColor = Color.Transparent
        notifU.BackColor = Color.FromArgb(109, 206, 39)
        notifB.BackColor = Color.FromArgb(109, 206, 39)


        Dim Notif = New Notification
        Notif.Show()
        Notif.BringToFront()
        Notif.Location = New Point(1150, 60)
    End Sub

    Private Sub documentsButton_Click(sender As Object, e As EventArgs) Handles documentsButton.Click
        docPanelR.BackColor = Color.FromArgb(109, 206, 39)
        docPanelL.BackColor = Color.FromArgb(109, 206, 39)
        gradesPanelR.BackColor = Color.Transparent
        gradesPanelL.BackColor = Color.Transparent
        calendarL.BackColor = Color.Transparent
        calendarR.BackColor = Color.Transparent
        annL.BackColor = Color.Transparent
        annR.BackColor = Color.Transparent
        notesL.BackColor = Color.Transparent
        notesR.BackColor = Color.Transparent
        uploadL.BackColor = Color.Transparent
        uploadR.BackColor = Color.Transparent
        homePanelU.BackColor = Color.Transparent
        homePanelB.BackColor = Color.Transparent
        notifU.BackColor = Color.Transparent
        notifB.BackColor = Color.Transparent
        homeButton.BackColor = Color.Transparent

        Documents1.Show()
        Documents1.BringToFront()
    End Sub

    Private Sub gradesButton_Click(sender As Object, e As EventArgs) Handles gradesButton.Click
        gradesPanelR.BackColor = Color.FromArgb(109, 206, 39)
        gradesPanelL.BackColor = Color.FromArgb(109, 206, 39)
        docPanelL.BackColor = Color.Transparent
        docPanelR.BackColor = Color.Transparent
        calendarL.BackColor = Color.Transparent
        calendarR.BackColor = Color.Transparent
        annL.BackColor = Color.Transparent
        annR.BackColor = Color.Transparent
        notesL.BackColor = Color.Transparent
        notesR.BackColor = Color.Transparent
        uploadL.BackColor = Color.Transparent
        uploadR.BackColor = Color.Transparent
        homePanelU.BackColor = Color.Transparent
        homePanelB.BackColor = Color.Transparent
        notifU.BackColor = Color.Transparent
        notifB.BackColor = Color.Transparent
        homeButton.BackColor = Color.Transparent

        Grades1.Show()
        Grades1.BringToFront()
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Me.Hide()
        Dim login = New LoginForm
        login.Show()

    End Sub

    Private Sub SectionFormat1_Click(sender As Object, e As EventArgs) Handles SectionFormat1.Click
        Section1.Show()
        Section1.BringToFront()
    End Sub

    Private Sub calendarButton_Click(sender As Object, e As EventArgs) Handles calendarButton.Click
        gradesPanelR.BackColor = Color.Transparent
        gradesPanelL.BackColor = Color.Transparent
        docPanelL.BackColor = Color.Transparent
        docPanelR.BackColor = Color.Transparent
        calendarL.BackColor = Color.FromArgb(109, 206, 39)
        calendarR.BackColor = Color.FromArgb(109, 206, 39)
        annL.BackColor = Color.Transparent
        annR.BackColor = Color.Transparent
        notesL.BackColor = Color.Transparent
        notesR.BackColor = Color.Transparent
        uploadL.BackColor = Color.Transparent
        uploadR.BackColor = Color.Transparent
        homePanelU.BackColor = Color.Transparent
        homePanelB.BackColor = Color.Transparent
        notifU.BackColor = Color.Transparent
        notifB.BackColor = Color.Transparent
        homeButton.BackColor = Color.Transparent

    End Sub

    Private Sub Notes1_Load(sender As Object, e As EventArgs) Handles Notes1.Load

    End Sub
End Class