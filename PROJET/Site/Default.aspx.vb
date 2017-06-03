Partial Public Class PageDefault
    Inherits CwPageDefault

#Region "Définition de la page de démarrage de l'application"

    ''' <summary>
    ''' Définition de la page de démarage à utiliser dans la frame de droite
    ''' </summary>
    Public Overrides ReadOnly Property StartPage() As String
        Get
            If UserIsInRole("Admin") Then
                Return "~/Pages/AccueilAdmin.aspx"
            ElseIf UserIsInRole("Veto") Then
                Return "~/Pages/Veterinaire/AuthAnimal.aspx"
            ElseIf UserIsInRole("Mutuelle") Then
                Return "~/Pages/Mutuelle/AccueilMutuelle.aspx"
            ElseIf UserIsInRole("Proprietaire") Then
                Return "~/Pages/Proprio/AccueilProprietaire.aspx"
            End If
            Return "Welcome.aspx"
        End Get
    End Property

#End Region

End Class
