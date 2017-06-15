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
    Private m_i_nom As Integer
    Private m_i_cp As Integer
    Private m_i_ville As Integer
    Private m_i_tel As Integer
    Private m_i_mail As Integer
    Private m_i_log As Integer
    Private m_i_mdp As Integer

#End Region

    Private Sub dtgProprioContrat_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgProprioContrat.DataTableRequest
        Try
            p_o_dt = PropriEtaire.GetInfoPropUser.GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub dtgProprioContrat_Init(sender As Object, e As EventArgs) Handles dtgProprioContrat.Init
        With dtgProprioContrat
            .DataKeyField = VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID
            .AllowAdding = True

            With .AddSelectColumn("Nom", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, "=")
                ' On revoie le champ
                .AddReturnedFields(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                ' Taille 
                .Width = Unit.Pixel(65)
                m_i_nom = .ColumnIndex
            End With
            With .AddColumn("Prénom", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                m_i_prenom = .ColumnIndex
            End With
            With .AddColumn("Login", VTL_USER.VTL_USER_LOGIN)
                m_i_log = .ColumnIndex
            End With
            With .AddColumn("Mot de passe", VTL_USER.VTL_USER_MDP)
                m_i_mdp = .ColumnIndex
            End With
            With .AddColumn("Adresse", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ADR)
                m_i_adr = .ColumnIndex
            End With
            With .AddColumn("Code Postal", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_CP)
                m_i_cp = .ColumnIndex
            End With
            With .AddColumn("Ville", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_VILLE)
                m_i_ville = .ColumnIndex
            End With
            With .AddColumn("Téléphone", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_TEL)
                m_i_tel = .ColumnIndex
            End With
            With .AddColumn("Mail", VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_MAIL)
                m_i_mail = .ColumnIndex
            End With
            .AddActionColumn()
        End With
    End Sub

    'x Private Sub dtgProprioContrat_Load(sender As Object, e As EventArgs) Handles dtgProprioContrat.Load
    'x     With dtgProprioContrat
    'x         .ValueForAdd(m_i_prenom) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_adr) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_nom) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_cp) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_ville) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_tel) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_mail) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_log) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x         .ValueForAdd(m_i_mdp) = "Nouveau"  ' m_i_nom correspond au numéro de la colonne
    'x     End With
    'x End Sub

    Private Sub dtgProprioContrat_AddCommand(sender As Object, e As DataGridCommandEventArgs, ByRef refresh As Boolean) Handles dtgProprioContrat.AddCommand
        Dim l_o_user As New User
        Dim l_o_proprio As New PropriEtaire
        Dim l_o_ex As New Exception("Un utilisateur existe déjà avec ce login !")

        Try
            If VITAL.BO.VITAL.User.Exists(CStr(dtgProprioContrat.Values(m_i_log, e.Item))) = True Then
                ShowException(l_o_ex)
            Else
                Using l_o_trans As Transaction = MyDB.GetNewTransaction()
                    With l_o_user
                        .Login = CStr(dtgProprioContrat.Values(m_i_log, e.Item))
                        .Mdp = CStr(dtgProprioContrat.Values(m_i_mdp, e.Item))
                        .Role = CStr("Proprietaire")
                        .Save(l_o_trans)
                    End With
                    With l_o_proprio
                        .Adr = CStr(dtgProprioContrat.Values(m_i_adr, e.Item)) ' m_i_nom correspond au numéro de la colonne
                        .Cp = CStr(dtgProprioContrat.Values(m_i_cp, e.Item)) ' e.Item correspond au numéro de ligne
                        .id_user = l_o_user.ID
                        .Mail = CStr(dtgProprioContrat.Values(m_i_mail, e.Item))
                        .Nom = CStr(dtgProprioContrat.Values(m_i_nom, e.Item))
                        .Prenom = CStr(dtgProprioContrat.Values(m_i_prenom, e.Item))
                        .Tel = CStr(dtgProprioContrat.Values(m_i_tel, e.Item))
                        .Ville = CStr(dtgProprioContrat.Values(m_i_ville, e.Item))
                        .Save(l_o_trans)
                    End With
                    l_o_trans.Validate()
                End Using
            End If
        Catch ex As Exception
            refresh = False ' Il ne faut pas rafraichir la grille en cas d'erreur 
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
