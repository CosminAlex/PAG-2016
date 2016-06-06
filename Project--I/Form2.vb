Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Mod_joc.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Dim fileReadScore As New IO.StreamReader("F:\score.txt")
        MsgBox("Scorul maxim obtinut este: " & fileReadScore.ReadToEnd, , "Score Joc")

        fileReadScore.Close()
    End Sub

   
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        InfoAutor.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Doriti sa inchideti aplicatia?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            start.Close()
        End If
       

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        Manual_utilizare.Show()

    End Sub
End Class