Public Class Commande

    Private IDproduit As Integer
    Private requete As String
    Public basee As DataBase = New DataBase()
    Public dstt As DataSet = New DataSet()
    Private pro As Produitt = New Produitt()
    Private dt3 As DataTable = New DataTable()
    '------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------
    '                              Constructeur
    Sub New()
        dstt.Tables.Add("Prod")
        dstt.Tables("Prod").Columns.Add("ID", GetType(String))
        dstt.Tables("Prod").Columns.Add("Famille", GetType(String))
        dstt.Tables("Prod").Columns.Add("Nom", GetType(String))
        dstt.Tables("Prod").Columns.Add("DCI", GetType(String))
        dstt.Tables("Prod").Columns.Add("Laboratoire", GetType(String))
        dstt.Tables("Prod").Columns.Add("[Quantite actuelle]", GetType(String))
        dstt.Tables("Prod").Columns.Add("[Quantite alerte]", GetType(String))
        dstt.Tables("Prod").Columns.Add("Remboursement", GetType(String))
        dstt.Tables("Prod").Columns.Add("[Code Equivalence]", GetType(String))


    End Sub



    '----------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------
    '                                    méthodes

    Sub affichr_commande()
        Achat_Commande.b.execute("SELECT * FROM Commande WHERE ")
    End Sub

    Sub enregistrer_cmd(ByVal id As Integer, ByVal q As Integer, ByVal n As String, ByRef vali As String)

        If (pro.recherch_prod(n, dstt)) Then
            dt3 = dstt.Tables("Produit")
            IDproduit = dt3.Rows(0)("ID")
            requete = "INSERT INTO Commande VALUES ( " + IDproduit.ToString + "," + id.ToString + "," + q.ToString + " , '" + vali + "')"
            basee.execute(requete)

        End If
    End Sub


End Class
