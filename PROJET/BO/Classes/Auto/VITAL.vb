Namespace VITAL

#Region "Constantes"

#Region "Enumération"

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public Enum EN_HistoSort
        None
        Asc
        Desc
    End Enum

#End Region

#Region "Tables du schéma VITAL."

    ''' <summary>
    ''' Tables du schéma VITAL.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class Tables

        ''' <summary>
        ''' AnimalDocs.
        ''' </summary>
        Public Const VITAL_ANIMALDOCS As String = "VITAL_ANIMALDOCS"

        ''' <summary>
        ''' Adopter : Associations etre propriétaire et animal.
        ''' </summary>
        Public Const VTL_ADOPTER As String = "VTL_ADOPTER"

        ''' <summary>
        ''' Animal.
        ''' </summary>
        Public Const VTL_ANIMAL As String = "VTL_ANIMAL"

        ''' <summary>
        ''' Assurance.
        ''' </summary>
        Public Const VTL_ASSURANCE As String = "VTL_ASSURANCE"

        ''' <summary>
        ''' Attachement.
        ''' </summary>
        Public Const VTL_ATTACHEMT As String = "VTL_ATTACHEMT"

        ''' <summary>
        ''' Carte vitale.
        ''' </summary>
        Public Const VTL_CARTE As String = "VTL_CARTE"

        ''' <summary>
        ''' ConseilDietetique.
        ''' </summary>
        Public Const VTL_CNSLDIET As String = "VTL_CNSLDIET"

        ''' <summary>
        ''' Consultation vétérinaire d'un animal.
        ''' </summary>
        Public Const VTL_CONSULTATION As String = "VTL_CONSULTATION"

        ''' <summary>
        ''' Contrat d'assurance.
        ''' </summary>
        Public Const VTL_CONTRAT As String = "VTL_CONTRAT"

        ''' <summary>
        ''' Historique du poids de l'animal.
        ''' </summary>
        Public Const VTL_HISTO_POIDS As String = "VTL_HISTO_POIDS"

        ''' <summary>
        ''' Historique de la taille de l'animal.
        ''' </summary>
        Public Const VTL_HISTO_TAILLE As String = "VTL_HISTO_TAILLE"

        ''' <summary>
        ''' Medicament.
        ''' </summary>
        Public Const VTL_MEDICAMENT As String = "VTL_MEDICAMENT"

        ''' <summary>
        ''' Position de l'animal.
        ''' </summary>
        Public Const VTL_POSITION As String = "VTL_POSITION"

        ''' <summary>
        ''' Propriétaire.
        ''' </summary>
        Public Const VTL_PROPRIETAIRE As String = "VTL_PROPRIETAIRE"

        ''' <summary>
        ''' Race de l'animal.
        ''' </summary>
        Public Const VTL_RACE As String = "VTL_RACE"

        ''' <summary>
        ''' Remboursement.
        ''' </summary>
        Public Const VTL_REMBOURSMT As String = "VTL_REMBOURSMT"

        ''' <summary>
        ''' Liste des médicaments compris dans un traitement.
        ''' </summary>
        Public Const VTL_TRAITEMENT_MEDICAMENT As String = "VTL_TRAITEMENT_MEDICAMENT"

        ''' <summary>
        ''' Traitrement.
        ''' </summary>
        Public Const VTL_TRAITREMENT As String = "VTL_TRAITREMENT"

        ''' <summary>
        ''' Typede l'animal.
        ''' </summary>
        Public Const VTL_TYPE As String = "VTL_TYPE"

        ''' <summary>
        ''' User.
        ''' </summary>
        Public Const VTL_USER As String = "VTL_USER"

        ''' <summary>
        ''' Vaccin.
        ''' </summary>
        Public Const VTL_VACCIN As String = "VTL_VACCIN"

        ''' <summary>
        ''' Vaccination d'un animal.
        ''' </summary>
        Public Const VTL_VACCINATION As String = "VTL_VACCINATION"

        ''' <summary>
        ''' Veterinaire.
        ''' </summary>
        Public Const VTL_VETERINAIRE As String = "VTL_VETERINAIRE"

    End Class

#End Region

#Region "VITAL_ANIMALDOCS - AnimalDocs"

    ''' <summary>
    ''' AnimalDocs.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VITAL_ANIMALDOCS

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const ANIMALDOCS_ID As String = "ANIMALDOCS_ID"

        ''' <summary>
        ''' Nom.
        ''' </summary>
        Public Const ANIMALDOCS_NOM As String = "ANIMALDOCS_NOM"

        ''' <summary>
        ''' Nom (Maxlen).
        ''' </summary>
        Public Const ANIMALDOCS_NOM_MAXLEN As Integer = 50

        ''' <summary>
        ''' Chemin.
        ''' </summary>
        Public Const ANIMALDOCS_CHEMIN As String = "ANIMALDOCS_CHEMIN"

        ''' <summary>
        ''' Chemin (Maxlen).
        ''' </summary>
        Public Const ANIMALDOCS_CHEMIN_MAXLEN As Integer = 255

        ''' <summary>
        ''' Id_Animal.
        ''' </summary>
        Public Const ANIMALDOCS_ID_ANIMAL As String = "ANIMALDOCS_ID_ANIMAL"

    End Class

