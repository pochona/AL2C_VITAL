Imports VITAL.BO.VITAL
Imports VITAL.BO

Partial Public Class PageAjoutContratClient
    Inherits CwPage

#Region "Chargement"
    ''' <summary>
    ''' Initialisation de la page en cours
    ''' </summary>
    ''' <remarks>Ne pas mettre de bloc try/catch :
    ''' S'il y a une erreur dans cette procédure, la page ne sera pas affichée.
    ''' Le message d'erreur sera affiché dans la page d'erreur critique</remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

#End Region

#Region "Boutton"

    Public Sub clicValider(sender As Object, e As EventArgs)
        Dim l_o_contrat As New Contrat
        Try
            With l_o_contrat
                ValidationManager.Validate(NumContrat, DateDebut, DateFin, Txremb)
                .Num_contrat = CStr(NumContrat.Text)
                .Dt_debut = DateDebut.Date
                .Dt_fin = DateFin.Date
                .TxRemb = Txremb.Value
                .Id_proprietaire = CInt(txtIdPropCache.Text)
                .Id_animal = CInt(txtIdAnimalCache.Text)
                l_o_contrat.Save()
            End With
        Catch ex As Exception
            ShowException(ex)
        End Try

    End Sub

#End Region

#Region "Grille"



#End Region

#Region "SelectTextBox"

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
                    End If
                Else
                    ShowInfo("Pour sélectionner un propriétaire, veuillez cliquer sur le bouton à droite de la zone.")
                    stbProprio.Text = ""
                End If
            End If
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

#End Region

#Region "TextBox"

    Private Sub txtIdPropCache_TextChanged(sender As Object, e As EventArgs) Handles txtIdPropCache.TextChanged

    End Sub

#End Region

End Class
