#Region "Enumérations"

''' <summary>
''' Mode d'accès aux pages
''' </summary>
Public Enum EN_ModeAcces
    ''' <summary>
    ''' Accès en création
    ''' </summary>
    Creation
    ''' <summary>
    ''' Accès en modification
    ''' </summary>
    Modification
End Enum

''' <summary>
''' Mode d'accès aux pages
''' </summary>
Public Enum EN_Statut
    ''' <summary>
    ''' Ne pas utiliser
    ''' </summary>
    StatutInexistant
    ''' <summary>
    ''' Accès en création de consultation
    ''' </summary>
    EnCours
    ''' <summary>
    ''' Apres paiement
    ''' </summary>
    Payee
End Enum

#End Region

#Region "Constantes"

Module ModConst

    ''' Style des éléments inactifs dans les grilles
    Public Const C_S_EXEMPLE As String = "background-color:#CCCCCC;"

End Module

#End Region

