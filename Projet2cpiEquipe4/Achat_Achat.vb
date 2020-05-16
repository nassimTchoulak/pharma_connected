Public Class Achat_Achat

    Inherits menu
    Private IDfacture, Q, i, j, z, dif As Integer
    Private stopp, bl, bll As Boolean
    Private pua, mar, p, s, puv, pth, pttc, tv, sommeht, sommettc As Double
    Private ddtt, nom, ee, requete, di As String
    Private val As String = "Valide"
    Private nonval As String = "Non valide manque d unités: "
    Public dFA, dataf, dv, dc As DataSet
    Public bFA As DataBase = New DataBase()
    Private f As Facture = New Facture()
    Private ach As Achat = New Achat()
    Private dtable As DataTable = New DataTable()
    Private dtablecmd As DataTable = New DataTable()
    Private l As Lot = New Lot()
    Private bo As Bon = New Bon()
    Private pro As Produitt = New Produitt()
    Private compte As Integer = 0


    Private Sub Facture_achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ff As DataSet = New DataSet()
        Dim r, a As Integer
        bFA.execute("SELECT * FROM Fournisseur")
        r = bFA.read(ff, "Test")
        For a = 0 To r - 1
            ComboBox1.Items.Add(ff.Tables("Test").Rows(a).Item("Nom").ToString)
            ComboBox10.Items.Add(ff.Tables("Test").Rows(a).Item("Nom").ToString)
        Next

        dFA = New DataSet()
        dFA.Tables.Add("achat")
        dFA.Tables("achat").Columns.Add("Nom", GetType(String))
        dFA.Tables("achat").Columns.Add("Quantité", GetType(String))
        dFA.Tables("achat").Columns.Add("Date Expiration", GetType(String))
        dFA.Tables("achat").Columns.Add("Prix Achat", GetType(String))
        dFA.Tables("achat").Columns.Add("Marge", GetType(String))
        dFA.Tables("achat").Columns.Add("PPA", GetType(String))
        dFA.Tables("achat").Columns.Add("SHP", GetType(String))
        dFA.Tables("achat").Columns.Add("Prix Vente", GetType(String))
        dFA.Tables("achat").Columns.Add("ToTale HT", GetType(String))
        dFA.Tables("achat").Columns.Add("TVA", GetType(String))
        dFA.Tables("achat").Columns.Add("ToTale TTC", GetType(String))
        dFA.Tables("achat").Columns.Add("IDfacture", GetType(String))
        dFA.Tables("achat").Columns.Add("Emplacement", GetType(String))
        DataGridView1.DataSource = dFA.Tables("achat")

        '-------------------------------------------------------------------------
        dataf = New DataSet()
        dataf.Tables.Add("facture")
        dataf.Tables("facture").Columns.Add("Ref", GetType(String))
        dataf.Tables("facture").Columns.Add("[Date Facture]", GetType(String))
        dataf.Tables("facture").Columns.Add("Fournisseur", GetType(String))
        dataf.Tables("facture").Columns.Add("[Montant HT]", GetType(String))
        dataf.Tables("facture").Columns.Add("[Montant TTC]", GetType(String))
        '------------------------------------------------------------------------
        dc = New DataSet()
        dc.Tables.Add("cmde")
        dc.Tables("cmde").Columns.Add("ID", GetType(String))
        dc.Tables("cmde").Columns.Add("IDproduit", GetType(String))
        dc.Tables("cmde").Columns.Add("IDcommande", GetType(String))
        dc.Tables("cmde").Columns.Add("Quantité", GetType(String))
        dc.Tables("cmde").Columns.Add("Validité", GetType(String))

        Label6.Text = ""
        Label7.Text = ""
        EP_NumBon.SetError(TextBox2, "")
        EP_NumFacture.SetError(TextBox1, "")
        Button77.Enabled = False
        Button2.Enabled = False

    End Sub


    Private Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.InitializeComponent()
        Facture_achat_Load(Nothing, Nothing)
        Achat_historique_facture_Load(Nothing, Nothing)
        ' DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        dtable = dFA.Tables("achat")
        If dtable.Rows.Count = 0 Then
            MsgBox("L'enregistrement d'une facture d'achat vide est impossible")
        Else
            For Me.j = 0 To ((dtable.Rows.Count) - 1)
                nom = dtable.Rows(Me.j)("Nom")
                Q = dtable.Rows(Me.j)("Quantité")
                ddtt = dtable.Rows(Me.j)("Date Expiration")
                pua = dtable.Rows(Me.j)("Prix Achat")
                mar = dtable.Rows(Me.j)("Marge")
                p = dtable.Rows(Me.j)("PPA")
                s = dtable.Rows(Me.j)("SHP")
                puv = dtable.Rows(Me.j)("Prix Vente")
                pth = dtable.Rows(Me.j)("ToTale HT")
                pttc = dtable.Rows(Me.j)("ToTale TTC")
                tv = dtable.Rows(Me.j)("TVA")
                ee = dtable.Rows(Me.j)("Emplacement")
                l.enregistrer_lot(nom, Q, ddtt, pua, mar, p, s, puv, ee, 0)
                ach.enregistrer_achat(nom, Conversion.Val(TextBox1.Text), Q, ddtt, pua, mar, p, s, puv, pth, pttc, tv)

            Next
            f.enregistrer_fac(Conversion.Val(TextBox1.Text), ComboBox1.Text, DateTimePicker1.Text.ToString, Conversion.Val(Label6.Text), Conversion.Val(Label7.Text))
            dv = New DataSet()
            If bo.verifie_numBon(Conversion.Val(TextBox2.Text), dv) Then
                bFA.execute("SELECT * FROM Commande WHERE IDcommande = " + TextBox2.Text.ToString + "")
                bFA.read(dc, "cmde")
                dtablecmd = dc.Tables("cmde")
                For Me.j = 0 To ((dtable.Rows.Count) - 1)
                    stopp = False
                    Me.z = 0
                    While (Not stopp) And (z <= dtablecmd.Rows.Count - 1)
                        nom = pro.give_nomproduit(dtablecmd.Rows(Me.z)("IDproduit"))
                        If dtable.Rows(Me.j)("Nom") = nom Then
                            stopp = True
                            dif = dtablecmd.Rows(Me.z)("Quantité") - dtable.Rows(Me.j)("Quantité")
                            di = dif.ToString
                            If (dif = 0) Then
                                bFA.execute("UPDATE Commande SET Validité='" + val + "' WHERE IDproduit = " + dtablecmd.Rows(Me.z)("IDproduit").ToString + " AND IDcommande = " + TextBox2.Text.ToString + " ")
                                compte = compte + 1
                            Else
                                nonval = nonval + di
                                bFA.execute("UPDATE Commande SET Validité='" + nonval + "' WHERE IDproduit = " + dtablecmd.Rows(Me.z)("IDproduit").ToString + "  AND IDcommande = " + TextBox2.Text.ToString + "")

                                nonval = "Non valide manque d unités: "
                            End If
                        End If
                        Me.z = Me.z + 1
                    End While
                Next


                If (compte = dtablecmd.Rows.Count) Then
                    bFA.execute("UPDATE [Bon Commande] SET Validité='" + val + "' WHERE Ref = " + TextBox2.Text.ToString + " ")
                End If
                compte = 0
            End If
            Me.InitializeComponent()
            Facture_achat_Load(Nothing, Nothing)
            Achat_historique_facture_Load(Nothing, Nothing)
            Me.Refresh()
            ' DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (DataGridView1.SelectedRows.Count - 1 >= 0) Then
            For Me.i = 0 To (DataGridView1.SelectedRows.Count - 1)
                Try
                    DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(i).Index)
                Catch ex As Exception

                End Try
            Next
            If (DataGridView1.Rows.Count - 1) > 0 Then
                For Me.i = 0 To (DataGridView1.Rows.Count - 1)
                    sommeht = sommeht + DataGridView1.Rows(Me.i).Cells("[Prix Totale HT]").Value
                    sommettc = sommettc + DataGridView1.Rows(Me.i).Cells("[Prix Totale TTC]").Value
                Next
            Else
                sommeht = 0
                sommettc = 0

            End If
            Label6.Text = sommeht.ToString
            Label7.Text = sommettc.ToString
        Else
            MsgBox("Erreur.Aucune ligne est séléctioné")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        dv = New DataSet()
        If bo.verifie_numBon(Conversion.Val(TextBox2.Text), dv) Then
            EP_NumBon.SetError(TextBox2, "")
        ElseIf TextBox2.Text = "" Then
            EP_NumBon.SetError(TextBox2, "Champ requis")
        Else
            EP_NumBon.SetError(TextBox2, "N° inexistant")
        End If
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        If Not (f.verifie_numFac(Conversion.Val(TextBox1.Text), dataf)) Then
            Achat_AjtFact.Show()
        Else
            MsgBox("ne numéro de facture existe déja, veuillez introduire un nouveau numéro ")
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (f.verifie_numFac(Conversion.Val(TextBox1.Text), dataf)) Then
            EP_NumFacture.SetError(TextBox1, "N° existe déjà")
            bl = False
        ElseIf TextBox1.Text = "" Then
            EP_NumFacture.SetError(TextBox1, "Champ requis")
            bl = False
        Else
            If Not IsNumeric(TextBox1.Text) Then
                EP_NumFacture.SetError(TextBox1, "Valeur erronée")
                bl = False
            Else
                If TextBox1.Text <= 0 Then
                    EP_NumFacture.SetError(TextBox1, "Valeur erronée")
                    bl = False
                Else
                    EP_NumFacture.SetError(TextBox1, "")
                    bl = True
                End If

            End If

        End If
        Button77.Enabled = bl And bll
        Button2.Enabled = bl And bll
    End Sub


    Private d3 As DataSet = New DataSet()
    Private bas3 As DataBase = New DataBase()
    Private dttt2 As DataTable = New DataTable()
    Private dttt3 As DataTable = New DataTable()
    Private namee As String
    Private x, idprod, idlot As Integer
    Private produi As Produitt = New Produitt()
    Private lott As Lot = New Lot()
    '  Private fact As Achat_Facture_achat = New Achat_Facture_achat()

    Private Sub Achat_historique_facture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        d3.Tables.Add("achat2")
        d3.Tables("achat2").Columns.Add("Nom", GetType(String))
        d3.Tables("achat2").Columns.Add("Quantité", GetType(String))
        d3.Tables("achat2").Columns.Add("[Date Expiration]", GetType(String))
        d3.Tables("achat2").Columns.Add("[Prix Unitaire Achat]", GetType(String))
        d3.Tables("achat2").Columns.Add("Marge", GetType(String))
        d3.Tables("achat2").Columns.Add("PPA", GetType(String))
        d3.Tables("achat2").Columns.Add("SHP", GetType(String))
        d3.Tables("achat2").Columns.Add("[Prix Unitaire Vente]", GetType(String))
        d3.Tables("achat2").Columns.Add("[Prix Totale HT]", GetType(String))
        d3.Tables("achat2").Columns.Add("TVA", GetType(String))
        d3.Tables("achat2").Columns.Add("[Prix Totale TTC]", GetType(String))
        d3.Tables("achat2").Columns.Add("IDfacture", GetType(String))
        d3.Tables("achat2").Columns.Add("Emplacement", GetType(String))

        ComboBox9.Text = "<tout>"
        ComboBox10.Text = "<tout>"

        ComboBox9.Items.Add("<tout>")
        ComboBox10.Items.Add("<tout>")

        bas3.execute("SELECT * FROM [Facture Achat] ")
        x = bas3.read(d3, "facture")
        ' x = d3.Tables("facture").Rows.Count - 1
        For Me.j = 0 To x - 1
            DataGridView2.Rows.Add(d3.Tables("facture").Rows(j).Item("Ref").ToString, d3.Tables("facture").Rows(j).Item("Date Facture").ToString, d3.Tables("facture").Rows(j).Item("Fournisseur").ToString, d3.Tables("facture").Rows(j).Item("Montant HT").ToString, d3.Tables("facture").Rows(j).Item("Montant TTC").ToString)
        Next
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim z, w As Integer
        If e.RowIndex > -1 Then
            Try
                Achat_FactureDetaille.f.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString
                Achat_FactureDetaille.num.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
                Achat_FactureDetaille.dat.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
                bas3.execute("SELECT * FROM Achat WHERE IDfacture = " & DataGridView2.CurrentRow.Cells(0).Value.ToString)
                z = bas3.read(Achat_FactureDetaille.d6, "achat")
                ' z = Achat_FactureDetaille.d6.Tables("achat").Rows.Count - 1
                For w = 0 To z - 1
                    idlot = CInt(Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("IDlot").ToString)
                    If (lott.recherch_idLot(idlot, d3)) Then
                        dttt3 = d3.Tables("Lot")
                        idprod = dttt3.Rows(0)("IDproduit")
                        If (produi.recherch_idprod(idprod, produi.dst)) Then
                            dttt2 = produi.dst.Tables("Produit")
                            namee = dttt2.Rows(0)("Nom")
                            Achat_FactureDetaille.DataGridView1.Rows.Add(namee, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("Quantité").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("Date Expiration").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("Prix Unitaire Achat").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("Marge").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("PPA").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("SHP").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("Prix Unitaire Vente").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("Prix Totale HT").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("TVA").ToString, Achat_FactureDetaille.d6.Tables("achat").Rows(w).Item("Prix Totale TTC").ToString, d3.Tables("Lot").Rows(0).Item("Emplacement").ToString)
                        End If
                    End If
                Next
                Achat_FactureDetaille.Label3.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString
                Achat_FactureDetaille.Label6.Text = DataGridView2.CurrentRow.Cells(4).Value.ToString
                Achat_FactureDetaille.Show()
            Catch ex As NullReferenceException
                MsgBox("Ligne vide")
            End Try
        End If
    End Sub
    Private Function trans(ByVal s As String, ByVal n As Integer) As String
        Dim s2 As String = ""
        Dim day, mon, yea, i As Integer
        day = CInt(s.Substring(8, 2))
        mon = CInt(s.Substring(5, 2))
        yea = CInt(s.Substring(0, 4))

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
        Dim requete As String = "SELECT * FROM [Facture achat]"
        Dim d2 As DataSet = New DataSet()
        Dim b As DataBase = New DataBase()
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
            requete += "[Date Facture] between '" + DateTimePicker4.Value.ToString.Substring(6, 4) + "-" + DateTimePicker4.Value.ToString.Substring(3, 2) + "-" + DateTimePicker4.Value.ToString.Substring(0, 2) + "' and '" + DateTimePicker5.Value.ToString.Substring(6, 4) + "-" + DateTimePicker5.Value.ToString.Substring(3, 2) + "-" + DateTimePicker5.Value.ToString.Substring(0, 2) + "'"

        End If
        ' Label2.Text = requete
        b.execute(requete)
        i = b.read(d2, "Test")
        ' i = D2.Tables("Test").Rows.Count - 1
        DataGridView2.Rows.Clear()
        For Me.j = 0 To i - 1

            DataGridView2.Rows.Add(d2.Tables("Test").Rows(j).Item("Ref").ToString, d2.Tables("Test").Rows(j).Item("Date Facture").ToString, d2.Tables("Test").Rows(j).Item("Fournisseur").ToString, d2.Tables("Test").Rows(j).Item("Montant HT").ToString, d2.Tables("Test").Rows(j).Item("Montant TTC").ToString)
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

    Private Sub ComboBox1_TextChange(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "" Then
            bll = False
        ElseIf ComboBox1.Text = " " Then
            bll = False
        Else
            bll = True
        End If
        Button77.Enabled = bl And bll
        Button2.Enabled = bl And bll
    End Sub


End Class