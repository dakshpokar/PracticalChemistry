Public Class Form11
    Public Salt As Boolean
    Public com As String
    Public err As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Clear()
        com = "start"
        RichTextBox1.AppendText("The salt was added. ")
        Salt = True
        Button1.Hide()
        OvalShape1.Visible = True
        If Form1.a = 0 Then
            OvalShape1.FillColor = Color.LightSeaGreen
        ElseIf Form1.a = 1 Then
            OvalShape1.FillColor = Color.Green
        ElseIf Form1.a = 2 Then
            OvalShape1.FillColor = Color.Brown
        ElseIf Form1.a = 3 Then
            OvalShape1.FillColor = Color.White
        ElseIf Form1.a = 4 Then
            OvalShape1.FillColor = Color.Red
        ElseIf Form1.a = 5 Then
            OvalShape1.FillColor = Color.White
        ElseIf Form1.a = 6 Then
            OvalShape1.FillColor = Color.White
        ElseIf Form1.a = 7 Then
            OvalShape1.FillColor = Color.White

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Salt = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("2 drops of dil.HCl was added.")
            OvalShape1.FillStyle = PowerPacks.FillStyle.Trellis
            RichTextBox1.AppendText("Wait for 5 seconds.....")
            Timer2.Start()
            Button2.Hide()
            com = "stop"
        Else
            RichTextBox1.AppendText("Add salt first.")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Clear()
        RichTextBox1.AppendText("The test is completed results below--")
        If Form1.a = 5 Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("There is colourless, odourless gas with effervescence, turns freshly prepared lime water milky.")
            OvalShape4.FillColor = Color.GhostWhite
            OvalShape5.FillColor = Color.GhostWhite
            OvalShape6.FillColor = Color.GhostWhite
        Else
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Nothing happened")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If com = "stop" Then

            If Form1.a = 5 And RadioButton1.Checked = True Then

                Form4.TextBox21.Text = "Action of dil.HCl: Take salt in dry test tube. Add 2-3 drops of  dil.HCl."
                Form4.TextBox20.Text = "There is colourless, odourless gas with effervescence, turns freshly prepared lime water milky."
                Form4.TextBox19.Text = "(CO3)2- may be present."

                Me.Hide()
                Form12.Show()
            ElseIf RadioButton4.Checked = True And Not Form1.a = 5 Then
                Form4.TextBox21.Text = "Action of dil.HCl: Take salt in dry test tube. Add 2-3 drops of  dil.HCl."
                Form4.TextBox20.Text = "No observations"
                Form4.TextBox19.Text = "No Inference."
                Me.Hide()
                Form12.Show()
            Else
                Timer1.Start()
                erro.Visible = True
                Label6.Visible = True
                PictureBox1.Visible = True
            End If

        Else
            RichTextBox1.AppendText("First perform Test.")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        erro.Visible = False
        Label6.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()

    End Sub
End Class