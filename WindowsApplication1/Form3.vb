﻿Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Form1.Show()
        Form1.Focus()


    End Sub
End Class