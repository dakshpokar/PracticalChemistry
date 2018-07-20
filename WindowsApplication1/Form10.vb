Public Class Form10
    Public boole As Boolean
    Public naoh As Boolean
    Public result As String
    Public resulto As String
    Public timer55 As String
    Public resulter As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.AppendText("The salt was added.")
        naoh = True
        Button1.Visible = False
        OvalShape1.Visible = True
        If Form1.a = 0 Then
            OvalShape1.FillColor = Color.LightSeaGreen
        ElseIf Form1.a = 1 Then
            OvalShape1.FillColor = Color.Green
        ElseIf Form1.a = 2 Then
            OvalShape1.FillColor = Color.Brown
        ElseIf Form1.a = 3 Then
            OvalShape1.FillColor = Color.White
        ElseIf Form1.a = 4 Then
            OvalShape1.FillColor = Color.Red
        ElseIf Form1.a = 5 Then
            OvalShape1.FillColor = Color.White
        ElseIf Form1.a = 6 Then
            OvalShape1.FillColor = Color.White
        ElseIf Form1.a = 7 Then
            OvalShape1.FillColor = Color.White

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        boole = True
        Form4.TextBox18.Text = "Heat a little salt with NaOH solution."
        Form4.TextBox17.Text = resulto
        Form4.TextBox16.Text = resulter
        If Form2.a = 0 Then
            If RadioButton2.Checked = True Then
                boole = False
            End If
        ElseIf Form2.a = 1 Then
            If RadioButton2.Checked = True Then
                boole = False
            End If
        ElseIf Form2.a = 2 Then
            If RadioButton2.Checked = True Then
                boole = False
            End If
        ElseIf Form2.a = 3 Then
            If RadioButton2.Checked = True Then
                boole = False
            End If
        ElseIf Form2.a = 4 Then
            If RadioButton2.Checked = True Then
                boole = False
            End If
        ElseIf Form2.a = 5 Then
            If RadioButton1.Checked = True Then
                boole = False
            End If
        ElseIf Form2.a = 6 Then
            If RadioButton2.Checked = True Then
                boole = False
            End If
        ElseIf Form2.a = 7 Then
            If RadioButton2.Checked = True Then
                boole = False
            End If

        End If
        If boole = False Then
            Me.Hide()
            Form11.Show()

        Else
            erro.Visible = True
            Label2.Visible = True
            PictureBox1.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        erro.Visible = False
        Label2.Visible = False
        PictureBox1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If naoh = True  Then
            RichTextBox1.AppendText(" The NaOH was added the mix was heated.")
            RichTextBox1.ResetText()
            PictureBox2.Visible = True
            If Form1.a = 5 Then
                result = " The test tube is heating hold a turmeric paper above it."
                resulto = ". The paper turned red.  Colourless gas with ammonical smell."
                resulter = "NH4+ may be present."

            Else
                result = "The test tube is heating hold turmeric paper above it. "
                resulto = " Nothing happened."
                resulter = "NH4+ may be absent."
            End If
            RichTextBox1.AppendText("" + result)
            Button2.Visible = False
            Timer2.Start()
            Button4.Visible = True

        Else
            RichTextBox1.AppendText(" NaOH was added and the test tube was heated and nothing happened.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If timer55 = "no" Then
            RichTextBox1.AppendText(" The heating was stopped while you held paper.")
            Button1.Visible = True
            Button2.Visible = True
            timer55 = "yes"
        Else
            RectangleShape2.Visible = True
            RichTextBox1.Clear()
            RichTextBox1.AppendText(" Wait for 5 seconds...")
            Timer3.Start()

            Timer2.Stop()
            Button4.Hide()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        timer55 = "no"
        Button1.Visible = True
        Button2.Visible = True
        RichTextBox1.AppendText(" The heating stopped.")

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        RichTextBox1.AppendText("" + resulto)
        If Form1.a = 5 Then
            RectangleShape2.FillColor = Color.Red
            RectangleShape2.Refresh()
        End If
        Timer3.Stop()
    End Sub
End Class