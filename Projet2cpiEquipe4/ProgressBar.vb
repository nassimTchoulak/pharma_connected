Public Class ProgressBar

    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            Me.Close()
            ' Timer1.Enabled = False
            Stock.TabControl1.Visible = True
        Else

            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub

    Private Sub ProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class