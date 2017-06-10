Namespace VITAL

    ''' <summary>
    ''' Carte vitale.
    ''' </summary>
    Partial Public Class Carte

        ''' <summary>
        ''' Retourne la liste des cartes qui n'ont pas d'animaux.
        ''' </summary>
        ''' <returns>La liste des cartes qui n'ont pas d'animaux.</returns>
        Public Shared Function GetCartesNonAttribuees(Optional p_i_idAnimal As Integer = 0) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(Tables.VTL_CARTE + "." + VTL_CARTE.VTL_CARTE_ID)
                .AddSelect(VTL_CARTE.VTL_CARTE_NUMERO)
                .AddFrom(Tables.VTL_CARTE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CARTE, VTL_ANIMAL.VTL_ANIMAL_ID_CARTE, VTL_CARTE.VTL_CARTE_ID)
                .AddWhere(VTL_CARTE.VTL_CARTE_ID + " NOT IN (Select " + VTL_ANIMAL.VTL_ANIMAL_ID_CARTE + " from " + Tables.VTL_ANIMAL + ") OR " + VTL_ANIMAL.VTL_ANIMAL_ID + "=" + CStr(p_i_idAnimal))
            End With
            Return l_o_sql
        End Function

        'x         ''' <summary>
        'x         ''' Retourne la caret de l'animal.
        'x         ''' </summary>
        'x         ''' <param name="p_i_idAnimal">Contrôle IdAnimal.</param>
        'x         ''' <returns>La caret de l'animal.</returns>
        'x         Public Shared Function GetCarteAnimal(p_i_idAnimal As Integer) As Query
        'x             Dim l_o_sql As New Query
        'x 
        'x             With l_o_sql
        'x                 .Clear()
        'x                 .AddSelect(Tables.VTL_CARTE + "." + VTL_CARTE.VTL_CARTE_ID)
        'x                 .AddSelect(VTL_CARTE.VTL_CARTE_NUMERO)
        'x                 .AddFrom(Tables.VTL_CARTE)
        'x                 .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CARTE, VTL_ANIMAL.VTL_ANIMAL_ID_CARTE, VTL_CARTE.VTL_CARTE_ID)
        'x                 .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_ID, p_i_idAnimal)
        'x             End With
        'x             Return l_o_sql
        'x         End Function

    End Class

End Namespace
