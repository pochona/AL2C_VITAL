Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageAjoutContratClient
    Inherits CwPage

    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Public Sub clicValider(sender As Object, e As EventArgs)
        Dim l_o_contrat As New Contrat
        Try
            With l_o_contrat
                ValidationManager.Validate(NumContrat, DateDebut, DateFin, IdAnimal, IdProprio, IdAssurance)
                .Num_contrat = CStr(NumContrat.Text)
                .Dt_debut = DateDebut.Date
                .Dt_fin = DateFin.Date
                .Id_animal = CInt(IdAnimal.Value)
                .Id_proprietaire = CInt(IdProprio.Value)
                .Id_assurance = CInt(IdAssurance.Value)

                l_o_contrat.Save()
            End With
        Catch ex As Exception
            ShowException(ex)
        End Try

    End Sub


End Class
