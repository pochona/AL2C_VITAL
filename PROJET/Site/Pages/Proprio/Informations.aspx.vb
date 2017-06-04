Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' Informations de l'animal vue par un propriétaire.
''' </summary>
Partial Public Class PageInformations
    Inherits CwPage

#Region "propriétés et variables privées"
    Private m_o_proprio As PropriEtaire
    Private m_o_user As User

    ''' <summary>
    ''' Contient l'Animal consultée
    ''' </summary>
    ''' <value>Animal</value>
    ''' <returns>Animal</returns>
    Private ReadOnly Property SelectedProprio As PropriEtaire
        Get
            m_o_user = New User(BO.VITAL.User.GetIdUser(User.Identity.Name))
            m_o_proprio = New PropriEtaire(PropriEtaire.GetIdProprioByIdUser(m_o_user.ID))
            Return m_o_proprio
        End Get
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

            m_o_proprio = SelectedProprio

            Title = SelectedProprio.ID.ToString


            'chargement des données
            LoadData()
            'définition des éléments visibles
            LoadElementsVisibles()
            'définition des url des boutons redirecteurs
            'LoadLien()
        End If
    End Sub


    ''' <summary>
    ''' Défini les éléments visibles sur la page.
    ''' </summary>
    Private Sub LoadElementsVisibles()
        'Boutons
        btnModif.Visible = True
        btnSave.Visible = False
        'Elements modifiables
        txtNom.Enabled = False
        txtPrenom.Enabled = False
        txtAdresse.Enabled = False
        txtMail.Enabled = False
        txtTelephone.Enabled = False
    End Sub

    ''' <summary>
    ''' Chargement des données de l'animal.
    ''' </summary>
    Private Sub LoadData()
        'Si il y a bien un id d'animal passé en param dans URL
        If SelectedProprio.ID <> 0 Then
            txtNom.Text = SelectedProprio.Nom
            txtPrenom.Text = SelectedProprio.Prenom
            txtAdresse.Text = SelectedProprio.Adr
            txtMail.Text = SelectedProprio.Mail
            txtTelephone.Text = SelectedProprio.Tel
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

        'If e.Argument.Contains("RefreshCarte||") Then
        '    l_s_parts = Split(e.Argument, "||")
        '    cboNumCarte.SelectedValue = l_s_parts(1)
        '    ShowInfo("Enregistrement effectué avec succès!")
        '    upnNumCarte.Update()
        'End If
    End Sub

#End Region

#Region "Boutons"

    ''' <summary>
    ''' Boutons qui va permettre d'enregistrer les informations du proprio.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim l_o_proprio As New PropriEtaire
        Try
            ValidationManager.Validate(txtNom, txtPrenom, txtTelephone, txtAdresse, txtMail)
            With l_o_proprio
                .Load(SelectedProprio.ID)
                .Nom = txtNom.Text
                .Prenom = txtPrenom.Text
                .Tel = txtTelephone.Text
                .Ville = txtAdresse.Text
                .Mail = txtMail.Text
                .Save()
            End With
            LoadElementsVisibles()
            ShowInfo("Enregistrement effectué avec succès.")
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Boutons qui va permettre de modifier les infos du proprio.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnModifierInfoAnml_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Try
            txtNom.Enabled = True
            txtPrenom.Enabled = True
            txtAdresse.Enabled = True
            txtMail.Enabled = True
            txtTelephone.Enabled = True
            btnModif.Visible = False
            btnSave.Visible = True
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
