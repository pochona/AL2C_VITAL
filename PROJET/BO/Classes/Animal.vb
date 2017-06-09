Namespace VITAL

    ''' <summary>
    ''' Animal.
    ''' </summary>
    Partial Public Class Animal

        ' Exemple
        ''' <summary>
        ''' Retourne l'id de l'animal - Accessible depuis 1 objet de la classe : p_o_animal.GetThisAnimal2().
        ''' </summary>
        ''' <returns>L'id de l'animal - Accessible depuis 1 objet de la classe : p_o_animal.GetThisAnimal2().
        ''' </returns>
        Public Function GetThisAnimal() As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddFrom(Tables.VTL_ANIMAL)
                .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_NOM, Nom)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

        ' Exemple
        ''' <summary>
        ''' Retourne l'id de l'animal - Accessible sans objet de la classe : Animal.GetThisAnimal2("Rex").
        ''' </summary>
        ''' <param name="p_s_name">Nom de l'animal.</param>
        ''' <returns>L'id de l'animal - Accessible sans objet de la classe : Animal.GetThisAnimal2("Rex").
        ''' </returns>
        Public Shared Function GetThisAnimal2(p_s_name As String) As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddFrom(Tables.VTL_ANIMAL)
                .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_NOM, p_s_name)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

#Region "Propriétaire - animaux"

        ''' <summary>
        ''' Retourne la liste des animaux du proprio.
        ''' </summary>
        ''' <param name="p_s_logginProprio">Login du propriétaire.</param>
        ''' <returns>La liste des animaux du proprio.</returns>
        Public Shared Function GetAnimauxProprio(p_s_logginProprio As String) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(Tables.VTL_ANIMAL + "." + VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_DT_DECES)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_DT_NAISSANCE)
                .AddSelect(Tables.VTL_ANIMAL + "." + VTL_ANIMAL.VTL_ANIMAL_ID_CARTE)
                .AddSelect(VTL_CARTE.VTL_CARTE_NFC)
                .AddSelect(VTL_RACE.VTL_RACE_NOM)
                .AddSelect(VTL_TYPE.VTL_TYPE_LIBELLE)
                .AddFrom(Tables.VTL_ANIMAL)
                .AddFrom(Tables.VTL_RACE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_RACE.VTL_RACE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_RACE)
                .AddFrom(Tables.VTL_TYPE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_TYPE.VTL_TYPE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_TYPE)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
                .AddFrom(Tables.VTL_USER, DbJoin.Right, Tables.VTL_PROPRIETAIRE, VTL_USER.VTL_USER_ID, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER)
                .AddFrom(Tables.VTL_CARTE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_CARTE.VTL_CARTE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_CARTE)
                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_logginProprio)
            End With
            Return l_o_sql
        End Function

        ''' <summary>
        ''' Retourne nb d'animaux d'un prop.
        ''' </summary>
        ''' <param name="p_s_logProp"></param>
        ''' <returns>Nb d'animaux d'un prop.</returns>
        Public Shared Function GetNbAnimaux(p_s_logProp As String) As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()

                .AddSelect("COUNT(" + VTL_ANIMAL.VTL_ANIMAL_ID + ")", "NBANIMX")
                .AddFrom(Tables.VTL_ANIMAL)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
                .AddFrom(Tables.VTL_USER, DbJoin.Right, Tables.VTL_PROPRIETAIRE, VTL_USER.VTL_USER_ID, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER)

                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_logProp)
                If Not .GetFirstRow Is Nothing Then
                    Return CInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

#End Region

