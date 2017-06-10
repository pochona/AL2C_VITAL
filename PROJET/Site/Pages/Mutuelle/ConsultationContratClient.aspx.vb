Imports VITAL.BO.VITAL

Partial Public Class PageConsultationClient
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            dtgContratClient.RefreshData()
        End If
    End Sub

#Region "Grille contrat/clients"

#Region "Colonnes de la grille"

    Private m_i_dt_deb As Integer
    Private m_i_dt_fin As Integer
    Private m_i_nom_proprietaire As Integer
    Private m_i_prenom_proprietaire As Integer
    Private m_i_type As Integer
    Private m_i_race As Integer
    Private m_i_tx_remb As Integer
    Private m_i_nom_animal As Integer

#End Region

#End Region

    Private Sub dtgContratClient_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgContratClient.DataTableRequest
        Try
            p_o_dt = Contrat.GetContratData().GetDT()
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgContratClient_Init(sender As Object, e As EventArgs) Handles dtgContratClient.Init
        With dtgContratClient
            .DataKeyField = VTL_CONTRAT.VTL_CONTRAT_ID
            With .AddDateColumn("Début", VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT)
                m_i_dt_deb = .ColumnIndex
            End With
            With .AddDateColumn("Fin", VTL_CONTRAT.VTL_CONTRAT_DT_FIN)
                m_i_dt_fin = .ColumnIndex
            End With
            With .AddColumn("Nom propriétaire", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                m_i_nom_proprietaire = .ColumnIndex
            End With
            With .AddColumn("Prenom propriétaire", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                m_i_prenom_proprietaire = .ColumnIndex
            End With
            With .AddColumn("Nom de l'animal", VTL_ANIMAL.VTL_ANIMAL_NOM)
                m_i_nom_animal = .ColumnIndex
            End With
            With .AddColumn("Type animal", VTL_TYPE.VTL_TYPE_LIBELLE)
                m_i_type = .ColumnIndex
            End With
            With .AddColumn("Race animal", VTL_RACE.VTL_RACE_NOM)
                m_i_race = .ColumnIndex
            End With
            With .AddColumn("Type de contrat", VTL_CONTRAT.VTL_CONTRAT_TXREMB)
                m_i_tx_remb = .ColumnIndex
            End With
        End With

    End Sub

End Class