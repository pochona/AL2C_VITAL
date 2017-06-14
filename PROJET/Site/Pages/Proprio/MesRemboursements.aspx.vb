Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageMesRemboursements
    Inherits CwPage

#Region "Prop et variables privées"

#Region "Animal"

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

#End Region


    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'recupere le proprietaire dans l'url
        SelectedAnimalId = CInt(Request.QueryString("ID"))

        'chargement des données
        'LoadData()
        grdMesRemboursements.RefreshData()
    End Sub

#Region "Colonnes de la grille "

    Private m_i_date As Integer
    Private m_i_statut As Integer

#End Region

#Region "Chargement grille"

    Private Sub grdMesRemboursements_Init(sender As Object, e As EventArgs) Handles grdMesRemboursements.Init
        With grdMesRemboursements
            .DataKeyField = VTL_REMBOURSMT.VTL_REMBOURSMT_ID

            With .AddDateColumn("Date consultation", VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                m_i_date = .ColumnIndex
            End With
            With .AddColumn("Statut du remboursement", VTL_STATUT.VTL_STATUT_NAME)
                m_i_statut = .ColumnIndex
            End With
        End With

    End Sub

    Private Sub grdMesRemboursements_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles grdMesRemboursements.DataTableRequest
        Try
            ' GetContacts est une requête qui permet de sélectionner les données qui apparaitrons dans la grille
            p_o_dt = Remboursement.GetRemboursementAnimal(SelectedAnimalId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region


End Class
