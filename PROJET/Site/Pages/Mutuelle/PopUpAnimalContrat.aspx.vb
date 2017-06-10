Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PagePopUpAnimalContrat
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            dtgAnimalContrat.RefreshData()
        End If
    End Sub

#Region "Grille"
#Region "Colonnes de la grille"

    Private m_i_prenom As Integer
    Private m_i_adr As Integer

#End Region

    Private Sub dtgAnimalContrat_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgAnimalContrat.DataTableRequest
        Try
            p_o_dt = Animal.GetAnimauxByProprio(1).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgAnimalContrat_Init(sender As Object, e As EventArgs) Handles dtgAnimalContrat.Init
        With dtgAnimalContrat
            .DataKeyField = VTL_ANIMAL.VTL_ANIMAL_ID

            With .AddSelectColumn("Nom", VTL_ANIMAL.VTL_ANIMAL_NOM, "=")
                ' On revoie le champ
                .AddReturnedFields(VTL_ANIMAL.VTL_ANIMAL_ID)
                ' Taille 
                .Width = Unit.Pixel(65)
            End With
            .AddColumn("Race", VTL_RACE.VTL_RACE_NOM)
            .AddColumn("Type", VTL_TYPE.VTL_TYPE_LIBELLE)
        End With
        
    End Sub
#End Region

End Class
