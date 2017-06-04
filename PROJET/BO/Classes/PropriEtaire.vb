Namespace VITAL

    ''' <summary>
    ''' Propriétaire.
    ''' </summary>
	Partial Public Class PropriEtaire
        ''' <summary>
        ''' Indique s'il existe un utilisateur avec cet ID.
        ''' </summary>
        ''' <param name="p_i_idUser">Id utilisateur.</param>
        ''' <returns>Indique s'il existe un utilisateur avec cet ID.</returns>
        Public Shared Function Exists(p_i_idUser As Integer) As Boolean
            Dim l_o_sql As New Query

            With l_o_sql
                ' Requête principale
                .Clear()
                .AddSelect(VTL_USER.VTL_USER_ID)
                .AddFrom(Tables.VTL_USER)
                .AddWhereIs(VTL_USER.VTL_USER_ID, p_i_idUser)

                If Not .GetFirstRow Is Nothing Then
                    Return True
                Else
                    Return False
                End If
            End With
        End Function
    End Class

End Namespace