#End Region

#Region "VTL_ADOPTER - Adopter : Associations etre propriétaire et animal"

    ''' <summary>
    ''' Adopter : Associations etre propriétaire et animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_ADOPTER

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_ADOPTER_ID As String = "VTL_ADOPTER_ID"

        ''' <summary>
        ''' Dt_debut.
        ''' </summary>
        Public Const VTL_ADOPTER_DT_DEBUT As String = "VTL_ADOPTER_DT_DEBUT"

        ''' <summary>
        ''' Dt_fin.
        ''' </summary>
        Public Const VTL_ADOPTER_DT_FIN As String = "VTL_ADOPTER_DT_FIN"

        ''' <summary>
        ''' Id_proprietaire.
        ''' </summary>
        Public Const VTL_ADOPTER_ID_PROPRIETAIRE As String = "VTL_ADOPTER_ID_PROPRIETAIRE"

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const VTL_ADOPTER_ID_ANIMAL As String = "VTL_ADOPTER_ID_ANIMAL"

    End Class

#End Region

#Region "VTL_ANIMAL - Animal"

    ''' <summary>
    ''' Animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_ANIMAL

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_ANIMAL_ID As String = "VTL_ANIMAL_ID"

        ''' <summary>
        ''' Nom.
        ''' </summary>
        Public Const VTL_ANIMAL_NOM As String = "VTL_ANIMAL_NOM"

        ''' <summary>
        ''' Nom (Maxlen).
        ''' </summary>
        Public Const VTL_ANIMAL_NOM_MAXLEN As Integer = 50

        ''' <summary>
        ''' Num_puce.
        ''' </summary>
        Public Const VTL_ANIMAL_NUM_PUCE As String = "VTL_ANIMAL_NUM_PUCE"

        ''' <summary>
        ''' Num_puce (Maxlen).
        ''' </summary>
        Public Const VTL_ANIMAL_NUM_PUCE_MAXLEN As Integer = 14

        ''' <summary>
        ''' Dt_naissance.
        ''' </summary>
        Public Const VTL_ANIMAL_DT_NAISSANCE As String = "VTL_ANIMAL_DT_NAISSANCE"

        ''' <summary>
        ''' Dt_deces.
        ''' </summary>
        Public Const VTL_ANIMAL_DT_DECES As String = "VTL_ANIMAL_DT_DECES"

        ''' <summary>
        ''' Id_race.
        ''' </summary>
        Public Const VTL_ANIMAL_ID_RACE As String = "VTL_ANIMAL_ID_RACE"

        ''' <summary>
        ''' Id_carte.
        ''' </summary>
        Public Const VTL_ANIMAL_ID_CARTE As String = "VTL_ANIMAL_ID_CARTE"

        ''' <summary>
        ''' Id_type.
        ''' </summary>
        Public Const VTL_ANIMAL_ID_TYPE As String = "VTL_ANIMAL_ID_TYPE"

        ''' <summary>
        ''' Id_prop.
        ''' </summary>
        Public Const VTL_ANIMAL_ID_PROP As String = "VTL_ANIMAL_ID_PROP"

        ''' <summary>
        ''' Image.
        ''' </summary>
        Public Const VTL_ANIMAL_IMAGE As String = "VTL_ANIMAL_IMAGE"

    End Class

#End Region

#Region "VTL_ASSURANCE - Assurance"

    ''' <summary>
    ''' Assurance.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_ASSURANCE

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_ASSURANCE_ID As String = "VTL_ASSURANCE_ID"

        ''' <summary>
        ''' Nom.
        ''' </summary>
        Public Const VTL_ASSURANCE_NOM As String = "VTL_ASSURANCE_NOM"

        ''' <summary>
        ''' Nom (Maxlen).
        ''' </summary>
        Public Const VTL_ASSURANCE_NOM_MAXLEN As Integer = 50

        ''' <summary>
        ''' Siret.
        ''' </summary>
        Public Const VTL_ASSURANCE_SIRET As String = "VTL_ASSURANCE_SIRET"

        ''' <summary>
        ''' Siret (Maxlen).
        ''' </summary>
        Public Const VTL_ASSURANCE_SIRET_MAXLEN As Integer = 50

    End Class

#End Region

