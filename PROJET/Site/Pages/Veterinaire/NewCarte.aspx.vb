Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageNewCarte
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

        End If
    End Sub

#End Region

#Region "Boutons"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim l_o_carte As New Carte

        Try
            ValidationManager.Validate(txtNumCarte)
            l_o_carte.Numero = txtNumCarte.Text
            l_o_carte.Save()
            CloseModalOnLoad("RefreshCarte||" + CStr(l_o_carte.ID))
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
