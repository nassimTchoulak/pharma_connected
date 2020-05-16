Public Class RestVente

    Dim base As DataBase = New DataBase()
    Dim monDataSet As New DataSet
    Dim qtInser As Integer
    Dim qtCorr As Boolean = False
    Dim nomCorr As Boolean = False
    Dim operation As New RestOperation

    Private Sub ResteVente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        base.execute("SELECT Nom FROM Restitution ")
        base.read(monDataSet, "Restitution")
        LSTB_REST.DataSource = monDataSet.Tables("Restitution")
        LSTB_REST.DisplayMember = "Nom"

        EP_QT.SetError(TXT_QT, "")
        BT_VALIDER.Enabled = False
    End Sub

    Private Sub TXT_NOM_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOM.TextChanged
        base.execute("SELECT * FROM Restitution WHERE Nom LIKE '%" + TXT_NOM.Text + "%'")
        monDataSet = New DataSet()
        base.read(monDataSet, "Restitue")

        LSTB_REST.DataSource = monDataSet.Tables("Restitue")
        LSTB_REST.DisplayMember = "Nom"
        nomCorr = False
        BT_VALIDER.Enabled = nomCorr And qtCorr
    End Sub

    Private Sub TXT_QT_TextChanged(sender As Object, e As EventArgs) Handles TXT_QT.TextChanged
        If TXT_QT.Text = "" Then
            EP_QT.SetError(TXT_QT, "Champ obligatoire")
            qtCorr = False
        ElseIf (Not IsNumeric(TXT_QT.Text)) Then
            EP_QT.SetError(TXT_QT, "Valeur erronée")
            qtCorr = False
        ElseIf (CInt(TXT_QT.Text) <= 0) Then
            EP_QT.SetError(TXT_QT, "Valeur erronée")
            qtCorr = False
        Else
            qtCorr = True
            qtInser = CInt(TXT_QT.Text)
            EP_QT.SetError(TXT_QT, "")
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr
    End Sub


    Private Sub LSTB_REST_DoubleClick(sender As Object, e As EventArgs) Handles LSTB_REST.DoubleClick
        TXT_NOM.Text = LSTB_REST.Text
        nomCorr = True
        BT_VALIDER.Enabled = nomCorr And qtCorr
    End Sub

    Private Sub BT_VALIDER_Click(sender As Object, e As EventArgs) Handles BT_VALIDER.Click
        Dim Requete As String
        Dim qtProd As Integer
        Dim dateVente As String = Date.Now
        Dim dateExp As String = "NULL"
        Dim nom As String

        If TXT_NOM.Text <> "" And nomCorr And qtCorr Then
            'Selection du produit a vendre
            Requete = "SELECT * FROM Restitution WHERE Nom = '" + TXT_NOM.Text + "'"
            base.execute(Requete)
            base.read(monDataSet, "Restitution")

            qtProd = monDataSet.Tables("Restitution").Rows(0).Item("Poids")
            nom = monDataSet.Tables("Restitution").Rows(0).Item("Nom")

            'CONVERSION DES DATES
            dateVente = "convert(date, '" + dateVente + "', 103)"
            If (Not IsDBNull(monDataSet.Tables("Restitution").Rows(0).Item("Date Expiration"))) Then
                dateExp = monDataSet.Tables("Restitution").Rows(0).Item("Date Expiration")
                dateExp = "convert(date, '" + dateExp + "', 103)"
            End If

            If qtProd >= qtInser Then
                'SI LA QUANTITE SAISIE EST CORRECTE
                EP_QT.SetError(TXT_QT, "")
                qtProd = qtProd - qtInser
                If qtProd = 0 Then
                    Requete = "DELETE FROM Restitution WHERE Nom = '" + TXT_NOM.Text + "'"
                Else
                    Requete = "UPDATE Restitution SET Poids = " + qtProd.ToString + " WHERE Nom = '" + TXT_NOM.Text + "'"
                End If
                base.execute(Requete)
                TXT_NOM.Text = ""
                TXT_QT.Text = ""
                EP_QT.SetError(TXT_QT, "")

                'Ajout dans le Journal de Restitution
                Requete = "INSERT INTO [Journal Restitution] VALUES ('" + nom + "'," + qtInser.ToString + ", " + dateVente + ", " + dateExp + ")"
                base.execute(Requete)
                operation.chargementProduits("SELECT * FROM Restitution")
                operation.chargementJournal("SELECT * FROM [Journal Restitution]")
                Me.Close()
            Else
                EP_QT.SetError(TXT_QT, "Quantité disponible = " + qtProd.ToString)
            End If
        Else
        End If
    End Sub
End Class