
Public Class Stock_Verification
    Private b As DataBase = New DataBase()
    Public Function Verifier_Proche_Peremption() As DataSet
        Dim d As DataSet = New DataSet()
        Dim aaaa, mm, jj, dat, now As String
        d = New DataSet()
        aaaa = Date.Now.ToString.Substring(6, 4)
        mm = Date.Now.ToString.Substring(3, 2)
        jj = Date.Now.ToString.Substring(0, 2)
        now = aaaa + "-" + mm + "-" + jj + " " + Date.Now.ToString.Substring(11, 8)
        aaaa = Date.Now.AddDays(30).ToString.Substring(6, 4)
        mm = Date.Now.AddDays(30).ToString.Substring(3, 2)
        jj = Date.Now.AddDays(30).ToString.Substring(0, 2)
        dat = aaaa + "-" + mm + "-" + jj + " " + Date.Now.AddDays(30).ToString.Substring(11, 8)
        b.execute("SELECT * FROM Lot WHERE [Date Expiration] BETWEEN '" + now + "' AND '" + dat + "'")
        b.read(d, "Lot")
        Return d
    End Function
    Public Function Verifier_Perime() As DataSet
        Dim d As DataSet = New DataSet()
        Dim aaaa, mm, jj, now As String
        d = New DataSet()
        aaaa = Date.Now.ToString.Substring(6, 4)
        mm = Date.Now.ToString.Substring(3, 2)
        jj = Date.Now.ToString.Substring(0, 2)
        now = aaaa + "-" + mm + "-" + jj + " " + Date.Now.ToString.Substring(11, 8)
        b.execute("UPDATE Lot SET Expiré='1' WHERE [Date Expiration] <= '" + now + "'")
        b.execute("SELECT * FROM Lot WHERE Expiré=1")
        b.read(d, "Lot")
        Return d
    End Function

    Public Function Verifier_Rupture() As DataSet
        Dim d As DataSet = New DataSet()
        Dim data As DataGridView = New DataGridView()
        b.execute("SELECT * FROM Produit WHERE [Quantité Actuelle] <= [Quantité Alerte] ")
        b.read(d, "Produit")
        data.DataSource = d.Tables("Produit")
        Return d
    End Function
End Class

