Imports VITAL.BO.VITAL
Imports VITAL.BO

''' <summary>
''' Informations de l'animal vue par un propriétaire.
''' </summary>
Partial Public Class PageAccueilAnimal
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
            'recupere l'animal dans l'url
            SelectedAnimalId = CInt(Request.QueryString("ID"))
            Title = SelectedAnimal.Nom
            'chargement listes déroulantes
            LoadCbo()
            'chargement des données
            LoadData()
            'définition des éléments visibles
            LoadElementsVisibles()
            'définition des url des boutons redirecteurs
            LoadLien()
        End If
    End Sub

    ''' <summary>
    ''' Chargement des liens vers d'autres page depuis des boutons.
    ''' </summary>
    Private Sub LoadLien()
        btnNewCarte.NavigateUrl = "~/Pages/Veterinaire/NewCarte.aspx?ID=" & SelectedAnimalId
        btnNewCarte.Target = "Modal#400x400"
    End Sub

    ''' <summary>
    ''' Chargement des combo box / listes déroulantes.
    ''' </summary>
    Private Sub LoadCbo()
        BindCbo(cboType, Type.GetAll.GetDS, VTL_TYPE.VTL_TYPE_ID, VTL_TYPE.VTL_TYPE_LIBELLE, "Sélectionner...")
        BindCbo(cboRace, Race.GetAll.GetDS, VTL_RACE.VTL_RACE_ID, VTL_RACE.VTL_RACE_NOM, "Sélectionner...")
        BindCbo(cboNumCarte, Carte.GetAll.GetDS, VTL_CARTE.VTL_CARTE_ID, VTL_CARTE.VTL_CARTE_NUMERO, "Sélectionner...")
    End Sub

    ''' <summary>
    ''' Défini les éléments visibles sur la page.
    ''' </summary>
    Private Sub LoadElementsVisibles()
        'Boutons
        btnSaveInfoAnml.Visible = False
        btnNewCarte.Visible = False
        btnModifierInfoAnml.Visible = True
        'Elements modifiables
        txtNom.Enabled = False
        ntbPoids.Enabled = False
        ntbTaille.Enabled = False
        txtNumPuce.Enabled = False
        cboNumCarte.Enabled = False
        dtbNaiss.Enabled = False
        dtbDeces.Enabled = False
        cboType.Enabled = False
        cboRace.Enabled = False
        stbProprio.Enabled = False
    End Sub

    ''' <summary>
    ''' Chargement des données de l'animal.
    ''' </summary>
    Private Sub LoadData()
        'Si il y a bien un id d'animal passé en param dans URL
        If SelectedAnimalId <> 0 Then
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
            cboNumCarte.SelectedValue = CStr(SelectedAnimal.Id_carte)
            stbProprio.Text = SelectedAnimal.GetNomPrenomProprio()
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
            l_s_parts = Split(e.Argument, "||")
            LoadCbo()
            cboNumCarte.SelectedValue = l_s_parts(1)
            ShowInfo("Enregistrement effectué avec succès!")
        End If
    End Sub

    ''' <summary>
    ''' Permet de remplir le champ Proprio automatiquemetn.
    ''' Se produit lorsque le contenu de la zone de texte change entre des publications sur le serveur
    ''' </summary>
    ''' <param name="sender">Instance de classe source de l'évènement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub stbProprio_TextChanged(sender As Object, e As EventArgs) Handles stbProprio.TextChanged
        Dim l_o_user As New User
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
                    If BO.VITAL.User.Exists(CInt(stbProprio.Text)) = True Then
                        l_o_user.Load(CInt(stbProprio.Text))
                        txtIdPropCache.Text = stbProprio.Text
                        stbProprio.Text = l_o_user.Nom + " " + l_o_user.Prenom
                        ShowInfo("Vous avez sélectionné : " + CStr(l_o_user.Nom + " " + l_o_user.Prenom))
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
    ''' Boutons qui va permettre d'enregistrer les informations de l'animal.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSaveInfoAnml_Click(sender As Object, e As EventArgs) Handles btnSaveInfoAnml.Click
        Dim l_o_animal As New Animal
        Dim l_o_taille As New Histo_Taille
        Dim l_o_poids As New Histo_Poids

        Try
            ValidationManager.Validate(txtNom, txtIdPropCache, cboRace, cboType, ntbPoids, ntbTaille, stbProprio)
            ' Ouverture d'une transcaction
            Using l_o_trans As Transaction = MyDB.GetNewTransaction()
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
                    .Id_carte = CInt(cboNumCarte.SelectedValue)
                    .Save()
                End With
                'on crée des historiques seuleument si c'est différent
                If ntbPoids.Value <> SelectedAnimal.GetLastPoids() Then
                    With l_o_poids
                        .Poids = ntbPoids.Value
                        .Dt_histo = Now.Date
                        .Id_animal = SelectedAnimalId
                        .Save()
                    End With
                End If
                If ntbTaille.Value <> SelectedAnimal.GetLastTaille() Then
                    With l_o_taille
                        .Taille = ntbTaille.Value
                        .Dt_histo = Now.Date
                        .Id_animal = SelectedAnimalId
                        .Save()
                    End With
                End If
                ' On valide la transaction (elle se ferme tout seule grace au "using")
                l_o_trans.Validate()
                LoadElementsVisibles()
                ShowInfo("Enregistrement effectué avec succès.")
            End Using
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Boutons qui va permettre de modifier les infos de l'animal.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnModifierInfoAnml_Click(sender As Object, e As EventArgs) Handles btnModifierInfoAnml.Click
        Try
            txtNom.Enabled = True
            ntbPoids.Enabled = True
            ntbTaille.Enabled = True
            txtNumPuce.Enabled = True
            cboNumCarte.Enabled = True
            dtbNaiss.Enabled = True
            dtbDeces.Enabled = True
            cboType.Enabled = True
            cboRace.Enabled = True
            stbProprio.Enabled = True
            btnSaveInfoAnml.Visible = True
            btnNewCarte.Visible = True
            btnModifierInfoAnml.Visible = False
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
