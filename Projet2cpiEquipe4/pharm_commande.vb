Public Class pharm_commande
    Public pharmacie As pharm_con
    Public time As String
    Public produit As String
    Public etat As Integer ' 1 en attante '2 accepted & 0 refused 
    Public quant As Integer



    Public Sub New(ByVal p As String, ByVal q As Integer, ByVal pahr As pharm_con)
        time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        'MsgBox(time)
        produit = p
        quant = q
        etat = 1
        pharmacie = pahr

    End Sub

    Public Sub update_status_comande() ' add timmme
        'MsgBox(pharmacie.get_status())
        Dim date2 As Date
        Dim date3 As Date
        date2 = DateTime.Parse(time)
        date3 = DateTime.Parse(time)
        date2 = date2.AddSeconds(5)
        date3 = date3.AddSeconds(-5)
        'MsgBox(date2)
        'MsgBox(date3)


        Me.pharmacie.execute("select * from [Demandes produit] where ((Produit='" + Me.produit + "')and(exdate between '" + date3.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'   )and( Quantité=" + quant.ToString + ")and(traité>0) )")
        Dim se As DataSet = New DataSet()
        pharmacie.read(se, "[Demandes produit]")
        If (se.Tables("[Demandes produit]").Rows().Count > 0) Then
            If (se.Tables("[Demandes produit]").Rows(0).Item("traité") = 10) Then
                etat = 2
            Else
                etat = 1
            End If
        Else
            etat = 0
        End If
    End Sub
    Public Sub create_row_datagrid(ByVal dd As DataGridView)
        If etat = 2 Then
            dd.Rows.Add(time, produit, quant.ToString, pharmacie.nomf, pharmacie.Distance, pharmacie.adress, "accepté")
        ElseIf etat = 1 Then
            dd.Rows.Add(time, produit, quant.ToString, pharmacie.nomf, pharmacie.Distance, pharmacie.adress, "en court de traitement")
        Else
            dd.Rows.Add(time, produit, quant.ToString, pharmacie.nomf, pharmacie.Distance, pharmacie.adress, "refusé")

        End If

    End Sub

End Class
