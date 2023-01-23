Imports LOGIN
Imports TrinitySeal
Imports WindowsApp6.Seal

Public Class Form1
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim response As Boolean = LOGIN.Seal.Login(TextBox1.Text, TextBox2.Text)

        If response Then
            My.Settings.user = TextBox1.Text
            My.Settings.pass = TextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()
            Form2.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SealCheck.HashChecks()

        If SealCheck.isValidDLL Then
            Dim response As Boolean = LOGIN.Seal.Register(TextBox1.Text, TextBox2.Text, "SHEHAB@GMAIL.COM", TextBox3.Text)

            If response Then
                'Register Success
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBox3.Visible = False
        Label3.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = False

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBox3.Visible = True
        Label3.Visible = True
        PictureBox3.Visible = False
        PictureBox4.Visible = True
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SealCheck.HashChecks()
        If SealCheck.isValidDLL Then
            LOGIN.Seal.Secret = "Ly9Nepf07acVE3EDw9KuNPCdqngeNlIEZNwheXtz3GKkU"
            LOGIN.Seal.Initialize("1.0")
        End If
        TextBox1.Text = My.Settings.user
        TextBox2.Text = My.Settings.pass
        TextBox3.Visible = False
        Label3.Visible = False


        PictureBox4.Visible = False

    End Sub
End Class