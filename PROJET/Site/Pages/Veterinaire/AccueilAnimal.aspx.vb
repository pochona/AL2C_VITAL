Imports VITAL.BO.VITAL
Imports VITAL.BO

''' <summary>
''' Informations de l'animal vue par un propriétaire.
''' </summary>
Partial Public Class PageAccueilAnimal
    Inherits CwPage

#Region "propriétés et variables privées"

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
                'recupere l'animal dans l'url
                SelectedAnimalId = CInt(Request.QueryString("ID"))
                Title = SelectedAnimal.Nom
            ElseIf ModeAcces = EN_ModeAcces.Creation Then
                Title = "Nouvel animal"
            End If
            'chargement listes déroulantes
            LoadCbo()
            'chargement des données
            LoadData()
            'définition des éléments visibles
            LoadElementsVisibles()
            'définition des url des boutons redirecteurs
            LoadLien()
            LoadGrilles()
        End If
    End Sub

    ''' <summary>
    ''' Refresh des grilles.
    ''' </summary>
    Private Sub LoadGrilles()
        If ModeAcces = EN_ModeAcces.Modification Then
            dtgConsultations.RefreshData()
            dtgDietetiques.RefreshData()
            dtgTraitements.RefreshData()
            dtgVaccins.RefreshData()
        End If
    End Sub

    ''' <summary>
    ''' Chargement des liens vers d'autres page depuis des boutons.
    ''' </summary>
    Private Sub LoadLien()
        If ModeAcces = EN_ModeAcces.Modification Then
            '  btnNewCarte.NavigateUrl = "~/Pages/Veterinaire/NewCarte.aspx?ID=" & SelectedAnimalId
            '  btnNewCarte.Target = "Modal#400x400"
            btnNewConsult.NavigateUrl = "~/Pages/Veterinaire/Consultation.aspx?Mode=" & EN_ModeAcces.Creation & "&Animal=" & SelectedAnimalId
            btnNewConsult.Target = "tabConsult"
            btnNewTraitement.NavigateUrl = "~/Pages/Veterinaire/Traitement.aspx?Mode=" & EN_ModeAcces.Creation & "&Animal=" & SelectedAnimalId
            btnNewTraitement.Target = "tabTraitement"
        End If
    End Sub

    ''' <summary>
    ''' Chargement des combo box / listes déroulantes.
    ''' </summary>
    Private Sub LoadCbo()
        'x         If ModeAcces = EN_ModeAcces.Modification Then
        'x             BindCbo(cboNumCarte, Carte.GetCartesNonAttribuees(SelectedAnimalId).GetDS, VTL_CARTE.VTL_CARTE_ID, VTL_CARTE.VTL_CARTE_NUMERO, "Sélectionner...")
        'x         Else
        'x             BindCbo(cboNumCarte, Carte.GetCartesNonAttribuees().GetDS, VTL_CARTE.VTL_CARTE_ID, VTL_CARTE.VTL_CARTE_NUMERO, "Sélectionner...")
        'x 
        'x             '     BindCbo(cboNumCarte, Carte.GetCarteAnimal(SelectedAnimalId).GetDS, VTL_CARTE.VTL_CARTE_ID, VTL_CARTE.VTL_CARTE_NUMERO, "Sélectionner...")
        'x         End If
        BindCbo(cboType, Type.GetAll.GetDS, VTL_TYPE.VTL_TYPE_ID, VTL_TYPE.VTL_TYPE_LIBELLE, "Sélectionner...")
        BindCbo(cboRace, Race.GetAll.GetDS, VTL_RACE.VTL_RACE_ID, VTL_RACE.VTL_RACE_NOM, "Sélectionner...")
        BindCbo(CboVaccin, Vaccin.GetAll.GetDS, VTL_VACCIN.VTL_VACCIN_ID, VTL_VACCIN.VTL_VACCIN_LIBELLE, "Sélectionner...")
    End Sub

    ''' <summary>
    ''' Défini les éléments visibles sur la page.
    ''' </summary>
    Private Sub LoadElementsVisibles()
        If ModeAcces = EN_ModeAcces.Modification Then
            'Boutons
            btnSaveInfoAnml.Visible = False
            '   btnNewCarte.Visible = False
            btnModifierInfoAnml.Visible = True
            btnNewAnimal.Visible = False
            'Elements modifiables
            txtNom.Enabled = False
            ntbPoids.Enabled = False
            chkCarte.Enabled = False
            ntbTaille.Enabled = False
            txtNumPuce.Enabled = False
            'x  cboNumCarte.Enabled = False
            dtbNaiss.Enabled = False
            dtbDeces.Enabled = False
            cboType.Enabled = False
            cboRace.Enabled = False
            stbProprio.Enabled = False
            'visibilité des frames
            frmNewConsul.Visible = True
            frmListConsult.Visible = True
            frmListTraitements.Visible = True
            frmListVaccins.Visible = True
            frmListConseilDiet.Visible = True
            'x  cboNumCarte.Visible = True
            'x  upnNumCarte.Visible = True
        ElseIf ModeAcces = EN_ModeAcces.Creation Then
            'les autres frames ne sont pas visibles
            frmNewConsul.Visible = False
            frmListConsult.Visible = False
            frmListTraitements.Visible = False
            frmListVaccins.Visible = False
            frmListConseilDiet.Visible = False
            'modifiabilité des éléments
            cboType.Enabled = True
            cboRace.Enabled = True
            stbProprio.Enabled = True
            'Boutons
            btnSaveInfoAnml.Visible = False
            ' btnNewCarte.Visible = False
            btnModifierInfoAnml.Visible = False
            btnNewAnimal.Visible = True
            'x  cboNumCarte.Visible = False
            'x   upnNumCarte.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Chargement des données de l'animal.
    ''' </summary>
    Private Sub LoadData()
        If ModeAcces = EN_ModeAcces.Modification Then
            'Si il y a bien un id d'animal passé en param dans URL
            If SelectedAnimalId <> 0 Then
                'Renomme la page en cours (identifiant de la page non visible)
                ClientRegisterWindowName("tabAnimal" & SelectedAnimalId)
                'Infos
                txtIdPropCache.Text = CStr(SelectedAnimal.Id_prop)
                txtNom.Text = SelectedAnimal.Nom
                txtNumPuce.Text = SelectedAnimal.Num_puce
                dtbNaiss.Date = SelectedAnimal.Dt_naissance
                dtbDeces.Date = SelectedAnimal.Dt_deces
                ntbPoids.Value = SelectedAnimal.GetLastPoids()
                ntbTaille.Value = SelectedAnimal.GetLastTaille()
                ntbAge.Value = DateDiff(DateInterval.Year, SelectedAnimal.Dt_naissance, Now.Date)
                cboType.SelectedValue = CStr(SelectedAnimal.Id_type)
                cboRace.SelectedValue = CStr(SelectedAnimal.Id_race)
                txtCarte.Text = SelectedAnimal.GetNumCarteVit
                'x   cboNumCarte.SelectedValue = CStr(SelectedAnimal.Id_carte)
                stbProprio.Text = SelectedAnimal.GetNomPrenomProprio()
                dttxtNewVaccin.Date = Now.Date
            End If
        ElseIf ModeAcces = EN_ModeAcces.Creation Then

        End If
    End Sub

