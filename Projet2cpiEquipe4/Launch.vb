Imports System.Threading
Imports System.Net.Security.SslStream
Imports System.Net.Security
Imports System.IO


Public Class Launch
    Public b As Boolean = False
    Private ctrl As Integer = 0
    Public namepharm As String

    Private Sub Launch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial.Show()
    End Sub
    Private Sub ProgressBar1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then


            Dim re As StreamReader
            Dim wr As StreamWriter
            Dim s As String = Application.StartupPath + "\Code.txt"
            Try
                'Dim ty As String = Path.GetFullPath("Code.txt")
                re = My.Computer.FileSystem.OpenTextFileReader(s)
            Catch ex As Exception
                wr = File.CreateText(s)
                wr.Close()
                re = My.Computer.FileSystem.OpenTextFileReader(s)
            End Try

            Dim op As String = re.ReadLine()
            namepharm = re.ReadLine()
            re.Close()
            Try
                DataBase.connect(op)
                b = True

            Catch ex2 As Exception
                While ctrl = 0
                    Dim res As MsgBoxResult = MsgBox("Votre base de données est introuvable ! Voulez-vous connecter une nouvelle base ?", vbYesNo + vbInformation, "Base Introuvable !")
                    If res = vbYes Then
                        ctrl = 1
                        BaseNotFound.ShowDialog()
                    Else
                        If MsgBox("Souhaitez-vous vraiment annuler l'opération ? Cela va forcer l'arrêt du programme ?", vbYesNo + vbInformation, "Quitter?") = vbYes Then
                            End
                        End If
                    End If
                End While
            End Try



        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            '--------------------------------
            Me.Visible = False
            Timer1.Enabled = False
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If

    End Sub


    Private Sub ProgressBar1_MouseMove(sender As Object, e As EventArgs) Handles Timer3.tick
        If b = True Then
            Timer3.Enabled = False
            'Accueil.Show()
            CompteConnect.ShowDialog()
            Precedent.init()
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim verif As Stock_Verification = New Stock_Verification()

        Dim d1 As DataSet = New DataSet
        Dim d2 As DataSet = New DataSet
        Dim d3 As DataSet = New DataSet
        If Now.TimeOfDay.ToString >= "00:00:00" Then
            Timer2.Enabled = False
            d1 = verif.Verifier_Perime()
            d2 = verif.Verifier_Proche_Peremption()
            d3 = verif.Verifier_Rupture()
            Accueil.Label11.Text = d1.Tables(0).Rows.Count
            Accueil.Label12.Text = d2.Tables(0).Rows.Count
            Accueil.Label14.Text = d3.Tables(0).Rows.Count
            Timer2.Enabled = True
        End If
    End Sub


End Class