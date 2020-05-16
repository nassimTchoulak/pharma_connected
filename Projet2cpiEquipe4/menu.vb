Imports System.IO

Public Class menu
    Private b As New MouseButtons()
    Private tr As New TreeNode()
    Private u As New TreeNodeMouseClickEventArgs(tr, b, 0, 0, 0)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        'Hour.Text = tim()
        ST_DATE.Text = Date.Now
    End Sub

    Private Sub menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("Voulez-vous vraiment quitter le programme?", 36, "Confirmation") = MsgBoxResult.Yes) Then
            DataBase.close()
            Launch.Close()
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        La.Text = Launch.namepharm
        LBL_NOM_UTIL.Text = Compte.Nom
        'LBL_NIV.Text = "Niveau :" + Compte.Niveau
        Select Case Compte.Niveau
            Case "1"
                LBL_NIV.Text = "Gérant"
            Case "2"
                LBL_NIV.Text = "Admin vendeur"
            Case "3"
                LBL_NIV.Text = "Simple vendeur"
        End Select
        ST_CONNECT.Text = "|    " + Compte.Nom
        PNL_SIDE_MENU.SendToBack()
        Timer_notif.Interval = 10000
        Gp_notif.Visible = False
        MenuStrip4.SendToBack()

    End Sub

    Public Sub affichernotf(s As String)
        Gp_notif.Visible = True
        lb_notif.Text = s
        Gp_notif.BringToFront()
        Timer_notif.Start()
    End Sub
    'make public here
    Public Sub Timer_notif_Tick(sender As Object, e As EventArgs) Handles Timer_notif.Tick
        Timer_notif.Stop()
        Gp_notif.Visible = False
        Gp_notif.SendToBack()
    End Sub

    Private Sub BT_VENTE_Click(sender As Object, e As EventArgs) Handles BT_VENTE.Click
        Precedent.push(Me.ToString, 1)
        Vente.Show()
        Me.Visible = False
        Vente.Show()

    End Sub


    Private Sub BT_COMMANDE_Click(sender As Object, e As EventArgs) Handles BT_COMMANDE.Click
        If Compte.Niveau < 3 Then
            Precedent.push(Me.ToString, 0)
            Achat_Commande.Show()
            Me.Visible = False
            Achat_Commande.Show()
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If


    End Sub

    Private Sub BT_STOCK_Click(sender As Object, e As EventArgs) Handles BT_ACHAT.Click
        If Compte.Niveau < 3 Then
            Precedent.push(Me.ToString, 0)
            Achat_Achat.Show()
            Me.Visible = False
            Achat_Achat.Show()
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_STOCK.Click
        Precedent.push(Me.ToString, 0)
        Stock.Show()
        Me.Visible = False
        Stock.Show()

    End Sub

    Private Sub BT_PRODREST_Click(sender As Object, e As EventArgs) Handles BT_PRODREST.Click
        Precedent.push(Me.ToString, 0)
        RestMain.Show()
        Me.Visible = False
        RestMain.Show()

    End Sub

    Private Sub BT_Compte_Click(sender As Object, e As EventArgs) Handles BT_Compte.Click
        If Compte.Niveau < 3 Then
            Precedent.push(Me.ToString, 0)
            CompteAffichage.Show()
            Me.Visible = False
            CompteAffichage.Show()
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BT_PHARM.Click

        Precedent.push(Me.ToString, 0)
        pharm_connected.Show()
        Me.Visible = False
        pharm_connected.Show()

    End Sub

    Private Sub B_Prec_Click(sender As Object, e As EventArgs) Handles B_Prec.Click
        Dim i As String
        Dim tab As Integer = 0
        i = Precedent.pop(tab)
        Select Case i
            Case Accueil.ToString
                Accueil.Show()
                Me.Visible = False
                Accueil.Show()
            Case Vente.ToString
                Vente.Show()
                Me.Visible = False
                Vente.Show()
            Case Achat_Commande.ToString
                Achat_Commande.Show()
                Me.Visible = False
                Achat_Commande.Show()
            Case Achat_Achat.ToString
                Achat_Achat.Show()
                Me.Visible = False
                Achat_Achat.Show()
            Case Stock.ToString
                Stock.Show()
                Me.Visible = False
                Stock.Show()
        End Select
    End Sub

    Private Sub B_Home_Click(sender As Object, e As EventArgs) Handles B_Home.Click
        Precedent.push(Me.ToString, 0)
        Accueil.Show()
        Me.Visible = False
        Accueil.Show()
    End Sub




    '================================== MENUSTRIP RESTITUTION ============================================
    Private Sub ListeDesProduitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesProduitsToolStripMenuItem.Click
        BT_PRODREST_Click(Nothing, Nothing)
    End Sub

    Private Sub JournalDeVenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JournalDeVenteToolStripMenuItem.Click
        BT_PRODREST_Click(Nothing, Nothing)
        RestMain.TabControl1.SelectTab("TAB_JOURNAL")
    End Sub

    Private Sub AjouterUnProduitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnProduitToolStripMenuItem.Click
        RestAjout.Show()
    End Sub

    Private Sub VendreUnProduitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendreUnProduitToolStripMenuItem.Click
        RestVente.Show()
    End Sub

    Private Sub AideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AideToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath + "\MEDELA - Aide.chm")
    End Sub

    Private Sub AideEnLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AideEnLigneToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath + "\MEDELA - Aide\MEDELA - Aide.html")
    End Sub

    Private Sub IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IToolStripMenuItem.Click
        Me.Hide()
        initial.Show()
        CompteConnect.ShowDialog()
    End Sub

    Private Sub AjouterUnCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnCompteToolStripMenuItem.Click
        If Compte.Niveau = 1 Then
            Precedent.push(Me.ToString, 0)
            CompteAffichage.Show()
            Me.Visible = False
            CompteAffichage.Show()
            CompteAjout.Show()
            CompteAffichage.TabPage1.Show()
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If

    End Sub

    Private Sub SupprimerUnCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerUnCompteToolStripMenuItem.Click
        If Compte.Niveau = 1 Then
            Precedent.push(Me.ToString, 0)
            CompteAffichage.Show()
            Me.Visible = False
            CompteAffichage.Show()
            CompteSupp.Show()
            CompteAffichage.TabPage1.Show()
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If
    End Sub

    Private Sub RenitialiserUnCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenitialiserUnCompteToolStripMenuItem.Click
        If Compte.Niveau = 1 Then
            Precedent.push(Me.ToString, 0)
            CompteAffichage.Show()
            Me.Visible = False
            CompteAffichage.Show()
            CompteRenit.Show()
            CompteAffichage.TabPage1.Show()
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If
    End Sub

    Private Sub HistoriqueDesComptesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriqueDesComptesToolStripMenuItem.Click
        If Compte.Niveau = 1 Then
            Precedent.push(Me.ToString, 0)
            CompteAffichage.Show()
            Me.Visible = False
            CompteAffichage.Show()
            CompteAffichage.TabControl1.SelectedTab = CompteAffichage.TabPage2
        Else
            MsgBox("Vous n'avez pas l'autorisation d'accéder à cette page", 16, "Accès refusé")
        End If
    End Sub

    Private Sub ModifierUnCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierUnCompteToolStripMenuItem.Click

        CompteModifier.Show()


    End Sub

    Private Sub ProduitsPlusVendusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduitsPlusVendusToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        Stats.Chart1.Series("prix").Points.Clear()

        u.Node.Text = "Produits Plus Vendus"
        Stats.TreeView1_NodeMouseClick(Nothing, u)

    End Sub



    Private Sub ProduitsPlusAchetésToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProduitsPlusAchetésToolStripMenuItem1.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Produits Plus achetés"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub FournisseursPlusDemandésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FournisseursPlusDemandésToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Produits Plus Commandés"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub ProduitsPlusRestituésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduitsPlusRestituésToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Produits Plus restitué"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub ProduitsPlusRestituablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduitsPlusRestituablesToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Produits Plus restituable"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub ProduitsPlusDisponibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduitsPlusDisponibleToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Produits Plus disponible"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub ProduitsPlusPérissableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduitsPlusPérissableToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Produits Plus périmés"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub ProduitsPlusRemboursableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduitsPlusRemboursableToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Produits Plus Remboursable"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub PharmaciesPlusDemandésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PharmaciesPlusDemandésToolStripMenuItem.Click
        Precedent.push(Me.ToString, 0)
        Stats.Show()

        Me.Visible = False
        Stats.Show()

        u.Node.Text = "Degrés d'échange"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub



    Private Sub ProduitsPlusAchetésToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProduitsPlusAchetésToolStripMenuItem.Click
        u.Node.Text = "Produits Plus chéres"
        Stats.TreeView1_NodeMouseClick(Nothing, u)
    End Sub

    Private Sub lb_notif_Click(sender As Object, e As EventArgs) Handles lb_notif.Click
        Precedent.push(Me.ToString, 0)
        pharm_connected.Show()
        Me.Visible = False
        pharm_connected.Show()
        pharm_connected.pharmacie_tab.SelectTab(3)
        pharm_connected.pharm_recu.SelectTab(0)
        'for all forms
        Timer_notif.Stop()
        Gp_notif.Visible = False
        Gp_notif.SendToBack()
        Vente.Timer_notif_Tick(Nothing, Nothing)

        CompteAffichage.Timer_notif_Tick(Nothing, Nothing)
        pharm_connected.Timer_notif_Tick(Nothing, Nothing)
        Achat_Achat.Timer_notif_Tick(Nothing, Nothing)
        Achat_Commande.Timer_notif_Tick(Nothing, Nothing)
        Stock.Timer_notif_Tick(Nothing, Nothing)
        RestMain.Timer_notif_Tick(Nothing, Nothing)

    End Sub
End Class