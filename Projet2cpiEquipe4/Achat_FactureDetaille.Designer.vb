<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Achat_FactureDetaille
    Inherits System.Windows.Forms.Form

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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateExpiration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixUnitaireAchat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixUnitaireVente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixTotaleHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixTotaleTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dat = New System.Windows.Forms.Label()
        Me.num = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.f = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(682, 583)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 14)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "L"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 583)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 14)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "l"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(513, 578)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 22)
        Me.TextBox2.TabIndex = 66
        Me.TextBox2.Text = "Montant Totale TTC :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(21, 578)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 22)
        Me.TextBox1.TabIndex = 65
        Me.TextBox1.Text = "Montant Totale HT :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Quantité, Me.DateExpiration, Me.PrixUnitaireAchat, Me.Marge, Me.PPA, Me.SHP, Me.PrixUnitaireVente, Me.PrixTotaleHT, Me.TVA, Me.PrixTotaleTTC, Me.Emplacement})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(18, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(774, 373)
        Me.DataGridView1.TabIndex = 64
        '
        'Nom
        '
        Me.Nom.FillWeight = 274.6159!
        Me.Nom.HeaderText = "Nom"
        Me.Nom.MaxInputLength = 3276
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        Me.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Quantité
        '
        Me.Quantité.FillWeight = 86.44704!
        Me.Quantité.HeaderText = "Quantité"
        Me.Quantité.Name = "Quantité"
        Me.Quantité.ReadOnly = True
        Me.Quantité.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DateExpiration
        '
        Me.DateExpiration.FillWeight = 86.44704!
        Me.DateExpiration.HeaderText = "Date d'expiration"
        Me.DateExpiration.Name = "DateExpiration"
        Me.DateExpiration.ReadOnly = True
        '
        'PrixUnitaireAchat
        '
        Me.PrixUnitaireAchat.FillWeight = 86.44704!
        Me.PrixUnitaireAchat.HeaderText = "Prix unitaire d'achat"
        Me.PrixUnitaireAchat.Name = "PrixUnitaireAchat"
        Me.PrixUnitaireAchat.ReadOnly = True
        '
        'Marge
        '
        Me.Marge.FillWeight = 86.44704!
        Me.Marge.HeaderText = "Marge"
        Me.Marge.Name = "Marge"
        Me.Marge.ReadOnly = True
        '
        'PPA
        '
        Me.PPA.FillWeight = 86.44704!
        Me.PPA.HeaderText = "PPA"
        Me.PPA.Name = "PPA"
        Me.PPA.ReadOnly = True
        '
        'SHP
        '
        Me.SHP.FillWeight = 86.44704!
        Me.SHP.HeaderText = "SHP"
        Me.SHP.Name = "SHP"
        Me.SHP.ReadOnly = True
        '
        'PrixUnitaireVente
        '
        Me.PrixUnitaireVente.FillWeight = 86.44704!
        Me.PrixUnitaireVente.HeaderText = "Prix unitaire de vente"
        Me.PrixUnitaireVente.Name = "PrixUnitaireVente"
        Me.PrixUnitaireVente.ReadOnly = True
        '
        'PrixTotaleHT
        '
        Me.PrixTotaleHT.FillWeight = 86.44704!
        Me.PrixTotaleHT.HeaderText = "Prix Totale HT"
        Me.PrixTotaleHT.Name = "PrixTotaleHT"
        Me.PrixTotaleHT.ReadOnly = True
        '
        'TVA
        '
        Me.TVA.FillWeight = 86.44704!
        Me.TVA.HeaderText = "TVA"
        Me.TVA.Name = "TVA"
        Me.TVA.ReadOnly = True
        '
        'PrixTotaleTTC
        '
        Me.PrixTotaleTTC.FillWeight = 86.44704!
        Me.PrixTotaleTTC.HeaderText = "Prix Totale TTC"
        Me.PrixTotaleTTC.Name = "PrixTotaleTTC"
        Me.PrixTotaleTTC.ReadOnly = True
        '
        'Emplacement
        '
        Me.Emplacement.FillWeight = 60.9137!
        Me.Emplacement.HeaderText = "Empla cemnt"
        Me.Emplacement.Name = "Emplacement"
        Me.Emplacement.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 644)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Pharmacie ESI EQUIPE 04"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 671)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Oued Smar Alger"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(4, 613)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(548, 18)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "---------------------------------------------------------------------------------" & _
    "---------"
        '
        'dat
        '
        Me.dat.AutoSize = True
        Me.dat.Location = New System.Drawing.Point(682, 141)
        Me.dat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dat.Name = "dat"
        Me.dat.Size = New System.Drawing.Size(65, 13)
        Me.dat.TabIndex = 58
        Me.dat.Text = "12/03/2018"
        '
        'num
        '
        Me.num.AutoSize = True
        Me.num.Location = New System.Drawing.Point(150, 109)
        Me.num.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(43, 13)
        Me.num.TabIndex = 57
        Me.num.Text = "002145"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 17)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Pharmacie ESI EQUIPE 04"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(16, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Facture N° :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(548, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "DATE :"
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Location = New System.Drawing.Point(116, 145)
        Me.f.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(10, 13)
        Me.f.TabIndex = 53
        Me.f.Text = "f"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(15, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Fournisseur :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 55)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Facture d'achat"
        '
        'Achat_FactureDetaille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(802, 721)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dat)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.f)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Achat_FactureDetaille"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facture Achat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dat As System.Windows.Forms.Label
    Friend WithEvents num As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents f As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantité As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateExpiration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixUnitaireAchat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SHP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixUnitaireVente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixTotaleHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixTotaleTTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Emplacement As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
