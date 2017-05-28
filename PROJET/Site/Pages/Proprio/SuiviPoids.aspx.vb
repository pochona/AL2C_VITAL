Imports VITAL.BO
Imports VITAL.BO.VITAL

Partial Public Class PageSuiviPoids
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


End Class
