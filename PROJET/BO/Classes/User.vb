Namespace VITAL

    ''' <summary>
    ''' User.
    ''' </summary>
    Partial Public Class User

#Region "get"

        ''' <summary>
        ''' Get connected User
        ''' </summary>
        ''' <param name="p_s_login"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetConnectedUser(p_s_login As String) As User
            Dim l_o_sql As New Query
            Dim l_o_row As DataRow
            Dim l_o_user As New User

            With l_o_sql
                .Clear()
                .AddFrom(Tables.VTL_USER)
                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_login, False)
                l_o_row = .GetFirstRow
                If l_o_row Is Nothing Then Return Nothing
                l_o_user.Load(l_o_row)
            End With
            Return l_o_user
        End Function

#End Region

        ''' <summary>
        ''' Retourne la liste des utilisateurs qui sont des propriétaires d'animaux.
        ''' </summary>
        ''' <returns>La liste des utilisateurs qui sont des propriétaires d'animaux.</returns>
        Public Shared Function GetProprios() As Query
            Dim l_o_sql As New Query

            With l_o_sql
                ' Requête principale
                .Clear()
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                'FROM
                .AddFrom(Tables.VTL_PROPRIETAIRE)
                'WHERE
                ' .AddWhereIs(VTL_USER.VTL_USER_ROLE, "Proprietaire")
            End With
            Return l_o_sql
        End Function

    

        ''' <summary>
        ''' Retourne l'id de l'utilisateur connecté.
        ''' </summary>
        ''' <param name="p_s_log">Loggin.</param>
        ''' <returns>L'id de l'utilisateur connecté.</returns>
        Public Shared Function GetIdUser(p_s_log As String) As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_USER.VTL_USER_ID)
                .AddFrom(Tables.VTL_USER)
                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_log)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

        ''' <summary>
        ''' Indique s'il existe un utilisateur avec cet loggin.
        ''' </summary>
        ''' <returns>Indique s'il existe un utilisateur avec cet loggin.</returns>
        Public Shared Function Exists(p_s_log As String) As Boolean
            Dim l_o_sql As New Query

            With l_o_sql
                ' Requête principale
                .Clear()
                .AddSelect(VTL_USER.VTL_USER_ID)
                .AddFrom(Tables.VTL_USER)
                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_log)

                If Not .GetFirstRow Is Nothing Then
                    Return True
                Else
                    Return False
                End If
            End With
        End Function

    End Class

End Namespace
