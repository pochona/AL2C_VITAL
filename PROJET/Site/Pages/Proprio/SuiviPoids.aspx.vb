Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' 
''' </summary>
Partial Public Class PageSuiviPoids
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
        If Not IsPostBack Then
            'Récupère le document dans l'url
            SelectedAnimalId = CInt(Request.QueryString("ID"))
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        Dim l_o_poids As New Histo_Poids
        Dim l_o_conseilDiet As New ConseilDietetique

        txtPoidsActuel.Text = CStr(SelectedAnimal.GetLastPoids())
       
        txtTaille.Text = CStr(SelectedAnimal.GetLastTaille())
        LoadChart()
        LoadChartTaille()
        If SelectedAnimal.GetIDConseilDiet() <> 0 Then
            l_o_conseilDiet.Load(SelectedAnimal.GetIDConseilDiet())
            txtConseils.Text = l_o_conseilDiet.Contenu
            dtbLastConseil.Date = l_o_conseilDiet.Date
            txtConseils.Enabled = False
        Else
            'Pas de dernier conseil diet
            txtConseils.Label = "Pour obtenir des conseils diététiques pour animal, contactez votre vétérinaire !"
            dtbLastConseil.Visible = False
        End If
    End Sub

#Region "Graphiques"

#Region "Poids"

    ''' <summary>
    ''' Mise en forme du graphique.
    ''' </summary>
    Private Sub LoadChart()
        Dim l_o_dt As DataTable = GetChartLineData()
        Dim l_o_ds As Chart.BarDataset
        Dim l_i_nbValuePoids As Integer = Histo_Poids.GetHistoPoids(SelectedAnimalId).GetDT().Rows.Count

        With lnctPoids
            ' Libellés axe des abscisses (vertical)
            For l_i As Integer = 1 To l_i_nbValuePoids
                .Labels.Add(l_o_dt.Columns(l_i).ColumnName)
            Next
            ' Nettoyage des données du graphique
            .Datasets.Clear()
            ' Renseignement des données
            For Each l_o_dr As DataRow In l_o_dt.Rows
                l_o_ds = .Datasets.AddBar(NzStr(l_o_dr(0)), "#088A29")
                For l_i_col As Integer = 1 To l_i_nbValuePoids
                    l_o_ds.Add(NzDbl(l_o_dr(l_i_col)))
                    l_o_ds.BorderWidth = 1
                Next
            Next
            .Options.Legend.Display = False
        End With
    End Sub

    ''' <summary>
    ''' Retourne les données à mettre dans le graphique.
    ''' </summary>
    ''' <returns>Les données à mettre dans le graphique.</returns>
    Public Function GetChartLineData() As DataTable
        Dim l_o_dt As New DataTable
        Dim l_o_dtTemp As New DataTable
        Dim l_i_count As Integer
        Dim l_s_tempDate As String = ""
        Dim l_i_nbEgaux As Integer = 0

        l_o_dtTemp = Histo_Poids.GetHistoPoids(SelectedAnimalId).GetDT()
        'Construction des colonnes de la grille 
        l_o_dt.Columns.Add("TEMP")
        ' construit donnees de l'axe des ordonnées
        For Each l_o_row As DataRow In l_o_dtTemp.Rows
            If l_s_tempDate <> CStr(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO)) Then
                l_o_dt.Columns.Add(CStr(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO)))
                l_i_nbEgaux = 0
            Else
                l_i_nbEgaux = l_i_nbEgaux + 1
                l_o_dt.Columns.Add(CStr(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO)) + " " + CStr(l_i_nbEgaux))
            End If
            l_s_tempDate = CStr(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO))
        Next
        'Ajouter la 1er ligne pour la valeur du poids
        With l_o_dt.Rows.Add()
            l_i_count = 1
            For Each l_o_row2 As DataRow In l_o_dtTemp.Rows
                'pour cahque date poids sa valeur de poids
                .Item(l_i_count) = CDbl(l_o_row2(VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS))
                l_i_count = l_i_count + 1
            Next
        End With
        Return l_o_dt
    End Function

#End Region

#Region "Taille"

    ''' <summary>
    ''' Mise en forme du graphique.
    ''' </summary>
    Private Sub LoadChartTaille()
        Dim l_o_dt As DataTable = GetChartTailleData()
        Dim l_o_ds As Chart.BarDataset
        Dim l_i_nbValuePoids As Integer = Histo_Taille.GetHistoTaille(SelectedAnimalId).GetDT().Rows.Count

        With lnctTaille
            ' Libellés axe des abscisses (vertical)
            For l_i As Integer = 1 To l_i_nbValuePoids
                .Labels.Add(l_o_dt.Columns(l_i).ColumnName)
            Next
            ' Nettoyage des données du graphique
            .Datasets.Clear()
            ' Renseignement des données
            For Each l_o_dr As DataRow In l_o_dt.Rows
                l_o_ds = .Datasets.AddBar(NzStr(l_o_dr(0)), "#088A29")
                For l_i_col As Integer = 1 To l_i_nbValuePoids
                    l_o_ds.Add(NzDbl(l_o_dr(l_i_col)))
                    l_o_ds.BorderWidth = 1
                Next
            Next
            .Options.Legend.Display = False
        End With
    End Sub

    ''' <summary>
    ''' Retourne les données à mettre dans le graphique.
    ''' </summary>
    ''' <returns>Les données à mettre dans le graphique.</returns>
    Public Function GetChartTailleData() As DataTable
        Dim l_o_dt As New DataTable
        Dim l_o_dtTemp As New DataTable
        Dim l_i_count As Integer
        Dim l_s_tempDate As String = ""
        Dim l_i_nbEgaux As Integer = 0

        l_o_dtTemp = Histo_Taille.GetHistoTaille(SelectedAnimalId).GetDT()
        'Construction des colonnes de la grille 
        l_o_dt.Columns.Add("TEMP")
        ' construit donnees de l'axe des ordonnées
        For Each l_o_row As DataRow In l_o_dtTemp.Rows
            If l_s_tempDate <> CStr(l_o_row(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO)) Then
                l_o_dt.Columns.Add(CStr(l_o_row(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO)))
                l_i_nbEgaux = 0
            Else
                l_i_nbEgaux = l_i_nbEgaux + 1
                l_o_dt.Columns.Add(CStr(l_o_row(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO)) + " " + CStr(l_i_nbEgaux))
            End If
            l_s_tempDate = CStr(l_o_row(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO))
        Next
        'Ajouter la 1er ligne pour la valeur du poids
        With l_o_dt.Rows.Add()
            l_i_count = 1
            For Each l_o_row2 As DataRow In l_o_dtTemp.Rows
                'pour cahque date poids sa valeur de poids
                .Item(l_i_count) = CDbl(l_o_row2(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_TAILLE))
                l_i_count = l_i_count + 1
            Next
        End With
        Return l_o_dt
    End Function

#End Region

#End Region

#End Region

End Class