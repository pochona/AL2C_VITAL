Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageCreerAnimal
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
            LoadCbo()
        End If
    End Sub

    Private Sub LoadCbo()
        BindCbo(cboType, Type.GetAll.GetDS, VTL_TYPE.VTL_TYPE_ID, VTL_TYPE.VTL_TYPE_LIBELLE, "Sélectionner...")
        BindCbo(cboRace, Race.GetAll.GetDS, VTL_RACE.VTL_RACE_ID, VTL_RACE.VTL_RACE_NOM, "Sélectionner...")
    End Sub

#End Region

#Region "Boutons"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim l_o_animal As New Animal

        Try
            ValidationManager.Validate(txtNom, cboRace, cboType)
            With l_o_animal
                .Dt_naissance = dtbNaiss.Date
                .Nom = txtNom.Text
                .Num_puce = txtPuce.Text
                '.Id_carte=
                .Id_race = CInt(cboRace.SelectedValue)
                .Id_type = CInt(cboType.SelectedValue)
                ' .Id_prop=
                .Save()
            End With
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region


End Class
