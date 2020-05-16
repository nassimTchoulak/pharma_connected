Public Class Accueil
    Inherits menu
  



    Private Sub BT_ACC_VENTE_Click(sender As Object, e As EventArgs) Handles BT_ACC_VENTE.Click
        Precedent.push(Me.ToString, 1)
        Vente.Show()
        Me.Visible = False
    End Sub

    Private Sub BT_ACC_COMMANDE_Click(sender As Object, e As EventArgs) Handles BT_ACC_COMMANDE.Click
        If Compte.Niveau < 3 Then
            Precedent.push(Me.ToString, 0)
            Achat_Commande.Show()
            Me.Visible = False
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If
    End Sub

    Private Sub BT_ACC_ACHAT_Click(sender As Object, e As EventArgs) Handles BT_ACC_ACHAT.Click
        If Compte.Niveau < 3 Then
            Precedent.push(Me.ToString, 0)
            Achat_Achat.Show()
            Me.Visible = False
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If
    End Sub

    Private Sub BT_ACC_STOCK_Click(sender As Object, e As EventArgs) Handles BT_ACC_STOCK.Click
        Precedent.push(Me.ToString, 0)
        Stock.Show()
        Me.Visible = False
    End Sub

    Private Sub BT_ACC_COMPTES_Click(sender As Object, e As EventArgs) Handles BT_ACC_COMPTES.Click
        If Compte.Niveau < 3 Then
            Precedent.push(Me.ToString, 0)
            CompteAffichage.Show()
            Me.Visible = False
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If
    End Sub

    Private Sub BT_ACC_RESEAU_Click(sender As Object, e As EventArgs) Handles BT_ACC_RESEAU.Click
        Precedent.push(Me.ToString, 0)
        pharm_connected.Show()
        Me.Visible = False
    End Sub

    Private Sub BT_ACC_RESTITUTION_Click(sender As Object, e As EventArgs) Handles BT_ACC_RESTITUTION.Click
        Precedent.push(Me.ToString, 0)
        RestMain.Show()
        Me.Visible = False
    End Sub

    Private Sub BT_ACC_STATISTIQUE_Click(sender As Object, e As EventArgs) Handles BT_ACC_STATISTIQUE.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()
    End Sub


    Private Sub lbl_acceuil_Click(sender As Object, e As EventArgs) Handles lbl_acceuil_notif.DoubleClick
        Precedent.push(Me.ToString, 0)
        pharm_connected.Show()
        Me.Visible = False
        pharm_connected.pharmacie_tab.SelectTab(3)
        pharm_connected.pharm_recu.SelectTab(0)

    End Sub

    
End Class