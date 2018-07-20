Public Class Form45
    Public Anion As String
    Public salt As String

    Private Sub Form45_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.a = 0 Then
            Anion = "Cl-"
            salt = "CuCl2"
        ElseIf Form1.a = 1 Then
            Anion = "Cl-"
            salt = "NiCl2"
        ElseIf Form1.a = 2 Then
            Anion = "Cl-"
            salt = "FeCl3"
        ElseIf Form1.a = 3 Then
            Anion = "Cl-"
            salt = "AlCl3"
        ElseIf Form1.a = 4 Then
            Anion = "Cl-"
            salt = "CoCl2"
        ElseIf Form1.a = 5 Then
            Anion = "(CO3)2-"
            salt = "(NH4)2CO3"
        ElseIf Form1.a = 6 Then
            Anion = "(SO4)2-"
            salt = "BaSo4"
        ElseIf Form1.a = 7 Then
            Anion = "Cl-"
            salt = "CaCl2"
        End If
        cat.Text = Form2.cation
        ani.Text = Anion
        sal.Text = salt
        PictureBox1.Image = Form2.PictureBox2.Image
    End Sub
        

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form46.Show()
        Me.Hide()
    End Sub
End Class