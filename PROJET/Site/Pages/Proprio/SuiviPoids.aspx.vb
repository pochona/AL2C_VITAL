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

    End Sub

#End Region

End Class
