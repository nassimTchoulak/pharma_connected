Public Class Achat_CommandeAjout

    Dim i As Integer
    Public data2 As DataSet = New DataSet()
    Public datacombo1 As DataSet
    Private b As DataBase = New DataBase()
    Private k As Bon = New Bon()
    Private npdt As Produitt = New Produitt()

    Private Sub ajoutcmd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ProjeetDataSet2.Produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.ProduitTableAdapter.Fill(Me.ProjeetDataSet2.Produit)
        '--------------------------------------------------------------------
        datacombo1 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(datacombo1, "Produit")
        ComboBox1.DataSource = datacombo1.Tables("Produit")
        ComboBox1.DisplayMember = "Nom"
        '---------------------------------------------------------------------
        data2.Tables.Add("Prodd")
        data2.Tables("Prodd").Columns.Add("Famille", GetType(String))
        data2.Tables("Prodd").Columns.Add("Nom", GetType(String))
        data2.Tables("Prodd").Columns.Add("DCI", GetType(String))
        data2.Tables("Prodd").Columns.Add("Laboratoire", GetType(String))
        data2.Tables("Prodd").Columns.Add("[Quantite actuelle]", GetType(String))
        data2.Tables("Prodd").Columns.Add("[Quantite alerte]", GetType(String))
        data2.Tables("Prodd").Columns.Add("Remboursement", GetType(String))
        data2.Tables("Prodd").Columns.Add("[Code equivalent]", GetType(String))

        EP_QT.SetError(TextBox1, "")
        Button1.Enabled = False
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (npdt.recherch_prod(ComboBox1.Text, data2) = True) Then
            k.ajouter_cmd(ComboBox1.Text, TextBox1.Text)
            Me.Close()
        Else
            Achat_ProduitAjout.Show()
            Achat_ProduitAjout.TextBox1.Text = ComboBox1.Text
            MsgBox("Ce produit n'existe pas dans la base de données vous devez remplir cette formulaire")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button1.Enabled = False
        If TextBox1.Text = "" Then
            EP_QT.SetError(TextBox1, "Champ obligatoire")
        ElseIf Not IsNumeric(TextBox1.Text) Then
            EP_QT.SetError(TextBox1, "Valeur erronée")
        Else
            If (CInt(TextBox1.Text) <= 0) Then
                EP_QT.SetError(TextBox1, "Valeur erronée")
            Else
                EP_QT.SetError(TextBox1, "")
                Button1.Enabled = True
            End If
        End If
    End Sub



End Class