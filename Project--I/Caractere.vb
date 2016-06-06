Public Class Caractere
    Dim select_actor As Boolean = False
    Public select_number As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' caracter galben
        Form1.actor.Image = My.Resources.Aim
        Form1.BackgroundImage = My.Resources.galbenWall
        select_actor = True
        PictureBox1.BackColor = Color.Red
        select_number = 1
        Timer1.Start()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'albastrel
        Form1.actor.Image = My.Resources.blue_user
        Form1.BackgroundImage = My.Resources.Albastrel
        select_actor = True
        PictureBox7.BackColor = Color.Red
        select_number = 2
        Timer1.Start()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'flappy
        Form1.actor.Image = My.Resources._281318
        Form1.BackgroundImage = My.Resources.flappyWall
        select_actor = True
        PictureBox6.BackColor = Color.Red
        select_number = 3
        Timer1.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' veverita
        Form1.actor.Image = My.Resources.Furtiffes_lunettes_vertes
        Form1.BackgroundImage = My.Resources.veveritawall
        select_actor = True
        PictureBox2.BackColor = Color.Red
        select_number = 4
        Timer1.Start()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'cocos
        Form1.actor.Image = My.Resources.le_Coq_2
        Form1.BackgroundImage = My.Resources.cocoswall
        select_actor = True
        PictureBox5.BackColor = Color.Red
        Form1.BackgroundImage = My.Resources.cocoswall
        select_number = 5
        Timer1.Start()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'zana
        Form1.actor.Image = My.Resources.Luis__2_
        Form1.BackgroundImage = My.Resources._640x359_20823_Environments_Educational_Game_2d_cartoon_landscape_forest_game_art_background_picture_image_digital_art
        select_actor = True
        PictureBox4.BackColor = Color.Red
        select_number = 6
        Timer1.Start()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.actor.Image = My.Resources.MonTux256
        Form1.BackgroundImage = My.Resources.pinguinwall1
        select_actor = True
        PictureBox3.BackColor = Color.Red
        select_number = 1
        Timer1.Start()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        '  pinguin
        Form1.actor.Image = My.Resources.MotardTux256
        Form1.BackgroundImage = My.Resources.moto
        select_actor = True
        PictureBox8.BackColor = Color.Red
        select_number = 7
        Timer1.Start()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        'minion
        Form1.actor.Image = My.Resources.superman_minion_ico1n1
        PictureBox10.BackColor = Color.Red
        Form1.BackgroundImage = My.Resources.MINIONWALL
        select_number = 8
        Timer1.Start()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        'pinguin costum
        Form1.actor.Image = My.Resources.TuxSmoking256
        Form1.BackgroundImage = My.Resources.PinguinCostumWall
        select_actor = True
        PictureBox9.BackColor = Color.Red
        select_number = 9
        Timer1.Start()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        'car 
        Form1.actor.Image = My.Resources.yellow_512
        Form1.BackgroundImage = My.Resources.CARWALL
        select_actor = True
        PictureBox12.BackColor = Color.Red
        select_number = 10
        Timer1.Start()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        'mario
        Form1.actor.Image = My.Resources.Mario_Bro
        select_actor = True
        PictureBox11.BackColor = Color.Red
        Form1.BackgroundImage = My.Resources.Mariowall
        select_number = 11
        Timer1.Start()


    End Sub



   
    Private Sub Caractere_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()

    End Sub
End Class