#Region "VTL_ATTACHEMT - Attachement"

    ''' <summary>
    ''' Attachement.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_ATTACHEMT

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_ATTACHEMT_ID As String = "VTL_ATTACHEMT_ID"

        ''' <summary>
        ''' Name.
        ''' </summary>
        Public Const VTL_ATTACHEMT_NAME As String = "VTL_ATTACHEMT_NAME"

        ''' <summary>
        ''' Name (Maxlen).
        ''' </summary>
        Public Const VTL_ATTACHEMT_NAME_MAXLEN As Integer = 50

        ''' <summary>
        ''' Chemin.
        ''' </summary>
        Public Const VTL_ATTACHEMT_CHEMIN As String = "VTL_ATTACHEMT_CHEMIN"

        ''' <summary>
        ''' Chemin (Maxlen).
        ''' </summary>
        Public Const VTL_ATTACHEMT_CHEMIN_MAXLEN As Integer = 100

        ''' <summary>
        ''' Consult.
        ''' </summary>
        Public Const VTL_ATTACHEMT_CONSULT As String = "VTL_ATTACHEMT_CONSULT"

    End Class

#End Region

#Region "VTL_CARTE - Carte vitale"

    ''' <summary>
    ''' Carte vitale.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_CARTE

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_CARTE_ID As String = "VTL_CARTE_ID"

        ''' <summary>
        ''' Numero.
        ''' </summary>
        Public Const VTL_CARTE_NUMERO As String = "VTL_CARTE_NUMERO"

        ''' <summary>
        ''' Numero (Maxlen).
        ''' </summary>
        Public Const VTL_CARTE_NUMERO_MAXLEN As Integer = 50

        ''' <summary>
        ''' Nfc.
        ''' </summary>
        Public Const VTL_CARTE_NFC As String = "VTL_CARTE_NFC"

        ''' <summary>
        ''' Nfc (Maxlen).
        ''' </summary>
        Public Const VTL_CARTE_NFC_MAXLEN As Integer = 255

    End Class

#End Region

#Region "VTL_CNSLDIET - ConseilDietetique"

    ''' <summary>
    ''' ConseilDietetique.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_CNSLDIET

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const CNSLDIET_ID As String = "CNSLDIET_ID"

        ''' <summary>
        ''' Contenu.
        ''' </summary>
        Public Const CNSLDIET_CONTENU As String = "CNSLDIET_CONTENU"

        ''' <summary>
        ''' Contenu (Maxlen).
        ''' </summary>
        Public Const CNSLDIET_CONTENU_MAXLEN As Integer = 2000

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const CNSLDIET_ID_ANIMAL As String = "CNSLDIET_ID_ANIMAL"

        ''' <summary>
        ''' Date.
        ''' </summary>
        Public Const CNSLDIET_DATE As String = "CNSLDIET_DATE"

    End Class

#End Region

