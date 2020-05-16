Imports System.Data.SqlClient
Imports System.Threading
Public Class BaseNotFound
    Private myConn As SqlConnection
    Private myComand As SqlCommand
    Private myAdapter As SqlDataAdapter
    Public myDataset As DataSet
    Public BaseChaine As String
    Public o As Integer
    Public server As String
    Public type As Boolean
    Public id As String
    Public pass As String



    Private Sub BaseNotFound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1.Text = Environment.MachineName() + "\SQLEXPRESS"
        c1.Items.Add(Environment.MachineName() + "\SQLEXPRESS")
    

    End Sub
    Private Sub search(sender As Object, e As EventArgs) Handles Button1.Click
        server = c1.Text
        id = ComboBox1.Text
        pass = ComboBox2.Text
        Label2.Visible = True
        Dim chaine As String
        If ComboBox1.Text = "" And ComboBox2.Text = "" Then
            type = False
            chaine = "Data Source=" + c1.Text + ";Integrated Security=True;Encrypt=False;TrustServerCertificate=False"
        Else
            type = True
            chaine = "Data Source=" + c1.Text + ";User Id=" + ComboBox1.Text + ";Password=" + ComboBox2.Text + ";Integrated Security=True;Encrypt=False;TrustServerCertificate=False"
        End If
        myConn = New SqlConnection(chaine)
        Try
            myConn.Open()

            myComand = New SqlCommand("SELECT name, database_id, create_date  FROM sys.databases", myConn)
            Try
                myComand.ExecuteNonQuery()

                myAdapter = New SqlDataAdapter(myComand)
                myDataset = New DataSet()
                Try
                    o = myAdapter.Fill(myDataset, "table")
                    myConn.Close()

                    BaseSelect.ShowDialog()
                Catch ex As Exception
                    MsgBox("Connexion au serveur impossible ! Verifiez vos informations !", vbOK + vbInformation, "Serveur Introuvable !")
                End Try

            Catch ex As Exception
                MsgBox("Connexion au serveur impossible ! Verifiez vos informations !", vbOK + vbInformation, "Serveur Introuvable !")
            End Try

        Catch ex As Exception
            MsgBox("Connexion au serveur impossible ! Verifiez vos informations !", vbOK + vbInformation, "Serveur Introuvable !")
        End Try
    End Sub
    Private Sub c1_TextChanged(sender As Object, e As EventArgs) Handles c1.TextChanged
        
        If c1.Text = "" Then
            ErrorProvider1.SetError(c1, "Champs Obligatoire !")
        Else
            ErrorProvider1.Clear()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Souhaitez-vous vraiment annuler l'opération ? Cela va forcer l'arrêt du programme ?", vbYesNo + vbInformation, "Quitter?") = vbYes Then
            End
        End If
    End Sub
End Class