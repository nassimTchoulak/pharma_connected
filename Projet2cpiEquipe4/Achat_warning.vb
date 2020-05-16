Public Class Achat_warning
    Private i, r As Integer
    Private requete As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Achat_Commande.DataGridView2.SelectedRows.Count - 1 = 0) Then
            Try
                Achat_Commande.dttt = Achat_Commande.D2.Tables("Test")
                r = Achat_Commande.dttt.Rows(Achat_Commande.DataGridView2.SelectedRows(0).Index)("Ref")
                requete = "DELETE FROM [Bon Commande] WHERE Ref = ( " + r.ToString + ") "
                Achat_Commande.b.execute(requete)
                requete = "DELETE FROM [Commande] WHERE IDcommande = ( " + r.ToString + ") "
                Achat_Commande.b.execute(requete)
                Achat_Commande.DataGridView2.Rows.RemoveAt(Achat_Commande.DataGridView2.SelectedRows(0).Index)

            Catch

            End Try
            Me.Close()
        Else
            MsgBox("Veuillez séléctionner une seule ligne")
        End If
    End Sub
End Class