#Region "VTL_CONSULTATION - Consultation vétérinaire d'un animal"

    ''' <summary>
    ''' Consultation vétérinaire d'un animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_CONSULTATION

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_CONSULTATION_ID As String = "VTL_CONSULTATION_ID"

        ''' <summary>
        ''' Montant.
        ''' </summary>
        Public Const VTL_CONSULTATION_MONTANT As String = "VTL_CONSULTATION_MONTANT"

        ''' <summary>
        ''' Commentaire.
        ''' </summary>
        Public Const VTL_CONSULTATION_COMMENTAIRE As String = "VTL_CONSULTATION_COMMENTAIRE"

        ''' <summary>
        ''' Commentaire (Maxlen).
        ''' </summary>
        Public Const VTL_CONSULTATION_COMMENTAIRE_MAXLEN As Integer = 255

        ''' <summary>
        ''' Id_veterinaire.
        ''' </summary>
        Public Const VTL_CONSULTATION_ID_VETERINAIRE As String = "VTL_CONSULTATION_ID_VETERINAIRE"

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const VTL_CONSULTATION_L As String = "VTL_CONSULTATION_L"

        ''' <summary>
        ''' Dt_Consultation.
        ''' </summary>
        Public Const VTL_CONSULTATION_DT_CONSULTATION As String = "VTL_CONSULTATION_DT_CONSULTATION"

    End Class

#End Region

#Region "VTL_CONTRAT - Contrat d'assurance"

    ''' <summary>
    ''' Contrat d'assurance.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_CONTRAT

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_CONTRAT_ID As String = "VTL_CONTRAT_ID"

        ''' <summary>
        ''' Num_contrat.
        ''' </summary>
        Public Const VTL_CONTRAT_NUM_CONTRAT As String = "VTL_CONTRAT_NUM_CONTRAT"

        ''' <summary>
        ''' Num_contrat (Maxlen).
        ''' </summary>
        Public Const VTL_CONTRAT_NUM_CONTRAT_MAXLEN As Integer = 50

        ''' <summary>
        ''' Dt_debut.
        ''' </summary>
        Public Const VTL_CONTRAT_DT_DEBUT As String = "VTL_CONTRAT_DT_DEBUT"

        ''' <summary>
        ''' Dt_fin.
        ''' </summary>
        Public Const VTL_CONTRAT_DT_FIN As String = "VTL_CONTRAT_DT_FIN"

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const VTL_CONTRAT_ID_ANIMAL As String = "VTL_CONTRAT_ID_ANIMAL"

        ''' <summary>
        ''' Id_proprietaire.
        ''' </summary>
        Public Const VTL_CONTRAT_ID_PROPRIETAIRE As String = "VTL_CONTRAT_ID_PROPRIETAIRE"

        ''' <summary>
        ''' Id_assurance.
        ''' </summary>
        Public Const VTL_CONTRAT_ID_ASSURANCE As String = "VTL_CONTRAT_ID_ASSURANCE"

    End Class

#End Region

#Region "VTL_HISTO_POIDS - Historique du poids de l'animal"

    ''' <summary>
    ''' Historique du poids de l'animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_HISTO_POIDS

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_HISTO_POIDS_ID As String = "VTL_HISTO_POIDS_ID"

        ''' <summary>
        ''' Dt_histo.
        ''' </summary>
        Public Const VTL_HISTO_POIDS_DT_HISTO As String = "VTL_HISTO_POIDS_DT_HISTO"

        ''' <summary>
        ''' Poids.
        ''' </summary>
        Public Const VTL_HISTO_POIDS_POIDS As String = "VTL_HISTO_POIDS_POIDS"

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const VTL_HISTO_POIDS_ID_ANIMAL As String = "VTL_HISTO_POIDS_ID_ANIMAL"

    End Class

#End Region

#Region "VTL_HISTO_TAILLE - Historique de la taille de l'animal"

    ''' <summary>
    ''' Historique de la taille de l'animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_HISTO_TAILLE

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_HISTO_TAILLE_ID As String = "VTL_HISTO_TAILLE_ID"

        ''' <summary>
        ''' Dt_histo.
        ''' </summary>
        Public Const VTL_HISTO_TAILLE_DT_HISTO As String = "VTL_HISTO_TAILLE_DT_HISTO"

        ''' <summary>
        ''' Taille.
        ''' </summary>
        Public Const VTL_HISTO_TAILLE_TAILLE As String = "VTL_HISTO_TAILLE_TAILLE"

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const VTL_HISTO_TAILLE_ID_ANIMAL As String = "VTL_HISTO_TAILLE_ID_ANIMAL"

    End Class

#End Region

#Region "VTL_MEDICAMENT - Medicament"

    ''' <summary>
    ''' Medicament.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_MEDICAMENT

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_MEDICAMENT_ID As String = "VTL_MEDICAMENT_ID"

        ''' <summary>
        ''' Libelle.
        ''' </summary>
        Public Const VTL_MEDICAMENT_LIBELLE As String = "VTL_MEDICAMENT_LIBELLE"

        ''' <summary>
        ''' Libelle (Maxlen).
        ''' </summary>
        Public Const VTL_MEDICAMENT_LIBELLE_MAXLEN As Integer = 50

        ''' <summary>
        ''' Dosage.
        ''' </summary>
        Public Const VTL_MEDICAMENT_DOSAGE As String = "VTL_MEDICAMENT_DOSAGE"

        ''' <summary>
        ''' Dosage (Maxlen).
        ''' </summary>
        Public Const VTL_MEDICAMENT_DOSAGE_MAXLEN As Integer = 50

        ''' <summary>
        ''' Duree_moyenne_jour.
        ''' </summary>
        Public Const VTL_MEDICAMENT_DUREE_MOYENNE_JOUR As String = "VTL_MEDICAMENT_DUREE_MOYENNE_JOUR"

    End Class

#End Region

#Region "VTL_POSITION - Position de l'animal"

    ''' <summary>
    ''' Position de l'animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_POSITION

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_POSITION_ID As String = "VTL_POSITION_ID"

        ''' <summary>
        ''' Dt_position.
        ''' </summary>
        Public Const VTL_POSITION_DT_POSITION As String = "VTL_POSITION_DT_POSITION"

        ''' <summary>
        ''' Coord_lat.
        ''' </summary>
        Public Const VTL_POSITION_COORD_LAT As String = "VTL_POSITION_COORD_LAT"

        ''' <summary>
        ''' Coord_lat (Maxlen).
        ''' </summary>
        Public Const VTL_POSITION_COORD_LAT_MAXLEN As Integer = 50

        ''' <summary>
        ''' Coord_long.
        ''' </summary>
        Public Const VTL_POSITION_COORD_LONG As String = "VTL_POSITION_COORD_LONG"

        ''' <summary>
        ''' Coord_long (Maxlen).
        ''' </summary>
        Public Const VTL_POSITION_COORD_LONG_MAXLEN As Integer = 50

        ''' <summary>
        ''' Top_courante.
        ''' </summary>
        Public Const VTL_POSITION_TOP_COURANTE As String = "VTL_POSITION_TOP_COURANTE"

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const VTL_POSITION_ID_ANIMAL As String = "VTL_POSITION_ID_ANIMAL"

    End Class

#End Region

