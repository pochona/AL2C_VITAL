Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PagePopUpContrat
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            consultContrat.RefreshData()
        End If
    End Sub

    Private Sub dtgResults_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles consultContrat.DataTableRequest
        Try
            p_o_dt = Contrat.SearchedConsultContrat.GetDT
        Catch ex As Exception

            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgResults_Init(sender As Object, e As EventArgs) Handles consultContrat.Init
        With consultContrat
            .DataKeyField = VTL_CONTRAT.VTL_CONTRAT_ID
            .AddSelectColumn("Nom", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
            .AddSelectColumn("Numéro de contrat", VTL_CONTRAT.VTL_CONTRAT_NUM_CONTRAT)
            .AddDateColumn("Début du contrat", VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT)
            .AddDateColumn("Fin du contrat", VTL_CONTRAT.VTL_CONTRAT_DT_FIN)

        End With
    End Sub
End Class