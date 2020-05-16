Public Class RestOperation


    Dim base As DataBase = New DataBase()
    Dim dataProd As DataSet
    Dim dataJourn As DataSet

    Public Sub chargementProduits(ByVal requete)
        dataProd = New DataSet
        base.execute(requete)
        base.read(dataProd, "Restitution")
        RestMain.DG_REST_PROD.DataSource = dataProd.Tables("Restitution")
        ajustementProduit()
    End Sub

    Public Sub chargementJournal(ByVal requete)
        dataJourn = New DataSet
        base.execute(requete)
        base.read(dataJourn, "Journal Restitution")
        RestMain.DG_REST_JOURNAL.DataSource = dataJourn.Tables("Journal Restitution")
        ajustementJournal()
    End Sub

    Public Sub ajustementProduit()
        RestMain.DG_REST_PROD.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        RestMain.DG_REST_PROD.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        RestMain.DG_REST_PROD.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        RestMain.DG_REST_PROD.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        'ALLIGNEMENT DES COLONNES
        RestMain.DG_REST_PROD.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        RestMain.DG_REST_PROD.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        RestMain.DG_REST_PROD.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Public Sub ajustementJournal()
        RestMain.DG_REST_JOURNAL.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        RestMain.DG_REST_JOURNAL.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        RestMain.DG_REST_JOURNAL.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        RestMain.DG_REST_JOURNAL.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        'ALLIGNEMENT DES COLONNES
        RestMain.DG_REST_JOURNAL.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        RestMain.DG_REST_JOURNAL.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        RestMain.DG_REST_JOURNAL.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
End Class

