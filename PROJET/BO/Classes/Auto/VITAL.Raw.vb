﻿Namespace VITAL.Raw

#Region "AnimalDocs - AnimalDocs"

    ''' <summary>
    ''' AnimalDocs.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class AnimalDocs(Of T As {VITAL.AnimalDocs, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Nom.
        ''' </summary>
		Private m_s_nom As String

        ''' <summary>
        ''' Chemin.
        ''' </summary>
		Private m_s_chemin As String

        ''' <summary>
        ''' Id_Animal.
        ''' </summary>
		Private m_i_id_Animal As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VITAL_ANIMALDOCS.ANIMALDOCS_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Nom.
        ''' Champ associé : VITAL_ANIMALDOCS.ANIMALDOCS_NOM.
        ''' </summary>
        ''' <value>
        ''' Nom.
        ''' </value>
		Public Overridable Property Nom As String
            Get
				Return m_s_nom
            End Get
			Set(value As String)
                If m_s_nom <> value Then
                    m_s_nom = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Chemin.
        ''' Champ associé : VITAL_ANIMALDOCS.ANIMALDOCS_CHEMIN.
        ''' </summary>
        ''' <value>
        ''' Chemin.
        ''' </value>
		Public Overridable Property Chemin As String
            Get
				Return m_s_chemin
            End Get
			Set(value As String)
                If m_s_chemin <> value Then
                    m_s_chemin = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_Animal.
        ''' Champ associé : VITAL_ANIMALDOCS.ANIMALDOCS_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_Animal.
        ''' </value>
		Public Overridable Property Id_Animal As Integer
            Get
				Return m_i_id_Animal
            End Get
			Set(value As Integer)
                If m_i_id_Animal <> value Then
                    m_i_id_Animal = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VITAL_ANIMALDOCS

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_nom
            p_o_target.m_s_nom = m_s_nom
            ' Colonne : m_s_chemin
            p_o_target.m_s_chemin = m_s_chemin
            ' Colonne : m_i_id_Animal
            p_o_target.m_i_id_Animal = m_i_id_Animal

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!ANIMALDOCS_ID)
			m_s_nom = CStr(p_o_row!ANIMALDOCS_NOM)
			m_s_chemin = CStr(p_o_row!ANIMALDOCS_CHEMIN)
			m_i_id_Animal = CInt(p_o_row!ANIMALDOCS_ID_ANIMAL)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("ANIMALDOCS_ID") = ID
			p_o_row("ANIMALDOCS_NOM") = Nom
			p_o_row("ANIMALDOCS_CHEMIN") = Chemin
			p_o_row("ANIMALDOCS_ID_ANIMAL") = Id_Animal
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe AnimalDocs.</param>
        Public Function Diff(p_o_object As AnimalDocs(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VITAL_ANIMALDOCS.ANIMALDOCS_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Nom <> Nom Then
                l_o_dicDiff.Add(VITAL.VITAL_ANIMALDOCS.ANIMALDOCS_NOM, {p_o_object.Nom,Nom})
            End If
            If p_o_object.Chemin <> Chemin Then
                l_o_dicDiff.Add(VITAL.VITAL_ANIMALDOCS.ANIMALDOCS_CHEMIN, {p_o_object.Chemin,Chemin})
            End If
            If p_o_object.Id_Animal <> Id_Animal Then
                l_o_dicDiff.Add(VITAL.VITAL_ANIMALDOCS.ANIMALDOCS_ID_ANIMAL, {p_o_object.Id_Animal,Id_Animal})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Adopter - Adopter : Associations etre propriétaire et animal"

    ''' <summary>
    ''' Adopter : Associations etre propriétaire et animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Adopter(Of T As {VITAL.Adopter, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Dt_debut.
        ''' </summary>
		Private m_dt_dt_debut As DateTime

        ''' <summary>
        ''' Dt_fin.
        ''' </summary>
		Private m_dt_dt_fin As DateTime

        ''' <summary>
        ''' Id_proprietaire.
        ''' </summary>
		Private m_i_id_proprietaire As Integer

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_ADOPTER.VTL_ADOPTER_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Dt_debut.
        ''' Champ associé : VTL_ADOPTER.VTL_ADOPTER_DT_DEBUT.
        ''' </summary>
        ''' <value>
        ''' Dt_debut.
        ''' </value>
		Public Overridable Property Dt_debut As DateTime
            Get
				Return m_dt_dt_debut
            End Get
			Set(value As DateTime)
                If m_dt_dt_debut <> value Then
                    m_dt_dt_debut = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_fin.
        ''' Champ associé : VTL_ADOPTER.VTL_ADOPTER_DT_FIN.
        ''' </summary>
        ''' <value>
        ''' Dt_fin.
        ''' </value>
		Public Overridable Property Dt_fin As DateTime
            Get
				Return m_dt_dt_fin
            End Get
			Set(value As DateTime)
                If m_dt_dt_fin <> value Then
                    m_dt_dt_fin = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_proprietaire.
        ''' Champ associé : VTL_ADOPTER.VTL_ADOPTER_ID_PROPRIETAIRE.
        ''' </summary>
        ''' <value>
        ''' Id_proprietaire.
        ''' </value>
		Public Overridable Property Id_proprietaire As Integer
            Get
				Return m_i_id_proprietaire
            End Get
			Set(value As Integer)
                If m_i_id_proprietaire <> value Then
                    m_i_id_proprietaire = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_ADOPTER.VTL_ADOPTER_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_ADOPTER

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_dt_dt_debut
            p_o_target.m_dt_dt_debut = m_dt_dt_debut
            ' Colonne : m_dt_dt_fin
            p_o_target.m_dt_dt_fin = m_dt_dt_fin
            ' Colonne : m_i_id_proprietaire
            p_o_target.m_i_id_proprietaire = m_i_id_proprietaire
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_ADOPTER_ID)
			m_dt_dt_debut = CDate(p_o_row!VTL_ADOPTER_DT_DEBUT)
			m_dt_dt_fin = NzDate(p_o_row!VTL_ADOPTER_DT_FIN)
			m_i_id_proprietaire = NzInt(p_o_row!VTL_ADOPTER_ID_PROPRIETAIRE, 0)
			m_i_id_animal = NzInt(p_o_row!VTL_ADOPTER_ID_ANIMAL, 0)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_ADOPTER_ID") = ID
			p_o_row("VTL_ADOPTER_DT_DEBUT") = Dt_debut
			p_o_row("VTL_ADOPTER_DT_FIN") = Dt_fin
			p_o_row("VTL_ADOPTER_ID_PROPRIETAIRE") = Id_proprietaire
			p_o_row("VTL_ADOPTER_ID_ANIMAL") = Id_animal
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Adopter.</param>
        Public Function Diff(p_o_object As Adopter(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_ADOPTER.VTL_ADOPTER_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Dt_debut <> Dt_debut Then
                l_o_dicDiff.Add(VITAL.VTL_ADOPTER.VTL_ADOPTER_DT_DEBUT, {p_o_object.Dt_debut,Dt_debut})
            End If
            If p_o_object.Dt_fin <> Dt_fin Then
                l_o_dicDiff.Add(VITAL.VTL_ADOPTER.VTL_ADOPTER_DT_FIN, {p_o_object.Dt_fin,Dt_fin})
            End If
            If p_o_object.Id_proprietaire <> Id_proprietaire Then
                l_o_dicDiff.Add(VITAL.VTL_ADOPTER.VTL_ADOPTER_ID_PROPRIETAIRE, {p_o_object.Id_proprietaire,Id_proprietaire})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_ADOPTER.VTL_ADOPTER_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Animal - Animal"

    ''' <summary>
    ''' Animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Animal(Of T As {VITAL.Animal, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Nom.
        ''' </summary>
		Private m_s_nom As String

        ''' <summary>
        ''' Num_puce.
        ''' </summary>
		Private m_s_num_puce As String

        ''' <summary>
        ''' Dt_naissance.
        ''' </summary>
		Private m_dt_dt_naissance As DateTime

        ''' <summary>
        ''' Dt_deces.
        ''' </summary>
		Private m_dt_dt_deces As DateTime

        ''' <summary>
        ''' Id_race.
        ''' </summary>
		Private m_i_id_race As Integer

        ''' <summary>
        ''' Id_carte.
        ''' </summary>
		Private m_i_id_carte As Integer

        ''' <summary>
        ''' Id_type.
        ''' </summary>
		Private m_i_id_type As Integer

        ''' <summary>
        ''' Id_prop.
        ''' </summary>
		Private m_i_id_prop As Integer

        ''' <summary>
        ''' Image.
        ''' </summary>
		Private m_s_image As String

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Nom.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_NOM.
        ''' </summary>
        ''' <value>
        ''' Nom.
        ''' </value>
		Public Overridable Property Nom As String
            Get
				Return m_s_nom
            End Get
			Set(value As String)
                If m_s_nom <> value Then
                    m_s_nom = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Num_puce.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE.
        ''' </summary>
        ''' <value>
        ''' Num_puce.
        ''' </value>
		Public Overridable Property Num_puce As String
            Get
				Return m_s_num_puce
            End Get
			Set(value As String)
                If m_s_num_puce <> value Then
                    m_s_num_puce = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_naissance.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_DT_NAISSANCE.
        ''' </summary>
        ''' <value>
        ''' Dt_naissance.
        ''' </value>
		Public Overridable Property Dt_naissance As DateTime
            Get
				Return m_dt_dt_naissance
            End Get
			Set(value As DateTime)
                If m_dt_dt_naissance <> value Then
                    m_dt_dt_naissance = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_deces.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_DT_DECES.
        ''' </summary>
        ''' <value>
        ''' Dt_deces.
        ''' </value>
		Public Overridable Property Dt_deces As DateTime
            Get
				Return m_dt_dt_deces
            End Get
			Set(value As DateTime)
                If m_dt_dt_deces <> value Then
                    m_dt_dt_deces = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_race.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_ID_RACE.
        ''' </summary>
        ''' <value>
        ''' Id_race.
        ''' </value>
		Public Overridable Property Id_race As Integer
            Get
				Return m_i_id_race
            End Get
			Set(value As Integer)
                If m_i_id_race <> value Then
                    m_i_id_race = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_carte.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_ID_CARTE.
        ''' </summary>
        ''' <value>
        ''' Id_carte.
        ''' </value>
		Public Overridable Property Id_carte As Integer
            Get
				Return m_i_id_carte
            End Get
			Set(value As Integer)
                If m_i_id_carte <> value Then
                    m_i_id_carte = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_type.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_ID_TYPE.
        ''' </summary>
        ''' <value>
        ''' Id_type.
        ''' </value>
		Public Overridable Property Id_type As Integer
            Get
				Return m_i_id_type
            End Get
			Set(value As Integer)
                If m_i_id_type <> value Then
                    m_i_id_type = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_prop.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_ID_PROP.
        ''' </summary>
        ''' <value>
        ''' Id_prop.
        ''' </value>
		Public Overridable Property Id_prop As Integer
            Get
				Return m_i_id_prop
            End Get
			Set(value As Integer)
                If m_i_id_prop <> value Then
                    m_i_id_prop = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Image.
        ''' Champ associé : VTL_ANIMAL.VTL_ANIMAL_IMAGE.
        ''' </summary>
        ''' <value>
        ''' Image.
        ''' </value>
		Public Overridable Property Image As String
            Get
				Return m_s_image
            End Get
			Set(value As String)
                If m_s_image <> value Then
                    m_s_image = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_ANIMAL

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_nom
            p_o_target.m_s_nom = m_s_nom
            ' Colonne : m_s_num_puce
            p_o_target.m_s_num_puce = m_s_num_puce
            ' Colonne : m_dt_dt_naissance
            p_o_target.m_dt_dt_naissance = m_dt_dt_naissance
            ' Colonne : m_dt_dt_deces
            p_o_target.m_dt_dt_deces = m_dt_dt_deces
            ' Colonne : m_i_id_race
            p_o_target.m_i_id_race = m_i_id_race
            ' Colonne : m_i_id_carte
            p_o_target.m_i_id_carte = m_i_id_carte
            ' Colonne : m_i_id_type
            p_o_target.m_i_id_type = m_i_id_type
            ' Colonne : m_i_id_prop
            p_o_target.m_i_id_prop = m_i_id_prop
            ' Colonne : m_s_image
            p_o_target.m_s_image = m_s_image

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_ANIMAL_ID)
			m_s_nom = CStr(p_o_row!VTL_ANIMAL_NOM)
			m_s_num_puce = NzStr(p_o_row!VTL_ANIMAL_NUM_PUCE)
			m_dt_dt_naissance = NzDate(p_o_row!VTL_ANIMAL_DT_NAISSANCE)
			m_dt_dt_deces = NzDate(p_o_row!VTL_ANIMAL_DT_DECES)
			m_i_id_race = NzInt(p_o_row!VTL_ANIMAL_ID_RACE, 0)
			m_i_id_carte = NzInt(p_o_row!VTL_ANIMAL_ID_CARTE, 0)
			m_i_id_type = NzInt(p_o_row!VTL_ANIMAL_ID_TYPE, 0)
			m_i_id_prop = NzInt(p_o_row!VTL_ANIMAL_ID_PROP, 0)
			m_s_image = BlobToStr(p_o_row!VTL_ANIMAL_IMAGE)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_ANIMAL_ID") = ID
			p_o_row("VTL_ANIMAL_NOM") = Nom
			p_o_row("VTL_ANIMAL_NUM_PUCE") = Num_puce
			p_o_row("VTL_ANIMAL_DT_NAISSANCE") = Dt_naissance
			p_o_row("VTL_ANIMAL_DT_DECES") = Dt_deces
			p_o_row("VTL_ANIMAL_ID_RACE") = Id_race
			p_o_row("VTL_ANIMAL_ID_CARTE") = Id_carte
			p_o_row("VTL_ANIMAL_ID_TYPE") = Id_type
			p_o_row("VTL_ANIMAL_ID_PROP") = Id_prop
			p_o_row("VTL_ANIMAL_IMAGE") = StrToBlob(Image).Value
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Animal.</param>
        Public Function Diff(p_o_object As Animal(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Nom <> Nom Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_NOM, {p_o_object.Nom,Nom})
            End If
            If p_o_object.Num_puce <> Num_puce Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE, {p_o_object.Num_puce,Num_puce})
            End If
            If p_o_object.Dt_naissance <> Dt_naissance Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_DT_NAISSANCE, {p_o_object.Dt_naissance,Dt_naissance})
            End If
            If p_o_object.Dt_deces <> Dt_deces Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_DT_DECES, {p_o_object.Dt_deces,Dt_deces})
            End If
            If p_o_object.Id_race <> Id_race Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_ID_RACE, {p_o_object.Id_race,Id_race})
            End If
            If p_o_object.Id_carte <> Id_carte Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_ID_CARTE, {p_o_object.Id_carte,Id_carte})
            End If
            If p_o_object.Id_type <> Id_type Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_ID_TYPE, {p_o_object.Id_type,Id_type})
            End If
            If p_o_object.Id_prop <> Id_prop Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_ID_PROP, {p_o_object.Id_prop,Id_prop})
            End If
            If p_o_object.Image <> Image Then
                l_o_dicDiff.Add(VITAL.VTL_ANIMAL.VTL_ANIMAL_IMAGE, {p_o_object.Image,Image})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Assurance - Assurance"

    ''' <summary>
    ''' Assurance.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Assurance(Of T As {VITAL.Assurance, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Siret.
        ''' </summary>
		Private m_s_siret As String

        ''' <summary>
        ''' Nom.
        ''' </summary>
		Private m_s_nom As String

        ''' <summary>
        ''' Tel.
        ''' </summary>
		Private m_s_tel As String

        ''' <summary>
        ''' Mail.
        ''' </summary>
		Private m_s_mail As String

        ''' <summary>
        ''' Adr.
        ''' </summary>
		Private m_s_adr As String

        ''' <summary>
        ''' Cp.
        ''' </summary>
		Private m_s_cp As String

        ''' <summary>
        ''' Ville.
        ''' </summary>
		Private m_s_ville As String

        ''' <summary>
        ''' id_user.
        ''' </summary>
		Private m_i_id_user As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Siret.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_SIRET.
        ''' </summary>
        ''' <value>
        ''' Siret.
        ''' </value>
		Public Overridable Property Siret As String
            Get
				Return m_s_siret
            End Get
			Set(value As String)
                If m_s_siret <> value Then
                    m_s_siret = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Nom.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_NOM.
        ''' </summary>
        ''' <value>
        ''' Nom.
        ''' </value>
		Public Overridable Property Nom As String
            Get
				Return m_s_nom
            End Get
			Set(value As String)
                If m_s_nom <> value Then
                    m_s_nom = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Tel.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_TEL.
        ''' </summary>
        ''' <value>
        ''' Tel.
        ''' </value>
		Public Overridable Property Tel As String
            Get
				Return m_s_tel
            End Get
			Set(value As String)
                If m_s_tel <> value Then
                    m_s_tel = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Mail.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_MAIL.
        ''' </summary>
        ''' <value>
        ''' Mail.
        ''' </value>
		Public Overridable Property Mail As String
            Get
				Return m_s_mail
            End Get
			Set(value As String)
                If m_s_mail <> value Then
                    m_s_mail = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Adr.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_ADR.
        ''' </summary>
        ''' <value>
        ''' Adr.
        ''' </value>
		Public Overridable Property Adr As String
            Get
				Return m_s_adr
            End Get
			Set(value As String)
                If m_s_adr <> value Then
                    m_s_adr = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Cp.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_CP.
        ''' </summary>
        ''' <value>
        ''' Cp.
        ''' </value>
		Public Overridable Property Cp As String
            Get
				Return m_s_cp
            End Get
			Set(value As String)
                If m_s_cp <> value Then
                    m_s_cp = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Ville.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_VILLE.
        ''' </summary>
        ''' <value>
        ''' Ville.
        ''' </value>
		Public Overridable Property Ville As String
            Get
				Return m_s_ville
            End Get
			Set(value As String)
                If m_s_ville <> value Then
                    m_s_ville = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' id_user.
        ''' Champ associé : VTL_ASSURANCE.VTL_ASSURANCE_ID_USER.
        ''' </summary>
        ''' <value>
        ''' id_user.
        ''' </value>
		Public Overridable Property id_user As Integer
            Get
				Return m_i_id_user
            End Get
			Set(value As Integer)
                If m_i_id_user <> value Then
                    m_i_id_user = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_ASSURANCE

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_siret
            p_o_target.m_s_siret = m_s_siret
            ' Colonne : m_s_nom
            p_o_target.m_s_nom = m_s_nom
            ' Colonne : m_s_tel
            p_o_target.m_s_tel = m_s_tel
            ' Colonne : m_s_mail
            p_o_target.m_s_mail = m_s_mail
            ' Colonne : m_s_adr
            p_o_target.m_s_adr = m_s_adr
            ' Colonne : m_s_cp
            p_o_target.m_s_cp = m_s_cp
            ' Colonne : m_s_ville
            p_o_target.m_s_ville = m_s_ville
            ' Colonne : m_i_id_user
            p_o_target.m_i_id_user = m_i_id_user

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_ASSURANCE_ID)
			m_s_siret = CStr(p_o_row!VTL_ASSURANCE_SIRET)
			m_s_nom = NzStr(p_o_row!VTL_ASSURANCE_NOM)
			m_s_tel = NzStr(p_o_row!VTL_ASSURANCE_TEL)
			m_s_mail = NzStr(p_o_row!VTL_ASSURANCE_MAIL)
			m_s_adr = NzStr(p_o_row!VTL_ASSURANCE_ADR)
			m_s_cp = NzStr(p_o_row!VTL_ASSURANCE_CP)
			m_s_ville = NzStr(p_o_row!VTL_ASSURANCE_VILLE)
			m_i_id_user = NzInt(p_o_row!VTL_ASSURANCE_ID_USER, 0)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_ASSURANCE_ID") = ID
			p_o_row("VTL_ASSURANCE_SIRET") = Siret
			p_o_row("VTL_ASSURANCE_NOM") = Nom
			p_o_row("VTL_ASSURANCE_TEL") = Tel
			p_o_row("VTL_ASSURANCE_MAIL") = Mail
			p_o_row("VTL_ASSURANCE_ADR") = Adr
			p_o_row("VTL_ASSURANCE_CP") = Cp
			p_o_row("VTL_ASSURANCE_VILLE") = Ville
			p_o_row("VTL_ASSURANCE_ID_USER") = id_user
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Assurance.</param>
        Public Function Diff(p_o_object As Assurance(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Siret <> Siret Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_SIRET, {p_o_object.Siret,Siret})
            End If
            If p_o_object.Nom <> Nom Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_NOM, {p_o_object.Nom,Nom})
            End If
            If p_o_object.Tel <> Tel Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_TEL, {p_o_object.Tel,Tel})
            End If
            If p_o_object.Mail <> Mail Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_MAIL, {p_o_object.Mail,Mail})
            End If
            If p_o_object.Adr <> Adr Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_ADR, {p_o_object.Adr,Adr})
            End If
            If p_o_object.Cp <> Cp Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_CP, {p_o_object.Cp,Cp})
            End If
            If p_o_object.Ville <> Ville Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_VILLE, {p_o_object.Ville,Ville})
            End If
            If p_o_object.id_user <> id_user Then
                l_o_dicDiff.Add(VITAL.VTL_ASSURANCE.VTL_ASSURANCE_ID_USER, {p_o_object.id_user,id_user})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Attachement - Attachement"

    ''' <summary>
    ''' Attachement.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Attachement(Of T As {VITAL.Attachement, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Name.
        ''' </summary>
		Private m_s_name As String

        ''' <summary>
        ''' Chemin.
        ''' </summary>
		Private m_s_chemin As String

        ''' <summary>
        ''' Consult.
        ''' </summary>
		Private m_i_consult As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_ATTACHEMT.VTL_ATTACHEMT_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Name.
        ''' Champ associé : VTL_ATTACHEMT.VTL_ATTACHEMT_NAME.
        ''' </summary>
        ''' <value>
        ''' Name.
        ''' </value>
		Public Overridable Property Name As String
            Get
				Return m_s_name
            End Get
			Set(value As String)
                If m_s_name <> value Then
                    m_s_name = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Chemin.
        ''' Champ associé : VTL_ATTACHEMT.VTL_ATTACHEMT_CHEMIN.
        ''' </summary>
        ''' <value>
        ''' Chemin.
        ''' </value>
		Public Overridable Property Chemin As String
            Get
				Return m_s_chemin
            End Get
			Set(value As String)
                If m_s_chemin <> value Then
                    m_s_chemin = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Consult.
        ''' Champ associé : VTL_ATTACHEMT.VTL_ATTACHEMT_CONSULT.
        ''' </summary>
        ''' <value>
        ''' Consult.
        ''' </value>
		Public Overridable Property Consult As Integer
            Get
				Return m_i_consult
            End Get
			Set(value As Integer)
                If m_i_consult <> value Then
                    m_i_consult = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_ATTACHEMT

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_name
            p_o_target.m_s_name = m_s_name
            ' Colonne : m_s_chemin
            p_o_target.m_s_chemin = m_s_chemin
            ' Colonne : m_i_consult
            p_o_target.m_i_consult = m_i_consult

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_ATTACHEMT_ID)
			m_s_name = CStr(p_o_row!VTL_ATTACHEMT_NAME)
			m_s_chemin = CStr(p_o_row!VTL_ATTACHEMT_CHEMIN)
			m_i_consult = CInt(p_o_row!VTL_ATTACHEMT_CONSULT)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_ATTACHEMT_ID") = ID
			p_o_row("VTL_ATTACHEMT_NAME") = Name
			p_o_row("VTL_ATTACHEMT_CHEMIN") = Chemin
			p_o_row("VTL_ATTACHEMT_CONSULT") = Consult
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Attachement.</param>
        Public Function Diff(p_o_object As Attachement(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_ATTACHEMT.VTL_ATTACHEMT_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Name <> Name Then
                l_o_dicDiff.Add(VITAL.VTL_ATTACHEMT.VTL_ATTACHEMT_NAME, {p_o_object.Name,Name})
            End If
            If p_o_object.Chemin <> Chemin Then
                l_o_dicDiff.Add(VITAL.VTL_ATTACHEMT.VTL_ATTACHEMT_CHEMIN, {p_o_object.Chemin,Chemin})
            End If
            If p_o_object.Consult <> Consult Then
                l_o_dicDiff.Add(VITAL.VTL_ATTACHEMT.VTL_ATTACHEMT_CONSULT, {p_o_object.Consult,Consult})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Carte - Carte vitale"

    ''' <summary>
    ''' Carte vitale.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Carte(Of T As {VITAL.Carte, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Numero.
        ''' </summary>
		Private m_s_numero As String

        ''' <summary>
        ''' Nfc.
        ''' </summary>
		Private m_s_nfc As String

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_CARTE.VTL_CARTE_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Numero.
        ''' Champ associé : VTL_CARTE.VTL_CARTE_NUMERO.
        ''' </summary>
        ''' <value>
        ''' Numero.
        ''' </value>
		Public Overridable Property Numero As String
            Get
				Return m_s_numero
            End Get
			Set(value As String)
                If m_s_numero <> value Then
                    m_s_numero = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Nfc.
        ''' Champ associé : VTL_CARTE.VTL_CARTE_NFC.
        ''' </summary>
        ''' <value>
        ''' Nfc.
        ''' </value>
		Public Overridable Property Nfc As String
            Get
				Return m_s_nfc
            End Get
			Set(value As String)
                If m_s_nfc <> value Then
                    m_s_nfc = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_CARTE

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_numero
            p_o_target.m_s_numero = m_s_numero
            ' Colonne : m_s_nfc
            p_o_target.m_s_nfc = m_s_nfc

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_CARTE_ID)
			m_s_numero = CStr(p_o_row!VTL_CARTE_NUMERO)
			m_s_nfc = NzStr(p_o_row!VTL_CARTE_NFC)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_CARTE_ID") = ID
			p_o_row("VTL_CARTE_NUMERO") = Numero
			p_o_row("VTL_CARTE_NFC") = Nfc
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Carte.</param>
        Public Function Diff(p_o_object As Carte(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_CARTE.VTL_CARTE_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Numero <> Numero Then
                l_o_dicDiff.Add(VITAL.VTL_CARTE.VTL_CARTE_NUMERO, {p_o_object.Numero,Numero})
            End If
            If p_o_object.Nfc <> Nfc Then
                l_o_dicDiff.Add(VITAL.VTL_CARTE.VTL_CARTE_NFC, {p_o_object.Nfc,Nfc})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "ConseilDietetique - ConseilDietetique"

    ''' <summary>
    ''' ConseilDietetique.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class ConseilDietetique(Of T As {VITAL.ConseilDietetique, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Contenu.
        ''' </summary>
		Private m_s_contenu As String

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

        ''' <summary>
        ''' Date.
        ''' </summary>
		Private m_dt_date As DateTime

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_CNSLDIET.CNSLDIET_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Contenu.
        ''' Champ associé : VTL_CNSLDIET.CNSLDIET_CONTENU.
        ''' </summary>
        ''' <value>
        ''' Contenu.
        ''' </value>
		Public Overridable Property Contenu As String
            Get
				Return m_s_contenu
            End Get
			Set(value As String)
                If m_s_contenu <> value Then
                    m_s_contenu = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_CNSLDIET.CNSLDIET_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Date.
        ''' Champ associé : VTL_CNSLDIET.CNSLDIET_DATE.
        ''' </summary>
        ''' <value>
        ''' Date.
        ''' </value>
		Public Overridable Property [Date] As DateTime
            Get
				Return m_dt_date
            End Get
			Set(value As DateTime)
                If m_dt_date <> value Then
                    m_dt_date = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_CNSLDIET

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_contenu
            p_o_target.m_s_contenu = m_s_contenu
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal
            ' Colonne : m_dt_date
            p_o_target.m_dt_date = m_dt_date

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!CNSLDIET_ID)
			m_s_contenu = CStr(p_o_row!CNSLDIET_CONTENU)
			m_i_id_animal = CInt(p_o_row!CNSLDIET_ID_ANIMAL)
			m_dt_date = CDate(p_o_row!CNSLDIET_DATE)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("CNSLDIET_ID") = ID
			p_o_row("CNSLDIET_CONTENU") = Contenu
			p_o_row("CNSLDIET_ID_ANIMAL") = Id_animal
			p_o_row("CNSLDIET_DATE") = [Date]
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe ConseilDietetique.</param>
        Public Function Diff(p_o_object As ConseilDietetique(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_CNSLDIET.CNSLDIET_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Contenu <> Contenu Then
                l_o_dicDiff.Add(VITAL.VTL_CNSLDIET.CNSLDIET_CONTENU, {p_o_object.Contenu,Contenu})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_CNSLDIET.CNSLDIET_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            If p_o_object.[Date] <> [Date] Then
                l_o_dicDiff.Add(VITAL.VTL_CNSLDIET.CNSLDIET_DATE, {p_o_object.[Date],[Date]})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Consultation - Consultation vétérinaire d'un animal"

    ''' <summary>
    ''' Consultation vétérinaire d'un animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Consultation(Of T As {VITAL.Consultation, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Montant.
        ''' </summary>
		Private m_d_montant As Double?

        ''' <summary>
        ''' Commentaire.
        ''' </summary>
		Private m_s_commentaire As String

        ''' <summary>
        ''' Id_veterinaire.
        ''' </summary>
		Private m_i_id_veterinaire As Integer

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

        ''' <summary>
        ''' Dt_Consultation.
        ''' </summary>
		Private m_dt_dt_Consultation As DateTime

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_CONSULTATION.VTL_CONSULTATION_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Montant.
        ''' Champ associé : VTL_CONSULTATION.VTL_CONSULTATION_MONTANT.
        ''' </summary>
        ''' <value>
        ''' Montant.
        ''' </value>
		Public Overridable Property Montant As Double?
            Get
				Return m_d_montant
            End Get
			Set(value As Double?)
                If Not Object.Equals(m_d_montant, value) Then
                    m_d_montant = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Commentaire.
        ''' Champ associé : VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE.
        ''' </summary>
        ''' <value>
        ''' Commentaire.
        ''' </value>
		Public Overridable Property Commentaire As String
            Get
				Return m_s_commentaire
            End Get
			Set(value As String)
                If m_s_commentaire <> value Then
                    m_s_commentaire = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_veterinaire.
        ''' Champ associé : VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE.
        ''' </summary>
        ''' <value>
        ''' Id_veterinaire.
        ''' </value>
		Public Overridable Property Id_veterinaire As Integer
            Get
				Return m_i_id_veterinaire
            End Get
			Set(value As Integer)
                If m_i_id_veterinaire <> value Then
                    m_i_id_veterinaire = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_CONSULTATION.VTL_CONSULTATION_L.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_Consultation.
        ''' Champ associé : VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION.
        ''' </summary>
        ''' <value>
        ''' Dt_Consultation.
        ''' </value>
		Public Overridable Property Dt_Consultation As DateTime
            Get
				Return m_dt_dt_Consultation
            End Get
			Set(value As DateTime)
                If m_dt_dt_Consultation <> value Then
                    m_dt_dt_Consultation = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_CONSULTATION

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_d_montant
            p_o_target.m_d_montant = m_d_montant
            ' Colonne : m_s_commentaire
            p_o_target.m_s_commentaire = m_s_commentaire
            ' Colonne : m_i_id_veterinaire
            p_o_target.m_i_id_veterinaire = m_i_id_veterinaire
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal
            ' Colonne : m_dt_dt_Consultation
            p_o_target.m_dt_dt_Consultation = m_dt_dt_Consultation

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_CONSULTATION_ID)
			m_d_montant = NzDblNullable(p_o_row!VTL_CONSULTATION_MONTANT)
			m_s_commentaire = NzStr(p_o_row!VTL_CONSULTATION_COMMENTAIRE)
			m_i_id_veterinaire = NzInt(p_o_row!VTL_CONSULTATION_ID_VETERINAIRE, 0)
			m_i_id_animal = NzInt(p_o_row!VTL_CONSULTATION_L, 0)
			m_dt_dt_Consultation = CDate(p_o_row!VTL_CONSULTATION_DT_CONSULTATION)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_CONSULTATION_ID") = ID
			p_o_row("VTL_CONSULTATION_MONTANT") = If(Montant Is Nothing, DBNull.Value, CType(Montant, Object))
			p_o_row("VTL_CONSULTATION_COMMENTAIRE") = Commentaire
			p_o_row("VTL_CONSULTATION_ID_VETERINAIRE") = Id_veterinaire
			p_o_row("VTL_CONSULTATION_L") = Id_animal
			p_o_row("VTL_CONSULTATION_DT_CONSULTATION") = Dt_Consultation
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Consultation.</param>
        Public Function Diff(p_o_object As Consultation(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_CONSULTATION.VTL_CONSULTATION_ID, {p_o_object.ID,ID})
            End If
            If Not Object.Equals(p_o_object.Montant, Montant) Then
                l_o_dicDiff.Add(VITAL.VTL_CONSULTATION.VTL_CONSULTATION_MONTANT, {p_o_object.Montant,Montant})
            End If
            If p_o_object.Commentaire <> Commentaire Then
                l_o_dicDiff.Add(VITAL.VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE, {p_o_object.Commentaire,Commentaire})
            End If
            If p_o_object.Id_veterinaire <> Id_veterinaire Then
                l_o_dicDiff.Add(VITAL.VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE, {p_o_object.Id_veterinaire,Id_veterinaire})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_CONSULTATION.VTL_CONSULTATION_L, {p_o_object.Id_animal,Id_animal})
            End If
            If p_o_object.Dt_Consultation <> Dt_Consultation Then
                l_o_dicDiff.Add(VITAL.VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION, {p_o_object.Dt_Consultation,Dt_Consultation})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Contrat - Contrat d'assurance"

    ''' <summary>
    ''' Contrat d'assurance.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Contrat(Of T As {VITAL.Contrat, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Num_contrat.
        ''' </summary>
		Private m_s_num_contrat As String

        ''' <summary>
        ''' Dt_debut.
        ''' </summary>
		Private m_dt_dt_debut As DateTime

        ''' <summary>
        ''' Dt_fin.
        ''' </summary>
		Private m_dt_dt_fin As DateTime

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

        ''' <summary>
        ''' Id_proprietaire.
        ''' </summary>
		Private m_i_id_proprietaire As Integer

        ''' <summary>
        ''' Id_assurance.
        ''' </summary>
		Private m_i_id_assurance As Integer

        ''' <summary>
        ''' TxRemb.
        ''' </summary>
		Private m_d_txRemb As Double

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Num_contrat.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_NUM_CONTRAT.
        ''' </summary>
        ''' <value>
        ''' Num_contrat.
        ''' </value>
		Public Overridable Property Num_contrat As String
            Get
				Return m_s_num_contrat
            End Get
			Set(value As String)
                If m_s_num_contrat <> value Then
                    m_s_num_contrat = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_debut.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT.
        ''' </summary>
        ''' <value>
        ''' Dt_debut.
        ''' </value>
		Public Overridable Property Dt_debut As DateTime
            Get
				Return m_dt_dt_debut
            End Get
			Set(value As DateTime)
                If m_dt_dt_debut <> value Then
                    m_dt_dt_debut = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_fin.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_DT_FIN.
        ''' </summary>
        ''' <value>
        ''' Dt_fin.
        ''' </value>
		Public Overridable Property Dt_fin As DateTime
            Get
				Return m_dt_dt_fin
            End Get
			Set(value As DateTime)
                If m_dt_dt_fin <> value Then
                    m_dt_dt_fin = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_proprietaire.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE.
        ''' </summary>
        ''' <value>
        ''' Id_proprietaire.
        ''' </value>
		Public Overridable Property Id_proprietaire As Integer
            Get
				Return m_i_id_proprietaire
            End Get
			Set(value As Integer)
                If m_i_id_proprietaire <> value Then
                    m_i_id_proprietaire = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_assurance.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_ID_ASSURANCE.
        ''' </summary>
        ''' <value>
        ''' Id_assurance.
        ''' </value>
		Public Overridable Property Id_assurance As Integer
            Get
				Return m_i_id_assurance
            End Get
			Set(value As Integer)
                If m_i_id_assurance <> value Then
                    m_i_id_assurance = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' TxRemb.
        ''' Champ associé : VTL_CONTRAT.VTL_CONTRAT_TXREMB.
        ''' </summary>
        ''' <value>
        ''' TxRemb.
        ''' </value>
		Public Overridable Property TxRemb As Double
            Get
				Return m_d_txRemb
            End Get
			Set(value As Double)
                If m_d_txRemb <> value Then
                    m_d_txRemb = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_CONTRAT

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_num_contrat
            p_o_target.m_s_num_contrat = m_s_num_contrat
            ' Colonne : m_dt_dt_debut
            p_o_target.m_dt_dt_debut = m_dt_dt_debut
            ' Colonne : m_dt_dt_fin
            p_o_target.m_dt_dt_fin = m_dt_dt_fin
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal
            ' Colonne : m_i_id_proprietaire
            p_o_target.m_i_id_proprietaire = m_i_id_proprietaire
            ' Colonne : m_i_id_assurance
            p_o_target.m_i_id_assurance = m_i_id_assurance
            ' Colonne : m_d_txRemb
            p_o_target.m_d_txRemb = m_d_txRemb

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_CONTRAT_ID)
			m_s_num_contrat = CStr(p_o_row!VTL_CONTRAT_NUM_CONTRAT)
			m_dt_dt_debut = NzDate(p_o_row!VTL_CONTRAT_DT_DEBUT)
			m_dt_dt_fin = NzDate(p_o_row!VTL_CONTRAT_DT_FIN)
			m_i_id_animal = NzInt(p_o_row!VTL_CONTRAT_ID_ANIMAL, 0)
			m_i_id_proprietaire = NzInt(p_o_row!VTL_CONTRAT_ID_PROPRIETAIRE, 0)
			m_i_id_assurance = NzInt(p_o_row!VTL_CONTRAT_ID_ASSURANCE, 0)
			m_d_txRemb = CDbl(p_o_row!VTL_CONTRAT_TXREMB)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_CONTRAT_ID") = ID
			p_o_row("VTL_CONTRAT_NUM_CONTRAT") = Num_contrat
			p_o_row("VTL_CONTRAT_DT_DEBUT") = Dt_debut
			p_o_row("VTL_CONTRAT_DT_FIN") = Dt_fin
			p_o_row("VTL_CONTRAT_ID_ANIMAL") = Id_animal
			p_o_row("VTL_CONTRAT_ID_PROPRIETAIRE") = Id_proprietaire
			p_o_row("VTL_CONTRAT_ID_ASSURANCE") = Id_assurance
			p_o_row("VTL_CONTRAT_TXREMB") = TxRemb
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Contrat.</param>
        Public Function Diff(p_o_object As Contrat(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Num_contrat <> Num_contrat Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_NUM_CONTRAT, {p_o_object.Num_contrat,Num_contrat})
            End If
            If p_o_object.Dt_debut <> Dt_debut Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT, {p_o_object.Dt_debut,Dt_debut})
            End If
            If p_o_object.Dt_fin <> Dt_fin Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_DT_FIN, {p_o_object.Dt_fin,Dt_fin})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            If p_o_object.Id_proprietaire <> Id_proprietaire Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE, {p_o_object.Id_proprietaire,Id_proprietaire})
            End If
            If p_o_object.Id_assurance <> Id_assurance Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_ID_ASSURANCE, {p_o_object.Id_assurance,Id_assurance})
            End If
            If p_o_object.TxRemb <> TxRemb Then
                l_o_dicDiff.Add(VITAL.VTL_CONTRAT.VTL_CONTRAT_TXREMB, {p_o_object.TxRemb,TxRemb})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Histo_Poids - Historique du poids de l'animal"

    ''' <summary>
    ''' Historique du poids de l'animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Histo_Poids(Of T As {VITAL.Histo_Poids, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Dt_histo.
        ''' </summary>
		Private m_dt_dt_histo As DateTime

        ''' <summary>
        ''' Poids.
        ''' </summary>
		Private m_d_poids As Double

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Dt_histo.
        ''' Champ associé : VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO.
        ''' </summary>
        ''' <value>
        ''' Dt_histo.
        ''' </value>
		Public Overridable Property Dt_histo As DateTime
            Get
				Return m_dt_dt_histo
            End Get
			Set(value As DateTime)
                If m_dt_dt_histo <> value Then
                    m_dt_dt_histo = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Poids.
        ''' Champ associé : VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS.
        ''' </summary>
        ''' <value>
        ''' Poids.
        ''' </value>
		Public Overridable Property Poids As Double
            Get
				Return m_d_poids
            End Get
			Set(value As Double)
                If m_d_poids <> value Then
                    m_d_poids = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_HISTO_POIDS

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_dt_dt_histo
            p_o_target.m_dt_dt_histo = m_dt_dt_histo
            ' Colonne : m_d_poids
            p_o_target.m_d_poids = m_d_poids
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_HISTO_POIDS_ID)
			m_dt_dt_histo = CDate(p_o_row!VTL_HISTO_POIDS_DT_HISTO)
			m_d_poids = CDbl(p_o_row!VTL_HISTO_POIDS_POIDS)
			m_i_id_animal = CInt(p_o_row!VTL_HISTO_POIDS_ID_ANIMAL)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_HISTO_POIDS_ID") = ID
			p_o_row("VTL_HISTO_POIDS_DT_HISTO") = Dt_histo
			p_o_row("VTL_HISTO_POIDS_POIDS") = Poids
			p_o_row("VTL_HISTO_POIDS_ID_ANIMAL") = Id_animal
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Histo_Poids.</param>
        Public Function Diff(p_o_object As Histo_Poids(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Dt_histo <> Dt_histo Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO, {p_o_object.Dt_histo,Dt_histo})
            End If
            If p_o_object.Poids <> Poids Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS, {p_o_object.Poids,Poids})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Histo_Taille - Historique de la taille de l'animal"

    ''' <summary>
    ''' Historique de la taille de l'animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Histo_Taille(Of T As {VITAL.Histo_Taille, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Dt_histo.
        ''' </summary>
		Private m_dt_dt_histo As DateTime

        ''' <summary>
        ''' Taille.
        ''' </summary>
		Private m_d_taille As Double

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Dt_histo.
        ''' Champ associé : VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO.
        ''' </summary>
        ''' <value>
        ''' Dt_histo.
        ''' </value>
		Public Overridable Property Dt_histo As DateTime
            Get
				Return m_dt_dt_histo
            End Get
			Set(value As DateTime)
                If m_dt_dt_histo <> value Then
                    m_dt_dt_histo = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Taille.
        ''' Champ associé : VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_TAILLE.
        ''' </summary>
        ''' <value>
        ''' Taille.
        ''' </value>
		Public Overridable Property Taille As Double
            Get
				Return m_d_taille
            End Get
			Set(value As Double)
                If m_d_taille <> value Then
                    m_d_taille = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_HISTO_TAILLE

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_dt_dt_histo
            p_o_target.m_dt_dt_histo = m_dt_dt_histo
            ' Colonne : m_d_taille
            p_o_target.m_d_taille = m_d_taille
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_HISTO_TAILLE_ID)
			m_dt_dt_histo = CDate(p_o_row!VTL_HISTO_TAILLE_DT_HISTO)
			m_d_taille = CDbl(p_o_row!VTL_HISTO_TAILLE_TAILLE)
			m_i_id_animal = CInt(p_o_row!VTL_HISTO_TAILLE_ID_ANIMAL)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_HISTO_TAILLE_ID") = ID
			p_o_row("VTL_HISTO_TAILLE_DT_HISTO") = Dt_histo
			p_o_row("VTL_HISTO_TAILLE_TAILLE") = Taille
			p_o_row("VTL_HISTO_TAILLE_ID_ANIMAL") = Id_animal
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Histo_Taille.</param>
        Public Function Diff(p_o_object As Histo_Taille(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Dt_histo <> Dt_histo Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO, {p_o_object.Dt_histo,Dt_histo})
            End If
            If p_o_object.Taille <> Taille Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_TAILLE, {p_o_object.Taille,Taille})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Medicament - Medicament"

    ''' <summary>
    ''' Medicament.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Medicament(Of T As {VITAL.Medicament, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Libelle.
        ''' </summary>
		Private m_s_libelle As String

        ''' <summary>
        ''' Dosage.
        ''' </summary>
		Private m_s_dosage As String

        ''' <summary>
        ''' DureeMoyenneDuTraitement.
        ''' </summary>
		Private m_i_dureeMoyenneDuTraitement As Integer?

        ''' <summary>
        ''' AdministrableParProprietaires.
        ''' </summary>
		Private m_b_administrableParProprietaires As Boolean? = False

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_MEDICAMENT.VTL_MEDICAMENT_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Libelle.
        ''' Champ associé : VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE.
        ''' </summary>
        ''' <value>
        ''' Libelle.
        ''' </value>
		Public Overridable Property Libelle As String
            Get
				Return m_s_libelle
            End Get
			Set(value As String)
                If m_s_libelle <> value Then
                    m_s_libelle = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dosage.
        ''' Champ associé : VTL_MEDICAMENT.VTL_MEDICAMENT_DOSAGE.
        ''' </summary>
        ''' <value>
        ''' Dosage.
        ''' </value>
		Public Overridable Property Dosage As String
            Get
				Return m_s_dosage
            End Get
			Set(value As String)
                If m_s_dosage <> value Then
                    m_s_dosage = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' DureeMoyenneDuTraitement.
        ''' Champ associé : VTL_MEDICAMENT.VTL_MEDICAMENT_DUREE_MOYENNE_JOUR.
        ''' </summary>
        ''' <value>
        ''' DureeMoyenneDuTraitement.
        ''' </value>
		Public Overridable Property DureeMoyenneDuTraitement As Integer?
            Get
				Return m_i_dureeMoyenneDuTraitement
            End Get
			Set(value As Integer?)
                If Not Object.Equals(m_i_dureeMoyenneDuTraitement, value) Then
                    m_i_dureeMoyenneDuTraitement = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' AdministrableParProprietaires.
        ''' Champ associé : VTL_MEDICAMENT.VTL_MEDICAMENT_PROPRIOCANDO.
        ''' </summary>
        ''' <value>
        ''' AdministrableParProprietaires.
        ''' </value>
		Public Overridable Property AdministrableParProprietaires As Boolean?
            Get
				Return m_b_administrableParProprietaires
            End Get
			Set(value As Boolean?)
                If Not Object.Equals(m_b_administrableParProprietaires, value) Then
                    m_b_administrableParProprietaires = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_MEDICAMENT

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_libelle
            p_o_target.m_s_libelle = m_s_libelle
            ' Colonne : m_s_dosage
            p_o_target.m_s_dosage = m_s_dosage
            ' Colonne : m_i_dureeMoyenneDuTraitement
            p_o_target.m_i_dureeMoyenneDuTraitement = m_i_dureeMoyenneDuTraitement
            ' Colonne : m_b_administrableParProprietaires
            p_o_target.m_b_administrableParProprietaires = m_b_administrableParProprietaires

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_MEDICAMENT_ID)
			m_s_libelle = CStr(p_o_row!VTL_MEDICAMENT_LIBELLE)
			m_s_dosage = NzStr(p_o_row!VTL_MEDICAMENT_DOSAGE)
			m_i_dureeMoyenneDuTraitement = NzIntNullable(p_o_row!VTL_MEDICAMENT_DUREE_MOYENNE_JOUR)
			m_b_administrableParProprietaires = NzBoolNullable(p_o_row!VTL_MEDICAMENT_PROPRIOCANDO)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_MEDICAMENT_ID") = ID
			p_o_row("VTL_MEDICAMENT_LIBELLE") = Libelle
			p_o_row("VTL_MEDICAMENT_DOSAGE") = Dosage
			p_o_row("VTL_MEDICAMENT_DUREE_MOYENNE_JOUR") = If(DureeMoyenneDuTraitement Is Nothing, DBNull.Value, CType(DureeMoyenneDuTraitement, Object))
			p_o_row("VTL_MEDICAMENT_PROPRIOCANDO") = If(AdministrableParProprietaires Is Nothing, DBNull.Value, CType(AdministrableParProprietaires, Object))
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Medicament.</param>
        Public Function Diff(p_o_object As Medicament(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_MEDICAMENT.VTL_MEDICAMENT_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Libelle <> Libelle Then
                l_o_dicDiff.Add(VITAL.VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE, {p_o_object.Libelle,Libelle})
            End If
            If p_o_object.Dosage <> Dosage Then
                l_o_dicDiff.Add(VITAL.VTL_MEDICAMENT.VTL_MEDICAMENT_DOSAGE, {p_o_object.Dosage,Dosage})
            End If
            If Not Object.Equals(p_o_object.DureeMoyenneDuTraitement, DureeMoyenneDuTraitement) Then
                l_o_dicDiff.Add(VITAL.VTL_MEDICAMENT.VTL_MEDICAMENT_DUREE_MOYENNE_JOUR, {p_o_object.DureeMoyenneDuTraitement,DureeMoyenneDuTraitement})
            End If
            If Not Object.Equals(p_o_object.AdministrableParProprietaires, AdministrableParProprietaires) Then
                l_o_dicDiff.Add(VITAL.VTL_MEDICAMENT.VTL_MEDICAMENT_PROPRIOCANDO, {p_o_object.AdministrableParProprietaires,AdministrableParProprietaires})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Position - Position de l'animal"

    ''' <summary>
    ''' Position de l'animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Position(Of T As {VITAL.Position, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Dt_position.
        ''' </summary>
		Private m_dt_dt_position As DateTime

        ''' <summary>
        ''' Coord_lat.
        ''' </summary>
		Private m_s_coord_lat As String

        ''' <summary>
        ''' Coord_long.
        ''' </summary>
		Private m_s_coord_long As String

        ''' <summary>
        ''' Top_courante.
        ''' </summary>
		Private m_b_top_courante As Boolean? = False

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_POSITION.VTL_POSITION_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Dt_position.
        ''' Champ associé : VTL_POSITION.VTL_POSITION_DT_POSITION.
        ''' </summary>
        ''' <value>
        ''' Dt_position.
        ''' </value>
		Public Overridable Property Dt_position As DateTime
            Get
				Return m_dt_dt_position
            End Get
			Set(value As DateTime)
                If m_dt_dt_position <> value Then
                    m_dt_dt_position = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Coord_lat.
        ''' Champ associé : VTL_POSITION.VTL_POSITION_COORD_LAT.
        ''' </summary>
        ''' <value>
        ''' Coord_lat.
        ''' </value>
		Public Overridable Property Coord_lat As String
            Get
				Return m_s_coord_lat
            End Get
			Set(value As String)
                If m_s_coord_lat <> value Then
                    m_s_coord_lat = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Coord_long.
        ''' Champ associé : VTL_POSITION.VTL_POSITION_COORD_LONG.
        ''' </summary>
        ''' <value>
        ''' Coord_long.
        ''' </value>
		Public Overridable Property Coord_long As String
            Get
				Return m_s_coord_long
            End Get
			Set(value As String)
                If m_s_coord_long <> value Then
                    m_s_coord_long = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Top_courante.
        ''' Champ associé : VTL_POSITION.VTL_POSITION_TOP_COURANTE.
        ''' </summary>
        ''' <value>
        ''' Top_courante.
        ''' </value>
		Public Overridable Property Top_courante As Boolean?
            Get
				Return m_b_top_courante
            End Get
			Set(value As Boolean?)
                If Not Object.Equals(m_b_top_courante, value) Then
                    m_b_top_courante = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_POSITION.VTL_POSITION_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_POSITION

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_dt_dt_position
            p_o_target.m_dt_dt_position = m_dt_dt_position
            ' Colonne : m_s_coord_lat
            p_o_target.m_s_coord_lat = m_s_coord_lat
            ' Colonne : m_s_coord_long
            p_o_target.m_s_coord_long = m_s_coord_long
            ' Colonne : m_b_top_courante
            p_o_target.m_b_top_courante = m_b_top_courante
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_POSITION_ID)
			m_dt_dt_position = CDate(p_o_row!VTL_POSITION_DT_POSITION)
			m_s_coord_lat = NzStr(p_o_row!VTL_POSITION_COORD_LAT)
			m_s_coord_long = NzStr(p_o_row!VTL_POSITION_COORD_LONG)
			m_b_top_courante = NzBoolNullable(p_o_row!VTL_POSITION_TOP_COURANTE)
			m_i_id_animal = NzInt(p_o_row!VTL_POSITION_ID_ANIMAL, 0)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_POSITION_ID") = ID
			p_o_row("VTL_POSITION_DT_POSITION") = Dt_position
			p_o_row("VTL_POSITION_COORD_LAT") = Coord_lat
			p_o_row("VTL_POSITION_COORD_LONG") = Coord_long
			p_o_row("VTL_POSITION_TOP_COURANTE") = If(Top_courante Is Nothing, DBNull.Value, CType(Top_courante, Object))
			p_o_row("VTL_POSITION_ID_ANIMAL") = Id_animal
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Position.</param>
        Public Function Diff(p_o_object As Position(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_POSITION.VTL_POSITION_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Dt_position <> Dt_position Then
                l_o_dicDiff.Add(VITAL.VTL_POSITION.VTL_POSITION_DT_POSITION, {p_o_object.Dt_position,Dt_position})
            End If
            If p_o_object.Coord_lat <> Coord_lat Then
                l_o_dicDiff.Add(VITAL.VTL_POSITION.VTL_POSITION_COORD_LAT, {p_o_object.Coord_lat,Coord_lat})
            End If
            If p_o_object.Coord_long <> Coord_long Then
                l_o_dicDiff.Add(VITAL.VTL_POSITION.VTL_POSITION_COORD_LONG, {p_o_object.Coord_long,Coord_long})
            End If
            If Not Object.Equals(p_o_object.Top_courante, Top_courante) Then
                l_o_dicDiff.Add(VITAL.VTL_POSITION.VTL_POSITION_TOP_COURANTE, {p_o_object.Top_courante,Top_courante})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_POSITION.VTL_POSITION_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "PropriEtaire - Propriétaire"

    ''' <summary>
    ''' Propriétaire.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class PropriEtaire(Of T As {VITAL.PropriEtaire, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' DateFin.
        ''' </summary>
		Private m_dt_dateFin As DateTime

        ''' <summary>
        ''' Nom.
        ''' </summary>
		Private m_s_nom As String

        ''' <summary>
        ''' Prenom.
        ''' </summary>
		Private m_s_prenom As String

        ''' <summary>
        ''' Tel.
        ''' </summary>
		Private m_s_tel As String

        ''' <summary>
        ''' Mail.
        ''' </summary>
		Private m_s_mail As String

        ''' <summary>
        ''' Adr.
        ''' </summary>
		Private m_s_adr As String

        ''' <summary>
        ''' Cp.
        ''' </summary>
		Private m_s_cp As String

        ''' <summary>
        ''' Ville.
        ''' </summary>
		Private m_s_ville As String

        ''' <summary>
        ''' id_user.
        ''' </summary>
		Private m_i_id_user As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' DateFin.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_DATEFIN.
        ''' </summary>
        ''' <value>
        ''' DateFin.
        ''' </value>
		Public Overridable Property DateFin As DateTime
            Get
				Return m_dt_dateFin
            End Get
			Set(value As DateTime)
                If m_dt_dateFin <> value Then
                    m_dt_dateFin = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Nom.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM.
        ''' </summary>
        ''' <value>
        ''' Nom.
        ''' </value>
		Public Overridable Property Nom As String
            Get
				Return m_s_nom
            End Get
			Set(value As String)
                If m_s_nom <> value Then
                    m_s_nom = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Prenom.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM.
        ''' </summary>
        ''' <value>
        ''' Prenom.
        ''' </value>
		Public Overridable Property Prenom As String
            Get
				Return m_s_prenom
            End Get
			Set(value As String)
                If m_s_prenom <> value Then
                    m_s_prenom = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Tel.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_TEL.
        ''' </summary>
        ''' <value>
        ''' Tel.
        ''' </value>
		Public Overridable Property Tel As String
            Get
				Return m_s_tel
            End Get
			Set(value As String)
                If m_s_tel <> value Then
                    m_s_tel = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Mail.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_MAIL.
        ''' </summary>
        ''' <value>
        ''' Mail.
        ''' </value>
		Public Overridable Property Mail As String
            Get
				Return m_s_mail
            End Get
			Set(value As String)
                If m_s_mail <> value Then
                    m_s_mail = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Adr.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ADR.
        ''' </summary>
        ''' <value>
        ''' Adr.
        ''' </value>
		Public Overridable Property Adr As String
            Get
				Return m_s_adr
            End Get
			Set(value As String)
                If m_s_adr <> value Then
                    m_s_adr = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Cp.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_CP.
        ''' </summary>
        ''' <value>
        ''' Cp.
        ''' </value>
		Public Overridable Property Cp As String
            Get
				Return m_s_cp
            End Get
			Set(value As String)
                If m_s_cp <> value Then
                    m_s_cp = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Ville.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_VILLE.
        ''' </summary>
        ''' <value>
        ''' Ville.
        ''' </value>
		Public Overridable Property Ville As String
            Get
				Return m_s_ville
            End Get
			Set(value As String)
                If m_s_ville <> value Then
                    m_s_ville = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' id_user.
        ''' Champ associé : VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER.
        ''' </summary>
        ''' <value>
        ''' id_user.
        ''' </value>
		Public Overridable Property id_user As Integer
            Get
				Return m_i_id_user
            End Get
			Set(value As Integer)
                If m_i_id_user <> value Then
                    m_i_id_user = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_PROPRIETAIRE

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_dt_dateFin
            p_o_target.m_dt_dateFin = m_dt_dateFin
            ' Colonne : m_s_nom
            p_o_target.m_s_nom = m_s_nom
            ' Colonne : m_s_prenom
            p_o_target.m_s_prenom = m_s_prenom
            ' Colonne : m_s_tel
            p_o_target.m_s_tel = m_s_tel
            ' Colonne : m_s_mail
            p_o_target.m_s_mail = m_s_mail
            ' Colonne : m_s_adr
            p_o_target.m_s_adr = m_s_adr
            ' Colonne : m_s_cp
            p_o_target.m_s_cp = m_s_cp
            ' Colonne : m_s_ville
            p_o_target.m_s_ville = m_s_ville
            ' Colonne : m_i_id_user
            p_o_target.m_i_id_user = m_i_id_user

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_PROPRIETAIRE_ID)
			m_dt_dateFin = NzDate(p_o_row!VTL_PROPRIETAIRE_DATEFIN)
			m_s_nom = NzStr(p_o_row!VTL_PROPRIETAIRE_NOM)
			m_s_prenom = NzStr(p_o_row!VTL_PROPRIETAIRE_PRENOM)
			m_s_tel = NzStr(p_o_row!VTL_PROPRIETAIRE_TEL)
			m_s_mail = NzStr(p_o_row!VTL_PROPRIETAIRE_MAIL)
			m_s_adr = NzStr(p_o_row!VTL_PROPRIETAIRE_ADR)
			m_s_cp = NzStr(p_o_row!VTL_PROPRIETAIRE_CP)
			m_s_ville = NzStr(p_o_row!VTL_PROPRIETAIRE_VILLE)
			m_i_id_user = NzInt(p_o_row!VTL_PROPRIETAIRE_ID_USER, 0)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_PROPRIETAIRE_ID") = ID
			p_o_row("VTL_PROPRIETAIRE_DATEFIN") = DateFin
			p_o_row("VTL_PROPRIETAIRE_NOM") = Nom
			p_o_row("VTL_PROPRIETAIRE_PRENOM") = Prenom
			p_o_row("VTL_PROPRIETAIRE_TEL") = Tel
			p_o_row("VTL_PROPRIETAIRE_MAIL") = Mail
			p_o_row("VTL_PROPRIETAIRE_ADR") = Adr
			p_o_row("VTL_PROPRIETAIRE_CP") = Cp
			p_o_row("VTL_PROPRIETAIRE_VILLE") = Ville
			p_o_row("VTL_PROPRIETAIRE_ID_USER") = id_user
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe PropriEtaire.</param>
        Public Function Diff(p_o_object As PropriEtaire(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.DateFin <> DateFin Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_DATEFIN, {p_o_object.DateFin,DateFin})
            End If
            If p_o_object.Nom <> Nom Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, {p_o_object.Nom,Nom})
            End If
            If p_o_object.Prenom <> Prenom Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM, {p_o_object.Prenom,Prenom})
            End If
            If p_o_object.Tel <> Tel Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_TEL, {p_o_object.Tel,Tel})
            End If
            If p_o_object.Mail <> Mail Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_MAIL, {p_o_object.Mail,Mail})
            End If
            If p_o_object.Adr <> Adr Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ADR, {p_o_object.Adr,Adr})
            End If
            If p_o_object.Cp <> Cp Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_CP, {p_o_object.Cp,Cp})
            End If
            If p_o_object.Ville <> Ville Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_VILLE, {p_o_object.Ville,Ville})
            End If
            If p_o_object.id_user <> id_user Then
                l_o_dicDiff.Add(VITAL.VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER, {p_o_object.id_user,id_user})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Race - Race de l'animal"

    ''' <summary>
    ''' Race de l'animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Race(Of T As {VITAL.Race, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Nom.
        ''' </summary>
		Private m_s_nom As String

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_RACE.VTL_RACE_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Nom.
        ''' Champ associé : VTL_RACE.VTL_RACE_NOM.
        ''' </summary>
        ''' <value>
        ''' Nom.
        ''' </value>
		Public Overridable Property Nom As String
            Get
				Return m_s_nom
            End Get
			Set(value As String)
                If m_s_nom <> value Then
                    m_s_nom = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_RACE

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_nom
            p_o_target.m_s_nom = m_s_nom

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_RACE_ID)
			m_s_nom = CStr(p_o_row!VTL_RACE_NOM)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_RACE_ID") = ID
			p_o_row("VTL_RACE_NOM") = Nom
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Race.</param>
        Public Function Diff(p_o_object As Race(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_RACE.VTL_RACE_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Nom <> Nom Then
                l_o_dicDiff.Add(VITAL.VTL_RACE.VTL_RACE_NOM, {p_o_object.Nom,Nom})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Remboursement - Remboursement"

    ''' <summary>
    ''' Remboursement.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Remboursement(Of T As {VITAL.Remboursement, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Date.
        ''' </summary>
		Private m_dt_date As DateTime

        ''' <summary>
        ''' Consult.
        ''' </summary>
		Private m_i_consult As Integer

        ''' <summary>
        ''' Contrat.
        ''' </summary>
		Private m_i_contrat As Integer

        ''' <summary>
        ''' Montant.
        ''' </summary>
		Private m_d_montant As Double

        ''' <summary>
        ''' Statut.
        ''' </summary>
		Private m_i_statut As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_REMBOURSMT.VTL_REMBOURSMT_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Date.
        ''' Champ associé : VTL_REMBOURSMT.VTL_REMBOURSMT_DATE.
        ''' </summary>
        ''' <value>
        ''' Date.
        ''' </value>
		Public Overridable Property [Date] As DateTime
            Get
				Return m_dt_date
            End Get
			Set(value As DateTime)
                If m_dt_date <> value Then
                    m_dt_date = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Consult.
        ''' Champ associé : VTL_REMBOURSMT.VTL_REMBOURSMT_CONSULT.
        ''' </summary>
        ''' <value>
        ''' Consult.
        ''' </value>
		Public Overridable Property Consult As Integer
            Get
				Return m_i_consult
            End Get
			Set(value As Integer)
                If m_i_consult <> value Then
                    m_i_consult = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Contrat.
        ''' Champ associé : VTL_REMBOURSMT.VTL_REMBOURSMT_CONTRAT.
        ''' </summary>
        ''' <value>
        ''' Contrat.
        ''' </value>
		Public Overridable Property Contrat As Integer
            Get
				Return m_i_contrat
            End Get
			Set(value As Integer)
                If m_i_contrat <> value Then
                    m_i_contrat = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Montant.
        ''' Champ associé : VTL_REMBOURSMT.VTL_REMBOURSMT_MONTANT.
        ''' </summary>
        ''' <value>
        ''' Montant.
        ''' </value>
		Public Overridable Property Montant As Double
            Get
				Return m_d_montant
            End Get
			Set(value As Double)
                If m_d_montant <> value Then
                    m_d_montant = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Statut.
        ''' Champ associé : VTL_REMBOURSMT.VTL_REMBOURSMT_STATUT.
        ''' </summary>
        ''' <value>
        ''' Statut.
        ''' </value>
		Public Overridable Property Statut As Integer
            Get
				Return m_i_statut
            End Get
			Set(value As Integer)
                If m_i_statut <> value Then
                    m_i_statut = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_REMBOURSMT

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_dt_date
            p_o_target.m_dt_date = m_dt_date
            ' Colonne : m_i_consult
            p_o_target.m_i_consult = m_i_consult
            ' Colonne : m_i_contrat
            p_o_target.m_i_contrat = m_i_contrat
            ' Colonne : m_d_montant
            p_o_target.m_d_montant = m_d_montant
            ' Colonne : m_i_statut
            p_o_target.m_i_statut = m_i_statut

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_REMBOURSMT_ID)
			m_dt_date = NzDate(p_o_row!VTL_REMBOURSMT_DATE)
			m_i_consult = NzInt(p_o_row!VTL_REMBOURSMT_CONSULT, 0)
			m_i_contrat = NzInt(p_o_row!VTL_REMBOURSMT_CONTRAT, 0)
			m_d_montant = CDbl(p_o_row!VTL_REMBOURSMT_MONTANT)
			m_i_statut = CInt(p_o_row!VTL_REMBOURSMT_STATUT)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_REMBOURSMT_ID") = ID
			p_o_row("VTL_REMBOURSMT_DATE") = [Date]
			p_o_row("VTL_REMBOURSMT_CONSULT") = Consult
			p_o_row("VTL_REMBOURSMT_CONTRAT") = Contrat
			p_o_row("VTL_REMBOURSMT_MONTANT") = Montant
			p_o_row("VTL_REMBOURSMT_STATUT") = Statut
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Remboursement.</param>
        Public Function Diff(p_o_object As Remboursement(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_REMBOURSMT.VTL_REMBOURSMT_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.[Date] <> [Date] Then
                l_o_dicDiff.Add(VITAL.VTL_REMBOURSMT.VTL_REMBOURSMT_DATE, {p_o_object.[Date],[Date]})
            End If
            If p_o_object.Consult <> Consult Then
                l_o_dicDiff.Add(VITAL.VTL_REMBOURSMT.VTL_REMBOURSMT_CONSULT, {p_o_object.Consult,Consult})
            End If
            If p_o_object.Contrat <> Contrat Then
                l_o_dicDiff.Add(VITAL.VTL_REMBOURSMT.VTL_REMBOURSMT_CONTRAT, {p_o_object.Contrat,Contrat})
            End If
            If p_o_object.Montant <> Montant Then
                l_o_dicDiff.Add(VITAL.VTL_REMBOURSMT.VTL_REMBOURSMT_MONTANT, {p_o_object.Montant,Montant})
            End If
            If p_o_object.Statut <> Statut Then
                l_o_dicDiff.Add(VITAL.VTL_REMBOURSMT.VTL_REMBOURSMT_STATUT, {p_o_object.Statut,Statut})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Statut - Statut"

    ''' <summary>
    ''' Statut.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Statut(Of T As {VITAL.Statut, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Name.
        ''' </summary>
		Private m_s_name As String

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_STATUT.VTL_STATUT_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Name.
        ''' Champ associé : VTL_STATUT.VTL_STATUT_NAME.
        ''' </summary>
        ''' <value>
        ''' Name.
        ''' </value>
		Public Overridable Property Name As String
            Get
				Return m_s_name
            End Get
			Set(value As String)
                If m_s_name <> value Then
                    m_s_name = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_STATUT

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_name
            p_o_target.m_s_name = m_s_name

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_STATUT_ID)
			m_s_name = CStr(p_o_row!VTL_STATUT_NAME)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_STATUT_ID") = ID
			p_o_row("VTL_STATUT_NAME") = Name
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Statut.</param>
        Public Function Diff(p_o_object As Statut(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_STATUT.VTL_STATUT_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Name <> Name Then
                l_o_dicDiff.Add(VITAL.VTL_STATUT.VTL_STATUT_NAME, {p_o_object.Name,Name})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Traitement_medicament - Liste des médicaments compris dans un traitement"

    ''' <summary>
    ''' Liste des médicaments compris dans un traitement.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Traitement_medicament(Of T As {VITAL.Traitement_medicament, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Id_traitement.
        ''' </summary>
		Private m_i_id_traitement As Integer

        ''' <summary>
        ''' Id_medicament.
        ''' </summary>
		Private m_i_id_medicament As Integer

        ''' <summary>
        ''' Posologie.
        ''' </summary>
		Private m_s_posologie As String

        ''' <summary>
        ''' Duree_jour.
        ''' </summary>
		Private m_i_duree_jour As Integer?

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Id_traitement.
        ''' Champ associé : VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT.
        ''' </summary>
        ''' <value>
        ''' Id_traitement.
        ''' </value>
		Public Overridable Property Id_traitement As Integer
            Get
				Return m_i_id_traitement
            End Get
			Set(value As Integer)
                If m_i_id_traitement <> value Then
                    m_i_id_traitement = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_medicament.
        ''' Champ associé : VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT.
        ''' </summary>
        ''' <value>
        ''' Id_medicament.
        ''' </value>
		Public Overridable Property Id_medicament As Integer
            Get
				Return m_i_id_medicament
            End Get
			Set(value As Integer)
                If m_i_id_medicament <> value Then
                    m_i_id_medicament = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Posologie.
        ''' Champ associé : VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE.
        ''' </summary>
        ''' <value>
        ''' Posologie.
        ''' </value>
		Public Overridable Property Posologie As String
            Get
				Return m_s_posologie
            End Get
			Set(value As String)
                If m_s_posologie <> value Then
                    m_s_posologie = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Duree_jour.
        ''' Champ associé : VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR.
        ''' </summary>
        ''' <value>
        ''' Duree_jour.
        ''' </value>
		Public Overridable Property Duree_jour As Integer?
            Get
				Return m_i_duree_jour
            End Get
			Set(value As Integer?)
                If Not Object.Equals(m_i_duree_jour, value) Then
                    m_i_duree_jour = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_TRAITEMENT_MEDICAMENT

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_i_id_traitement
            p_o_target.m_i_id_traitement = m_i_id_traitement
            ' Colonne : m_i_id_medicament
            p_o_target.m_i_id_medicament = m_i_id_medicament
            ' Colonne : m_s_posologie
            p_o_target.m_s_posologie = m_s_posologie
            ' Colonne : m_i_duree_jour
            p_o_target.m_i_duree_jour = m_i_duree_jour

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_TRAITEMENT_MEDICAMENT_ID)
			m_i_id_traitement = CInt(p_o_row!VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT)
			m_i_id_medicament = NzInt(p_o_row!VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT, 0)
			m_s_posologie = NzStr(p_o_row!VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE)
			m_i_duree_jour = NzIntNullable(p_o_row!VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_TRAITEMENT_MEDICAMENT_ID") = ID
			p_o_row("VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT") = Id_traitement
			p_o_row("VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT") = Id_medicament
			p_o_row("VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE") = Posologie
			p_o_row("VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR") = If(Duree_jour Is Nothing, DBNull.Value, CType(Duree_jour, Object))
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Traitement_medicament.</param>
        Public Function Diff(p_o_object As Traitement_medicament(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Id_traitement <> Id_traitement Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT, {p_o_object.Id_traitement,Id_traitement})
            End If
            If p_o_object.Id_medicament <> Id_medicament Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT, {p_o_object.Id_medicament,Id_medicament})
            End If
            If p_o_object.Posologie <> Posologie Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE, {p_o_object.Posologie,Posologie})
            End If
            If Not Object.Equals(p_o_object.Duree_jour, Duree_jour) Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR, {p_o_object.Duree_jour,Duree_jour})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Traitrement - Traitrement"

    ''' <summary>
    ''' Traitrement.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Traitrement(Of T As {VITAL.Traitrement, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Duree_jour.
        ''' </summary>
		Private m_i_duree_jour As Integer

        ''' <summary>
        ''' Dt_debut.
        ''' </summary>
		Private m_dt_dt_debut As DateTime

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_TRAITREMENT.VTL_TRAITREMENT_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Duree_jour.
        ''' Champ associé : VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR.
        ''' </summary>
        ''' <value>
        ''' Duree_jour.
        ''' </value>
		Public Overridable Property Duree_jour As Integer
            Get
				Return m_i_duree_jour
            End Get
			Set(value As Integer)
                If m_i_duree_jour <> value Then
                    m_i_duree_jour = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_debut.
        ''' Champ associé : VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT.
        ''' </summary>
        ''' <value>
        ''' Dt_debut.
        ''' </value>
		Public Overridable Property Dt_debut As DateTime
            Get
				Return m_dt_dt_debut
            End Get
			Set(value As DateTime)
                If m_dt_dt_debut <> value Then
                    m_dt_dt_debut = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_TRAITREMENT.VTL_TRAITREMENT_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_TRAITREMENT

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_i_duree_jour
            p_o_target.m_i_duree_jour = m_i_duree_jour
            ' Colonne : m_dt_dt_debut
            p_o_target.m_dt_dt_debut = m_dt_dt_debut
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_TRAITREMENT_ID)
			m_i_duree_jour = CInt(p_o_row!VTL_TRAITREMENT_DUREE_JOUR)
			m_dt_dt_debut = NzDate(p_o_row!VTL_TRAITREMENT_DT_DEBUT)
			m_i_id_animal = NzInt(p_o_row!VTL_TRAITREMENT_ID_ANIMAL, 0)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_TRAITREMENT_ID") = ID
			p_o_row("VTL_TRAITREMENT_DUREE_JOUR") = Duree_jour
			p_o_row("VTL_TRAITREMENT_DT_DEBUT") = Dt_debut
			p_o_row("VTL_TRAITREMENT_ID_ANIMAL") = Id_animal
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Traitrement.</param>
        Public Function Diff(p_o_object As Traitrement(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITREMENT.VTL_TRAITREMENT_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Duree_jour <> Duree_jour Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR, {p_o_object.Duree_jour,Duree_jour})
            End If
            If p_o_object.Dt_debut <> Dt_debut Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT, {p_o_object.Dt_debut,Dt_debut})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_TRAITREMENT.VTL_TRAITREMENT_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Type - Typede l'animal"

    ''' <summary>
    ''' Typede l'animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Type(Of T As {VITAL.Type, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Libelle.
        ''' </summary>
		Private m_s_libelle As String

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_TYPE.VTL_TYPE_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Libelle.
        ''' Champ associé : VTL_TYPE.VTL_TYPE_LIBELLE.
        ''' </summary>
        ''' <value>
        ''' Libelle.
        ''' </value>
		Public Overridable Property Libelle As String
            Get
				Return m_s_libelle
            End Get
			Set(value As String)
                If m_s_libelle <> value Then
                    m_s_libelle = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_TYPE

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_libelle
            p_o_target.m_s_libelle = m_s_libelle

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_TYPE_ID)
			m_s_libelle = CStr(p_o_row!VTL_TYPE_LIBELLE)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_TYPE_ID") = ID
			p_o_row("VTL_TYPE_LIBELLE") = Libelle
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Type.</param>
        Public Function Diff(p_o_object As Type(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_TYPE.VTL_TYPE_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Libelle <> Libelle Then
                l_o_dicDiff.Add(VITAL.VTL_TYPE.VTL_TYPE_LIBELLE, {p_o_object.Libelle,Libelle})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "User - User"

    ''' <summary>
    ''' User.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class User(Of T As {VITAL.User, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Login.
        ''' </summary>
		Private m_s_login As String

        ''' <summary>
        ''' Mdp.
        ''' </summary>
		Private m_s_mdp As String

        ''' <summary>
        ''' Role.
        ''' </summary>
		Private m_s_role As String

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_USER.VTL_USER_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Login.
        ''' Champ associé : VTL_USER.VTL_USER_LOGIN.
        ''' </summary>
        ''' <value>
        ''' Login.
        ''' </value>
		Public Overridable Property Login As String
            Get
				Return m_s_login
            End Get
			Set(value As String)
                If m_s_login <> value Then
                    m_s_login = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Mdp.
        ''' Champ associé : VTL_USER.VTL_USER_MDP.
        ''' </summary>
        ''' <value>
        ''' Mdp.
        ''' </value>
		Public Overridable Property Mdp As String
            Get
				Return m_s_mdp
            End Get
			Set(value As String)
                If m_s_mdp <> value Then
                    m_s_mdp = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Role.
        ''' Champ associé : VTL_USER.VTL_USER_ROLE.
        ''' </summary>
        ''' <value>
        ''' Role.
        ''' </value>
		Public Overridable Property Role As String
            Get
				Return m_s_role
            End Get
			Set(value As String)
                If m_s_role <> value Then
                    m_s_role = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_USER

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_login
            p_o_target.m_s_login = m_s_login
            ' Colonne : m_s_mdp
            p_o_target.m_s_mdp = m_s_mdp
            ' Colonne : m_s_role
            p_o_target.m_s_role = m_s_role

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_USER_ID)
			m_s_login = CStr(p_o_row!VTL_USER_LOGIN)
			m_s_mdp = CStr(p_o_row!VTL_USER_MDP)
			m_s_role = CStr(p_o_row!VTL_USER_ROLE)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_USER_ID") = ID
			p_o_row("VTL_USER_LOGIN") = Login
			p_o_row("VTL_USER_MDP") = Mdp
			p_o_row("VTL_USER_ROLE") = Role
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe User.</param>
        Public Function Diff(p_o_object As User(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_USER.VTL_USER_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Login <> Login Then
                l_o_dicDiff.Add(VITAL.VTL_USER.VTL_USER_LOGIN, {p_o_object.Login,Login})
            End If
            If p_o_object.Mdp <> Mdp Then
                l_o_dicDiff.Add(VITAL.VTL_USER.VTL_USER_MDP, {p_o_object.Mdp,Mdp})
            End If
            If p_o_object.Role <> Role Then
                l_o_dicDiff.Add(VITAL.VTL_USER.VTL_USER_ROLE, {p_o_object.Role,Role})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Vaccin - Vaccin"

    ''' <summary>
    ''' Vaccin.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Vaccin(Of T As {VITAL.Vaccin, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Libelle.
        ''' </summary>
		Private m_s_libelle As String

        ''' <summary>
        ''' VaccinPeriodique.
        ''' </summary>
		Private m_b_vaccinPeriodique As Boolean? = False

        ''' <summary>
        ''' MoisPeriode.
        ''' </summary>
		Private m_i_moisPeriode As Integer?

        ''' <summary>
        ''' Recommande.
        ''' </summary>
		Private m_b_recommande As Boolean? = False

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_VACCIN.VTL_VACCIN_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Libelle.
        ''' Champ associé : VTL_VACCIN.VTL_VACCIN_LIBELLE.
        ''' </summary>
        ''' <value>
        ''' Libelle.
        ''' </value>
		Public Overridable Property Libelle As String
            Get
				Return m_s_libelle
            End Get
			Set(value As String)
                If m_s_libelle <> value Then
                    m_s_libelle = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' VaccinPeriodique.
        ''' Champ associé : VTL_VACCIN.VTL_VACCIN_TOP_PERIODIQUE.
        ''' </summary>
        ''' <value>
        ''' VaccinPeriodique.
        ''' </value>
		Public Overridable Property VaccinPeriodique As Boolean?
            Get
				Return m_b_vaccinPeriodique
            End Get
			Set(value As Boolean?)
                If Not Object.Equals(m_b_vaccinPeriodique, value) Then
                    m_b_vaccinPeriodique = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' MoisPeriode.
        ''' Champ associé : VTL_VACCIN.VTL_VACCIN_PERIODE_MOIS.
        ''' </summary>
        ''' <value>
        ''' MoisPeriode.
        ''' </value>
		Public Overridable Property MoisPeriode As Integer?
            Get
				Return m_i_moisPeriode
            End Get
			Set(value As Integer?)
                If Not Object.Equals(m_i_moisPeriode, value) Then
                    m_i_moisPeriode = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Recommande.
        ''' Champ associé : VTL_VACCIN.VTL_VACCIN_TOP_RECOMMANDATION.
        ''' </summary>
        ''' <value>
        ''' Recommande.
        ''' </value>
		Public Overridable Property Recommande As Boolean?
            Get
				Return m_b_recommande
            End Get
			Set(value As Boolean?)
                If Not Object.Equals(m_b_recommande, value) Then
                    m_b_recommande = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_VACCIN

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_libelle
            p_o_target.m_s_libelle = m_s_libelle
            ' Colonne : m_b_vaccinPeriodique
            p_o_target.m_b_vaccinPeriodique = m_b_vaccinPeriodique
            ' Colonne : m_i_moisPeriode
            p_o_target.m_i_moisPeriode = m_i_moisPeriode
            ' Colonne : m_b_recommande
            p_o_target.m_b_recommande = m_b_recommande

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_VACCIN_ID)
			m_s_libelle = CStr(p_o_row!VTL_VACCIN_LIBELLE)
			m_b_vaccinPeriodique = NzBoolNullable(p_o_row!VTL_VACCIN_TOP_PERIODIQUE)
			m_i_moisPeriode = NzIntNullable(p_o_row!VTL_VACCIN_PERIODE_MOIS)
			m_b_recommande = NzBoolNullable(p_o_row!VTL_VACCIN_TOP_RECOMMANDATION)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_VACCIN_ID") = ID
			p_o_row("VTL_VACCIN_LIBELLE") = Libelle
			p_o_row("VTL_VACCIN_TOP_PERIODIQUE") = If(VaccinPeriodique Is Nothing, DBNull.Value, CType(VaccinPeriodique, Object))
			p_o_row("VTL_VACCIN_PERIODE_MOIS") = If(MoisPeriode Is Nothing, DBNull.Value, CType(MoisPeriode, Object))
			p_o_row("VTL_VACCIN_TOP_RECOMMANDATION") = If(Recommande Is Nothing, DBNull.Value, CType(Recommande, Object))
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Vaccin.</param>
        Public Function Diff(p_o_object As Vaccin(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_VACCIN.VTL_VACCIN_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Libelle <> Libelle Then
                l_o_dicDiff.Add(VITAL.VTL_VACCIN.VTL_VACCIN_LIBELLE, {p_o_object.Libelle,Libelle})
            End If
            If Not Object.Equals(p_o_object.VaccinPeriodique, VaccinPeriodique) Then
                l_o_dicDiff.Add(VITAL.VTL_VACCIN.VTL_VACCIN_TOP_PERIODIQUE, {p_o_object.VaccinPeriodique,VaccinPeriodique})
            End If
            If Not Object.Equals(p_o_object.MoisPeriode, MoisPeriode) Then
                l_o_dicDiff.Add(VITAL.VTL_VACCIN.VTL_VACCIN_PERIODE_MOIS, {p_o_object.MoisPeriode,MoisPeriode})
            End If
            If Not Object.Equals(p_o_object.Recommande, Recommande) Then
                l_o_dicDiff.Add(VITAL.VTL_VACCIN.VTL_VACCIN_TOP_RECOMMANDATION, {p_o_object.Recommande,Recommande})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Vaccination - Vaccination d'un animal"

    ''' <summary>
    ''' Vaccination d'un animal.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Vaccination(Of T As {VITAL.Vaccination, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' Id_animal.
        ''' </summary>
		Private m_i_id_animal As Integer

        ''' <summary>
        ''' Id_vaccin.
        ''' </summary>
		Private m_i_id_vaccin As Integer

        ''' <summary>
        ''' Dt_vaccin.
        ''' </summary>
		Private m_dt_dt_vaccin As DateTime

        ''' <summary>
        ''' Id_consultation.
        ''' </summary>
		Private m_i_id_consultation As Integer

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_VACCINATION.VTL_VACCINATION_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' Id_animal.
        ''' Champ associé : VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL.
        ''' </summary>
        ''' <value>
        ''' Id_animal.
        ''' </value>
		Public Overridable Property Id_animal As Integer
            Get
				Return m_i_id_animal
            End Get
			Set(value As Integer)
                If m_i_id_animal <> value Then
                    m_i_id_animal = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_vaccin.
        ''' Champ associé : VTL_VACCINATION.VTL_VACCINATION_ID_VACCIN.
        ''' </summary>
        ''' <value>
        ''' Id_vaccin.
        ''' </value>
		Public Overridable Property Id_vaccin As Integer
            Get
				Return m_i_id_vaccin
            End Get
			Set(value As Integer)
                If m_i_id_vaccin <> value Then
                    m_i_id_vaccin = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Dt_vaccin.
        ''' Champ associé : VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN.
        ''' </summary>
        ''' <value>
        ''' Dt_vaccin.
        ''' </value>
		Public Overridable Property Dt_vaccin As DateTime
            Get
				Return m_dt_dt_vaccin
            End Get
			Set(value As DateTime)
                If m_dt_dt_vaccin <> value Then
                    m_dt_dt_vaccin = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Id_consultation.
        ''' Champ associé : VTL_VACCINATION.VTL_VACCINATION_ID_CONSULTATION.
        ''' </summary>
        ''' <value>
        ''' Id_consultation.
        ''' </value>
		Public Overridable Property Id_consultation As Integer
            Get
				Return m_i_id_consultation
            End Get
			Set(value As Integer)
                If m_i_id_consultation <> value Then
                    m_i_id_consultation = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_VACCINATION

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_i_id_animal
            p_o_target.m_i_id_animal = m_i_id_animal
            ' Colonne : m_i_id_vaccin
            p_o_target.m_i_id_vaccin = m_i_id_vaccin
            ' Colonne : m_dt_dt_vaccin
            p_o_target.m_dt_dt_vaccin = m_dt_dt_vaccin
            ' Colonne : m_i_id_consultation
            p_o_target.m_i_id_consultation = m_i_id_consultation

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_VACCINATION_ID)
			m_i_id_animal = CInt(p_o_row!VTL_VACCINATION_ID_ANIMAL)
			m_i_id_vaccin = NzInt(p_o_row!VTL_VACCINATION_ID_VACCIN, 0)
			m_dt_dt_vaccin = NzDate(p_o_row!VTL_VACCINATION_DT_VACCIN)
			m_i_id_consultation = NzInt(p_o_row!VTL_VACCINATION_ID_CONSULTATION, 0)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_VACCINATION_ID") = ID
			p_o_row("VTL_VACCINATION_ID_ANIMAL") = Id_animal
			p_o_row("VTL_VACCINATION_ID_VACCIN") = Id_vaccin
			p_o_row("VTL_VACCINATION_DT_VACCIN") = Dt_vaccin
			p_o_row("VTL_VACCINATION_ID_CONSULTATION") = Id_consultation
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Vaccination.</param>
        Public Function Diff(p_o_object As Vaccination(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_VACCINATION.VTL_VACCINATION_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.Id_animal <> Id_animal Then
                l_o_dicDiff.Add(VITAL.VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL, {p_o_object.Id_animal,Id_animal})
            End If
            If p_o_object.Id_vaccin <> Id_vaccin Then
                l_o_dicDiff.Add(VITAL.VTL_VACCINATION.VTL_VACCINATION_ID_VACCIN, {p_o_object.Id_vaccin,Id_vaccin})
            End If
            If p_o_object.Dt_vaccin <> Dt_vaccin Then
                l_o_dicDiff.Add(VITAL.VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN, {p_o_object.Dt_vaccin,Dt_vaccin})
            End If
            If p_o_object.Id_consultation <> Id_consultation Then
                l_o_dicDiff.Add(VITAL.VTL_VACCINATION.VTL_VACCINATION_ID_CONSULTATION, {p_o_object.Id_consultation,Id_consultation})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

#Region "Veterinaire - Veterinaire"

    ''' <summary>
    ''' Veterinaire.
    ''' </summary>
    <Serializable()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Modeler", "1.4")> _
    Public MustInherit Class Veterinaire(Of T As {VITAL.Veterinaire, New})
        Inherits VITAL.Schema


#Region "Variables privées"

        ''' <summary>
        ''' Indique s'il y a eu des changements sur l'objet ou non
        ''' </summary>
        Private m_b_changes As Boolean = False

        ''' <summary>
        ''' ID.
        ''' </summary>
		Private m_i_iD As Integer

        ''' <summary>
        ''' SIRET.
        ''' </summary>
		Private m_s_sIRET As String

        ''' <summary>
        ''' id_user.
        ''' </summary>
		Private m_i_id_user As Integer

        ''' <summary>
        ''' Nom.
        ''' </summary>
		Private m_s_nom As String

        ''' <summary>
        ''' Prenom.
        ''' </summary>
		Private m_s_prenom As String

        ''' <summary>
        ''' Tel.
        ''' </summary>
		Private m_s_tel As String

        ''' <summary>
        ''' Mail.
        ''' </summary>
		Private m_s_mail As String

        ''' <summary>
        ''' Adr.
        ''' </summary>
		Private m_s_adr As String

        ''' <summary>
        ''' Cp.
        ''' </summary>
		Private m_s_cp As String

        ''' <summary>
        ''' Ville.
        ''' </summary>
		Private m_s_ville As String

#End Region

#Region "Propriétés publiques"

        ''' <summary>
        ''' Indique si l'objet a subi des modifications ou non
        ''' </summary>
        ''' <value>
        '''
        ''' </value>
        Public Property HasChanges As Boolean
            Get
                Return m_b_changes
            End Get
            Set(value As Boolean)
                m_b_changes = value
            End Set
        End Property

        ''' <summary>
        ''' ID.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_ID.
        ''' </summary>
        ''' <value>
        ''' ID.
        ''' </value>
		Public Overridable ReadOnly Property ID As Integer
            Get
				Return m_i_iD
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Protected Sub SetAutoId(p_i_iD As Integer)
            m_i_iD = p_i_iD
        End Sub

        ''' <summary>
        ''' SIRET.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_SIRET.
        ''' </summary>
        ''' <value>
        ''' SIRET.
        ''' </value>
		Public Overridable Property SIRET As String
            Get
				Return m_s_sIRET
            End Get
			Set(value As String)
                If m_s_sIRET <> value Then
                    m_s_sIRET = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' id_user.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_ID_USER.
        ''' </summary>
        ''' <value>
        ''' id_user.
        ''' </value>
		Public Overridable Property id_user As Integer
            Get
				Return m_i_id_user
            End Get
			Set(value As Integer)
                If m_i_id_user <> value Then
                    m_i_id_user = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Nom.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_NOM.
        ''' </summary>
        ''' <value>
        ''' Nom.
        ''' </value>
		Public Overridable Property Nom As String
            Get
				Return m_s_nom
            End Get
			Set(value As String)
                If m_s_nom <> value Then
                    m_s_nom = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Prenom.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM.
        ''' </summary>
        ''' <value>
        ''' Prenom.
        ''' </value>
		Public Overridable Property Prenom As String
            Get
				Return m_s_prenom
            End Get
			Set(value As String)
                If m_s_prenom <> value Then
                    m_s_prenom = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Tel.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_TEL.
        ''' </summary>
        ''' <value>
        ''' Tel.
        ''' </value>
		Public Overridable Property Tel As String
            Get
				Return m_s_tel
            End Get
			Set(value As String)
                If m_s_tel <> value Then
                    m_s_tel = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Mail.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_MAIL.
        ''' </summary>
        ''' <value>
        ''' Mail.
        ''' </value>
		Public Overridable Property Mail As String
            Get
				Return m_s_mail
            End Get
			Set(value As String)
                If m_s_mail <> value Then
                    m_s_mail = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Adr.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_ADR.
        ''' </summary>
        ''' <value>
        ''' Adr.
        ''' </value>
		Public Overridable Property Adr As String
            Get
				Return m_s_adr
            End Get
			Set(value As String)
                If m_s_adr <> value Then
                    m_s_adr = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Cp.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_CP.
        ''' </summary>
        ''' <value>
        ''' Cp.
        ''' </value>
		Public Overridable Property Cp As String
            Get
				Return m_s_cp
            End Get
			Set(value As String)
                If m_s_cp <> value Then
                    m_s_cp = value
                    HasChanges = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' Ville.
        ''' Champ associé : VTL_VETERINAIRE.VTL_VETERINAIRE_VILLE.
        ''' </summary>
        ''' <value>
        ''' Ville.
        ''' </value>
		Public Overridable Property Ville As String
            Get
				Return m_s_ville
            End Get
			Set(value As String)
                If m_s_ville <> value Then
                    m_s_ville = value
                    HasChanges = True
                End If
            End Set
        End Property

#End Region

#Region "Constantes publiques"

        ''' <summary>
        ''' Indique si l'objet a un historique ou non
        ''' </summary>
        Public Const HasHisto As Boolean = False

        ''' <summary>
        ''' Indique si l'objet utilise le cache ou non
        ''' </summary>
        Public Const HasCache As Boolean = False

        ''' <summary>
        ''' Nom de la table associée à la classe.
        ''' </summary>
        <Obsolete("Veuillez utiliser la classe 'Tables'.")>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
        Public Const TableName As String = Tables.VTL_VETERINAIRE

#End Region

#Region "Méthodes publiques"

        ''' <summary> Clone l'objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Function CloneAsNew(Optional p_b_includeKeyValues As Boolean = False) As T
            Dim l_o_target As New T()

            ' Copie des propriétés et retour
            Return CopyTo(l_o_target, p_b_includeKeyValues)
        End Function

        ''' <summary> Copie objet vers un autre avec la possibilité d'occulter la valorisation des propriétés des clés primaires.
        ''' </summary>
        ''' <param name="p_b_includeKeyValues"> <c>true</c> pour inclure les valeurs des clés primaires.</param>
        ''' <returns> <paramref name="p_o_target"/></returns>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Overridable Function CopyTo(p_o_target As T, Optional p_b_includeKeyValues As Boolean = False) As T

            ' Vérification des paramètres.
            If (p_o_target Is Nothing) Then
                Throw New ArgumentNullException("p_o_target")
            End If

            ' Copie des valeurs des clés primaires
            If p_b_includeKeyValues Then
                ' Column : m_i_iD
                p_o_target.m_i_iD = m_i_iD
            End If
            p_o_target.m_i_iD = m_i_iD
            ' Colonne : m_s_sIRET
            p_o_target.m_s_sIRET = m_s_sIRET
            ' Colonne : m_i_id_user
            p_o_target.m_i_id_user = m_i_id_user
            ' Colonne : m_s_nom
            p_o_target.m_s_nom = m_s_nom
            ' Colonne : m_s_prenom
            p_o_target.m_s_prenom = m_s_prenom
            ' Colonne : m_s_tel
            p_o_target.m_s_tel = m_s_tel
            ' Colonne : m_s_mail
            p_o_target.m_s_mail = m_s_mail
            ' Colonne : m_s_adr
            p_o_target.m_s_adr = m_s_adr
            ' Colonne : m_s_cp
            p_o_target.m_s_cp = m_s_cp
            ' Colonne : m_s_ville
            p_o_target.m_s_ville = m_s_ville

            ' Retour de l'objet cible pour appel en chaine
            Return p_o_target
        End Function

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub Load(p_o_row As DataRow)
            If p_o_row Is Nothing Then Throw New Exception("#RECORD_NOT_FOUND")
			m_i_iD = CInt(p_o_row!VTL_VETERINAIRE_ID)
			m_s_sIRET = NzStr(p_o_row!VTL_VETERINAIRE_SIRET)
			m_i_id_user = NzInt(p_o_row!VTL_VETERINAIRE_ID_USER, 0)
			m_s_nom = NzStr(p_o_row!VTL_VETERINAIRE_NOM)
			m_s_prenom = NzStr(p_o_row!VTL_VETERINAIRE_PRENOM)
			m_s_tel = NzStr(p_o_row!VTL_VETERINAIRE_TEL)
			m_s_mail = NzStr(p_o_row!VTL_VETERINAIRE_MAIL)
			m_s_adr = NzStr(p_o_row!VTL_VETERINAIRE_ADR)
			m_s_cp = NzStr(p_o_row!VTL_VETERINAIRE_CP)
			m_s_ville = NzStr(p_o_row!VTL_VETERINAIRE_VILLE)
            HasChanges = False
        End Sub

        ''' <summary>
        ''' Chargement des informations à partir de la table.
        ''' </summary>
        ''' <param name="p_o_row">Enregistrement.</param>
        Public Overridable Sub ToRow(p_o_row As DataRow)
			p_o_row("VTL_VETERINAIRE_ID") = ID
			p_o_row("VTL_VETERINAIRE_SIRET") = SIRET
			p_o_row("VTL_VETERINAIRE_ID_USER") = id_user
			p_o_row("VTL_VETERINAIRE_NOM") = Nom
			p_o_row("VTL_VETERINAIRE_PRENOM") = Prenom
			p_o_row("VTL_VETERINAIRE_TEL") = Tel
			p_o_row("VTL_VETERINAIRE_MAIL") = Mail
			p_o_row("VTL_VETERINAIRE_ADR") = Adr
			p_o_row("VTL_VETERINAIRE_CP") = Cp
			p_o_row("VTL_VETERINAIRE_VILLE") = Ville
        End Sub

        ''' <summary>
        ''' Permet de détecter toutes les différences entre 2 objets
        ''' </summary>
        ''' <param name="p_o_object">Objet de la classe Veterinaire.</param>
        Public Function Diff(p_o_object As Veterinaire(Of T)) As Dictionary(Of String, Object())
            Dim l_o_dicDiff As New Dictionary(Of String, Object())

            If p_o_object.ID <> ID Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_ID, {p_o_object.ID,ID})
            End If
            If p_o_object.SIRET <> SIRET Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_SIRET, {p_o_object.SIRET,SIRET})
            End If
            If p_o_object.id_user <> id_user Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_ID_USER, {p_o_object.id_user,id_user})
            End If
            If p_o_object.Nom <> Nom Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_NOM, {p_o_object.Nom,Nom})
            End If
            If p_o_object.Prenom <> Prenom Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM, {p_o_object.Prenom,Prenom})
            End If
            If p_o_object.Tel <> Tel Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_TEL, {p_o_object.Tel,Tel})
            End If
            If p_o_object.Mail <> Mail Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_MAIL, {p_o_object.Mail,Mail})
            End If
            If p_o_object.Adr <> Adr Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_ADR, {p_o_object.Adr,Adr})
            End If
            If p_o_object.Cp <> Cp Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_CP, {p_o_object.Cp,Cp})
            End If
            If p_o_object.Ville <> Ville Then
                l_o_dicDiff.Add(VITAL.VTL_VETERINAIRE.VTL_VETERINAIRE_VILLE, {p_o_object.Ville,Ville})
            End If
            Return l_o_dicDiff
        End Function

#End Region

    End Class

#End Region

End Namespace

