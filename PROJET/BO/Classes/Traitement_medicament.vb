Namespace VITAL

    ''' <summary>
    ''' Liste des médicaments compris dans un traitement.
    ''' </summary>
    Partial Public Class Traitement_medicament

        ''' <summary>
        ''' Retourne la liste des vétérianire : ID & NOM+PRENOM.
        ''' </summary>
        ''' <param name="p_i_idAnimal">Id de l'animal qui suit le traitemnt.</param>
        ''' <returns>La liste des vétérianire : ID & NOM+PRENOM.</returns>
        Public Shared Function GetTraitmtAnimal(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID)
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE)
                .AddSelect(VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR)
                .AddSelect(VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE)
                .AddSelect(VTL_MEDICAMENT.VTL_MEDICAMENT_DOSAGE)
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR)
                .AddFrom(Tables.VTL_TRAITEMENT_MEDICAMENT)
                .AddFrom(Tables.VTL_MEDICAMENT, DbJoin.Right, Tables.VTL_TRAITEMENT_MEDICAMENT, VTL_MEDICAMENT.VTL_MEDICAMENT_ID, VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT)
                .AddFrom(Tables.VTL_TRAITREMENT, DbJoin.Right, Tables.VTL_TRAITEMENT_MEDICAMENT, VTL_TRAITREMENT.VTL_TRAITREMENT_ID, VTL_TRAITEMENT_MEDICAMENT.VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT)
            End With
            Return l_o_sql
        End Function

    End Class

End Namespace
