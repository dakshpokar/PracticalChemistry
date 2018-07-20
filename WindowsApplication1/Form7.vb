Public Class Form7
    Public result As String
    Public ts As String
    Public salt As Boolean
    Public resulto As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.AppendText("The Salt was added.")
        salt = True
        Button1.Visible = False
        OvalShape2.Visible = True
        If Form1.a = 0 Then
            OvalShape2.FillColor = Color.LightSeaGreen
        ElseIf Form1.a = 1 Then
            OvalShape2.FillColor = Color.Green
        ElseIf Form1.a = 2 Then
            OvalShape2.FillColor = Color.Brown
        ElseIf Form1.a = 3 Then
            OvalShape2.FillColor = Color.White
        ElseIf Form1.a = 4 Then
            OvalShape2.FillColor = Color.Red
        ElseIf Form1.a = 5 Then
            OvalShape2.FillColor = Color.White
        ElseIf Form1.a = 6 Then
            OvalShape2.FillColor = Color.White
        ElseIf Form1.a = 7 Then
            OvalShape2.FillColor = Color.White

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If salt = True Then
            Timer1.Start()
            RichTextBox1.AppendText(" The testube with salt was heated.")
            RichTextBox1.AppendText(" Wait for 5 seconds....")
            Button2.Visible = False
            PictureBox1.Visible = True
        Else
            RichTextBox1.AppendText("The test tube was heated and bursted into flames. Take the salt in it first")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        OvalShape4.Visible = True
        OvalShape5.Visible = True
        OvalShape6.Visible = True

        If Form2.a = 0 Then
            result = " This turned white when hot, but then it again became blue when cooled. Yellowish green gas with pungent smell."
            resulto = "Cu2+ may be present." + vbNewLine + "Cl- may be present."
            OvalShape4.FillColor = Color.GreenYellow
            OvalShape5.FillColor = Color.GreenYellow
            OvalShape6.FillColor = Color.GreenYellow
            OvalShape2.FillColor = Color.WhiteSmoke
            Timer2.Start()
        End If
        If Form2.a = 1 Then
            result = " Colour of the salt is now yellow. Yellowish green gas with pungent smell."
            resulto = "Ni2+ may be present." + vbNewLine + "Cl- may be present."
            OvalShape4.FillColor = Color.GreenYellow
            OvalShape5.FillColor = Color.GreenYellow
            OvalShape6.FillColor = Color.GreenYellow
            OvalShape2.FillColor = Color.Yellow
        End If
        If Form2.a = 2 Then
            result = " There is a reddish brown coloured residue. Yellowish green gas with pungent smell."
            resulto = "Fe2+/Fe3+ may be present." + vbNewLine + "Cl- may be present."
            OvalShape4.FillColor = Color.GreenYellow
            OvalShape5.FillColor = Color.GreenYellow
            OvalShape6.FillColor = Color.GreenYellow
            OvalShape2.FillColor = Color.RosyBrown
        End If
        If Form2.a = 3 Then
            result = " There is a residue which is white in colour and glows on heating. Yellowish green gas with pungent smell."
            resulto = "Al3+ may be present." + vbNewLine + "Cl- may be present."
            OvalShape4.FillColor = Color.GreenYellow
            OvalShape5.FillColor = Color.GreenYellow
            OvalShape6.FillColor = Color.GreenYellow
            OvalShape2.FillColor = Color.GhostWhite
        End If
        If Form2.a = 4 Then
            result = " It is turned blue now and after cooling it is pink. Yellowish green gas with pungent smell."
            resulto = "Co2+ may be present." + vbNewLine + "Cl- may be present."
            OvalShape4.FillColor = Color.GreenYellow
            OvalShape5.FillColor = Color.GreenYellow
            OvalShape6.FillColor = Color.GreenYellow
            OvalShape2.FillColor = Color.Blue
            Timer2.Start()
        End If
        If Form2.a = 5 Then
            result = " It has white sublimate with ammonical smell. Also colourless and odourless CO2 gas is evolved which turns lime water milky."
            resulto = "NH4+ may be present." + vbNewLine + "(CO3)2- or (C2O4)2- may be present."
            OvalShape4.FillColor = Color.GhostWhite
            OvalShape5.FillColor = Color.GhostWhite
            OvalShape6.FillColor = Color.GhostWhite
            OvalShape2.FillColor = Color.White
        End If
        If Form2.a = 6 Then
            result = " Nothing happens."
            resulto = "No inference."
            OvalShape4.FillColor = Color.Transparent
            OvalShape5.FillColor = Color.Transparent
            OvalShape6.FillColor = Color.Transparent
        End If
        If Form2.a = 7 Then
            result = " Yellowish green with pungent smell."
            resulto = "Cl- may be present."
            OvalShape4.FillColor = Color.GreenYellow
            OvalShape5.FillColor = Color.GreenYellow
            OvalShape6.FillColor = Color.GreenYellow
        End If

        RichTextBox1.Clear()
        RichTextBox1.AppendText(result)
        PictureBox1.Visible = False

        Timer1.Stop()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.TextBox9.Text = "Action of heat: " + vbNewLine + "Take a little salt in test tube and heat gently."
        Form4.TextBox8.Text = "" + result
        Form4.TextBox7.Text = "" + resulto
        If Form2.a = 0 Then
            If CheckBox5.Checked = True And CheckBox3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox9.Checked = False And CheckBox10.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False Then
                ts = "T"
            Else
                MsgBox("Error check again")
            End If

        End If
        If Form2.a = 1 Then
            If CheckBox14.Checked = True And CheckBox3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox9.Checked = False And CheckBox10.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox5.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False Then
                ts = "T"
            Else
                MsgBox("Error check again")
            End If
        End If
        If Form2.a = 2 Then
            If CheckBox9.Checked = True And CheckBox3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox5.Checked = False And CheckBox10.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False Then
                ts = "T"

            Else
                MsgBox("Error check again")
            End If
        End If
        If Form2.a = 3 Then
            If CheckBox10.Checked = True And CheckBox3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox5.Checked = False And CheckBox9.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False Then
                ts = "T"
            Else
                MsgBox("Error check again")
            End If
        End If
        If Form2.a = 4 Then
            If CheckBox11.Checked = True And CheckBox3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox5.Checked = False And CheckBox10.Checked = False And CheckBox9.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False Then
                ts = "T"
            Else
                MsgBox("Error check again")
            End If
        End If
        If Form2.a = 5 Then
            If CheckBox8.Checked = True And CheckBox3.Checked = False And CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox9.Checked = False And CheckBox5.Checked = False And CheckBox10.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False Then
                ts = "T"
            Else
                MsgBox("Error check again")
            End If
        End If
        If Form2.a = 6 Then
            If CheckBox16.Checked = True And CheckBox3.Checked = False And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox5.Checked = False And CheckBox10.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox9.Checked = False Then
                ts = "T"
            Else
                MsgBox("Error check again")
            End If
        End If

        If Form2.a = 7 Then
            If CheckBox3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox4.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox5.Checked = False And CheckBox10.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False And CheckBox9.Checked = False Then
                ts = "T"
            Else
                MsgBox("Error check again")
            End If
        End If

        If ts = "T" Then
            Me.Hide()
            Form8.Show()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Form1.a = 0 Then
            OvalShape2.FillColor = Color.Blue
        End If
        If Form1.a = 4 Then
            OvalShape2.FillColor = Color.Pink
        End If

        OvalShape2.Refresh()
        Timer2.Stop()
    End Sub


End Class