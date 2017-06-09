Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageTraitement
    Inherits CwPage

#Region "Propriétés et variables privées"

#Region "traitement"
    Private m_o_traitement As Traitrement

    ''' <summary>
    ''' Contient le traitement consultée
    ''' </summary>
    ''' <value>Traitement</value>
    ''' <returns>Traitement</returns>
    Private ReadOnly Property SelectedTraitement As Traitrement
        Get
            If m_o_traitement Is Nothing OrElse (SelectedTraitementId <> m_o_traitement.ID) Then
                If SelectedTraitementId <> 0 Then
                    m_o_traitement = New Traitrement(SelectedTraitementId)
                Else
                    m_o_traitement = New Traitrement()
                End If
            End If
            Return m_o_traitement
        End Get
    End Property

    ''' <summary>
    ''' Contient l'ID du traitement consulté
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID du traitement consulté</returns>
    Private Property SelectedTraitementId As Integer
        Get
            Return CInt(ViewState("SelectedTraitementId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedTraitementId") = p_i_value
        End Set
    End Property
#End Region

#Region "Mode d'accès"

    Private Property ModeAcces As EN_ModeAcces
        Get
            Return CType(ViewState("ModeAcces"), EN_ModeAcces)
        End Get
        Set(p_o_value As EN_ModeAcces)
            ViewState("ModeAcces") = p_o_value
        End Set
    End Property

#End Region

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
            ' Récupération des paramètres
            ModeAcces = CType(Request.QueryString("Mode"), EN_ModeAcces)
            If ModeAcces = EN_ModeAcces.Modification Then
                'recupere le traitement dans l'url
                SelectedTraitementId = CInt(Request.QueryString("ID"))
                Title = "Traitement"
            ElseIf ModeAcces = EN_ModeAcces.Creation Then
                Title = "Nouveau Traitement"
            End If
            'Chargement listes déroulantes
            LoadCbo()
            dtgMedicament.RefreshData()
        End If
    End Sub

    ''' <summary>
    ''' Chargement des combo box / listes déroulantes.
    ''' </summary>
    Private Sub LoadCbo()
        BindCbo(cboMedoc, Medicament.GetAll.GetDS, VTL_MEDICAMENT.VTL_MEDICAMENT_ID, VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE, "Sélectionner...")
    End Sub

#End Region

#Region "Bouton"

    Private Sub btnNewMedoc_Click(sender As Object, e As EventArgs) Handles btnNewMedoc.Click
        Dim l_o_cslMedoc As New Traitement_medicament

        Try
            ValidationManager.Validate(ntbDuree, ntbPosologie)
            With l_o_cslMedoc
                .Duree_jour = CIntVal(ntbDuree.Text)
                .Posologie = CIntVal(ntbPosologie.Text)
                .Id_traitement = SelectedTraitementId
                .Id_medicament = CInt(cboMedoc.SelectedValue)
                .Save()
            End With
            ShowInfo("Enregistrement effectué avec succès.")
            dtgMedicament.RefreshData()
            ntbDuree.Text = ""
            ntbPosologie.Text = ""
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "Grille"

#Region "Colonnes de la grille "

    Private m_i_btn_traitmt_medoc As Integer
    Private m_i_date_deb As Integer
    Private m_i_nom_medoc As Integer
    Private m_i_duree_medoc As Integer
    Private m_i_posologie As Integer

#End Region

    Private Sub dtgMedicament_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgMedicament.DataTableRequest
        Try
            p_o_dt = Traitement_medicament.GetTraitmtAnimal(SelectedTraitementId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgMedicament_UpdateCommand(sender As Object, e As DataGridCommandEventArgs, ByRef refresh As Boolean) Handles dtgMedicament.UpdateCommand
        Dim l_o_tt_medoc As New Traitement_medicament
        Try
            l_o_tt_medoc.Load(CInt(dtgMedicament.DataKeys(e.Item.ItemIndex()))) ' On charge le médicament qui est modifié
            With l_o_tt_medoc
                .Duree_jour = CInt(dtgMedicament.Values(m_i_duree_medoc, e.Item))  ' On enregistre le nom modifié
                .Posologie = CInt(dtgMedicament.Values(m_i_posologie, e.Item))
                .Save()
            End With
        Catch ex As Exception
            ' Si la modification échoue, on ne rafraichit pas la grille pour que l'utilisateur n'ai pas à saisir à nouveau des infos
            refresh = False
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgMedicament_Init(sender As Object, e As EventArgs) Handles dtgMedicament.Init
        With dtgMedicament
            .DataKeyField = VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID
            'x With .AddButtonColumn()
            'x     .Width = Unit.Pixel(65) ' fixe la taille de la colonne
            'x     .DataNavigateUrlFormatString = "~/Pages/Veterinaire/Traitement.aspx?Mode=" & EN_ModeAcces.Modification & "&ID={0}"
            'x     .DataNavigateUrlField = VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID
            'x     .Target = "tabTraitement_Medoc" + VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID
            'x     .Properties.ImageName = "search"
            'x     m_i_btn_traitmt_medoc = .ColumnIndex
            'x End With
            With .AddDateColumn("Date début", VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                m_i_date_deb = .ColumnIndex
            End With
            With .AddColumn("Médicament", VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE)
                m_i_nom_medoc = .ColumnIndex
            End With
            With .AddColumn("Durée", VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
                m_i_duree_medoc = .ColumnIndex
            End With
            With .AddColumn("Posologie", VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE)
                m_i_posologie = .ColumnIndex
            End With
            .AddActionColumn()
        End With
    End Sub

#End Region


End Class
