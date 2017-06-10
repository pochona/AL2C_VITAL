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
   
        ''' <summary>
        ''' Retourne l'id du proprio connecté.
        ''' </summary>
        ''' <param name="p_i_idUser">ID User.</param>
        ''' <returns>L'id de l'utilisateur connecté.</returns>
        Public Shared Function GetIdProprioByIdUser(p_i_idUser As Integer) As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                .AddFrom(Tables.VTL_PROPRIETAIRE)
                .AddWhereIs(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER, p_i_idUser)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function
    End Class

End Namespace
