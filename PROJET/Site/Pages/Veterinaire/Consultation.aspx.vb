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
        Else
            btnSave.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' Chargement des combo box / listes déroulantes.
    ''' </summary>
    Private Sub LoadCbo()
        BindCbo(cboVeterinaire, Veterinaire.GetIdNomPrenomVetos.GetDS, VTL_VETERINAIRE.VTL_VETERINAIRE_ID, "nom_prenom", "Sélectionner...")
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
        Else
            'on pré-remplit les infos d'une nouvelle consultation
            cboVeterinaire.SelectedValue = CStr(Veterinaire.GetIdVetoConnectedUser(User.Identity.Name))
            dtbDate.Date = Now.Date
        End If
    End Sub

#End Region

#Region "Boutons"

    ''' <summary>
    ''' Enregsitrement d'une consultation.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim l_o_consult As New Consultation

        Try
            With l_o_consult
                .Dt_Consultation = dtbDate.Date
                .Commentaire = txtComment.Text
                .Montant = ntbMontant.Value
                .Id_veterinaire = CInt(cboVeterinaire.SelectedValue)
                .Id_animal = SelectedAnimalId
                .Save()
            End With
            ShowInfo("Enregistrement effectué avec succès.")
            ModeAcces = EN_ModeAcces.Modification
            LoadData()
            LoadElementsVisibles()
            ClientRegisterRefreshWindow("tabAnimal" & SelectedAnimalId, "refreshGrilleConsult")
            CloseWindowOnLoad()
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
