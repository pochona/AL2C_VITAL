Imports System.Data.SqlClient

Partial Public Class PageAjoutContratClient
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Public Sub clicValider(sender As Object, e As EventArgs)

        If NumContrat.Text = "" Then
            label1.Text = "erreur"
        End If

        If DateDebut.Text = "" Then
            label1.Text = "erreur"
        End If

        If DateFin.Text = "" Then
            label1.Text = "erreur"
        End If

        If IdAnimal.Text = "" Then
            label1.Text = "erreur"
        End If

        If IdProprio.Text = "" Then
            label1.Text = "erreur"
        End If

        If IdAssurance.Text = "" Then
            label1.Text = "erreur"
        End If

        If label1.Text <> "erreur" Then
            Dim Connexion As New SqlConnection("Data Source=(localdb)\Projects;Initial Catalog=VITL;User Id=VITL;Password=VITL1234;")
            Connexion.Open()
            Dim Requete As String = "INSERT INTO VTL_CONTRAT(VTL_CONTRAT_NUM_CONTRAT, VTL_CONTRAT_DT_DEBUT, VTL_CONTRAT_DT_FIN, VTL_CONTRAT_ID_ANIMAL, VTL_CONTRAT_ID_PROPRIETAIRE, VTL_CONTRAT_ID_ASSURANCE) VALUES (NumContrat.Text, DateDebut.Text, DateFin.Text, IdAnimal.Text, IdProprio.Text, IdAssurance.Text)"
            Dim Commande As New SqlCommand(Requete, Connexion)
            Connexion.Close()

            Try
                Commande.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            label1.Text = "Contrat ajouté"
        End If

    End Sub


End Class
