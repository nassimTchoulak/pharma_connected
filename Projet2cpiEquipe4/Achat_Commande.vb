Public Class Achat_Commande

    Inherits menu

    Public d, data2 As DataSet
    Public b As DataBase = New DataBase()
    Private j As Integer = 0
    Private h As String
    Private cmdd As Commande = New Commande()
    Private bonn As Bon = New Bon()
    Private datable As DataTable = New DataTable()
    Private bl, bll As Boolean
    Private nom, idc, q As String
    Private x As Integer
    Private Sub Bon_de_commade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ff As DataSet = New DataSet()
        Dim r, a As Integer
        DataGridView2.Columns(0).Width = 100

        b.execute("SELECT * FROM Fournisseur")
        r = b.read(ff, "Test")
        For a = 0 To r - 1
            ComboBox1.Items.Add(ff.Tables("Test").Rows(a).Item("Nom").ToString)
            ComboBox10.Items.Add(ff.Tables("Test").Rows(a).Item("Nom").ToString)
        Next
        d = New DataSet()
        d.Tables.Add("cmd")
        d.Tables("cmd").Columns.Add("Nom", GetType(String))
        d.Tables("cmd").Columns.Add("Quantité", GetType(String))
        d.Tables("cmd").Columns.Add("Validité", GetType(String))
        d.Tables("cmd").Columns.Add("IDcommande", GetType(String))
        DataGridView1.DataSource = d.Tables("cmd")
        Dim n As Integer = Me.Width - PNL_SIDE_MENU.Width
        DataGridView1.Columns(0).Width = 0.5 * n
        DataGridView1.Columns(1).Width = (1 / 6) * n
        DataGridView1.Columns(2).Width = (1 / 6) * n
        DataGridView1.Columns(3).Width = (1 / 6) * n
        '---------------------------------------------------------------
        data2 = New DataSet()
        data2.Tables.Add("bo")
        data2.Tables("bo").Columns.Add("Ref", GetType(String))
        data2.Tables("bo").Columns.Add("[Date Bon]", GetType(String))
        data2.Tables("bo").Columns.Add("Fournisseur", GetType(String))
        '----------------------------------------------------------------

        Label4.Text = ""
        Button2.Enabled = False
        Button5.Enabled = False

        Dim i, j As Integer

        ComboBox9.Text = "<tout>"
        ComboBox10.Text = "<tout>"

        ComboBox9.Items.Add("<tout>")
        ComboBox10.Items.Add("<tout>")

        b.execute("SELECT * FROM [Bon Commande]")
        b.read(D2, "Test")
        i = D2.Tables("Test").Rows.Count - 1
        For j = 0 To i
            DataGridView2.Rows.Add(D2.Tables("Test").Rows(j).Item("Ref").ToString, D2.Tables("Test").Rows(j).Item("Date bon").ToString, D2.Tables("Test").Rows(j).Item("Fournisseur").ToString, D2.Tables("Test").Rows(j).Item("Validité").ToString)
        Next
    End Sub

    Private Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.InitializeComponent()
        Bon_de_commade_Load(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click1(sender As Object, e As EventArgs) Handles Button2.Click
        datable = d.Tables("cmd")
        If datable.Rows.Count <> 0 Then
            For Me.j = 0 To ((datable.Rows.Count) - 1)
                nom = datable.Rows(Me.j)("Nom")
                idc = datable.Rows(Me.j)("IDcommande")
                q = datable.Rows(Me.j)("Quantité")
                cmdd.enregistrer_cmd(Val(idc), Val(q), nom, "Non valide")

            Next
            bonn.enregistrer_bon(Val(TextBox1.Text), ComboBox1.Text, DateTimePicker1.Text.ToString)
            Achat_finCommande.Show()


        Else
            MsgBox("Impossible d'enregistrer une liste de commandes vide")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label4.Text = "Champ obligatoire"
            bl = False
        ElseIf Not IsNumeric(TextBox1.Text) Then
            Label4.Text = "Valeur erronée"
            bl = False
        Else
            If (CInt(TextBox1.Text) <= 0) Then
                Label4.Text = "Valeur négative"
                bl = False
            Else
                If (bonn.verifie_numBon(Conversion.Val(TextBox1.Text), data2)) Then
                    Label4.Text = "ce numéro existe déjà"
                    bl = False
                Else

                    bl = True
                    Label4.Text = ""
                End If
            End If
        End If
        Button2.Enabled = (bl And bll)
        Button5.Enabled = bl And bll
    End Sub

    Private Sub Button4_Click1(sender As Object, e As EventArgs) Handles Button4.Click
        If ((DataGridView1.SelectedRows.Count - 1) >= 0) Then
            For Me.x = 0 To (DataGridView1.SelectedRows.Count - 1)
                Try
                    DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(x).Index)
                Catch

                End Try
            Next
        Else
            MsgBox("Erreur, aucune ligne est séléstionné")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not (bonn.verifie_numBon(Val(TextBox1.Text), data2)) Then
            Achat_CommandeAjout.Show()
        Else
            MsgBox("Ce numéro de bon existe deja, veuillez introduire un autre")
            TextBox1.Text = ""
        End If
    End Sub

    '----Journal


    Public D2 As DataSet = New DataSet()
    Private D1 As DataSet = New DataSet()
    Public dttt As DataTable = New DataTable()
    Private nbr, fildat, idprod, i, r As Integer
    Private facture As Facture
    Private produi As Produitt = New Produitt()
    Private bo As Bon = New Bon()
    Private namee, requete As String


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim z, w As Integer
        If e.ColumnIndex = 3 And e.RowIndex > -1 Then
            Try
                Achat_bonDetaille.Show()
                Achat_bonDetaille.f.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString
                Achat_bonDetaille.num.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
                Achat_bonDetaille.dat.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
                b.execute("SELECT * FROM Commande WHERE IDCommande = " & DataGridView2.CurrentRow.Cells(0).Value.ToString)
                b.read(Achat_bonDetaille.d5, "cmd")
                z = Achat_bonDetaille.d5.Tables("cmd").Rows.Count - 1
                For w = 0 To z
                    idprod = Val(Achat_bonDetaille.d5.Tables("cmd").Rows(w).Item("IDproduit").ToString)
                    If (produi.recherch_idprod(idprod, produi.dst)) Then
                        dttt = produi.dst.Tables("Produit")
                        namee = dttt.Rows(0)("Nom")
                        Achat_bonDetaille.DataGridView1.Rows.Add(namee, Achat_bonDetaille.d5.Tables("cmd").Rows(w).Item("Quantité").ToString, Achat_bonDetaille.d5.Tables("cmd").Rows(w).Item("Validité").ToString)
                    End If
                Next
            Catch ex As NullReferenceException
                MsgBox("Ligne vide")
            End Try
        End If

    End Sub

    Private Function trans(ByVal s As String, ByVal n As Integer) As String
        Dim s2 As String = ""
        Dim day, mon, yea, i As Integer
        day = Val(s.Substring(8, 2))
        mon = Val(s.Substring(5, 2))
        yea = Val(s.Substring(0, 4))

        For i = 1 To n
            If day = 1 Then
                day = 31
                If mon = 1 Then
                    mon = 12
                    yea = yea - 1
                Else
                    mon = mon - 1
                End If
            Else
                day = day - 1
            End If
        Next
        s2 = yea & "-"
        If mon <= 9 Then
            s2 += "0" & mon & "-"
        Else
            s2 = s2 & mon & "-"
        End If
        If day <= 9 Then
            s2 += "0" & day
        Else
            s2 = s2 & day
        End If

        Return s2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles filtrer.Click
        Dim i As Integer
        Dim bool1 As Boolean = False
        Dim requete As String = "SELECT * FROM [Bon Commande]"
        If ComboBox10.Text <> "<tout>" Or ComboBox9.Text <> "<tout>" Then
            requete += " where "
        End If


        If ComboBox10.Text <> "<tout>" Then
            requete += "Fournisseur = '" + ComboBox10.Text + "'"
            If ComboBox9.Text <> "<tout>" Then
                requete += " and "
            End If
        End If
        If ComboBox9.Text <> "<tout>" Then
            requete += "[Date bon] between '" + DateTimePicker4.Value.ToString.Substring(6, 4) + "-" + DateTimePicker4.Value.ToString.Substring(3, 2) + "-" + DateTimePicker4.Value.ToString.Substring(0, 2) + "' and '" + DateTimePicker5.Value.ToString.Substring(6, 4) + "-" + DateTimePicker5.Value.ToString.Substring(3, 2) + "-" + DateTimePicker5.Value.ToString.Substring(0, 2) + "'"

        End If
        ' Label2.Text = requete
        b.execute(requete)
        i = b.read(D2, "Test")
        ' i = D2.Tables("Test").Rows.Count - 1
        DataGridView2.Rows.Clear()
        For Me.j = 0 To i - 1

            DataGridView2.Rows.Add(D2.Tables("Test").Rows(j).Item("Ref").ToString, D2.Tables("Test").Rows(j).Item("Date bon").ToString, D2.Tables("Test").Rows(j).Item("Fournisseur").ToString)
        Next
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedValueChanged

        If ComboBox9.Text = "<personalisé>" Then
            DateTimePicker4.Enabled = True
            DateTimePicker5.Enabled = True
        Else
            DateTimePicker4.Enabled = False
            DateTimePicker5.Enabled = False
        End If

        If ComboBox9.Text = "Cette année" Then
            DateTimePicker5.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker4.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 372)
        End If
        If ComboBox9.Text = "Ce semestre" Then
            DateTimePicker5.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker4.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 186)
        End If
        If ComboBox9.Text = "Ce trimestre" Then
            DateTimePicker5.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker4.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 93)
        End If
        If ComboBox9.Text = "Ce mois" Then
            DateTimePicker5.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker4.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 31)
        End If
        If ComboBox9.Text = "Cette semaine" Then
            DateTimePicker5.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker4.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 7)
        End If

        If ComboBox9.Text = "Aujourd'hui" Then
            DateTimePicker5.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker4.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delete.Click
        If ((DataGridView2.SelectedRows.Count - 1) >= 0) Then
            Achat_warning.Show()
        Else
            MsgBox("Erreur, aucune ligne est séléstionné")
        End If
    End Sub

    Private Sub BT_PROD_ACTUALISER_Click(sender As Object, e As EventArgs) Handles BT_PROD_ACTUALISER.Click
        b = New DataBase()
        b.execute("SELECT * FROM [Bon Commande]")
        D2 = New DataSet()
        b.read(D2, "Test")
        DataGridView2.Rows.Clear()
        i = D2.Tables("Test").Rows.Count - 1
        For Me.j = 0 To i
            DataGridView2.Rows.Add(D2.Tables("Test").Rows(j).Item("Ref").ToString, D2.Tables("Test").Rows(j).Item("Date bon").ToString, D2.Tables("Test").Rows(j).Item("Fournisseur").ToString, D2.Tables("Test").Rows(j).Item("Validité").ToString)
        Next
    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.ColumnIndex = 4 And e.RowIndex > -1 Then
            Dim z, w As Integer
            Try
                Achat_bon.Show()
                Achat_bon.d5 = New DataSet()
                Achat_bon.f.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString
                Achat_bon.num.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
                Achat_bon.dat.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
                b.execute("SELECT Commande.IDproduit,Commande.Quantité FROM Commande WHERE IDCommande = " & DataGridView2.CurrentRow.Cells(0).Value.ToString)
                b.read(Achat_bon.d5, "Commande")
                z = Achat_bon.d5.Tables("Commande").Rows.Count - 1
                dttt = New DataTable()
                For w = 0 To z
                    idprod = Val(Achat_bon.d5.Tables("Commande").Rows(w).Item("IDproduit").ToString)
                    If (produi.recherch_idprod(idprod, produi.dst)) Then
                        dttt = produi.dst.Tables("Produit")
                        namee = dttt.Rows(0)("Nom")
                        Achat_bon.DataGridView1.Rows.Add(namee, Achat_bon.d5.Tables("Commande").Rows(w).Item("Quantité").ToString)
                    End If
                Next
            Catch ex As NullReferenceException
                MsgBox("Ligne vide")
            End Try
            Achat_bon.d5 = New DataSet()
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "" Then
            bll = False
        ElseIf ComboBox1.Text = " " Then
            bll = False
        Else
            bll = True
        End If
        Button2.Enabled = (bl And bll)
        Button5.Enabled = bl And bll
    End Sub

    
End Class