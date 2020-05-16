Public Class Vente
    Inherits menu

    Dim b As DataBase = New DataBase()
    Dim d3 As DataSet = New DataSet()
    Dim d4 As DataSet = New DataSet()
    Dim nbr, fildat As Integer
    Dim facture As VenteFacture
    Public totale As Integer = 0
    Private d, d1, d2 As DataSet
    Private session As New VenteCloture()

    Public ctrl, nvqte, i, x, z As Integer

    Dim bool As Boolean = True
    Private Sub TextBox3_DoubleClick(sender As Object, e As EventArgs) Handles TextBox3.DoubleClick
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown, TextBox1.KeyDown, TextBox4.KeyDown
        If e.KeyCode = Keys.Down And ListBox1.SelectedIndex <> ListBox1.Items.Count Then
            Try
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            Catch ex As Exception

            End Try
        End If
        If e.KeyCode = Keys.Up And ListBox1.SelectedIndex <> 0 Then
            Try
                ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            Catch ex As Exception

            End Try
        End If
        If e.KeyCode = Keys.Enter Then
            TextBox3.Text = ListBox1.Text
            ok.Enabled = True
            ListBox1.Visible = False

        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then
            TextBox1.Text = ""
            TextBox4.Text = ""

                    Dim n As Integer
            ok.Enabled = False
            If TextBox3.Text <> "" Then
                ListBox1.Visible = True
            Else
                ListBox1.Visible = False
            End If

            i = 0
            n = 0
            d1 = New DataSet()
            b.execute("SELECT Produit.Famille,Produit.Nom,Produit.[Quantité Actuelle],Lot.ID,Lot.[Date Expiration],Lot.Quantité,Lot.[Prix Unitaire Vente],Lot.Emplacement FROM Produit , Lot  WHERE Produit.ID = Lot.IDproduit AND Produit.Nom LIKE '" + TextBox3.Text + "%'")
            n = b.read(d1, "Produit")
            d1.Tables("Produit").Columns.Add("Fusion")
            For Me.i = 0 To n - 1
                d1.Tables("Produit").Rows(i).Item("Fusion") = ""
                d1.Tables("Produit").Rows(i).Item("Fusion") += d1.Tables("Produit").Rows(i).Item("Nom").ToString()
                d1.Tables("Produit").Rows(i).Item("Fusion") += " - Lot :"
                d1.Tables("Produit").Rows(i).Item("Fusion") += d1.Tables("Produit").Rows(i).Item("ID").ToString()
            Next
            ListBox1.DataSource = d1.Tables("Produit")
            ListBox1.DisplayMember = "Fusion"

            i = 0
            If ctrl = 0 Then
                While d1.Tables("Produit").Rows(i).Item("Fusion").ToString <> ListBox1.Text
                    i = i + 1
                End While
                nom.Text = d1.Tables("Produit").Rows(i).Item("Nom").ToString
                If nom.Text.Length > 35 Then
                    nom.Text = nom.Text.Substring(0, 35) + "..."
                End If
                prix.Text = d1.Tables("Produit").Rows(i).Item("Prix Unitaire Vente").ToString
                ' prix.Text = prix.Text.Substring(0, prix.Text.Length - 2)
                exp.Text = d1.Tables("Produit").Rows(i).Item("Date Expiration").ToString.Substring(0, 10)
                emp.Text = d1.Tables("Produit").Rows(i).Item("Emplacement").ToString
                num.Text = d1.Tables("Produit").Rows(i).Item("ID").ToString
                qte.Text = d1.Tables("Produit").Rows(i).Item("Quantité").ToString

            End If

            ctrl = 1
        End If
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListBox1_DoubleClick(Nothing, Nothing)
        End If



    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ok.Enabled = False Then
            Dim h As Integer = 0

            i = 0

            If ctrl = 1 Then
                While d1.Tables("Produit").Rows(i).Item("Fusion").ToString <> ListBox1.Text
                    i = i + 1
                End While
                nom.Text = d1.Tables("Produit").Rows(i).Item("Nom").ToString
                If nom.Text.Length > 35 Then
                    nom.Text = nom.Text.Substring(0, 35) + "..."
                End If
                prix.Text = d1.Tables("Produit").Rows(i).Item("Prix Unitaire Vente").ToString
                exp.Text = d1.Tables("Produit").Rows(i).Item("Date Expiration").ToString.Substring(0, 10)
                emp.Text = d1.Tables("Produit").Rows(i).Item("Emplacement").ToString
                num.Text = d1.Tables("Produit").Rows(i).Item("ID").ToString

                nvqte = d1.Tables("Produit").Rows(i).Item("Quantité").ToString
                For h = 0 To x - 1
                    If DataGridView2.Rows(h).Cells(1).Value.ToString = nom.Text And DataGridView2.Rows(h).Cells(2).Value.ToString = num.Text Then
                        nvqte -= DataGridView2.Rows(h).Cells(4).Value.ToString

                    End If
                Next
                qte.Text = nvqte

            End If
            d = d1
            z = i

        End If
    End Sub
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

        TextBox3.Text = ListBox1.Text
        ok.Enabled = True
        ListBox1.Visible = False
        TextBox1.Text = prix.Text

    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim bool As Integer
        ListBox1.Visible = False


        bool = 1
        If TextBox2.Text = "" Then
            MsgBox("le champs 'Quantité' est vide!", 0, "Erreur de saisie !")
            bool = 0
        End If
        If Val(TextBox2.Text) = 0 Then
            MsgBox("le champs 'Quantité' est vide!", 0, "Erreur de saisie !")
            bool = 0
        End If
        If TextBox3.Text = "" Then
            MsgBox("le champs 'Nom' est vide!", 0, "Erreur de saisie !")
            bool = 0
        End If
        If IsNumeric(TextBox2.Text) Or TextBox2.Text = "" Then

        Else
            MsgBox("Veuillez Entrez une valeur numérique dans le champs 'Quantité' !", 0, "Erreur de saisie !")
            bool = 0
        End If

        If Val(TextBox2.Text) > Val(qte.Text) Then
            MsgBox("Quantité Insufisante !", 0, "Erreur de saisie !")
            bool = 0
        End If
        If bool = 1 Then
            x = x + 1
            DataGridView2.Rows.Add(d.Tables("Produit").Rows(z).Item("Famille").ToString, d.Tables("Produit").Rows(z).Item("Nom").ToString, Val(d.Tables("Produit").Rows(z).Item("ID").ToString), d.Tables("Produit").Rows(z).Item("Date Expiration").ToString.Substring(0, 10), Val(TextBox2.Text), Val(d.Tables("Produit").Rows(z).Item("Prix Unitaire Vente").ToString), Val(d.Tables("Produit").Rows(z).Item("Prix Unitaire Vente").ToString) * Val(TextBox2.Text), Val(d.Tables("Produit").Rows(z).Item("Quantité").ToString), Val(d.Tables("Produit").Rows(z).Item("Quantité Actuelle").ToString))
            TextBox1.Text = ""
            TextBox2.Text = "1"
            TextBox3.Text = ""
            TextBox4.Text = ""
            ok.Enabled = False
        End If
        If qte.Text > 0 And x > 0 Then
            qte.Text -= DataGridView2.Rows(x - 1).Cells(4).Value.ToString
        End If


        TextBox3.Text = ""
    End Sub
    Public Sub majStock()
        Dim h As Integer
        h = 0
        h = Val(DataGridView2.Rows(0).Cells(4).Value.ToString)
        TextBox1.Text = x

        For h = 0 To x - 1
            b.execute("UPDATE Lot SET Quantité = " & (Val(DataGridView2.Rows(h).Cells(7).Value.ToString) - Val(DataGridView2.Rows(h).Cells(4).Value.ToString)) & "  WHERE ID = " & Val(DataGridView2.Rows(h).Cells(2).Value.ToString))

            b.execute("UPDATE Produit SET [Quantité Actuelle] = " & (Val(DataGridView2.Rows(h).Cells(8).Value.ToString) - Val(DataGridView2.Rows(h).Cells(4).Value.ToString)) & "  WHERE Nom = '" + DataGridView2.Rows(h).Cells(1).Value.ToString + "'")

        Next
    End Sub


    Public Function insert() As Integer
        Dim sum As Integer = 0
        Dim j As Integer = 0
        Dim p As Integer = 0
        Dim tar As String = ""
        Dim e As DataSet = New DataSet()
        For j = 0 To x - 1
            sum += Val(DataGridView2.Rows(j).Cells(6).Value.ToString)
        Next
        tar = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)

        b.execute("INSERT INTO [Facture vente] VALUES ('" + tar + "','" + VenteValidation.Client2.Text + "','Vendeur'," & sum & "," & 0 & "," & sum + sum * 0 & ",'" + VenteValidation.Ref2.Text + "','" & VenteValidation.CheckBox2.Checked & "')")

        b.execute("SELECT TOP 1 ID FROM [Facture vente] ORDER BY ID DESC")
        b.read(e, "Test")

        For j = 0 To x - 1

            b.execute("INSERT INTO Vente VALUES ( '" + DataGridView2.Rows(j).Cells(1).Value.ToString + "'," & Val(DataGridView2.Rows(j).Cells(2).Value.ToString) & "," & Val(e.Tables("Test").Rows(0).Item("ID").ToString) & "," & Val(DataGridView2.Rows(j).Cells(4).Value.ToString) & ",'" + DataGridView2.Rows(j).Cells(3).Value.ToString + "'," & Val(DataGridView2.Rows(j).Cells(5).Value.ToString) & "," & Val(DataGridView2.Rows(j).Cells(6).Value.ToString) & "," & p & "," & Val(DataGridView2.Rows(j).Cells(6).Value.ToString) & ")")
        Next

        Return Val(e.Tables("Test").Rows(0).Item("ID").ToString)
    End Function




    Private Sub valider_Click(sender As Object, e As EventArgs) Handles valider.Click
        If x = 0 Then
            MsgBox("Veuillez inserer au moins une vente dans la liste !", 0, "Liste de vente vide !")
        Else
            VenteValidation.ShowDialog()
        End If

    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    '   sep.Visible = bool
    '    bool = Not bool
    'End Sub

    Function Facturation(ByVal n As Integer) As VenteFacture
        Dim f As DataSet = New DataSet()
        Dim s As VenteFacture = New VenteFacture()
        Dim i, j As Integer
        b.execute("SELECT * FROM [Facture vente] WHERE ID =" & n)
        b.read(f, "test")
        s.vendeur.Text = f.Tables("test").Rows(0).Item("Vendeur").ToString
        s.dat.Text = f.Tables("test").Rows(0).Item("Date Facture").ToString
        s.client.Text = f.Tables("test").Rows(0).Item("Client").ToString
        s.id.Text = f.Tables("test").Rows(0).Item("Ref").ToString
        s.total.Text = f.Tables("test").Rows(0).Item("Montant TTC").ToString

        b.execute("SELECT * FROM Vente WHERE IDfacture =" & n)
        j = b.read(f, "test2")

        For i = 0 To j - 1
            s.DataGridView1.Rows.Add(f.Tables("test2").Rows(i).Item("IDproduit").ToString, f.Tables("test2").Rows(i).Item("Prix Unitaire").ToString, f.Tables("test2").Rows(i).Item("Quantité").ToString, f.Tables("test2").Rows(i).Item("Montant Totale TTC").ToString)
        Next
        Return s
    End Function





    Private Sub initi()
        Dim i, j As Integer
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        DataGridView1.Rows.Clear()

        ComboBox1.Text = "<tout>"
        ComboBox3.Text = "<tout>"
        ComboBox4.Text = "<tout>"

        ComboBox1.Items.Add("<tout>")
        ComboBox3.Items.Add("<tout>")
        ComboBox4.Items.Add("<tout>")

        ComboBox3.Items.Add("Cette année")
        ComboBox3.Items.Add("Ce semestre")
        ComboBox3.Items.Add("Ce trimestre")
        ComboBox3.Items.Add("Ce mois")
        ComboBox3.Items.Add("Cette semaine")
        ComboBox3.Items.Add("Aujourd'hui")
        b.execute("SELECT * FROM Client")
        i = b.read(d3, "Test")
        For j = 0 To i - 1
            ComboBox4.Items.Add(d3.Tables("Test").Rows(j).Item("Nom").ToString)
        Next

        b.execute("SELECT * FROM Compte")
        nbr = b.read(d3, "Test")
        For j = 0 To nbr - 1
            ComboBox1.Items.Add(d3.Tables("Test").Rows(j).Item("Nom").ToString)
        Next

        b.execute("SELECT * FROM [Facture vente]")
        i = b.read(d3, "Test")
        For j = 0 To i - 1
            DataGridView1.Rows.Add(d3.Tables("Test").Rows(j).Item("Ref").ToString, d3.Tables("Test").Rows(j).Item("Date Facture").ToString, d3.Tables("Test").Rows(j).Item("Client").ToString, d3.Tables("Test").Rows(j).Item("Vendeur").ToString, d3.Tables("Test").Rows(j).Item("Montant HT").ToString, d3.Tables("Test").Rows(j).Item("TVA").ToString, d3.Tables("Test").Rows(j).Item("Montant TTC").ToString, d3.Tables("Test").Rows(j).Item("ID").ToString)
        Next
    End Sub
    Private Sub Vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '.Text = DateTime.Now.TimeOfDay.Hours
        'sep.Text = " : "
        'min.Text = DateTime.Now.TimeOfDay.Minutes
        ctrl = 0
        x = 0
        Dim l As Label = New Label()
        Dim s As Point = New Point()
        s.X = 289
        s.Y = 27
        l.ForeColor = Color.Blue
        l.Text = "tetettete"
        l.Location = s
        l.Visible = True
        '  Label2.Text = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
        initi()


    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 8 And e.RowIndex > -1 Then
            facture = Facturation(Val(DataGridView1.CurrentRow.Cells(7).Value.ToString))
            '  facture.DataGridView1.AutoSizeColumnsMode = "fill"
            facture.Show()
        Else
            b.execute("SELECT * FROM Vente WHERE IDfacture = " & DataGridView1.CurrentRow.Cells(0).Value.ToString)
            b.read(d4, "Test")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Filtre.Click
        Dim i As Integer
        Dim bool1 As Boolean = False
        Dim requete As String = "SELECT * FROM [Facture vente]"
        If ComboBox4.Text <> "<tout>" Or ComboBox1.Text <> "<tout>" Or ComboBox3.Text <> "<tout>" Then
            requete += " where "
        End If
        If ComboBox1.Text <> "<tout>" Then
            requete += "Vendeur = '" + ComboBox1.Text + "'"
            If ComboBox4.Text <> "<tout>" Or ComboBox3.Text <> "<tout>" Then
                requete += " and "
            End If

        End If
        If ComboBox4.Text <> "<tout>" Then
            requete += "Client = '" + ComboBox4.Text + "'"
            If ComboBox3.Text <> "<tout>" Then
                requete += " and "
            End If
        End If
        If ComboBox3.Text <> "<tout>" Then
            requete += "[Date Facture] between '" + DateTimePicker1.Value.ToString.Substring(6, 4) + "-" + DateTimePicker1.Value.ToString.Substring(3, 2) + "-" + DateTimePicker1.Value.ToString.Substring(0, 2) + "' and '" + DateTimePicker2.Value.ToString.Substring(6, 4) + "-" + DateTimePicker2.Value.ToString.Substring(3, 2) + "-" + DateTimePicker2.Value.ToString.Substring(0, 2) + "'"

        End If
        Label2.Text = requete
        b.execute(requete)
        i = b.read(d, "Test")

        DataGridView1.Rows.Clear()
        For j = 0 To i - 1

            DataGridView1.Rows.Add(d.Tables("Test").Rows(j).Item("Ref").ToString, d.Tables("Test").Rows(j).Item("Date Facture").ToString, d.Tables("Test").Rows(j).Item("Client").ToString, d.Tables("Test").Rows(j).Item("Vendeur").ToString, d.Tables("Test").Rows(j).Item("Montant HT").ToString, d.Tables("Test").Rows(j).Item("TVA").ToString, d.Tables("Test").Rows(j).Item("Montant TTC").ToString, d.Tables("Test").Rows(j).Item("ID").ToString)
        Next
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedValueChanged

        If ComboBox3.Text = "<personalisé>" Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        End If

        If ComboBox3.Text = "Cette année" Then
            DateTimePicker2.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker1.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 372)
        End If
        If ComboBox3.Text = "Ce semestre" Then
            DateTimePicker2.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker1.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 186)
        End If
        If ComboBox3.Text = "Ce trimestre" Then
            DateTimePicker2.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker1.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 93)
        End If
        If ComboBox3.Text = "Ce mois" Then
            DateTimePicker2.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker1.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 31)
        End If
        If ComboBox3.Text = "Cette semaine" Then
            DateTimePicker2.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker1.Value = trans(DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2), 7)
        End If

        If ComboBox3.Text = "Aujourd'hui" Then
            DateTimePicker2.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
            DateTimePicker1.Value = DateTime.Now.ToString.Substring(6, 4) + "-" + DateTime.Now.ToString.Substring(3, 2) + "-" + DateTime.Now.ToString.Substring(0, 2)
        End If
    End Sub


    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        ListBox1.Visible = False
    End Sub

    Private Sub SupprimerLaLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerLaLigneToolStripMenuItem.Click
        DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
        x = x - 1
    End Sub




    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        Dim i As Integer = MsgBox("Voulez vous vraiment annuler la vente ?", 36, "Annulation de la vente")
        If (i = vbYes) Then
            TextBox1.Text = ""
            TextBox2.Text = "1"
            TextBox3.Text = ""
            TextBox4.Text = ""
            ok.Enabled = False
            ListBox1.Visible = False
            DataGridView2.Rows.Clear()
            nom.Text = ""

            prix.Text = ""
            exp.Text = ""
            emp.Text = ""
            num.Text = ""
            qte.Text = ""
            x = 0
        End If

    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub DataGridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView2.KeyDown, TextBox3.KeyDown
        If e.KeyCode = Keys.Add And ok.Enabled = True Then
            Button11_Click(Nothing, Nothing)
        End If
    End Sub



    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        VenteRecherche.ShowDialog()
    End Sub
    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        VenteEqu.ShowDialog()
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Monnaie.ShowDialog()
    End Sub


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            TextBox3.Text = ""
            TextBox4.Text = ""
            Dim n As Integer
            ok.Enabled = False
            If TextBox1.Text <> "" Then
                ListBox1.Visible = True
            Else
                ListBox1.Visible = False
            End If

            i = 0
            n = 0
            d1 = New DataSet()
            b.execute("SELECT Produit.Famille,Produit.Nom,Produit.[Quantité Actuelle],Lot.ID,Lot.[Date Expiration],Lot.Quantité,Lot.[Prix Unitaire Vente],Lot.Emplacement FROM Produit , Lot  WHERE Produit.ID = Lot.IDproduit AND lot.[Prix Unitaire Vente] LIKE '" + TextBox1.Text + "%'")
            n = b.read(d1, "Produit")
            d1.Tables("Produit").Columns.Add("Fusion")
            For Me.i = 0 To n - 1
                d1.Tables("Produit").Rows(i).Item("Fusion") = ""
                d1.Tables("Produit").Rows(i).Item("Fusion") += d1.Tables("Produit").Rows(i).Item("Nom").ToString()
                d1.Tables("Produit").Rows(i).Item("Fusion") += " - Lot :"
                d1.Tables("Produit").Rows(i).Item("Fusion") += d1.Tables("Produit").Rows(i).Item("ID").ToString()
            Next
            ListBox1.DataSource = d1.Tables("Produit")
            ListBox1.DisplayMember = "Fusion"

            i = 0
            If ctrl = 0 Then
                While d1.Tables("Produit").Rows(i).Item("Fusion").ToString <> ListBox1.Text
                    i = i + 1
                End While
                nom.Text = d1.Tables("Produit").Rows(i).Item("Nom").ToString
                If nom.Text.Length > 35 Then
                    nom.Text = nom.Text.Substring(0, 35) + "..."
                End If
                prix.Text = d1.Tables("Produit").Rows(i).Item("Prix Unitaire Vente").ToString

                exp.Text = d1.Tables("Produit").Rows(i).Item("Date Expiration").ToString.Substring(0, 10)
                emp.Text = d1.Tables("Produit").Rows(i).Item("Emplacement").ToString
                num.Text = d1.Tables("Produit").Rows(i).Item("ID").ToString
                qte.Text = d1.Tables("Produit").Rows(i).Item("Quantité").ToString

            End If

            ctrl = 1
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text <> "" Then
            TextBox3.Text = ""
            TextBox1.Text = ""
            Dim n As Integer
            ok.Enabled = False
            If TextBox4.Text <> "" Then
                ListBox1.Visible = True
            Else
                ListBox1.Visible = False
            End If

            i = 0
            n = 0
            d1 = New DataSet()
            b.execute("SELECT Produit.Famille,Produit.Nom,Produit.[Quantité Actuelle],Lot.ID,Lot.[Date Expiration],Lot.Quantité,Lot.[Prix Unitaire Vente],Lot.Emplacement FROM Produit , Lot  WHERE Produit.ID = Lot.IDproduit AND Produit.ID LIKE '" + TextBox4.Text + "%'")
            n = b.read(d1, "Produit")
            d1.Tables("Produit").Columns.Add("Fusion")
            For Me.i = 0 To n - 1
                d1.Tables("Produit").Rows(i).Item("Fusion") = ""
                d1.Tables("Produit").Rows(i).Item("Fusion") += d1.Tables("Produit").Rows(i).Item("Nom").ToString()
                d1.Tables("Produit").Rows(i).Item("Fusion") += " - Lot :"
                d1.Tables("Produit").Rows(i).Item("Fusion") += d1.Tables("Produit").Rows(i).Item("ID").ToString()
            Next
            ListBox1.DataSource = d1.Tables("Produit")
            ListBox1.DisplayMember = "Fusion"

            i = 0
            If ctrl = 0 Then
                While d1.Tables("Produit").Rows(i).Item("Fusion").ToString <> ListBox1.Text
                    i = i + 1
                End While
                nom.Text = d1.Tables("Produit").Rows(i).Item("Nom").ToString
                If nom.Text.Length > 35 Then
                    nom.Text = nom.Text.Substring(0, 35) + "..."
                End If
                prix.Text = d1.Tables("Produit").Rows(i).Item("Prix Unitaire Vente").ToString

                exp.Text = d1.Tables("Produit").Rows(i).Item("Date Expiration").ToString.Substring(0, 10)
                emp.Text = d1.Tables("Produit").Rows(i).Item("Emplacement").ToString
                num.Text = d1.Tables("Produit").Rows(i).Item("ID").ToString
                qte.Text = d1.Tables("Produit").Rows(i).Item("Quantité").ToString

            End If

            ctrl = 1
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Souhaitez-vous vraiment cloturer cette session de vente ?", vbYesNo + vbInformation, "Cloturer?") = vbYes Then

            session.Label2.Text = totale & "DA"

            session.ShowDialog()

            totale = 0
        End If

    End Sub
End Class