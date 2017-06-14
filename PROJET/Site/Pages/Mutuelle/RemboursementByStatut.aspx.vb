
Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageRemboursementByStatut
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'chargement des données
        grdtestmutu.RefreshData()
        ClientRegisterWindowName("ModifStatutRbrst")
    End Sub

    Private Sub PageDetailIRD_PartB_Refresh(Sender As Object, e As RefreshEventArg) Handles Me.Refresh
        ' Récupérer l'argument envoyé par la page qui déclenche de rafraichissement
        If e.Argument = "REFRESH" Then
            grdtestmutu.RefreshData()
            ShowInfo("Le statut du remboursement à bien été modifié !")
        End If
    End Sub


#Region "Chargement grille"
    Private m_i_date_mutu As Integer
    Private m_i_contrat As Integer
    Private m_i_montant As Integer
    Private m_i_btn_rembrst As Integer
    Private m_i_txremb_mutu As Integer
    Private m_i_nomProp As Integer
    Private m_i_nom_animal_mutu As Integer



    Private Sub grdtestmutu_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles grdtestmutu.DataTableRequest
        'Variable pour les BTNRadio Statut
        Dim l_i_statut As Integer = 0
        Try
            'On lui affecte la valeur seuleument si une case est cochée, comme ça, ça ne plante pas
            If rblStatut.SelectedItem IsNot Nothing Then l_i_statut = CInt(rblStatut.SelectedItem.Value)
            p_o_dt = Remboursement.GetRemboursementStatut(l_i_statut).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub grdtestmutu_Init(sender As Object, e As EventArgs) Handles grdtestmutu.Init
        With grdtestmutu
            .DataKeyField = VTL_REMBOURSMT.VTL_REMBOURSMT_ID

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Mutuelle/ModifStatutRbrst.aspx?Remboursement={0}"
                .DataNavigateUrlField = VTL_REMBOURSMT.VTL_REMBOURSMT_ID
                .Target = "tabRembrst{0}" + VTL_REMBOURSMT.VTL_REMBOURSMT_ID
                .Properties.ImageName = "search"
                m_i_btn_rembrst = .ColumnIndex
            End With
            With .AddDateColumn(" Date", VTL_REMBOURSMT.VTL_REMBOURSMT_DATE)
                m_i_date_mutu = .ColumnIndex
            End With
            With .AddNumericColumn(" Taux de remboursement", VTL_CONTRAT.VTL_CONTRAT_TXREMB, , 2)
                m_i_txremb_mutu = .ColumnIndex
            End With
            With .AddNumericColumn(" Montant", VTL_REMBOURSMT.VTL_REMBOURSMT_MONTANT)
                m_i_montant = .ColumnIndex
            End With
            With .AddColumn(" Client", "nom_prenom")
                m_i_nomProp = .ColumnIndex
            End With
            With .AddColumn(" Nom animal", VTL_ANIMAL.VTL_ANIMAL_NOM)
                m_i_nom_animal_mutu = .ColumnIndex
            End With

        End With


    End Sub


#End Region


#Region "Bouton"
    Public Sub clicSearch(sender As Object, e As EventArgs)

    End Sub
#End Region

End Class