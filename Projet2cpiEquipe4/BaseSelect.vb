Imports System.IO

Public Class BaseSelect
    Private b As New DataBase()
    Private d As New DataSet()
    Private o As Integer
    Dim ch As String
    Private Sub Button2_Click(sender As Object, e As EventArgs)

        If MsgBox("Souhaitez-vous vraiment annuler l'opération ? Cela va forcer l'arrêt du programme ?", vbYesNo + vbInformation, "Quitter?") = vbYes Then
            End
        End If
    End Sub

    Private Sub BaseSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BaseNotFound.o = 0 Then
            ListBox1.Items.Add("Aucune base dans ce serveur !")
        Else
            ListBox1.DataSource = BaseNotFound.myDataset.Tables("table")
            BaseNotFound.Show()
            ListBox1.DisplayMember = "name"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If BaseNotFound.type = False Then

            ch = "Data Source=" + BaseNotFound.server + ";Initial Catalog=" + ListBox1.Text + ";Integrated Security=True;Encrypt=False;TrustServerCertificate=False"
        Else
            ch = "Data Source=" + BaseNotFound.server + ";Initial Catalog=" + ListBox1.Text + ";User Id=" + BaseNotFound.id + ";Password=" + BaseNotFound.pass + ";Integrated Security=True;Encrypt=False;TrustServerCertificate=False"
        End If
        Try



            DataBase.connect(ch)

            b.execute("select * from sysobjects where name = 'aghd459lpms54512'")
            o = b.read(d, "tt")
            If o <> 0 Then
                DataBase.save()
                Launch.b = True
                BaseNotFound.Close()
                Me.Close()
            Else
                MsgBox("La base sélectionnée est corrompu ! Veuillez choisir une autre base ou consultez le manuel d'installation ! ", vbOK + vbInformation, "Probléme !")
            End If
      

        Catch ex2 As Exception
            MsgBox("Impossible d'établir la connexion à cette base ! Verifiez les informations saisies ! ", vbOK + vbInformation, "Probléme !")
        End Try




    End Sub


    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class