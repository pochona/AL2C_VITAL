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

#End Region
    End Class

End Namespace
