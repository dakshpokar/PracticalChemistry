Public Class Form31


    Public salt As Boolean
    Public nh As Boolean
    Public result As String
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
        If Form1.a = 3 Then
            RichTextBox1.AppendText("White gelantinuous precipitate of Al(OH)3")
            PictureBox1.Image = My.Resources.whitgel
            result = "White gelantinuous precipitate of Al(OH)3"
        ElseIf Form1.a = 2 Then
            RichTextBox1.AppendText("Reddish brown precipitate of Fe(OH)3")
            PictureBox1.Image = My.Resources.redgel
            result = "Reddish brown precipitate of Fe(OH)3"
        End If
        PictureBox1.Refresh()
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True And Form1.a = 3 Then
            Form44.Show()
            Me.Hide()
            Form4.TextBox54.Text = "O.S. + NH4Cl + NH4OH(till alkaline)"
            Form4.TextBox53.Text = result
            Form4.TextBox52.Text = Form2.cation + " confirmed"
        ElseIf RadioButton3.Checked = True And Form1.a = 2 Then
            Form44.Show()
            Me.Hide()
            Form4.TextBox54.Text = "O.S. + NH4Cl + NH4OH(till alkaline)"
            Form4.TextBox53.Text = result
            Form4.TextBox52.Text = Form2.cation + " confirmed"

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If nh = True Then
            RichTextBox1.AppendText(" NH4OH was added")
            RichTextBox1.AppendText(vbNewLine + "Wait for 2 seconds....")
            Timer1.Start()
            Button4.Hide()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class