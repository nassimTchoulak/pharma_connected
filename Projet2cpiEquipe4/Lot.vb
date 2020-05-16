Public Class Lot

    '--------------------Attribus---------------------------
    Private IDproduit As Integer
    Private requete As String
    Private prod As Produitt = New Produitt()
    Private dt4 As DataTable = New DataTable()
    Public bas4 As DataBase = New DataBase()
    Private quanActuel, total As String
    '-------------------Constructeur------------------------
    Sub New()

    End Sub

    '---------------------Méthodes-------------------------

    Public Function recherch_Lot(ByVal nomLot As String, ByRef datap2 As DataSet) As Boolean

        If prod.recherch_prod(nomLot, prod.dst) Then
            dt4 = prod.dst.Tables("Produit")
            IDproduit = dt4.Rows(0)("ID")
            bas4.execute("SELECT * FROM Lot WHERE IDproduit = " + IDproduit.ToString + " ")
            bas4.read(datap2, "Lot")
            dt4 = datap2.Tables("Lot")
            If (dt4.Rows.Count = 0) Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Public Function recherch_idLot(ByVal idlot As Integer, ByRef d3 As DataSet) As Boolean
        bas4.execute("SELECT * FROM Lot WHERE ID = " + idlot.ToString + " ")
        bas4.read(d3, "Lot")
        dt4 = d3.Tables("Lot")
        If (dt4.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Sub enregistrer_lot(ByVal nom As String, ByVal q As Integer, ByVal datEx As String, ByVal prixUachat As Double, ByVal marge As Double, ByVal PPA As Double, ByVal SHP As Double, ByVal prixUvente As Double, ByVal empla As String, ByVal exp As Integer)
        If prod.recherch_prod(nom, prod.dst) Then
            dt4 = prod.dst.Tables("Produit")
            IDproduit = dt4.Rows(0)("ID")

            quanActuel = dt4.Rows(0)("Quantité Actuelle")
            total = quanActuel + q
            bas4.execute("UPDATE Produit SET [Quantité Actuelle] = " + total.ToString + " WHERE ID = " + IDproduit.ToString + "  ")


            requete = "INSERT INTO Lot VALUES ( " + IDproduit.ToString + ",'" + datEx + "'," + q.ToString + "," + prixUachat.ToString + "," + marge.ToString + "," + PPA.ToString + "," + SHP.ToString + "," + prixUachat.ToString + ", '" + empla + "', " + exp.ToString + ")"
            bas4.execute(requete)
        Else
            MsgBox("ce produit n'existe pas")
        End If

    End Sub
End Class
