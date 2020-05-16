Public Class RestAjout

    Private base As DataBase = New DataBase()
    Dim dtOuvCorr As Boolean = False
    Dim dtExpCorr As Boolean = False
    Dim qtCorr As Boolean = False
    Dim nomCorr As Boolean = False
    Dim expCorr As Boolean = True
    Dim ouvCorr As Boolean = True
    Dim operation As New RestOperation

    Private Sub RestAjout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataSet = New DataSet()
        base.execute("SELECT * FROM Produit")
        base.read(dt, "Produit")
        CMB_Nom.DataSource = dt.Tables("Produit")
        CMB_Nom.DisplayMember = "Nom"
        CMB_Nom.Text = ""
        EP_NOM.SetError(CMB_Nom, "")
        EP_DTOUV.SetError(DTP_OUV, "")
        EP_DTEXP.SetError(DTP_EXP, "")
    End Sub

    Private Sub TXT_QT_Leave(sender As Object, e As EventArgs) Handles TXT_QT.Leave
        If TXT_QT.Text = "" Then
            EP_QT.SetError(TXT_QT, "Champ obligatoire")
            qtCorr = False
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr
    End Sub

    Private Sub TXT_QT_TextChanged(sender As Object, e As EventArgs) Handles TXT_QT.TextChanged
        If TXT_QT.Text = "" Then
            EP_QT.SetError(TXT_QT, "Champ obligatoire")
            qtCorr = False
        ElseIf Not IsNumeric(TXT_QT.Text) Then
            EP_QT.SetError(TXT_QT, "Valeur erronée")
            qtCorr = False
        Else
            If (CInt(TXT_QT.Text) <= 0) Then
                EP_QT.SetError(TXT_QT, "Valeur erronée")
                qtCorr = False
            Else
                qtCorr = True
                EP_QT.SetError(TXT_QT, "")
                BT_VALIDER.Enabled = True
            End If
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr
    End Sub


    Private Sub BT_VALIDER_Click_1(sender As Object, e As EventArgs) Handles BT_VALIDER.Click
        Dim Requete As String
        Dim dateouv As String = "NULL"
        Dim dateexp As String = "NULL"

        If DTP_OUV.Checked Then
            dateouv = DTP_OUV.Value.Date
            dateouv = "convert(date, '" + dateouv + "', 103)"
        End If

        If DTP_EXP.Checked Then
            dateexp = DTP_EXP.Value.Date
            dateexp = "convert(date, '" + dateexp + "', 103)"
        End If

        'Verification des champs
        If (nomCorr And qtCorr) Then
            Requete = "INSERT INTO Restitution VALUES ( '" + CMB_Nom.Text + "'," + TXT_QT.Text + ", " + dateouv + ", " + dateexp + ")"

            base.execute(Requete)
            CMB_Nom.Text = ""
            TXT_QT.Text = ""
            nomCorr = False
            qtCorr = False
            EP_NOM.SetError(CMB_Nom, "")
            EP_QT.SetError(TXT_QT, "")
            operation.chargementProduits("SELECT * FROM Restitution")
        End If
    End Sub

    Private Sub CMB_Nom_Leave(sender As Object, e As EventArgs) Handles CMB_Nom.Leave
        If CMB_Nom.Text = "" Then
            EP_NOM.SetError(CMB_Nom, "Champ obligatoire")
            nomCorr = False
        Else
            nomCorr = True
            EP_NOM.SetError(CMB_Nom, "")
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr
    End Sub

    Private Sub CMB_Nom_TextChanged(sender As Object, e As EventArgs) Handles CMB_Nom.TextChanged
        If CMB_Nom.Text = "" Then
            EP_NOM.SetError(CMB_Nom, "Champ obligatoire")
            nomCorr = False
        Else
            nomCorr = True
            EP_NOM.SetError(CMB_Nom, "")
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr
    End Sub

    Private Sub DTP_OUV_ValueChanged(sender As Object, e As EventArgs) Handles DTP_OUV.ValueChanged
        If DTP_OUV.Text > Date.Now Then
            If DTP_OUV.Checked Then
                ouvCorr = False
                EP_DTOUV.SetError(DTP_OUV, "Date erronée")
            End If
        Else
            ouvCorr = True
            EP_DTOUV.SetError(DTP_OUV, "")
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr

    End Sub

    Private Sub DTP_EXP_Leave(sender As Object, e As EventArgs) Handles DTP_EXP.Leave
        If DTP_EXP.Checked = False Then
            expCorr = True
            EP_DTEXP.SetError(DTP_EXP, "")
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr
    End Sub

    Private Sub DTP_EXP_ValueChanged(sender As Object, e As EventArgs) Handles DTP_EXP.ValueChanged
        If DTP_EXP.Text <= Date.Now Then
            If DTP_EXP.Checked Then
                expCorr = False
                EP_DTEXP.SetError(DTP_EXP, "Date erronée")
            End If
        Else
            expCorr = True
            EP_DTEXP.SetError(DTP_EXP, "")
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr
    End Sub

    Private Sub DTP_OUV_Leave(sender As Object, e As EventArgs) Handles DTP_OUV.Leave
        If DTP_OUV.Checked = False Then
            ouvCorr = True
            EP_DTOUV.SetError(DTP_OUV, "")
        End If
        BT_VALIDER.Enabled = nomCorr And qtCorr And ouvCorr And expCorr
    End Sub
End Class