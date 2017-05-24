Imports VITAL.BO
Imports VITAL.BO.VITAL

''' <summary>
''' Application principale.
''' </summary>
Public Class MainApplication
    Inherits WebApplication

#Region "Initialisation de la base de données"

    ''' <summary>
    ''' Méthode permettant de charger la liste des bases de données qui
    ''' vont être utilisées par l'application. La première base de donnée
    ''' étant considérée comme la base de donnée par défaut
    ''' </summary>
    ''' <param name="p_o_list"></param>
    Protected Overrides Sub InitDatabases(ByVal p_o_list As Corail.Core.DataBaseList)
        BO.Main.InitDatabases(p_o_list)
    End Sub

#End Region

#Region "Authentification de l'utilisateur"

    ''' <summary>
    ''' Chargement des informations (Mot de passe et groupes de l'utilisateur).
    ''' </summary>
    ''' <param name="p_o_identity">Identité de l'utilisateur.</param>
    Protected Overrides Sub LoadUserIdentity(p_o_identity As UserIdentity)
        Dim l_o_user As New User

        l_o_user = BO.VITAL.User.GetConnectedUser(p_o_identity.Login)
        If (Not l_o_user Is Nothing) Then
            'On vérifie l'identifiant de l'utilisateur
            If UpperWord(p_o_identity.Login) = UpperWord(l_o_user.Login) Then
                'On récupère le mot de passe précédement enregistré
                p_o_identity.SetUnsafePassword(l_o_user.Mdp)
                ' On définit le profil à utiliser
                ' Administrator
                If (l_o_user.Role = "Admin") Then p_o_identity.AddGroup("ADMIN")
                ' Vétérinaire
                If (l_o_user.Role = "Veto") Then p_o_identity.AddGroup("VETER")
                ' Mutuelle
                If (l_o_user.Role = "Mutuelle") Then p_o_identity.AddGroup("MUT")
                ' Proprietaire
                If (l_o_user.Role = "Proprietaire") Then p_o_identity.AddGroup("PROP")
            End If
        End If
    End Sub

#End Region

#Region "Chargement du menu et de la barre d'outils"

    ''' <summary>
    ''' Chargement du menu principal de l'application.
    ''' </summary>
    ''' <param name="Menu">Menu principal de l'application.</param>
    ''' <param name="IsAuthenticated">Indique si l'utilisateur est actuellement connecté.</param>
    Public Overrides Sub LoadMenu(Menu As ApplicationMenu, IsAuthenticated As Boolean)
        With Menu
            If UserIsInRole("Admin") Then
                .Add("Administration").ImageName = "cog"
                .AddSubAdminTable("Adopter", Tables.VTL_ADOPTER)
                .AddSubAdminTable("Animal", Tables.VTL_ANIMAL)
                .AddSubAdminTable("Assurance", Tables.VTL_ASSURANCE)
                .AddSubAdminTable("Carte", Tables.VTL_CARTE)
                .AddSubAdminTable("User", Tables.VTL_USER)
                .AddSubAdminTable("CONSULTATION", Tables.VTL_CONSULTATION)
                .AddSubAdminTable("VACCIN", Tables.VTL_VACCIN)
                .AddSubAdminTable("VACCINATION", Tables.VTL_VACCINATION)
                .AddSubAdminTable("VETERINAIRE", Tables.VTL_VETERINAIRE)
                .AddSubAdminTable("CONTRAT", Tables.VTL_CONTRAT)
                .AddSubAdminTable("MEDICAMENT", Tables.VTL_MEDICAMENT)
                .AddSubAdminTable("POSITION", Tables.VTL_POSITION)
                .AddSubAdminTable("PROPRIETAIRE", Tables.VTL_PROPRIETAIRE)
                .AddSubAdminTable("RACE", Tables.VTL_RACE)
                .AddSubAdminTable("TRAITEMENT_MEDICAMENT", Tables.VTL_TRAITEMENT_MEDICAMENT)
                .AddSubAdminTable("TRAITREMENT", Tables.VTL_TRAITREMENT)
                .AddSubAdminTable("TYPE", Tables.VTL_TYPE)
            End If
            If UserIsInRole("Veto") Or UserIsInRole("Admin") Then
                .Add("Veto", "~/Pages/AccueilVeto.aspx")
                .Add("Historique des consultations", "~/Pages/histo_consultation.aspx")
            End If
            If UserIsInRole("Mutuelle") Or UserIsInRole("Admin") Then
                .Add("Mutuelle", "~/Pages/AccueilMutuelle.aspx")
            End If
            If UserIsInRole("Proprietaire") Or UserIsInRole("Admin") Then
                .Add("NomAnimal", "~/Pages/Proprio/Animal.aspx")
                .AddSub("Informations")
                .AddSubSub("Générales", "~/Pages/Proprio/AnimalGeneral.aspx")
                .AddSubSub("Suivi du poids", "~/Pages/Proprio/SuiviPoids.aspx")
                .AddSubSub("Historique vaccins et traitements", "~/Pages/Proprio/HistoVaccinTraitemt.aspx")
                .AddSubSub("Historique consultations", "~/Pages/Proprio/HistoConsul.aspx")
                .AddSubSub("Documents", "~/Pages/Proprio/Documents.aspx")
                .AddSubSub("Générales", "")
                .AddSubSub("Générales", "")
                .AddSubSub("Générales", "")
                .AddSub("Mes remboursements", "")
                .AddSub("Mon contrat", "")
                .AddSubSub("Mes droits", "")
                .AddSubSub("Mon espace", "")
                .AddSub("Localisation", "")
                .AddSub("Infos pratiques", "")
                .AddSub("Contact", "")
                .AddSub("Informations", "")
                .Add("Mes informations", "~/Pages/Proprio/Informations.aspx")
            End If
#If DEBUG Then
            ' Menu pour le développeur
            .AddDebugMenu()
#End If
        End With
    End Sub

    ''' <summary>
    ''' Chargement de la barre d'outils principale de l'application.
    ''' </summary>
    ''' <param name="ToolBar">Barre d'outils principale de l'application.</param>
    ''' <param name="IsAuthenticated">Indique si l'utilisateur est actuellement connecté.</param>
    Public Overrides Sub LoadToolbar(ToolBar As ApplicationToolbar, IsAuthenticated As Boolean)
        With ToolBar
            ' Déconnexion
            .AddDisconnect()
            ' A propos
            .AddAbout()
            ' Thèmes
            .AddPalette()
        End With
    End Sub

#End Region

End Class
