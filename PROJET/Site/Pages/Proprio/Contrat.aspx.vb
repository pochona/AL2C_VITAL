Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageContrat
    Inherits CwPage

#Region "propriétés et variables privées"
    Private m_o_Animal As Animal

    ''' <summary>
    ''' Contient l'Animal consultée
    ''' </summary>
    ''' <value>Animal</value>
    ''' <returns>Animal</returns>
    Private ReadOnly Property SelectedAnimal As Animal
        Get
            If m_o_Animal Is Nothing OrElse (SelectedAnimalId <> m_o_Animal.ID) Then
                If SelectedAnimalId <> 0 Then
                    m_o_Animal = New Animal(SelectedAnimalId)
                Else
                    m_o_Animal = New Animal()
                End If
            End If
            Return m_o_Animal
        End Get
    End Property

    ''' <summary>
    ''' Contient l'ID de l'SelectedContratId
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID d'une SelectedContratId</returns>
    Private Property SelectedAnimalId As Integer
        Get
            Return CInt(ViewState("SelectedAnimalId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedAnimalId") = p_i_value
        End Set
    End Property

#End Region
#Region "propriétés et variables privées"
    Private m_o_contrat As Contrat

    ''' <summary>
    ''' Contient l'Animal consultée
    ''' </summary>
    ''' <value>Animal</value>
    ''' <returns>Animal</returns>
    Private ReadOnly Property SelectedContrat As Contrat
        Get
            If m_o_contrat Is Nothing OrElse (SelectedContratId <> m_o_contrat.ID) Then
                If SelectedContratId <> 0 Then
                    m_o_contrat = New Contrat(SelectedContratId)
                Else
                    m_o_contrat = New Contrat()
                End If
            End If
            Return m_o_contrat
        End Get
    End Property

    ''' <summary>
    ''' Contient l'ID de l'SelectedContratId
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID d'une SelectedContratId</returns>
    Private Property SelectedContratId As Integer
        Get
            Return CInt(ViewState("SelectedContratId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedContratId") = p_i_value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'recupere l'animal dans l'url
            SelectedAnimalId = CInt(Request.QueryString("ID"))
            SelectedContratId = SelectedAnimal.GetIdContrat
            txtNumContrat.Text = SelectedContrat.Num_contrat
            ntbTxremb.Value = CDbl(SelectedContrat.TxRemb)
            DateDebut.Date = SelectedContrat.Dt_debut
            txtMut.Text = SelectedContrat.GetNomMutuelle()
            DateFin.Date = SelectedContrat.Dt_fin
        End If
    End Sub

End Class
