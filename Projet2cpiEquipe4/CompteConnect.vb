Public Class CompteConnect
    Private compte As Compte
    Dim b As New DataBase()
    Private Sub Connection1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Connection1_Enter(sender As Object, e As EventArgs) Handles MyBase.Activated
        compte = New Compte()
        Dim first As Boolean
        compte.firstConn(first)
        If first Then
            CompteFirstConnect.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim juste As Boolean
        Dim TypeErreur As Integer
        Dim s As String = TextBox1.Text
        juste = False
        compte = New Compte()
        compte.verifier(TextBox1.Text, TextBox2.Text, juste, TypeErreur)
        If juste Then
            compte.AjouterHistorique(s, Date.Now.Date, Date.Now.TimeOfDay.ToString.Substring(0, 8))

            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.Visible = False
            Accueil.Show()
            initial.Hide()

            '-----------------------------------------------------------------------
            Dim verif As Stock_Verification = New Stock_Verification()

            Dim d1 As DataSet = verif.Verifier_Perime()
            Dim d2 As DataSet = verif.Verifier_Proche_Peremption()
            Dim d3 As DataSet = verif.Verifier_Rupture()
            Accueil.Label11.Text = d1.Tables(0).Rows.Count
            Accueil.Label12.Text = d2.Tables(0).Rows.Count
            Accueil.Label14.Text = d3.Tables(0).Rows.Count
            Launch.Timer2.Enabled = True
            '-----------------------------------------------------------------------
        Else
            If TypeErreur = 0 Then
                MsgBox("Nom d'utilisateur inexistant", 16, "Erreur")
            Else
                MsgBox("Mot de passe incorrect", 16, "Erreur")
            End If
        End If
        Accueil.LBL_NOM_UTIL.Text = compte.getnom()
        Select Case compte.getniveau()
            Case "1"
                Accueil.LBL_NIV.Text = "Gérant"
            Case "2"
                Accueil.LBL_NIV.Text = "Admin vendeur"
            Case "3"
                Accueil.LBL_NIV.Text = "Simple vendeur"
        End Select



        Dim d As DataSet = New DataSet()
        Dim aaaa, mm, jj, now As String
        d = New DataSet()
        aaaa = Date.Now.ToString.Substring(6, 4)
        mm = Date.Now.ToString.Substring(3, 2)
        jj = Date.Now.ToString.Substring(0, 2)
        now = aaaa + "-" + mm + "-" + jj + " " + Date.Now.ToString.Substring(11, 8)
        b.execute("UPDATE Lot SET Expiré='1' WHERE [Date Expiration] <= '" + now + "'")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Vueillez contacter le gérant", 64, "Mot de passe oublié")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Souhaitez-vous vraiment quitter le programme ?", 36, "Quitter?") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class