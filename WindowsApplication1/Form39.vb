Public Class Form39
    Public salt As Boolean
    Public result As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.AppendText("O.S. was transferred to new test tube.")
        salt = True
        Button1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If salt = True Then
            RichTextBox1.AppendText(" AgNO3 was added.")
            RichTextBox1.AppendText(" Wait for 2 seconds.....")
            Timer1.Start()

            Button5.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Clear()

        If Form1.a = 0 Then
            result = "White precipitate insoluble in dil.HNO3"
            PictureBox1.Image = My.Resources.whiteppt
        ElseIf Form1.a = 1 Then
            result = "White precipitate insoluble in dil.HNO3"
            PictureBox1.Image = My.Resources.whiteppt
        ElseIf Form1.a = 2 Then
            result = "White precipitate insoluble in dil.HNO3"
            PictureBox1.Image = My.Resources.whiteppt
        ElseIf Form1.a = 3 Then
            result = "White precipitate insoluble in dil.HNO3"
            PictureBox1.Image = My.Resources.whiteppt
        ElseIf Form1.a = 4 Then
            result = "White precipitate insoluble in dil.HNO3"
            PictureBox1.Image = My.Resources.whiteppt
        ElseIf Form1.a = 5 Then
            result = "White precipitate soluble in dil.HNO3 with effervescence of CO2"
            PictureBox1.Image = My.Resources.whiteppt
        ElseIf Form1.a = 6 Then
            result = "No precipitate"
        ElseIf Form1.a = 7 Then
            result = "White precipitate insoluble in dil.HNO3"
            PictureBox1.Image = My.Resources.whiteppt

        End If
        RichTextBox1.AppendText("" + result)
        Timer1.Stop()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton4.Checked = True And (Form1.a = 0 Or Form1.a = 1 Or Form1.a = 2 Or Form1.a = 3 Or Form1.a = 4 Or Form1.a = 7) Then
            Form40.Show()
            Me.Hide()
            Form4.TextBox72.Text = "Two drops of O.S. + 2 drops of AgNO3"
            If Form1.a = 6 Then
                Form4.TextBox71.Text = "No ppt"
                Form4.TextBox70.Text = "Cl-,I-,Br-,(CO3)2-,PO4--- absent"
            ElseIf Form1.a = 5 Then
                Form4.TextBox71.Text = "White ppt soluble in dil.HNO3"
                Form4.TextBox70.Text = "CO3-- present."
            Else
                Form4.TextBox71.Text = "White ppt insoluble in dil.HNO3"
                Form4.TextBox70.Text = "Cl-,I-,Br- present"

            End If



        ElseIf Form1.a = 5 And RadioButton2.Checked = True Then
            Form45.Show()
            Me.Hide()
        ElseIf Form1.a = 6 And RadioButton3.Checked = True Then
            Form41.Show()
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