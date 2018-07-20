Public Class Form5
    Public a As Integer
    Public err As Boolean
    Public radio As String
    Public resulto As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Form2.a = 0 Then
            If RadioButton2.Checked = True Then
                Form7.Show()
                Me.Hide()
            Else
                err = True

            End If
        End If
        If Form2.a = 1 Then
            If RadioButton2.Checked = True Then
                Form7.Show()
                Me.Hide()
            Else
                err = True
            End If
        End If

        If Form2.a = 4 Then
            If RadioButton2.Checked = True Then
                Form7.Show()
                Me.Hide()
            Else
                err = True
            End If
        End If
        If Form2.a = 5 Then
            If RadioButton1.Checked = True Then
                Form7.Show()
                Me.Hide()
            Else
                err = True
            End If
        End If
        If Form2.a = 7 Then
            If RadioButton2.Checked = True Then
                Form7.Show()
                Me.Hide()
            Else
                err = True
            End If
        End If
        If RadioButton1.Checked = True Then
            radio = "Crystalline"
            Form4.TextBox4.Text = "Cl-, Br-, I-, NO3-,(SO4)2- or soluble (CO3)2- or compounds of NH4+ may be present."
        ElseIf RadioButton2.Checked = True Then
            radio = "Hygroscopic"
            Form4.TextBox4.Text = "Chlorides or nitrates of Cu2+, Ni2+, Co2+, Ca2+ may be present."
        Else
            radio = "Oye chadya"
        End If
        Form4.TextBox6.Text = "Nature"
        Form4.TextBox5.Text = radio
        If err = True Then
            erro.Visible = True
            Label2.Visible = True
            PictureBox1.Visible = True
            Timer1.Start()
        End If

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Form1.a

        If a = 0 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.cucl2

            resulto = "There are blue dots of Water on the salt."
        End If
        If a = 1 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.nicl2

            resulto = "There are blue dots of Water on the salt."
        End If
        If a = 2 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.fecl3

            resulto = "There are blue dots of Water on the salt."
        End If
        If a = 3 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.alcl3
            resulto = "There are blue dots of Water on the salt."
        End If
        If a = 4 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.cocl2

            resulto = "There are blue dots of Water on the salt."
        End If
        If a = 5 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.nh4co3
            resulto = "The salt is same as it was."
        End If
        If a = 6 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.baso4

            resulto = "There are blue dots of Water on the salt."
        End If
        If a = 7 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.cacl2

            resulto = "There are blue dots of Water on the salt."
        End If
        Label6.Text = resulto
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        erro.Visible = False
        Label2.Visible = False
        PictureBox1.Visible = False
        Timer1.Stop()
    End Sub
End Class