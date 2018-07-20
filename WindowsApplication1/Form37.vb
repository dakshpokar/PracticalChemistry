Public Class Form37


    Public salt As Boolean
    Public nh As Boolean
    Public nh2 As Boolean
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.AppendText("Acetate Solution was transferred to new test tube.")
        salt = True
        Button4.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If salt = True Then
            RichTextBox1.AppendText(" K2CrO4 was added")
            RichTextBox1.AppendText(" Wait for 2 seconds....")
            Button5.Hide()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Clear()
        If Form1.a = 7 Then
            RichTextBox1.AppendText(" No ppt")
        Else
            RichTextBox1.AppendText(" White ppt")
        End If
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form1.a = 7 And RadioButton3.Checked = True Then
            Form39.Show()
            Me.Hide()
            Form4.TextBox69.Text = "Seperation Test for Ba2+, Ca2+, Sr2+: " + vbNewLine + "Acetate Solution heat + dil.H2SO4"
            Form4.TextBox68.Text = "No ppt"
            Form4.TextBox67.Text = Form2.cation + " confirmed"

        Else
            erro.Visible = True
            res.Visible = True
            PictureBox2.Visible = True
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        erro.Visible = True
        res.Visible = True
        PictureBox2.Visible = True
        Timer2.Stop()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class