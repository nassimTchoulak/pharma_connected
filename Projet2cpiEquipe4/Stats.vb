Public Class Stats
    Inherits menu
    Private bs As New DataBase
    Dim bs1 As DataBase = New DataBase()


    Public Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick


        If e.Node.Text.Equals("Produits Plus Vendus") Then
            Chart1.Series("prix").Points.Clear()

            Dim dt As New DataSet()
            bs.execute("select top 7 Vente.IDproduit, sum(Quantité)as Q  from Vente Group by IDproduit Order by Q desc")
            Dim z5 As Integer = bs.read(dt, "Lot3")

            z5 = z5 - 1
            Dim dtt As DataTable = dt.Tables("Lot3")

            Dim l As New DataSet()
            For w = 0 To z5


                Chart1.Series("prix").Points.AddXY(dtt.Rows(w)("IDproduit"), dtt.Rows(w)("Q"))

            Next

        End If
        If e.Node.Text.Equals("Produits Plus Commandés") Then
            Chart1.Series("prix").Points.Clear()
            Dim dt1 As DataSet = New DataSet()
            Dim bs1 As DataBase = New DataBase()
            Dim dttt1 As DataTable = New DataTable()
            Dim dtt1 As DataTable = New DataTable()
            Dim produi1 As Produitt = New Produitt()
            Dim z1, idprod1, w1 As Integer
            Dim namee1 As String

            bs1 = New DataBase()
            dttt1 = New DataTable()
            dtt1 = New DataTable()
            dt1 = New DataSet()
            bs1.execute("select top 7 Commande.IDproduit, sum(Quantité)as Q  from Commande Group by IDproduit Order by Q desc")
            bs1.read(dt1, "Lot")

            z1 = dt1.Tables("Lot").Rows.Count - 1
            dtt1 = dt1.Tables("Lot")
            For w1 = 0 To z1
                idprod1 = Val(dt1.Tables("Lot").Rows(w1).Item("IDproduit").ToString)
                If (produi1.recherch_idprod(idprod1, produi1.dst)) Then
                    dttt1 = produi1.dst.Tables("Produit")
                    namee1 = dttt1.Rows(0)("Nom")
                    Chart1.Series("prix").Points.AddXY(namee1, dtt1.Rows(w1)("Q"))
                End If
            Next
        End If
        If e.Node.Text.Equals("Produits Plus achetés") Then
            Chart1.Series("prix").Points.Clear()
            Dim dt1 As DataSet = New DataSet()
            Dim bs1 As DataBase = New DataBase()
            Dim dttt1 As DataTable = New DataTable()
            Dim dtt1 As DataTable = New DataTable()
            Dim produi1 As Produitt = New Produitt()
            Dim z1, idprod1, w1 As Integer
            Dim namee1 As String

            bs1 = New DataBase()
            dttt1 = New DataTable()
            dtt1 = New DataTable()
            dt1 = New DataSet()
            bs1.execute("select top 7 Lot.IDproduit, sum(Quantité)as Q  from Lot Group by IDproduit Order by Q desc")
            bs1.read(dt1, "Lot")

            z1 = dt1.Tables("Lot").Rows.Count - 1
            dtt1 = dt1.Tables("Lot")
            For w1 = 0 To z1
                idprod1 = Val(dt1.Tables("Lot").Rows(w1).Item("IDproduit").ToString)
                If (produi1.recherch_idprod(idprod1, produi1.dst)) Then
                    dttt1 = produi1.dst.Tables("Produit")
                    namee1 = dttt1.Rows(0)("Nom")
                    Chart1.Series("prix").Points.AddXY(namee1, dtt1.Rows(w1)("Q"))
                End If
            Next

        End If
        If e.Node.Text.Equals("Produits Plus chéres") Then
            Chart1.Series("prix").Points.Clear()

            Dim dt As DataSet = New DataSet()
            Dim dttt As DataTable = New DataTable()
            Dim dtt As DataTable = New DataTable()
            Dim produi As Produitt = New Produitt()
            Dim z, idprod, w As Integer
            Dim namee As String



            bs.execute("select distinct top 7 IDproduit,[Prix Unitaire Vente] from Lot order by [Prix Unitaire Vente] desc")
            bs.read(dt, "Lot")

            z = dt.Tables("Lot").Rows.Count - 1
            dtt = dt.Tables("Lot")
            For w = 0 To z
                idprod = Val(dt.Tables("Lot").Rows(w).Item("IDproduit").ToString)
                If (produi.recherch_idprod(idprod, produi.dst)) Then
                    dttt = produi.dst.Tables("Produit")
                    namee = dttt.Rows(0)("Nom")

                    Chart1.Series("prix").Points.AddXY(namee, dtt.Rows(w)("Prix Unitaire Vente"))
                End If
            Next





        End If

        If e.Node.Text.Equals("Produits Plus restitué") Then
            Chart1.Series("prix").Points.Clear()

            Dim dt As New DataSet()
            bs.execute("select top 7 [Journal Restitution].Nom, sum(CONVERT ( int, Quantité ))as Q  from [Journal Restitution] Group by Nom Order by Q desc")
            Dim z5 As Integer = bs.read(dt, "Lot3")

            z5 = z5 - 1
            Dim dtt As DataTable = dt.Tables("Lot3")

            Dim l As New DataSet()
            For w = 0 To z5


                Chart1.Series("prix").Points.AddXY(dtt.Rows(w)("Nom"), dtt.Rows(w)("Q"))

            Next
        End If
        If e.Node.Text.Equals("Produits Plus restituable") Then
            Chart1.Series("prix").Points.Clear()

            Dim dt As New DataSet()
            bs.execute("select top 7 [Restitution].Nom, sum(Poids)as Q  from [Restitution] Group by Nom Order by Q desc")
            Dim z5 As Integer = bs.read(dt, "Lot3")

            z5 = z5 - 1
            Dim dtt As DataTable = dt.Tables("Lot3")

            Dim l As New DataSet()
            For w = 0 To z5


                Chart1.Series("prix").Points.AddXY(dtt.Rows(w)("Nom"), dtt.Rows(w)("Q"))

            Next
        End If
        If e.Node.Text.Equals("Produits Plus périmés") Then
            Chart1.Series("prix").Points.Clear()

            Dim d As DataSet = New DataSet
            bs.execute("SELECT TOP 7 Produit.Nom,Produit.[Quantité Actuelle],Lot.Expiré,Lot.[Date Expiration] FROM Lot,Produit where Lot.IDproduit=Produit.ID AND Expiré = '1' order by [Quantité Actuelle] desc")
            bs.read(d, "Lot")
            Chart1.DataSource = d
            Chart1.Series("prix").XValueMember = "Nom"
            Chart1.Series("prix").YValueMembers = "Quantité Actuelle"
        End If
        If e.Node.Text.Equals("Produits Plus disponible") Then
            Chart1.Series("prix").Points.Clear()

            Dim d As DataSet = New DataSet
            bs.execute("SELECT TOP 7 Nom,[Quantité Actuelle] FROM Produit order by [Quantité Actuelle] desc")
            bs.read(d, "Lot")
            Chart1.DataSource = d
            Chart1.Series("prix").XValueMember = "Nom"
            Chart1.Series("prix").YValueMembers = "Quantité Actuelle"
        End If
        If e.Node.Text.Equals("Produits Plus Remboursable") Then
            Chart1.Series("prix").Points.Clear()

            Dim d As DataSet = New DataSet
            bs.execute("SELECT TOP 7 Nom,Remboursement FROM Produit order by [Remboursement] desc")
            bs.read(d, "Lot")
            Chart1.DataSource = d
            Chart1.Series("prix").XValueMember = "Nom"
            Chart1.Series("prix").YValueMembers = "Remboursement"
        End If
        If e.Node.Text.Equals("Degrés d'échange") Then
            Chart1.Series("prix").Points.Clear()

            Dim d As DataSet = New DataSet
            bs.execute("SELECT TOP 7 Nom,[Degré Echange] FROM Pharmacie order by [Degré Echange] desc")
            bs.read(d, "Lot")
            Chart1.DataSource = d
            Chart1.Series("prix").XValueMember = "Nom"
            Chart1.Series("prix").YValueMembers = "Degré Echange"
        End If

    End Sub

  
    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class