#Region "VTL_PROPRIETAIRE - Propriétaire"

    ''' <summary>
    ''' Propriétaire.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_PROPRIETAIRE

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_PROPRIETAIRE_ID As String = "VTL_PROPRIETAIRE_ID"

        ''' <summary>
        ''' Nom.
        ''' </summary>
        Public Const VTL_PROPRIETAIRE_NOM As String = "VTL_PROPRIETAIRE_NOM"

        ''' <summary>
        ''' Nom (Maxlen).
        ''' </summary>
        Public Const VTL_PROPRIETAIRE_NOM_MAXLEN As Integer = 50

        ''' <summary>
        ''' Prenom.
        ''' </summary>
        Public Const VTL_PROPRIETAIRE_PRENOM As String = "VTL_PROPRIETAIRE_PRENOM"

        ''' <summary>
        ''' Prenom (Maxlen).
        ''' </summary>
        Public Const VTL_PROPRIETAIRE_PRENOM_MAXLEN As Integer = 50

    End Class

#End Region

#Region "VTL_RACE - Race de l'animal"

    ''' <summary>
    ''' Race de l'animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_RACE

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_RACE_ID As String = "VTL_RACE_ID"

        ''' <summary>
        ''' Nom.
        ''' </summary>
        Public Const VTL_RACE_NOM As String = "VTL_RACE_NOM"

        ''' <summary>
        ''' Nom (Maxlen).
        ''' </summary>
        Public Const VTL_RACE_NOM_MAXLEN As Integer = 50

    End Class

#End Region

#Region "VTL_REMBOURSMT - Remboursement"

    ''' <summary>
    ''' Remboursement.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_REMBOURSMT

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_REMBOURSMT_ID As String = "VTL_REMBOURSMT_ID"

        ''' <summary>
        ''' Name.
        ''' </summary>
        Public Const VTL_REMBOURSMT_NAME As String = "VTL_REMBOURSMT_NAME"

        ''' <summary>
        ''' Name (Maxlen).
        ''' </summary>
        Public Const VTL_REMBOURSMT_NAME_MAXLEN As Integer = 50

        ''' <summary>
        ''' Date.
        ''' </summary>
        Public Const VTL_REMBOURSMT_DATE As String = "VTL_REMBOURSMT_DATE"

        ''' <summary>
        ''' Statut.
        ''' </summary>
        Public Const VTL_REMBOURSMT_STATUT As String = "VTL_REMBOURSMT_STATUT"

        ''' <summary>
        ''' Statut (Maxlen).
        ''' </summary>
        Public Const VTL_REMBOURSMT_STATUT_MAXLEN As Integer = 50

        ''' <summary>
        ''' Consult.
        ''' </summary>
        Public Const VTL_REMBOURSMT_CONSULT As String = "VTL_REMBOURSMT_CONSULT"

        ''' <summary>
        ''' Contrat.
        ''' </summary>
        Public Const VTL_REMBOURSMT_CONTRAT As String = "VTL_REMBOURSMT_CONTRAT"

    End Class

#End Region

#Region "VTL_TRAITEMENT_MEDICAMENT - Liste des médicaments compris dans un traitement"

    ''' <summary>
    ''' Liste des médicaments compris dans un traitement.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_TRAITEMENT_MEDICAMENT

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_TRAITEMENT_MEDICAMENT_ID As String = "VTL_TRAITEMENT_MEDICAMENT_ID"

        ''' <summary>
        ''' Id_traitement.
        ''' </summary>
        Public Const VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT As String = "VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT"

        ''' <summary>
        ''' Id_medicament.
        ''' </summary>
        Public Const VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT As String = "VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT"

        ''' <summary>
        ''' Posologie.
        ''' </summary>
        Public Const VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE As String = "VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE"

        ''' <summary>
        ''' Duree_jour.
        ''' </summary>
        Public Const VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR As String = "VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR"

    End Class

#End Region

#Region "VTL_TRAITREMENT - Traitrement"

    ''' <summary>
    ''' Traitrement.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_TRAITREMENT

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_TRAITREMENT_ID As String = "VTL_TRAITREMENT_ID"

        ''' <summary>
        ''' Duree_jour.
        ''' </summary>
        Public Const VTL_TRAITREMENT_DUREE_JOUR As String = "VTL_TRAITREMENT_DUREE_JOUR"

        ''' <summary>
        ''' Dt_debut.
        ''' </summary>
        Public Const VTL_TRAITREMENT_DT_DEBUT As String = "VTL_TRAITREMENT_DT_DEBUT"

    End Class

#End Region

#Region "VTL_TYPE - Typede l'animal"

    ''' <summary>
    ''' Typede l'animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_TYPE

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_TYPE_ID As String = "VTL_TYPE_ID"

        ''' <summary>
        ''' Libelle.
        ''' </summary>
        Public Const VTL_TYPE_LIBELLE As String = "VTL_TYPE_LIBELLE"

        ''' <summary>
        ''' Libelle (Maxlen).
        ''' </summary>
        Public Const VTL_TYPE_LIBELLE_MAXLEN As Integer = 50

    End Class

#End Region

#Region "VTL_USER - User"

    ''' <summary>
    ''' User.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_USER

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_USER_ID As String = "VTL_USER_ID"

        ''' <summary>
        ''' Login.
        ''' </summary>
        Public Const VTL_USER_LOGIN As String = "VTL_USER_LOGIN"

        ''' <summary>
        ''' Login (Maxlen).
        ''' </summary>
        Public Const VTL_USER_LOGIN_MAXLEN As Integer = 50

        ''' <summary>
        ''' Mdp.
        ''' </summary>
        Public Const VTL_USER_MDP As String = "VTL_USER_MDP"

        ''' <summary>
        ''' Mdp (Maxlen).
        ''' </summary>
        Public Const VTL_USER_MDP_MAXLEN As Integer = 50

        ''' <summary>
        ''' Role.
        ''' </summary>
        Public Const VTL_USER_ROLE As String = "VTL_USER_ROLE"

        ''' <summary>
        ''' Role (Maxlen).
        ''' </summary>
        Public Const VTL_USER_ROLE_MAXLEN As Integer = 50

    End Class

#End Region

#Region "VTL_VACCIN - Vaccin"

    ''' <summary>
    ''' Vaccin.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_VACCIN

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_VACCIN_ID As String = "VTL_VACCIN_ID"

        ''' <summary>
        ''' Libelle.
        ''' </summary>
        Public Const VTL_VACCIN_LIBELLE As String = "VTL_VACCIN_LIBELLE"

        ''' <summary>
        ''' Libelle (Maxlen).
        ''' </summary>
        Public Const VTL_VACCIN_LIBELLE_MAXLEN As Integer = 50

        ''' <summary>
        ''' Top_periodique.
        ''' </summary>
        Public Const VTL_VACCIN_TOP_PERIODIQUE As String = "VTL_VACCIN_TOP_PERIODIQUE"

        ''' <summary>
        ''' Periode_mois.
        ''' </summary>
        Public Const VTL_VACCIN_PERIODE_MOIS As String = "VTL_VACCIN_PERIODE_MOIS"

        ''' <summary>
        ''' Top_recommandation.
        ''' </summary>
        Public Const VTL_VACCIN_TOP_RECOMMANDATION As String = "VTL_VACCIN_TOP_RECOMMANDATION"

    End Class

