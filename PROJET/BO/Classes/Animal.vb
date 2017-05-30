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
                .AddFrom(Tables.VTL_USER, DbJoin.Right, Tables.VTL_ANIMAL, VTL_USER.VTL_USER_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
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
                .AddFrom(Tables.VTL_USER, DbJoin.Right, Tables.VTL_ANIMAL, VTL_USER.VTL_USER_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)

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

#End Region
    End Class

End Namespace
