
Imports System.Data.SqlClient
Public Class pharm_con
    Private myConn As SqlConnection
    Private myComand As SqlCommand
    Private myReader As SqlDataReader
    Private myAdapter As SqlDataAdapter
    Private myDataset As DataSet
    Private ip As String
    Private pass As String
    Private id As String
    Private status As Boolean
    ' var d'affichage
    Public num As Integer
    Public Distance As Integer
    Public adress As String
    Public nomf As String

    Public Sub New(ByVal idd As String, ByVal ipp As String, ByVal pss As String)

        ip = ipp
        id = idd
        pass = pss
    End Sub
    Public Sub set_info(ByVal i As Integer, ByVal b As Integer, ByVal c As String, ByVal d As String)
        num = i
        Distance = b
        adress = c
        nomf = d
    End Sub
    Public Sub connect()
        Dim s As String
        s = "Data Source=" + ip + ";Integrated Security=False;Initial Catalog=az;User ID=" + id + ";Password=" + pass + ";Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"

        myConn = New SqlConnection(s)
        status = False
        Try
            myConn.Open()
            status = True
        Catch ex As Exception

            status = False
        End Try
    End Sub

    Public Function get_status() As Boolean
        Return status
    End Function
    Public Sub close()
        myConn.Close()
    End Sub

    Public Sub execute(ByVal s As String)


        myComand = New SqlCommand(s, myConn)
        Try
            myComand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur avec l'éxécution de la requéte suivante : " + s + ".", 0, "Erreur !")
        End Try
    End Sub

    Public Sub read(ByRef dataSet As DataSet, ByVal table As String)
        myAdapter = New SqlDataAdapter(myComand)
        dataSet = New DataSet()
        Try
            myAdapter.Fill(dataSet, table)
        Catch ex As Exception
            MsgBox("Erreur avec la lecture de la table : " + table + ".", 0, "Erreur !")
        End Try

    End Sub

End Class
