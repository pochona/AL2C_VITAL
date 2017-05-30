Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' 
''' </summary>
Partial Public Class PageOpenDoc
    Inherits CwPage


#Region "propriétés et variables privées"
    Private m_o_doc As AnimalDocs

    ''' <summary>
    ''' Contient le document consulté
    ''' </summary>
    ''' <value>document</value>
    ''' <returns>document</returns>
    Private ReadOnly Property SelectedDoc As AnimalDocs
        Get
            If m_o_doc Is Nothing OrElse (SelectedDocId <> m_o_doc.ID) Then
                If SelectedDocId <> 0 Then
                    m_o_doc = New AnimalDocs(SelectedDocId)
                Else
                    m_o_doc = New AnimalDocs()
                End If
            End If
            Return m_o_doc
        End Get
    End Property

    ''' <summary>
    ''' Contient l'ID du document consultée
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID d'une document</returns>
    Private Property SelectedDocId As Integer
        Get
            Return CInt(ViewState("SelectedDocId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedDocId") = p_i_value
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
            SelectedDocId = CInt(Request.QueryString("ID"))
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        txtNom.Text = SelectedDoc.Nom
        txtChemin.Text = SelectedDoc.Chemin
    End Sub
#End Region

#Region "Boutons"

#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseWindowOnLoad()
    End Sub

    ''' <summary>
    ''' Ouvre de doc dans new onglet.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try
            SendFile(SelectedDoc.Chemin, True)
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Lance téléchargement du fichier.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            SendFile(SelectedDoc.Chemin, False)
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub
End Class
