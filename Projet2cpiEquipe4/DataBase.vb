Imports System.Data.SqlClient
Imports System.IO

Public Class DataBase


    Private Shared myConn As SqlConnection
    Private myComand As SqlCommand
    Private myReader As SqlDataReader
    Private myAdapter As SqlDataAdapter
    Private myDataset As DataSet
    Private Shared mychaine As String

    Public Shared Sub connect(ByVal s As String)
        mychaine = s
        myConn = New SqlConnection(s)
        'Try
        myConn.Open()
        'Catch ex As Exception
        'MsgBox("Erreur ! La connection avec la base de données a échoué !", 0, "Erreur de connection !")
        'End Try
    End Sub

    Public Shared Sub save()
        Dim file As StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "\Code.txt", False)
        file.WriteLine(mychaine)
        file.WriteLine("Pharmacie Oued Smar")
        file.Close()
        'Dim wr As New StreamWriter(Application.StartupPath + "\Code.txt")
        ' wr.WriteLine(mychaine)
    End Sub

    Public Shared Sub close()
        myConn.Close()
    End Sub

    Public Sub execute(ByVal s As String)
        myComand = New SqlCommand(s, myConn)
        ' Try
        myComand.ExecuteNonQuery()
        'Catch ex As Exception
        'MsgBox("Erreur avec l'éxécution de la requéte suivante : " + s + ".", 0, "Erreur !")
        'End Try
    End Sub
    'Public Sub execute(ByVal s As String)
    '   myComand = New SqlCommand(s, myConn)
    '
    '   myComand.ExecuteNonQuery()

    '    End Sub

    Public Function read(ByRef dataSet As DataSet, ByVal table As String) As Integer
        Dim i As Integer
        myAdapter = New SqlDataAdapter(myComand)
        dataSet = New DataSet()
        Try
            i = myAdapter.Fill(dataSet, table)
        Catch ex As Exception
            MsgBox("Erreur avec la lecture de la table : " + table + ".", 0, "Erreur !")
        End Try
        Return i
    End Function

End Class
