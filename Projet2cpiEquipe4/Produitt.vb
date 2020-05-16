Imports System.Data.SqlClient

Public Class Produitt


    Private produi As String

    Private dt As DataTable = New DataTable()
    Private dt2 As DataTable = New DataTable()
    Public bas As DataBase = New DataBase()
    Public dst As DataSet = New DataSet()
    Private requete As String


    '--------------------------------------------------------------------------
    '--------------------------------------------------------------------------
    '                          Constructeur
    Sub New()
        dst.Tables.Add("Prod")
        dst.Tables("Prod").Columns.Add("ID", GetType(String))
        dst.Tables("Prod").Columns.Add("Famille", GetType(String))
        dst.Tables("Prod").Columns.Add("Nom", GetType(String))
        dst.Tables("Prod").Columns.Add("DCI", GetType(String))
        dst.Tables("Prod").Columns.Add("Laboratoire", GetType(String))
        dst.Tables("Prod").Columns.Add("[Quantite actuelle]", GetType(String))
        dst.Tables("Prod").Columns.Add("[Quantite alerte]", GetType(String))
        dst.Tables("Prod").Columns.Add("Remboursement", GetType(String))
        dst.Tables("Prod").Columns.Add("[Code Equivalence]", GetType(String))
    End Sub




    Private Property DBNull As DataSet

    '--------------------------------------------------------------------------
    '--------------------------------------------------------------------------
    '                                 Méthodes

    Public Function recherch_prod(ByVal nomProd As String, ByRef datap As DataSet) As Boolean

        bas.execute("SELECT * FROM Produit WHERE Nom = '" + nomProd + "'")
        bas.read(datap, "Produit")
        dt = datap.Tables("Produit")
        If (dt.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function give_nomproduit(ByVal id As Integer) As String
        bas.execute("SELECT * FROM Produit WHERE ID = " + id.ToString + "")
        bas.read(dst, "Produit")
        dt = dst.Tables("Produit")
        Return dt.Rows(0)("Nom")

    End Function

    Public Function recherch_code(ByVal numcode As String, ByRef datap As DataSet) As Boolean

        bas.execute("SELECT * FROM Produit WHERE [Code Equivalence] = '" + numcode + "'")
        bas.read(datap, "Produit")
        dt2 = datap.Tables("Produit")
        If (dt2.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function recherch_idprod(ByVal id As Integer, ByRef datap As DataSet) As Boolean
        bas.execute("SELECT * FROM Produit WHERE ID = " + id.ToString + "")
        bas.read(datap, "Produit")
        dt2 = datap.Tables("Produit")
        If (dt2.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub enregistrer_produit(ByVal code As String, ByVal qt As Integer, ByVal ql As Integer, ByVal r As Double, ByVal f As String, ByRef lab As String, ByVal nm As String, ByVal dc As String)

        If Achat_ProduitAjout.RadioButton2.Checked Then
            If Not recherch_code(code, dst) Then
                bas.execute("INSERT INTO Equivalent VALUES(" + Achat_ProduitAjout.TextBox4.Text.ToString + ")")
                requete = "INSERT INTO Produit VALUES ( '" + f + "','" + nm + "','" + dc + "','" + lab + "'," & ql & "," & qt & "," & r & ",'" + code + "')"
                bas.execute(requete)
                MsgBox("l'ajout est terminé")
                Achat_ProduitAjout.Close()
            Else
                MsgBox("Ce code existe deja, veuillez introduire un code d'equivalence propre a ce nouveau produit")
                Achat_ProduitAjout.TextBox4.Text = ""
            End If
        Else
            If recherch_prod(code, dst) Then
                dt2 = dst.Tables("Produit")
                produi = dt2.Rows(0)("Code Equivalence")
                requete = "INSERT INTO Produit VALUES ( '" + f + "','" + nm + "','" + dc + "','" + lab + "'," & ql & "," & qt & "," & r & ",'" + produi + "')"
                bas.execute(requete)
                MsgBox("l'ajout est terminé")
                Achat_ProduitAjout.Close()
            Else
                MsgBox("Ce produit equivalent n'existe pas , veuillez entrer un produit existant equivalent")
                Achat_ProduitAjout.ComboBox4.Text = ""
            End If
        End If



    End Sub


End Class
