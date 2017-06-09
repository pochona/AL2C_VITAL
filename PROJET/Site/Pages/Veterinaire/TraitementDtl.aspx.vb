Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageTraitementDtl
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'TODO
        End If
    End Sub

#Region "Grille Traitements"

#Region "Colonnes de la grille "

    Private m_i_btn_traitmt_medoc As Integer
    Private m_i_duree_medoc As Integer
    Private m_i_date_deb As Integer
    Private m_i_btn_trt As Integer
    Private m_i_duree_traitmt As Integer
    Private m_i_lib_medoc As Integer
    Private m_i_Posologie As Integer
    Private m_i_dosage_medoc As Integer

#End Region

    'x Private Sub dtgTraitements_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgTraitements.DataTableRequest
    'x     Try
    'x         p_o_dt = Traitement_medicament.GetTraitmtAnimal(SelectedAnimalId).GetDT
    'x     Catch ex As Exception
    'x         ShowException(ex)
    'x     End Try
    'x End Sub

    
    'x     Private Sub dtgTraitements_Init(sender As Object, e As EventArgs) Handles dtgTraitements.Init
    'x         With dtgTraitements
    'x             .DataKeyField = VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID
    'x 
    'x             With .AddButtonColumn()
    'x                 .Width = Unit.Pixel(65) ' fixe la taille de la colonne
    'x                 .DataNavigateUrlFormatString = "~/Pages/Veterinaire/Traitement.aspx?Mode=" & EN_ModeAcces.Modification & "&ID={0}"
    'x                 .DataNavigateUrlField = VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID
    'x                 .Target = "tabTraitement_Medoc" + VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID
    'x                 .Properties.ImageName = "search"
    'x                 m_i_btn_traitmt_medoc = .ColumnIndex
    'x             End With
    'x             With .AddDateColumn("Date début", VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
    'x                 m_i_date_deb = .ColumnIndex
    'x             End With
    'x             With .AddColumn("Durée de prise du médicament", VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
    'x                 m_i_duree_medoc = .ColumnIndex
    'x             End With
    'x             With .AddColumn("Durée globale du traitement", VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR)
    'x                 m_i_duree_traitmt = .ColumnIndex
    'x             End With
    'x             With .AddColumn("Médicament", VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE)
    'x                 m_i_lib_medoc = .ColumnIndex
    'x             End With
    'x             With .AddColumn("Posologie", VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE)
    'x                 m_i_Posologie = .ColumnIndex
    'x             End With
    'x             With .AddColumn("Dosage du médicament", VTL_MEDICAMENT.VTL_MEDICAMENT_DOSAGE)
    'x                 m_i_dosage_medoc = .ColumnIndex
    'x             End With
    'x         End With
    'x     End Sub
  

#End Region
End Class
