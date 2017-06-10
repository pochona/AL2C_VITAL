Namespace VITAL

    ''' <summary>
    ''' Medicament.
    ''' </summary>
    Partial Public Class Medicament

        ''' <summary>
        ''' Retourne les médicaments pouvant etre administrés directement par des propriétaires.
        ''' </summary>
        ''' <returns>Les médicaments pouvant etre administrés directement par des propriétaires.</returns>
        Public Shared Function GetMedicamentByProprio() As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_MEDICAMENT.VTL_MEDICAMENT_ID)
                .AddSelect(VTL_MEDICAMENT.VTL_MEDICAMENT_LIBELLE)
                .AddFrom(Tables.VTL_MEDICAMENT)
                .AddWhereIs(VTL_MEDICAMENT.VTL_MEDICAMENT_PROPRIOCANDO, True)
            End With
            Return l_o_sql
        End Function

    End Class

End Namespace
