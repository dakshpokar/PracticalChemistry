Public Class Form30

    Public salt As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.AppendText("O.S. was transferred to new test tube.")
        salt = True
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If salt = True Then
            RichTextBox1.AppendText(" NaOH was added in excess.")
            RichTextBox1.AppendText(vbNewLine + "Wait for 2 seconds....")
            Timer1.Start()
            Button2.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Blue precipate is formed.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            Form44.Show()
            Me.Hide()
            Form4.TextBox52.Text = "O.S. + NaOH in excess"
            Form4.TextBox51.Text = "Blue precipitate"
            Form4.TextBox49.Text = "Cu2+ confirmed"

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class