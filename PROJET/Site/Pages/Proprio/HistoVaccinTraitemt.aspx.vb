Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageHistoVaccinTraitemt
    Inherits CwPage

#Region "propriétés et variables privées"
    Private m_o_animal As Animal

    ''' <summary>
    ''' Contient l'Animal consultée
    ''' </summary>
    ''' <value>Animal</value>
    ''' <returns>Animal</returns>
    Private ReadOnly Property SelectedAnimal As Animal
        Get
            If m_o_animal Is Nothing OrElse (SelectedAnimalId <> m_o_animal.ID) Then
                If SelectedAnimalId <> 0 Then
                    m_o_animal = New Animal(SelectedAnimalId)
                Else
                    m_o_animal = New Animal()
                End If
            End If
            Return m_o_animal
        End Get
    End Property

    ''' <summary>
    ''' Contient l'ID de l'Animal consultée
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID d'une Animal</returns>
    Private Property SelectedAnimalId As Integer
        Get
            Return CInt(ViewState("SelectedAnimalId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedAnimalId") = p_i_value
        End Set
    End Property

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
            'Récupère le document dans l'url
            SelectedAnimalId = CInt(Request.QueryString("ID"))
            dtgVaccins.RefreshData()
            dtgTraitements.RefreshData()
        End If
    End Sub

#End Region

    'x 
    'x #Region "Grilletraitemt"
    'x 
    'x #Region "Colonnes de la grille "
    'x 
    'x     '  Private m_i_date As Integer
    'x     '  Private m_i_montant As Integer
    'x     '  Private m_i_comm As Integer
    'x     '  Private m_i_veto As Integer
    'x 
    'x #End Region
    'x 
    'x     Private Sub dtgTraitements_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgTraitements.DataTableRequest
    'x         Try
    'x             p_o_dt = Consultation.GetConsultationsClient(UserLogin, SelectedAnimalId).GetDT
    'x         Catch ex As Exception
    'x             ShowException(ex)
    'x         End Try
    'x     End Sub
    'x 
    'x     Private Sub dtgTraitements_Init(sender As Object, e As EventArgs) Handles dtgTraitements.Init
    'x         With dtgTraitements
    'x             .DataKeyField = VTL_CONSULTATION.VTL_CONSULTATION_ID
    'x 
    'x 
    'x             With .AddDateColumn("Date", VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
    'x                 m_i_date = .ColumnIndex
    'x             End With
    'x             With .AddNumericColumn("Montant", VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
    'x                 m_i_montant = .ColumnIndex
    'x             End With
    'x             With .AddColumn("Commentaire", VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
    'x                 m_i_comm = .ColumnIndex
    'x             End With
    'x             With .AddColumn("Vétérinaire", "nom_prenom")
    'x                 m_i_veto = .ColumnIndex
    'x             End With
    'x         End With
    'x 
    'x     End Sub
    'x 
    'x #End Region

#Region "Grille Traitements"

#Region "Colonnes de la grille "

    Private m_i_nomMedoc As Integer
    Private m_i_duree_prise As Integer
    Private m_i_Posologie As Integer

    Private m_i_duree_traitmt As Integer
    Private m_i_date_deb As Integer

#End Region

    Private Sub dtgTraitements_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgTraitements.DataTableRequest
        Try
            p_o_dt = Traitement_medicament.GetTraitmtAnimalProprio(SelectedAnimalId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgTraitements_Init(sender As Object, e As EventArgs) Handles dtgTraitements.Init
        With dtgTraitements
            .DataKeyField = VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID

            With .AddDateColumn("Date début prise traitement", VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                m_i_date_deb = .ColumnIndex
            End With
            With .AddColumn("Durée globale du traitement (jours)", VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR)
                m_i_duree_traitmt = .ColumnIndex
            End With

            With .AddColumn("Posologie", VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE)
                m_i_Posologie = .ColumnIndex
            End With

            With .AddColumn("Durée prise du médicament (jours)", VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
                m_i_duree_prise = .ColumnIndex
            End With

            With .AddColumn("Nom médicament", VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE)
                m_i_nomMedoc = .ColumnIndex
            End With
        End With
    End Sub

#End Region

#Region "Grillevaccin"
#Region "Colonnes de la grille"

    Private m_i_btn_vac As Integer
    Private m_i_date_vac As Integer
    Private m_i_vac_eff As Integer
    Private m_i_recommendation As Integer
    Private m_i_period As Integer

#End Region

    Private Sub dtgVaccins_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgVaccins.DataTableRequest
        Try
            p_o_dt = Vaccination.GetVaccinsAnimal(SelectedAnimalId).GetDT()
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgVaccins_Init(sender As Object, e As EventArgs) Handles dtgVaccins.Init
        With dtgVaccins
            .DataKeyField = VTL_VACCINATION.VTL_VACCINATION_ID
          
            With .AddDateColumn("Date", VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)
                m_i_date_vac = .ColumnIndex
            End With
            With .AddColumn("Nom", VTL_VACCIN.VTL_VACCIN_LIBELLE)
                m_i_vac_eff = .ColumnIndex
            End With
            With .AddColumn("Vaccin recommandé", VTL_VACCIN.VTL_VACCIN_TOP_RECOMMANDATION)
                m_i_recommendation = .ColumnIndex
            End With
            With .AddColumn("Vaccin périodique", VTL_VACCIN.VTL_VACCIN_TOP_PERIODIQUE)
                m_i_period = .ColumnIndex
            End With
        End With
    End Sub

#End Region



End Class
