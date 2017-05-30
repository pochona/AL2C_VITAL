Namespace VITAL

    ''' <summary>
    ''' AnimalDocs.
    ''' </summary>
    Partial Public Class AnimalDocs

        ''' <summary>
        ''' Retourne les documents d'un animal.
        ''' </summary>
        ''' <param name="p_i_idanimal">Contrôle IdAnimal.</param>
        ''' <returns>Les documents d'un animal.</returns>
        Public Shared Function GetDocs(p_i_idanimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VITAL_ANIMALDOCS.ANIMALDOCS_ID)
                .AddSelect(VITAL_ANIMALDOCS.ANIMALDOCS_CHEMIN)
                .AddSelect(VITAL_ANIMALDOCS.ANIMALDOCS_NOM)
                .AddFrom(Tables.VITAL_ANIMALDOCS)
                .AddWhereIs(VITAL_ANIMALDOCS.ANIMALDOCS_ID_ANIMAL, p_i_idanimal)
            End With
            Return l_o_sql
        End Function
    End Class

End Namespace
