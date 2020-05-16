Public Class Stock
    Inherits menu
    Private b As DataBase = New DataBase()
    Private d, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d17, dx, x As DataSet
    Private p As ProgressBar = New ProgressBar()

    Private Sub En_Tps_Reel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Visible = False
        ProgressBar.ShowDialog()

        '------------------------------------------------------------------- temps réel -------------------------------------
        b.execute("SELECT * FROM Produit")
        b.read(d, "Produit")
        ComboBox1.DataSource = d.Tables("Produit")
        ComboBox1.DisplayMember = "Nom"
        ComboBox1.Text = ""
        ComboBox3.DataSource = d.Tables("Produit")
        ComboBox3.DisplayMember = "DCI"
        ComboBox3.Text = ""

        b.execute("SELECT * FROM Equivalent")
        b.read(d, "Equiv")
        ComboBox5.DataSource = d.Tables("Equiv")
        ComboBox5.DisplayMember = "Code Equivalence"
        ComboBox5.Text = ""
        d = New DataSet()
        ' b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte]")
        b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.ID = Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte]")

        b.read(d, "Produit")
        If (d.Tables("Produit").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If
        DataGridView1.DataSource = d.Tables("Produit")
        Dim n As Integer = Me.Width - PNL_SIDE_MENU.Width - 20 - 600 - 20
        DataGridView1.Columns(0).Width = n / 2
        DataGridView1.Columns(1).Width = n / 2
        DataGridView1.Columns(2).HeaderText = "Lot"
        ' Dim n As Integer = Me.Width - PNL_SIDE_MENU.Width - 20
        'DataGridView1.Columns(0).Width = 0.23 * n
        'DataGridView1.Columns(1).Width = 0.23 * n
        'DataGridView1.Columns(2).Width = 0.23 * n
        'DataGridView1.Columns(3).Width = 0.077 * n
        'DataGridView1.Columns(4).Width = 0.077 * n
        'DataGridView1.Columns(5).Width = 0.077 * n
        'DataGridView1.Columns(6).Width = n - (0.077 * n * 3) - (0.23 * 3 * n)


        '------------------------------------------------------------------- tous les lots-------------------------------------
        b.execute("SELECT * FROM Lot")
        b.read(d2, "Lot")
        ComboBox6.DataSource = d2.Tables("Lot")
        ComboBox6.DisplayMember = "Id"
        ComboBox6.Text = ""
        ComboBox7.DataSource = d2.Tables("Lot")
        ComboBox7.DisplayMember = "Idproduit"
        ComboBox7.Text = ""
        d3 = New DataSet()
        b.execute("SELECT Nom FROM Produit")
        b.read(d3, "Nom")
        ComboBox8.DataSource = d3.Tables("Nom")
        ComboBox8.DisplayMember = "Nom"
        ComboBox8.Text = ""
        b.execute("SELECT Produit.Nom,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Achat],lot.Marge,lot.PPA,lot.SHP,lot.[Prix Unitaire Vente],lot.Emplacement FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit")
        b.read(d2, "Lot")
        If (d2.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun lot existant dans la base")
        End If
        DataGridView2.DataSource = d2.Tables("Lot")
        Dim n2 As Integer = Me.Width - PNL_SIDE_MENU.Width - 20 - 900 - 20
        DataGridView2.Columns(0).Width = n2
        DataGridView2.Columns(1).HeaderText = "Lot"
        '----------------------------------------------------------------- tous les produits -------------------------------------------
        d4 = New DataSet()
        d5 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(d4, "Produit")
        ComboBox16.DataSource = d4.Tables("Produit")
        ComboBox16.DisplayMember = "Nom"
        ComboBox16.Text = ""
        ComboBox27.DataSource = d4.Tables("Produit")
        ComboBox27.DisplayMember = "DCI"
        ComboBox27.Text = ""
        b.execute("SELECT * FROM Laboratoire")
        b.read(d5, "lab")
        ComboBox18.DataSource = d5.Tables("lab")
        ComboBox18.DisplayMember = "Nom"
        ComboBox18.Text = ""
        b.execute("SELECT * FROM Equivalent ")
        b.read(d5, "Equiv")
        ComboBox19.DataSource = d5.Tables("Equiv")
        ComboBox19.DisplayMember = "Code Equivalence"
        ComboBox19.Text = ""

        b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit")
        b.read(d4, "Produit")
        If (d4.Tables("Produit").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If
        DataGridView5.DataSource = d4.Tables("Produit")
        Dim n1 As Integer = Me.Width - PNL_SIDE_MENU.Width - 20
        DataGridView5.Columns(0).Width = 0.23 * n1
        DataGridView5.Columns(1).Width = 0.23 * n1
        DataGridView5.Columns(2).Width = 0.23 * n1
        DataGridView5.Columns(3).Width = 0.077 * n1
        DataGridView5.Columns(4).Width = 0.077 * n1
        DataGridView5.Columns(5).Width = 0.077 * n1
        DataGridView5.Columns(6).Width = n1 - (0.077 * n1 * 3) - (0.23 * 3 * n1)
        '------------------------------------------------Lot perimé------------------------------------------------------------
        d6 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(d6, "Produit")
        ComboBox10.DataSource = d6.Tables("Produit")
        ComboBox10.DisplayMember = "Nom"
        ComboBox10.Text = ""
        ComboBox12.DataSource = d6.Tables("Produit")
        ComboBox12.DisplayMember = "DCI"
        ComboBox12.Text = ""
        b.execute("SELECT * FROM Equivalent")
        b.read(d6, "Equiv")
        ComboBox13.DataSource = d6.Tables("Equiv")
        ComboBox13.DisplayMember = "Code Equivalence"
        ComboBox13.Text = ""
        b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré = 1")
        b.read(d6, "Lot")
        If (d6.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est périmé")
        End If
        DataGridView3.DataSource = d6.Tables("Lot")
        DataGridView3.Columns(0).Width = n / 2
        DataGridView3.Columns(1).Width = n / 2
        DataGridView3.Columns(2).HeaderText = "Lot"
        '------------------------------------Proche de peremption--------------------------------------------------------------
        Dim aaaa, mm, jj, dat, now As String
        d8 = New DataSet()
        aaaa = Date.Now.ToString.Substring(6, 4)
        mm = Date.Now.ToString.Substring(3, 2)
        jj = Date.Now.ToString.Substring(0, 2)
        now = aaaa + "-" + mm + "-" + jj + " " + Date.Now.ToString.Substring(11, 8)
        aaaa = Date.Now.AddDays(30).ToString.Substring(6, 4)
        mm = Date.Now.AddDays(30).ToString.Substring(3, 2)
        jj = Date.Now.AddDays(30).ToString.Substring(0, 2)
        dat = aaaa + "-" + mm + "-" + jj + " " + Date.Now.AddDays(30).ToString.Substring(11, 8)
        b.execute("SELECT * FROM Produit")
        b.read(d8, "Produit")
        ComboBox14.DataSource = d8.Tables("Produit")
        ComboBox14.DisplayMember = "Nom"
        ComboBox14.Text = ""
        b.execute("SELECT * FROM Equivalent")
        b.read(d8, "Equiv")
        ComboBox15.DataSource = d8.Tables("Equiv")
        ComboBox15.DisplayMember = "Code Equivalence"
        ComboBox15.Text = ""
        b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.[Date Expiration] BETWEEN '" + now + "'AND '" + dat + "'")
        b.read(d8, "Lot")
        If (d8.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun produit ne va se périmer pendant ce mois")
        End If
        DataGridView4.DataSource = d8.Tables("Lot")
        DataGridView4.Columns(0).Width = n / 2
        DataGridView4.Columns(1).Width = n / 2
        DataGridView4.Columns(2).HeaderText = "Lot"
        '-------------------------------Rupture
        d10 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(d10, "Produit")
        ComboBox22.DataSource = d10.Tables("Produit")
        ComboBox22.DisplayMember = "Nom"
        ComboBox22.Text = ""
        b.execute("SELECT * FROM Equivalent")
        b.read(d10, "Equiv")
        ComboBox24.DataSource = d10.Tables("Equiv")
        ComboBox24.DisplayMember = "Code Equivalence"
        ComboBox24.Text = ""
        b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit WHERE [Quantité Actuelle] <= [Quantité Alerte] ")
        b.read(d10, "Produit")
        If (d10.Tables("Produit").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If
        DataGridView7.DataSource = d10.Tables("Produit")
        DataGridView7.Columns(0).Width = 0.23 * n1
        DataGridView7.Columns(1).Width = 0.23 * n1
        DataGridView7.Columns(2).Width = 0.23 * n1
        DataGridView7.Columns(3).Width = 0.077 * n1
        DataGridView7.Columns(4).Width = 0.077 * n1
        DataGridView7.Columns(5).Width = 0.077 * n1
        DataGridView7.Columns(6).Width = n1 - (0.077 * n1 * 3) - (0.23 * 3 * n1)
        '-------------------------Equivalent--------------------------
        d12 = New DataSet()
        d13 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(d12, "Produit")
        ComboBox20.DataSource = d12.Tables("Produit")
        ComboBox20.DisplayMember = "Nom"
        ComboBox20.Text = ""
        b.execute("SELECT * FROM Equivalent")
        b.read(d12, "Equiv")
        ComboBox21.DataSource = d12.Tables("Equiv")
        ComboBox21.DisplayMember = "Code Equivalence"
        ComboBox21.Text = ""
        d12.Tables.Add("Lot")
        d12.Tables("Lot").Columns.Add("Code Equivalent", GetType(String))
        d12.Tables("Lot").Columns.Add("Nom", GetType(String()))
        b.execute("SELECT [Code Equivalence] FROM Equivalent")
        b.read(d12, "Lot")
        If (d12.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If
        DataGridView6.DataSource = d12.Tables("Lot")

        DataGridView6.Columns(0).Width = Me.Width - PNL_SIDE_MENU.Width
    End Sub

    Private Sub Button3_Click1(sender As Object, e As EventArgs) Handles B1.Click
        If ((ComboBox1.Text = DBNull.Value.ToString) And (ComboBox2.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox5.Text = DBNull.Value.ToString)) Then
            b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte]")
            b.read(d, "Produit")

        Else


            If (ComboBox2.Text = "<Tous>") Then
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte] AND Produit.Nom Like'" + ComboBox1.Text + "%' AND Produit.DCI Like '" + ComboBox3.Text + "%' AND Produit.[Code Equivalence] Like'" + ComboBox5.Text + "%'")
                b.read(d, "Produit")
            Else
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte] AND Produit.Nom Like'" + ComboBox1.Text + "%' AND Produit.Famille Like '" + ComboBox2.Text + "%' AND Produit.DCI Like '" + ComboBox3.Text + "%' AND Produit.[Code Equivalence] Like'" + ComboBox5.Text + "%'")
                b.read(d, "Produit")
            End If
        End If
        If (d.Tables("Produit").Rows.Count = 0) Then
            If ((ComboBox1.Text <> DBNull.Value.ToString) And (ComboBox2.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox5.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.Nom Like'" + ComboBox1.Text + "%'")
                b.read(d1, "Nom")
                If (d1.Tables("Nom").Rows.Count = 0) Then
                    MsgBox("Aucun produit avec le nom que vous recherchez.Veuillez entrer un autre nom.")
                End If
            ElseIf ((ComboBox1.Text = DBNull.Value.ToString) And (ComboBox2.Text <> DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox5.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.Famille Like'" + ComboBox2.Text + "%'")
                b.read(d1, "Famille")
                If (d1.Tables("Famille").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'appartient à cette famille.Veuillez choisir une autre famille.")
                End If
            ElseIf ((ComboBox1.Text = DBNull.Value.ToString) And (ComboBox2.Text = DBNull.Value.ToString) And (ComboBox27.Text <> DBNull.Value.ToString) And (ComboBox5.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.DCI Like'" + ComboBox27.Text + "%'")
                b.read(d1, "DCI")
                If (d1.Tables("DCI").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'est caractérisé par ce DCI.Veuillez entrer un autre DCI.")
                End If
            ElseIf ((ComboBox1.Text = DBNull.Value.ToString) And (ComboBox2.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox5.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0'")
                b.read(d1, "Lab")
                If (d1.Tables("Lab").Rows.Count = 0) Then
                    MsgBox("Aucun produit ne provient de ce laboratoire.Veuillez entrer un autre laboratoire.")
                End If
            ElseIf ((ComboBox1.Text = DBNull.Value.ToString) And (ComboBox2.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox5.Text <> DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.[Code Equivalence] Like'" + ComboBox5.Text + "%'")
                b.read(d1, "Code")
                If (d1.Tables("Code").Rows.Count = 0) Then
                    MsgBox("Le code que vous avez entré n'existe pas.Veuillez entrer un autre code.")
                End If
            Else
                MsgBox("Le produit que vous recherchez n'existe pas ou n'est pas disponible.Veuillez entrer une autre recherche.")
            End If
        End If
        DataGridView1.DataSource = d.Tables("Produit")

    End Sub
    Private Sub Button3_Click5(sender As Object, e As EventArgs) Handles B2.Click
        Dim i As Boolean
        If (ComboBox9.Text = "Produit Expiré") Then
            i = True
        Else
            i = False
        End If
        If ((ComboBox6.Text = DBNull.Value.ToString) And (ComboBox7.Text = DBNull.Value.ToString) And (ComboBox8.Text = DBNull.Value.ToString) And (ComboBox9.Text = DBNull.Value.ToString)) Then
            b.execute("SELECT Produit.Nom,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Achat],lot.Marge,lot.PPA,lot.SHP,lot.[Prix Unitaire Vente],lot.Emplacement FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit")
            b.read(d2, "Lot")
        Else
            Dim s As String = "SELECT Produit.Nom,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Achat],lot.Marge,lot.PPA,lot.SHP,lot.[Prix Unitaire Vente],lot.Emplacement FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.ID Like '" + ComboBox6.Text + "%' AND Lot.IDproduit Like '" + ComboBox7.Text + "%' AND Lot.Expiré = '" + i.ToString + "' AND Produit.Nom Like '" + ComboBox8.Text + "%'"

            b.execute(s)
            i = b.read(d2, "Lot")
        End If

        DataGridView2.DataSource = d2.Tables("Lot")
    End Sub
    Private Sub Button3_Click2(sender As Object, e As EventArgs) Handles Button1.Click
        '------------------
        If ((ComboBox16.Text = DBNull.Value.ToString) And (ComboBox17.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox18.Text = DBNull.Value.ToString) And (ComboBox19.Text = DBNull.Value.ToString)) Then
            b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte]")
            b.read(d4, "Produit")

        Else

            If (ComboBox17.Text = "<Tous>") Then
                b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte] AND Produit.Nom Like'" + ComboBox16.Text + "%' AND Produit.DCI Like '" + ComboBox27.Text + "%' AND Produit.Laboratoire Like '" + ComboBox18.Text + "%' AND Produit.[Code Equivalence] Like'" + ComboBox19.Text + "%'")
                b.read(d4, "Produit")
            Else
                b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte] AND Produit.Nom Like'" + ComboBox16.Text + "%' AND Produit.Famille Like '" + ComboBox17.Text + "%' AND Produit.DCI Like '" + ComboBox27.Text + "%' AND Produit.Laboratoire Like '" + ComboBox18.Text + "%' AND Produit.[Code Equivalence] Like'" + ComboBox19.Text + "%'")
                b.read(d4, "Produit")
            End If
        End If
        If (d4.Tables("Produit").Rows.Count = 0) Then
            If ((ComboBox16.Text <> DBNull.Value.ToString) And (ComboBox17.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox18.Text = DBNull.Value.ToString) And (ComboBox19.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.Nom Like'" + ComboBox16.Text + "%'")
                b.read(d5, "Nom")
                If (d5.Tables("Nom").Rows.Count = 0) Then
                    MsgBox("Aucun produit avec le nom que vous recherchez.Veuillez entrer un autre nom.")
                End If
            ElseIf ((ComboBox16.Text = DBNull.Value.ToString) And (ComboBox17.Text <> DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox18.Text = DBNull.Value.ToString) And (ComboBox19.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.Famille Like'" + ComboBox17.Text + "%'")
                b.read(d5, "Famille")
                If (d5.Tables("Famille").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'appartient à cette famille.Veuillez choisir une autre famille.")
                End If
            ElseIf ((ComboBox16.Text = DBNull.Value.ToString) And (ComboBox17.Text = DBNull.Value.ToString) And (ComboBox27.Text <> DBNull.Value.ToString) And (ComboBox18.Text = DBNull.Value.ToString) And (ComboBox19.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.DCI Like'" + ComboBox27.Text + "%'")
                b.read(d5, "DCI")
                If (d5.Tables("DCI").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'est caractérisé par ce DCI.Veuillez entrer un autre DCI.")
                End If
            ElseIf ((ComboBox16.Text = DBNull.Value.ToString) And (ComboBox17.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox18.Text <> DBNull.Value.ToString) And (ComboBox19.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.Laboratoire Like'" + ComboBox18.Text + "%'")
                b.read(d5, "Lab")
                If (d5.Tables("Lab").Rows.Count = 0) Then
                    MsgBox("Aucun produit ne provient de ce laboratoire.Veuillez entrer un autre laboratoire.")
                End If
            ElseIf ((ComboBox16.Text = DBNull.Value.ToString) And (ComboBox17.Text = DBNull.Value.ToString) And (ComboBox27.Text = DBNull.Value.ToString) And (ComboBox18.Text = DBNull.Value.ToString) And (ComboBox19.Text <> DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.[Code Equivalence] Like'" + ComboBox19.Text + "%'")
                b.read(d5, "Code")
                If (d5.Tables("Code").Rows.Count = 0) Then
                    MsgBox("Le code que vous avez entré n'existe pas.Veuillez entrer un autre code.")
                End If
            Else
                MsgBox("Le produit que vous recherchez n'existe pas ou n'est pas disponible.Veuillez entrer une autre recherche.")
            End If
        End If
        DataGridView5.DataSource = d4.Tables("Produit")
        '--------------

    End Sub

    Private Sub Button3_Click7(sender As Object, e As EventArgs) Handles B3.Click
        d6 = New DataSet()
        If ((ComboBox10.Text = DBNull.Value.ToString) And (ComboBox12.Text = DBNull.Value.ToString) And (ComboBox11.Text = DBNull.Value.ToString) And (ComboBox13.Text = DBNull.Value.ToString)) Then
            b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Lot.Quantité,Produit.Remboursement,Produit.[Code Equivalence],Lot.[Date Expiration] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré = 1")
            b.read(d6, "Lot")
        Else

            If (ComboBox11.Text = "<Tous>") Then
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré = 1 AND Produit.Nom Like '" + ComboBox10.Text + "%' AND Produit.DCI Like '" + ComboBox12.Text + "%' AND Produit.[Code Equivalence] Like '" + ComboBox13.Text + "%'")
                b.read(d6, "Lot")
            Else
                b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré = 1 AND Produit.Nom Like '" + ComboBox10.Text + "%' AND Produit.DCI Like '" + ComboBox12.Text + "%' AND Produit.Famille Like '" + ComboBox11.Text + "%' AND Produit.[Code Equivalence] Like '" + ComboBox13.Text + "%'")
                b.read(d6, "Lot")
            End If
        End If
        If (d6.Tables("Lot").Rows.Count = 0) Then
            If ((ComboBox10.Text <> DBNull.Value.ToString) And (ComboBox12.Text = DBNull.Value.ToString) And (ComboBox11.Text = DBNull.Value.ToString) And (ComboBox13.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='1' AND  Produit.Nom Like'" + ComboBox10.Text + "%'")
                b.read(d7, "Nom")
                If (d7.Tables("Nom").Rows.Count = 0) Then
                    MsgBox("Aucun produit avec le nom que vous recherchez.Veuillez entrer un autre nom.")
                End If
            ElseIf ((ComboBox10.Text = DBNull.Value.ToString) And (ComboBox12.Text = DBNull.Value.ToString) And (ComboBox11.Text <> DBNull.Value.ToString) And (ComboBox13.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='1' AND  Produit.Famille Like'" + ComboBox11.Text + "%'")
                b.read(d7, "Famille")
                If (d7.Tables("Famille").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'appartient à cette famille.Veuillez choisir une autre famille.")
                End If
            ElseIf ((ComboBox10.Text = DBNull.Value.ToString) And (ComboBox12.Text <> DBNull.Value.ToString) And (ComboBox11.Text = DBNull.Value.ToString) And (ComboBox13.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='1' AND  Produit.DCI Like'" + ComboBox12.Text + "%'")
                b.read(d7, "DCI")
                If (d7.Tables("DCI").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'est caractérisé par ce DCI.Veuillez entrer un autre DCI.")
                End If
            ElseIf ((ComboBox10.Text = DBNull.Value.ToString) And (ComboBox12.Text = DBNull.Value.ToString) And (ComboBox11.Text = DBNull.Value.ToString) And (ComboBox13.Text <> DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='1' AND  Produit.[Code Equivalence] Like'" + ComboBox13.Text + "%'")
                b.read(d7, "Code")
                If (d7.Tables("Code").Rows.Count = 0) Then
                    MsgBox("Le code que vous avez entré n'existe pas.Veuillez entrer un autre code.")
                End If
            Else
                MsgBox("Le produit que vous recherchez n'existe pas ou n'est pas périmé.Veuillez entrer une autre recherche.")
            End If
        End If
        DataGridView3.DataSource = d6.Tables("Lot")
    End Sub

    Private Sub Button3_Click3(sender As Object, e As EventArgs) Handles B4.Click
        Dim aaaa, mm, jj, dat, now As String
        d8 = New DataSet()
        If ((ComboBox14.Text = DBNull.Value.ToString) And (ComboBox15.Text = DBNull.Value.ToString) And (DateTimePicker1.Value = Date.Today)) Then
            aaaa = Date.Now.ToString.Substring(6, 4)
            mm = Date.Now.ToString.Substring(3, 2)
            jj = Date.Now.ToString.Substring(0, 2)
            now = aaaa + "-" + mm + "-" + jj + " " + Date.Now.ToString.Substring(11, 8)
            aaaa = Date.Now.AddDays(30).ToString.Substring(6, 4)
            mm = Date.Now.AddDays(30).ToString.Substring(3, 2)
            jj = Date.Now.AddDays(30).ToString.Substring(0, 2)
            dat = aaaa + "-" + mm + "-" + jj + " "
            Label17.Text = dat + "---" + now
            b.execute("SELECT Lot.ID,Lot.IDproduit,Produit.Nom,Produit.DCI,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.[Date Expiration] BETWEEN '" + now + "'AND '" + dat + "'")
            b.read(d8, "Lot")
        Else
            aaaa = DateTimePicker1.Value.ToString.Substring(6, 4)
            mm = DateTimePicker1.Value.ToString.Substring(3, 2)
            jj = DateTimePicker1.Value.ToString.Substring(0, 2)
            now = aaaa + "-" + mm + "-" + jj + " "
            aaaa = DateTimePicker1.Value.AddDays(30).ToString.Substring(6, 4)
            mm = DateTimePicker1.Value.AddDays(30).ToString.Substring(3, 2)
            jj = DateTimePicker1.Value.AddDays(30).ToString.Substring(0, 2)
            dat = aaaa + "-" + mm + "-" + jj + " "
            b.execute("SELECT Lot.ID,Lot.IDproduit,Produit.Nom,Produit.DCI,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.[Date Expiration] BETWEEN'" + now + "' AND '" + dat + "' AND Produit.Nom Like '" + ComboBox14.Text + "%' AND Produit.[Code Equivalence] Like'" + ComboBox15.Text + "%'")
            b.read(d8, "Lot")
        End If
        If (d8.Tables("Lot").Rows.Count = 0) Then
            If ((ComboBox14.Text <> DBNull.Value.ToString) And (ComboBox15.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Produit.Nom Like'" + ComboBox14.Text + "%'")
                b.read(d9, "Nom")
                If (d9.Tables("Nom").Rows.Count = 0) Then
                    MsgBox("Aucun produit avec ce nom.Veuillez entrer un autre nom.")
                End If
            ElseIf ((ComboBox14.Text = DBNull.Value.ToString) And (ComboBox15.Text <> DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND  Produit.[Code Equivalence] Like'" + ComboBox15.Text + "%'")
                b.read(d9, "Code")
                If (d9.Tables("Code").Rows.Count = 0) Then
                    MsgBox("Le code que vous avez entré n'existe pas.Veuillez entrer un autre code.")
                End If
            Else
                MsgBox("Le produit que vous recherchez n'existe pas ou ne va pas se périmer prochainement.Veuillez entrer une autre recherche.")
            End If
        End If
        DataGridView4.DataSource = d8.Tables("Lot")
        DataGridView4.Columns(0).HeaderText = "Lot"

    End Sub

    Private Sub Button4_Click6(sender As Object, e As EventArgs) Handles B5.Click
        Dim aaaa, mm, jj, dat, now As String
        d8 = New DataSet()
        aaaa = Date.Now.ToString.Substring(6, 4)
        mm = Date.Now.ToString.Substring(3, 2)
        jj = Date.Now.ToString.Substring(0, 2)
        now = aaaa + "-" + mm + "-" + jj + " " + Date.Now.ToString.Substring(11, 8)
        aaaa = Date.Now.AddDays(30).ToString.Substring(6, 4)
        mm = Date.Now.AddDays(30).ToString.Substring(3, 2)
        jj = Date.Now.AddDays(30).ToString.Substring(0, 2)
        dat = aaaa + "-" + mm + "-" + jj + " " + Date.Now.AddDays(30).ToString.Substring(11, 8)
        b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Lot.Quantité,Produit.Remboursement,Produit.[Code Equivalence],Lot.[Date Expiration] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.[Date Expiration] BETWEEN '" + now + "'AND '" + dat + "'")
        b.read(d8, "Lot")
        If (d8.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun produit ne va se périmer pendant ce mois")
        End If
        DataGridView4.DataSource = d8.Tables("Lot")
    End Sub
    Private Sub Button3_Click4(sender As Object, e As EventArgs) Handles B10.Click
        d10 = New DataSet()
        If ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
            b.execute("SELECT * FROM Produit WHERE [Quantité Actuelle] <= [Quantité Alerte]")
            b.read(d10, "Produit")
        Else


            If (ComboBox23.Text = "<Tous>") Then
                b.execute("SELECT * FROM Produit WHERE Nom Like'" + ComboBox22.Text + "%' AND [Quantité Actuelle] ='" + ComboBox25.Text + "' AND [Code Equivalence] Like'" + ComboBox24.Text + "%'")
                b.read(d10, "Produit")
            Else
                b.execute("SELECT * FROM Produit WHERE Famille Like'" + ComboBox23.Text + "%' AND Nom Like'" + ComboBox22.Text + "%' AND [Quantité Actuelle] ='" + ComboBox25.Text + "' AND [Code Equivalence] Like'" + ComboBox24.Text + "%'")
                b.read(d10, "Produit")
            End If
        End If
        If (d10.Tables("Produit").Rows.Count = 0) Then
            If ((ComboBox22.Text <> DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE Nom Like'" + ComboBox22.Text + "%'")
                b.read(d11, "Nom")
                If (d11.Tables("Nom").Rows.Count = 0) Then
                    MsgBox("Aucun produit avec le nom que vous recherchez.Veuillez entrer un autre nom.")
                End If
            ElseIf ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text <> DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE Famille Like'" + ComboBox23.Text + "%'")
                b.read(d11, "Famille")
                If (d11.Tables("Famille").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'appartient à cette famille.Veuillez choisir une autre famille.")
                End If
            ElseIf ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text <> DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE [Quantité Actuelle] Like'" + ComboBox25.Text + "%'")
                b.read(d11, "quant")
                If (d11.Tables("quant").Rows.Count = 0) Then
                    MsgBox("Aucun produit a cette quantité.Veuillez entrer une autre quantité.")
                End If
            ElseIf ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text <> DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE [Code Equivalence] Like'" + ComboBox24.Text + "%'")
                b.read(d11, "Code")
                If (d11.Tables("Code").Rows.Count = 0) Then
                    MsgBox("Le code que vous avez entré n'existe pas.Veuillez entrer un autre code.")
                End If
            Else
                MsgBox("Le produit que vous recherchez n'existe pas ou n'est pas en rupture. Veuillez entrer une autre recherche.")
            End If
        End If
        DataGridView7.DataSource = d10.Tables("Produit")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles B10.Click
        d10 = New DataSet()
        If ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
            b.execute("SELECT * FROM Produit WHERE [Quantité Actuelle] <= [Quantité Alerte]")
            b.read(d10, "Produit")
        Else
            b.execute("SELECT * FROM Produit WHERE Famille Like'" + ComboBox23.Text + "%' AND Nom Like'" + ComboBox22.Text + "%' AND [Quantité Actuelle] ='" + ComboBox25.Text + "' AND [Code Equivalence] Like'" + ComboBox24.Text + "%'")
            b.read(d10, "Produit")
        End If
        If (d10.Tables("Produit").Rows.Count = 0) Then
            If ((ComboBox22.Text <> DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE Nom Like'" + ComboBox22.Text + "%'")
                b.read(d11, "Nom")
                If (d11.Tables("Nom").Rows.Count = 0) Then
                    MsgBox("Aucun produit avec le nom que vous recherchez.Veuillez entrer un autre nom.")
                End If
            ElseIf ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text <> DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE Famille Like'" + ComboBox23.Text + "%'")
                b.read(d11, "Famille")
                If (d11.Tables("Famille").Rows.Count = 0) Then
                    MsgBox("Aucun produit n'appartient à cette famille.Veuillez choisir une autre famille.")
                End If
            ElseIf ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text <> DBNull.Value.ToString) And (ComboBox24.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE [Quantité Actuelle] Like'" + ComboBox25.Text + "%'")
                b.read(d11, "quant")
                If (d11.Tables("quant").Rows.Count = 0) Then
                    MsgBox("Aucun produit a cette quantité.Veuillez entrer une autre quantité.")
                End If
            ElseIf ((ComboBox22.Text = DBNull.Value.ToString) And (ComboBox23.Text = DBNull.Value.ToString) And (ComboBox25.Text = DBNull.Value.ToString) And (ComboBox24.Text <> DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE [Code Equivalence] Like'" + ComboBox24.Text + "%'")
                b.read(d11, "Code")
                If (d11.Tables("Code").Rows.Count = 0) Then
                    MsgBox("Le code que vous avez entré n'existe pas.Veuillez entrer un autre code.")
                End If
            Else
                MsgBox("Le produit que vous recherchez n'existe pas ou n'est pas en rupture. Veuillez entrer une autre recherche.")
            End If
        End If
        DataGridView7.DataSource = d10.Tables("Produit")
    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellDoubleClick
        Dim A As Point
        Dim n1 As Integer = Me.Width - PNL_SIDE_MENU.Width - 20

        A = DataGridView6.CurrentCellAddress
        ComboBox21.SelectedText = DataGridView6.Item(A.X, A.Y).Value
        b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit WHERE [Code Equivalence] ='" + DataGridView6.Item(A.X, A.Y).Value + "'")
        b.read(d12, "Produit")
        DataGridView6.DataSource = d12.Tables("Produit")


        DataGridView6.Columns(1).Width = 0.23 * n1
        DataGridView6.Columns(2).Width = 0.23 * n1
        DataGridView6.Columns(3).Width = 0.23 * n1
        DataGridView6.Columns(4).Width = 0.077 * n1
        DataGridView6.Columns(5).Width = 0.077 * n1
        DataGridView6.Columns(6).Width = 0.077 * n1
        DataGridView6.Columns(0).Width = n1 - (0.077 * n1 * 3) - (0.23 * 3 * n1)
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles B7.Click
        If ((ComboBox21.Text = DBNull.Value.ToString) And (ComboBox20.Text = DBNull.Value.ToString)) Then
            b.execute("SELECT [Code Equivalence] FROM Equivalent")
            b.read(d12, "Produit")
        Else
            b.execute("SELECT * FROM Produit WHERE Nom  Like'" + ComboBox20.Text + "%' AND  [Code Equivalence] Like'" + ComboBox21.Text + "%'")
            b.read(d12, "Produit")
        End If
        If (d12.Tables("Produit").Rows.Count = 0) Then
            If ((ComboBox20.Text <> DBNull.Value.ToString) And (ComboBox21.Text = DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE Nom Like'" + ComboBox20.Text + "%'")
                b.read(d13, "Nom")
                If (d13.Tables("Nom").Rows.Count = 0) Then
                    MsgBox("Aucun produit avec le nom que vous recherchez.Veuillez entrer un autre nom.")
                End If
            ElseIf ((ComboBox20.Text = DBNull.Value.ToString) And (ComboBox21.Text <> DBNull.Value.ToString)) Then
                b.execute("SELECT * FROM Produit WHERE [Code Equivalence] Like'" + ComboBox21.Text + "%'")
                b.read(d13, "Code")
                If (d13.Tables("Code").Rows.Count = 0) Then
                    MsgBox("Le code que vous avez entré n'existe pas.Veuillez entrer un autre code.")
                End If
            Else
                MsgBox("Le produit que vous recherchez n'existe pas. Veuillez entrer une autre recherche.")
            End If
        End If
        DataGridView6.DataSource = d12.Tables("Produit")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles B8.Click
        b.execute("SELECT [Code Equivalence] FROM Equivalent")
        b.read(d12, "Lot")
        If (d12.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If

        DataGridView6.DataSource = d12.Tables("Lot")
        DataGridView6.Columns(0).Width = Me.Width - PNL_SIDE_MENU.Width
    End Sub
    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""

        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        ComboBox10.Text = ""
        ComboBox11.Text = ""
        ComboBox12.Text = ""
        ComboBox13.Text = ""
        ComboBox14.Text = ""
        ComboBox15.Text = ""
        ComboBox16.Text = ""
        ComboBox17.Text = ""
        ComboBox18.Text = ""
        ComboBox19.Text = ""
        ComboBox20.Text = ""
        ComboBox21.Text = ""
        ComboBox22.Text = ""
        ComboBox23.Text = ""
        ComboBox24.Text = ""
        ComboBox27.Text = ""
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b.execute("SELECT * FROM Produit")
        b.read(d, "Produit")
        ComboBox1.DataSource = d.Tables("Produit")
        ComboBox1.DisplayMember = "Nom"
        ComboBox1.Text = ""
        ComboBox3.DataSource = d.Tables("Produit")
        ComboBox3.DisplayMember = "DCI"
        ComboBox3.Text = ""

        b.execute("SELECT * FROM Equivalent")
        b.read(d, "Equiv")
        ComboBox5.DataSource = d.Tables("Equiv")
        ComboBox5.DisplayMember = "Code Equivalence"
        ComboBox5.Text = ""
        d = New DataSet()
        ' b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte]")
        b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.ID = Lot.IDproduit AND Lot.Expiré='0' AND Produit.[Quantité Actuelle]>Produit.[Quantité Alerte]")

        b.read(d, "Produit")
        If (d.Tables("Produit").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If
        DataGridView1.DataSource = d.Tables("Produit")
        Dim n As Integer = Me.Width - PNL_SIDE_MENU.Width - 20 - 600 - 20
        DataGridView1.Columns(0).Width = n / 2
        DataGridView1.Columns(1).Width = n / 2
        DataGridView1.Columns(2).HeaderText = "Lot"
        ' Dim n As Integer = Me.Width - PNL_SIDE_MENU.Width - 20
        'DataGridView1.Columns(0).Width = 0.23 * n
        'DataGridView1.Columns(1).Width = 0.23 * n
        'DataGridView1.Columns(2).Width = 0.23 * n
        'DataGridView1.Columns(3).Width = 0.077 * n
        'DataGridView1.Columns(4).Width = 0.077 * n
        'DataGridView1.Columns(5).Width = 0.077 * n
        'DataGridView1.Columns(6).Width = n - (0.077 * n * 3) - (0.23 * 3 * n)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        b.execute("SELECT * FROM Lot")
        b.read(d2, "Lot")
        ComboBox6.DataSource = d2.Tables("Lot")
        ComboBox6.DisplayMember = "Id"
        ComboBox6.Text = ""
        ComboBox7.DataSource = d2.Tables("Lot")
        ComboBox7.DisplayMember = "Idproduit"
        ComboBox7.Text = ""
        d3 = New DataSet()
        b.execute("SELECT Nom FROM Produit")
        b.read(d3, "Nom")
        ComboBox8.DataSource = d3.Tables("Nom")
        ComboBox8.DisplayMember = "Nom"
        ComboBox8.Text = ""
        b.execute("SELECT Produit.Nom,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Achat],lot.Marge,lot.PPA,lot.SHP,lot.[Prix Unitaire Vente],lot.Emplacement FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit")
        b.read(d2, "Lot")
        If (d2.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun lot existant dans la base")
        End If
        DataGridView2.DataSource = d2.Tables("Lot")
        Dim n2 As Integer = Me.Width - PNL_SIDE_MENU.Width - 20 - 900 - 20
        DataGridView2.Columns(0).Width = n2
        DataGridView2.Columns(1).HeaderText = "Lot"
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
  d4 = New DataSet()
        d5 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(d4, "Produit")
        ComboBox16.DataSource = d4.Tables("Produit")
        ComboBox16.DisplayMember = "Nom"
        ComboBox16.Text = ""
        ComboBox27.DataSource = d4.Tables("Produit")
        ComboBox27.DisplayMember = "DCI"
        ComboBox27.Text = ""
        b.execute("SELECT * FROM Laboratoire")
        b.read(d5, "lab")
        ComboBox18.DataSource = d5.Tables("lab")
        ComboBox18.DisplayMember = "Nom"
        ComboBox18.Text = ""
        b.execute("SELECT * FROM Equivalent ")
        b.read(d5, "Equiv")
        ComboBox19.DataSource = d5.Tables("Equiv")
        ComboBox19.DisplayMember = "Code Equivalence"
        ComboBox19.Text = ""

        b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit")
        b.read(d4, "Produit")
        If (d4.Tables("Produit").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If
        DataGridView5.DataSource = d4.Tables("Produit")
        Dim n1 As Integer = Me.Width - PNL_SIDE_MENU.Width - 20
        DataGridView5.Columns(0).Width = 0.23 * n1
        DataGridView5.Columns(1).Width = 0.23 * n1
        DataGridView5.Columns(2).Width = 0.23 * n1
        DataGridView5.Columns(3).Width = 0.077 * n1
        DataGridView5.Columns(4).Width = 0.077 * n1
        DataGridView5.Columns(5).Width = 0.077 * n1
        DataGridView5.Columns(6).Width = n1 - (0.077 * n1 * 3) - (0.23 * 3 * n1)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n As Integer = Me.Width - PNL_SIDE_MENU.Width - 20 - 600 - 20
        d6 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(d6, "Produit")
        ComboBox10.DataSource = d6.Tables("Produit")
        ComboBox10.DisplayMember = "Nom"
        ComboBox10.Text = ""
        ComboBox12.DataSource = d6.Tables("Produit")
        ComboBox12.DisplayMember = "DCI"
        ComboBox12.Text = ""
        b.execute("SELECT * FROM Equivalent")
        b.read(d6, "Equiv")
        ComboBox13.DataSource = d6.Tables("Equiv")
        ComboBox13.DisplayMember = "Code Equivalence"
        ComboBox13.Text = ""
        b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.Expiré = 1")
        b.read(d6, "Lot")
        If (d6.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est périmé")
        End If
        DataGridView3.DataSource = d6.Tables("Lot")
        DataGridView3.Columns(0).Width = n / 2
        DataGridView3.Columns(1).Width = n / 2
        DataGridView3.Columns(2).HeaderText = "Lot"


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim n As Integer = Me.Width - PNL_SIDE_MENU.Width - 20 - 600 - 20
        Dim aaaa, mm, jj, dat, now As String
        d8 = New DataSet()
        aaaa = Date.Now.ToString.Substring(6, 4)
        mm = Date.Now.ToString.Substring(3, 2)
        jj = Date.Now.ToString.Substring(0, 2)
        now = aaaa + "-" + mm + "-" + jj + " " + Date.Now.ToString.Substring(11, 8)
        aaaa = Date.Now.AddDays(30).ToString.Substring(6, 4)
        mm = Date.Now.AddDays(30).ToString.Substring(3, 2)
        jj = Date.Now.AddDays(30).ToString.Substring(0, 2)
        dat = aaaa + "-" + mm + "-" + jj + " " + Date.Now.AddDays(30).ToString.Substring(11, 8)
        b.execute("SELECT * FROM Produit")
        b.read(d8, "Produit")
        ComboBox14.DataSource = d8.Tables("Produit")
        ComboBox14.DisplayMember = "Nom"
        ComboBox14.Text = ""
        b.execute("SELECT * FROM Equivalent")
        b.read(d8, "Equiv")
        ComboBox15.DataSource = d8.Tables("Equiv")
        ComboBox15.DisplayMember = "Code Equivalence"
        ComboBox15.Text = ""
        b.execute("SELECT Produit.Nom,Produit.DCI,Lot.ID,lot.[Date Expiration],lot.Quantité,lot.[Prix Unitaire Vente],lot.Emplacement,Produit.[Code Equivalence] FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.[Date Expiration] BETWEEN '" + now + "'AND '" + dat + "'")
        b.read(d8, "Lot")
        If (d8.Tables("Lot").Rows.Count = 0) Then
            MsgBox("Aucun produit ne va se périmer pendant ce mois")
        End If
        DataGridView4.DataSource = d8.Tables("Lot")
        DataGridView4.Columns(0).Width = n / 2
        DataGridView4.Columns(1).Width = n / 2
        DataGridView4.Columns(2).HeaderText = "Lot"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        d10 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(d10, "Produit")
        ComboBox22.DataSource = d10.Tables("Produit")
        ComboBox22.DisplayMember = "Nom"
        ComboBox22.Text = ""
        b.execute("SELECT * FROM Equivalent")
        b.read(d10, "Equiv")
        ComboBox24.DataSource = d10.Tables("Equiv")
        ComboBox24.DisplayMember = "Code Equivalence"
        ComboBox24.Text = ""
        b.execute("SELECT Produit.Nom,Produit.DCI,Produit.Laboratoire,Produit.[Quantité Actuelle],Produit.[Quantité Alerte],Produit.Remboursement,Produit.[Code Equivalence] FROM Produit WHERE [Quantité Actuelle] <= [Quantité Alerte] ")
        b.read(d10, "Produit")
        If (d10.Tables("Produit").Rows.Count = 0) Then
            MsgBox("Aucun produit n'est disponible à la vente")
        End If
        Dim n1 As Integer = Me.Width - PNL_SIDE_MENU.Width - 20

        DataGridView7.DataSource = d10.Tables("Produit")
        DataGridView7.Columns(0).Width = 0.23 * n1
        DataGridView7.Columns(1).Width = 0.23 * n1
        DataGridView7.Columns(2).Width = 0.23 * n1
        DataGridView7.Columns(3).Width = 0.077 * n1
        DataGridView7.Columns(4).Width = 0.077 * n1
        DataGridView7.Columns(5).Width = 0.077 * n1
        DataGridView7.Columns(6).Width = n1 - (0.077 * n1 * 3) - (0.23 * 3 * n1)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        b.execute("SELECT Famille,Nom,DCI,[Code Equivalence] FROM Produit WHERE Nom = '" + ComboBox1.Text + "'")
        b.read(dx, "Nom")
        If (dx.Tables("Nom").Rows.Count = 1) Then
            ComboBox3.Text = dx.Tables(0).Rows(0).Item(2)
            ComboBox5.Text = dx.Tables(0).Rows(0).Item(3)
            ComboBox2.Text = dx.Tables(0).Rows(0).Item(0)
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        b.execute("SELECT Famille,Nom,DCI,[Code Equivalence] FROM Produit WHERE [Code Equivalence] = '" + ComboBox5.Text + "'")
        b.read(dx, "Prod")
        If (dx.Tables("Prod").Rows.Count = 1) Then
            ComboBox1.DataSource = dx.Tables("Prod")
            ComboBox1.DisplayMember = "Nom"
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        b.execute("SELECT Famille,Nom,DCI,[Code Equivalence] FROM Produit WHERE DCI = '" + ComboBox3.Text + "'")
        b.read(dx, "Prod")
        If (dx.Tables("Prod").Rows.Count = 1) Then
            ComboBox1.DataSource = dx.Tables("Prod")
            ComboBox1.DisplayMember = "Nom"
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub ComboBox27_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox27.SelectedIndexChanged

    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        b.execute("SELECT Lot.ID,Lot.IDproduit,Lot.Expiré,Produit.Nom FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Produit.Nom = '" + ComboBox8.Text + "'")
        b.read(dx, "Lot")
        If (dx.Tables("Lot").Rows.Count > 1) Then
            ComboBox7.Text = dx.Tables(0).Rows(0).Item(1)
            ComboBox9.SelectedIndex = 0
        ElseIf (dx.Tables("Lot").Rows.Count = 1) Then
            ComboBox6.Text = dx.Tables(0).Rows(0).Item(0)
            ComboBox7.Text = dx.Tables(0).Rows(0).Item(1)
            ComboBox9.SelectedIndex = 0
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If (ComboBox6.Text = DBNull.Value.ToString) Then
            b.execute("SELECT Lot.ID,Lot.IDproduit,Lot.Expiré,Produit.Nom FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.IDproduit ='" & Val(ComboBox7.Text) & "'")
            b.read(dx, "Lot")
            If (dx.Tables("Lot").Rows.Count > 1) Then
                ComboBox8.Text = dx.Tables(0).Rows(0).Item(3)
                ComboBox9.SelectedIndex = 0
            ElseIf (dx.Tables("Lot").Rows.Count = 1) Then
                ComboBox6.Text = dx.Tables(0).Rows(0).Item(0)
                ComboBox8.Text = dx.Tables(0).Rows(0).Item(3)
                ComboBox9.SelectedIndex = 0
            End If
        Else
            b.execute("SELECT Lot.ID,Lot.IDproduit,Lot.Expiré,Produit.Nom FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.IDproduit ='" & Val(ComboBox7.Text) & "' AND Lot.ID ='" + ComboBox6.Text + "'")
            b.read(dx, "Lot")
            If (dx.Tables("Lot").Rows.Count = 1) Then
                ComboBox8.Text = dx.Tables(0).Rows(0).Item(3)
                ComboBox9.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged, ComboBox6.SelectedValueChanged
        b.execute("SELECT Lot.ID,Lot.IDproduit,Lot.Expiré,Produit.Nom FROM Produit,Lot WHERE Produit.[ID]=Lot.IDproduit AND Lot.ID ='" & Val(ComboBox6.Text) & "'")
        b.read(dx, "Lot")
        If (dx.Tables("Lot").Rows.Count >= 1) Then
            ComboBox6.Text = dx.Tables(0).Rows(0).Item(0)
            ComboBox7.Text = dx.Tables(0).Rows(0).Item(1)
            ComboBox8.Text = dx.Tables(0).Rows(0).Item(3)
            ComboBox9.SelectedIndex = 0
        End If
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox20.SelectedIndexChanged
        B7.Enabled = True
        b.execute("SELECT Nom,[Code Equivalence] FROM Produit WHERE Nom = '" + ComboBox20.Text + "'")
        b.read(dx, "Nom")
        If (dx.Tables("Nom").Rows.Count = 1) Then
            ComboBox21.Text = dx.Tables(0).Rows(0).Item(1)
        End If
    End Sub

    Private Sub ComboBox21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox21.SelectedIndexChanged
        b.execute("SELECT Nom,[Code Equivalence] FROM Produit WHERE [Code Equivalence] = '" + ComboBox5.Text + "'")
        b.read(dx, "Prod")
        If (dx.Tables("Prod").Rows.Count = 1) Then
            ComboBox20.DataSource = dx.Tables("Prod")
            ComboBox20.DisplayMember = "Nom"
            ComboBox20.Text = ""
        End If
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox16.SelectedIndexChanged
        b.execute("SELECT Famille,Nom,DCI,Laboratoire,[Code Equivalence] FROM Produit WHERE Nom = '" + ComboBox16.Text + "'")
        b.read(dx, "Nom")
        If (dx.Tables("Nom").Rows.Count >= 1) Then
            If (dx.Tables(0).Rows(0).Item(0) = "Médicament") Then
                ComboBox17.SelectedIndex = 1
            Else
                ComboBox17.SelectedIndex = 2
            End If
            ComboBox19.Text = dx.Tables(0).Rows(0).Item(4)
            ComboBox27.Text = dx.Tables(0).Rows(0).Item(2)
            ComboBox18.Text = dx.Tables(0).Rows(0).Item(3)
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged
        b.execute("SELECT Famille,Nom,DCI,[Code Equivalence] FROM Produit WHERE Nom = '" + ComboBox10.Text + "'")
        b.read(dx, "Nom")
        If (dx.Tables("Nom").Rows.Count >= 1) Then
            If (dx.Tables(0).Rows(0).Item(0) = "Médicament") Then
                ComboBox11.SelectedIndex = 1
            Else
                ComboBox11.SelectedIndex = 2
            End If
            ComboBox12.Text = dx.Tables(0).Rows(0).Item(2)
            ComboBox13.Text = dx.Tables(0).Rows(0).Item(3)
        End If
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox14.SelectedIndexChanged
        b.execute("SELECT Nom,[Code Equivalence] FROM Produit WHERE Nom = '" + ComboBox14.Text + "'")
        b.read(dx, "Nom")
        If (dx.Tables("Nom").Rows.Count >= 1) Then
            ComboBox15.Text = dx.Tables(0).Rows(0).Item(1)
        End If
    End Sub

    Private Sub ComboBox22_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox22.SelectedIndexChanged
        b.execute("SELECT Famille,Nom,[Code Equivalence] FROM Produit WHERE Nom = '" + ComboBox22.Text + "'")
        b.read(dx, "Nom")
        If (dx.Tables("Nom").Rows.Count >= 1) Then
            ComboBox24.Text = dx.Tables(0).Rows(0).Item(2)
            If (dx.Tables(0).Rows(0).Item(0) = "Médicament") Then
                ComboBox23.SelectedIndex = 1
            Else
                ComboBox23.SelectedIndex = 2
            End If
        End If
    End Sub

    Private Sub ComboBox20_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox20.SelectedValueChanged, ComboBox20.ValueMemberChanged, ComboBox20.TextChanged
        B7.Enabled = True
    End Sub
End Class
