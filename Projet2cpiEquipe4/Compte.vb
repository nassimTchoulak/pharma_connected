Imports System.Text

Public Class Compte
    Private b As DataBase = New DataBase()
    Private mydataset As DataSet
    Private mydatasetverif As DataSet
    Public Shared Nom As String
    Public Shared Prenom As String
    Public Shared NomUtilistateur As String
    Public Shared Password As String
    Public Shared Niveau As Integer
    Public Function getnom() As String
        Return Nom
    End Function
    Public Function getuser() As String
        Return NomUtilistateur
    End Function
    Public Function ReCompte(ByVal user As String) As String
        Dim password As String
        Dim newpassword As String
        Dim newnew As String
        b.execute("SELECT * FROM Compte WHERE Identifiant = '" + user + "'")
        mydataset = New DataSet()
        b.read(mydataset, "Compte")
        password = mydataset.Tables("Compte").Rows(0).Item("Password").ToString()
        newpassword = password.Substring(0, 8)
        newnew = GetHash(newpassword)
        b.execute("UPDATE Compte Set Password = '" + newnew + "' WHERE Identifiant = '" + user + "'")
        Return newpassword
    End Function
    Public Sub ModifierComptePassword(ByVal user As String, ByVal password As String)
        b.execute("UPDATE Compte Set Password = '" + password + "' WHERE Identifiant = '" + user + "'")
    End Sub
    Public Function getniveau() As String
        Return Niveau
    End Function

    Public Sub AjouterHistorique(ByVal user As String, ByVal ladate As String, ByVal heure As String)
        b.execute("SELECT * FROM Compte WHERE Identifiant = '" + user + "'")
        mydataset = New DataSet()
        b.read(mydataset, "Compte")
        Dim niveau As String
        Niveau = mydataset.Tables("Compte").Rows(0).Item("Niveau").ToString
        b.execute("INSERT INTO Acces VALUES ( '" + ladate + "','" + heure + "','" + user + "','" + niveau + "')")
    End Sub
    Public Function GetHash(strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As New StringBuilder

        For Each b As Byte In bytesToHash
            strResult.Append(b.ToString("x2"))
        Next

        Return strResult.ToString

    End Function

    Public Sub verifier(ByVal user As String, ByVal pass As String, ByRef juste As Boolean, ByRef TypeError As Integer)
        b.execute("SELECT * FROM Compte WHERE Identifiant = '" + user + "'")
        mydataset = New DataSet()
        b.read(mydataset, "Compte")
        For Each Ligne As DataRow In mydataset.Tables("Compte").Rows()
            TypeError = TypeError + 1
            If Ligne("Password").ToString = GetHash(pass) Then
                juste = True
            End If
        Next
        If juste Then
            Nom = mydataset.Tables("Compte").Rows(0).Item("Nom").ToString
            Prenom = mydataset.Tables("Compte").Rows(0).Item("Prenom").ToString
            NomUtilistateur = mydataset.Tables("Compte").Rows(0).Item("Identifiant").ToString
            Password = mydataset.Tables("Compte").Rows(0).Item("Password").ToString
            Niveau = CInt(mydataset.Tables("Compte").Rows(0).Item("Niveau").ToString)
        End If
    End Sub

    Public Sub AjouterCompte(ByVal user As String, ByVal password As String, ByVal nom As String, ByVal prenom As String, ByVal type As String)
        Dim i As Integer
        b.execute("SELECT * FROM Compte WHERE Identifiant = '" + user + "'")
        mydatasetverif = New DataSet()
        If type = "ADMIN" Then
            i = 2
        ElseIf type = "SIMPLE" Then
            i = 3
        Else
            i = 1
        End If
        b.execute("INSERT INTO Compte VALUES ( " + i.ToString + ",'" + user + "','" + password + "','" + nom + "','" + prenom + "')")
    End Sub

    Public Sub UsedUSer(ByVal user As String, ByRef used As Boolean)
        b.execute("SELECT * FROM Compte WHERE Identifiant = '" + user + "'")
        mydatasetverif = New DataSet()
        If b.read(mydatasetverif, "Compte") <> 0 Then
            used = True
        End If
        If user = "" Then
            used = True
        End If
    End Sub

    Public Sub Supprimer(ByVal user As String)
        b.execute("DELETE FROM Compte WHERE Identifiant = '" + user + "'")
    End Sub

    Public Sub firstConn(ByRef first As Boolean)
        b.execute("SELECT * FROM Compte")
        mydataset = New DataSet()
        If b.read(mydataset, "Compte") = 0 Then
            first = True
        Else
            first = False
        End If
    End Sub
End Class
