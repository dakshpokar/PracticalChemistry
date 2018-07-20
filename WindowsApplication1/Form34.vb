Public Class Form34


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
            RichTextBox1.AppendText(" NH4Cl was added")
            nh = True
            Button2.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Clear()

        If Form1.a = 6 Or Form1.a = 7 Then
            RichTextBox1.AppendText("White precipitate")
            PictureBox1.Image = My.Resources.whitgel
            PictureBox1.Refresh()

        End If
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True And (Form1.a = 7 Or Form1.a = 6) Then
            Form35.Show()
            Me.Hide()
            Form4.TextBox63.Text = "O.S. + NH4Cl + NH4OH till alkaline + (NH4)2CO3"
            Form4.TextBox62.Text = "White ppt"
            Form4.TextBox61.Text = Form2.cation + " confirmed"

        Else
            erro.Visible = True
            res.Visible = True
            PictureBox2.Visible = True
            Timer2.Start()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If nh = True Then
            RichTextBox1.AppendText(" NH4OH was added")
            nh2 = True
            Button4.Hide()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If nh2 = True Then
            RichTextBox1.AppendText(" (NH4)2CO3 was added")
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class