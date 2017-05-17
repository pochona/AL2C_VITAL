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

    End Class

End Namespace