#End Region

#Region "VTL_VACCINATION - Vaccination d'un animal"

    ''' <summary>
    ''' Vaccination d'un animal.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_VACCINATION

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_VACCINATION_ID As String = "VTL_VACCINATION_ID"

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
        Public Const VTL_VACCINATION_ID_ANIMAL As String = "VTL_VACCINATION_ID_ANIMAL"

        ''' <summary>
        ''' Id_vaccin.
        ''' </summary>
        Public Const VTL_VACCINATION_ID_VACCIN As String = "VTL_VACCINATION_ID_VACCIN"

        ''' <summary>
        ''' Dt_vaccin.
        ''' </summary>
        Public Const VTL_VACCINATION_DT_VACCIN As String = "VTL_VACCINATION_DT_VACCIN"

        ''' <summary>
        ''' Id_consultation.
        ''' </summary>
        Public Const VTL_VACCINATION_ID_CONSULTATION As String = "VTL_VACCINATION_ID_CONSULTATION"

    End Class

#End Region

#Region "VTL_VETERINAIRE - Veterinaire"

    ''' <summary>
    ''' Veterinaire.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public NotInheritable Class VTL_VETERINAIRE

        ''' <summary>
        ''' ID.
        ''' </summary>
        Public Const VTL_VETERINAIRE_ID As String = "VTL_VETERINAIRE_ID"

        ''' <summary>
        ''' Nom.
        ''' </summary>
        Public Const VTL_VETERINAIRE_NOM As String = "VTL_VETERINAIRE_NOM"

        ''' <summary>
        ''' Nom (Maxlen).
        ''' </summary>
        Public Const VTL_VETERINAIRE_NOM_MAXLEN As Integer = 50

        ''' <summary>
        ''' Prenom.
        ''' </summary>
        Public Const VTL_VETERINAIRE_PRENOM As String = "VTL_VETERINAIRE_PRENOM"

        ''' <summary>
        ''' Prenom (Maxlen).
        ''' </summary>
        Public Const VTL_VETERINAIRE_PRENOM_MAXLEN As Integer = 50

        ''' <summary>
        ''' SIRET.
        ''' </summary>
        Public Const VTL_VETERINAIRE_SIRET As String = "VTL_VETERINAIRE_SIRET"

        ''' <summary>
        ''' SIRET (Maxlen).
        ''' </summary>
        Public Const VTL_VETERINAIRE_SIRET_MAXLEN As Integer = 50

        ''' <summary>
        ''' id_user.
        ''' </summary>
        Public Const VTL_VETERINAIRE_ID_USER As String = "VTL_VETERINAIRE_ID_USER"

    End Class

#End Region

#End Region

#Region "Classes partagées"

    <Serializable()>
    Partial Public MustInherit Class Schema

#Region "Variables privées"

        ''' <summary>
        ''' Base de donnée liée à "VITAL".
        ''' </summary>
        Private Shared m_o_db As Corail.Core.DataBase

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Base de donnée liée à "VITAL".
        ''' </summary>
        ''' <value> Base de donnée liée.</value>
        Public Shared ReadOnly Property DB As Corail.Core.DataBase
            Get
                Return m_o_db
            End Get
        End Property

