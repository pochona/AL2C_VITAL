Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageTraitement
    Inherits CwPage

#Region "Propriétés et variables privées"

#Region "animal"
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
                ' recupere le traitement dans l'url
                SelectedTraitementId = CInt(Request.QueryString("ID"))
                Title = "Traitement"
            ElseIf ModeAcces = EN_ModeAcces.Creation Then
                Title = "Nouveau Traitement"
            End If

            ' recupere l'animal dans l'url
            SelectedAnimalId = CInt(Request.QueryString("Animal"))
            'Chargement listes déroulantes
            LoadCbo()
            'chargement des données
            LoadData()
            LoadElementsVisibles()
            dtgMedicament.RefreshData()
        End If
    End Sub

    Private Sub LoadElementsVisibles()
        If ModeAcces = EN_ModeAcces.Creation Then
            frmMedoc.Visible = False
            btnNewTraitmt.Visible = True
            btnSaveTraitmt.Visible = False
            dtgMedicament.Visible = False

        Else
            frmMedoc.Visible = True
            btnNewTraitmt.Visible = False
            btnSaveTraitmt.Visible = True
            dtgMedicament.Visible = True
        End If
    End Sub

    Private Sub LoadData()
        If ModeAcces = EN_ModeAcces.Creation Then
            dtbTraitmt.Date = Now.Date
        Else
            ntbDureeTraitmt.Value = SelectedTraitement.Duree_jour
            dtbTraitmt.Date = SelectedTraitement.Dt_debut
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

    Private Sub btnNewTraitmt_Click(sender As Object, e As EventArgs) Handles btnNewTraitmt.Click
        Dim l_o_traitmt As New Traitrement

        Try
            ValidationManager.Validate(ntbDureeTraitmt, dtbTraitmt)
            With l_o_traitmt
                .Dt_debut = dtbTraitmt.Date
                .Duree_jour = CInt(ntbDureeTraitmt.Value)
                .Id_animal = SelectedAnimalId
                .Save()
                SelectedTraitementId = .ID
                ModeAcces = EN_ModeAcces.Modification
                LoadElementsVisibles()
                dtgMedicament.RefreshData()
            End With
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub btnSaveTraitmt_Click(sender As Object, e As EventArgs) Handles btnSaveTraitmt.Click
        Dim l_o_traitmt As New Traitrement

        Try
            ValidationManager.Validate(ntbDureeTraitmt, dtbTraitmt)
            With l_o_traitmt
                .Load(SelectedTraitementId)
                .Dt_debut = dtbTraitmt.Date
                .Duree_jour = CInt(ntbDureeTraitmt.Value)
                .Id_animal = SelectedAnimalId
                .Save()
            End With
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub btnNewMedoc_Click(sender As Object, e As EventArgs) Handles btnNewMedoc.Click
        Dim l_o_cslMedoc As New Traitement_medicament

        Try
            ValidationManager.Validate(ntbDuree, txtPosologie)
            With l_o_cslMedoc
                .Duree_jour = CInt(ntbDuree.Text)
                .Posologie = CStr(txtPosologie.Text)
                .Id_traitement = SelectedTraitementId
                .Id_medicament = CInt(cboMedoc.SelectedValue)
                .Save()
            End With
            ShowInfo("Enregistrement effectué avec succès.")
            dtgMedicament.RefreshData()
            ntbDuree.Text = ""
            txtPosologie.Text = ""
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
            p_o_dt = Traitement_medicament.GetTraitmtAnimal(SelectedAnimalId, SelectedTraitementId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgMedicament_UpdateCommand(sender As Object, e As DataGridCommandEventArgs, ByRef refresh As Boolean) Handles dtgMedicament.UpdateCommand
        Dim l_o_tt_medoc As New Traitement_medicament
        Try
            l_o_tt_medoc.Load(CInt(dtgMedicament.DataKeys(e.Item.ItemIndex()))) ' On charge le médicament qui est modifié
            With l_o_tt_medoc

                .Id_medicament = CInt(dtgMedicament.Values(m_i_nom_medoc, e.Item))
                .Duree_jour = CInt(dtgMedicament.Values(m_i_duree_medoc, e.Item))  ' On enregistre le nom modifié
                .Posologie = CStr(dtgMedicament.Values(m_i_posologie, e.Item))
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
         
            With .AddDateColumn("Date début", VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                m_i_date_deb = .ColumnIndex
            End With
            With .AddComboBoxColumn("Médicament", VTL_MEDICAMENT.VTL_MEDICAMENT_ID, VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE) ' défini la source des données de la liste déroulante
                .Properties.DataSource = Medicament.GetAll().GetDS
                .Properties.DataValueField = VTL_MEDICAMENT.VTL_MEDICAMENT_ID ' la clé
                .Properties.DataTextField = VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE ' la valeur
                .Properties.SpecialText = "Sélectionner ..." ' texte affiché par défaut
                m_i_nom_medoc = .ColumnIndex ' stocker le numéro de la colonne 
                '  .CanEdit = False ' empêche la modification
            End With
            With .AddNumericColumn("Durée", VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
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
