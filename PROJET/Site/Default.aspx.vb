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

                ' Si acces par URL carte NFC
                If (CStr(Request.QueryString("acces")) = "direct") Then
                    ' NFC en paramètre
                    Dim NFC As String
                    NFC = CStr(Request.QueryString("NFC"))

                    ' Retrouver ID Animal
                    Dim id As String

                    id = retrouverAnimalParNFC(NFC)

                    'Si le numéro NFC n'existe pas
                    If id = "0" Then
                        Return "~/Pages/Veterinaire/AuthAnimal.aspx?NFC=erreur"
                    End If

                    Return "~/Pages/Veterinaire/AccueilAnimal.aspx?ID=" & id & "&Mode=1"
                Else
                    Return "~/Pages/Veterinaire/AuthAnimal.aspx"
                End If
            ElseIf UserIsInRole("Mutuelle") Then
                Return "~/Pages/Mutuelle/AccueilMutuelle.aspx"
            ElseIf UserIsInRole("Proprietaire") Then
                If (CStr(Request.QueryString("acces")) = "direct") Then
                    ' NFC en paramètre
                    Dim NFC As String
                    NFC = CStr(Request.QueryString("NFC"))

                    ' Retrouver ID Animal
                    Dim id As String

                    id = retrouverAnimalParNFC(NFC)

                    'Si le numéro NFC n'existe pas
                    If id = "0" Then
                        Return "~/Pages/Proprio/AccueilProprietaire.aspx?NFC=erreur"
                    End If
                    Return "~/Pages/Proprio/AnimalGeneral.aspx?ID=" & id
                Else
                    Return "~/Pages/Proprio/AccueilProprietaire.aspx"
                End If
            End If
            Return "Welcome.aspx"
        End Get
    End Property

#End Region

    'Retrouve l'ID d'un animal à partir de son numéro NFC
    Private Function retrouverAnimalParNFC(NFC As String) As String

        'ID à retourner
        Dim ID As String
        ID = "0"

        'Recherche des animaux avec le numero NFC en paramètre
        Dim dt As DataTable
        dt = BO.VITAL.Animal.GetAnimxSearched("", "", "", "", NFC).GetDT

        'nomber de résultats trouvés
        Dim results As Integer
        results = dt.Rows.Count

        If results = 1 Then
            'ID de l'animal
            'sil vous plait, pas de doublons !!!
            Dim row As DataRow
            For Each row In dt.Rows
                ID = CStr(row("VTL_ANIMAL_ID"))
            Next
        End If
        Return ID

    End Function
End Class
