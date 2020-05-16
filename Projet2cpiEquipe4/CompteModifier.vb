Public Class CompteModifier

    Private d, d1 As DataSet
    Private b As DataBase = New DataBase()
    Private compte As Compte

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        compte = New Compte()
        PictureBox3.Visible = True
        If TextBox3.Text = compte.getuser() Then
            PictureBox3.Visible = False
        Else
            PictureBox3.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        compte = New Compte
        b = New DataBase()
        b.execute("SELECT [Password] FROM Compte WHERE Identifiant = '" + TextBox3.Text + "'")
        d = New DataSet()
        b.read(d, "Compte")
        PictureBox4.Visible = False
        If compte.GetHash(TextBox4.Text) = d.Tables("Compte").Rows(0).Item("Password").ToString Then
            PictureBox4.Visible = False
        Else
            PictureBox4.Visible = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        If TextBox5.Text <> TextBox6.Text Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If
        If TextBox5.Text = "" Then
            PictureBox5.Visible = True
        ElseIf TextBox5.Text.First = " " Or TextBox5.Text.Contains("  ") Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        PictureBox6.Visible = True
        If TextBox6.Text = "" Then
            PictureBox6.Visible = True
        Else
            If TextBox5.Text <> TextBox6.Text Then
                PictureBox6.Visible = True
            Else
                PictureBox6.Visible = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        compte = New Compte()
        If Not PictureBox3.Visible And Not PictureBox4.Visible And Not PictureBox5.Visible And Not PictureBox6.Visible Then
            compte.ModifierComptePassword(TextBox3.Text, compte.GetHash(TextBox5.Text))
            If MsgBox("Le compte a été modifié", 0, "le compte a été modifié") = MsgBoxResult.Ok Then
                Me.Close()
            End If
        Else
            Label9.Visible = True
        End If
    End Sub

    Private Sub CompteModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class