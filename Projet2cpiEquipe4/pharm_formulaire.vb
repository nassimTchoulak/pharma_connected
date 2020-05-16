Imports System.Net
Imports System.IO
Public Class pharm_formulaire
    Dim bool1 As Boolean = False
    Dim bool2 As Boolean = False
    Dim bool3 As Boolean = False
    Dim bool4 As Boolean = False
    Dim bool5 As Boolean = False

    Private Sub txt_nom_TextChanged(sender As Object, e As EventArgs) Handles txt_nom.TextChanged
        If txt_nom.Text = "" Then
            ErrorProvider1.SetError(txt_nom, "champ vide")
        ElseIf txt_nom.Text.Substring(0, 1) = " " Then
            ErrorProvider1.SetError(txt_nom, "début vide")
        Else
            ErrorProvider1.Clear()
        End If
        If (ErrorProvider1.GetError(txt_nom) = "") Then
            bool1 = True

        Else
            bool1 = False

        End If
        btn_add.Enabled = bool1 And bool2 And bool3 And bool4 And bool5 And bool6
    End Sub

    Private Sub add_pharm_formulaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_add.Enabled = False

    End Sub



    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim bas As DataBase = New DataBase()
        'bas.execute("insert into Pharmacie values ('" + txt_nom.Text + "','" + txt_adress.Text + "'," + txt_distance.Text + ",0,'" + txt_num.Text + "','" + txt_fax.Text + "','" + txt_ip.Text + "',0,'" + txt_server.Text + "','" + txt_user.Text + "','" + txt_passwd.Text + "')")
        bas.execute("insert into Pharmacie values ('" + txt_nom.Text + "','" + txt_adress.Text + "'," + txt_distance.Text + ",0,'" + txt_num.Text + "','" + txt_fax.Text + "',0,'" + txt_server.Text + "','" + txt_user.Text + "','" + txt_passwd.Text + "')")

        MsgBox("opération réussite")
        Me.Close()
    End Sub






    Private Sub txt_distance_TextChanged(sender As Object, e As EventArgs) Handles txt_distance.TextChanged

        Dim i As Integer
        Try
            i = CInt(txt_distance.Text)
            ErrorProvider1.Clear()
        Catch ex As Exception
            ErrorProvider2.SetError(txt_distance, "valeur non numérique")
        End Try
        If (ErrorProvider2.GetError(txt_distance) = "") Then
            bool2 = True

        Else
            bool2 = False

        End If
        btn_add.Enabled = bool1 And bool2 And bool3 And bool4 And bool5 And bool6

    End Sub

    Private Sub txt_server_TextChanged(sender As Object, e As EventArgs) Handles txt_server.TextChanged
        If txt_server.Text = "" Then
            ErrorProvider3.SetError(txt_server, "champ vide")
        ElseIf txt_server.Text.Substring(0, 1) = " " Then
            ErrorProvider3.SetError(txt_server, "début vide")
        Else
            ErrorProvider3.Clear()
        End If
        If (ErrorProvider3.GetError(txt_server) = "") Then
            bool3 = True

        Else
            bool3 = False

        End If
        btn_add.Enabled = bool1 And bool2 And bool3 And bool4 And bool5 And bool6
    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged
        If txt_user.Text = "" Then
            ErrorProvider4.SetError(txt_user, "champ vide")
        ElseIf txt_user.Text.Substring(0, 1) = " " Then
            ErrorProvider4.SetError(txt_user, "début vide")
        Else
            ErrorProvider4.Clear()
        End If
        If (ErrorProvider4.GetError(txt_user) = "") Then
            bool4 = True

        Else
            bool4 = False

        End If
        btn_add.Enabled = bool1 And bool2 And bool3 And bool4 And bool5 And bool6
    End Sub

    Private Sub txt_passwd_TextChanged(sender As Object, e As EventArgs) Handles txt_passwd.TextChanged
        If txt_passwd.Text = "" Then
            ErrorProvider5.SetError(txt_passwd, "champ vide")
        Else
            ErrorProvider5.Clear()
        End If
        If (ErrorProvider5.GetError(txt_passwd) = "") Then
            bool5 = True

        Else
            bool5 = False

        End If
        btn_add.Enabled = bool1 And bool2 And bool3 And bool4 And bool5
    End Sub
    Dim bool6 As Boolean = False
    Private Sub txt_ip_TextChanged(sender As Object, e As EventArgs) Handles txt_ip.TextChanged
        Dim fg As IPAddress
        Try
            fg = IPAddress.Parse(txt_ip.Text)
            ErrorProvider6.Clear()
        Catch ex As Exception
            ErrorProvider6.SetError(txt_ip, "adress ip non valide")
        End Try
        If (ErrorProvider5.GetError(txt_passwd) = "") Then
            bool6 = True

        Else
            bool6 = False

        End If
        btn_add.Enabled = bool1 And bool2 And bool3 And bool4 And bool5
    End Sub
End Class