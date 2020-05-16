Public Class Achat_ProduitAjout

    Private data1, datacombo1, datacombo2 As DataSet
    Private b As DataBase = New DataBase()
    Private np As Produitt = New Produitt()
    Private ch, qtcorr As String
    Private bq, br, bf, bl, bd, be, b22, br1, br2 As Boolean


    Private Sub AjoutNProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ProjetDataSet.Laboratoire'. Vous pouvez la déplacer ou la supprimer selon vos besoins.

        'TODO: cette ligne de code charge les données dans la table 'ProjeetDataSet7.Produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.ProduitTableAdapter3.Fill(Me.ProjeetDataSet7.Produit)
        'TODO: cette ligne de code charge les données dans la table 'ProjeetDataSet6.Laboratoire'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.LaboratoireTableAdapter1.Fill(Me.ProjeetDataSet6.Laboratoire)

        datacombo1 = New DataSet()
        b.execute("SELECT * FROM DCI")
        b.read(datacombo1, "Produit2")
        ComboBox2.DataSource = datacombo1.Tables("Produit2")
        ComboBox2.DisplayMember = "Nom"

        '-----------------------------------------------------------------
        datacombo1 = New DataSet()
        b.execute("SELECT * FROM Produit")
        b.read(datacombo1, "Produit")
        ComboBox4.DataSource = datacombo1.Tables("Produit")
        ComboBox4.DisplayMember = "Nom"
        '-----------------------------------------------------------------
        datacombo2 = New DataSet()
        b.execute("SELECT * FROM Laboratoire")
        b.read(datacombo2, "Laboratoire")
        ComboBox3.DataSource = datacombo2.Tables("Laboratoire")
        ComboBox3.DisplayMember = "Nom"
        '----------------------------------------------------------------
        data1 = New DataSet()
        data1.Tables.Add("Prod")
        data1.Tables("Prod").Columns.Add("Famille", GetType(String))
        data1.Tables("Prod").Columns.Add("Nom", GetType(String))
        data1.Tables("Prod").Columns.Add("DCI", GetType(String))
        data1.Tables("Prod").Columns.Add("Laboratoire", GetType(String))
        data1.Tables("Prod").Columns.Add("[Quantite actuelle]", GetType(String))
        data1.Tables("Prod").Columns.Add("[Quantite alerte]", GetType(String))
        data1.Tables("Prod").Columns.Add("Remboursement", GetType(String))
        data1.Tables("Prod").Columns.Add("[Code Equivalence]", GetType(String))

        bq = False
        br = False
        bl = False
        bf = False
        bd = False
        be = False
        Button2.Enabled = False
        ComboBox4.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox4.Enabled = False
        ComboBox4.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox4.Enabled = True
        ComboBox4.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = 0
        If RadioButton2.Checked Then
            ch = TextBox4.Text
        Else
            ch = ComboBox4.Text
        End If

        np.enregistrer_produit(ch, Val(TextBox2.Text), a, Val(TextBox3.Text), ComboBox1.Text, ComboBox3.Text, TextBox1.Text, ComboBox2.Text)
    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        bq = False
        If TextBox2.Text = "" Then
            EP1.SetError(TextBox2, "Champ obligatoire")
        ElseIf Not IsNumeric(TextBox2.Text) Then
            EP1.SetError(TextBox2, "Valeur erronée")
        Else
            If (CInt(TextBox2.Text) < 0) Then
                EP1.SetError(TextBox2, "Valeur erronée")
            Else
                EP1.SetError(TextBox2, "")
                bq = True
            End If
        End If
        b22 = bl And bf And br And bq And bd And (br1 Or br2)
        Button2.Enabled = b22
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        br = False
        If TextBox3.Text = "" Then
            EPREMB.SetError(TextBox3, "Champ obligatoire")
        ElseIf Not IsNumeric(TextBox3.Text) Then
            EPREMB.SetError(TextBox3, "Valeur erronée")
        Else
            If (CInt(TextBox3.Text) < 0) Then
                EPREMB.SetError(TextBox3, "Valeur erronée")
            Else
                EPREMB.SetError(TextBox3, "")
                br = True
            End If
        End If
        b22 = bl And bf And br And bq And bd And (br1 Or br2)
        Button2.Enabled = b22
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "Médicament" Or ComboBox1.Text = "Produit de bien etre" Then
            bf = True
            EPFAMILLE.SetError(ComboBox1, "")
        Else
            EPFAMILLE.SetError(ComboBox1, "Valeur erronée")
            bf = False
        End If
        b22 = bl And bf And br And bq And bd And (br1 Or br2)
        Button2.Enabled = b22
    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs) Handles ComboBox3.TextChanged
        bl = False
        If ComboBox3.Text = "" Then
            EPLABO.SetError(ComboBox3, "erreur")
        Else
            bl = True
            EPLABO.SetError(ComboBox3, "")
        End If
        b22 = bl And bf And br And bq And bd And (br1 Or br2)
        Button2.Enabled = b22
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        bd = False
        If ComboBox2.Text = "" Then
            EPDCI.SetError(ComboBox2, "erreur")
        Else
            bd = True
            EPDCI.SetError(ComboBox2, "")
        End If
        b22 = bl And bf And br And bq And bd And (br1 Or br2)
        Button2.Enabled = b22
    End Sub

    Private Sub ComboBox4_TextChanged(sender As Object, e As EventArgs) Handles ComboBox4.TextChanged
        If RadioButton1.Checked Then
            If ComboBox4.Text <> "" Then
                br1 = True
            Else
                br1 = False
            End If
        End If
        b22 = bl And bf And br And bq And bd And (br1 Or br2)
        Button2.Enabled = b22
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If RadioButton2.Checked Then
            If TextBox4.Text <> "" Then
                br2 = True
            Else
                br2 = False
            End If
        End If
        b22 = bl And bf And br And bq And bd And (br1 Or br2)
        Button2.Enabled = b22
    End Sub


End Class