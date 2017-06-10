Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PagePopUpProprioContrat
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            dtgProprioContrat.RefreshData()
        End If
    End Sub

#Region "Grille"

#Region "Colonnes de la grille"

    Private m_i_prenom As Integer
    Private m_i_adr As Integer

#End Region

    Private Sub dtgProprioContrat_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgProprioContrat.DataTableRequest
        Try
            p_o_dt = PropriEtaire.GetAll.GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgProprioContrat_Init(sender As Object, e As EventArgs) Handles dtgProprioContrat.Init
        With dtgProprioContrat
            .DataKeyField = VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID

            With .AddSelectColumn("Nom", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, "=")
                ' On revoie le champ
                .AddReturnedFields(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                ' Taille 
                .Width = Unit.Pixel(65)
            End With
            .AddColumn("Prénom", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
            .AddColumn("Adresse", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ADR)
            .AddColumn("Code Postal", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_CP)
            .AddColumn("Ville", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_VILLE)
            .AddColumn("Téléphone", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_TEL)
            .AddColumn("Mail", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_MAIL)
        End With
    End Sub

#End Region

End Class
