Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageAjoutContratClient
    Inherits CwPage

#Region "propriétés et variables privées"

#Region "contrat"
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
    ''' Contient l'ID de l'Animal consultée
    ''' </summary>
    ''' <value>ID</value>
    ''' <returns>ID d'une Animal</returns>
    Private Property SelectedContratId As Integer
        Get
            Return CInt(ViewState("SelectedContratId"))
        End Get
        Set(p_i_value As Integer)
            ViewState("SelectedContratId") = p_i_value
        End Set
    End Property
#End Region

#Region "Mode d'accès"

    Private Property ModeAcces As EN_ModeAcces
        Get
            Return CType(ViewState("ModeAcces"), EN_ModeAcces)
        End Get
        Set(p_o_value As EN_ModeAcces)
            ViewState("ModeAcces") = p_o_value
        End Set
    End Property

#End Region

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
            ' Récupération des paramètres
            ModeAcces = CType(Request.QueryString("Mode"), EN_ModeAcces)
            If ModeAcces = EN_ModeAcces.Modification Then
                SelectedContratId = CInt(Request.QueryString("Contrat"))
                Title = SelectedContrat.Num_contrat
                SelectedProprioId = SelectedContrat.Id_proprietaire
            ElseIf ModeAcces = EN_ModeAcces.Creation Then
                Title = "Nouveau contrat"
                SelectedProprioId = 0
            End If
            LoadCbo()
            LoadData()
            LoadElementsVisibles()
        End If
    End Sub

    Private Sub LoadCbo()
        If ModeAcces = EN_ModeAcces.Creation Then
            BindCbo(cboAnimal, Animal.GetAll().GetDS, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_ANIMAL.VTL_ANIMAL_NOM, "Sélectionner...")
        ElseIf ModeAcces = EN_ModeAcces.Modification And SelectedProprioId <> 0 Then
            BindCbo(cboAnimal, Animal.GetAnimauxByProprio(SelectedProprioId).GetDS, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_ANIMAL.VTL_ANIMAL_NOM, "Sélectionner...")
        Else
            BindCbo(cboAnimal, Animal.GetAll().GetDS, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_ANIMAL.VTL_ANIMAL_NOM, "Sélectionner...")
        End If
    End Sub

    Private Sub LoadElementsVisibles()
        btnNewAnimal.Visible = False
        If ModeAcces = EN_ModeAcces.Creation Then
            btnCreate.Visible = True
            btnSave.Visible = False
            btnModifier.Visible = False
            txtNumContrat.Enabled = True
            DateDebut.Enabled = True
            DateFin.Enabled = True
            ntbTxremb.Enabled = True
            txtIdPropCache.Enabled = True
            stbProprio.Enabled = True
            cboAnimal.Enabled = True
            '      txtIdAnimalCache.Enabled = True
            '      stbAnimal.Enabled = True
            cboAnimal.Visible = False
            If SelectedProprioId <> 0 Then
                btnNewAnimal.Visible = True
            End If
        ElseIf ModeAcces = EN_ModeAcces.Modification Then
            btnCreate.Visible = False
            btnModifier.Visible = True
            btnSave.Visible = False
            txtNumContrat.Enabled = False
            DateDebut.Enabled = False
            DateFin.Enabled = False
            ntbTxremb.Enabled = False
            txtIdPropCache.Enabled = False
            stbProprio.Enabled = False
            cboAnimal.Enabled = False
            cboAnimal.Visible = True
            '    txtIdAnimalCache.Enabled = False
            '   stbAnimal.Enabled = False
            'x If SelectedProprioId <> 0 Then
            'x     btnNewAnimal.Visible = True
            'x End If
        End If
    End Sub

    Private Sub LoadData()
        If ModeAcces = EN_ModeAcces.Creation Then
            DateDebut.Date = Now.Date
            DateFin.Date = Now.Date.AddYears(1)
        ElseIf ModeAcces = EN_ModeAcces.Modification Then
            If SelectedContratId <> 0 Then
                txtNumContrat.Text = SelectedContrat.Num_contrat
                DateDebut.Date = SelectedContrat.Dt_debut
                DateFin.Date = SelectedContrat.Dt_fin
                ntbTxremb.Value = SelectedContrat.TxRemb
                'Proprio

                SelectedProprioId = SelectedContrat.Id_proprietaire
                txtIdPropCache.Text = CStr(SelectedProprioId)
                stbProprio.Text = SelectedProprio.Nom + " " + SelectedProprio.Prenom
                'aNIMAL
                'x l_o_animal.Load(SelectedContrat.Id_animal)
                'x txtIdAnimalCache.Text = CStr(SelectedContrat.Id_animal)
                'x stbAnimal.Text = l_o_proprio.Nom + " " + l_o_proprio.Prenom
                cboAnimal.SelectedValue = CStr(SelectedContrat.Id_animal)
                SelectedProprioId = SelectedContrat.Id_proprietaire
            End If
        End If
    End Sub

