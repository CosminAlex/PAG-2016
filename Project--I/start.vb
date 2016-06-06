Public Class start

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Form2.Show()
            Me.Hide()
            Timer1.Enabled = False

        End If

    End Sub

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class