Public Class Precedent
    Public Shared d As DataSet = New DataSet()
    Public Shared x As Integer
    Public Shared Sub init()
        d.Tables.Add("prec")
        d.Tables("prec").Columns.Add("nom")
        d.Tables("prec").Columns.Add("tab")
        x = 0
    End Sub

    Public Shared Sub push(ByVal s As String, ByVal k As Integer)
        d.Tables("prec").Rows.Add(s, k)
        x = x + 1
    End Sub

    Public Shared Function pop(ByRef k As Integer) As String
        Dim v As String
        If x = 0 Then
            v = ""
        Else
            v = d.Tables("prec").Rows(x - 1).Item("nom").ToString
            k = Val(d.Tables("prec").Rows(x - 1).Item("tab").ToString)
            d.Tables("prec").Rows.Remove(d.Tables("prec").Rows(x - 1))
            x = x - 1
        End If
        Return v
    End Function

 
End Class
