Public Class VenteEqu

    Private b As DataBase = New DataBase()
    Private d As DataSet = New DataSet()
    Private d1 As DataSet = New DataSet()
    Private d2 As DataSet = New DataSet()
    Private code As String

    Private Sub VenteRecherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        b.execute("select * from produit")
        b.read(d, "tst")
        ComboBox1.DataSource = d.Tables("tst")
        ComboBox1.DisplayMember = "Nom"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, i As Integer
        DataGridView1.Rows.Clear()
        Select Case RadioButton1.Checked
            Case True
                b.execute("select * from produit where [Code Equivalence] ='" + code + "'")
                x = b.read(d1, "tst")

            Case False
                b.execute("select * from produit where [Code Equivalence] = '" + TextBox4.Text + "'")
                x = b.read(d1, "tst")
        End Select

        Select Case x
            Case Is <> 0
                Label2.Visible = False

                DataGridView1.Visible = True

                For i = 0 To x - 1
                    DataGridView1.Rows.Add(d1.Tables("tst").Rows(i).Item("Nom").ToString)
                Next
            Case 0

                DataGridView1.Visible = False
                Label2.Visible = True
        End Select


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim r As DataSet = New DataSet()
        Dim p As Integer
        b.execute("select * from produit where Nom ='" + ComboBox1.Text + "'")
        p = b.read(r, "tst")
        If p = 0 Then
            Button1.Enabled = False
        Else
            If RadioButton1.Checked = True Then
                code = r.Tables("tst").Rows(0).Item("Code Equivalence").ToString
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim r As DataSet = New DataSet()
        Dim p As Integer
        b.execute("select * from Equivalent where [Code Equivalence] ='" + TextBox4.Text + "'")
        p = b.read(r, "tst")
        If p = 0 Then
            Button1.Enabled = False
        Else
            If RadioButton1.Checked = False Then
                Button1.Enabled = True
            End If
        End If
    End Sub
End Class