Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageAjoutTraitement
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
            'recupere l'animal dans l'url
            SelectedAnimalId = CInt(Request.QueryString("Animal"))
            LoadData()
            LoadCbo()
        End If
    End Sub

    Private Sub LoadData()
        dtbMedoc.Date = Now.Date
    End Sub

    Private Sub LoadCbo()
        BindCbo(cboMedoc, Medicament.GetMedicamentByProprio.GetDS, VTL_MEDICAMENT.VTL_MEDICAMENT_ID, VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE, "Sélectionner...")
    End Sub

#End Region

    Private Sub btnNewTraitement_Click(sender As Object, e As EventArgs) Handles btnNewTraitement.Click
        Dim l_o_tramt As New Traitrement
        Dim l_o_dtl As New Traitement_medicament

        Try
            ValidationManager.Validate(dtbMedoc, cboMedoc)
            ' Ouverture d'une transcaction
            Using l_o_trans As Transaction = MyDB.GetNewTransaction()
                ' Traitements
                With l_o_tramt
                    .Dt_debut = dtbMedoc.Date
                    .Id_animal = SelectedAnimalId
                    .Save(l_o_trans)
                End With
                With l_o_dtl
                    .Posologie = "Effectué par le propriétaire"
                    .Id_medicament = CInt(cboMedoc.SelectedValue)
                    .Id_traitement = l_o_tramt.ID
                    .Save(l_o_trans)
                End With
                ' On valide la transaction (elle se ferme tout seule grace au "using")
                l_o_trans.Validate()
                CloseModalOnLoad("ShowInfoNewTraitement")
            End Using
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub
End Class
