Public Class RestMain
    Inherits menu
    Dim base As DataBase = New DataBase()
    Dim dataProd As New DataSet
    Dim dataJourn As New DataSet
    Dim operation As New RestOperation
    Dim ligne As Integer = -1


    Private Sub RestMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operation.chargementProduits("SELECT * FROM Restitution")
        operation.chargementJournal("SELECT * FROM [Journal Restitution]")
    End Sub

    Private Sub BT_REST_AJOUT_Click(sender As Object, e As EventArgs) Handles BT_REST_AJOUT.Click
        RestAjout.Show()
    End Sub

    Private Sub BT_REST_VENTE_Click(sender As Object, e As EventArgs) Handles BT_REST_VENTE.Click
        RestVente.Show()
    End Sub

    Private Sub BT_RECHERCHE_Click(sender As Object, e As EventArgs) Handles BT_RECHERCHE.Click
        If TXT_PROD_QT.Text <> "" And IsNumeric(TXT_PROD_QT.Text) Then
            base.execute("SELECT * FROM Restitution WHERE Nom LIKE '%" + TXT_PROD_NOM.Text + "%' AND ID LIKE '%" + TXT_PROD_ID.Text + "%' AND Poids = " + TXT_PROD_QT.Text)
        Else
            base.execute("SELECT * FROM Restitution WHERE Nom LIKE '%" + TXT_PROD_NOM.Text + "%' AND ID LIKE '%" + TXT_PROD_ID.Text + "%'")
        End If
        base.read(dataProd, "Restitution")
        DG_REST_PROD.DataSource = dataProd.Tables("Restitution")
    End Sub


    Private Sub BT_PROD_ACTUALISER_Click(sender As Object, e As EventArgs) Handles BT_PROD_ACTUALISER.Click
        operation.chargementProduits("SELECT * FROM Restitution")
        TXT_PROD_ID.Text = ""
        TXT_PROD_NOM.Text = ""
        TXT_PROD_QT.Text = ""
    End Sub

    Private Sub BT_JOURNAL_ACTUALISER_Click(sender As Object, e As EventArgs) Handles BT_JOURNAL_ACTUALISER.Click
        operation.chargementJournal("SELECT * FROM [Journal Restitution]")
        TXT_JOURNAL_ID.Text = ""
        TXT_JOURNAL_NOM.Text = ""
        TXT_JOURNAL_QT.Text = ""
    End Sub


    Private Sub BT_JOURNAL_RECHERCHE_Click(sender As Object, e As EventArgs) Handles BT_JOURNAL_RECHERCHE.Click
        If TXT_JOURNAL_QT.Text <> "" And IsNumeric(TXT_JOURNAL_QT.Text) Then
            base.execute("SELECT * FROM [Journal Restitution] WHERE Nom LIKE '%" + TXT_JOURNAL_NOM.Text + "%' AND ID LIKE '%" + TXT_JOURNAL_ID.Text + "%' AND [Quantité] = " + TXT_JOURNAL_QT.Text)
        Else
            base.execute("SELECT * FROM [Journal Restitution] WHERE Nom LIKE '%" + TXT_JOURNAL_NOM.Text + "%' AND ID LIKE '%" + TXT_JOURNAL_ID.Text + "%'")
        End If
        base.read(dataJourn, "Journal")
        DG_REST_JOURNAL.DataSource = dataJourn.Tables("Journal")
    End Sub

    Private Sub DG_REST_JOURNAL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_REST_JOURNAL.CellClick
        ligne = DG_REST_JOURNAL.SelectedCells.Item(0).RowIndex
        If Compte.Niveau < 3 Then
            BT_JOURN_SUPP.Enabled = True
        End If
    End Sub

    Private Sub DG_REST_JOURNAL_Leave(sender As Object, e As EventArgs) Handles DG_REST_JOURNAL.Leave
        If DG_REST_JOURNAL.SelectedCells.Count <> 1 Then
            BT_JOURN_SUPP.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_JOURN_SUPP.Click
        Dim id As Integer
        Dim nom As String
        If DG_REST_JOURNAL.SelectedCells.Count = 1 And DG_REST_JOURNAL.SelectedCells.Item(0).RowIndex = ligne Then
            nom = DG_REST_JOURNAL.Rows(ligne).Cells(1).Value
            If MsgBox("Voulez-vous vraiment supprimer : " + nom, 36, "Confirmation") = MsgBoxResult.Yes Then
                id = DG_REST_JOURNAL.Rows(ligne).Cells(0).Value
                base.execute("DELETE FROM [Journal Restitution] WHERE ID = " + id.ToString)
                BT_JOURNAL_ACTUALISER_Click(Nothing, Nothing)
            End If
        End If
    End Sub
End Class