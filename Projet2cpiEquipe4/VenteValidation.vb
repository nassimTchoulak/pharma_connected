Public Class VenteValidation
    Public nbr As Integer
    Private d As DataSet = New DataSet()
    Private b As DataBase = New DataBase()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Vente.majStock()
        nbr = Vente.insert()
        VenteFin.ShowDialog()
        Me.Close()
    End Sub

    Private Sub VenteValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        b.execute("select * from client")
        b.read(d, "tr")
        Client2.DataSource = d.Tables("tr")
        Client2.DisplayMember = "Nom"
        If CheckBox1.Checked = True Then
            Ref.Enabled = False
            Ref2.Enabled = False
            Client.Enabled = False
            Client2.Enabled = False
            Ref2.Text = "Auto."
            Client2.Text = "Client au comptoir"
        Else
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            Ref.Enabled = True
            Ref2.Enabled = True
            Client.Enabled = True
            Client2.Enabled = True
            Ref2.Text = ""
            Client2.Text = ""
        Else
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            Ref.Enabled = False
            Ref2.Enabled = False
            Client.Enabled = False
            Client2.Enabled = False
        Else
        End If

    End Sub

End Class