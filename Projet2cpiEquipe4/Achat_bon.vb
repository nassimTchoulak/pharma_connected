Imports System.Drawing.Printing

Public Class Achat_bon
    Public d5 As DataSet = New DataSet()

    Private Sub Achat_bon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc As New PrintDocument
        Dim page As New PageSetupDialog
        Dim printer As New PrintDialog
        page.Document = doc
        printer.Document = doc
        Dim d As DialogResult = page.ShowDialog()
        If d = vbOK Then
            printer.ShowDialog()
        End If

    End Sub
End Class