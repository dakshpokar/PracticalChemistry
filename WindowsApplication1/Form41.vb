Public Class Form41


    Public salt As Boolean
    Public nh As Boolean
    Public nh2 As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.AppendText("O.S. was transferred to new test tube.")
        salt = True
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If salt = True Then
            RichTextBox1.AppendText(" K2CrO4 was added")
            RichTextBox1.AppendText(" Wait for 2 seconds....")
            Button2.Hide()

            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Clear()
        If Form1.a = 6 Then
            RichTextBox1.AppendText(" White ppt insoluble in dil.HNO3")
            PictureBox1.Image = My.Resources.whiteppt
            PictureBox1.Refresh()
        Else
            RichTextBox1.AppendText("Kutru")
        End If
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Form1.a = 6 And RadioButton1.Checked = True Then
            Form45.Show()
            Me.Hide()
            Form4.TextBox69.Text = "O.S. + Ba(NO3)2"
            Form4.TextBox68.Text = "White ppt insoluble in dil.HNO3"
            Form4.TextBox67.Text = "SO4-- confirmed"
        ElseIf Form1.a = 7 And RadioButton3.Checked = True Then
            Form45.Show()
            Me.Hide()
        Else
            erro.Visible = True
            res.Visible = True
            PictureBox2.Visible = True
            Timer2.Start()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        erro.Visible = False
        res.Visible = False
        PictureBox2.Visible = False
        Timer2.Stop()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class