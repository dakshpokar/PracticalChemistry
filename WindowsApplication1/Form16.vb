Public Class Form16

    Public hcl As Boolean
    Public h2s As Boolean
    Public resulto As String
    Public a As Integer
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
            h2s = True
            Button2.Hide()
        End If
        If Form1.a = 0 Then
            resulto = "Black ppt"
        Else
            resulto = "No ppt"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Heating is completed. Results below--")

        RichTextBox1.AppendText(vbNewLine + resulto)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton3.Checked = True And Not Form1.a = 0 Then
            Me.Hide()
            Form17.Show()
            Form4.TextBox33.Text = "O.S. + dil.HCl(boil) + H2S gas"
            Form4.TextBox32.Text = "No precipitate"
            Form4.TextBox31.Text = "Group II absent"
        ElseIf RadioButton1.Checked = True And Form1.a = 0 Then
            Me.Hide()
            Form4.TextBox33.Text = "O.S. + dil.HCl(boil) + H2S gas"
            Form4.TextBox32.Text = resulto
            Form4.TextBox31.Text = "Group II present"
            a = MsgBox("This confirms presence of Group II continue?", MsgBoxStyle.OkCancel)
            If a = vbOK
                Form21.Show()
            Else
                Form4.Show()
            End If
        Else
            erro.Visible = True
            res.Visible = True
            PictureBox1.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        erro.Visible = False
        res.Visible = False
        PictureBox1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If h2s = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("H2S gas is passed over.")
            RichTextBox1.AppendText("Wait for 2 seconds...")
            Timer2.Start()
            Button4.Hide()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      

    End Sub
End Class