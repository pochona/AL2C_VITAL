Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageHistoriquePoids
    Inherits CwPage

#Region "Propriétés et variables privées"

#End Region


#Region "Colonnes de la grille"
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

#Region "Animal de la page"

    Private m_o_animal As Animal

    Private Property SelectedAnimalId() As Integer
        Get
            Return CInt(ViewState("SelectedAnimalId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedAnimalId") = p_i_value
        End Set
    End Property

    Private ReadOnly Property SelectedAnimal As Animal
        Get
            If m_o_animal Is Nothing OrElse (SelectedAnimalId() <> m_o_animal.ID) Then
                If SelectedAnimalId() <> 0 Then
                    m_o_animal = New Animal(SelectedAnimalId)
                Else
                    m_o_animal = New Animal()
                End If
            End If
            Return m_o_animal
        End Get
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
            LoadData()
        End If
    End Sub

    ''' <summary>
    ''' Chargement des données.
    ''' </summary>
    Private Sub LoadData()
        Dim l_o_animal As New Animal

        l_o_animal.Load(4)
        CwNomAnimal.Text = l_o_animal.Nom
    End Sub

#End Region

#Region "Evènements"

#End Region

#Region "Boutons"


    'Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
    '    Try
    '        ShowInfo("Hello !!!!!!!!")
    '    Catch ex As Exception
    '        ShowException(ex)
    '    End Try
    'End Sub

#End Region


End Class
