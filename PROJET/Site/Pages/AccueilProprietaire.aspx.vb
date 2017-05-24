Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageAccueilProprietaire
    Inherits CwPage

#Region "Propriétés et variables privées"

#End Region

#Region "Chargement"

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        dtgAnimx.RefreshData()
    End Sub

#End Region

#Region "Grille"

#Region "Colonnes de la grille des travaux"

    Private m_i_nom As Integer
    Private m_i_type As Integer
    Private m_i_race As Integer
    Private m_i_puce As Integer
    Private m_i_naissance As Integer
    Private m_i_deces As Integer
    Private m_i_carte As Integer

#End Region

    Private Sub dtgAnimx_Init(sender As Object, e As EventArgs) Handles dtgAnimx.Init
        With dtgAnimx
            .DataKeyField = VTL_ANIMAL.VTL_ANIMAL_ID

            With .AddColumn("Nom", VTL_ANIMAL.VTL_ANIMAL_NOM)
                m_i_nom = .ColumnIndex
            End With
            With .AddColumn("Type", VTL_TYPE.VTL_TYPE_LIBELLE)
                m_i_type = .ColumnIndex
            End With
            With .AddColumn("Num puce", VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE)
                m_i_puce = .ColumnIndex
            End With
            With .AddDateColumn("Date naissance", VTL_ANIMAL.VTL_ANIMAL_DT_NAISSANCE)
                m_i_naissance = .ColumnIndex
            End With
            With .AddDateColumn("Date décès", VTL_ANIMAL.VTL_ANIMAL_DT_DECES)
                m_i_deces = .ColumnIndex
            End With
            With .AddColumn("Id carte(à changer)", VTL_ANIMAL.VTL_ANIMAL_ID_CARTE)
                m_i_carte = .ColumnIndex
            End With
            With .AddColumn("Nom race", VTL_RACE.VTL_RACE_NOM)
                m_i_race = .ColumnIndex
            End With
        End With
    End Sub

    Private Sub dtgAnimx_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgAnimx.DataTableRequest
        Try
            p_o_dt = Animal.GetAnimauxProprio(User.Identity.Name).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "Boutons"

#End Region

End Class
