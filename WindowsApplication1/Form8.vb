Public Class Form8
    Public Bool As Boolean
    Public cavity As Boolean
    Public charcoal As Boolean
    Public fm As Boolean
    Public salt As Boolean
    Public charcol As String
    Public resulta As String
    Public result As String
    Public heater As Boolean
    Public resulto As String



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form2.a = 0 Then
            If RadioButton3.Checked = True Then
                Bool = True
                resulta = "There are red scales."
                resulto = "Cu2+ may be present"
            End If

      
        ElseIf Form2.a = 2 Then
            If RadioButton6.Checked = True Then
                Bool = True
                resulta = "Nothing happened."
                resulto = "No Inference."
            End If
        ElseIf Form2.a = 3 Then
        If RadioButton4.Checked = True Then
            Bool = True
                resulta = "There is white residue."
                resulto = "A13+, Zn2+, Ca2+, Ba2+, Sr2+, Hg2+ may be present."
            End If
        ElseIf Form2.a = 5 Then
            If RadioButton6.Checked = True Then
                Bool = True
                resulta = "Nothing happened"
                resulto = "No Inference"

            End If
        ElseIf Form2.a = 4 Then
            If RadioButton6.Checked = True Then
                Bool = True
                resulta = "Nothing happened"
                resulto = "No Inference"
            End If
        ElseIf Form2.a = 6 Then
        If RadioButton4.Checked = True Then
            Bool = True
                resulta = "There is a white residue."
                resulto = "A13+, Zn2+, Ca2+, Ba2+, Sr2+, Hg2+ may be present."
        End If
        ElseIf Form2.a = 7 Then
        If RadioButton4.Checked = True Then
            Bool = True
                resulta = "There is a white residue."

                resulto = "A13+, Zn2+, Ca2+, Ba2+, Sr2+, Hg2+ may be present."
        End If
        ElseIf Form2.a = 1 Then
        If RadioButton5.Checked = True Then

            Bool = True
                resulta = "There is a coloured residue."

                resulto = "Fe2+, Mn2+, Cu2+, Ni2+ may be present."

        End If
        End If
        Form4.TextBox12.Text = "Charcoal Cavity Test: "
        Form4.TextBox12.Text = "Take a small quantity of salt mix it with equal amounts of fusion mix(Na2CO3+K2CO3). Moist this with drop of water. Make a cavity in a charcoal and paste to it."
        Form4.TextBox11.Text = resulta
        Form4.TextBox10.Text = resulto
        If Bool = True Then

            Me.Hide()
            Form10.Show()


        Else
            erro.Visible = True
            Label2.Visible = True
            PictureBox1.Visible = True
            Timer1.Start()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        erro.Visible = False
        Label2.Visible = False
        PictureBox1.Visible = False
        Timer1.Stop()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If charcoal = True Then
            RichTextBox1.AppendText(vbNewLine + " A cavity was made into the charcoal.")
            Button1.Visible = False
            cavity = True
        Else
            RichTextBox1.AppendText(vbNewLine + " There is nothing to make cavity in.")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If salt = True Then
            RichTextBox1.AppendText(vbNewLine + " The fusion mixture was added to the cavity with salt.")
            Button5.Visible = False
            fm = True

        Else
            RichTextBox1.AppendText(vbNewLine + " Add salt first.")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If fm = True Then
            RichTextBox1.ResetText()

            RichTextBox1.AppendText("A drop of water was added to cavity with salt+fusion mix.")
            Button6.Visible = False
            heater = True
        Else
            RichTextBox1.AppendText(vbNewLine + " Please add fusion mixture first then click this button.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cavity = True Then
            RichTextBox1.AppendText(vbNewLine + " Salt was added to the cavity.")
            Button4.Visible = False
            salt = True

        Else
            RichTextBox1.AppendText(vbNewLine + " There is no cavity to add salt to.")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RichTextBox1.AppendText("A " + charcol + " charcoal was taken.")
        Button7.Visible = False
        charcoal = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If heater = True Then

            RichTextBox1.AppendText("The test tube was kept on burner.")
            Timer2.Start()
            RichTextBox1.ResetText()
            RichTextBox1.AppendText("Wait for 5 seconds....")
            Button2.Visible = False
            If Form2.a = 0 Then
                result = "There are red scales."


            ElseIf Form2.a = 2 Then
                result = "No result for this test."

            ElseIf Form2.a = 3 Then
                result = "There is white residue."

            ElseIf Form2.a = 5 Then
                result = "No result for this test."

            ElseIf Form2.a = 4 Then
                result = "No result for this test."

            ElseIf Form2.a = 6 Then

                result = "There is a white residue."

            ElseIf Form2.a = 7 Then

                result = "There is a white residue."
            ElseIf Form2.a = 1 Then

                result = "There is a coloured residue."

            End If
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.ResetText()
        RichTextBox1.AppendText(vbNewLine + "The heating process is completed, results below,")
        RichTextBox1.AppendText(" " + result)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()

    End Sub
End Class