Public Class CompteAjout

    Private d, d1 As DataSet
    Private b As DataBase = New DataBase()
    Private compte As Compte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        compte = New Compte()
        If Not PictureBox1.Visible And Not PictureBox2.Visible And Not PictureBox3.Visible And Not PictureBox4.Visible And Not PictureBox5.Visible And Not PictureBox6.Visible Then
            compte.AjouterCompte(TextBox3.Text, compte.GetHash(TextBox4.Text), TextBox1.Text, TextBox2.Text, ComboBox1.Text)
            CompteAffichage.CompteAffichage_Load(Nothing, Nothing)
            If MsgBox("Le compte a été ajouté", 0, "Confirmation") = MsgBoxResult.Ok Then
                Me.Close()
            End If
        Else
            Label9.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PictureBox1.Visible = True
        If TextBox1.Text = "" Then
            PictureBox1.Visible = True
        ElseIf TextBox1.Text.First = " " Or TextBox1.Text.Contains("  ") Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        PictureBox2.Visible = True
        If TextBox2.Text = "" Then
            PictureBox2.Visible = True
        ElseIf TextBox2.Text.First = " " Or TextBox2.Text.Contains("  ") Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        compte = New Compte()
        Dim UserUsed As Boolean
        UserUsed = False
        compte.UsedUSer(TextBox3.Text, UserUsed)
        PictureBox3.Visible = True
        If UserUsed Then
            PictureBox3.Visible = True
        ElseIf TextBox3.Text.First = " " Or TextBox3.Text.Contains("  ") Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        PictureBox4.Visible = True
        If TextBox4.Text = "" Then
            PictureBox4.Visible = True
        ElseIf TextBox4.Text.First = " " Or TextBox4.Text.Contains("  ") Then
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        PictureBox5.Visible = True
        If TextBox5.Text = "" Then
            PictureBox5.Visible = True
        Else
            If TextBox5.Text <> TextBox4.Text Then
                PictureBox5.Visible = True
            Else
                PictureBox5.Visible = False
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox6.Visible = False
        If ComboBox1.Text = "" Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class