Public Class CompteRenit

    Private d, d1 As DataSet
    Private b As DataBase = New DataBase()
    Private compte As Compte

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        b = New DataBase()
        b.execute("SELECT [Identifiant] FROM Compte Where Identifiant LIKE'" + TextBox1.Text + "%'")
        d1 = New DataSet()
        b.read(d1, "Compte")
        ListBox1.DataSource = d1.Tables("Compte")
        ListBox1.DisplayMember = "Identifiant"
        compte = New Compte()
        Dim UserUsed As Boolean
        PictureBox1.Visible = False
        UserUsed = False
        compte.UsedUSer(TextBox1.Text, UserUsed)
        If Not UserUsed Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        TextBox1.Text = ListBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        compte = New Compte
        b = New DataBase()
        b.execute("SELECT [Password] FROM Compte WHERE Niveau = '1'")
        d = New DataSet()
        b.read(d, "Compte")
        PictureBox2.Visible = False
        If compte.GetHash(TextBox2.Text) = d.Tables("Compte").Rows(0).Item("Password").ToString Then
            PictureBox2.Visible = False
        Else
            PictureBox2.Visible = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        PictureBox3.Visible = False
        If TextBox3.Text = "" Then
            PictureBox3.Visible = True
        Else
            If TextBox2.Text <> TextBox3.Text Then
                PictureBox3.Visible = True
            Else
                PictureBox3.Visible = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        compte = New Compte()
        Dim newpass As String
        If TextBox1.Text = "admin" Then
            Label6.Visible = True
        Else
            If Not PictureBox1.Visible And Not PictureBox2.Visible And Not PictureBox3.Visible Then
                If MsgBox("Voullez-vous réinitialiser le compte", 4, "réinitialisation") = MsgBoxResult.Yes Then
                    newpass = compte.ReCompte(TextBox1.Text)
                    CompteAffichage.CompteAffichage_Load(Nothing, Nothing)
                    If MsgBox("Le nouveau mot de passe est : " + newpass + "", 0, "le compte a été réinitialisé") = MsgBoxResult.Ok Then
                        Me.Close()
                    End If
                End If
            Else
                Label4.Visible = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CompteSupprimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class