#End Region

#Region "Evenements"

    ''' <summary>
    ''' Evènement se déclenchant lors d'une demande de rafraichissement de la page.
    ''' </summary>
    ''' <param name="Sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub PageAccueilAnimal_Refresh(Sender As Object, e As Corail.Web.RefreshEventArg) Handles Me.Refresh
        Dim l_s_parts As String()

        If e.Argument.Contains("RefreshCarte||") Then
            'x  l_s_parts = Split(e.Argument, "||")
            'x  LoadCbo()
            'x cboNumCarte.SelectedValue = l_s_parts(1)
            'x ShowInfo("Enregistrement effectué avec succès!")
            'xupnNumCarte.Update()
        End If
        ' Récupérer l'argument envoyé par la page qui déclenche de rafraichissement
        If e.Argument.Contains("refreshGrilleConsult") Then
            dtgConsultations.RefreshData()
        End If

        ' Récupérer l'argument envoyé par la page qui déclenche de rafraichissement
        If e.Argument.Contains("refreshGrilleTraitement") Then
            dtgTraitements.RefreshData()
        End If
        ' Récupérer l'argument envoyé par la page qui déclenche de rafraichissement
        If e.Argument.Contains("refreshGrilleVaccins") Then
            dtgVaccins.RefreshData()
        End If
    End Sub

    ''' <summary>
    ''' Permet de remplir le champ Proprio automatiquemetn.
    ''' Se produit lorsque le contenu de la zone de texte change entre des publications sur le serveur
    ''' </summary>
    ''' <param name="sender">Instance de classe source de l'évènement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub stbProprio_TextChanged(sender As Object, e As EventArgs) Handles stbProprio.TextChanged
        Dim l_o_prop As New PropriEtaire
        Dim l_i_count As Integer = 0
        Dim l_b_allNumber As Boolean = True
        Dim l_s_tempCaract As String
        Dim l_b_number As Boolean = False

        Try
            If stbProprio.Text <> "" Then
                'On vérifie que c'est bien numérique 
                While l_i_count < stbProprio.Text.Count And l_b_allNumber = True
                    l_b_number = False
                    l_s_tempCaract = stbProprio.Text.Substring(l_i_count, 1)
                    ' On vérifie que c'est bien numérique
                    Select Case l_s_tempCaract
                        Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                            l_b_number = True
                    End Select
                    If l_b_number = False Then
                        l_b_allNumber = False
                    End If
                    ' on incrémente
                    l_i_count = l_i_count + 1
                End While
                'Si c'est bien numérique
                If l_b_allNumber = True Then
                    'On vérifie qu'il existe un user correspondant
                    If PropriEtaire.ExistsV2(CInt(stbProprio.Text)) = True Then
                        l_o_prop.Load(CInt(stbProprio.Text))
                        txtIdPropCache.Text = stbProprio.Text
                        stbProprio.Text = l_o_prop.Nom + " " + l_o_prop.Prenom
                        ShowInfo("Vous avez sélectionné : " + CStr(l_o_prop.Nom + " " + l_o_prop.Prenom))
                    End If
                Else
                    ShowInfo("Pour sélectionner un propriétaire, veuillez cliquer sur le bouton à droite de la zone.")
                    stbProprio.Text = ""
                End If
            End If
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "Boutons"

    ''' <summary>
    ''' Création d'un nouvel animal.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnNewAnimal_Click(sender As Object, e As EventArgs) Handles btnNewAnimal.Click
        Dim l_o_animal As New Animal
        Dim l_o_taille As New Histo_Taille
        Dim l_o_poids As New Histo_Poids
        Dim l_o_carte As New Carte

        Try
            ValidationManager.Validate(txtNom, txtIdPropCache, cboRace, cboType, ntbPoids, ntbTaille, stbProprio)
            ' Ouverture d'une transcaction
            Using l_o_trans As Transaction = MyDB.GetNewTransaction()

                If chkCarte.checked = True Then
                    With l_o_carte
                        .Numero = Guid.NewGuid().ToString
                        .Nfc = Guid.NewGuid().ToString
                        .Save(l_o_trans)
                    End With
                End If
                With l_o_animal
                    .Nom = txtNom.Text
                    .Num_puce = txtNumPuce.Text
                    .Dt_deces = dtbDeces.Date
                    .Dt_naissance = dtbNaiss.Date
                    .Id_prop = CInt(txtIdPropCache.Text)
                    .Id_race = CInt(cboRace.SelectedValue)
                    .Id_type = CInt(cboType.SelectedValue)
                    If chkCarte.Checked = True Then
                        .Id_carte = l_o_carte.ID
                    End If
                    ' .Id_carte = CInt(cboNumCarte.SelectedValue)
                    .Save(l_o_trans)
                End With
                With l_o_poids
                    .Poids = NzDbl(ntbPoids.Value)
                    .Dt_histo = Now.Date
                    .Id_animal = l_o_animal.ID
                    .Save(l_o_trans)
                End With
                With l_o_taille
                    .Taille = NzDbl(ntbTaille.Value)
                    .Dt_histo = Now.Date
                    .Id_animal = l_o_animal.ID
                    .Save(l_o_trans)
                End With
                ' On valide la transaction (elle se ferme tout seule grace au "using")
                l_o_trans.Validate()
                SelectedAnimalId = l_o_animal.ID
                Title = SelectedAnimal.Nom
                ModeAcces = EN_ModeAcces.Modification
                'manque recharger
                LoadElementsVisibles()
                LoadLien()
                LoadGrilles()
                LoadData()
                ShowInfo("Enregistrement effectué avec succès.")
            End Using
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Boutons qui va permettre d'enregistrer les informations de l'animal.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSaveInfoAnml_Click(sender As Object, e As EventArgs) Handles btnSaveInfoAnml.Click
        Dim l_o_animal As New Animal
        Dim l_o_taille As New Histo_Taille
        Dim l_o_poids As New Histo_Poids
        Dim l_o_carte As New Carte

        Try
            ValidationManager.Validate(txtNom, txtIdPropCache, cboRace, cboType, ntbPoids, ntbTaille, stbProprio)
            ' Ouverture d'une transcaction
            Using l_o_trans As Transaction = MyDB.GetNewTransaction()
                If chkCarte.Checked = True Then
                    With l_o_carte
                        .Numero = Guid.NewGuid().ToString
                        .Nfc = Guid.NewGuid().ToString
                        .Save(l_o_trans)
                    End With
                End If
                ' Traitements
                With l_o_animal
                    .Load(SelectedAnimalId)
                    .Nom = txtNom.Text
                    .Num_puce = txtNumPuce.Text
                    .Dt_deces = dtbDeces.Date
                    .Dt_naissance = dtbNaiss.Date
                    .Id_prop = CInt(txtIdPropCache.Text)
                    .Id_race = CInt(cboRace.SelectedValue)
                    .Id_type = CInt(cboType.SelectedValue)
                    If chkCarte.Checked = True Then
                        .Id_carte = l_o_carte.ID
                        'x ElseIf CInt(cboNumCarte.SelectedValue) <> 0 Then
                        'x    .Id_carte = CInt(cboNumCarte.SelectedValue)
                    End If
                    .Save(l_o_trans)
                End With
                'on crée des historiques seuleument si c'est différent
                'x If ntbPoids.Value <> SelectedAnimal.GetLastPoids() Then
                With l_o_poids
                    .Poids = ntbPoids.Value
                    .Dt_histo = Now.Date
                    .Id_animal = SelectedAnimalId
                    .Save(l_o_trans)
                End With
                'x End If
                'x  If ntbTaille.Value <> SelectedAnimal.GetLastTaille() Then
                With l_o_taille
                    .Taille = ntbTaille.Value
                    .Dt_histo = Now.Date
                    .Id_animal = SelectedAnimalId
                    .Save(l_o_trans)
                End With
                'x  End If
                ' On valide la transaction (elle se ferme tout seule grace au "using")
                l_o_trans.Validate()
                If chkCarte.Checked = True Then
                    txtCarte.Text = SelectedAnimal.GetNumCarteVit
                End If

                LoadElementsVisibles()
                ShowInfo("Enregistrement effectué avec succès.")
            End Using
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub
    'x <cw:CwUpdatePanel runat="server" ID="upnNumCarte" UpdateMode="Conditional"  >
    'x                         <ContentTemplate>
    'x                             <cw:CwFormLayout runat="server" ID="frlNumCarte">
    'x                                 <cw:CwComboBox runat="server" ID="cboNumCarte" Label="Numéro de carte vitale" PostBackMode="Full"  AutoPostBack="True"></cw:CwComboBox> 
    'x                             </cw:CwFormLayout>
    'x                         </ContentTemplate>
    'x                     </cw:CwUpdatePanel>

    'x   <cw:CwButton runat="server" ImageName="sq-plus-all" ID="btnNewCarte" Text="Créer une nouvelle carte"></cw:CwButton>

    ''' <summary>
    ''' Boutons qui va permettre de modifier les infos de l'animal.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnModifierInfoAnml_Click(sender As Object, e As EventArgs) Handles btnModifierInfoAnml.Click
        Try
            txtNom.Enabled = True
            ntbPoids.Enabled = True

            chkCarte.Enabled = True
            ntbTaille.Enabled = True
            txtNumPuce.Enabled = True
            'x cboNumCarte.Enabled = True
            dtbNaiss.Enabled = True
            dtbDeces.Enabled = True
            cboType.Enabled = True
            cboRace.Enabled = True
            stbProprio.Enabled = True
            btnSaveInfoAnml.Visible = True
            '   btnNewCarte.Visible = True
            btnModifierInfoAnml.Visible = False
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Nouveau conseil diététique.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnNewConseil_Click(sender As Object, e As EventArgs) Handles btnNewConseil.Click
        Dim l_o_cslDiet As New ConseilDietetique

        Try
            With l_o_cslDiet
                .Date = Now.Date
                .Contenu = txtNewConseil.Text
                .Id_animal = SelectedAnimalId
                .Save()
            End With
            ShowInfo("Enregistrement effectué avec succès.")
            dtgDietetiques.RefreshData()
            txtNewConseil.Text = ""
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    'x     ''' <summary>
    'x     ''' Nouveau Traitement
    'x     ''' </summary>
    'x     ''' <param name="sender"></param>
    'x     ''' <param name="e"></param>
    'x     ''' <remarks></remarks>
    'x     Private Sub btnNewTraitement_Click(sender As Object, e As EventArgs) Handles btnNewTraitement.Click
    'x         Dim l_o_traitement As New Traitrement
    'x 
    'x         Try
    'x             ValidationManager.Validate(dtbNewTraitement, ntbNewTraitement)
    'x             With l_o_traitement
    'x                 .Duree_jour = CIntVal(ntbNewTraitement.Text)
    'x                 .Dt_debut = dtbNewTraitement.Date
    'x                 .Id_animal = SelectedAnimalId
    'x                 .Save()
    'x             End With
    'x             ShowInfo("Enregistrement effectué avec succès.")
    'x             dtgTraitements.RefreshData()
    'x             ntbNewTraitement.Text = ""
    'x             dtbNewTraitement.Date = Now.Date
    'x         Catch ex As Exception
    'x             ShowException(ex)
    'x         End Try
    'x     End Sub

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
            ShowInfo("Enregistrement effectué avec succès.")
            dtgVaccins.RefreshData()
            dttxtNewVaccin.Text = ""
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "Grille"

