Namespace VITAL

    ''' <summary>
    ''' Historique du poids de l'animal.
    ''' </summary>
	Partial Public Class Histo_Poids

        Public Shared Function GetHistoPoids(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOrder(VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO)
                .AddSelect(VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID)
                .AddSelect(VTL_HISTO_POIDS.VTL_HISTO_POIDS_POIDS)
                .AddSelect(VTL_HISTO_POIDS.VTL_HISTO_POIDS_DT_HISTO)
                .AddFrom(Tables.VTL_HISTO_POIDS)
                .AddWhereIs(VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID_ANIMAL, p_i_idAnimal)
                Return l_o_sql
            End With
        End Function

    End Class

End Namespace
