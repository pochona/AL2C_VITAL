Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' 
''' </summary>
Partial Public Class PageDocuments
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
        If Not IsPostBack Then
            'Récupération de l'animal sélectionné
            SelectedAnimalId = CInt(Request.QueryString("ID"))
            dtgDocs.RefreshData()
        End If
    End Sub

#End Region

#Region "Boutons"

    ''' <summary>
    ''' Permet d'enregistrer le fichier sélectionné.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    'x     Private Sub uplDoc_FileReceived(sender As Object, e As EventArgs) Handles uplDoc.FileReceived
    'x         Dim l_o_cls As New Query
    'x         Dim l_s_PathInterv As String
    'x         Dim l_s_nom As String
    'x         Dim l_s_extension As String
    'x         Dim l_o_doc As New AnimalDocs
    'x 
    'x         If Len(uplDoc.FileName) > 0 Then
    'x             l_s_PathInterv = AppSettings("DocsPath")
    'x             Try
    'x                 If l_s_PathInterv <> "" Then
    'x                     l_s_nom = uplDoc.FileName
    'x                     ' On enregistre le chemin des PJ dans la base
    'x                     ' TODO, voir si on garde
    'x                     If Len(l_s_nom) > 50 Then
    'x                         l_s_extension = l_s_nom
    'x                         l_s_extension = Right(l_s_extension, 4)
    'x                         l_s_nom = Left(l_s_nom, 46)
    'x                         l_s_nom = l_s_nom + l_s_extension
    'x                     End If
    'x                     '----------Enregsitrement dans un répertoire
    'x                     'On copie le fichier dans le répertoire qui va contenir les fichiers
    'x                     uplDoc.PostedFile.SaveAs(l_s_PathInterv + "\" + l_s_nom)
    'x                     '----------Enregistrement dans la base de données
    'x                     l_o_doc.Chemin = l_s_PathInterv + "\" + l_s_nom
    'x                     l_o_doc.Nom = l_s_nom
    'x                     l_o_doc.Id_Animal = SelectedAnimalId
    'x                     l_o_doc.Save()
    'x                     'Message
    'x                     ShowInfo("Document enregistré.")
    'x                 Else
    'x                     Throw New UserException("Chemin du répertoire de l'application non valide.")
    'x                 End If
    'x             Catch ex As Exception
    'x                 ShowException(ex)
    'x             End Try
    'x         End If
    'x     End Sub
    Private Sub uplDoc_FileReceived(sender As Object, e As EventArgs) Handles uplDoc.FileReceived
        Dim l_o_cls As New Query
        Dim l_s_PathInterv As String
        Dim l_s_nom As String
        Dim l_s_extension As String
        Dim l_o_doc As New AnimalDocs
        Dim l_s_ext As String()

        If Len(uplDoc.FileName) > 0 Then
            l_s_PathInterv = AppSettings("DocsPath")
            Try
                If l_s_PathInterv <> "" Then
                    l_s_nom = uplDoc.FileName
                    ' On enregistre le chemin des PJ dans la base
                    ' TODO, voir si on garde
                    If Len(l_s_nom) > 50 Then
                        l_s_extension = l_s_nom
                        l_s_extension = Right(l_s_extension, 4)
                        l_s_nom = Left(l_s_nom, 46)
                        l_s_nom = l_s_nom + l_s_extension
                    End If
                    '----------Enregistrement dans la base de données
                    l_o_doc.Chemin = l_s_PathInterv + "\"
                    l_o_doc.Nom = l_s_nom
                    l_o_doc.Id_Animal = SelectedAnimalId
                    l_o_doc.Save()
                    'Chemin unique avec l'ID (on le fait now car avant le save l'id existe pas 
                    l_s_ext = Split(l_s_nom, ".")
                    l_o_doc.Chemin = l_s_PathInterv + "\" + CStr(l_o_doc.ID) + "." + l_s_ext(1)
                    l_o_doc.Save()
                    '----------Enregsitrement dans un répertoire
                    'On copie le fichier dans le répertoire qui va contenir les fichiers
                    uplDoc.PostedFile.SaveAs(l_s_PathInterv + "\" + CStr(l_o_doc.ID) + "." + l_s_ext(1))
                    'Message
                    ShowInfo("Document enregistré.")
                    'refresh grille
                    dtgDocs.RefreshData()
                Else
                    Throw New UserException("Chemin du répertoire de l'application non valide.")
                End If
            Catch ex As Exception
                ShowException(ex)
            End Try
        End If
    End Sub

#End Region

#Region "Grille"

#Region "Colonnes de la grille des travaux"

    Private m_i_nom As Integer
    Private m_i_btn As Integer
    Private m_i_chemin As Integer

#End Region

    Private Sub dtgDocs_Init(sender As Object, e As EventArgs) Handles dtgDocs.Init
        With dtgDocs
            'obligatoire : identifiant de la ligne
            .DataKeyField = VITAL_ANIMALDOCS.ANIMALDOCS_ID
            'Pour supprimer le changement de page de la grille 
            .AllowPaging = False

            'x             .AddToggleButtonColumn("toglebut")
            'x 
            'x             With .AddHyperlinkColumn("Nom - limité à 50 caractères", VITAL_ANIMALDOCS.ANIMALDOCS_ID, "DOC_ENCODEDPATH", "file_download.aspx?path={0}", "=")
            'x                 .WriteRawHTML = True
            'x                 .Target = "_top"
            'x             End With

            With .AddButtonColumn()
                .Width = Unit.Pixel(65) ' fixe la taille de la colonne
                .DataNavigateUrlFormatString = "~/Pages/Proprio/OpenDoc.aspx?ID={0}"
                .DataNavigateUrlField = VITAL_ANIMALDOCS.ANIMALDOCS_ID
                .Properties.ImageName = "search"
                m_i_btn = .ColumnIndex
            End With
            With .AddColumn("Nom", VITAL_ANIMALDOCS.ANIMALDOCS_NOM)
                m_i_nom = .ColumnIndex
            End With
            With .AddColumn("Emplacement", VITAL_ANIMALDOCS.ANIMALDOCS_CHEMIN)
                m_i_chemin = .ColumnIndex
            End With
        End With
    End Sub

    Private Sub dtgDocs_DataTableRequest(sender As Object, ByRef p_o_dt As DataTable, e As EventArgs) Handles dtgDocs.DataTableRequest
        Try
            p_o_dt = AnimalDocs.GetDocs(SelectedAnimalId).GetDT
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

End Class
