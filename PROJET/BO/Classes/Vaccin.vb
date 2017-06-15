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

        'x         Public Shared Function GetRappels(p_i_idANimal As Integer) As Query
        'x             Dim l_o_sql As New Query
        'x 
        'x             With l_o_sql
        'x                 .AddSelect(VTL_VACCIN.VTL_VACCIN_LIBELLE)
        'x                 .AddFrom(Tables.VTL_VACCIN)
        'x                 .AddFrom(Tables.VTL_VACCINATION, DbJoin.Right, Tables.VTL_VACCIN, VTL_VACCINATION.VTL_VACCINATION_ID_VACCIN, VTL_VACCIN.VTL_VACCIN_ID)
        'x                 .AddWhere(VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL, p_i_idANimal)
        'x                 .AddWhere(VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)
        'x                 .AddWhereIs(VTL_VACCIN.VTL_VACCIN_TOP_PERIODIQUE, "True")
        'x                 .AddWhere(VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)
        'x 
        'x 
        'x                 .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_FIN + ">='" + Now.Year.ToString + "/" + Now.Month.ToString + "/" + Now.Day.ToString + "'")
        'x                 .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT + "<='" + CStr(p_d_dtfin.Date.Year) + "/" + CStr(p_d_dtfin.Date.Month) + "/" + CStr(p_d_dtfin.Date.Day) + "'")
        'x 
        'x             End With
        'x             Return l_o_sql
        'x         End Function

        Public Shared Function GetVaccinations(p_s_logginProprio As String) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .AddOrder(VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL)
                .AddSelect(VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)
                .AddSelect(VTL_VACCIN.VTL_VACCIN_LIBELLE)
                .AddSelect(VTL_VACCIN.VTL_VACCIN_PERIODE_MOIS)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)

                .AddFrom(Tables.VTL_VACCINATION)
                .AddFrom(Tables.VTL_VACCIN, DbJoin.Right, Tables.VTL_VACCINATION, VTL_VACCIN.VTL_VACCIN_ID, VTL_VACCINATION.VTL_VACCINATION_ID_VACCIN)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_VACCINATION, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
                .AddFrom(Tables.VTL_USER, DbJoin.Right, Tables.VTL_PROPRIETAIRE, VTL_USER.VTL_USER_ID, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER)


                'x V old .AddWhereIs(VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL, p_i_idANimal)
                .AddWhereIs(VTL_VACCIN.VTL_VACCIN_TOP_PERIODIQUE, "True")
                'x V new  .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_ID_PROP, p_i_idProp)

                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_logginProprio)
                .AddGroup(VTL_VACCIN.VTL_VACCIN_ID)
                'x                 .AddSelect(VTL_VACCIN.)
                'x                 .AddFrom(Tables.VTL_VACCIN)
                'x                 .AddFrom(Tables.VTL_VACCINATION, DbJoin.Right, Tables.VTL_VACCIN, VTL_VACCINATION.VTL_VACCINATION_ID_VACCIN, VTL_VACCIN.VTL_VACCIN_ID)
                'x                 .AddWhere(VTL_VACCINATION.VTL_VACCINATION_ID_ANIMAL, p_i_idANimal)
                'x                 .AddWhere(VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)
                'x                 .AddWhereIs(VTL_VACCIN.VTL_VACCIN_TOP_PERIODIQUE, "True")
                'x                 .AddWhere(VTL_VACCINATION.VTL_VACCINATION_DT_VACCIN)
                'x 

                'x .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_FIN + ">='" + Now.Year.ToString + "/" + Now.Month.ToString + "/" + Now.Day.ToString + "'")
                'x .AddWhere(VTL_CONTRAT.VTL_CONTRAT_DT_DEBUT + "<='" + CStr(p_d_dtfin.Date.Year) + "/" + CStr(p_d_dtfin.Date.Month) + "/" + CStr(p_d_dtfin.Date.Day) + "'")

            End With
            Return l_o_sql
        End Function

    End Class

End Namespace
