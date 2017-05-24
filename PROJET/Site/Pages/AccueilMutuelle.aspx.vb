Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageAccueilMutuelle
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            consultClient.RefreshData()
        End If
    End Sub

    Private Sub dtgResults_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles consultClient.DataTableRequest
        Try
            p_o_dt = Consultation.SearchedConsultClient().GetDT
        Catch ex As Exception

            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgResults_Init(sender As Object, e As EventArgs) Handles consultClient.Init
        With consultClient
            .DataKeyField = VTL_CONSULTATION.VTL_CONSULTATION_ID
            .AddColumn("Numéro de consultation", VTL_CONSULTATION.VTL_CONSULTATION_ID)
            .AddDateColumn("Date demande", VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION, "=")
            .AddNumericColumn("Montant", VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)

        End With
    End Sub
End Class
