Public Class Bon

    '------------------Attribus-------------------
    Private dateBon As String
    Private fournisseur As String
    Private numBon, i, r As Integer
    Private requete As String
    Private vali As String = "Non valide"
    Public basee2 As DataBase = New DataBase()
    Private dt As DataTable = New DataTable()
    '--------------------------------------------------------------------------
    '-------------------------- Constructeur----------------------------------
    Sub New()

    End Sub
    Sub New(ByVal dat As String, ByVal f As String, ByVal n As Integer)
        dateBon = dat
        fournisseur = f
        numBon = n
    End Sub


    '--------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------
    '                               Setters and getters

    Public Property dte() As String
        Get
            Return dateBon
        End Get
        Set(ByVal value As String)
            dateBon = value
        End Set
    End Property

    Public Property frns() As String
        Get
            Return fournisseur
        End Get
        Set(ByVal value As String)
            fournisseur = value
        End Set
    End Property

    Public Property num() As Integer
        Get
            Return numBon
        End Get
        Set(ByVal value As Integer)
            numBon = value
        End Set
    End Property

    '---------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------
    '                               Methodes
    Sub ajouter_cmd(ByRef a As String, ByVal b As String)
        Achat_Commande.d.Tables("cmd").Rows.Add(a, b, "Non valide", Achat_Commande.TextBox1.Text)
        Achat_Commande.DataGridView1.DataSource = Achat_Commande.d.Tables("cmd")
    End Sub

    Sub enregistrer_bon(ByVal n As Integer, ByVal four As String, ByVal dat As String)
        requete = "INSERT INTO [Bon Commande] VALUES ( " + n.ToString + ",'" + dat.Substring(6, 4) + "-" + dat.Substring(3, 2) + "-" + dat.Substring(0, 2) + "','" + four + "','" + vali + "')"
        basee2.execute(requete)
    End Sub

    Function verifie_numBon(ByVal number As Integer, ByRef data As DataSet) As Boolean
        basee2.execute("SELECT * FROM [Bon Commande] WHERE Ref = " + number.ToString + "")
        basee2.read(data, "Bon Commande")
        dt = data.Tables("Bon Commande")
        If (dt.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If
    End Function




End Class