#End Region

#Region "Boutton"

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim l_o_Contrat As New Contrat
        Dim l_o_ex As New Exception("Vous devez sélectionner un animal !")
        Dim l_o_ex2 As New Exception("Cet animal à déjà un contrat ! Vous devez le modifier !")

        Try
            ValidationManager.Validate(DateDebut, DateFin, cboAnimal, txtIdPropCache, txtNumContrat, ntbTxremb)
            If CInt(cboAnimal.SelectedValue) = 0 Then
                ShowException(l_o_ex)
            ElseIf Contrat.Exists(CInt(cboAnimal.SelectedValue), DateDebut.Date, DateFin.Date) = True Then
                ShowException(l_o_ex2)
            Else
                With l_o_Contrat
                    .Load(SelectedContratId)
                    .Dt_debut = DateDebut.Date
                    .Dt_fin = DateFin.Date
                    .Id_animal = CInt(cboAnimal.SelectedValue)
                    .Id_proprietaire = CInt(txtIdPropCache.Text)
                    .Num_contrat = txtNumContrat.Text
                    .TxRemb = ntbTxremb.Value
                    'TODO Vérif remboursement
                    .Save()
                End With
                SelectedContratId = l_o_Contrat.ID
                LoadElementsVisibles()
                ModeAcces = EN_ModeAcces.Modification
                ShowInfo("Nouveau contrat enregistré avec succès !")
            End If
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim l_o_Contrat As New Contrat
        Dim l_o_ex As New Exception("Vous devez sélectionner un animal !")
       
        Try

            ValidationManager.Validate(DateDebut, DateFin, cboAnimal, txtIdPropCache, txtNumContrat, ntbTxremb)
            If CInt(cboAnimal.SelectedValue) = 0 Then
                ShowException(l_o_ex)
            Else
                With l_o_Contrat
                    .Load(SelectedContratId)
                    .Dt_debut = DateDebut.Date
                    .Dt_fin = DateFin.Date
                    .Id_animal = CInt(cboAnimal.SelectedValue)
                    .Id_proprietaire = CInt(txtIdPropCache.Text)
                    .Num_contrat = txtNumContrat.Text
                    .TxRemb = ntbTxremb.Value
                    .Save()
                End With
                LoadElementsVisibles()
                ShowInfo("Enregistrement effectué avec succès !")
            End If
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Try
            btnModifier.Visible = False
            btnSave.Visible = True
            txtNumContrat.Enabled = True
            DateDebut.Enabled = True
            DateFin.Enabled = True
            ntbTxremb.Enabled = True
            txtIdPropCache.Enabled = True
            stbProprio.Enabled = True
            cboAnimal.Enabled = True
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "SelectTextBox Proprio"

    Private Sub stbProprio_TextChanged(sender As Object, e As EventArgs) Handles stbProprio.TextChanged
        Dim l_o_prop As New PropriEtaire
        Dim l_i_count As Integer = 0
        Dim l_b_allNumber As Boolean = True
        Dim l_s_tempCaract As String
        Dim l_b_number As Boolean = False

        Try
            If stbProprio.Text <> "" Then
                'On vérifie que c'est bien numérique 
                While l_i_count < stbProprio.Text.Count And l_b_allNumber = True
                    l_b_number = False
                    l_s_tempCaract = stbProprio.Text.Substring(l_i_count, 1)
                    ' On vérifie que c'est bien numérique
                    Select Case l_s_tempCaract
                        Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                            l_b_number = True
                    End Select
                    If l_b_number = False Then
                        l_b_allNumber = False
                    End If
                    ' on incrémente
                    l_i_count = l_i_count + 1
                End While
                'Si c'est bien numérique
                If l_b_allNumber = True Then
                    'On vérifie qu'il existe un user correspondant
                    If PropriEtaire.Exists(CInt(stbProprio.Text)) = True Then
                        l_o_prop.Load(CInt(stbProprio.Text))
                        txtIdPropCache.Text = stbProprio.Text
                        stbProprio.Text = l_o_prop.Nom + " " + l_o_prop.Prenom
                        ShowInfo("Vous avez sélectionné : " + CStr(l_o_prop.Nom + " " + l_o_prop.Prenom))
                        cboAnimal.Visible = True
                        SelectedProprioId = CInt(txtIdPropCache.Text)
                        LoadCbo()
                        btnNewAnimal.Visible = True
                    End If
                Else
                    ShowInfo("Pour sélectionner un propriétaire, veuillez cliquer sur le bouton à droite de la zone.")
                    stbProprio.Text = ""
                    cboAnimal.Visible = False
                    SelectedProprioId = 0
                    btnNewAnimal.Visible = False
                End If
            End If
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
