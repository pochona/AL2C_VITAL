Namespace VITAL

    ''' <summary>
    ''' ConseilDietetique.
    ''' </summary>
    Partial Public Class ConseilDietetique

        ''' <summary>
        ''' Retourne les consultations d'un client et d'un animal de la plus récente à la plus ancienne
        ''' </summary>
        ''' <returns>Les consultations d'un client et d'un animal de la plus récente à la plus ancienne.</returns>
        Public Shared Function GetConseilsAnimal(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOrder(VTL_CNSLDIET.CNSLDIET_DATE, True)
                .AddSelect(VTL_CNSLDIET.CNSLDIET_ID)
                .AddSelect(VTL_CNSLDIET.CNSLDIET_DATE)
                .AddSelect(VTL_CNSLDIET.CNSLDIET_CONTENU)
                .AddFrom(Tables.VTL_CNSLDIET)
                '.AddFrom(Tables.VTL_VETERINAIRE, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_VETERINAIRE.VTL_VETERINAIRE_ID, VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE)
                .AddWhereIs(VTL_CNSLDIET.CNSLDIET_ID_ANIMAL, p_i_idAnimal)
            End With
            Return l_o_sql
        End Function

    End Class

End Namespace
