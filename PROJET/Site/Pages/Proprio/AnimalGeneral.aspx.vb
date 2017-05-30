Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' Accueil général d'un animal.
''' </summary>
Partial Public Class PageAnimalGeneral
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
        'Attention l'ordre est important
        If Not IsPostBack Then
            Title = "Informations générales"
            'recupere l'animal dans l'url
            SelectedAnimalId = CInt(Request.QueryString("ID"))
            'chargement listes déroulantes
            LoadCbo()
            'chargement des données
            LoadData()
            'définition des éléments visibles
            LoadElementsVisibles()
        End If
    End Sub

    ''' <summary>
    ''' Chargement des combo box / listes déroulantes.
    ''' </summary>
    Private Sub LoadCbo()
        BindCbo(cboType, Type.GetAll.GetDS, VTL_TYPE.VTL_TYPE_ID, VTL_TYPE.VTL_TYPE_LIBELLE, "Sélectionner...")
        BindCbo(cboRace, Race.GetAll.GetDS, VTL_RACE.VTL_RACE_ID, VTL_RACE.VTL_RACE_NOM, "Sélectionner...")
    End Sub

    ''' <summary>
    ''' Chargement des données.
    ''' </summary>
    Private Sub LoadData()
        'Si il y a bien un id d'animal passé en param dans URL
        If SelectedAnimalId <> 0 Then
            frmAnimal.Text = SelectedAnimal.Nom
            txtNumPuce.Text = SelectedAnimal.Num_puce
            txtNumCarte.Text = SelectedAnimal.GetNumCarteVit()
            dtbNaiss.Date = SelectedAnimal.Dt_naissance
            dtbDeces.Date = SelectedAnimal.Dt_deces
            ntbPoids.Value = SelectedAnimal.GetLastPoids()
            ntbTaille.Value = SelectedAnimal.GetLastTaille()
            ntbAge.Value = DateDiff(DateInterval.Year, SelectedAnimal.Dt_naissance, Now.Date)
            cboType.SelectedValue = CStr(SelectedAnimal.Id_type)
            cboRace.SelectedValue = CStr(SelectedAnimal.Id_race)
            txtNom.Text = SelectedAnimal.Nom
            LoadImage()
        End If

    End Sub

    ''' <summary>
    ''' Charge l'image, il faudra changer.
    ''' </summary>
    Private Sub LoadImage()
        'On supprime tout les boutons de la barre d'outils
        hmtlImageTest.ToolBar.AddButton(HtmlEditorButton.Image)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.AlignLeft)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.AlignRight)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Anchor)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Bold)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Bullets)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Center)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Color)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Copy)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Cut)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Font)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Highlight)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Indent)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Italic)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Justify)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Link)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Numbering)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Outdent)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Paste)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.PasteCode)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.PasteText)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Print)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Redo)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.RemoveFormat)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Rule)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Size)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Source)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.StrikeThrough)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Style)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Subscript)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Underline)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Undo)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Print)
        hmtlImageTest.ToolBar.Remove(HtmlEditorButton.Image)
        hmtlImageTest.AllowPrint = False
        hmtlImageTest.AllowZoom = False
        'On met l'image
        hmtlImageTest.Text = SelectedAnimal.Image
        'On enleve la possibiilté de modification 
        hmtlImageTest.RoleEdit = "!*"
    End Sub

    ''' <summary>
    ''' Défini les éléments visibles sur la page.
    ''' </summary>
    Private Sub LoadElementsVisibles()
        If Not SelectedAnimal.Dt_deces = DbNullDate() Then
            dtbDeces.Visible = True
        End If
        txtNom.Visible = False
        btnSave.Visible = False
        btnImage.Visible = False
        btnModif.Visible = True
        btnImage.Text = "Changer l'image"
    End Sub

#End Region

#Region "Boutons"

    ''' <summary>
    ''' Passe les chamsp en mode modification.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Try
            txtNom.RoleEdit = "*"
            ntbPoids.RoleEdit = "*"
            ntbTaille.RoleEdit = "*"
            dtbDeces.RoleEdit = "*"
            cboRace.RoleEdit = "*"
            txtNom.Enabled = True
            ntbPoids.Enabled = True
            ntbTaille.Enabled = True
            dtbDeces.Enabled = True
            cboRace.Enabled = True
            btnModif.Visible = False
            btnSave.Visible = True
            btnImage.Visible = True
            dtbDeces.Visible = True
            txtNom.Visible = True
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Enregsitre les infos de l'animal.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim l_o_animal As New Animal
        Dim l_o_taille As New Histo_Taille
        Dim l_o_poids As New Histo_Poids

        Try
            ValidationManager.Validate(txtNom, cboRace, cboType)
            ' Ouverture d'une transcaction
            Using l_o_trans As Transaction = MyDB.GetNewTransaction()
                ' Traitements
                With l_o_animal
                    .Load(SelectedAnimalId)
                    .Nom = txtNom.Text
                    .Dt_deces = dtbDeces.Date
                    .Id_race = CInt(cboRace.SelectedValue)
                    .Save()
                End With
                'on crée des historiques seuleument si c'est différent
                If ntbPoids.Value <> SelectedAnimal.GetLastPoids() Then
                    With l_o_poids
                        .Poids = ntbPoids.Value
                        .Dt_histo = Now.Date
                        .Id_animal = SelectedAnimalId
                        .Save()
                    End With
                End If
                If ntbTaille.Value <> SelectedAnimal.GetLastTaille() Then
                    With l_o_taille
                        .Taille = ntbTaille.Value
                        .Dt_histo = Now.Date
                        .Id_animal = SelectedAnimalId
                        .Save()
                    End With
                End If
                ' On valide la transaction (elle se ferme tout seule grace au "using")
                l_o_trans.Validate()
                LoadElementsVisibles()
                ShowInfo("Enregistrement effectué avec succès.")
            End Using
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Changement de l'image de l'animal.
    ''' </summary>
    ''' <param name="sender">Source de l'événement.</param>
    ''' <param name="e"><see cref="T:System.EventArgs"/> qui ne contient aucune donnée d'événement.</param>
    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Dim l_o_animal As New Animal
        Try
            'le meme bouton à deux fonctions
            If btnImage.Text = "Changer l'image" Then
                '-------modification
                btnImage.Text = "Enregistrer l'image"
                'On met la possibiilté de modification 
                hmtlImageTest.RoleEdit = "*"
            Else
                '-------enregistrement
                With l_o_animal
                    .Load(SelectedAnimalId)
                    .Image = hmtlImageTest.Text
                    .Id_race = CInt(cboRace.SelectedValue)
                    .Save()
                End With
                btnImage.Text = "Changer l'image"
                'On enleve la possibiilté de modification 
                hmtlImageTest.RoleEdit = "!*"
            End If
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
