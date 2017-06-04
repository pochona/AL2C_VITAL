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
                SelectedConsultationId = CInt(Request.QueryString("ID"))
            End If
            LoadCbo()
            LoadData()
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

End Class
