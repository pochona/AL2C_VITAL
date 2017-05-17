Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' Page servant d'exemple.
''' </summary>
Partial Public Class PageExemple
    Inherits CwPage

#Region "Propriétés et variables privées"

#Region "Colonnes de la grille XXX"
    Private m_i_XXX As Integer
    Private m_i_XXXX As Integer
#End Region

#Region "Mode d'accès"

    Private Property ModeAcces As EN_ModeAcces
        Get
            Return CType(ViewState("ModeAcces"), EN_ModeAcces)
        End Get
        Set(p_o_value As EN_ModeAcces)
            ViewState("ModeAcces") = p_o_value
        End Set
    End Property

#End Region

    'x #Region "Animal de la page"
    'x 
    'x     Private m_o_animal As Animal
    'x 
    'x     Private Property SelectedAnimalId() As Integer
    'x         Get
    'x             Return CInt(ViewState("SelectedAnimalId"))
    'x         End Get
    'x         Set(p_i_value As Integer)
    'x             ViewState("SelectedAnimalId") = p_i_value
    'x         End Set
    'x     End Property
    'x 
    'x     Private ReadOnly Property SelectedAnimal As Animal
    'x         Get
    'x             If m_o_animal Is Nothing OrElse (SelectedAnimalId() <> m_o_animal.ID) Then
    'x                 If SelectedAnimalId() <> 0 Then
    'x                     m_o_animal = New Animal(SelectedAnimalId)
    'x                 Else
    'x                     m_o_animal = New Animal()
    'x                 End If
    'x             End If
    'x             Return m_o_animal
    'x         End Get
    'x     End Property
    'x 
    'x #End Region

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
            LoadData()
        End If
    End Sub

    ''' <summary>
    ''' Chargement des données.
    ''' </summary>
    Private Sub LoadData()
        Dim l_o_race As New Race

        l_o_race.Load(1)
        txtTest.Text = l_o_race.Nom
    End Sub

#End Region

#Region "Evènements"

#End Region

#Region "Boutons"

    ''' <summary>
    ''' Gestion du clic sur le bouton.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            ShowInfo("Hello !!!!!!!!")
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
