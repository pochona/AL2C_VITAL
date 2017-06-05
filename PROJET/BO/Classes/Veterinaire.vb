Namespace VITAL

    ''' <summary>
    ''' Veterinaire.
    ''' </summary>
    Partial Public Class Veterinaire

        ''' <summary>
        ''' Retourne l'id vétérianire correspondant à l'utilisateur connecté.
        ''' </summary>
        ''' <param name="p_s_log">Loggin de l'utilisateur connecté.</param>
        ''' <returns>L'id vétérianire correspondant à l'utilisateur connecté.</returns>
        Public Shared Function GetIdVetoConnectedUser(p_s_log As String) As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_VETERINAIRE.VTL_VETERINAIRE_ID)
                .AddFrom(Tables.VTL_VETERINAIRE)
                .AddFrom(Tables.VTL_USER, DbJoin.Right, Tables.VTL_VETERINAIRE, VTL_USER.VTL_USER_ID, VTL_VETERINAIRE.VTL_VETERINAIRE_ID_USER)
                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_log)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

        ''' <summary>
        ''' Retourne la liste des vétérianire : ID & NOM+PRENOM.
        ''' </summary>
        ''' <returns>La liste des vétérianire : ID & NOM+PRENOM.</returns>
        Public Shared Function GetIdNomPrenomVetos() As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_VETERINAIRE.VTL_VETERINAIRE_ID)
                .AddSelect(MyDB.FctConcat(VTL_VETERINAIRE.VTL_VETERINAIRE_NOM, TextSQL(", "), VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM), "nom_prenom")
                .AddFrom(Tables.VTL_VETERINAIRE)
            End With
            Return l_o_sql
        End Function


        ''' <summary>
        ''' Retourne la derniere conusltationt du veterinaire.
        ''' </summary>
        ''' <returns>La derniere conusltationt du veterinaire.</returns>
        Public Function GetLastConsult() As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOrder(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION, True)
                ' .AddSelect(Tables.VTL_CONSULTATION + "." + VTL_CONSULTATION.VTL_CONSULTATION_ID)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_ID)
                .AddFrom(Tables.VTL_CONSULTATION)
                '  .AddFrom(Tables.VTL_CONSULTATION, DbJoin.Right, Tables.VTL_VETERINAIRE, VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE, VTL_VETERINAIRE.VTL_VETERINAIRE_ID)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

    End Class

End Namespace

