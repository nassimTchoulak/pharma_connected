Public Class Achat_finCommande

    Private B As DataBase = New DataBase()
    Private d5 As DataSet = New DataSet()
    Private dttt As DataTable = New DataTable()
    Private produi As Produitt = New Produitt()
    Private z, idprod As Integer
    Private namee As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      
        Accueil.Show()
        Achat_Commande.Dispose()
        Achat_Commande.Show()
        Accueil.Hide()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Achat_bon.f.Text = Achat_Commande.ComboBox1.Text
        Achat_bon.num.Text = Achat_Commande.TextBox1.Text
        Achat_bon.dat.Text = Achat_Commande.DateTimePicker1.Text
        B.execute("SELECT Commande.IDproduit,Commande.Quantité FROM Commande WHERE IDCommande = " + Achat_Commande.TextBox1.Text)
        B.read(d5, "Commande")
        z = d5.Tables("Commande").Rows.Count - 1
        For w = 0 To z
            idprod = Val(d5.Tables("Commande").Rows(w).Item("IDproduit").ToString)
            If (produi.recherch_idprod(idprod, produi.dst)) Then
                dttt = produi.dst.Tables("Produit")
                namee = dttt.Rows(0)("Nom")
                Achat_bon.DataGridView1.Rows.Add(namee, d5.Tables("commande").Rows(w).Item("Quantité").ToString)
            End If
        Next
        Accueil.Show()
        Achat_Commande.Dispose()
        Achat_Commande.Show()
        Me.Close()
        Accueil.Hide()
        Achat_bon.Show()
    End Sub

    Private Sub Achat_finCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class