Public Class VenteRecherche
    Private b As DataBase = New DataBase()
    Private d As DataSet = New DataSet()
    Private d1 As DataSet = New DataSet()
    Private d2 As DataSet = New DataSet()

    Private Sub VenteRecherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        b.execute("select * from produit")
        b.read(d, "tst")
        ComboBox1.DataSource = d.Tables("tst")
        ComboBox1.DisplayMember = "Nom"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, i As Integer
        DataGridView1.Rows.Clear()
        Select Case RadioButton1.Checked
            Case True
                b.execute("select * from produit where nom ='" + ComboBox1.Text + "'")
                x = b.read(d1, "tst")
            Case False
                b.execute("select * from produit where ID = " & Val(TextBox4.Text))
                x = b.read(d1, "tst")
        End Select

        Select Case x
            Case Is <> 0
                Label12.Visible = False
                Panel3.BackColor = Color.White
                DataGridView1.Visible = True
                code.Text = d1.Tables("tst").Rows(0).Item("ID").ToString
                fami.Text = d1.Tables("tst").Rows(0).Item("Famille").ToString
                nom.Text = d1.Tables("tst").Rows(0).Item("Nom").ToString
                lab.Text = d1.Tables("tst").Rows(0).Item("Laboratoire").ToString
                dci.Text = d1.Tables("tst").Rows(0).Item("DCI").ToString
                actu.Text = d1.Tables("tst").Rows(0).Item("Quantité Actuelle").ToString
                alrt.Text = d1.Tables("tst").Rows(0).Item("Quantité Alerte").ToString
                remb.Text = d1.Tables("tst").Rows(0).Item("Remboursement").ToString

                b.execute("select * from lot where IDproduit = " & Val(d1.Tables("tst").Rows(0).Item("ID").ToString))
                y = b.read(d2, "tst")
                For i = 0 To y - 1
                    DataGridView1.Rows.Add(d2.Tables("tst").Rows(i).Item("ID").ToString, d2.Tables("tst").Rows(i).Item("Date Expiration").ToString, d2.Tables("tst").Rows(i).Item("Quantité").ToString, d2.Tables("tst").Rows(0).Item("Prix Unitaire Vente").ToString)
                Next
            Case 0
                Panel3.BackColor = Color.Teal
                DataGridView1.Visible = False
                Label12.Visible = True
        End Select


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class