Public Class Form44

   
    Private Sub Form44_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "This tests confirms presence of " + Form2.cation + "cation"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form1.a = 0 Then
            Form39.Show()
            Me.Hide()
        ElseIf Form1.a = 1 Then
            Form39.Show()
            Me.Hide()
        ElseIf Form1.a = 2 Then
            Form39.Show()
            Me.Hide()
        ElseIf Form1.a = 3 Then
            Form39.Show()
            Me.Hide()
        ElseIf Form1.a = 4 Then
            Form39.Show()
            Me.Hide()
        ElseIf Form1.a = 7 Then
            Form39.Show()
            Me.Hide()
        ElseIf Form1.a = 5 Then
            Form39.Show()
            Me.Hide()
        ElseIf Form1.a = 6 Then
            Form39.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class