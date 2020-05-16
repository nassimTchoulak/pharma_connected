<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestAjout
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BT_VALIDER = New System.Windows.Forms.Button()
        Me.EP_NOM = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EP_QT = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CMB_Nom = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTP_EXP = New System.Windows.Forms.DateTimePicker()
        Me.DTP_OUV = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_QT = New System.Windows.Forms.TextBox()
        Me.EP_DTOUV = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EP_DTEXP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.EP_NOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP_QT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EP_DTOUV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP_DTEXP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 107)
        Me.Panel1.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(16, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(439, 40)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ajouter un produit restitué"
        '
        'BT_VALIDER
        '
        Me.BT_VALIDER.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_VALIDER.BackColor = System.Drawing.Color.Teal
        Me.BT_VALIDER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_VALIDER.Enabled = False
        Me.BT_VALIDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_VALIDER.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_VALIDER.ForeColor = System.Drawing.Color.Snow
        Me.BT_VALIDER.Location = New System.Drawing.Point(363, 426)
        Me.BT_VALIDER.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_VALIDER.Name = "BT_VALIDER"
        Me.BT_VALIDER.Size = New System.Drawing.Size(200, 43)
        Me.BT_VALIDER.TabIndex = 83
        Me.BT_VALIDER.Text = "Valider"
        Me.BT_VALIDER.UseVisualStyleBackColor = False
        '
        'EP_NOM
        '
        Me.EP_NOM.ContainerControl = Me
        '
        'EP_QT
        '
        Me.EP_QT.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CMB_Nom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTP_EXP)
        Me.GroupBox1.Controls.Add(Me.DTP_OUV)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXT_QT)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 139)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(547, 262)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations"
        '
        'CMB_Nom
        '
        Me.CMB_Nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMB_Nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMB_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CMB_Nom.FormattingEnabled = True
        Me.CMB_Nom.Location = New System.Drawing.Point(96, 42)
        Me.CMB_Nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CMB_Nom.Name = "CMB_Nom"
        Me.CMB_Nom.Size = New System.Drawing.Size(421, 33)
        Me.CMB_Nom.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 22)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Date d'expiration"
        '
        'DTP_EXP
        '
        Me.DTP_EXP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_EXP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_EXP.Location = New System.Drawing.Point(225, 203)
        Me.DTP_EXP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTP_EXP.Name = "DTP_EXP"
        Me.DTP_EXP.ShowCheckBox = True
        Me.DTP_EXP.Size = New System.Drawing.Size(171, 26)
        Me.DTP_EXP.TabIndex = 46
        '
        'DTP_OUV
        '
        Me.DTP_OUV.Checked = False
        Me.DTP_OUV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_OUV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_OUV.Location = New System.Drawing.Point(225, 149)
        Me.DTP_OUV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTP_OUV.Name = "DTP_OUV"
        Me.DTP_OUV.ShowCheckBox = True
        Me.DTP_OUV.Size = New System.Drawing.Size(171, 26)
        Me.DTP_OUV.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date d'ouverture"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(111, 100)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Quantité"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(31, 46)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 22)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Nom"
        '
        'TXT_QT
        '
        Me.TXT_QT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_QT.Location = New System.Drawing.Point(225, 96)
        Me.TXT_QT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_QT.Name = "TXT_QT"
        Me.TXT_QT.Size = New System.Drawing.Size(101, 30)
        Me.TXT_QT.TabIndex = 2
        Me.TXT_QT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EP_DTOUV
        '
        Me.EP_DTOUV.ContainerControl = Me
        '
        'EP_DTEXP
        '
        Me.EP_DTEXP.ContainerControl = Me
        '
        'RestAjout
        '
        Me.AcceptButton = Me.BT_VALIDER
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 480)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BT_VALIDER)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RestAjout"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EP_NOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP_QT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EP_DTOUV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP_DTEXP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BT_VALIDER As System.Windows.Forms.Button
    Friend WithEvents EP_NOM As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTP_EXP As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_OUV As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_QT As System.Windows.Forms.TextBox
    Friend WithEvents EP_QT As System.Windows.Forms.ErrorProvider
    Friend WithEvents CMB_Nom As System.Windows.Forms.ComboBox
    Friend WithEvents EP_DTOUV As System.Windows.Forms.ErrorProvider
    Friend WithEvents EP_DTEXP As System.Windows.Forms.ErrorProvider
End Class
