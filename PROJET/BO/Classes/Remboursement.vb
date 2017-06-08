Namespace VITAL

    ''' <summary>
    ''' Remboursement.
    ''' </summary>
	Partial Public Class Remboursement


        Public Shared Function GetRemboursementAnimal(p_i_animalId As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                '  .AddSelect(Tables.VTL_ANIMAL + "." + VTL_ANIMAL.VTL_ANIMAL_ID)


                .AddFrom(Tables.VTL_REMBOURSMT)
                .AddFrom(Tables.VTL_CONSULTATION, DbJoin.Right, Tables.VTL_REMBOURSMT, VTL_CONSULTATION.VTL_CONSULTATION_ID, VTL_REMBOURSMT.VTL_REMBOURSMT_CONSULT)

                '.AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_logginProprio)
            End With
            Return l_o_sql
        End Function
    End Class

End Namespace
