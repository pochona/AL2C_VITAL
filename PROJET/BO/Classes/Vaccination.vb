Namespace VITAL

    ''' <summary>
    ''' Vaccination d'un animal.
    ''' </summary>
	Partial Public Class Vaccination
        Public Shared Function GetVaccinsAnimal(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_VACCINATION.VTL_VACCINATION_ID)
                .AddSelect(VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)
                .AddSelect(VTL_VACCIN.VTL_VACCIN_LIBELLE)
                .AddSelect(VTL_VACCIN.VTL_VACCIN_TOP_RECOMMANDATION)
                .AddFrom(Tables.VTL_VACCINATION)
                .AddFrom(Tables.VTL_VACCIN, DbJoin.Right, Tables.VTL_VACCINATION, VTL_VACCIN.VTL_VACCIN_ID, VTL_VACCINATION.VTL_VACCINATION_ID_VACCIN)
                .AddWhereIs(VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL, p_i_idAnimal)
            End With

            Return l_o_sql
        End Function
    End Class

End Namespace
