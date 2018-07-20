Public Class LoginForm1
    Private username As String
    Private password As String
    Private tries As Integer = 0

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        tries = tries + 1
        username = UsernameTextBox.Text
        password = PasswordTextBox.Text
        If tries = 3 Then
            MsgBox("You reached your maximum tries")
            MsgBox("You fucking bitch")
            MsgBox("Now I am closing....")
            Me.Close()
        End If
        If username = "DJ" And password = "CONC.H2S04" Then
            Form27.Show()
            Me.Hide()
            Form1.Label2.Text = "Welcome, Daksh and Jishnu"
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            username = ""
            password = ""
            Form1.two = True
            If Form1.two = True Then
                Form1.PictureBox3.Visible = False
                Form1.PictureBox4.Visible = True
                Form1.PictureBox5.Visible = True
                Form1.PictureBox4.Image = PracticalChemistry.My.Resources.daksh
                Form1.PictureBox5.Image = PracticalChemistry.My.Resources.jishnu
              
            End If
        ElseIf username = "daksh" And password = "india123" Then
            Form27.Show()
            Me.Hide()
            Form1.Label2.Text = "Welcome, Daksh"
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            username = ""
            password = ""
            Form1.PictureBox3.Image = PracticalChemistry.My.Resources.daksh
        ElseIf username = "Jishnu" And password = "fucking bitch" Then
            Form27.Show()
            Me.Hide()
            Form1.Label2.Text = "Welcome, " + username
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            username = ""
            password = ""
            Form1.PictureBox3.Image = PracticalChemistry.My.Resources.jishnu
        Else
            Label1.Visible = True
            Timer1.Start()


        End If
        My.Settings.username = username
        My.Settings.password = password
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Visible = False
        Timer1.Stop()


    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Timer1.Start()
    End Sub
End Class
