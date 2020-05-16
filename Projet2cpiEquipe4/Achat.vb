Public Class Achat

    Private IDlot As Integer
    Private requete As String
    Public basee5 As DataBase = New DataBase()
    Public datalot As DataSet = New DataSet()
    Private lot As Lot = New Lot()
    Private dt3 As DataTable = New DataTable()

    Sub New()
        datalot.Tables.Add("lott")
        datalot.Tables("lott").Columns.Add("IDlot", GetType(String))
        datalot.Tables("lott").Columns.Add("IDfacture", GetType(String))
        datalot.Tables("lott").Columns.Add("Quantité", GetType(String))
        datalot.Tables("lott").Columns.Add("[Date Expiration]", GetType(String))
        datalot.Tables("lott").Columns.Add("[Prix Unitaire Achat]", GetType(String))
        datalot.Tables("lott").Columns.Add("Marge", GetType(String))
        datalot.Tables("lott").Columns.Add("PPA", GetType(String))
        datalot.Tables("lott").Columns.Add("SHP", GetType(String))
        datalot.Tables("lott").Columns.Add("[Prix Unitaire Vente]", GetType(String))
        datalot.Tables("lott").Columns.Add("[Prix Totale HT]", GetType(String))
        datalot.Tables("lott").Columns.Add("[TVA", GetType(String))
        datalot.Tables("lott").Columns.Add("[Prix Totale TTC]", GetType(String))

    End Sub

    Sub enregistrer_achat(ByVal nom As String, ByVal IDfact As Integer, ByVal q As Integer, ByVal datEx As String, ByVal prixUachat As Double, ByVal marge As Double, ByVal PPA As Double, ByVal SHP As Double, ByVal prixUvente As Double, ByVal prixtotalHT As Double, ByVal prixtotalTTC As Double, ByVal TVA As Double)
        If (lot.recherch_Lot(nom, datalot)) Then
            dt3 = datalot.Tables("Lot")
            IDlot = dt3.Rows(dt3.Rows.Count - 1)("ID")
            requete = "INSERT INTO Achat VALUES ( " + IDlot.ToString + "," + IDfact.ToString + "," + q.ToString + ", '" + datEx + "', " + prixUachat.ToString + ", " + marge.ToString + ", " + PPA.ToString + ", " + SHP.ToString + ", " + prixUvente.ToString + ", " + prixtotalHT.ToString + ", " + TVA.ToString + ", " + prixtotalTTC.ToString + ")"
            basee5.execute(requete)

        End If
    End Sub

End Class
