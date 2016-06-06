Public Class Manual_utilizare

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Manual_utilizare_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        TextBox1.Text = "     Pentru a putea sa joci trebuie sa dai click pe PLAY. La apasarea butonului va aparea o consola care va contine setari pentru joc. Setarile disponibile sunt pentru modul de joc si pentru designul aplicatiei. Pentru modul de joc se poate alege dintre space sau click prin bifarea optiunii selectate. Designul este impartit in 2 categorii : cel primitiv si cel personalizat. Cel primitiv iti da posibilitatea sa alegi culoarea caracterului si a fundalului dintr-o lista de culori. Iar cel personalizat iti da posibilitatea sa alegi caracterul dintr-o lista de caractere. Fiecare caracter are alta tema de joc. Dupa ce ati selectat aceste lucruri poti incepe sa joci.                -> Modul de joc <-                                   La apasarea butonului start jocul va incepe. Daca ai ales cu space, trebui sa apeesi pentru a nu atinge marginile de jos si de sus ale ferestrei dar in acelasi timp sa te feresti si inamici. Daca te-ai atins de unul din aceste lucruri jocul este pierdut! "
    End Sub

    Private Sub ScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScoreToolStripMenuItem.Click
        TextBox1.Text = "       Acest buton iti da posibilitatea sa vizualizezi scorul maxim. La apasarea butonului se va afisa scorul maxim obtinut de un jucator. "
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        TextBox1.Text = "       La apasarea acestui buton vor fi afisate informatii despre cel care a realizat aplicatia!"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        TextBox1.Text = "       Buton folosit pentru a parasi aplicatia!"
    End Sub

    Private Sub MeniuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeniuPrincipalToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class