#Region "Informations de l'animal"

        ''' <summary>
        ''' Retourne le dernier poids enregistre de l'animal.
        ''' </summary>
        ''' <returns>Le dernier poids enregistre de l'animal.</returns>
        Public Function GetLastPoids() As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS)
                .AddFrom(Tables.VTL_HISTO_POIDS)
                '  .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_HISTO_POIDS, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID_ANIMAL)
                .AddWhereIs(VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID_ANIMAL, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

        ''' <summary>
        ''' Retourne la derniere taille enregistrée de l'animal.
        ''' </summary>
        ''' <returns>La derniere taille enregistrée de l'animal.</returns>
        Public Function GetLastTaille() As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_TAILLE)
                .AddFrom(Tables.VTL_HISTO_TAILLE)
                '  .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_HISTO_POIDS, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID_ANIMAL)
                .AddWhereIs(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_ID_ANIMAL, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

        ''' <summary>
        ''' Retourne le numéro de carte vitale.
        ''' </summary>
        ''' <returns>Le numéro de carte vitale.</returns>
        Public Function GetNumCarteVit() As String
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_CARTE.VTL_CARTE_NUMERO)
                .AddFrom(Tables.VTL_CARTE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CARTE, VTL_ANIMAL.VTL_ANIMAL_ID_CARTE, VTL_CARTE.VTL_CARTE_ID)
                .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_ID, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzStr((.GetFirstValue))
                Else
                    Return ""
                End If
            End With
        End Function

        ''' <summary>
        ''' Retourne le dernier ID conseil diététique enregistré.
        ''' </summary>
        ''' <returns>Le dernier ID conseil diététique enregistré.</returns>
        Public Function GetIDConseilDiet() As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_CNSLDIET.CNSLDIET_ID)
                .AddFrom(Tables.VTL_CNSLDIET)
                .AddWhereIs(VTL_CNSLDIET.CNSLDIET_ID_ANIMAL, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

        ''' <summary>
        ''' Retourne le nom prénom de son propriétaire.
        ''' </summary>
        ''' <returns>Le nom prénom de son propriétaire.</returns>
        Public Function GetNomPrenomProprio() As String
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(MyDB.FctConcat(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, TextSQL(", "), VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM), "nom_prenom")
                .AddFrom(Tables.VTL_ANIMAL)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
                .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_ID, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzStr((.GetFirstValue))
                Else
                    Return ""
                End If
            End With
        End Function

#End Region

#Region "Recherche"

        ''' <summary>
        ''' Retourne les animaux qui correspondent aux critères de recherche.
        ''' </summary>
        ''' <param name="p_s_NumCarte">Numéro de carte vital (NUMERO ET PAS ID NI NFC).</param>
        ''' <param name="p_s_NomAnimal">Nom animal.</param>
        ''' <param name="p_s_NomProprio">Nom Proprio.</param>
        ''' <param name="p_s_PrenomProprio">Prénom proprio.</param>
        ''' <returns>Les animaux qui correspondent aux critères de recherche.</returns>
        Public Shared Function GetAnimxSearched(p_s_NumCarte As String, p_s_NomAnimal As String, _
                                                p_s_NomProprio As String, p_s_PrenomProprio As String) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                ' Requête principale
                .Clear()
                ' .AddOption(DbSelectOption.Distinct)
                ' .AddSelect(Tables.SAV_DMDE + "." + SAV_DMDE.APP_ID)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_DT_NAISSANCE)
                .AddSelect(VTL_CARTE.VTL_CARTE_NUMERO)
                .AddSelect(MyDB.FctConcat(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, TextSQL(", "), VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM), "nom_prenom")
                .AddSelect(VTL_RACE.VTL_RACE_NOM)
                .AddSelect(VTL_TYPE.VTL_TYPE_LIBELLE)
                'FROM
                .AddFrom(Tables.VTL_ANIMAL)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
                .AddFrom(Tables.VTL_RACE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_RACE.VTL_RACE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_RACE)
                .AddFrom(Tables.VTL_TYPE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_TYPE.VTL_TYPE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_TYPE)
                .AddFrom(Tables.VTL_CARTE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_CARTE.VTL_CARTE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_CARTE)
                'WHERE
                If p_s_NumCarte <> "" Then .AddWhereContains(VTL_CARTE.VTL_CARTE_NUMERO, p_s_NumCarte)
                If p_s_NomAnimal <> "" Then .AddWhereContains(VTL_ANIMAL.VTL_ANIMAL_NOM, p_s_NomAnimal)
                If p_s_NomProprio <> "" Then .AddWhereContains(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, p_s_NomProprio)
                If p_s_PrenomProprio <> "" Then .AddWhereContains(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM, p_s_PrenomProprio)
            End With
            Return l_o_sql
        End Function

#End Region

#Region "Contrat mutuelle "

        ''' <summary>
        ''' Retourne l'id du contrat de l'animal.
        ''' </summary>
        ''' <returns>L'id du contrat de l'animal.</returns>
        Public Function GetIdContrat() As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_ID)

                'FROM
                .AddFrom(Tables.VTL_ANIMAL)
                .AddFrom(Tables.VTL_CONTRAT, DbJoin.Right, Tables.VTL_ANIMAL, VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL, VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddWhereIs(VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE, Id_prop)
                'x .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_FIN + ">=" + MyDB.SqlDate(Now.Date))
                'x .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT + ">=" + MyDB.SqlDate(Now.Date))
                .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_FIN + ">='" + Now.Year.ToString + "/" + Now.Month.ToString + "/" + Now.Day.ToString + "'")
                .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT + "<='" + Now.Year.ToString + "/" + Now.Month.ToString + "/" + Now.Day.ToString + "'")
          

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function


#End Region

    End Class

End Namespace
