Namespace VITAL

    ''' <summary>
    ''' Contrat d'assurance.
    ''' </summary>
    Partial Public Class Contrat
        Public Shared Function SearchedConsultContrat() As Query
            Dim l_o_sql As New Query

            With l_o_sql

                .Clear()
                .AddOption(DbSelectOption.Distinct)
                ' DataKeyField
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_ID)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_DT_FIN)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddFrom(Tables.VTL_CONTRAT)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_CONTRAT, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE)

            End With
            Return l_o_sql
        End Function

        ''' <summary>
        ''' Retourne les contrats clients correspondant au nom saisi
        ''' </summary>
        ''' <returns>Les contrats clients correspondant au nom saisi.</returns>
        Public Shared Function GetContratsClient(p_s_loginProp As String, p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOrder(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT, True)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_ID)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_DT_FIN)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)

                .AddFrom(Tables.VTL_CONTRAT)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_CONTRAT, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE)

            End With
            Return l_o_sql
        End Function

        ''' <summary>
        ''' Récupére les données à afficher pour les contrats
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetContratData() As Query
            Dim l_o_sql As New Query

            With l_o_sql

                .Clear()
                .AddOption(DbSelectOption.Distinct)
                ' DataKeyField
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_ID)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_DT_FIN)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_TXREMB)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddSelect(VTL_TYPE.VTL_TYPE_LIBELLE)
                .AddSelect(VTL_RACE.VTL_RACE_NOM)
                .AddFrom(Tables.VTL_CONTRAT)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_CONTRAT, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONTRAT, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL)
                .AddFrom(Tables.VTL_TYPE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_TYPE.VTL_TYPE_ID, VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddFrom(Tables.VTL_RACE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_RACE.VTL_RACE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_RACE)
            End With
            Return l_o_sql
        End Function

    End Class


End Namespace
