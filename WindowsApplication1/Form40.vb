Public Class Form40

 
    Public salt As Boolean
    Public nh As Boolean
    Public nh2 As Boolean
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.AppendText("O.S. was transferred to new test tube.")
        salt = True
        Button4.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If salt = True Then
            RichTextBox1.AppendText(" Freshly prepared Cl2 gas was added")
            nh = True
            Button2.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        RichTextBox1.Clear()
        RichTextBox1.AppendText("Chloroform layer colourless")
        PictureBox1.Image = My.Resources.chloroform
        PictureBox1.Refresh()
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton4.Checked = True And Not (Form1.a = 5 Or Form1.a = 6) Then
            Form45.Show()
            Me.Hide()
            Form4.TextBox75.Text = "Distinction Test: " + vbNewLine + "O.S. + Cl2 water(fresh) + chloroform and shake well"
            Form4.TextBox74.Text = "Chloroform layer colourless"
            Form4.TextBox73.Text = "Cl- confirmed"
        Else
            erro.Visible = True
            res.Visible = True
            PictureBox2.Visible = True
            Timer2.Start()

        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If nh2 = True Then
            RichTextBox1.AppendText(" Please wait while shaking is performed.")
            RichTextBox1.AppendText(vbNewLine + "Wait for 2 seconds....")
            Timer1.Start()
            Button5.Hide()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        erro.Visible = False
        res.Visible = False
        PictureBox2.Visible = False
        Timer2.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nh = True Then
            RichTextBox1.AppendText(" Chloroform was added.")
            nh2 = True
            Button1.Hide()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class