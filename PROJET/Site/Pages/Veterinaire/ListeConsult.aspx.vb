Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageListeConsult
    Inherits CwPage

#Region "propriétés et variables privées"

#Region "Vétérinaire"

    Private m_o_veto As Veterinaire

    ''' <summary>
    ''' Contient l'Animal consultée
    ''' </summary>
    ''' <value>Animal</value>
    ''' <returns>Animal</returns>
    Private ReadOnly Property SelectedVeto As Veterinaire
        Get
            If m_o_veto Is Nothing OrElse (SelectedVetoId <> m_o_veto.ID) Then
                If SelectedVetoId <> 0 Then
                    m_o_veto = New Veterinaire(SelectedVetoId)
                Else
                    m_o_veto = New Veterinaire()
                End If
            End If
            Return m_o_veto
        End Get
    End Property

    ''' <summary>
    ''' Contient l'ID de l'SelectedVeto consultée
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID d'une SelectedVeto</returns>
    Private Property SelectedVetoId As Integer
        Get
            Return CInt(ViewState("SelectedVetoId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedVetoId") = p_i_value
        End Set
    End Property

#End Region

#Region "consultation"

    Private m_o_consultation As Consultation

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
            'recupere l'veto dans l'url
            SelectedVetoId = CInt(Request.QueryString("ID"))

            grdHistorique.RefreshData()
            'chargement des données
            LoadData()
        End If
    End Sub

#End Region

#Region "Colonnes de la grille "

    Private m_i_btn As Integer
    Private m_i_animal As Integer
    Private m_i_date As Integer
    Private m_i_nom As Integer
    Private m_i_montant As Integer
    Private m_i_puce As Integer

#End Region

#Region "Chargement grille"

    Private Sub grdHistorique_Init(sender As Object, e As EventArgs) Handles grdHistorique.Init
        With grdHistorique
            .DataKeyField = VTL_CONSULTATION.VTL_CONSULTATION_ID

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Veterinaire/Consultation.aspx?Mode=" & EN_ModeAcces.Modification & "&ID={0}" & "&NoAnml=true"
                .DataNavigateUrlField = VTL_CONSULTATION.VTL_CONSULTATION_ID
                .Target = "tabConsult" + VTL_CONSULTATION.VTL_CONSULTATION_ID
                .Properties.ImageName = "search"
                m_i_btn = .ColumnIndex
            End With

            With .AddDateColumn("Date", VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                m_i_date = .ColumnIndex
            End With
            With .AddColumn("Nom animal", VTL_ANIMAL.VTL_ANIMAL_NOM)
                m_i_animal = .ColumnIndex
            End With
            With .AddColumn("Puce animal", VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE)
                m_i_puce = .ColumnIndex
            End With
            With .AddColumn("Commentaire", VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
                m_i_nom = .ColumnIndex
            End With
            With .AddNumericColumn("Montant", VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
                m_i_montant = .ColumnIndex
            End With
        End With

    End Sub

    Private Sub grdHistorique_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles grdHistorique.DataTableRequest
        Try
            ' GetContacts est une requête qui permet de sélectionner les données qui apparaitrons dans la grille
            p_o_dt = Consultation.SearchedConsultVeto(SelectedVetoId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "Chargement données formulaire"

    Private Sub LoadData()
        'Si il y a bien un id d'animal passé en param dans URL 
        If SelectedVetoId <> 0 Then
            'on récupère la derniere consultation
            SelectedConsultationId = SelectedVeto.GetLastConsult()
            dtbDate.Date = NzDate(SelectedConsultation.GetDateConsultation())
            txtNomProprio.Text = SelectedConsultation.GetNomProprio()
            txtNomAnimal.Text = SelectedConsultation.GetNomAnimal()
            txtPuceAnimal.Text = SelectedConsultation.GetPuceAnimal()
            txtCommentaire.Text = SelectedConsultation.GetCommentaireConsultation()
            ntbMontant.Value = NzDbl(SelectedConsultation.Montant)
        End If
    End Sub

    Private Sub LoadElementsVisibles()

    End Sub

#End Region

End Class