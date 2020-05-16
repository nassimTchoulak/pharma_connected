<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestMain
    Inherits Projet2cpiEquipe4.menu

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestMain))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TAB_PROD = New System.Windows.Forms.TabPage()
        Me.DG_REST_PROD = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_RECHERCHE = New System.Windows.Forms.Button()
        Me.TXT_PROD_QT = New System.Windows.Forms.TextBox()
        Me.TXT_PROD_ID = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BT_PROD_ACTUALISER = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BT_REST_VENTE = New System.Windows.Forms.Button()
        Me.BT_REST_AJOUT = New System.Windows.Forms.Button()
        Me.TXT_PROD_NOM = New System.Windows.Forms.TextBox()
        Me.TAB_JOURNAL = New System.Windows.Forms.TabPage()
        Me.DG_REST_JOURNAL = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BT_JOURN_SUPP = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_JOURNAL_QT = New System.Windows.Forms.TextBox()
        Me.TXT_JOURNAL_ID = New System.Windows.Forms.TextBox()
        Me.TXT_JOURNAL_NOM = New System.Windows.Forms.TextBox()
        Me.BT_JOURNAL_ACTUALISER = New System.Windows.Forms.Button()
        Me.BT_JOURNAL_RECHERCHE = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PNL_SIDE_MENU.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TAB_PROD.SuspendLayout()
        CType(Me.DG_REST_PROD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.TAB_JOURNAL.SuspendLayout()
        CType(Me.DG_REST_JOURNAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL_SIDE_MENU
        '
        Me.PNL_SIDE_MENU.Location = New System.Drawing.Point(0, 81)
        Me.PNL_SIDE_MENU.Size = New System.Drawing.Size(267, 828)
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
        Me.LBL_NOM_UTIL.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBL_NOM_UTIL.Size = New System.Drawing.Size(0, 19)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TAB_PROD)
        Me.TabControl1.Controls.Add(Me.TAB_JOURNAL)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(267, 81)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1418, 828)
        Me.TabControl1.TabIndex = 57
        '
        'TAB_PROD
        '
        Me.TAB_PROD.Controls.Add(Me.DG_REST_PROD)
        Me.TAB_PROD.Controls.Add(Me.Panel6)
        Me.TAB_PROD.Location = New System.Drawing.Point(4, 29)
        Me.TAB_PROD.Margin = New System.Windows.Forms.Padding(0)
        Me.TAB_PROD.Name = "TAB_PROD"
        Me.TAB_PROD.Size = New System.Drawing.Size(1410, 795)
        Me.TAB_PROD.TabIndex = 0
        Me.TAB_PROD.Text = "Produits Restitués"
        Me.TAB_PROD.UseVisualStyleBackColor = True
        '
        'DG_REST_PROD
        '
        Me.DG_REST_PROD.AllowUserToAddRows = False
        Me.DG_REST_PROD.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DG_REST_PROD.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_REST_PROD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_REST_PROD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_REST_PROD.BackgroundColor = System.Drawing.Color.White
        Me.DG_REST_PROD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_REST_PROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_REST_PROD.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_REST_PROD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_REST_PROD.GridColor = System.Drawing.SystemColors.Control
        Me.DG_REST_PROD.Location = New System.Drawing.Point(0, 148)
        Me.DG_REST_PROD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DG_REST_PROD.Name = "DG_REST_PROD"
        Me.DG_REST_PROD.ReadOnly = True
        Me.DG_REST_PROD.Size = New System.Drawing.Size(1410, 647)
        Me.DG_REST_PROD.TabIndex = 48
        Me.DG_REST_PROD.VirtualMode = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.BT_RECHERCHE)
        Me.Panel6.Controls.Add(Me.TXT_PROD_QT)
        Me.Panel6.Controls.Add(Me.TXT_PROD_ID)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.BT_PROD_ACTUALISER)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.BT_REST_VENTE)
        Me.Panel6.Controls.Add(Me.BT_REST_AJOUT)
        Me.Panel6.Controls.Add(Me.TXT_PROD_NOM)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1410, 148)
        Me.Panel6.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(23, 71)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 20)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Nom"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(201, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Quantité"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(44, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(779, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Opérations"
        '
        'BT_RECHERCHE
        '
        Me.BT_RECHERCHE.BackColor = System.Drawing.Color.Transparent
        Me.BT_RECHERCHE.FlatAppearance.BorderSize = 0
        Me.BT_RECHERCHE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_RECHERCHE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RECHERCHE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_RECHERCHE.Image = CType(resources.GetObject("BT_RECHERCHE.Image"), System.Drawing.Image)
        Me.BT_RECHERCHE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_RECHERCHE.Location = New System.Drawing.Point(481, 15)
        Me.BT_RECHERCHE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_RECHERCHE.Name = "BT_RECHERCHE"
        Me.BT_RECHERCHE.Size = New System.Drawing.Size(120, 98)
        Me.BT_RECHERCHE.TabIndex = 44
        Me.BT_RECHERCHE.Text = "Rechercher"
        Me.BT_RECHERCHE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_RECHERCHE.UseVisualStyleBackColor = False
        '
        'TXT_PROD_QT
        '
        Me.TXT_PROD_QT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PROD_QT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_PROD_QT.Location = New System.Drawing.Point(281, 28)
        Me.TXT_PROD_QT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_PROD_QT.Name = "TXT_PROD_QT"
        Me.TXT_PROD_QT.Size = New System.Drawing.Size(112, 28)
        Me.TXT_PROD_QT.TabIndex = 42
        Me.TXT_PROD_QT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_PROD_ID
        '
        Me.TXT_PROD_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PROD_ID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_PROD_ID.Location = New System.Drawing.Point(80, 28)
        Me.TXT_PROD_ID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_PROD_ID.Name = "TXT_PROD_ID"
        Me.TXT_PROD_ID.Size = New System.Drawing.Size(97, 28)
        Me.TXT_PROD_ID.TabIndex = 41
        Me.TXT_PROD_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel7.Location = New System.Drawing.Point(1003, 15)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 123)
        Me.Panel7.TabIndex = 40
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel8.Location = New System.Drawing.Point(609, 14)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 123)
        Me.Panel8.TabIndex = 39
        '
        'BT_PROD_ACTUALISER
        '
        Me.BT_PROD_ACTUALISER.BackColor = System.Drawing.Color.Transparent
        Me.BT_PROD_ACTUALISER.FlatAppearance.BorderSize = 0
        Me.BT_PROD_ACTUALISER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PROD_ACTUALISER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PROD_ACTUALISER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_PROD_ACTUALISER.Image = CType(resources.GetObject("BT_PROD_ACTUALISER.Image"), System.Drawing.Image)
        Me.BT_PROD_ACTUALISER.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_PROD_ACTUALISER.Location = New System.Drawing.Point(875, 16)
        Me.BT_PROD_ACTUALISER.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_PROD_ACTUALISER.Name = "BT_PROD_ACTUALISER"
        Me.BT_PROD_ACTUALISER.Size = New System.Drawing.Size(120, 98)
        Me.BT_PROD_ACTUALISER.TabIndex = 47
        Me.BT_PROD_ACTUALISER.Text = "Actualiser"
        Me.BT_PROD_ACTUALISER.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_PROD_ACTUALISER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_PROD_ACTUALISER.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(251, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Recherche"
        '
        'BT_REST_VENTE
        '
        Me.BT_REST_VENTE.BackColor = System.Drawing.Color.Transparent
        Me.BT_REST_VENTE.FlatAppearance.BorderSize = 0
        Me.BT_REST_VENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_REST_VENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_REST_VENTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_REST_VENTE.Image = CType(resources.GetObject("BT_REST_VENTE.Image"), System.Drawing.Image)
        Me.BT_REST_VENTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_REST_VENTE.Location = New System.Drawing.Point(747, 16)
        Me.BT_REST_VENTE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_REST_VENTE.Name = "BT_REST_VENTE"
        Me.BT_REST_VENTE.Size = New System.Drawing.Size(120, 98)
        Me.BT_REST_VENTE.TabIndex = 46
        Me.BT_REST_VENTE.Text = "Vendre"
        Me.BT_REST_VENTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_REST_VENTE.UseVisualStyleBackColor = False
        '
        'BT_REST_AJOUT
        '
        Me.BT_REST_AJOUT.BackColor = System.Drawing.Color.Transparent
        Me.BT_REST_AJOUT.FlatAppearance.BorderSize = 0
        Me.BT_REST_AJOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_REST_AJOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_REST_AJOUT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_REST_AJOUT.Image = Global.Projet2cpiEquipe4.My.Resources.Resources.plus_circle_outline__1_
        Me.BT_REST_AJOUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_REST_AJOUT.Location = New System.Drawing.Point(619, 16)
        Me.BT_REST_AJOUT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_REST_AJOUT.Name = "BT_REST_AJOUT"
        Me.BT_REST_AJOUT.Size = New System.Drawing.Size(120, 98)
        Me.BT_REST_AJOUT.TabIndex = 45
        Me.BT_REST_AJOUT.Text = "Ajouter"
        Me.BT_REST_AJOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_REST_AJOUT.UseVisualStyleBackColor = False
        '
        'TXT_PROD_NOM
        '
        Me.TXT_PROD_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PROD_NOM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_PROD_NOM.Location = New System.Drawing.Point(80, 65)
        Me.TXT_PROD_NOM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_PROD_NOM.Name = "TXT_PROD_NOM"
        Me.TXT_PROD_NOM.Size = New System.Drawing.Size(392, 28)
        Me.TXT_PROD_NOM.TabIndex = 43
        '
        'TAB_JOURNAL
        '
        Me.TAB_JOURNAL.Controls.Add(Me.DG_REST_JOURNAL)
        Me.TAB_JOURNAL.Controls.Add(Me.Panel9)
        Me.TAB_JOURNAL.Location = New System.Drawing.Point(4, 29)
        Me.TAB_JOURNAL.Margin = New System.Windows.Forms.Padding(0)
        Me.TAB_JOURNAL.Name = "TAB_JOURNAL"
        Me.TAB_JOURNAL.Size = New System.Drawing.Size(1411, 792)
        Me.TAB_JOURNAL.TabIndex = 1
        Me.TAB_JOURNAL.Text = "J.Ventes"
        Me.TAB_JOURNAL.UseVisualStyleBackColor = True
        '
        'DG_REST_JOURNAL
        '
        Me.DG_REST_JOURNAL.AllowUserToAddRows = False
        Me.DG_REST_JOURNAL.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        Me.DG_REST_JOURNAL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_REST_JOURNAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_REST_JOURNAL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_REST_JOURNAL.BackgroundColor = System.Drawing.Color.White
        Me.DG_REST_JOURNAL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_REST_JOURNAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_REST_JOURNAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.DG_REST_JOURNAL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_REST_JOURNAL.GridColor = System.Drawing.SystemColors.Control
        Me.DG_REST_JOURNAL.Location = New System.Drawing.Point(0, 148)
        Me.DG_REST_JOURNAL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DG_REST_JOURNAL.MultiSelect = False
        Me.DG_REST_JOURNAL.Name = "DG_REST_JOURNAL"
        Me.DG_REST_JOURNAL.ReadOnly = True
        Me.DG_REST_JOURNAL.Size = New System.Drawing.Size(1411, 644)
        Me.DG_REST_JOURNAL.TabIndex = 56
        Me.DG_REST_JOURNAL.VirtualMode = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.BT_JOURN_SUPP)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.Label12)
        Me.Panel9.Controls.Add(Me.TXT_JOURNAL_QT)
        Me.Panel9.Controls.Add(Me.TXT_JOURNAL_ID)
        Me.Panel9.Controls.Add(Me.TXT_JOURNAL_NOM)
        Me.Panel9.Controls.Add(Me.BT_JOURNAL_ACTUALISER)
        Me.Panel9.Controls.Add(Me.BT_JOURNAL_RECHERCHE)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1411, 148)
        Me.Panel9.TabIndex = 1
        '
        'BT_JOURN_SUPP
        '
        Me.BT_JOURN_SUPP.Enabled = False
        Me.BT_JOURN_SUPP.FlatAppearance.BorderSize = 0
        Me.BT_JOURN_SUPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_JOURN_SUPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_JOURN_SUPP.Image = Global.Projet2cpiEquipe4.My.Resources.Resources.close_circle_outline
        Me.BT_JOURN_SUPP.Location = New System.Drawing.Point(747, 12)
        Me.BT_JOURN_SUPP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_JOURN_SUPP.Name = "BT_JOURN_SUPP"
        Me.BT_JOURN_SUPP.Size = New System.Drawing.Size(120, 98)
        Me.BT_JOURN_SUPP.TabIndex = 57
        Me.BT_JOURN_SUPP.Text = "Supprimer"
        Me.BT_JOURN_SUPP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_JOURN_SUPP.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel10.Location = New System.Drawing.Point(609, 14)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 123)
        Me.Panel10.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(23, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 20)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Nom"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(201, 34)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Quantité"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(44, 34)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 20)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "ID"
        '
        'TXT_JOURNAL_QT
        '
        Me.TXT_JOURNAL_QT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_JOURNAL_QT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_JOURNAL_QT.Location = New System.Drawing.Point(281, 28)
        Me.TXT_JOURNAL_QT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_JOURNAL_QT.Name = "TXT_JOURNAL_QT"
        Me.TXT_JOURNAL_QT.Size = New System.Drawing.Size(112, 28)
        Me.TXT_JOURNAL_QT.TabIndex = 52
        Me.TXT_JOURNAL_QT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_JOURNAL_ID
        '
        Me.TXT_JOURNAL_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_JOURNAL_ID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_JOURNAL_ID.Location = New System.Drawing.Point(80, 28)
        Me.TXT_JOURNAL_ID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_JOURNAL_ID.Name = "TXT_JOURNAL_ID"
        Me.TXT_JOURNAL_ID.Size = New System.Drawing.Size(97, 28)
        Me.TXT_JOURNAL_ID.TabIndex = 51
        Me.TXT_JOURNAL_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_JOURNAL_NOM
        '
        Me.TXT_JOURNAL_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_JOURNAL_NOM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_JOURNAL_NOM.Location = New System.Drawing.Point(80, 65)
        Me.TXT_JOURNAL_NOM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_JOURNAL_NOM.Name = "TXT_JOURNAL_NOM"
        Me.TXT_JOURNAL_NOM.Size = New System.Drawing.Size(392, 28)
        Me.TXT_JOURNAL_NOM.TabIndex = 53
        '
        'BT_JOURNAL_ACTUALISER
        '
        Me.BT_JOURNAL_ACTUALISER.BackColor = System.Drawing.Color.Transparent
        Me.BT_JOURNAL_ACTUALISER.FlatAppearance.BorderSize = 0
        Me.BT_JOURNAL_ACTUALISER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_JOURNAL_ACTUALISER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_JOURNAL_ACTUALISER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_JOURNAL_ACTUALISER.Image = CType(resources.GetObject("BT_JOURNAL_ACTUALISER.Image"), System.Drawing.Image)
        Me.BT_JOURNAL_ACTUALISER.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_JOURNAL_ACTUALISER.Location = New System.Drawing.Point(619, 12)
        Me.BT_JOURNAL_ACTUALISER.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_JOURNAL_ACTUALISER.Name = "BT_JOURNAL_ACTUALISER"
        Me.BT_JOURNAL_ACTUALISER.Size = New System.Drawing.Size(120, 98)
        Me.BT_JOURNAL_ACTUALISER.TabIndex = 55
        Me.BT_JOURNAL_ACTUALISER.Text = "Actualiser"
        Me.BT_JOURNAL_ACTUALISER.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_JOURNAL_ACTUALISER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_JOURNAL_ACTUALISER.UseVisualStyleBackColor = False
        '
        'BT_JOURNAL_RECHERCHE
        '
        Me.BT_JOURNAL_RECHERCHE.BackColor = System.Drawing.Color.Transparent
        Me.BT_JOURNAL_RECHERCHE.FlatAppearance.BorderSize = 0
        Me.BT_JOURNAL_RECHERCHE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_JOURNAL_RECHERCHE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_JOURNAL_RECHERCHE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_JOURNAL_RECHERCHE.Image = CType(resources.GetObject("BT_JOURNAL_RECHERCHE.Image"), System.Drawing.Image)
        Me.BT_JOURNAL_RECHERCHE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_JOURNAL_RECHERCHE.Location = New System.Drawing.Point(481, 12)
        Me.BT_JOURNAL_RECHERCHE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_JOURNAL_RECHERCHE.Name = "BT_JOURNAL_RECHERCHE"
        Me.BT_JOURNAL_RECHERCHE.Size = New System.Drawing.Size(120, 98)
        Me.BT_JOURNAL_RECHERCHE.TabIndex = 54
        Me.BT_JOURNAL_RECHERCHE.Text = "Rechercher"
        Me.BT_JOURNAL_RECHERCHE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_JOURNAL_RECHERCHE.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(251, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Recherche"
        '
        'RestMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 937)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "RestMain"
        Me.Text = "MEDELA - Produits restitués"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.PNL_SIDE_MENU, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.PNL_SIDE_MENU.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TAB_PROD.ResumeLayout(False)
        CType(Me.DG_REST_PROD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TAB_JOURNAL.ResumeLayout(False)
        CType(Me.DG_REST_JOURNAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TAB_PROD As System.Windows.Forms.TabPage
    Friend WithEvents DG_REST_PROD As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BT_RECHERCHE As System.Windows.Forms.Button
    Friend WithEvents TXT_PROD_QT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PROD_ID As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents BT_PROD_ACTUALISER As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BT_REST_VENTE As System.Windows.Forms.Button
    Friend WithEvents BT_REST_AJOUT As System.Windows.Forms.Button
    Friend WithEvents TXT_PROD_NOM As System.Windows.Forms.TextBox
    Friend WithEvents TAB_JOURNAL As System.Windows.Forms.TabPage
    Friend WithEvents DG_REST_JOURNAL As System.Windows.Forms.DataGridView
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXT_JOURNAL_QT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_JOURNAL_ID As System.Windows.Forms.TextBox
    Friend WithEvents TXT_JOURNAL_NOM As System.Windows.Forms.TextBox
    Friend WithEvents BT_JOURNAL_ACTUALISER As System.Windows.Forms.Button
    Friend WithEvents BT_JOURNAL_RECHERCHE As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BT_JOURN_SUPP As System.Windows.Forms.Button
End Class
