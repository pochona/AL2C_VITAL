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

                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_ID)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_MONTANT)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_DATE)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                .AddSelect(VTL_STATUT.VTL_STATUT_NAME)
                .AddFrom(Tables.VTL_REMBOURSMT)
                .AddFrom(Tables.VTL_CONSULTATION, DbJoin.Right, Tables.VTL_REMBOURSMT, VTL_CONSULTATION.VTL_CONSULTATION_ID, VTL_REMBOURSMT.VTL_REMBOURSMT_CONSULT)
                .AddFrom(Tables.VTL_STATUT, DbJoin.Right, Tables.VTL_REMBOURSMT, VTL_STATUT.VTL_STATUT_ID, VTL_REMBOURSMT.VTL_REMBOURSMT_STATUT)
            
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_L, p_i_animalId)
            End With
            Return l_o_sql
        End Function
        Public Shared Function GetRemboursementStatut(p_i_statutId As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_ID)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_DATE)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_CONTRAT)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_MONTANT)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_TXREMB)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                .AddSelect(MyDB.FctConcat(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, TextSQL(", "), VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM), "nom_prenom")

                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddFrom(Tables.VTL_REMBOURSMT)
                .AddFrom(Tables.VTL_CONTRAT, DbJoin.Right, Tables.VTL_REMBOURSMT, VTL_CONTRAT.VTL_CONTRAT_ID, VTL_REMBOURSMT.VTL_REMBOURSMT_CONTRAT)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_CONTRAT, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONTRAT, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL)
                If p_i_statutId <> 0 Then
                    .AddWhereIs(VTL_REMBOURSMT.VTL_REMBOURSMT_STATUT, p_i_statutId)
                End If
            End With
            Return l_o_sql
        End Function

        Public Shared Function GetRemboursementSelected(p_i_idSelected As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_ID)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_DATE)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_CONTRAT)
                .AddSelect(VTL_REMBOURSMT.VTL_REMBOURSMT_MONTANT)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_TXREMB)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddFrom(Tables.VTL_REMBOURSMT)
                .AddFrom(Tables.VTL_CONTRAT, DbJoin.Right, Tables.VTL_REMBOURSMT, VTL_CONTRAT.VTL_CONTRAT_ID, VTL_REMBOURSMT.VTL_REMBOURSMT_CONTRAT)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_CONTRAT, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONTRAT, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL)
                .AddWhereIs(VTL_REMBOURSMT.VTL_REMBOURSMT_ID, p_i_idSelected)

            End With
            Return l_o_sql
        End Function

    End Class

End Namespace
