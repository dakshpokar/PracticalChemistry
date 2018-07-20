Public Class Form2
    Public T As Integer
    Public a As Integer
    Public trues As Integer
    Public randon As Integer
    Public cation As String
    Public loader As Integer
    Public allow As Integer
    Public k As Boolean
    Public cat As String




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Timer1.Stop()



    End Sub



    Private Sub Form2_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        If loader < 21 Then
            loader = loader + 20
        End If

        Label3.Text = loader.ToString + "% loaded"
        Timer2.Start()



    End Sub

   
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ProgressBar1.PerformStep()
   

        Label3.Text = loader.ToString + "% loaded"
        Button1.Visible = True
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()

        Timer4.Stop()




    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ProgressBar1.PerformStep()
        If loader < 41 Then
            loader = loader + 20
        End If
        Label3.Text = loader.ToString + "% loaded"

        Timer3.Start()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ProgressBar1.PerformStep()
     
        If loader < 91 Then
            loader = loader + 10
        End If
    
        Label3.Text = loader.ToString + "% loaded"
        Timer4.Start()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        Label2.Visible = False
        ProgressBar1.Visible = False
        Button1.Visible = False
        Label3.Visible = False



        Label4.Visible = True
        Label5.Visible = True
        Label7.Visible = True

        colour.Visible = True
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        RadioButton5.Visible = True
        RadioButton6.Visible = True

        Button2.Visible = True
        Button3.Visible = True
        PictureBox2.Visible = True
        a = Form1.a

        If a = 0 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.cucl2
        End If
        If a = 1 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.nicl2
        End If
        If a = 2 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.fecl3
        End If
        If a = 3 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.alcl3

        End If
        If a = 4 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.cocl2
        End If
        If a = 5 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.nh4co3
        End If
        If a = 6 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.baso4
        End If
        If a = 7 Then
            PictureBox2.Image = PracticalChemistry.My.Resources.cacl2
        End If
      
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If a = 0 And RadioButton1.Checked = True Then
            cation = "Cu2+"
            trues = 1
            Form8.charcol = "Good"
            Form4.TextBox2.Text = "Blue or Bluish green"
        End If
        If a = 1 And RadioButton2.Checked = True Then
            cation = "Ni2+"
            trues = 1
            Form8.charcol = "Old"
            Form4.TextBox2.Text = "Green"
        End If
        If a = 2 And RadioButton3.Checked = True Then
            cation = "Fe3+"
            trues = 2
            Form8.charcol = "Worst"
            Form4.TextBox2.Text = "Dark brown"
        End If
        If a = 3 And RadioButton6.Checked = True Then
            cation = "Al3+"
            trues = 2
            Form8.charcol = "Used"
            Form4.TextBox2.Text = "White or colourless"
        End If
        If a = 4 And RadioButton5.Checked = True Then
            cation = "Co2+"
            trues = 1
            Form8.charcol = "Excellent"
            Form4.TextBox2.Text = "Rose Red or violet"
        End If
        If a = 5 And RadioButton6.Checked = True Then
            cation = "NH4+"
            trues = 1
            Form8.charcol = "AWESOME"
            Form4.TextBox2.Text = "White or colourless"
        End If
        If a = 6 And RadioButton6.Checked = True Then
            cation = "Ba2+"
            trues = 2
            Form8.charcol = "normal"
            Form4.TextBox2.Text = "White or colourless"
        End If
        If a = 7 And RadioButton6.Checked = True Then
            cation = "Ca2+"
            trues = 1
            Form8.charcol = "small"
            Form4.TextBox2.Text = "White or colourless"
        End If
        If RadioButton6.Checked = True Then
            cat = "Al3+, Zn2+, Ca2+, Ba2+, Mg2+, Pb2+ and NH4+ "
        Else
            cat = cation
        End If

        If trues = 1 Then
            Form4.TextBox1.Text = "Colour"
            Form4.TextBox3.Text = cat + " may be present."
            Me.Hide()
            Form5.Show()
        ElseIf trues = 2 Then
            Form4.TextBox1.Text = "Colour"
            Form4.TextBox3.Text = cat + " may be present."
            Me.Hide()
            Form7.Show()
        Else
            Timer5.Start()
            erro.Visible = True
            Label6.Visible = True
            PictureBox1.Visible = True


        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        erro.Visible = False
        Label6.Visible = False

        PictureBox1.Visible = False
        Timer5.Stop()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        allow = InputBox("Enter number: ", "Developer`s Mode")
        k = IsNumeric(allow)
        If k = True Then
            Form1.a = allow

        Else
            MsgBox("Please enter a number")
        End If

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub
End Class