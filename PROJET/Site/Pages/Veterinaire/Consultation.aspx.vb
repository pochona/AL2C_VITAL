Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' 
''' </summary>
Partial Public Class PageConsultation
    Inherits CwPage

#Region "Propriétés et variables privées"

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

#Region "Consultation"
    Private m_o_consultation As Consultation

    ''' <summary>
    ''' Contient l'Animal consultée
    ''' </summary>
    ''' <value>Animal</value>
    ''' <returns>Animal</returns>
    Private ReadOnly Property SelectedConsultation As Consultation
        Get
            If m_o_consultation Is Nothing OrElse (SelectedConsultationId <> m_o_consultation.ID) Then
                If SelectedConsultationId <> 0 Then
                    m_o_consultation = New Consultation(SelectedConsultationId)
                Else
                    m_o_consultation = New Consultation()
                End If
            End If
            Return m_o_consultation
        End Get
    End Property

    ''' <summary>
    ''' Contient l'ID de l'Consultation consultée
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID d'une Consultation</returns>
    Private Property SelectedConsultationId As Integer
        Get
            Return CInt(ViewState("SelectedConsultationId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedConsultationId") = p_i_value
        End Set
    End Property

#End Region

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
            'recupere l'animal dans l'url
            SelectedAnimalId = CInt(Request.QueryString("Animal"))
            If ModeAcces = EN_ModeAcces.Modification Then
                'recupere l'animal dans l'url
                SelectedConsultationId = CInt(Request.QueryString("ID"))
                SelectedTraitementId = 0
            End If
            LoadCbo()
            LoadData()
            LoadElementsVisibles()


        End If
    End Sub

    ''' <summary>
    ''' Chargement des elemetns visibles.
    ''' </summary>
    Private Sub LoadElementsVisibles()
        If ModeAcces = EN_ModeAcces.Modification Then
            btnSave.Visible = False
            ntbMontant.Enabled = False
            txtComment.Enabled = False
            cboVeterinaire.Enabled = False
            dtbDate.Enabled = False
            frmTraitements.Visible = True
            frmVaccins.Visible = True
            If SelectedTraitementId <> 0 Then
                frmMedoc.Visible = True

                dtgMedicament.Visible = True
                btnNewTraitmt.Visible = False
                btnSaveTraitmt.Visible = True
                dtgMedicament.RefreshData()
            Else
                dtgMedicament.Visible = False
                btnNewTraitmt.Visible = True
                btnSaveTraitmt.Visible = False
                frmMedoc.Visible = False
            End If

        Else
            btnSave.Visible = True
            frmTraitements.Visible = False
            frmVaccins.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Chargement des combo box / listes déroulantes.
    ''' </summary>
    Private Sub LoadCbo()
        BindCbo(cboVeterinaire, Veterinaire.GetIdNomPrenomVetos.GetDS, VTL_VETERINAIRE.VTL_VETERINAIRE_ID, "nom_prenom", "Sélectionner...")
        BindCbo(CboVaccin, Vaccin.GetAll.GetDS, VTL_VACCIN.VTL_VACCIN_ID, VTL_VACCIN.VTL_VACCIN_LIBELLE, "Sélectionner...")
        BindCbo(cboMedoc, Medicament.GetAll.GetDS, VTL_MEDICAMENT.VTL_MEDICAMENT_ID, VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE, "Sélectionner...")

    End Sub

    ''' <summary>
    ''' Chargement des données.
    ''' </summary>
    Private Sub LoadData()
        If ModeAcces = EN_ModeAcces.Modification Then
            ' On vérif que récup des param dans URL a bien marché
            If SelectedConsultationId <> 0 Then
                'on met les infos de la consultation
                ntbMontant.Value = NzDbl(SelectedConsultation.Montant)
                txtComment.Text = SelectedConsultation.Commentaire
                cboVeterinaire.SelectedValue = CStr(SelectedConsultation.Id_veterinaire)
                dtbDate.Date = SelectedConsultation.Dt_Consultation
            End If
            dttxtNewVaccin.Date = Now.Date
        Else
            'on pré-remplit les infos d'une nouvelle consultation
            cboVeterinaire.SelectedValue = CStr(Veterinaire.GetIdVetoConnectedUser(User.Identity.Name))
            dtbDate.Date = Now.Date
        End If
    End Sub

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

#Region "Boutons"

    ''' <summary>
    ''' Enregsitrement d'une consultation.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim l_o_consult As New Consultation
        Dim l_i_idContrat As Integer

        Try
            Using l_o_trans As Transaction = MyDB.GetNewTransaction()
                With l_o_consult
                    .Dt_Consultation = dtbDate.Date
                    .Commentaire = txtComment.Text
                    .Montant = ntbMontant.Value
                    .Id_veterinaire = CInt(cboVeterinaire.SelectedValue)
                    .Id_animal = SelectedAnimalId
                    .Save(l_o_trans)
                End With
                l_i_idContrat = SelectedAnimal.GetIdContrat()
                If l_i_idContrat <> 0 Then
                    Dim l_o_contrat As New Contrat
                    l_o_contrat.Load(l_i_idContrat)
                    'Création d'un remboursement
                    Dim l_o_rembsrt As New Remboursement
                    With l_o_rembsrt
                        .Date = Now.Date
                        .Consult = l_o_consult.ID
                        .Contrat = l_i_idContrat
                        .Statut = EN_Statut.EnCours
                        '.montant
                        .Montant = NzDbl(l_o_consult.Montant) * NzDbl(l_o_contrat.TxRemb)
                        .Save(l_o_trans)
                    End With
                End If
                ShowInfo("Enregistrement effectué avec succès.")
                ModeAcces = EN_ModeAcces.Modification
                LoadData()
                LoadElementsVisibles()
                ClientRegisterRefreshWindow("tabAnimal" & SelectedAnimalId, "refreshGrilleConsult")

                l_o_trans.Validate()
            End Using

        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute une nouvelle vacination pour l'animal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewVaccin_Click(sender As Object, e As EventArgs) Handles btnNewVaccin.Click
        Dim l_o_cslVaccination As New Vaccination

        Try
            ValidationManager.Validate(dttxtNewVaccin, CboVaccin)
            With l_o_cslVaccination
                .Dt_vaccin = dttxtNewVaccin.Date
                .Id_vaccin = CInt(CboVaccin.SelectedValue)
                .Id_animal = SelectedAnimalId
                .Save()
            End With
            ShowInfo("Vaccination effectuée avec succès.")
            dttxtNewVaccin.Text = ""
            dtgMedicament.RefreshData()
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#Region "Traitement"

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
                LoadElementsVisibles()
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
