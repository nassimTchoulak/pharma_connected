<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stats))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus Vendus")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus chéres")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Statistiques de ventes", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus achetés")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus Commandés")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Statistiques d'achat", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus restitué")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus restituable")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Statistiques de restitutions", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus disponible")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus périmés")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produits Plus Remboursable")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Statistiques de stocks", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Degrés d'échange")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Statistiques de pharmacies", New System.Windows.Forms.TreeNode() {TreeNode14})
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BT_ACC_STATISTIQUE = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PNL_SIDE_MENU.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_SIDE_MENU
        '
        Me.PNL_SIDE_MENU.Location = New System.Drawing.Point(0, 81)
        Me.PNL_SIDE_MENU.Size = New System.Drawing.Size(267, 946)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BT_ACC_STATISTIQUE)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(267, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1657, 172)
        Me.Panel2.TabIndex = 57
        '
        'BT_ACC_STATISTIQUE
        '
        Me.BT_ACC_STATISTIQUE.FlatAppearance.BorderSize = 0
        Me.BT_ACC_STATISTIQUE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ACC_STATISTIQUE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ACC_STATISTIQUE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_ACC_STATISTIQUE.Image = CType(resources.GetObject("BT_ACC_STATISTIQUE.Image"), System.Drawing.Image)
        Me.BT_ACC_STATISTIQUE.Location = New System.Drawing.Point(653, 4)
        Me.BT_ACC_STATISTIQUE.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ACC_STATISTIQUE.Name = "BT_ACC_STATISTIQUE"
        Me.BT_ACC_STATISTIQUE.Size = New System.Drawing.Size(253, 158)
        Me.BT_ACC_STATISTIQUE.TabIndex = 69
        Me.BT_ACC_STATISTIQUE.Text = "Statistiques"
        Me.BT_ACC_STATISTIQUE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_ACC_STATISTIQUE.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TreeView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(267, 253)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(320, 774)
        Me.Panel4.TabIndex = 60
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.SystemColors.Control
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nœud1"
        TreeNode1.Text = "Produits Plus Vendus"
        TreeNode2.Name = "Nœud2"
        TreeNode2.Text = "Produits Plus chéres"
        TreeNode3.Name = "Nœud0"
        TreeNode3.Text = "Statistiques de ventes"
        TreeNode4.Name = "Nœud4"
        TreeNode4.Text = "Produits Plus achetés"
        TreeNode5.Name = "Nœud5"
        TreeNode5.Text = "Produits Plus Commandés"
        TreeNode6.Name = "Nœud3"
        TreeNode6.Text = "Statistiques d'achat"
        TreeNode7.Name = "Nœud7"
        TreeNode7.Text = "Produits Plus restitué"
        TreeNode8.Name = "Nœud8"
        TreeNode8.Text = "Produits Plus restituable"
        TreeNode9.Name = "Nœud6"
        TreeNode9.Text = "Statistiques de restitutions"
        TreeNode10.Name = "Nœud10"
        TreeNode10.Text = "Produits Plus disponible"
        TreeNode11.Name = "Nœud11"
        TreeNode11.Text = "Produits Plus périmés"
        TreeNode12.Name = "Nœud1"
        TreeNode12.Text = "Produits Plus Remboursable"
        TreeNode13.Name = "Nœud9"
        TreeNode13.Text = "Statistiques de stocks"
        TreeNode14.Name = "Nœud1"
        TreeNode14.Text = "Degrés d'échange"
        TreeNode15.Name = "Nœud0"
        TreeNode15.Text = "Statistiques de pharmacies"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9, TreeNode13, TreeNode15})
        Me.TreeView1.Size = New System.Drawing.Size(318, 772)
        Me.TreeView1.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(587, 253)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1337, 774)
        Me.Panel3.TabIndex = 61
        '
        'Chart1
        '
        ChartArea1.AxisY.LogarithmBase = 5.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.BorderColor = System.Drawing.Color.Teal
        Series1.ChartArea = "ChartArea1"
        Series1.LabelBorderColor = System.Drawing.Color.Teal
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Name = "prix"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1335, 772)
        Me.Chart1.TabIndex = 57
        Me.Chart1.Text = "Chart1"
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Stats"
        Me.Text = "Stats"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.PNL_SIDE_MENU, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.PNL_SIDE_MENU.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BT_ACC_STATISTIQUE As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
