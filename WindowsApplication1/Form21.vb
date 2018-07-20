Public Class Form21

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form30.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()

    End Sub
End Class