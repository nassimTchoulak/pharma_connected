Public Class Achat_AjtFact

    Private f As Facture = New Facture()
    Private data1 As DataSet
    Private b As DataBase = New DataBase()
    Private margebox, bn, be, bq, bp, bm, bs, bt As Boolean
    Private z, inter As Integer
    Private t As DataTable = New DataTable()
    Public data3 As DataSet = New DataSet()
    Private npdt As Produitt = New Produitt()
    Private sommeht, sommettc As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f.ajout_achat(ComboBox1.Text, Val(TextBox1.Text), DateTimePicker1.Value.ToString, Val(TextBox3.Text), Val(TextBox4.Text), Val(TextBox5.Text), Val(TextBox6.Text), Val(TextBox7.Text), Val(TextBox8.Text), Val(TextBox11.Text), Val(TextBox10.Text), ComboBox2.Text)
        Me.Close()
        t = Achat_Achat.dFA.Tables("achat")
        For Me.z = 0 To (t.Rows.Count - 1)
            sommeht = sommeht + t.Rows(Me.z)("ToTale HT")
            sommettc = sommettc + t.Rows(Me.z)("ToTale TTC")
        Next
        Achat_Achat.Label6.Text = sommeht.ToString
        Achat_Achat.Label7.Text = sommettc.ToString
    End Sub

    Private Sub Ajouter_Facture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ProjeetDataSet5.Emplacement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.EmplacementTableAdapter.Fill(Me.ProjeetDataSet5.Emplacement)
        'TODO: cette ligne de code charge les données dans la table 'ProjeetDataSet2.Produit'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.ProduitTableAdapter.Fill(Me.ProjeetDataSet2.Produit)

        Dim ff As DataSet = New DataSet()
        Dim r, a As Integer
        b.execute("SELECT * FROM Produit")
        r = b.read(ff, "Test")
        For a = 0 To r - 1
            ComboBox1.Items.Add(ff.Tables("Test").Rows(a).Item("Nom").ToString)
        Next

        b.execute("SELECT * FROM Emplacement")
        r = b.read(ff, "Test2")
        For a = 0 To r - 1
            ComboBox2.Items.Add(ff.Tables("Test2").Rows(a).Item("Nom").ToString)
        Next

        data3.Tables.Add("Prodd")
        data3.Tables("Prodd").Columns.Add("Famille", GetType(String))
        data3.Tables("Prodd").Columns.Add("Nom", GetType(String))
        data3.Tables("Prodd").Columns.Add("DCI", GetType(String))
        data3.Tables("Prodd").Columns.Add("Laboratoire", GetType(String))
        data3.Tables("Prodd").Columns.Add("[Quantite actuelle]", GetType(String))
        data3.Tables("Prodd").Columns.Add("[Quantite alerte]", GetType(String))
        data3.Tables("Prodd").Columns.Add("Remboursement", GetType(String))
        data3.Tables("Prodd").Columns.Add("[Code equivalent]", GetType(String))

        Button1.Enabled = False
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox5.Text = (((Val(TextBox3.Text) * Val(TextBox4.Text)) / 100) + Val(TextBox3.Text)).ToString

        If TextBox4.Text = "" Then
            EPMARGE.SetError(TextBox4, "Champ obligatoire")
            bm = False
        ElseIf Not IsNumeric(TextBox4.Text) Then
            EPMARGE.SetError(TextBox4, "Valeur erronée")
            bm = False
        Else
            If (CInt(TextBox4.Text) < 0) Then
                EPMARGE.SetError(TextBox4, "Valeur erronée")
                bm = False
            Else
                EPMARGE.SetError(TextBox4, "")
                bm = True
            End If
        End If

        Button1.Enabled = bn And be And bq And bp And bm And bs And bt

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox5.Text = (((Val(TextBox3.Text) * Val(TextBox4.Text)) / 100) + Val(TextBox3.Text)).ToString

        If TextBox3.Text = "" Then
            EPPRIX.SetError(TextBox3, "Champ obligatoire")
            bp = False
        ElseIf Not IsNumeric(TextBox3.Text) Then
            EPPRIX.SetError(TextBox3, "Valeur erronée")
            bp = False
        Else
            If (CInt(TextBox3.Text) <= 0) Then
                EPPRIX.SetError(TextBox3, "Valeur erronée")
                bp = False
            Else
                EPPRIX.SetError(TextBox3, "")
                bp = True
            End If
        End If
        Button1.Enabled = bn And be And bq And bp And bm And bs And bt
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox8.Text = (Val(TextBox7.Text) * Val(TextBox1.Text)).ToString
        TextBox11.Text = ((Val(TextBox10.Text) * Val(TextBox7.Text) + Val(TextBox7.Text)) * Val(TextBox1.Text)).ToString
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TextBox11.Text = ((Val(TextBox10.Text) * Val(TextBox7.Text) + Val(TextBox7.Text)) * Val(TextBox1.Text)).ToString


        If TextBox10.Text = "" Then
            EPTVA.SetError(TextBox10, "Champ obligatoire")
            bt = False
        ElseIf Not IsNumeric(TextBox10.Text) Then
            EPTVA.SetError(TextBox10, "Valeur erronée")
            bt = False
        Else
            If (CInt(TextBox10.Text) < 0) Then
                EPTVA.SetError(TextBox10, "Valeur erronée")
                bt = False
            Else
                EPTVA.SetError(TextBox6, "")
                bt = True
            End If
        End If
        Button1.Enabled = bn And be And bq And bp And bm And bs And bt
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox7.Text = (Val(TextBox6.Text) + Val(TextBox5.Text)).ToString
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox7.Text = (Val(TextBox6.Text) + Val(TextBox5.Text)).ToString


        If TextBox6.Text = "" Then
            EPSHP.SetError(TextBox6, "Champ obligatoire")
            bs = False
        ElseIf Not IsNumeric(TextBox6.Text) Then
            EPSHP.SetError(TextBox6, "Valeur erronée")
            bs = False
        Else
            If (CInt(TextBox6.Text) < 0) Then
                EPSHP.SetError(TextBox6, "Valeur erronée")
                bs = False
            Else
                EPSHP.SetError(TextBox6, "")
                bs = True
            End If
        End If
        Button1.Enabled = bn And be And bq And bp And bm And bs And bt
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox8.Text = (Val(TextBox7.Text) * Val(TextBox1.Text)).ToString
        TextBox11.Text = ((Val(TextBox10.Text) * Val(TextBox7.Text) + Val(TextBox7.Text)) * Val(TextBox1.Text)).ToString

        If TextBox1.Text = "" Then
            EPQUAN.SetError(TextBox1, "Champ obligatoire")
            bq = False
        ElseIf Not IsNumeric(TextBox1.Text) Then
            EPQUAN.SetError(TextBox1, "Valeur erronée")
            bq = False
        Else
            If (CInt(TextBox1.Text) <= 0) Then
                EPQUAN.SetError(TextBox1, "Valeur erronée")
                bq = False
            Else
                EPQUAN.SetError(TextBox1, "")
                bq = True
            End If
        End If
        Button1.Enabled = bn And be And bq And bp And bm And bs And bt
    End Sub


    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If (npdt.recherch_prod(ComboBox1.Text, data3) = True) Then
            bn = True
            EPNOM.SetError(ComboBox1, "")
        Else
            bn = False
            EPNOM.SetError(ComboBox1, "Valeur erronée")
        End If
        Button1.Enabled = bn And be And bq And bp And bm And bs And bt
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        If ComboBox2.Text = "" Then
            EPEMPL.SetError(ComboBox2, "erreur")
            be = False
        Else
            EPEMPL.SetError(ComboBox2, "")
            be = True
        End If
        Button1.Enabled = bn And be And bq And bp And bm And bs And bt
    End Sub

End Class