#Region "Grille consultation"

#Region "Colonnes de la grille "

    Private m_i_date As Integer
    Private m_i_montant As Integer
    Private m_i_comm As Integer
    Private m_i_veto As Integer
    Private m_i_btn As Integer

#End Region

    Private Sub dtgConsultations_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgConsultations.DataTableRequest
        Try
            p_o_dt = Consultation.GetConsultationsAnimal(SelectedAnimalId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgConsultations_Init(sender As Object, e As EventArgs) Handles dtgConsultations.Init
        With dtgConsultations
            .DataKeyField = VTL_CONSULTATION.VTL_CONSULTATION_ID

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Veterinaire/Consultation.aspx?Mode=" & EN_ModeAcces.Modification & "&ID={0}" & "&Animal=" & CInt(Request.QueryString("ID"))
                .DataNavigateUrlField = VTL_CONSULTATION.VTL_CONSULTATION_ID
                .Target = "tabConsult" + VTL_CONSULTATION.VTL_CONSULTATION_ID
                .Properties.ImageName = "search"
                m_i_btn = .ColumnIndex
            End With
            With .AddDateColumn("Date", VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                m_i_date = .ColumnIndex
            End With
            With .AddNumericColumn("Montant (€)", VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
                m_i_montant = .ColumnIndex
            End With
            With .AddColumn("Commentaire", VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
                m_i_comm = .ColumnIndex
            End With
            With .AddColumn("Vétérinaire", "nom_prenom")
                m_i_veto = .ColumnIndex
            End With
        End With

    End Sub

#End Region

#Region "Grille conseils diététiques"

#Region "Colonnes de la grille "

    Private m_i_btn2 As Integer
    Private m_i_date2 As Integer
    Private m_i_content As Integer

#End Region

    Private Sub dtgDietetiques_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgDietetiques.DataTableRequest
        Try
            p_o_dt = ConseilDietetique.GetConseilsAnimal(SelectedAnimalId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgDietetiques_Init(sender As Object, e As EventArgs) Handles dtgDietetiques.Init
        With dtgDietetiques
            .DataKeyField = VTL_CNSLDIET.CNSLDIET_ID

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Veterinaire/ConseilDiet.aspx?Mode=" & EN_ModeAcces.Modification & "&ID={0}"
                .DataNavigateUrlField = VTL_CNSLDIET.CNSLDIET_ID
                .Target = "tabConseilDiet" + VTL_CNSLDIET.CNSLDIET_ID
                .Properties.ImageName = "search"
                m_i_btn2 = .ColumnIndex
            End With
            With .AddDateColumn("Date", VTL_CNSLDIET.CNSLDIET_DATE)
                m_i_date2 = .ColumnIndex
            End With
            With .AddColumn("Conseil", VTL_CNSLDIET.CNSLDIET_CONTENU)
                m_i_content = .ColumnIndex
            End With
        End With

    End Sub

#End Region

#Region "Grille Traitements"

#Region "Colonnes de la grille "

    Private m_i_btn_traitmt As Integer
    Private m_i_duree_traitmt As Integer
    Private m_i_date_deb As Integer

#End Region

    Private Sub dtgTraitements_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgTraitements.DataTableRequest
        Try
            p_o_dt = Traitrement.GetTraitmtAnimal(SelectedAnimalId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgTraitements_Init(sender As Object, e As EventArgs) Handles dtgTraitements.Init
        With dtgTraitements
            .DataKeyField = VTL_TRAITREMENT.VTL_TRAITREMENT_ID

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Veterinaire/Traitement.aspx?ID={0}" & "&Mode=" & EN_ModeAcces.Modification & "&Animal=" & CInt(Request.QueryString("ID"))
                .DataNavigateUrlField = VTL_TRAITREMENT.VTL_TRAITREMENT_ID
                .Target = "tabTraitement" + VTL_TRAITREMENT.VTL_TRAITREMENT_ID
                .Properties.ImageName = "search"
                m_i_btn_traitmt = .ColumnIndex
            End With
            With .AddDateColumn("Date début", VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                m_i_date_deb = .ColumnIndex
            End With
            With .AddColumn("Durée globale du traitement", VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR)
                m_i_duree_traitmt = .ColumnIndex
            End With
        End With
    End Sub

#End Region

#Region "Grille Vaccins"

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
            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Veterinaire/Vaccin.aspx?Mode=" & EN_ModeAcces.Modification & "&ID={0}" & "&Animal=" & SelectedAnimalId
                .DataNavigateUrlField = VTL_VACCINATION.VTL_VACCINATION_ID
                .Target = "tabVaccin" + VTL_VACCINATION.VTL_VACCINATION_ID
                .Properties.ImageName = "search"
                m_i_btn = .ColumnIndex
            End With
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

#End Region

End Class
