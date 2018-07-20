Public Class Form12
    Public Salt As Boolean
    Public com As String
    Public err As Boolean
    Public h2so4 As Boolean
    Public result As String
    Public resulter As String
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
            RichTextBox1.AppendText("2 drops of conc.H2SO4 was added.")
            Button2.Hide()
            h2so4 = True
            OvalShape1.FillStyle = PowerPacks.FillStyle.Trellis
        Else

            RichTextBox1.AppendText("Add salt first.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Form1.a = 0 Then
            result = "Colourless gas, having pungent smell, gives white dense fumes with rod dipped in NH4OH. Blue litmus turns red."
            resulter = "Cl- may be present."
            OvalShape4.FillColor = Color.White
            OvalShape5.FillColor = Color.White
            OvalShape6.FillColor = Color.White
        ElseIf Form1.a = 1 Then
            result = "Colourless gas, having pungent smell, gives white dense fumes with rod dipped in NH4OH. Blue litmus turns red."
            resulter = "Cl- may be present."
            OvalShape4.FillColor = Color.White
            OvalShape5.FillColor = Color.White
            OvalShape6.FillColor = Color.White
        ElseIf Form1.a = 2 Then
            result = "Colourless gas, having pungent smell, gives white dense fumes with rod dipped in NH4OH. Blue litmus turns red."
            resulter = "Cl- may be present."
            OvalShape4.FillColor = Color.White
            OvalShape5.FillColor = Color.White
            OvalShape6.FillColor = Color.White
        ElseIf Form1.a = 3 Then
            result = "Colourless gas, having pungent smell, gives white dense fumes with rod dipped in NH4OH. Blue litmus turns red."
            resulter = "Cl- may be present."
            OvalShape4.FillColor = Color.White
            OvalShape5.FillColor = Color.White
            OvalShape6.FillColor = Color.White
        ElseIf Form1.a = 4 Then
            result = "Colourless gas, having pungent smell, gives white dense fumes with rod dipped in NH4OH. Blue litmus turns red."
            resulter = "Cl- may be present."
            OvalShape4.FillColor = Color.White
            OvalShape5.FillColor = Color.White
            OvalShape6.FillColor = Color.White
        ElseIf Form1.a = 7 Then
            result = "Colourless gas, having pungent smell, gives white dense fumes with rod dipped in NH4OH. Blue litmus turns red."
            resulter = "Cl- may be present."
            OvalShape4.FillColor = Color.White
            OvalShape5.FillColor = Color.White
            OvalShape6.FillColor = Color.White
        Else
            result = "Nothing happened"
            resulter = "No Inference."
            OvalShape4.FillColor = Color.Transparent
            OvalShape5.FillColor = Color.Transparent
            OvalShape6.FillColor = Color.Transparent
        End If
        If h2so4 = True Then
            OvalShape4.Visible = True
            OvalShape5.Visible = True
            OvalShape6.Visible = True

            PictureBox2.Visible = True
            RichTextBox1.Clear()
            RichTextBox1.AppendText(vbNewLine + "Heating Started.")
            RichTextBox1.AppendText(vbNewLine + "Wait for 5 seconds...")
            Timer2.Start()
            Button4.Hide()
            com = "stop"
        Else
            RichTextBox1.AppendText("Add H2SO4 first.")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Clear()
        RichTextBox1.AppendText("The heating is completed results below--" + result)
        PictureBox2.Visible = False
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        erro.Visible = False
        Label10.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      
        If com = "stop" Then

            If Form1.a = 0 Or Form1.a = 1 Or Form1.a = 2 Or Form1.a = 3 Or Form1.a = 4 And RadioButton1.Checked = True Then

                Me.Hide()
                Form13.Show()
            ElseIf RadioButton2.Checked = True Or Not Form1.a = 0 Or Not Form1.a = 1 Or Not Form1.a = 2 Or Not Form1.a = 3 Or Not Form1.a = 4 Then

                Me.Hide()
                Form13.Show()
            Else
                Timer1.Start()
                erro.Visible = True
                Label10.Visible = True
                PictureBox1.Visible = True
            End If

        Else
            RichTextBox1.AppendText("First perform Test.")
        End If
        Form4.TextBox24.Text = "Take salt in dry test tube, add 2 drops of conc.H2SO4 to it. Heat gently."
        Form4.TextBox23.Text = result
        Form4.TextBox22.Text = resulter
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class