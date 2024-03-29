﻿Namespace VITAL

    ''' <summary>
    ''' Consultation vétérinaire d'un animal.
    ''' </summary>
    Partial Public Class Consultation

        Public Shared Function SearchedConsultClient(p_i_idAssur As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql

                .Clear()
                .AddOption(DbSelectOption.Distinct)
                ' DataKeyField
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_ID)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddSelect(Tables.VTL_PROPRIETAIRE + "." + VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                .AddFrom(Tables.VTL_CONSULTATION)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONSULTATION.VTL_CONSULTATION_L)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
                .AddFrom(Tables.VTL_CONTRAT, DbJoin.Right, Tables.VTL_ANIMAL, VTL_CONTRAT.VTL_CONTRAT_ID_ANIMAL, VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddWhereIs(VTL_CONTRAT.VTL_CONTRAT_ID_ASSURANCE, p_i_idAssur)
            End With
            Return l_o_sql
        End Function

        ''' <summary>
        ''' Retourne les consultations d'un client et d'un animal de la plus récente à la plus ancienne
        ''' </summary>
        ''' <returns>Les consultations d'un client et d'un animal de la plus récente à la plus ancienne.</returns>
        Public Shared Function GetConsultationsAnimal(p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOrder(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION, True)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_ID)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
                .AddSelect(VTL_VETERINAIRE.VTL_VETERINAIRE_NOM)
                .AddSelect(VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM)
                .AddSelect(MyDB.FctConcat(VTL_VETERINAIRE.VTL_VETERINAIRE_NOM, TextSQL(", "), VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM), "nom_prenom")
                .AddFrom(Tables.VTL_CONSULTATION)
                .AddFrom(Tables.VTL_VETERINAIRE, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_VETERINAIRE.VTL_VETERINAIRE_ID, VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONSULTATION.VTL_CONSULTATION_L)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_L, p_i_idAnimal)
            End With
            Return l_o_sql
        End Function

        ''' <summary>
        ''' Retourne les consultations d'un client et d'un animal de la plus récente à la plus ancienne
        ''' </summary>
        ''' <returns>Les consultations d'un client et d'un animal de la plus récente à la plus ancienne.</returns>
        Public Shared Function GetConsultationsClient(p_s_loginProp As String, p_i_idAnimal As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOrder(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION, True)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_ID)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
                .AddSelect(VTL_VETERINAIRE.VTL_VETERINAIRE_NOM)
                .AddSelect(VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM)
                .AddSelect(MyDB.FctConcat(VTL_VETERINAIRE.VTL_VETERINAIRE_NOM, TextSQL(", "), VTL_VETERINAIRE.VTL_VETERINAIRE_PRENOM), "nom_prenom")
                .AddFrom(Tables.VTL_CONSULTATION)
                .AddFrom(Tables.VTL_VETERINAIRE, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_VETERINAIRE.VTL_VETERINAIRE_ID, VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONSULTATION.VTL_CONSULTATION_L)
                .AddFrom(Tables.VTL_PROPRIETAIRE, DbJoin.Right, Tables.VTL_ANIMAL, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID, VTL_ANIMAL.VTL_ANIMAL_ID_PROP)
                .AddFrom(Tables.VTL_USER, DbJoin.Right, Tables.VTL_PROPRIETAIRE, VTL_USER.VTL_USER_ID, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID_USER)
                .AddWhereIs(VTL_USER.VTL_USER_LOGIN, p_s_loginProp)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_L, p_i_idAnimal)
            End With
            Return l_o_sql
        End Function

        ''' <summary>
        ''' Retourne la liste des consultations d'un vétérinaire.
        ''' </summary>
        ''' <param name="p_s_loginVeto"></param>
        ''' <returns>La liste des consultations d'un vétérinaire.</returns>
        Public Shared Function SearchedConsultVeto(p_s_loginVeto As Integer) As Query
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddOption(DbSelectOption.Distinct)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_MONTANT)
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_ID)
                .AddSelect(Tables.VTL_ANIMAL + "." + VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE)
                .AddFrom(Tables.VTL_CONSULTATION)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_CONSULTATION, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_CONSULTATION.VTL_CONSULTATION_L)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_ID_VETERINAIRE, p_s_loginVeto)
            End With
            Return l_o_sql
        End Function

        Public Function GetNomAnimal() As String
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NOM)
                .AddFrom(Tables.VTL_ANIMAL)
                '  .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_HISTO_POIDS, VTL_ANIMAL.VTL_ANIMAL_ID, VTL_HISTO_POIDS.VTL_HISTO_POIDS_ID_ANIMAL)
                .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_ID, Id_animal)

                If Not .GetFirstRow Is Nothing Then
                    Return NzStr((.GetFirstValue))
                Else
                    Return ""
                End If
            End With
        End Function

        Public Function GetDateConsultation() As Date
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_DT_CONSULTATION)
                .AddFrom(Tables.VTL_CONSULTATION)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_ID, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzDate((.GetFirstValue))
                Else
                    Return DbNullDate()

                End If
            End With
        End Function

        Public Function GetCommentaireConsultation() As String
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_CONSULTATION.VTL_CONSULTATION_COMMENTAIRE)
                .AddFrom(Tables.VTL_CONSULTATION)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_ID, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzStr((.GetFirstValue))
                Else
                    Return ""

                End If
            End With
        End Function

        Public Function GetPuceAnimal() As String
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_NUM_PUCE)
                .AddFrom(Tables.VTL_ANIMAL)
                .AddFrom(Tables.VTL_CONSULTATION, DbJoin.Right, Tables.VTL_ANIMAL, VTL_CONSULTATION.VTL_CONSULTATION_L, VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_ID, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzStr((.GetFirstValue))
                Else
                    Return ""

                End If
            End With
        End Function

        Public Function GetNomProprio() As String
            Dim l_o_sql As New Query
            With l_o_sql
                .Clear()
                .AddSelect(VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_NOM)
                .AddFrom(Tables.VTL_PROPRIETAIRE)
                .AddFrom(Tables.VTL_ANIMAL, DbJoin.Right, Tables.VTL_PROPRIETAIRE, VTL_ANIMAL.VTL_ANIMAL_ID_PROP, VTL_PROPRIETAIRE.VTL_PROPRIETAIRE_ID)
                .AddFrom(Tables.VTL_CONSULTATION, DbJoin.Right, Tables.VTL_ANIMAL, VTL_CONSULTATION.VTL_CONSULTATION_L, VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_ID, ID)

                If Not .GetFirstRow Is Nothing Then
                    Return NzStr((.GetFirstValue))
                Else
                    Return ""

                End If
            End With
        End Function

        Public Shared Function GetMontantTtl(p_i_idAnimal As Integer) As Double
            Dim l_o_sql As New Query
            With l_o_sql
                .Clear()

                .AddSelect("SUM(" + VTL_CONSULTATION.VTL_CONSULTATION_MONTANT + ")")
                .AddFrom(Tables.VTL_CONSULTATION)
                .AddWhereIs(VTL_CONSULTATION.VTL_CONSULTATION_L, p_i_idAnimal)
                .AddGroup(VTL_CONSULTATION.VTL_CONSULTATION_L)

                If Not .GetFirstRow Is Nothing Then
                    Return NzDbl((.GetFirstValue))
                Else
                    Return 0.0
                End If
            End With
        End Function

    End Class

End Namespace
