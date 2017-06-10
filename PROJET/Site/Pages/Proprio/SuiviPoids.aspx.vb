Imports VITAL.BO
Imports VITAL.BO.VITAL

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
        If SelectedAnimal.GetIDConseilDiet() <> 0 Then
            l_o_conseilDiet.Load(SelectedAnimal.GetIDConseilDiet())
            txtConseils.Label = "Conseils diététiques"
            txtConseils.Text = l_o_conseilDiet.Contenu
            txtConseils.Enabled = False
        Else
            'Pas de dernier conseil diet
            txtConseils.Label = "Pour obtenir des conseils diététiques pour animal, contactez votre vétérinaire !"
            dtbLastConseil.Date = l_o_conseilDiet.Date
        End If
        ' LoadChart()
    End Sub


    'x 
    'x     '''  Rempli les données dans le graphique
    'x     Private Sub LoadChartLine()
    'x         Dim l_o_dt As DataTable = Histo_Poids.GetHistoPoids(SelectedAnimalId).GetDT()
    'x         Dim l_o_ds As Chart.BarDataset
    'x         Dim l_i_index As Integer = 0
    'x 
    'x         With lnctPoids
    'x             ' Libellés axe des abscisses (vertical)
    'x             For Each l_o_row As DataRow In l_o_dt.Rows
    'x                 .Labels.Add(CStr(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS)))
    'x             Next
    'x             ' Nettoyage des données du graphique
    'x             .Datasets.Clear()
    'x             ' Renseignement des données
    'x             For Each l_o_row As DataRow In l_o_dt.Rows
    'x                 l_o_ds = .Datasets.AddBar(NzStr(l_o_row(0)), "#39A5E0")
    'x                 l_o_ds.Add(NzDbl(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS)))
    'x             Next
    'x         End With
    'x 
    'x 
    'x 
    'x 
    'x 
    'x 
    'x 
    'x     End Sub
    'x 
    'x   
    'x 
    'x     ''' Initialise le graphique.    
    'x     Private Sub LoadChart()
    'x         ' DataTable qui contient les données à charger 
    'x         Dim l_o_dt As DataTable = Histo_Poids.GetHistoPoids(SelectedAnimalId).GetDT()
    'x         ' DataSource du graphique
    'x         Dim l_o_ds As New Chart.PieDataset
    'x 
    'x         With lnctPoids
    'x             'x ' Pour déclencher un évènement lorsqu'on clique sur le graphique
    'x             'x .AutoPostBack = True
    'x             'x ' Chart data sources
    'x             'x .Datasets.Clear()
    'x             'x l_o_ds = .Datasets.Add()
    'x             'x ' Chart Type
    'x             'x .Kind = Chart.PieChartKind.Doughnut
    'x             'x ' Options ...
    'x             'x ' Position de la légende
    'x             'x .Options.Legend.Position = Chart.ChartPosition.Bottom
    'x             'x ' Remplissage des données dans le graphique
    'x             For Each l_o_row As DataRow In l_o_dt.Rows
    'x                 ' Libellés
    'x                 .Labels.Add(NzStr(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS)))
    'x                 ' Données
    'x                 l_o_ds.Add(NzDbl(l_o_row(VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS)))
    'x                 ' l_o_ds.Add(Taille prise graphiquement par les données, Couleur affichée)
    'x             Next
    'x         End With
    'x     End Sub
 

#End Region

End Class

'x     Private Sub LoadChartLine()
'x         Dim l_o_dt As DataTable = GetChartLineData()
'x         Dim l_o_ds As Chart.BarDataset
'x         ' Si l'on souhaite utiliser différentes couleurs
'x         Dim l_as_colors As String() = {"#39A5E0", "#0089D4"}
'x         Dim l_i_index As Integer = 0
'x 
'x         With lchtMyChart
'x             ' Libellés axe des abscisses (vertical)
'x             For l_i As Integer = 1 To 12
'x                 .Labels.Add(l_o_dt.Columns(l_i).ColumnName)
'x             Next
'x             ' Nettoyage des données du graphique
'x             .Datasets.Clear()
'x             ' Renseignement des données
'x             For Each l_o_dr As DataRow In l_o_dt.Rows
'x                 l_o_ds = .Datasets.AddBar(NzStr(l_o_dr(0)), l_as_colors(l_i_index))
'x                 For l_i_col As Integer = 1 To 12
'x                     l_o_ds.Add(NzDbl(l_o_dr(l_i_col)))
'x                 Next
'x                 ' Pour changer de couleurs
'x                 l_i_index += 1
'x             Next
'x         End With
'x     End Sub