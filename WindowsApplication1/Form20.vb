Public Class Form20
    Public nh4cl As Boolean
    Public resulto As String
    Public nh4oh As Boolean
    Public a As String
    Public h2s As Boolean
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Transfered O.S. to new test tube.")
        nh4cl = True
        Button1.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If nh4cl = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Added NH4Cl to test tube with O.S.")
            nh4oh = True
            Button2.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If nh4oh = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Added NH4OH to test tube with O.S.")
            Button4.Hide()

            h2s = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If h2s = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Added Na2HPO4. ")
            RichTextBox1.AppendText("Wait for 2 seconds....")
            Timer2.Start()
            Button5.Hide()
        End If
            resulto = "No precipitate"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If RadioButton3.Checked = True And (Not Form1.a = 6 Or Not Form1.a = 7) Then
            Me.Hide()
            Form4.TextBox42.Text = "O.S. + NH4Cl + NH4OH(till alkaline) + Na2HPO4"
            Form4.TextBox41.Text = "No precipitate"
            Form4.TextBox40.Text = "Group IV absent"
            a = MsgBox("This confirms presence of Group VI continue?", MsgBoxStyle.OkCancel)
            If a = vbOK Then
                Form22.Show()
            Else
                Form4.Show()
            End If
        Else
            erro.Visible = True
            Label6.Visible = True
            PictureBox1.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        erro.Visible = False
        Label6.Visible = False
        PictureBox1.Visible = False
        Timer1.Stop()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Clear()
        RichTextBox1.AppendText("The process is completed results below-")
        RichTextBox1.AppendText(vbNewLine + resulto)
        Timer2.Stop()
    End Sub
End Class