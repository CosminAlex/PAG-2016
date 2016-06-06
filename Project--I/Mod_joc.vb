Public Class Mod_joc

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Mod_joc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form1.actor.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form1.BackColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub btncaracter_Click(sender As Object, e As EventArgs) Handles btncaracter.Click
        Caractere.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Label2.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        btncaracter.Enabled = True
        Label1.Enabled = False
    End Sub

    Private Sub rSpace_CheckedChanged(sender As Object, e As EventArgs) Handles rSpace.CheckedChanged
        btnStart.Enabled = True
        Form1.actor.Image = My.Resources.red_snooker_ball_300x300
        Form1.BackgroundImage = My.Resources.tapet
    End Sub

    Private Sub rClick_CheckedChanged(sender As Object, e As EventArgs) Handles rClick.CheckedChanged
        btnStart.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class