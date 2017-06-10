Namespace VITAL

    ''' <summary>
    ''' Liste des médicaments compris dans un traitement.
    ''' </summary>
    Partial Public Class Traitement_medicament

        Public Shared Function GetTraitmtAnimal(p_i_idAnimal As Integer, p_i_idtraitement As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID)
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE)
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
                .AddSelect(VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE)
                .AddSelect(Tables.VTL_MEDICAMENT + "." + VTL_MEDICAMENT.VTL_MEDICAMENT_ID)
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                .AddFrom(Tables.VTL_TRAITEMENT_MEDICAMENT)
                .AddFrom(Tables.VTL_MEDICAMENT, DbJoin.Right, Tables.VTL_TRAITEMENT_MEDICAMENT, VTL_MEDICAMENT.VTL_MEDICAMENT_ID, VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT)
                .AddFrom(Tables.VTL_TRAITREMENT, DbJoin.Right, Tables.VTL_TRAITEMENT_MEDICAMENT, VTL_TRAITREMENT.VTL_TRAITREMENT_ID, VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT)
                .AddWhereIs(VTL_TRAITREMENT.VTL_TRAITREMENT_ID_ANIMAL, p_i_idAnimal)
                .AddWhereIs(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT, p_i_idtraitement)
            End With
            Return l_o_sql
        End Function

        Public Shared Function GetTraitmtAnimalProprio(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID)
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE)
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
                .AddSelect(VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE)
                .AddSelect(Tables.VTL_MEDICAMENT + "." + VTL_MEDICAMENT.VTL_MEDICAMENT_ID)
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR)
                .AddFrom(Tables.VTL_TRAITEMENT_MEDICAMENT)
                .AddFrom(Tables.VTL_MEDICAMENT, DbJoin.Right, Tables.VTL_TRAITEMENT_MEDICAMENT, VTL_MEDICAMENT.VTL_MEDICAMENT_ID, VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT)
                .AddFrom(Tables.VTL_TRAITREMENT, DbJoin.Right, Tables.VTL_TRAITEMENT_MEDICAMENT, VTL_TRAITREMENT.VTL_TRAITREMENT_ID, VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT)
                .AddWhereIs(VTL_TRAITREMENT.VTL_TRAITREMENT_ID_ANIMAL, p_i_idAnimal)
            End With
            Return l_o_sql
        End Function

    End Class

End Namespace
