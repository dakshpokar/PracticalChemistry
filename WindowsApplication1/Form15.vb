Public Class Form15
    Public Salt As Boolean
    Public com As String
    Public hcl As Boolean
    Public resulto As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            RichTextBox1.Clear()
        RichTextBox1.AppendText("Transfered O.S. to new test tube.")
            hcl = True
        Button1.Hide()
    

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If hcl = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Added dil.HCl to test tube with O.S.")
            RichTextBox1.AppendText("Wait for 2 seconds...")
          
            Timer2.Start()
            Button2.Hide()
        End If
        resulto = "No precipitate."
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Results below--")
       
        RichTextBox1.AppendText(vbNewLine + resulto)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton3.Checked = True Then
            Me.Hide()
            Form16.Show()
            Form4.TextBox30.Text = "O.S. + dil.HCl"
            Form4.TextBox29.Text = resulto
            Form4.TextBox28.Text = "Group I absent"
        Else
            erro.Visible = True
            Label2.Visible = True
            PictureBox1.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        erro.Visible = False
        Label2.Visible = False
        PictureBox1.Visible = False
        Timer1.Stop()
    End Sub
End Class