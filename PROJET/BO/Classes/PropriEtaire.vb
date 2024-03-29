﻿Namespace VITAL

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
        ''' Indique s'il existe un proprietaire avec cet ID.
        ''' </summary>
        ''' <returns>Indique s'il existe un proprietaire avec cet ID.</returns>
        Public Shared Function ExistsV2(p_i_idProp As Integer) As Boolean
            Dim l_o_sql As New Query

            With l_o_sql
                ' Requête principale
                .Clear()
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                .AddFrom(Tables.VTL_PROPRIETAIRE)
                .AddWhereIs(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, p_i_idProp)

                If Not .GetFirstRow Is Nothing Then
                    Return True
                Else
                    Return False
                End If
            End With
        End Function

        ''' <summary>
        ''' Indique s'il existe un utilisateur avec cet ID.
        ''' </summary>
        ''' <returns>Indique s'il existe un utilisateur avec cet ID.</returns>
        Public Shared Function GetInfoPropUser() As Query
            Dim l_o_sql As New Query

            With l_o_sql
                ' Requête principale
                .Clear()
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ADR)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_CP)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_DATEFIN)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_MAIL)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_PRENOM)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_TEL)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_VILLE)

                .AddSelect(VTL_USER.VTL_USER_LOGIN)
                .AddSelect(VTL_USER.VTL_USER_MDP)
                .AddSelect(VTL_USER.VTL_USER_ROLE)

                .AddFrom(Tables.VTL_USER)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_USER, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER, VTL_USER.VTL_USER_ID)

                .AddWhereIs(VTL_USER.VTL_USER_ROLE, "Proprietaire")
                    Return l_o_sql
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
