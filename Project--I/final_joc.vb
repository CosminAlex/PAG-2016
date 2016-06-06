Public Class final_joc

    
    Private Sub final_joc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'citeste din fisier scorul maxim 
        Dim score_maxim As Integer
        Dim score_curent As Integer
        Dim fileReadScoreMax As New IO.StreamReader("F:\score.txt")
        score_maxim = fileReadScoreMax.ReadToEnd
        fileReadScoreMax.Close()
        'citeste din fisier scorul curent
        Dim fileReadScore As New IO.StreamReader("F:\score_curent.txt")
        score_curent = fileReadScore.ReadToEnd
        fileReadScore.Close()
        'verifica daca scorul curent este mai mare decat cel maxim
        'daca scor_curent  > sau < scor_max se afiseaza un mesaj 
        If score_maxim < score_curent Then
            pctboxHappy.Visible = True
            lblRecor.Visible = True
        Else
            pctboxSad.Visible = True
        End If
        Label3.Text = score_curent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class