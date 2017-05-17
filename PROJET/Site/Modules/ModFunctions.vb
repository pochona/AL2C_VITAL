Module ModFunctions

#Region "ComboBox"

    ''' <summary>
    ''' Remplir une liste déroulante à partir d'un DataSet
    ''' </summary>
    ''' <param name="p_o_cbo">Combobox à remplir</param>
    ''' <param name="p_o_ds">Dataset contenant les données</param>
    ''' <param name="p_s_valueField">Nom du champ contenant la valeur à récupérer</param>
    ''' <param name="p_s_TextField">Nom du champ contenant le texte à afficher</param>
    ''' <param name="p_s_SpecialLine">Libellé de la ligne spéciale</param>
    ''' <param name="p_s_colSiConcat">Nom du champ en cas de concaténation</param>
    ''' <param name="p_s_specialValue">Valeur de la ligne spéciale</param>
    ''' <param name="p_s_dataEnabledField">Nom du champ pour la visibilité des valeurs</param>
    ''' <param name="p_s_dataEnabledValue">Valeur pour laquelle une ligne de la combobox sera active</param>
    ''' <returns></returns>
    Public Function BindCbo(ByRef p_o_cbo As CwComboBox, ByVal p_o_ds As DataSet, p_s_valueField As String, p_s_TextField As String, _
                            Optional p_s_specialLine As String = "", Optional p_s_colSiConcat As String = "", Optional p_s_specialValue As String = "0", _
                            Optional p_s_dataEnabledField As String = "", Optional p_s_dataEnabledValue As String = "") As Boolean
        BindCbo = False
        ' Champ pour la valeur retournée
        p_o_cbo.DataValueField = p_s_valueField
        ' Champ pour la valeur affichée
        If p_s_colSiConcat = "" Then
            p_o_cbo.DataTextField = p_s_TextField
        Else
            p_o_cbo.DataTextField = p_s_colSiConcat
        End If
        ' Source
        p_o_cbo.DataSource = p_o_ds
        ' Champ pour les valeurs à ne pas afficher
        If p_s_dataEnabledField <> "" And p_s_dataEnabledValue <> "" Then
            p_o_cbo.DataEnabledField = p_s_dataEnabledField
            p_o_cbo.DataEnabledValue = p_s_dataEnabledValue
        End If
        p_o_cbo.DataBind()
        ' Special line
        If p_s_specialLine <> "" Then
            p_o_cbo.AddSpecialLine(p_s_specialLine, p_s_specialValue)
            p_o_cbo.SelectedValue = p_s_specialValue
        End If
        BindCbo = True
    End Function

#End Region

End Module
