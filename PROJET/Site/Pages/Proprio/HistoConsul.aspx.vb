Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' Historique des consultations d'un animal.
''' </summary>
Partial Public Class PageHistoConsul
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
        'Récupération de l'animal sélectionné
        SelectedAnimalId = CInt(Request.QueryString("ID"))
        'Chargement des données
        LoadData()
        'Affichage grille consultations
        dtgHistoConsultations.RefreshData()
    End Sub

    ''' <summary>
    ''' Chargement des données.
    ''' </summary>
    Private Sub LoadData()
        Dim l_o_lastConsult As DataRow

        ' On vérifie s'il existe une consultation
        If Consultation.GetConsultationsClient(UserLogin, SelectedAnimalId).GetDT.Rows.Count = 0 Then
            'Si aucunes consultations, on repli le 1er cadre, et on n'affiche pas le second qui contient la grille
            frmLastConsul.Text = "Pas de dernière consultation"
            frmLastConsul.Collapsed = True
            frmHisto.Visible = False
        Else
            'il y a une derniere consultation
            l_o_lastConsult = Consultation.GetConsultationsClient(UserLogin, SelectedAnimalId).GetFirstRow
            ' On renseigne les données
            dtbConsul.Date = NzDate(l_o_lastConsult(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION))
            ntbMontant.Value = NzDbl(l_o_lastConsult(VTL_CONSULTATION.VTL_CONSULTATION_MONTANT))
            txtComm.Text = NzStr(l_o_lastConsult(VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE))
            txtVeto.Text = NzStr(l_o_lastConsult(VTL_VETERINAIRE.VTL_VETERINAIRE_NOM)) + NzStr(l_o_lastConsult(VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM))
            If Consultation.GetConsultationsClient(UserLogin, SelectedAnimalId).GetDT.Rows.Count = 1 Then
                'le pannel historique n'est pas visible
                frmHisto.Visible = False
            End If
        End If

    End Sub

#End Region

#Region "Grille"

#Region "Colonnes de la grille "

    Private m_i_date As Integer
    Private m_i_montant As Integer
    Private m_i_comm As Integer
    Private m_i_veto As Integer

#End Region

    Private Sub dtgHistoConsultations_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgHistoConsultations.DataTableRequest
        Try
            p_o_dt = Consultation.GetConsultationsClient(UserLogin, SelectedAnimalId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgHistoConsultations_Init(sender As Object, e As EventArgs) Handles dtgHistoConsultations.Init
        With dtgHistoConsultations
            .DataKeyField = VTL_CONSULTATION.VTL_CONSULTATION_ID


            With .AddDateColumn("Date", VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                m_i_date = .ColumnIndex
            End With
            With .AddNumericColumn("Montant", VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
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

  
End Class
