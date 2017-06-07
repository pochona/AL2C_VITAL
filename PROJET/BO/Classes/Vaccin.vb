Namespace VITAL

    ''' <summary>
    ''' Vaccin.
    ''' </summary>
	Partial Public Class Vaccin
        Public Shared Function GetAllVaccins() As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .AddSelect(VTL_VACCIN.VTL_VACCIN_LIBELLE)
                .AddFrom(Tables.VTL_VACCIN)
            End With
            Return l_o_sql
        End Function
    End Class

End Namespace