#End Region

#Region "Méthodes protégées"

        ''' <summary>
        ''' Retourne la valeur à utiliser dans la requête.
        ''' </summary>
        ''' <param name="p_l_value">Valeur que l'on souhaite enregistrer.</param>
        ''' <param name="p_l_null">Valeur étant remplacée par NULL.</param>
        ''' <returns>La valeur à utiliser dans la requête.</returns>
        Protected Shared Function NullIfValue(p_l_value As Long, p_l_null As Long) As String
            If p_l_value = p_l_null Then
                ' Cas spécifique
                Return "NULL"
            Else
                ' Cas général
                Return p_l_value.ToString()
            End If
        End Function

        ''' <summary>
        ''' Retourne la valeur à utiliser dans la requête.
        ''' </summary>
        ''' <param name="p_r_value">Valeur que l'on souhaite enregistrer.</param>
        ''' <param name="p_r_null">Valeur étant remplacée par NULL.</param>
        ''' <returns>La valeur à utiliser dans la requête.</returns>
        Protected Shared Function NullIfValue(p_r_value As Double, p_r_null As Double) As String
            If p_r_value = p_r_null Then
                ' Cas spécifique
                Return "NULL"
            Else
                ' Cas général
                Return NumSQL(p_r_value)
            End If
        End Function

        ''' <summary>
        ''' Met des quotes autour de la chaine de texte.
        ''' </summary>
        ''' <param name="p_s">Texte.</param>
        ''' <returns>La valeur à utiliser dans la requête.</returns>
        Protected Shared Function TextSQLEmpty(p_s As String) As String
            ' Cas spécifique
            If p_s Is String.Empty Then Return "''"
            ' Cas général
            Return TextSQL(p_s)
        End Function

#End Region

#Region "Méthodes publiques"

        ''' <summary>
        ''' Permet de nettoyer tous les caches
        ''' </summary>
        ''' <param name="p_b_force">Indique si l'on force le vidage ou non</param>
        Public Shared Sub ClearAllCache(Optional p_b_force As Boolean = False)
            ' Clear cache pour les items de la classe AnimalDocs
            If AnimalDocs.HasCache Then AnimalDocs.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Adopter
            If Adopter.HasCache Then Adopter.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Animal
            If Animal.HasCache Then Animal.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Assurance
            If Assurance.HasCache Then Assurance.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Attachement
            If Attachement.HasCache Then Attachement.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Carte
            If Carte.HasCache Then Carte.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe ConseilDietetique
            If ConseilDietetique.HasCache Then ConseilDietetique.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Consultation
            If Consultation.HasCache Then Consultation.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Contrat
            If Contrat.HasCache Then Contrat.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Histo_Poids
            If Histo_Poids.HasCache Then Histo_Poids.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Histo_Taille
            If Histo_Taille.HasCache Then Histo_Taille.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Medicament
            If Medicament.HasCache Then Medicament.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Position
            If Position.HasCache Then Position.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe PropriEtaire
            If PropriEtaire.HasCache Then PropriEtaire.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Race
            If Race.HasCache Then Race.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Remboursement
            If Remboursement.HasCache Then Remboursement.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Traitement_medicament
            If Traitement_medicament.HasCache Then Traitement_medicament.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Traitrement
            If Traitrement.HasCache Then Traitrement.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Type
            If Type.HasCache Then Type.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe User
            If User.HasCache Then User.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Vaccin
            If Vaccin.HasCache Then Vaccin.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Vaccination
            If Vaccination.HasCache Then Vaccination.CacheClear(p_b_force)
            ' Clear cache pour les items de la classe Veterinaire
            If Veterinaire.HasCache Then Veterinaire.CacheClear(p_b_force)
        End Sub


#End Region

#Region "Initialisation"

        ''' <summary>
        ''' On conserve la référence vers la base de données.
        ''' </summary>
        ''' <param name="p_o_db">Base de données.</param>
        ''' <returns>Base de données source.</returns>
        Friend Shared Function SetDB(p_o_db As Corail.Core.DataBase) As Corail.Core.DataBase
            m_o_db = p_o_db
            'On surveille les annulations de transaction pour vider le cache
            AddHandler m_o_db.TransactionCancelled, AddressOf TransactionCancelled
            Return p_o_db
        End Function

        ''' <summary>
        ''' Une transaction a été annulée dans la base de données.
        ''' </summary>
        ''' <param name="p_o_db">Base de données.</param>
        Private Shared Sub TransactionCancelled(p_o_db As DataBase)
            'On vide le cache
            ClearAllCache()
        End Sub


#End Region

    End Class

#End Region

#Region "Classes métiers"

