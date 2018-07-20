Public Class Form25

    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "Hence Ba2+, Ca2+ or Sr2+ may be present"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form34.Show()
        Me.Hide()
    End Sub
End Class