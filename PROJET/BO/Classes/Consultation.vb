Namespace VITAL

    ''' <summary>
    ''' Consultation vétérinaire d'un animal.
    ''' </summary>
    Partial Public Class Consultation


        Public Shared Function SearchedConsultClient() As Query
            Dim l_o_sql As New Query

            With l_o_sql

                .Clear()
                .AddOption(DbSelectOption.Distinct)
                ' DataKeyField
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_ID)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(Tables.VTL_PROPRIETAIRE + "." + VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                .AddFrom(Tables.VTL_CONSULTATION)
                'jointure
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_CONSULTATION.VTL_CONSULTATION_ID_PROPRIETAIRE)
            End With
            Return l_o_sql
        End Function

    End Class

End Namespace