#Region "AnimalDocs - AnimalDocs"

    <Serializable()> 
    Partial Public Class AnimalDocs
        Inherits Auto.AnimalDocs

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="AnimalDocs" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="AnimalDocs" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="AnimalDocs" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Adopter - Adopter : Associations etre propriétaire et animal"

    <Serializable()> 
    Partial Public Class Adopter
        Inherits Auto.Adopter

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Adopter" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Adopter" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Adopter" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Animal - Animal"

    <Serializable()> 
    Partial Public Class Animal
        Inherits Auto.Animal

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Animal" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Animal" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Animal" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Assurance - Assurance"

    <Serializable()> 
    Partial Public Class Assurance
        Inherits Auto.Assurance

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Assurance" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Assurance" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Assurance" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Attachement - Attachement"

    <Serializable()> 
    Partial Public Class Attachement
        Inherits Auto.Attachement

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Attachement" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Attachement" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Attachement" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Carte - Carte vitale"

    <Serializable()> 
    Partial Public Class Carte
        Inherits Auto.Carte

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Carte" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Carte" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Carte" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "ConseilDietetique - ConseilDietetique"

    <Serializable()> 
    Partial Public Class ConseilDietetique
        Inherits Auto.ConseilDietetique

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="ConseilDietetique" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="ConseilDietetique" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="ConseilDietetique" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Consultation - Consultation vétérinaire d'un animal"

    <Serializable()> 
    Partial Public Class Consultation
        Inherits Auto.Consultation

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Consultation" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Consultation" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Consultation" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Contrat - Contrat d'assurance"

    <Serializable()> 
    Partial Public Class Contrat
        Inherits Auto.Contrat

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Contrat" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Contrat" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Contrat" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Histo_Poids - Historique du poids de l'animal"

    <Serializable()> 
    Partial Public Class Histo_Poids
        Inherits Auto.Histo_Poids

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Histo_Poids" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Histo_Poids" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Histo_Poids" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Histo_Taille - Historique de la taille de l'animal"

    <Serializable()> 
    Partial Public Class Histo_Taille
        Inherits Auto.Histo_Taille

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Histo_Taille" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Histo_Taille" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Histo_Taille" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Medicament - Medicament"

    <Serializable()> 
    Partial Public Class Medicament
        Inherits Auto.Medicament

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Medicament" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Medicament" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Medicament" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Position - Position de l'animal"

    <Serializable()> 
    Partial Public Class Position
        Inherits Auto.Position

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Position" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Position" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Position" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "PropriEtaire - Propriétaire"

    <Serializable()> 
    Partial Public Class PropriEtaire
        Inherits Auto.PropriEtaire

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="PropriEtaire" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="PropriEtaire" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="PropriEtaire" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Race - Race de l'animal"

    <Serializable()> 
    Partial Public Class Race
        Inherits Auto.Race

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Race" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Race" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Race" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Remboursement - Remboursement"

    <Serializable()> 
    Partial Public Class Remboursement
        Inherits Auto.Remboursement

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Remboursement" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Remboursement" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Remboursement" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Traitement_medicament - Liste des médicaments compris dans un traitement"

    <Serializable()> 
    Partial Public Class Traitement_medicament
        Inherits Auto.Traitement_medicament

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Traitement_medicament" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Traitement_medicament" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Traitement_medicament" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Traitrement - Traitrement"

    <Serializable()> 
    Partial Public Class Traitrement
        Inherits Auto.Traitrement

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Traitrement" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Traitrement" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Traitrement" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Type - Typede l'animal"

    <Serializable()> 
    Partial Public Class Type
        Inherits Auto.Type

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Type" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Type" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Type" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "User - User"

    <Serializable()> 
    Partial Public Class User
        Inherits Auto.User

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="User" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="User" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="User" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Vaccin - Vaccin"

    <Serializable()> 
    Partial Public Class Vaccin
        Inherits Auto.Vaccin

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Vaccin" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Vaccin" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Vaccin" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Vaccination - Vaccination d'un animal"

    <Serializable()> 
    Partial Public Class Vaccination
        Inherits Auto.Vaccination

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Vaccination" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Vaccination" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Vaccination" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#Region "Veterinaire - Veterinaire"

    <Serializable()> 
    Partial Public Class Veterinaire
        Inherits Auto.Veterinaire

#Region "Initialisation"

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Veterinaire" />.
        ''' </summary>
        ''' <param name="p_i_iD">ID.</param>
        ''' <param name="p_o_trans">Transaction à utiliser.</param>
        Public Sub New(p_i_iD As Integer, Optional p_o_trans As Transaction = Nothing)
            ' Chargement des informations
            Load(p_i_iD, p_o_trans)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Veterinaire" />.
        ''' </summary>
        Public Sub New()
            ' Initialisation des valeurs de propriétés 
            InitDefaultValues()
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de la classe <see cref="Veterinaire" />.
        ''' </summary>
        ''' <param name="p_o_row">Ligne d'une table de données.</param>
        Protected Sub New(p_o_row As DataRow)
            Load(p_o_row)
        End Sub

#End Region

    End Class

#End Region

#End Region

End Namespace
