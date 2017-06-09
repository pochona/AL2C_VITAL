Namespace VITAL

    ''' <summary>
    ''' Traitrement.
    ''' </summary>
    Partial Public Class Traitrement

        Public Shared Function GetTraitmtAnimal(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_DT_DEBUT)
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_DUREE_JOUR)
                .AddSelect(VTL_TRAITREMENT.VTL_TRAITREMENT_ID)
                .AddFrom(Tables.VTL_TRAITREMENT)
                .AddWhereIs(VTL_TRAITREMENT.VTL_TRAITREMENT_ID_ANIMAL, p_i_idAnimal)
            End With
            Return l_o_sql
        End Function
    End Class
End Namespace
