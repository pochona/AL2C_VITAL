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
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_NUM_CONTRAT)
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_TXREMB)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                .AddSelect(MyDB.FctConcat(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM, TextSQL(", "), VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM), "nom_prenom")
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_MAIL)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_VILLE)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddSelect(VTL_TYPE.VTL_TYPE_LIBELLE)
                .AddSelect(VTL_RACE.VTL_RACE_NOM)
                .AddFrom(Tables.VTL_CONTRAT)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_CONTRAT, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_CONTRAT.VTL_CONTRAT_ID_PROPRIETAIRE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONTRAT, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL)
                .AddFrom(Tables.VTL_TYPE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_TYPE.VTL_TYPE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_TYPE)
                .AddFrom(Tables.VTL_RACE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_RACE.VTL_RACE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_RACE)
            End With
            Return l_o_sql
        End Function

        ''' <summary>
        ''' Indique s'il existe un utilisateur avec cet loggin.
        ''' </summary>
        ''' <returns>Indique s'il existe un utilisateur avec cet loggin.</returns>
        Public Shared Function Exists(p_i_idAnimal As Integer, p_d_dbdebut As Date, p_d_dtfin As Date) As Boolean
            Dim l_o_sql As New Query

            With l_o_sql
                ' Requête principale
                .Clear()
                .AddSelect(VTL_CONTRAT.VTL_CONTRAT_ID)
                .AddFrom(Tables.VTL_CONTRAT)
                .AddWhereIs(VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL, p_i_idAnimal)
                'x .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_FIN + ">='" + CStr(p_d_dtfin.Date) + "'")
                'x .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT + "<='" + CStr(p_d_dtfin.Date) + "'")
                .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_FIN + ">='" + CStr(p_d_dtfin.Date.Year) + "/" + CStr(p_d_dtfin.Date.Month) + "/" + CStr(p_d_dtfin.Date.Day) + "'")
                .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT + "<='" + CStr(p_d_dtfin.Date.Year) + "/" + CStr(p_d_dtfin.Date.Month) + "/" + CStr(p_d_dtfin.Date.Day) + "'")

                If .GetFirstRow Is Nothing Then
                    Return False
                Else
                    Return True
                End If
            End With
        End Function

    End Class

End Namespace
