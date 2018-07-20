Public Class Form13
    Public Salt As Boolean
    Public com As String
    Public mno2 As Boolean
    Public h2so4 As Boolean
    Public resulto As String
    Public resulter As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Salt = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Add MnO2 powder to salt")
            mno2 = True
            Button2.Hide()
            OvalShape4.Visible = True
        Else
            RichTextBox1.AppendText("Add Salt first")
        End If
    End Sub

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If mno2 = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Drop of H2SO4 was added.")
            Button4.Hide()
            h2so4 = True
            OvalShape1.FillStyle = PowerPacks.FillStyle.Percent60
        Else
            RichTextBox1.AppendText("Add MnO2 first.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If h2so4 = True Then
            PictureBox2.Visible = True
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Heating is started.")
            RichTextBox1.AppendText(vbNewLine + "Wait for 5 seconds.")
        
            If Form1.a = 0 Then
                resulto = "Colourless gas or greenish yellow gas, bleaching moist litmus paper."
                resulter = "Cl- may be present."
                OvalShape5.FillColor = Color.GreenYellow
                OvalShape6.FillColor = Color.GreenYellow
                com = "stop"
            ElseIf Form1.a = 1 Then
                resulto = "Colourless gas or greenish yellow gas, bleaching moist litmus paper."
                resulter = "Cl- may be present."
                OvalShape5.FillColor = Color.GreenYellow
                OvalShape6.FillColor = Color.GreenYellow
                com = "stop"
            ElseIf Form1.a = 2 Then
                resulto = "Colourless gas or greenish yellow gas, bleaching moist litmus paper."
                resulter = "Cl- may be present."
                OvalShape5.FillColor = Color.GreenYellow
                OvalShape6.FillColor = Color.GreenYellow
                com = "stop"
            ElseIf Form1.a = 3 Then
                resulto = "Colourless gas or greenish yellow gas, bleaching moist litmus paper."
                resulter = "Cl- may be present."
                OvalShape5.FillColor = Color.GreenYellow
                OvalShape6.FillColor = Color.GreenYellow
                com = "stop"
            ElseIf Form1.a = 4 Then
                resulto = "Colourless gas or greenish yellow gas, bleaching moist litmus paper."
                resulter = "Cl- may be present."
                OvalShape5.FillColor = Color.GreenYellow
                OvalShape6.FillColor = Color.GreenYellow
                com = "stop"
            ElseIf Form1.a = 7 Then
                resulto = "Colourless gas or greenish yellow gas, bleaching moist litmus paper."
                resulter = "Cl- may be present."
                OvalShape5.FillColor = Color.GreenYellow
                OvalShape6.FillColor = Color.GreenYellow
                com = "stop"
            Else
                resulto = "Nothing happened"
                resulter = "No Inference"
                OvalShape5.FillColor = Color.Transparent
                OvalShape6.FillColor = Color.Transparent
                com = "stop"
            End If
            Timer2.Start()
            Button5.Hide()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Clear()
        OvalShape5.Visible = True
        OvalShape6.Visible = True
        RichTextBox1.AppendText("Heating is completed. Results below--")
        RichTextBox1.AppendText(vbNewLine + resulto)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    
        If com = "stop" Then

            If Form1.a = 0 Or Form1.a = 1 Or Form1.a = 2 Or Form1.a = 3 Or Form1.a = 4 And RadioButton1.Checked = True Then
                Me.Hide()
                Form15.Show()

            ElseIf RadioButton6.Checked = True Or Not Form1.a = 0 Or Not Form1.a = 1 Or Not Form1.a = 2 Or Not Form1.a = 3 Or Not Form1.a = 4 Then

                Me.Hide()
                Form15.Show()
            Else
                Timer1.Start()
                erro.Visible = True
                Label7.Visible = True
                PictureBox1.Visible = True
            End If

        Else
            RichTextBox1.AppendText("First perform Test.")
        End If
        Form4.TextBox27.Text = "Take salt in dry test tube, add MnO2 powder, add few drops of conc.H2SO4 and heat gently."
        Form4.TextBox26.Text = resulto
        Form4.TextBox25.Text = resulter
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        erro.Visible = False
        Label10.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class