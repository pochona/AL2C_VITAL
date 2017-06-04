Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageListeConsult
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
            grdHistorique.RefreshData()
        End If
    End Sub

#End Region

#Region "Grille consultation"

    Private Sub grdHistorique_Init(sender As Object, e As EventArgs) Handles grdHistorique.Init
        With grdHistorique
            .DataKeyField = VTL_CONSULTATION.VTL_CONSULTATION_ID

            .AddColumn("Date", VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
            .AddColumn("Id Vétérinaire", VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE)
            .AddDateColumn("Id Animal", VTL_CONSULTATION.VTL_CONSULTATION_L)
            .AddColumn("Nom", VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
        End With
    End Sub

#End Region

#Region "Recupération des données"

    Private Sub grdHistorique_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles grdHistorique.DataTableRequest
        Try
            ' GetContacts est une requête qui permet de sélectionner les données qui apparaitrons dans la grille
            p_o_dt = Consultation.SearchedConsultVeto(1).GetDT

        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region



End Class
