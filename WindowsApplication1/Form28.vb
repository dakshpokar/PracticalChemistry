Public Class Form28
    Public boole As Boolean
    Public naoh As Boolean
    Public result As String
    Public resulto As String
    Public timer55 As String
    Public resulter As String

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox1.AppendText("The salt was added.")
        naoh = True
        Button6.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        boole = True
        Form4.TextBox48.Text = "Heat a little salt with NaOH solution."
        Form4.TextBox47.Text = resulto
        Form4.TextBox46.Text = resulter
        If Form2.a = 5 Then
            If RadioButton1.Checked = True Then
                boole = False
            End If
        End If
        If boole = False Then
            Me.Hide()
            Form44.Show()

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If naoh = True Then
            RichTextBox1.AppendText(" The NaOH was added the mix was heated.")
            RichTextBox1.ResetText()
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
            Button5.Visible = False
            Timer2.Start()
            Button4.Visible = True

        Else
            RichTextBox1.AppendText(" NaOH was added and the test tube was heated and nothing happened.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If timer55 = "no" Then
            RichTextBox1.AppendText(" The heating was stopped while you held paper.")
            Button6.Visible = True
            Button5.Visible = True
            timer55 = "yes"
        Else
            RichTextBox1.AppendText("" + resulto)
            RichTextBox1.AppendText("")
            Timer2.Stop()
            Button4.Hide()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        timer55 = "no"
        Button6.Visible = True
        Button5.Visible = True
        RichTextBox1.AppendText(" The heating stopped.")

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()

    End Sub
End Class