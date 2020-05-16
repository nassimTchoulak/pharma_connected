Public Class Facture

    '-----------------------------------------------------
    '               Les atribus
    Private Ref As Integer
    Private dat, fournisseur, requete As String
    Private TTC, HT As Double
    Public basee3 As DataBase = New DataBase()
    Private dt3 As DataTable = New DataTable()

    '------------------------------------------------------
    '-----------------Constructeur-------------------------

    Sub New()

    End Sub

    '------------------------------------------------------
    '----------------Getters and setters-----------------
    Public Property dteFac() As String
        Get
            Return dat
        End Get
        Set(ByVal value As String)
            dat = value
        End Set
    End Property

    Public Property frnsFac() As String
        Get
            Return fournisseur
        End Get
        Set(ByVal value As String)
            fournisseur = value
        End Set
    End Property

    '------------------------------------------------------
    '-------------------Les méthodes----------------------

    Sub ajout_achat(ByVal nom As String, ByVal q As Integer, ByVal datEx As String, ByVal prixUachat As Double, ByVal marge As Double, ByVal PPA As Double, ByVal SHP As Double, ByVal prixUvente As Double, ByVal prixtotalHT As Double, ByVal prixtotalTTC As Double, ByVal TVA As Double, ByVal e As String)
        Achat_Achat.dFA.Tables("achat").Rows.Add(nom, q, datEx, prixUachat, marge, PPA, SHP, prixUvente, prixtotalHT, TVA, prixtotalTTC, Achat_Achat.TextBox1.Text, e)
        Achat_Achat.DataGridView1.DataSource = Achat_Achat.dFA.Tables("achat")
    End Sub

    Sub enregistrer_fac(ByVal num As Integer, ByVal four As String, ByVal d As String, ByVal monHT As Double, ByVal monTTC As Double)

        requete = "INSERT INTO [Facture Achat] VALUES ( " + num.ToString + ",'" + d.Substring(6, 4) + "-" + d.Substring(3, 2) + "-" + d.Substring(0, 2) + "','" + four + "', " + monHT.ToString + ", " + monTTC.ToString + ")"
        basee3.execute(requete)
        MsgBox("insertion termine")
    End Sub

    Function verifie_numFac(ByVal number As Integer, ByRef data As DataSet) As Boolean
        basee3.execute("SELECT * FROM [Facture Achat] WHERE Ref = '" + number.ToString + "'")
        basee3.read(data, "Facture Achat")
        dt3 = data.Tables("Facture Achat")
        If (dt3.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
