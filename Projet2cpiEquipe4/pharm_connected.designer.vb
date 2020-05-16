<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharm_connected
    Inherits menu

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharm_connected))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_answer = New System.Windows.Forms.Timer(Me.components)
        Me.pharmacie_tab = New System.Windows.Forms.TabControl()
        Me.pharms = New System.Windows.Forms.TabPage()
        Me.lbl_pharma = New System.Windows.Forms.Label()
        Me.dg_pharm_dispo = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Distance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_state = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.recherche = New System.Windows.Forms.TabPage()
        Me.lbl_produict = New System.Windows.Forms.Label()
        Me.dg_pharma_do = New System.Windows.Forms.DataGridView()
        Me.Nomm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adresss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Distancee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantité = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.selection = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.commender = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pharm_list = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pharm_commande_btn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pharm_rech_btn = New System.Windows.Forms.Button()
        Me.pharm_quant = New System.Windows.Forms.TextBox()
        Me.pharm_prod_txt = New System.Windows.Forms.TextBox()
        Me.dones = New System.Windows.Forms.TabPage()
        Me.lbl_do = New System.Windows.Forms.Label()
        Me.dg_commande_faite = New System.Windows.Forms.DataGridView()
        Me.exdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unites = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pharmacie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Distances = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.pharm_combo_done_filter = New System.Windows.Forms.ComboBox()
        Me.pharm_update_comd = New System.Windows.Forms.Button()
        Me.recived = New System.Windows.Forms.TabPage()
        Me.pharm_recu = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_encourt = New System.Windows.Forms.Label()
        Me.pharm_answer = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.re_Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.re_Produit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.re_Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.decline = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pharm_btn_refuse_all = New System.Windows.Forms.Button()
        Me.pharm_btn_accept_all = New System.Windows.Forms.Button()
        Me.pharm_update_answer = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_accepted = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pharm_accepted_filter = New System.Windows.Forms.ComboBox()
        Me.pharm_update_last = New System.Windows.Forms.Button()
        Me.dg_accepted_commande = New System.Windows.Forms.DataGridView()
        Me.exdate2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produit2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pharmacie2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNL_SIDE_MENU.SuspendLayout()
        Me.pharmacie_tab.SuspendLayout()
        Me.pharms.SuspendLayout()
        CType(Me.dg_pharm_dispo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.recherche.SuspendLayout()
        CType(Me.dg_pharma_do, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.dones.SuspendLayout()
        CType(Me.dg_commande_faite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.recived.SuspendLayout()
        Me.pharm_recu.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pharm_answer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dg_accepted_commande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_SIDE_MENU
        '
        Me.PNL_SIDE_MENU.Location = New System.Drawing.Point(0, 69)
        Me.PNL_SIDE_MENU.Size = New System.Drawing.Size(200, 658)
        '
        'BT_Compte
        '
        Me.BT_Compte.FlatAppearance.BorderSize = 0
        '
        'BT_PHARM
        '
        Me.BT_PHARM.FlatAppearance.BorderSize = 0
        '
        'BT_STOCK
        '
        Me.BT_STOCK.FlatAppearance.BorderSize = 0
        '
        'LBL_NOM_UTIL
        '
        Me.LBL_NOM_UTIL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_NOM_UTIL.Size = New System.Drawing.Size(0, 16)
        Me.LBL_NOM_UTIL.Text = ""
        '
        'BT_PRODREST
        '
        Me.BT_PRODREST.FlatAppearance.BorderSize = 0
        '
        'BT_ACHAT
        '
        Me.BT_ACHAT.FlatAppearance.BorderSize = 0
        '
        'BT_COMMANDE
        '
        Me.BT_COMMANDE.FlatAppearance.BorderSize = 0
        '
        'BT_VENTE
        '
        Me.BT_VENTE.FlatAppearance.BorderSize = 0
        '
        'Timer1
        '
        '
        'Timer12
        '
        '
        'Timer_answer
        '
        '
        'pharmacie_tab
        '
        Me.pharmacie_tab.Controls.Add(Me.pharms)
        Me.pharmacie_tab.Controls.Add(Me.recherche)
        Me.pharmacie_tab.Controls.Add(Me.dones)
        Me.pharmacie_tab.Controls.Add(Me.recived)
        Me.pharmacie_tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pharmacie_tab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharmacie_tab.ItemSize = New System.Drawing.Size(191, 40)
        Me.pharmacie_tab.Location = New System.Drawing.Point(200, 69)
        Me.pharmacie_tab.Name = "pharmacie_tab"
        Me.pharmacie_tab.SelectedIndex = 0
        Me.pharmacie_tab.Size = New System.Drawing.Size(1064, 658)
        Me.pharmacie_tab.TabIndex = 57
        '
        'pharms
        '
        Me.pharms.Controls.Add(Me.lbl_pharma)
        Me.pharms.Controls.Add(Me.dg_pharm_dispo)
        Me.pharms.Controls.Add(Me.Panel7)
        Me.pharms.Location = New System.Drawing.Point(4, 44)
        Me.pharms.Name = "pharms"
        Me.pharms.Padding = New System.Windows.Forms.Padding(3)
        Me.pharms.Size = New System.Drawing.Size(1056, 610)
        Me.pharms.TabIndex = 0
        Me.pharms.Text = "Pharmacies disponibles"
        Me.pharms.UseVisualStyleBackColor = True
        '
        'lbl_pharma
        '
        Me.lbl_pharma.AutoSize = True
        Me.lbl_pharma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pharma.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_pharma.Location = New System.Drawing.Point(463, 285)
        Me.lbl_pharma.Name = "lbl_pharma"
        Me.lbl_pharma.Size = New System.Drawing.Size(159, 13)
        Me.lbl_pharma.TabIndex = 43
        Me.lbl_pharma.Text = "Aucune pharmacie n'est ajoutée"
        '
        'dg_pharm_dispo
        '
        Me.dg_pharm_dispo.AllowUserToAddRows = False
        Me.dg_pharm_dispo.AllowUserToDeleteRows = False
        Me.dg_pharm_dispo.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.dg_pharm_dispo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_pharm_dispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_pharm_dispo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_pharm_dispo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_pharm_dispo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_pharm_dispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pharm_dispo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Adresse, Me.Distance, Me.Tel, Me.Fax, Me.deg, Me.Etat})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_pharm_dispo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_pharm_dispo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_pharm_dispo.GridColor = System.Drawing.SystemColors.Control
        Me.dg_pharm_dispo.Location = New System.Drawing.Point(3, 100)
        Me.dg_pharm_dispo.Name = "dg_pharm_dispo"
        Me.dg_pharm_dispo.ReadOnly = True
        Me.dg_pharm_dispo.Size = New System.Drawing.Size(1050, 507)
        Me.dg_pharm_dispo.TabIndex = 16
        '
        'Nom
        '
        Me.Nom.HeaderText = "Pharmacie"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'Adresse
        '
        Me.Adresse.HeaderText = "Adress"
        Me.Adresse.Name = "Adresse"
        Me.Adresse.ReadOnly = True
        '
        'Distance
        '
        Me.Distance.HeaderText = "Distance"
        Me.Distance.Name = "Distance"
        Me.Distance.ReadOnly = True
        '
        'Tel
        '
        Me.Tel.HeaderText = "Tel"
        Me.Tel.Name = "Tel"
        Me.Tel.ReadOnly = True
        '
        'Fax
        '
        Me.Fax.HeaderText = "Fax"
        Me.Fax.Name = "Fax"
        Me.Fax.ReadOnly = True
        '
        'deg
        '
        Me.deg.HeaderText = "Degré d'échange"
        Me.deg.Name = "deg"
        Me.deg.ReadOnly = True
        '
        'Etat
        '
        Me.Etat.HeaderText = "Etat"
        Me.Etat.Name = "Etat"
        Me.Etat.ReadOnly = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.lbl_state)
        Me.Panel7.Controls.Add(Me.btn_add)
        Me.Panel7.Controls.Add(Me.btn_update)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1050, 97)
        Me.Panel7.TabIndex = 0
        '
        'lbl_state
        '
        Me.lbl_state.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_state.Location = New System.Drawing.Point(606, 19)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(338, 67)
        Me.lbl_state.TabIndex = 41
        Me.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Transparent
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_add.Location = New System.Drawing.Point(108, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(126, 83)
        Me.btn_add.TabIndex = 40
        Me.btn_add.Text = "Ajouter pharmacie"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.Control
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.Location = New System.Drawing.Point(247, 3)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(94, 83)
        Me.btn_update.TabIndex = 39
        Me.btn_update.Text = "Actualiser"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'recherche
        '
        Me.recherche.Controls.Add(Me.lbl_produict)
        Me.recherche.Controls.Add(Me.dg_pharma_do)
        Me.recherche.Controls.Add(Me.Panel8)
        Me.recherche.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recherche.Location = New System.Drawing.Point(4, 44)
        Me.recherche.Name = "recherche"
        Me.recherche.Padding = New System.Windows.Forms.Padding(3)
        Me.recherche.Size = New System.Drawing.Size(1056, 622)
        Me.recherche.TabIndex = 1
        Me.recherche.Text = "Commander un produit"
        Me.recherche.UseVisualStyleBackColor = True
        '
        'lbl_produict
        '
        Me.lbl_produict.AutoSize = True
        Me.lbl_produict.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produict.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_produict.Location = New System.Drawing.Point(461, 280)
        Me.lbl_produict.Name = "lbl_produict"
        Me.lbl_produict.Size = New System.Drawing.Size(83, 13)
        Me.lbl_produict.TabIndex = 54
        Me.lbl_produict.Text = "Aucune donnée"
        '
        'dg_pharma_do
        '
        Me.dg_pharma_do.AllowUserToAddRows = False
        Me.dg_pharma_do.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        Me.dg_pharma_do.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_pharma_do.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_pharma_do.BackgroundColor = System.Drawing.Color.White
        Me.dg_pharma_do.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_pharma_do.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_pharma_do.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_pharma_do.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pharma_do.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nomm, Me.adresss, Me.Distancee, Me.quantité, Me.selection, Me.commender})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_pharma_do.DefaultCellStyle = DataGridViewCellStyle6
        Me.dg_pharma_do.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_pharma_do.Location = New System.Drawing.Point(3, 123)
        Me.dg_pharma_do.Name = "dg_pharma_do"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_pharma_do.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dg_pharma_do.RowTemplate.Height = 25
        Me.dg_pharma_do.Size = New System.Drawing.Size(1050, 496)
        Me.dg_pharma_do.TabIndex = 22
        '
        'Nomm
        '
        Me.Nomm.HeaderText = "Nom de la pharmacie"
        Me.Nomm.Name = "Nomm"
        '
        'adresss
        '
        Me.adresss.HeaderText = "adress"
        Me.adresss.Name = "adresss"
        '
        'Distancee
        '
        Me.Distancee.HeaderText = "Distance"
        Me.Distancee.Name = "Distancee"
        '
        'quantité
        '
        Me.quantité.HeaderText = "quantité "
        Me.quantité.Name = "quantité"
        Me.quantité.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.quantité.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'selection
        '
        Me.selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selection.HeaderText = "commandes multiples"
        Me.selection.Name = "selection"
        '
        'commender
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.NullValue = CType(resources.GetObject("DataGridViewCellStyle5.NullValue"), Object)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen
        Me.commender.DefaultCellStyle = DataGridViewCellStyle5
        Me.commender.HeaderText = "commander"
        Me.commender.Image = CType(resources.GetObject("commender.Image"), System.Drawing.Image)
        Me.commender.Name = "commender"
        Me.commender.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.pharm_list)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.pharm_commande_btn)
        Me.Panel8.Controls.Add(Me.ComboBox1)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.pharm_rech_btn)
        Me.Panel8.Controls.Add(Me.pharm_quant)
        Me.Panel8.Controls.Add(Me.pharm_prod_txt)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1050, 120)
        Me.Panel8.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Location = New System.Drawing.Point(821, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 110)
        Me.Panel2.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Location = New System.Drawing.Point(854, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 30)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "tolérance de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la recherche"
        '
        'pharm_list
        '
        Me.pharm_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_list.FormattingEnabled = True
        Me.pharm_list.ItemHeight = 16
        Me.pharm_list.Location = New System.Drawing.Point(25, 45)
        Me.pharm_list.Name = "pharm_list"
        Me.pharm_list.Size = New System.Drawing.Size(410, 132)
        Me.pharm_list.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(698, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Commandes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(211, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "filtres et recherche"
        '
        'pharm_commande_btn
        '
        Me.pharm_commande_btn.BackColor = System.Drawing.Color.Transparent
        Me.pharm_commande_btn.FlatAppearance.BorderSize = 0
        Me.pharm_commande_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharm_commande_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_commande_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pharm_commande_btn.Image = CType(resources.GetObject("pharm_commande_btn.Image"), System.Drawing.Image)
        Me.pharm_commande_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pharm_commande_btn.Location = New System.Drawing.Point(665, 15)
        Me.pharm_commande_btn.Name = "pharm_commande_btn"
        Me.pharm_commande_btn.Size = New System.Drawing.Size(125, 80)
        Me.pharm_commande_btn.TabIndex = 50
        Me.pharm_commande_btn.Text = "commandes multiples"
        Me.pharm_commande_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.pharm_commande_btn.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"1", "0.75", "5", "0.25", "0.1"})
        Me.ComboBox1.FormatString = "r"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0.1", "0.25", "0.5", "0.75", "1"})
        Me.ComboBox1.Location = New System.Drawing.Point(953, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 24)
        Me.ComboBox1.TabIndex = 49
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel10.Location = New System.Drawing.Point(637, 5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 110)
        Me.Panel10.TabIndex = 48
        '
        'pharm_rech_btn
        '
        Me.pharm_rech_btn.BackColor = System.Drawing.Color.Transparent
        Me.pharm_rech_btn.FlatAppearance.BorderSize = 0
        Me.pharm_rech_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharm_rech_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_rech_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pharm_rech_btn.Image = CType(resources.GetObject("pharm_rech_btn.Image"), System.Drawing.Image)
        Me.pharm_rech_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pharm_rech_btn.Location = New System.Drawing.Point(502, 15)
        Me.pharm_rech_btn.Name = "pharm_rech_btn"
        Me.pharm_rech_btn.Size = New System.Drawing.Size(125, 80)
        Me.pharm_rech_btn.TabIndex = 44
        Me.pharm_rech_btn.Text = "Rechercher"
        Me.pharm_rech_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.pharm_rech_btn.UseVisualStyleBackColor = False
        '
        'pharm_quant
        '
        Me.pharm_quant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_quant.Location = New System.Drawing.Point(361, 17)
        Me.pharm_quant.Name = "pharm_quant"
        Me.pharm_quant.Size = New System.Drawing.Size(129, 22)
        Me.pharm_quant.TabIndex = 18
        '
        'pharm_prod_txt
        '
        Me.pharm_prod_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_prod_txt.Location = New System.Drawing.Point(25, 17)
        Me.pharm_prod_txt.Name = "pharm_prod_txt"
        Me.pharm_prod_txt.Size = New System.Drawing.Size(315, 22)
        Me.pharm_prod_txt.TabIndex = 17
        '
        'dones
        '
        Me.dones.Controls.Add(Me.lbl_do)
        Me.dones.Controls.Add(Me.dg_commande_faite)
        Me.dones.Controls.Add(Me.Panel11)
        Me.dones.Location = New System.Drawing.Point(4, 44)
        Me.dones.Name = "dones"
        Me.dones.Padding = New System.Windows.Forms.Padding(3)
        Me.dones.Size = New System.Drawing.Size(1056, 622)
        Me.dones.TabIndex = 2
        Me.dones.Text = "Commandes effectuées"
        Me.dones.UseVisualStyleBackColor = True
        '
        'lbl_do
        '
        Me.lbl_do.AutoSize = True
        Me.lbl_do.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_do.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_do.Location = New System.Drawing.Point(430, 256)
        Me.lbl_do.Name = "lbl_do"
        Me.lbl_do.Size = New System.Drawing.Size(152, 13)
        Me.lbl_do.TabIndex = 54
        Me.lbl_do.Text = "aucunne commande éffectuée"
        '
        'dg_commande_faite
        '
        Me.dg_commande_faite.AllowUserToAddRows = False
        Me.dg_commande_faite.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        Me.dg_commande_faite.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dg_commande_faite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_commande_faite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_commande_faite.BackgroundColor = System.Drawing.Color.White
        Me.dg_commande_faite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_commande_faite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_commande_faite.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.exdate, Me.Produit, Me.Unites, Me.Pharmacie, Me.Distances, Me.Adress, Me.Status})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_commande_faite.DefaultCellStyle = DataGridViewCellStyle9
        Me.dg_commande_faite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_commande_faite.GridColor = System.Drawing.SystemColors.Control
        Me.dg_commande_faite.Location = New System.Drawing.Point(3, 86)
        Me.dg_commande_faite.Name = "dg_commande_faite"
        Me.dg_commande_faite.Size = New System.Drawing.Size(1050, 533)
        Me.dg_commande_faite.TabIndex = 1
        '
        'exdate
        '
        Me.exdate.HeaderText = "Date"
        Me.exdate.Name = "exdate"
        '
        'Produit
        '
        Me.Produit.HeaderText = "Produit"
        Me.Produit.Name = "Produit"
        '
        'Unites
        '
        Me.Unites.HeaderText = "Unites"
        Me.Unites.Name = "Unites"
        '
        'Pharmacie
        '
        Me.Pharmacie.HeaderText = "Pharmacie"
        Me.Pharmacie.Name = "Pharmacie"
        '
        'Distances
        '
        Me.Distances.HeaderText = "Distances"
        Me.Distances.Name = "Distances"
        '
        'Adress
        '
        Me.Adress.HeaderText = "Adress"
        Me.Adress.Name = "Adress"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.pharm_combo_done_filter)
        Me.Panel11.Controls.Add(Me.pharm_update_comd)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1050, 83)
        Me.Panel11.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(538, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "filtre et affichage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(519, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Etat"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel13.Location = New System.Drawing.Point(332, 6)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1, 70)
        Me.Panel13.TabIndex = 49
        '
        'pharm_combo_done_filter
        '
        Me.pharm_combo_done_filter.FormattingEnabled = True
        Me.pharm_combo_done_filter.Items.AddRange(New Object() {"toutes les commandes", "les commandes acceptées", "les commandes refusées", "les commandes en court"})
        Me.pharm_combo_done_filter.Location = New System.Drawing.Point(559, 23)
        Me.pharm_combo_done_filter.Name = "pharm_combo_done_filter"
        Me.pharm_combo_done_filter.Size = New System.Drawing.Size(202, 24)
        Me.pharm_combo_done_filter.TabIndex = 41
        '
        'pharm_update_comd
        '
        Me.pharm_update_comd.BackColor = System.Drawing.SystemColors.Control
        Me.pharm_update_comd.FlatAppearance.BorderSize = 0
        Me.pharm_update_comd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharm_update_comd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_update_comd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pharm_update_comd.Image = CType(resources.GetObject("pharm_update_comd.Image"), System.Drawing.Image)
        Me.pharm_update_comd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pharm_update_comd.Location = New System.Drawing.Point(126, 6)
        Me.pharm_update_comd.Name = "pharm_update_comd"
        Me.pharm_update_comd.Size = New System.Drawing.Size(89, 64)
        Me.pharm_update_comd.TabIndex = 40
        Me.pharm_update_comd.Text = "Actualiser"
        Me.pharm_update_comd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pharm_update_comd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.pharm_update_comd.UseVisualStyleBackColor = False
        '
        'recived
        '
        Me.recived.BackColor = System.Drawing.Color.White
        Me.recived.Controls.Add(Me.pharm_recu)
        Me.recived.Location = New System.Drawing.Point(4, 44)
        Me.recived.Name = "recived"
        Me.recived.Padding = New System.Windows.Forms.Padding(3)
        Me.recived.Size = New System.Drawing.Size(1056, 610)
        Me.recived.TabIndex = 3
        Me.recived.Text = "Commandes reçues"
        '
        'pharm_recu
        '
        Me.pharm_recu.Controls.Add(Me.TabPage1)
        Me.pharm_recu.Controls.Add(Me.TabPage2)
        Me.pharm_recu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pharm_recu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pharm_recu.ItemSize = New System.Drawing.Size(96, 30)
        Me.pharm_recu.Location = New System.Drawing.Point(3, 3)
        Me.pharm_recu.Multiline = True
        Me.pharm_recu.Name = "pharm_recu"
        Me.pharm_recu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pharm_recu.SelectedIndex = 0
        Me.pharm_recu.Size = New System.Drawing.Size(1050, 604)
        Me.pharm_recu.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lbl_encourt)
        Me.TabPage1.Controls.Add(Me.pharm_answer)
        Me.TabPage1.Controls.Add(Me.Panel12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(1042, 566)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "En cours"
        '
        'lbl_encourt
        '
        Me.lbl_encourt.AutoSize = True
        Me.lbl_encourt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_encourt.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_encourt.Location = New System.Drawing.Point(404, 288)
        Me.lbl_encourt.Name = "lbl_encourt"
        Me.lbl_encourt.Size = New System.Drawing.Size(143, 13)
        Me.lbl_encourt.TabIndex = 54
        Me.lbl_encourt.Text = "Aucune commande en cours"
        '
        'pharm_answer
        '
        Me.pharm_answer.AllowUserToAddRows = False
        Me.pharm_answer.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        Me.pharm_answer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.pharm_answer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.pharm_answer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.pharm_answer.BackgroundColor = System.Drawing.Color.White
        Me.pharm_answer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pharm_answer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pharm_answer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.re_Nom, Me.re_Produit, Me.re_Quantité, Me.edate, Me.btn, Me.decline})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pharm_answer.DefaultCellStyle = DataGridViewCellStyle13
        Me.pharm_answer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pharm_answer.GridColor = System.Drawing.SystemColors.Control
        Me.pharm_answer.Location = New System.Drawing.Point(3, 93)
        Me.pharm_answer.Name = "pharm_answer"
        Me.pharm_answer.Size = New System.Drawing.Size(1034, 468)
        Me.pharm_answer.TabIndex = 1
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        're_Nom
        '
        Me.re_Nom.HeaderText = "Nom de la pharmacie"
        Me.re_Nom.Name = "re_Nom"
        '
        're_Produit
        '
        Me.re_Produit.HeaderText = "Produit"
        Me.re_Produit.Name = "re_Produit"
        '
        're_Quantité
        '
        Me.re_Quantité.HeaderText = "Quantité"
        Me.re_Quantité.Name = "re_Quantité"
        '
        'edate
        '
        Me.edate.HeaderText = "Date D'envoie"
        Me.edate.Name = "edate"
        '
        'btn
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn.DefaultCellStyle = DataGridViewCellStyle11
        Me.btn.HeaderText = "Accepter"
        Me.btn.Name = "btn"
        '
        'decline
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decline.DefaultCellStyle = DataGridViewCellStyle12
        Me.decline.HeaderText = "Refuser"
        Me.decline.Name = "decline"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Controls.Add(Me.pharm_btn_refuse_all)
        Me.Panel12.Controls.Add(Me.pharm_btn_accept_all)
        Me.Panel12.Controls.Add(Me.pharm_update_answer)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1034, 90)
        Me.Panel12.TabIndex = 2
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel14.Location = New System.Drawing.Point(372, 9)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 70)
        Me.Panel14.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(661, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 39)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Répondre à toutes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " les commandes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " en cours" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pharm_btn_refuse_all
        '
        Me.pharm_btn_refuse_all.FlatAppearance.BorderSize = 0
        Me.pharm_btn_refuse_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharm_btn_refuse_all.Image = CType(resources.GetObject("pharm_btn_refuse_all.Image"), System.Drawing.Image)
        Me.pharm_btn_refuse_all.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pharm_btn_refuse_all.Location = New System.Drawing.Point(547, 6)
        Me.pharm_btn_refuse_all.Margin = New System.Windows.Forms.Padding(0)
        Me.pharm_btn_refuse_all.Name = "pharm_btn_refuse_all"
        Me.pharm_btn_refuse_all.Size = New System.Drawing.Size(95, 75)
        Me.pharm_btn_refuse_all.TabIndex = 44
        Me.pharm_btn_refuse_all.Text = "Refuser tout"
        Me.pharm_btn_refuse_all.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pharm_btn_refuse_all.UseVisualStyleBackColor = True
        '
        'pharm_btn_accept_all
        '
        Me.pharm_btn_accept_all.FlatAppearance.BorderSize = 0
        Me.pharm_btn_accept_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharm_btn_accept_all.Image = CType(resources.GetObject("pharm_btn_accept_all.Image"), System.Drawing.Image)
        Me.pharm_btn_accept_all.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pharm_btn_accept_all.Location = New System.Drawing.Point(428, 6)
        Me.pharm_btn_accept_all.Name = "pharm_btn_accept_all"
        Me.pharm_btn_accept_all.Size = New System.Drawing.Size(95, 75)
        Me.pharm_btn_accept_all.TabIndex = 43
        Me.pharm_btn_accept_all.Text = "Accepter tout"
        Me.pharm_btn_accept_all.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pharm_btn_accept_all.UseVisualStyleBackColor = True
        '
        'pharm_update_answer
        '
        Me.pharm_update_answer.BackColor = System.Drawing.SystemColors.Control
        Me.pharm_update_answer.FlatAppearance.BorderSize = 0
        Me.pharm_update_answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharm_update_answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_update_answer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pharm_update_answer.Image = CType(resources.GetObject("pharm_update_answer.Image"), System.Drawing.Image)
        Me.pharm_update_answer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pharm_update_answer.Location = New System.Drawing.Point(141, 8)
        Me.pharm_update_answer.Name = "pharm_update_answer"
        Me.pharm_update_answer.Size = New System.Drawing.Size(94, 71)
        Me.pharm_update_answer.TabIndex = 42
        Me.pharm_update_answer.Text = "Actualiser"
        Me.pharm_update_answer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pharm_update_answer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.pharm_update_answer.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbl_accepted)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.dg_accepted_commande)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1105, 551)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Acceptées"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_accepted
        '
        Me.lbl_accepted.AutoSize = True
        Me.lbl_accepted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accepted.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_accepted.Location = New System.Drawing.Point(311, 157)
        Me.lbl_accepted.Name = "lbl_accepted"
        Me.lbl_accepted.Size = New System.Drawing.Size(150, 13)
        Me.lbl_accepted.TabIndex = 56
        Me.lbl_accepted.Text = "aucun commandes acceptées"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.Panel15)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.pharm_accepted_filter)
        Me.Panel6.Controls.Add(Me.pharm_update_last)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1099, 89)
        Me.Panel6.TabIndex = 1
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel15.Location = New System.Drawing.Point(220, 5)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 70)
        Me.Panel15.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(250, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 16)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Date d'envoie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(395, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Filtre et Affichage"
        '
        'pharm_accepted_filter
        '
        Me.pharm_accepted_filter.FormattingEnabled = True
        Me.pharm_accepted_filter.Items.AddRange(New Object() {"les derniers 2 heures", "les derniers 4 heures", "les derniers 8 heures", "Tout"})
        Me.pharm_accepted_filter.Location = New System.Drawing.Point(361, 20)
        Me.pharm_accepted_filter.Name = "pharm_accepted_filter"
        Me.pharm_accepted_filter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pharm_accepted_filter.Size = New System.Drawing.Size(229, 24)
        Me.pharm_accepted_filter.TabIndex = 42
        '
        'pharm_update_last
        '
        Me.pharm_update_last.BackColor = System.Drawing.SystemColors.Control
        Me.pharm_update_last.FlatAppearance.BorderSize = 0
        Me.pharm_update_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharm_update_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharm_update_last.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pharm_update_last.Image = CType(resources.GetObject("pharm_update_last.Image"), System.Drawing.Image)
        Me.pharm_update_last.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pharm_update_last.Location = New System.Drawing.Point(67, 3)
        Me.pharm_update_last.Name = "pharm_update_last"
        Me.pharm_update_last.Size = New System.Drawing.Size(89, 70)
        Me.pharm_update_last.TabIndex = 41
        Me.pharm_update_last.Text = "Actualiser"
        Me.pharm_update_last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pharm_update_last.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.pharm_update_last.UseVisualStyleBackColor = False
        '
        'dg_accepted_commande
        '
        Me.dg_accepted_commande.AllowUserToAddRows = False
        Me.dg_accepted_commande.AllowUserToDeleteRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        Me.dg_accepted_commande.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dg_accepted_commande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_accepted_commande.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_accepted_commande.BackgroundColor = System.Drawing.Color.White
        Me.dg_accepted_commande.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_accepted_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_accepted_commande.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.exdate2, Me.Produit2, Me.Quantité2, Me.Pharmacie2})
        Me.dg_accepted_commande.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dg_accepted_commande.Location = New System.Drawing.Point(3, 95)
        Me.dg_accepted_commande.Name = "dg_accepted_commande"
        Me.dg_accepted_commande.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dg_accepted_commande.Size = New System.Drawing.Size(1082, 438)
        Me.dg_accepted_commande.TabIndex = 0
        '
        'exdate2
        '
        Me.exdate2.HeaderText = "date de l'envoie"
        Me.exdate2.Name = "exdate2"
        '
        'Produit2
        '
        Me.Produit2.HeaderText = "Produit"
        Me.Produit2.Name = "Produit2"
        '
        'Quantité2
        '
        Me.Quantité2.HeaderText = "Quantité"
        Me.Quantité2.Name = "Quantité2"
        '
        'Pharmacie2
        '
        Me.Pharmacie2.HeaderText = "Pharmacie source"
        Me.Pharmacie2.Name = "Pharmacie2"
        '
        'pharm_connected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 749)
        Me.Controls.Add(Me.pharmacie_tab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "pharm_connected"
        Me.Text = "MEDELA - Connexion pharmacies"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.PNL_SIDE_MENU, 0)
        Me.Controls.SetChildIndex(Me.pharmacie_tab, 0)
        Me.PNL_SIDE_MENU.ResumeLayout(False)
        Me.pharmacie_tab.ResumeLayout(False)
        Me.pharms.ResumeLayout(False)
        Me.pharms.PerformLayout()
        CType(Me.dg_pharm_dispo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.recherche.ResumeLayout(False)
        Me.recherche.PerformLayout()
        CType(Me.dg_pharma_do, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.dones.ResumeLayout(False)
        Me.dones.PerformLayout()
        CType(Me.dg_commande_faite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.recived.ResumeLayout(False)
        Me.pharm_recu.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pharm_answer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dg_accepted_commande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer12 As System.Windows.Forms.Timer
    Friend WithEvents Timer_answer As System.Windows.Forms.Timer
    Friend WithEvents pharmacie_tab As System.Windows.Forms.TabControl
    Friend WithEvents pharms As System.Windows.Forms.TabPage
    Friend WithEvents lbl_pharma As System.Windows.Forms.Label
    Protected WithEvents dg_pharm_dispo As System.Windows.Forms.DataGridView
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Distance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Etat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbl_state As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents recherche As System.Windows.Forms.TabPage
    Friend WithEvents lbl_produict As System.Windows.Forms.Label
    Friend WithEvents dg_pharma_do As System.Windows.Forms.DataGridView
    Friend WithEvents Nomm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adresss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Distancee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantité As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents selection As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents commender As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pharm_list As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pharm_commande_btn As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents pharm_rech_btn As System.Windows.Forms.Button
    Friend WithEvents pharm_quant As System.Windows.Forms.TextBox
    Friend WithEvents pharm_prod_txt As System.Windows.Forms.TextBox
    Friend WithEvents dones As System.Windows.Forms.TabPage
    Friend WithEvents lbl_do As System.Windows.Forms.Label
    Friend WithEvents dg_commande_faite As System.Windows.Forms.DataGridView
    Friend WithEvents exdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Produit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unites As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pharmacie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Distances As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents pharm_combo_done_filter As System.Windows.Forms.ComboBox
    Friend WithEvents pharm_update_comd As System.Windows.Forms.Button
    Friend WithEvents recived As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_encourt As System.Windows.Forms.Label
    Friend WithEvents pharm_answer As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents re_Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents re_Produit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents re_Quantité As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents decline As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pharm_btn_refuse_all As System.Windows.Forms.Button
    Friend WithEvents pharm_btn_accept_all As System.Windows.Forms.Button
    Friend WithEvents pharm_update_answer As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_accepted As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pharm_accepted_filter As System.Windows.Forms.ComboBox
    Friend WithEvents pharm_update_last As System.Windows.Forms.Button
    Friend WithEvents dg_accepted_commande As System.Windows.Forms.DataGridView
    Friend WithEvents exdate2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Produit2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantité2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pharmacie2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents pharm_recu As System.Windows.Forms.TabControl
End Class
