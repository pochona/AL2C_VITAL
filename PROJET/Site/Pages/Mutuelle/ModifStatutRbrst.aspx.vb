Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageModifStatutRbrst
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' recupere le traitement dans l'url
        SelectedDemandeId = CInt(Request.QueryString("Remboursement"))
            Title = "Remboursement"

        LoadData()
        LoadElementsVisible()
    End Sub
    'x 
    'x     Private Sub LoadData()
    'x         If ModeAcces = EN_ModeAcces.Creation Then
    'x             dtbTraitmt.Date = Now.Date
    'x         Else
    'x             ntbDureeTraitmt.Value = SelectedDemande.Duree_jour
    'x             dtbTraitmt.Date = SelectedDemande.Dt_debut
    'x         End If
    'x     End Sub

    Private Sub LoadElementsVisible()
        If SelectedDemande.Statut = 2 Then

            btnChgStatut.Visible = True
        Else

            btnChgStatut.Visible = False
        End If
    End Sub

#Region "Formulaire"
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


#End Region


#Region "demande paiement"
    Private m_o_rbrst As Remboursement


    ''' <summary>
    ''' Contient le traitement consultée
    ''' </summary>
    ''' <value>Traitement</value>
    ''' <returns>Traitement</returns>
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

    ''' <summary>
    ''' Contient l'ID du traitement consulté
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID du traitement consulté</returns>
    Private Property SelectedDemandeId As Integer
        Get
            Return CInt(ViewState("SelectedDemandeId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedDemandeId") = p_i_value
        End Set
    End Property
#End Region

#Region "Bouton"
    Private Sub btnChgStatut_Click(sender As Object, e As EventArgs) Handles btnChgStatut.Click
        Dim l_o_remboursement As New Remboursement

        Try
            With l_o_remboursement
                .Load(SelectedDemandeId)
                .Statut = 1
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
