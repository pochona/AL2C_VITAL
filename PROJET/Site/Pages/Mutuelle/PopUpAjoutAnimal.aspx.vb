Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PagePopUpAjoutAnimal
    Inherits CwPage

#Region "proprio"
    Private m_o_proprio As PropriEtaire

    Private ReadOnly Property SelectedProprio As PropriEtaire
        Get
            If m_o_proprio Is Nothing OrElse (SelectedProprioId <> m_o_proprio.ID) Then
                If SelectedProprioId <> 0 Then
                    m_o_proprio = New PropriEtaire(SelectedProprioId)
                Else
                    m_o_proprio = New PropriEtaire()
                End If
            End If
            Return m_o_proprio
        End Get
    End Property

    Private Property SelectedProprioId As Integer
        Get
            Return CInt(ViewState("SelectedProprioId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedProprioId") = p_i_value
        End Set
    End Property

#End Region
#Region "Chargement"

    ''' <summary>query
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            SelectedProprioId = CInt(Request.QueryString("ID"))

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
        Dim l_o_carte As New Carte
        Try
            Using l_o_trans As Transaction = MyDB.GetNewTransaction()
                ValidationManager.Validate(txtNom, cboRace, cboType)
                With l_o_carte
                    .Numero = Guid.NewGuid().ToString
                    .Nfc = Guid.NewGuid().ToString
                    .Save(l_o_trans)
                End With
                With l_o_animal
                    .Dt_naissance = dtbNaiss.Date
                    .Nom = txtNom.Text
                    .Num_puce = txtPuce.Text
                    .Id_carte = l_o_carte.ID
                    .Id_race = CInt(cboRace.SelectedValue)
                    .Id_type = CInt(cboType.SelectedValue)
                    .Id_prop = SelectedProprioId
                    .Save(l_o_trans)
                End With
                l_o_trans.Validate()
            End Using
            CloseModalOnLoad("RefreshCboAnimal||" + CStr(l_o_animal.ID))
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region



End Class
