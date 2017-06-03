Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' Page de sélection d'un animal par le vétérinaire.
''' </summary>
Partial Class PageAuthAnimal
    Inherits CwPage

#Region "Chargement"

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadData()
            LoadElementsVisibles()
        End If
    End Sub

    ''' <summary>
    ''' Chargement des données.
    ''' </summary>
    Private Sub LoadData()
        dtgResultats.RefreshData()
    End Sub

    Private Sub LoadElementsVisibles()
        dtgResultats.Visible = False
        frmResultats.Visible = False
    End Sub

#End Region

#Region "Boutons"

    ''' <summary>
    ''' Evenement déclenché lors du clic sur le bouton qui va lancer la récupération des informations contenues
    ''' dans le lecteur.
    ''' </summary>
    ''' <param name="sender">Instance de classe source de l'évènement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSearchNFC_Click(sender As Object, e As EventArgs) Handles btnSearchNFC.Click
        Try
            ' TODO
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Bouton qui lance la recherche d'un animal selon des critères, utile si le proprio n'as pas la carte de
    ''' l'animal.
    ''' </summary>
    ''' <param name="sender">Instance de classe source de l'évènement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSearchAnimal_Click(sender As Object, e As EventArgs) Handles btnSearchAnimal.Click
        Try
            dtgResultats.RefreshData()
            dtgResultats.Visible = True
            frmResultats.Visible = True
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "Grille"

#Region "Colonnes de la grille des travaux"

    Private m_i_btn As Integer
    Private m_i_nom As Integer
    Private m_i_naiss As Integer
    Private m_i_numCarteVit As Integer
    Private m_i_prop As Integer
    Private m_i_race As Integer
    Private m_i_type As Integer

#End Region

    ''' <summary>
    ''' Definition de la strucutre de la grille
    ''' Se produit lorsque le contrôle serveur est initialisé, ce qui constitue la première étape de son cycle de
    ''' vie.
    ''' </summary>
    ''' <param name="sender">Instance de classe source de l'évènement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub dtgResultats_Init(sender As Object, e As EventArgs) Handles dtgResultats.Init
        With dtgResultats
            .DataKeyField = VTL_ANIMAL.VTL_ANIMAL_ID

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Veterinaire/AccueilAnimal.aspx?ID={0}"
                .DataNavigateUrlField = VTL_ANIMAL.VTL_ANIMAL_ID
                .Target = "tabAnimal" + VTL_ANIMAL.VTL_ANIMAL_ID
                .Properties.ImageName = "search"
                m_i_btn = .ColumnIndex
            End With
            With .AddColumn("Nom", VTL_ANIMAL.VTL_ANIMAL_NOM)
                m_i_nom = .ColumnIndex
            End With
            With .AddDateColumn("Naissance", VTL_ANIMAL.VTL_ANIMAL_DT_NAISSANCE)
                m_i_naiss = .ColumnIndex
            End With
            With .AddColumn("Numéro carte vitale", VTL_CARTE.VTL_CARTE_NUMERO)
                m_i_numCarteVit = .ColumnIndex
            End With
            With .AddColumn("Propriétaire", "nom_prenom")
                m_i_prop = .ColumnIndex
            End With
            With .AddColumn("Race", VTL_RACE.VTL_RACE_NOM)
                m_i_race = .ColumnIndex
            End With
            With .AddColumn("Type d'animal", VTL_TYPE.VTL_TYPE_LIBELLE)
                m_i_type = .ColumnIndex
            End With
        End With
    End Sub

    Private Sub dtgResultats_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgResultats.DataTableRequest
        Try
            p_o_dt = Animal.GetAnimxSearched(txtNumCarte.Text, txtNomAnimal.Text, txtNomProprio.Text, txtPrenomProprio.Text).getDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region


End Class
