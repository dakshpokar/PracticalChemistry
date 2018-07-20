Public Class Form27

    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        ProgressBar1.PerformStep()
        ProgressBar1.PerformStep()

        Timer2.Start()



    End Sub


    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ProgressBar1.PerformStep()
        ProgressBar1.Value = 100
        Me.Hide()
        Form1.Show()

        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()

        Timer4.Stop()




    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()
        ProgressBar1.PerformStep()
        ProgressBar1.PerformStep()
        Timer3.Start()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ProgressBar1.PerformStep()
        ProgressBar1.PerformStep()
        ProgressBar1.PerformStep()
        Timer4.Start()


    End Sub
End Class