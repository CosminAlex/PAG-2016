Public Class Form1
    '**
    'Pentru lagg am folosit DoubleBuffered=true 
    '**
    Dim ySpeed As Integer = 0  ' pentru viteza personalui de pe coordonata Y
    Dim gravity As Integer = 4 ' stabileste gravitatea, viteza cu care va cobora pers..
    Dim Obstacol_jos(1) As PictureBox ' obstacolul care va aparea jos
    Dim Obstacol_sus(1) As PictureBox ' obstacolul care va aprea sus
    Public score As Integer ' daca personalul trece de obstacolo el va aduna niste puncte

    '    Form1_KeyDown proprietatea cu care pot controla personaluj==> La o apasare de space personajul 
    'se va ridica cu o viteza pe care o stabilest... aceasta viteza este data de numarul de pixeli cu 
    'care il ridic, pentru asta cand apas din viteza scad o anumita valoare....
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Mod_joc.rSpace.Checked = True Then
            If e.KeyCode = Keys.Space Then
                ySpeed -= 20
                '    My.Computer.Audio.Play(My.Resources.bipcut, _
                ' AudioPlayMode.Background)

            End If
        End If
        If e.KeyCode = Keys.Space Then
            ySpeed -= 20
            '    My.Computer.Audio.Play(My.Resources.bipcut, _
            ' AudioPlayMode.Background)

        End If
    End Sub
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        If Caractere.select_number = 3 Then
        End If
        Timer1.Enabled = True
        Inamici(1)     ' functia care face sa apara inamici-- OBSTACOLELE JOS
        Inamici_top(1) ' functia care face sa apara inamici-- OBSTACOLELE SUS
        stbRecord.BackColor = Color.IndianRed 'afisare scor 
        scor_record.BackColor = Color.IndianRed     'afisare scor maxim
        Dim AuxScore As Integer 'Variabila ce va memora valorea din fiser Scorul maxim
        ' file = My.Computer.FileSystem.OpenTextFileWriter("F:\score.txt", True)
        Dim fileReadScore As New IO.StreamReader("F:\score.txt")
        scor_record.Text = fileReadScore.ReadToEnd

        fileReadScore.Close()
        'actor.BackColor = Mod_joc.ColorDialog1.Color
        
    End Sub

    '              Timer1_tick --> aici controlez jocul
    ' pentru a putea avea "miscare" in aplicatie avem nevoie de un timer pentru a face 
    'obiestele sa se miste. aici personajului ii sunt atribuite viteza si gravitatea.
    'aici apar obstacolele de SUS si JOC
    'se verifica daca personajul a atins un obstacol
    'se numara cate puncte a facut jucatorul, aceste puncte fiind afisate intr-un statusBar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ySpeed += gravity
        actor.Top = ySpeed
        Dim test_score As Integer
        Dim fileReadScore As New IO.StreamReader("F:\score.txt")
        test_score = fileReadScore.ReadToEnd
        fileReadScore.Close()

        For i = 0 To 1
            Obstacol_jos(i).Left -= 2
            Obstacol_sus(i).Left -= 2
            If (Coliziune(Obstacol_jos(i), actor) = True) Or (Coliziune(Obstacol_sus(i), actor) = True) Then
                Me.Close()
                final_joc.Show()
                Form2.Show()

            End If
            If Obstacol_jos(i).Left < 0 Then

                Obstacol_jos(i).Left += 400
                Obstacol_sus(i).Left += 400
                Obstacol_jos(i).Top = 120 + 290 * Rnd()
                Obstacol_sus(i).Top = Obstacol_jos(i).Top - 460 ' distanta cel de sus
                score += 1
                If score <= 5 Then
                    score_curent.BackColor = Color.Green
                End If
                If score >= 10 Then
                    score_curent.BackColor = Color.DarkOliveGreen
                End If
                If score >= 15 Then
                    score_curent.BackColor = Color.Blue
                End If
                If score >= 20 Then
                    score_curent.BackColor = Color.DarkSlateBlue
                End If
                If score >= 25 Then
                    score_curent.BackColor = Color.IndianRed
                End If
                If score >= 30 Then
                    score_curent.BackColor = Color.Red
                End If
                If score >= 35 Then
                    score_curent.BackColor = Color.DarkRed
                End If
                sCurent.Text = score
                If score > test_score Then
                    stbScoreNew.Text = "NEW SCORE"
                End If
                If score > 10 Then
                    Timer1.Interval = 37
                End If
                If score > 20 Then
                    Timer1.Interval = 34
                End If
                If score > 30 Then
                    Timer1.Interval = 31
                End If
                If score > 40 Then
                    Timer1.Interval = 27
                End If
            End If
            '   F:\PAG--Project\v3.2\Project--I\Project--I:\score_curent.txt
            Dim fileWriteScorecurent As New IO.StreamWriter("F:\score_curent.txt")
            fileWriteScorecurent.Write(score)
            fileWriteScorecurent.Close()
           
            If test_score < score Then
                Dim fileWriteScore As New IO.StreamWriter("F:\score.txt")
                fileWriteScore.Write(score)
                fileWriteScore.Close()
            End If
            
        Next
    End Sub

    ' Aceasta functie este folosita pentru a creea "inamici", acele obstacole care apar in joc
    'Aceste forme sunt de tip PictureBox si sunt caracterizate de dimensiune si de pozitie unde apar...
    Private Sub Inamici(ByVal numar As Integer)
        Dim i As Integer = 0
        For i = 0 To numar
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50 ' latimea
            temp.Height = 360 ' inaltimea
            ' stil + fundal
            temp.BorderStyle = BorderStyle.None
            temp.BackgroundImage = My.Resources.images
            ' pozitia unde apar
            temp.Top = 120 + 290 * Rnd()
            temp.Left = (i * 200) + 350 ' pozitia stanga dreapta
            Obstacol_jos(i) = temp
            Obstacol_jos(i).Visible = True
        Next
    End Sub
    ' Aceasta functie este folosita pentru a creea "inamici", acele obstacole care apar in joc
    'Aceste forme sunt de tip PictureBox si sunt caracterizate de dimensiune si de pozitie unde apar...
    'Pentru inamici de sus
    Private Sub Inamici_top(ByVal numar As Integer)
        Dim i As Integer = 0
        For i = 0 To numar
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.None
            temp.BackgroundImage = My.Resources.images
            temp.Top = Obstacol_jos(i).Top - 470 ' dinstra dintre ele
            temp.Left = (i * 200) + 350 ' pozitia stanga dreapta
            Obstacol_sus(i) = temp
            Obstacol_sus(i).Visible = True
        Next
    End Sub

    ' Aceasta functie verifica daca personajul a atins un obstacol.....
    Private Function Coliziune(ByVal Obiect1 As Object, ByVal Obiect2 As Object) As Boolean
        Dim coliziune_minion As Boolean = False
        If Obiect1.Top + Obiect1.Height >= Obiect2.Top And Obiect2.Top + Obiect2.Height >= Obiect1.Top And Obiect1.Left + Obiect1.Width >= Obiect2.Left And Obiect2.Left + Obiect2.Width >= Obiect1.Left And Obiect1.Visible = True And Obiect1.Visible = True Then
            coliziune_minion = True
        End If
        Return coliziune_minion
    End Function


    '    Form1_MouseClick proprietatea cu care pot controla personaluj==> La o apasare de mouse personajul 
    'se va ridica cu o viteza pe care o stabilest... aceasta viteza este data de numarul de pixeli cu 
    'care il ridic, pentru asta cand apas din viteza scad o anumita valoare....
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If Mod_joc.rClick.Checked = True Then
            If e.Button = MouseButtons.Left Then
                ySpeed -= 20
            End If
        End If
    End Sub

    
End Class


'..............................
'..........................