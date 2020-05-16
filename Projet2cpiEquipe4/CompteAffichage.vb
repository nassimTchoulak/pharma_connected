Public Class CompteAffichage
    Inherits menu
    Private d, d1 As DataSet
    Private b As DataBase = New DataBase()

    Public Sub CompteAffichage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        b = New DataBase()
        b.execute("SELECT [Niveau],[Identifiant],[Nom],[Prenom] FROM Compte")
        d1 = New DataSet()
        b.read(d1, "Compte")
        DG_REST_PROD.DataSource = d1.Tables("Compte")


        b = New DataBase()
        b.execute("SELECT [Date],[Heure],[Vendeur],[Niveau] FROM Acces")
        d3 = New DataSet()
        b.read(d3, "Acces")
        DataGridView1.DataSource = d3.Tables("Acces")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        b = New DataBase()
        b.execute("SELECT [Niveau],[Identifiant],[Nom],[Prenom] FROM Compte")
        d1 = New DataSet()
        b.read(d1, "Compte")
        DG_REST_PROD.DataSource = d1.Tables("Compte")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CompteAjout.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CompteSupp.Show()
    End Sub


    Private d2, d3 As DataSet


    Private Sub CompteHistorique_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_4Click(sender As Object, e As EventArgs) Handles Button1.Click
        b = New DataBase()
        b.execute("SELECT [Date],[Heure],[Vendeur],[Niveau] FROM Acces")
        d3 = New DataSet()
        b.read(d3, "Acces")
        DataGridView1.DataSource = d3.Tables("Acces")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CompteRenit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CompteModifier.Show()
    End Sub
End Class