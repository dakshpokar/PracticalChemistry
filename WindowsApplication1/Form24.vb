Public Class Form24

    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "Hence confirmatory test for " + Form2.cation + " will begin"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form32.Show()
        Me.Hide()

    End Sub
End Class