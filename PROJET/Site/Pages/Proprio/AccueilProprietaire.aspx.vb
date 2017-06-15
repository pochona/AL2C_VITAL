Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageAccueilProprietaire
    Inherits CwPage

#Region "Propriétés et variables privées"

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
            If (CStr(Request.QueryString("NFC")) = "erreur") Then
                ShowInfo("Erreur : Animal ou carte inexistant")
            End If
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        dtgAnimx.RefreshData()
        Dim l_s_msg As String = ""
        Dim l_o_dt As DataTable = Vaccin.GetVaccinations(User.Identity.Name).Getdt

        If l_o_dt.Rows.Count <> 0 Then
            For Each l_o_row As DataRow In l_o_dt.Rows
                If NzDate(l_o_row(VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)).AddMonths(NzInt(l_o_row(VTL_VACCIN.VTL_VACCIN_PERIODE_MOIS)) - 1) <= Now.Date Then
                    l_s_msg = l_s_msg + "Attention, vous devez faire le vaccin '" + CStr(l_o_row(VTL_VACCIN.VTL_VACCIN_LIBELLE)) + "' pour l'animal : '" + CStr(l_o_row(VTL_ANIMAL.VTL_ANIMAL_NOM)) + "' ! "
                End If
            Next
        End If
        ShowInfo(l_s_msg)
    End Sub

#End Region

#Region "Grille"

#Region "Colonnes de la grille des travaux"

    Private m_i_nom As Integer
    Private m_i_type As Integer
    Private m_i_race As Integer
    Private m_i_puce As Integer
    Private m_i_naissance As Integer
    Private m_i_deces As Integer
    Private m_i_carte As Integer

#End Region

    Private Sub dtgAnimx_Init(sender As Object, e As EventArgs) Handles dtgAnimx.Init
        With dtgAnimx
            'obligatoire : identifiant de la ligne
            .DataKeyField = VTL_ANIMAL.VTL_ANIMAL_ID
            'Pour supprimer le changement de page de la grille 
            .AllowPaging = False

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Proprio/AnimalGeneral.aspx?ID={0}"
                .DataNavigateUrlField = VTL_ANIMAL.VTL_ANIMAL_ID
                .Properties.ImageName = "search"
            End With
            With .AddColumn("Nom", VTL_ANIMAL.VTL_ANIMAL_NOM)
                m_i_nom = .ColumnIndex
            End With
            With .AddColumn("Type", VTL_TYPE.VTL_TYPE_LIBELLE)
                m_i_type = .ColumnIndex
            End With
            With .AddColumn("Num puce", VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE)
                m_i_puce = .ColumnIndex
            End With
            With .AddDateColumn("Date naissance", VTL_ANIMAL.VTL_ANIMAL_DT_NAISSANCE)
                m_i_naissance = .ColumnIndex
            End With
            With .AddDateColumn("Date décès", VTL_ANIMAL.VTL_ANIMAL_DT_DECES)
                m_i_deces = .ColumnIndex
            End With
            With .AddColumn("Numéro de carte", VTL_CARTE.VTL_CARTE_NUMERO)
                m_i_carte = .ColumnIndex
            End With
            With .AddColumn("Nom race", VTL_RACE.VTL_RACE_NOM)
                m_i_race = .ColumnIndex
            End With
        End With
    End Sub

    Private Sub dtgAnimx_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgAnimx.DataTableRequest
        Try
            p_o_dt = Animal.GetAnimauxProprio(User.Identity.Name).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
