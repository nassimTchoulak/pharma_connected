<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VenteValidation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Client2 = New System.Windows.Forms.ComboBox()
        Me.Ref = New System.Windows.Forms.Label()
        Me.Ref2 = New System.Windows.Forms.TextBox()
        Me.Client = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Client2)
        Me.GroupBox1.Controls.Add(Me.Ref)
        Me.GroupBox1.Controls.Add(Me.Ref2)
        Me.GroupBox1.Controls.Add(Me.Client)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 154)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(414, 52)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'Client2
        '
        Me.Client2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Client2.FormattingEnabled = True
        Me.Client2.Location = New System.Drawing.Point(219, 15)
        Me.Client2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Client2.Name = "Client2"
        Me.Client2.Size = New System.Drawing.Size(186, 29)
        Me.Client2.TabIndex = 6
        '
        'Ref
        '
        Me.Ref.AutoSize = True
        Me.Ref.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Ref.Location = New System.Drawing.Point(4, 21)
        Me.Ref.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Ref.Name = "Ref"
        Me.Ref.Size = New System.Drawing.Size(33, 20)
        Me.Ref.TabIndex = 3
        Me.Ref.Text = "Ref"
        '
        'Ref2
        '
        Me.Ref2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Ref2.Location = New System.Drawing.Point(41, 17)
        Me.Ref2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Ref2.Name = "Ref2"
        Me.Ref2.Size = New System.Drawing.Size(76, 27)
        Me.Ref2.TabIndex = 4
        Me.Ref2.Text = "Auto."
        '
        'Client
        '
        Me.Client.AutoSize = True
        Me.Client.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Client.Location = New System.Drawing.Point(164, 19)
        Me.Client.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(51, 20)
        Me.Client.TabIndex = 5
        Me.Client.Text = "Client"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 90)
        Me.Panel2.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(8, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 38)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Info Facture"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.CheckBox2.Location = New System.Drawing.Point(14, 126)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(202, 24)
        Me.CheckBox2.TabIndex = 71
        Me.CheckBox2.Text = "Info Facture Personalisé"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.CheckBox1.Location = New System.Drawing.Point(14, 104)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(200, 24)
        Me.CheckBox1.TabIndex = 70
        Me.CheckBox1.Text = "Info Facture par Defaut"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(268, 237)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 30)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Valider"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(11, 237)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Annuler"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'VenteValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 276)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VenteValidation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Client2 As System.Windows.Forms.ComboBox
    Friend WithEvents Ref As System.Windows.Forms.Label
    Friend WithEvents Ref2 As System.Windows.Forms.TextBox
    Friend WithEvents Client As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
