Namespace VITAL

    ''' <summary>
    ''' Animal.
    ''' </summary>
    Partial Public Class Animal

        ''' <summary>
        ''' Retourne l'id de l'animal - Accessible depuis 1 objet de la classe : p_o_animal.GetThisAnimal2().
        ''' </summary>
        ''' <returns>L'id de l'animal - Accessible depuis 1 objet de la classe : p_o_animal.GetThisAnimal2().
        ''' </returns>
        Public Function GetThisAnimal() As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddFrom(Tables.VTL_ANIMAL)
                .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_NOM, Nom)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

        ''' <summary>
        ''' Retourne l'id de l'animal - Accessible sans objet de la classe : Animal.GetThisAnimal2("Rex").
        ''' </summary>
        ''' <param name="p_s_name">Nom de l'animal.</param>
        ''' <returns>L'id de l'animal - Accessible sans objet de la classe : Animal.GetThisAnimal2("Rex").
        ''' </returns>
        Public Shared Function GetThisAnimal2(p_s_name As String) As Integer
            Dim l_o_sql As New Query

            With l_o_sql
                .Clear()
                .AddSelect(VTL_ANIMAL.VTL_ANIMAL_ID)
                .AddFrom(Tables.VTL_ANIMAL)
                .AddWhereIs(VTL_ANIMAL.VTL_ANIMAL_NOM, p_s_name)

                If Not .GetFirstRow Is Nothing Then
                    Return NzInt((.GetFirstValue))
                Else
                    Return 0
                End If
            End With
        End Function

    End Class

End Namespace
