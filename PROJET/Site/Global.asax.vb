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
                .AddSubAdminTable("AnimalDocuments", Tables.VITAL_ANIMALDOCS)
                .AddSubAdminTable("Assurance", Tables.VTL_ASSURANCE)
                .AddSubAdminTable("Carte", Tables.VTL_CARTE)
                .AddSubAdminTable("User", Tables.VTL_USER)
                .AddSubAdminTable("Consultation", Tables.VTL_CONSULTATION)
                .AddSubAdminTable("Vaccin", Tables.VTL_VACCIN)
                .AddSubAdminTable("Vaccination", Tables.VTL_VACCINATION)
                .AddSubAdminTable("Vétérinaire", Tables.VTL_VETERINAIRE)
                .AddSubAdminTable("Contrat", Tables.VTL_CONTRAT)
                .AddSubAdminTable("Médicament", Tables.VTL_MEDICAMENT)
                .AddSubAdminTable("Poids", Tables.VTL_HISTO_POIDS)
                .AddSubAdminTable("Position", Tables.VTL_POSITION)
                .AddSubAdminTable("Propriétaire", Tables.VTL_PROPRIETAIRE)
                .AddSubAdminTable("Race", Tables.VTL_RACE)
                .AddSubAdminTable("Taille", Tables.VTL_HISTO_TAILLE)
                .AddSubAdminTable("Traitement médicaments", Tables.VTL_TRAITEMENT_MEDICAMENT)
                .AddSubAdminTable("Traitement", Tables.VTL_TRAITREMENT)
                .AddSubAdminTable("TYPE", Tables.VTL_TYPE)
                .AddSubAdminTable("Remboursement", Tables.VTL_REMBOURSMT)
                .AddSubAdminTable("Attachement", Tables.VTL_ATTACHEMT)
            End If
            If UserIsInRole("Veto") Or UserIsInRole("Admin") Then
                .Add("Sélectionner un animal", "~/Pages/Veterinaire/AuthAnimal.aspx")
                .Add("Créer un nouveau animal", "~/Pages/Veterinaire/AccueilAnimal.aspx?Mode=" & EN_ModeAcces.Creation, , "tabNewAnimal")
                .Add("Liste des consultations", "~/Pages/Veterinaire/ListeConsult.aspx?ID=" & Veterinaire.GetIdVetoConnectedUser(UserLogin()))
                .Add("Paramétrage")
                .AddSubAdminTable("Vaccins", Tables.VTL_VACCIN)
                .AddSubAdminTable("Médicaments", Tables.VTL_MEDICAMENT)
            End If
            If UserIsInRole("Mutuelle") Or UserIsInRole("Admin") Then
                .Add("Mutuelle", "~/Pages/Mutuelle/AccueilMutuelle.aspx")
                .Add("Remboursements", "~/Pages/Mutuelle/RemboursementByStatut.aspx")
            End If
            If UserIsInRole("Proprietaire") Or UserIsInRole("Admin") Then
                ' Chargement des animaux
                Dim l_o_animal As Animal
                ' S'il a des animaux 
                If Animal.GetNbAnimaux(UserLogin()) <> 0 Then
                    'Pour chaqun d'entre eux
                    For Each l_o_row As DataRow In Animal.GetAnimauxProprio(UserLogin()).GetDT.Rows
                        l_o_animal = New Animal
                        l_o_animal.Load(NzInt(l_o_row(VTL_ANIMAL.VTL_ANIMAL_ID)))
                        '         .AddSubSub("Générales", "~/Pages/Proprio/AnimalGeneral.aspx?ID=" & l_o_animal.ID & "&DemID=" & XX)

                        .Add(l_o_animal.Nom)
                        .AddSub("Informations")
                        .AddSubSub("Générales", "~/Pages/Proprio/AnimalGeneral.aspx?ID=" & l_o_animal.ID, , "tabInfoGene" + CStr(l_o_animal.ID))
                        .AddSubSub("Suivi poids et taille", "~/Pages/Proprio/SuiviPoids.aspx?ID=" & l_o_animal.ID, , "tabSuivPoids" + CStr(l_o_animal.ID))
                        .AddSubSub("Historique vaccins et traitements", "~/Pages/Proprio/HistoVaccinTraitemt.aspx?ID=" & l_o_animal.ID, , "tabHistoVac" + CStr(l_o_animal.ID))
                        .AddSubSub("Historique consultations", "~/Pages/Proprio/HistoConsul.aspx?ID=" & l_o_animal.ID, , "tabHistConsul" + CStr(l_o_animal.ID))
                        .AddSubSub("Documents", "~/Pages/Proprio/Documents.aspx?ID=" & l_o_animal.ID, , "tabDocs" + CStr(l_o_animal.ID))
                        'TODO : créer les pages
                        .AddSub("Mes remboursements", "~/Pages/Proprio/MesRemboursements.aspx?ID=" & l_o_animal.ID, , "tabRemboursemt" + CStr(l_o_animal.ID))
                        .AddSub("Mon contrat", "~/Pages/Proprio/.aspx?ID=" & l_o_animal.ID, , "tabContrat" + CStr(l_o_animal.ID))
                        .AddSubSub("Mes droits", "~/Pages/Proprio/.aspx?ID=" & l_o_animal.ID, , "tabDroit" + CStr(l_o_animal.ID))
                        .AddSubSub("Mon espace", "~/Pages/Proprio/.aspx?ID=" & l_o_animal.ID, , "tabEspace" + CStr(l_o_animal.ID))
                        .AddSub("Infos pratiques", "~/Pages/Proprio/.aspx?ID=" & l_o_animal.ID, , "tabInfoPratique" + CStr(l_o_animal.ID))
                        .AddSub("Contact", "~/Pages/Proprio/.aspx?ID=" & l_o_animal.ID, , "tabContact" + CStr(l_o_animal.ID))
                    Next
                End If
                ' Infos du proprio
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
