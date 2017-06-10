Namespace VITAL

    ''' <summary>
    ''' Historique de la taille de l'animal.
    ''' </summary>
	Partial Public Class Histo_Taille

        Public Shared Function GetHistoTaille(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOrder(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO)
                .AddSelect(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_ID)
                .AddSelect(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_TAILLE)
                .AddSelect(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_DT_HISTO)
                .AddFrom(Tables.VTL_HISTO_TAILLE)
                .AddWhereIs(VTL_HISTO_TAILLE.VTL_HISTO_TAILLE_ID_ANIMAL, p_i_idAnimal)


                Return l_o_sql
            End With
        End Function

    End Class

End Namespace
