Public Class Main

    ''' <summary>
    ''' Vous devez initialiser içi la liste des bases de données accessibles depuis
    ''' l'application
    ''' </summary>
    ''' <param name="p_o_list">Liste de bases de données</param>
    Public Shared Sub InitDatabases(ByVal p_o_list As Corail.Core.DataBaseList)
        p_o_list.Add(VITAL.Schema.SetDB(New Corail.Data.SqlServer.DataBase()))
    End Sub

End Class
