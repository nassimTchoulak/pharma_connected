Imports System.Collections.ArrayList
Imports System.Threading
Imports System.IO

Public Class pharm_connected
    Inherits menu  ' me + menu + pharm con + appearence of menu + list box produit 

    Public phar As List(Of pharm_con) = New List(Of pharm_con)()
    Dim bas As DataBase = New DataBase()
    Dim d1 As DataSet = New DataSet()
    Dim se As DataSet = New DataSet()
    Dim sef As DataSet = New DataSet()
    Private int_list As List(Of Integer) = New List(Of Integer)()
    Private go As Boolean = False
    Private go2 As Boolean = False
    Private list_connected As List(Of pharm_con) = New List(Of pharm_con)()
    '
    'liste de comandes
    Private commande As List(Of pharm_commande) = New List(Of pharm_commande)()
    '
    'my pharm name
    Dim asm As String = La.Text


    Private Sub pharm_connected_FormClosing(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Me.Dispose()
    End Sub
    '



    Private Sub debut(sender As Object, e As EventArgs) Handles MyBase.Load


        pharm_list.Visible = False

        If phar.Count = 0 Then
            bas.execute("update Pharmacie set connecte=0")

        End If
        asm = La.Text

        'labels
        lbl_accepted.Visible = False
        lbl_do.Visible = False
        lbl_encourt.Visible = False
        lbl_pharma.Visible = False
        lbl_produict.Visible = False
        lbl_state.Visible = True
        '
        'init datagrids sizez
        Dim col As DataGridViewColumn
        ' accepted data
        col = dg_accepted_commande.Columns.Item(0)

        col.Width = 200
        col = dg_accepted_commande.Columns.Item(1)
        col.Width = 400
        col = dg_accepted_commande.Columns.Item(2)
        col.Width = 100
        'done
        col = dg_commande_faite.Columns.Item(0)
        col.Width = 150
        col = dg_commande_faite.Columns.Item(1)
        col.Width = 250
        col = dg_commande_faite.Columns.Item(2)
        col.Width = 50
        col = dg_commande_faite.Columns.Item(3)
        col.Width = 100
        col = dg_commande_faite.Columns.Item(4)
        col.Width = 100
        col = dg_commande_faite.Columns.Item(5)
        col.Width = 200
        'answer
        col = pharm_answer.Columns.Item(1)
        col.Width = 100
        col = pharm_answer.Columns.Item(2)
        col.Width = 300
        col = pharm_answer.Columns.Item(3)
        col.Width = 100
        col = pharm_answer.Columns.Item(4)
        col.Width = 200


        'init recherche produit'
        pharm_prod_txt.Text = "Produit"
        pharm_quant.Text = "Quantité"
        pharm_prod_txt.ForeColor = Color.Gray
        pharm_quant.ForeColor = Color.Gray
        pharm_list.Visible = False

        'init combobox of commande done
        ''
        pharm_combo_done_filter.Text = "toutes les commandes"
        '
        ComboBox1.Text = "1"
        lbl_state.Text = "Prêt "
        ' bas.execute("insert into Pharmacie values ('nom az','Adress az'," & 999 & "," & 9999 & ",'az tel','fax az')")
        bas.execute("select * from Pharmacie ")
        bas.read(se, "Pharmacie")

        Dim i As Integer
        dg_pharm_dispo.Rows().Clear()
        Dim m As DataRow
        For i = 0 To se.Tables("Pharmacie").Rows().Count() - 1 Step 1
            m = se.Tables("Pharmacie").Rows(i)
            If m.Item("connecte") = 1 Then

                dg_pharm_dispo.Rows.Add(m.Item("Nom"), m.Item("Adresse"), m.Item("Distance"), m.Item("Tel"), m.Item("Fax"), m.Item("Degré Echange"), "Disponible")
            Else
                dg_pharm_dispo.Rows.Add(m.Item("Nom"), m.Item("Adresse"), m.Item("Distance"), m.Item("Tel"), m.Item("Fax"), m.Item("Degré Echange"), "Déconecté")

            End If


        Next
        'no pharma
        If se.Tables("Pharmacie").Rows().Count() = 0 Then
            lbl_pharma.Visible = True
        Else
            lbl_pharma.Visible = False
        End If
        'init componenet of answer
        pharm_accepted_filter.Text = "Tout"
        '

        ' DataGridView1.DataSource = se.Tables("Pharmacie")
        ' MsgBox(se.Tables("Pharmacie").Rows().Count().ToString())
        'load anser connected

        bas.execute("select * from [Demandes produit] where((traité<10)and(traité>0)) order by exdate desc")
        bas.read(sef, "[Demandes produit]")



        For i = 0 To sef.Tables("[Demandes produit]").Rows().Count() - 1 Step 1
            pharm_answer.Rows.Add(sef.Tables("[Demandes produit]")(i)(0).ToString(), sef.Tables("[Demandes produit]")(i)(1).ToString(), sef.Tables("[Demandes produit]")(i)(2).ToString(), sef.Tables("[Demandes produit]")(i)(3).ToString(), sef.Tables("[Demandes produit]")(i)(4).ToString(), "accept", "decline")

        Next
        'demandes recues
        If sef.Tables("[Demandes produit]").Rows().Count() = 0 Then
            lbl_encourt.Visible = True
        Else
            lbl_encourt.Visible = False
        End If

        'chaque x temps on fait une mise a jour de tout les commandes vers notre pharmacie
        Me.Timer_answer.Interval = 5000
        Me.Timer_answer.Start()
        'init timer1 of result
        Me.Timer1.Interval = 5000
        Me.Timer1.Start()

    End Sub


    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Timer12.Interval = 16000
        Timer12.Start()
        lbl_state.Text = "en court d'exuectution veuillez patienter ..."
        Dim i As Integer
        phar.Clear()
        For i = 0 To CInt(se.Tables("Pharmacie").Rows().Count().ToString()) - 1 Step 1
            phar.Add(New pharm_con(se.Tables("Pharmacie")(i)("user").ToString(), se.Tables("Pharmacie")(i)("server_name").ToString(), se.Tables("Pharmacie")(i)("password").ToString())) ' modification possible user paswd
            phar(i).set_info(se.Tables("Pharmacie")(i)("ID"), se.Tables("Pharmacie")(i)("Distance"), se.Tables("Pharmacie")(i)("Adresse"), se.Tables("Pharmacie")(i)("Nom"))

            Dim th As New Thread(AddressOf phar(i).connect)
            th.Start()

        Next


    End Sub





    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Timer12.Stop()
        Dim i As Integer
        For i = 0 To phar.Count() - 1 Step 1
            If phar(i).get_status() = True Then
                bas.execute("update Pharmacie set connecte=1 where id=" + se.Tables("Pharmacie")(i)("ID").ToString())

            End If
        Next
        ' debut(Nothing, Nothing)
        ' uncall debut

        bas.execute("select * from Pharmacie")
        bas.read(se, "Pharmacie")


        dg_pharm_dispo.Rows().Clear()
        Dim m As DataRow
        For i = 0 To se.Tables("Pharmacie").Rows().Count() - 1 Step 1
            m = se.Tables("Pharmacie").Rows(i)
            If m.Item("connecte") = 1 Then

                dg_pharm_dispo.Rows.Add(m.Item("Nom"), m.Item("Adresse"), m.Item("Distance"), m.Item("Tel"), m.Item("Fax"), m.Item("Degré Echange"), "Disponible")
            Else
                dg_pharm_dispo.Rows.Add(m.Item("Nom"), m.Item("Adresse"), m.Item("Distance"), m.Item("Tel"), m.Item("Fax"), m.Item("Degré Echange"), "Déconecté")

            End If


        Next
        lbl_state.Text = "prêt"
        If se.Tables("Pharmacie").Rows().Count() = 0 Then
            lbl_pharma.Visible = True
        Else
            lbl_pharma.Visible = False
        End If

        '' pharmacie_dispo_Load(Nothing, Nothing)
        ' recherche_inter_pharma.initi_phar(phar)

    End Sub

    Private Sub pharm_prod_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles pharm_prod_txt.KeyDown
        If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Down) Then
            pharm_list.Select()

        End If
    End Sub




    Private Sub pharm_prod_txt_TextChanged(sender As Object, e As EventArgs) Handles pharm_prod_txt.TextChanged
        pharm_list.Visible = True
        If pharm_prod_txt.Text = "" Then

            pharm_list.Visible = False
        ElseIf pharm_prod_txt.Text <> "Produit" Then
            bas.execute("SELECT * FROM Produit WHERE Nom LIKE '" + pharm_prod_txt.Text + "%' order by Nom asc")
            'd1.Clear()
            Dim ddl As DataSet = New DataSet()
            bas.read(ddl, "Produit")

            pharm_list.DataSource = ddl.Tables("Produit")
            pharm_list.DisplayMember = "Nom"




        End If

    End Sub

    Private Sub pharm_quant_TextChanged(sender As Object, e As EventArgs) Handles pharm_quant.TextChanged
        Dim i As Integer
        go2 = True

        Try
            i = CInt(pharm_quant.Text)
        Catch ex As Exception
            go2 = False
        End Try
    End Sub

    Private Sub pharm_rech_btn_Click(sender As Object, e As EventArgs) Handles pharm_rech_btn.Click 'rechercher dans les pharmacies
        Dim res As Boolean
        Dim data As DataSet = New DataSet()
        Dim data_all As DataSet = New DataSet()
        Dim quant As Double

        list_connected.Clear()
        res = False
        dg_pharma_do.Rows.Clear()
        If ((go = True) And (go2 = True)) Then
            Dim l As Integer
            Dim ss As String
            quant = CDbl(ComboBox1.Text)
            l = CInt(pharm_quant.Text)
            l = l * quant
            ' MsgBox(l)
            ss = pharm_prod_txt.Text
            Dim k As pharm_con
            '
            list_connected.Clear()
            '
            'evoyer des requette pour verifier la presence des produits
            '
            For Each k In phar
                If (k.get_status() = True) Then
                    k.execute("use az")
                    k.execute("select * from Produit where (Nom='" + ss + "' and [Quantité Actuelle]>=" + l.ToString() + ")") ' need to add quantité
                    '
                    'make list of only connected
                    list_connected.Add(k)
                    '----
                    res = True
                End If
            Next


            Dim j As Integer
            d1.Reset()
            d1.Tables.Add("Pharmacie")
            d1.Tables("Pharmacie").Columns.Add("ID", GetType(String))
            d1.Tables("Pharmacie").Columns.Add("Nom", GetType(String))
            d1.Tables("Pharmacie").Columns.Add("Adresse", GetType(String))
            d1.Tables("Pharmacie").Columns.Add("Distance", GetType(String))
            j = 0
            int_list.Clear()
            If res = True Then
                'need to update 
                res = False
                For Each k In list_connected ' was before ll
                    If (k.get_status() = True) Then

                        k.read(data, "Produit") 'need to add quantité later ****
                        If data.Tables("Produit").Rows().Count() > 0 Then

                            'get quantité for each pharmacie

                            int_list.Add(CInt(data.Tables("Produit").Rows(0).Item("Quantité actuelle")))
                            ''
                            ''

                            Dim nrow As DataRow = d1.Tables("Pharmacie").NewRow()
                            nrow("ID") = k.num
                            nrow("Nom") = k.nomf
                            nrow("Adresse") = k.adress
                            nrow("Distance") = CStr(k.Distance)
                            d1.Tables("Pharmacie").Rows.Add(nrow)
                        End If
                        res = True
                    End If
                Next


            End If
            'DataGridView1.DataSource = d.Tables("Pharmacie")
            '  Dim im As DataGridViewButtonCell
            ' Dim im2 As DataGridViewCheckBoxCell
            ' im = New DataGridViewButtonCell()
            ' im2 = New DataGridViewCheckBoxCell()
            ' im.Value = "commander"
            ' im2.Value = False
            ' im = New Bitmap("C:\Users\ASUS\Desktop\kjhir")
            For i = 0 To d1.Tables("Pharmacie").Rows().Count() - 1 Step 1
                dg_pharma_do.Rows.Add(d1.Tables("Pharmacie")(i)("Nom").ToString(), d1.Tables("Pharmacie")(i)("Adresse").ToString(), d1.Tables("Pharmacie")(i)("Distance").ToString(), "commander")

                'DataGridView1.Rows.Add(d.Tables("Pharmacie")(i)("ID").ToString(), d.Tables("Pharmacie")(i)("Nom").ToString(), d.Tables("Pharmacie")(i)("Adresse").ToString(), d.Tables("Pharmacie")(i)("Distance").ToString(), im)

                '((Combobox)DataGridView1.Rows(i).Cells("quantité")).
                ' d.Tables("Pharmacie")(i)("ID"),d.Tables("Pharmacie")(i)("Nom"),d.Tables("Pharmacie")(i)("Adress"),(d.Tables("Pharmacie")(i)("Distance"))
            Next
            Dim varr As DataGridViewComboBoxCell

            For i = 0 To dg_pharma_do.Rows().Count() - 1 Step 1
                varr = dg_pharma_do.Rows(i).Cells(3)
                For j = 1 To int_list.Item(i) Step 1
                    varr.Items.Add(CStr(j))
                Next
                varr.Value = "1"
            Next
            'labels
            If dg_pharma_do.Rows().Count() = 0 Then
                lbl_produict.Visible = True
            Else
                lbl_produict.Visible = False
            End If


        End If
    End Sub

    Private Sub pharm_commande_btn_Click(sender As Object, e As EventArgs) Handles pharm_commande_btn.Click
        Dim fg As MsgBoxResult

        Dim ss As String
        ss = "aucune commande selectionné à executer "
        For i = 0 To dg_pharma_do.Rows().Count() - 1 Step 1
            If dg_pharma_do.Rows(i).Cells("selection").Value = True Then
                If ss = "aucune commande selectionné à executer " Then
                    ss = "vous confirmez votre commandes du produit '" + pharm_prod_txt.Text + vbCrLf + " de " + dg_pharma_do.Rows(i).Cells(0).Value.ToString() + " quantité:" + dg_pharma_do.Rows(i).Cells(3).Value.ToString() + " "
                Else
                    ss = ss + vbCrLf + "&  de " + dg_pharma_do.Rows(i).Cells(0).Value.ToString() + " quantité:" + dg_pharma_do.Rows(i).Cells(3).Value.ToString() + " "
                End If
            End If
        Next

        fg = MsgBox(ss, vbOKCancel + vbInformation, "confirmation")
        If (fg = vbOK) Then

            For i = 0 To dg_pharma_do.Rows().Count() - 1 Step 1
                If dg_pharma_do.Rows(i).Cells("selection").Value = True Then

                    list_connected.Item(i).execute("insert into [Demandes produit] values ('" + asm + "','" + pharm_prod_txt.Text + "'," + dg_pharma_do.Rows(i).Cells("quantité").Value.ToString() + ",GETDATE(),9) ")
                    commande.Add(New pharm_commande(pharm_prod_txt.Text, dg_pharma_do.Rows(i).Cells("quantité").Value, list_connected.Item(i)))
                End If
            Next
        Else

        End If
        'Button3_Click(Nothing, Nothing)

    End Sub

    Private Sub pharm_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pharm_list.DoubleClick
        pharm_prod_txt.Text = pharm_list.Text
        pharm_list.Visible = False
        go = True
    End Sub
    Private Sub pharm_list_keydown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles pharm_list.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            pharm_prod_txt.Text = pharm_list.Text
            pharm_list.Visible = False
            go = True
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pharma_do.CellClick
        If (e.RowIndex > -1) And (e.ColumnIndex = 5) Then 'chnge made here
            ' need to change my pharm name to real
            ' Timer1.Start()

            Dim fg As MsgBoxResult

            Dim ss As String
            ss = "voullez vous commander le produit '" + pharm_prod_txt.Text + "' avec la quantité :" + dg_pharma_do.Rows(e.RowIndex).Cells("quantité").Value.ToString()


            fg = MsgBox(ss, vbOKCancel + vbInformation, "confirmation")
            If (fg = vbOK) Then
                Dim i As Integer
                Dim keep As Boolean
                Dim po As pharm_con
                keep = True
                i = list_connected.Count() - 1
                'MsgBox("hello")
                While ((i >= 0) And (keep = True))

                    ' MsgBox("boucle")
                    po = list_connected(i)
                    If (po.nomf = dg_pharma_do.Rows(e.RowIndex).Cells("Nomm").Value) And (po.Distance = dg_pharma_do.Rows(e.RowIndex).Cells("Distancee").Value) And (po.adress = dg_pharma_do.Rows(e.RowIndex).Cells("Adresss").Value) Then
                        keep = False
                        commande.Add(New pharm_commande(pharm_prod_txt.Text, CInt(dg_pharma_do.Rows(e.RowIndex).Cells("quantité").Value.ToString()), po))
                        po.execute("insert into [Demandes produit] values ('" + asm + "','" + pharm_prod_txt.Text + "'," + dg_pharma_do.Rows(e.RowIndex).Cells("quantité").Value.ToString() + ",GETDATE(),9) ")
                    End If
                    i = i - 1
                End While
                Button3_Click(Nothing, Nothing)
            Else

            End If

            'list_connected.Item(e.RowIndex).execute("insert into [Demandes produit] values ('ma_pharmacie','" + pharm_prod_txt.Text + "'," + dg_pharma_do.Rows(e.RowIndex).Cells("quantité").Value.ToString() + ",GETDATE(),9) ")
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles pharm_update_comd.Click
        Dim i As Integer
        dg_commande_faite.Rows().Clear()

        Dim k As Integer
        If ((pharm_combo_done_filter.Text = "les commandes refusées")) Then
            k = 0
        ElseIf ((pharm_combo_done_filter.Text = "les commandes acceptées")) Then
            k = 2
        ElseIf ((pharm_combo_done_filter.Text = "les commandes en court")) Then
            k = 1

        Else
            k = -1

        End If
        For i = commande.Count() - 1 To 0 Step -1
            commande.Item(i).update_status_comande()
            If (k <> -1) Then
                If (commande.Item(i).etat = k) Then
                    commande.Item(i).create_row_datagrid(dg_commande_faite)
                End If


            Else
                commande.Item(i).create_row_datagrid(dg_commande_faite)
            End If
        Next

        If commande.Count() = 0 Then
            lbl_do.Visible = True
        Else
            lbl_do.Visible = False
        End If




    End Sub
    Private Sub DataGrid_answer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pharm_answer.CellClick

        If (e.RowIndex > -1) Then
            If (e.ColumnIndex = 5) Then ' accepted
                'bas.execute("update [Demandes produit] set traité=10 where id=" & +bas.Tables("[Demandes produit]")(e.RowIndex)(0).ToString())
                'bas.execute("update Pharmacie set [Degré Echange]=[Degré Echange]+1 where exists(select 1 from [Demandes Produit] where ((exdate='" + pharm_answer.Rows(e.RowIndex).Cells("edate").Value.ToString() + "') and (pharmacie='" + pharm_answer.Rows(e.RowIndex).Cells("re_Nom").Value.ToString() + "'))); ")
                bas.execute("update Pharmacie set [Degré Echange]=[Degré Echange]+1 where  (Nom='" + pharm_answer.Rows(e.RowIndex).Cells("re_Nom").Value.ToString() + "')")
                bas.execute("update [Demandes produit] set traité=10 where id=" + pharm_answer.Rows(e.RowIndex).Cells("ID").Value.ToString())
                Timer1_Tick(Nothing, Nothing)

            End If
            If (e.ColumnIndex = 6) Then ' refused
                bas.execute("update [Demandes produit] set traité=0 where id=" + pharm_answer.Rows(e.RowIndex).Cells("ID").Value.ToString())

                Timer1_Tick(Nothing, Nothing)
            End If
            ' Timer1_Tick(Nothing, Nothing)
            ' TabPage2_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_answer.Tick
        bas.execute("update [Demandes produit] set traité=traité-1 where((traité<10)and(traité>0)) ")
        bas.execute("select * from [Demandes produit] where((traité<10)and(traité>0))")
        bas.read(sef, "[Demandes produit]")
        pharm_answer.Rows.Clear()

        If (sef.Tables("[Demandes produit]").Rows().Count() > 0) Then
            ' Me.Visible = True
            'add notification
            Dim msg As String
            msg = "des commandes reçues de:"
            'notiffon
            Dim i As Integer

            For i = 0 To sef.Tables("[Demandes produit]").Rows().Count() - 1 Step 1
                pharm_answer.Rows.Add(sef.Tables("[Demandes produit]")(i)(0).ToString(), sef.Tables("[Demandes produit]")(i)(1).ToString(), sef.Tables("[Demandes produit]")(i)(2).ToString(), sef.Tables("[Demandes produit]")(i)(3).ToString(), sef.Tables("[Demandes produit]")(i)(4).ToString(), "accept", "decline")
                'add data in msg
                msg = msg + vbCrLf + sef.Tables("[Demandes produit]")(i)(1).ToString()
            Next

            Accueil.lbl_acceuil_notif.Text = msg
            'notif count
            If sef.Tables("[Demandes produit]").Rows().Count() > nb_c_notif Then

                'nofing
                Me.affichernotf(msg)
                Accueil.lbl_acceuil_notif.Text = msg
                Vente.affichernotf(msg)
                CompteAffichage.affichernotf(msg)
                Achat_Achat.affichernotf(msg)
                Achat_Commande.affichernotf(msg)
                Stock.affichernotf(msg)
                RestMain.affichernotf(msg)

            End If
            nb_c_notif = sef.Tables("[Demandes produit]").Rows().Count()


            ' hhjvhjvhjvhjv



            'labels
            lbl_encourt.Visible = False
        Else
            nb_c_notif = 0
            lbl_encourt.Visible = True
            Accueil.lbl_acceuil_notif.Text = "aucunne notification"
        End If
        'Button3_Click(Nothing, Nothing)
        pharm_update_last_Click(Nothing, Nothing)

    End Sub
    ' label subbs
    Public stat_notif As Boolean = False
    Public nb_c_notif As Integer = 0
    'new boolean above

    Private Sub pharm_connected_produit_change_MouseClick(sender As Object, e As MouseEventArgs) Handles pharm_prod_txt.MouseClick
        If pharm_prod_txt.Text = "Produit" Then
            pharm_prod_txt.ForeColor = Color.Black
            pharm_prod_txt.Text = ""
            pharm_list.Visible = False
        End If

    End Sub
    Private Sub pharm_connected_quantité_mouse_clik(sender As Object, e As MouseEventArgs) Handles pharm_quant.MouseClick

        pharm_quant.ForeColor = Color.Black
        pharm_quant.Text = ""
    End Sub


    Private Sub tabbcontol(sender As Object, e As System.EventArgs) Handles pharmacie_tab.Selected
        pharm_prod_txt.Text = "Produit"
        pharm_quant.Text = "Quantité"
        pharm_prod_txt.ForeColor = Color.Gray
        pharm_quant.ForeColor = Color.Gray
        pharm_list.Visible = False
        dg_pharma_do.Rows.Clear()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles pharm_update_answer.Click
        Timer1_Tick(Nothing, Nothing)
        bas.execute("delete from [demande produit] where traité=0 ;")

    End Sub

    Private Sub pharm_update_last_Click(sender As Object, e As EventArgs) Handles pharm_update_last.Click
        If pharm_accepted_filter.Text = "Tout" Then

            bas.execute("select * from [Demandes produit] where traité=10 order by exdate desc")
            d1.Clear()


            bas.read(d1, "[Demandes produit]")
            dg_accepted_commande.Rows.Clear()
            'dg_accepted_commande.DataSource = d1.Tables("[Demandes produit]")
            Dim i As Integer
            For i = 0 To d1.Tables("[Demandes produit]").Rows().Count() - 1 Step 1
                dg_accepted_commande.Rows().Add(d1.Tables("[Demandes produit]").Rows(i).Item(4).ToString(), d1.Tables("[Demandes produit]").Rows(i).Item(2).ToString(), d1.Tables("[Demandes produit]").Rows(i).Item(3).ToString(), d1.Tables("[Demandes produit]").Rows(i).Item(1).ToString())

            Next
            'labels
            If d1.Tables("[Demandes produit]").Rows().Count() = 0 Then
                lbl_accepted.Visible = True
            Else
                lbl_accepted.Visible = False

            End If
        Else
            Dim val As Integer
            If pharm_accepted_filter.Text = "les derniers 2 heures" Then
                val = 2
            ElseIf pharm_accepted_filter.Text = "les derniers 4 heures" Then
                val = 4
            Else
                val = 8

            End If
            Dim ss As Date
            ss = DateTime.Now
            ss = ss.AddHours(-val)
            Dim s As String
            s = ss.ToString("yyyy-MM-dd HH:mm:ss")
            bas.execute("select * from [Demandes produit] where ((traité=10)and(exdate > '" + s + "')) order by exdate desc")
            d1.Clear()


            bas.read(d1, "[Demandes produit]")
            dg_accepted_commande.Rows.Clear()
            'dg_accepted_commande.DataSource = d1.Tables("[Demandes produit]")
            Dim i As Integer
            For i = 0 To d1.Tables("[Demandes produit]").Rows().Count() - 1 Step 1
                dg_accepted_commande.Rows().Add(d1.Tables("[Demandes produit]").Rows(i).Item(4).ToString(), d1.Tables("[Demandes produit]").Rows(i).Item(2).ToString(), d1.Tables("[Demandes produit]").Rows(i).Item(3).ToString(), d1.Tables("[Demandes produit]").Rows(i).Item(1).ToString())

            Next
            If d1.Tables("[Demandes produit]").Rows().Count() = 0 Then
                lbl_accepted.Visible = True
            Else
                lbl_accepted.Visible = False

            End If
        End If

    End Sub


    Private Sub pharm_btn_accept_all_Click(sender As Object, e As EventArgs) Handles pharm_btn_accept_all.Click

        bas.execute("update Pharmacie set [Degré Echange]=[Degré Echange]+1 where exists (select 1 from [Demandes produit] where(  (Pharmacie.Nom=[Demandes produit].pharmacie)and (traité<10)and(traité>0 )));")
        bas.execute("update [Demandes produit] set traité=10 where traité>0 ;")
        Timer1_Tick(Nothing, Nothing)


    End Sub

    Private Sub pharm_btn_refuse_all_Click(sender As Object, e As EventArgs) Handles pharm_btn_refuse_all.Click

        bas.execute("update [Demandes produit] set traité=0 where traité<10 ;")
        Timer1_Tick(Nothing, Nothing)
        'pharm_update_last_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        pharm_formulaire.Show()
    End Sub

    Private Sub pharm_accepted_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pharm_accepted_filter.SelectedIndexChanged
        pharm_update_last_Click(Nothing, Nothing)
    End Sub

    Private Sub pharm_combo_done_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pharm_combo_done_filter.SelectedIndexChanged
        Button3_Click(Nothing, Nothing)
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Button3_Click(Nothing, Nothing)
    End Sub


End Class