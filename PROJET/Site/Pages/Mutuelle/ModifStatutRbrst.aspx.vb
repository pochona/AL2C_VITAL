Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageModifStatutRbrst
    Inherits CwPage

#Region "prop et var prives"

    Private m_o_rbrst As Remboursement

    Private ReadOnly Property SelectedDemande As Remboursement
        Get
            If m_o_rbrst Is Nothing OrElse (SelectedDemandeId <> m_o_rbrst.ID) Then
                If SelectedDemandeId <> 0 Then
                    m_o_rbrst = New Remboursement(SelectedDemandeId)
                Else
                    m_o_rbrst = New Remboursement()
                End If
            End If
            Return m_o_rbrst
        End Get
    End Property

 
    Private Property SelectedDemandeId As Integer
        Get
            Return CInt(ViewState("SelectedDemandeId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedDemandeId") = p_i_value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' recupere le traitement dans l'url
            SelectedDemandeId = CInt(Request.QueryString("Remboursement"))
            Title = "Remboursement"
            LoadData()
            LoadElementsVisible()
        End If
    End Sub

    Private Sub LoadElementsVisible()
        If SelectedDemande.Statut = 2 Then
            btnChgStatut.Visible = False
        Else
            btnChgStatut.Visible = True
        End If
    End Sub

    Private Sub LoadData()
        dtbRbrst.Date = SelectedDemande.Date
        Dim l_o_query As DataRow

        l_o_query = Remboursement.GetRemboursementSelected(SelectedDemandeId).GetFirstRow
        dtbRbrst.Date = SelectedDemande.Date
        CwTextNomClt.Text = NzStr(l_o_query(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM))
        CwTextPrenomClt.Text = NzStr(l_o_query(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM))
        CwTxRbrst.Value = NzDbl(l_o_query(VTL_CONTRAT.VTL_CONTRAT_TXREMB))
        CwMtRemb.Value = NzDbl(l_o_query(VTL_REMBOURSMT.VTL_REMBOURSMT_MONTANT))
        CwTextNomAnimal.Text = NzStr(l_o_query(VTL_ANIMAL.VTL_ANIMAL_NOM))
    End Sub

#Region "Bouton"

    Private Sub btnChgStatut_Click(sender As Object, e As EventArgs) Handles btnChgStatut.Click
        Dim l_o_remboursement As New Remboursement

        Try
            With l_o_remboursement
                .Load(SelectedDemandeId)
                .Statut = 2
                .Save()
                'ferme l'onglet courant
                CloseWindowOnLoad()
                'Rafraîchi l'onglet RemboursementByStatut
                ClientRegisterRefreshWindow("ModifStatutRbrst", "REFRESH")

            End With
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
