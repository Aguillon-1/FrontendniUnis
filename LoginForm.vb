Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class LoginForm


    Dim roledropdown As Boolean = True
    Dim slide As Boolean = True
    Dim pagenext = True
    Public Sub New()

        InitializeComponent()
        pageTwoPanel.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginForm_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Me.Invalidate()
    End Sub

    Private Sub LoginForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Invalidate()
    End Sub

    Private Sub LoginForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Invalidate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub exitButton_MouseEnter(sender As Object, e As EventArgs) Handles exitButton.MouseEnter
        exitButton.BackColor = Color.Transparent
    End Sub

    Private Sub exitButton_MouseHover(sender As Object, e As EventArgs) Handles exitButton.MouseHover
        exitButton.BackColor = Color.Transparent
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim Mid = New FinalMainForm()
        Mid.Show()
        Me.Hide()

    End Sub



    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        moveLeftTimer.Start()
    End Sub

    Private Sub roleStudentButton_Click(sender As Object, e As EventArgs) Handles roleStudentButton.Click
        roleSelectButton.Text = roleStudentButton.Text
        roledropdownTimer.Start()
    End Sub

    Private Sub roleProfessorButton_Click(sender As Object, e As EventArgs) Handles roleProfessorButton.Click
        roleSelectButton.Text = roleProfessorButton.Text
        roledropdownTimer.Start()
    End Sub

    Private Sub roledropdownTimer_Tick(sender As Object, e As EventArgs) Handles roledropdownTimer.Tick
        If (roledropdown = True) Then
            rolePanel.Height += 10
            If (rolePanel.Height >= rolePanel.MaximumSize.Height) Then
                roledropdownTimer.Stop()
                roledropdown = False
            End If
        Else
            rolePanel.Height -= 10
            If (rolePanel.Height <= rolePanel.MinimumSize.Height) Then
                roledropdownTimer.Stop()
                roledropdown = True
            End If

        End If
    End Sub

    Private Sub roleSelectButton_Click(sender As Object, e As EventArgs) Handles roleSelectButton.Click
        roledropdownTimer.Start()
    End Sub

    Private Sub moveLeftTimer_Tick(sender As Object, e As EventArgs) Handles moveLeftTimer.Tick
        Dim xLoc = titlePanel.Location.X
        If (slide = True) Then
            xLoc += 25
            titlePanel.Location = New Point(xLoc, 0)
            If (titlePanel.Location.X >= 460) Then
                titlePanel.Location = New Point(464, 0)
                moveLeftTimer.Stop()
                slide = False
            End If
        Else
            xLoc -= 25
            titlePanel.Location = New Point(xLoc, 0)
            If (titlePanel.Location.X <= 5) Then
                titlePanel.Location = New Point(-7, 0)
                moveLeftTimer.Stop()
                slide = True
            End If

        End If
    End Sub

    Private Sub middleNameLbl_Click(sender As Object, e As EventArgs) Handles middleNameLbl.Click

    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        pageTwoPanel.Show()
        nextPageTimer.Start()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles studentNoLbl.Click

    End Sub

    Private Sub prevButton_Click(sender As Object, e As EventArgs) Handles prevButton.Click
        nextPageTimer.Start()
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim Mid = New FinalMainForm()
        Mid.Show()
        Me.Hide()
    End Sub

    Private Sub nextPageTimer_Tick(sender As Object, e As EventArgs) Handles nextPageTimer.Tick
        If (pagenext = True) Then
            pageTwoPanel.Height += 20
            If (pageTwoPanel.Height >= pageTwoPanel.MaximumSize.Height) Then
                nextPageTimer.Stop()
                pagenext = False
            End If
        Else
            pageTwoPanel.Height -= 20
            If (pageTwoPanel.Height <= pageTwoPanel.MinimumSize.Height) Then
                nextPageTimer.Stop()
                pagenext = True
                pageTwoPanel.Hide()
            End If

        End If
    End Sub

    Private Sub signUpButton_Click(sender As Object, e As EventArgs) Handles signUpButton.Click
        'if wala pa si user sa database, dapat magslide yung titlePanel pakanan para mare-veal yung details.
        'Ito yung dapat na code:
        moveLeftTimer.Start()
    End Sub

    Private Sub loginPanel_Paint(sender As Object, e As PaintEventArgs) Handles loginPanel.Paint

    End Sub

    Private Sub emailTextBox_TextChanged(sender As Object, e As EventArgs) Handles emailTextBox.TextChanged

    End Sub

    Private Sub passwordTextBox_TextChanged(sender As Object, e As EventArgs) Handles passwordTextBox.TextChanged

    End Sub
End Class