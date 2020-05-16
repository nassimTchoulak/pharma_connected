Public Class VenteFin
    Dim s As VenteFacture = New VenteFacture()


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Accueil.Show()
        Vente.Dispose()
        Vente.Show()
        Accueil.Hide()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
  
        s.Show()

 
    End Sub

    Private Sub VenteFin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = Vente.Facturation(VenteValidation.nbr)
        Vente.totale += CInt(s.total.Text)
    End Sub
End Class