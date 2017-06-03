Imports VITAL.BO
Imports VITAL.BO.VITAL


Partial Public Class PagePopUpProprio
    Inherits CwPage

#Region "Chargement"

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            dtgProprio.RefreshData()
        End If
    End Sub

#End Region

#Region "Grille"

    Private Sub dtgProprio_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgProprio.DataTableRequest
        Try
            p_o_dt = BO.VITAL.User.GetProprios().GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgProprio_Init(sender As Object, e As EventArgs) Handles dtgProprio.Init
        With dtgProprio
            .DataKeyField = VTL_USER.VTL_USER_ID

            With .AddSelectColumn("Nom", VTL_USER.VTL_USER_NOM, "=")
                ' On revoie le champ
                .AddReturnedFields(VTL_USER.VTL_USER_ID)
                ' Taille 
                .Width = Unit.Pixel(65)
            End With
            .AddColumn("Prénom", VTL_USER.VTL_USER_PRENOM)
        End With
    End Sub

#End Region

End Class
