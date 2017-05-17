/*--------------------------------------------------------------------------*/
/* Application : VITAL                                                      */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Tentative de creation de l'utilisateur                     */
/* Historique  : Creation le 16/05/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

PRINT "=============================="
PRINT "Debut du script vital_user.sql"
PRINT "=============================="


PRINT "Creation de la connexion 'VITAL'"
IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE name = N'VITAL')
CREATE LOGIN VITAL WITH PASSWORD = 'VITAL1234', CHECK_POLICY = OFF, DEFAULT_DATABASE=VITAL;
GO

PRINT "Utilisation du schema 'VITAL'"
USE VITAL;
GO

PRINT "Creation de l'utilisateur 'VITAL'"
IF NOT EXISTS (SELECT * FROM sys.sysusers WHERE name = N'VITAL' AND ISSQLUSER = 1)
CREATE USER VITAL FOR LOGIN VITAL;
GO


PRINT "=============================="
PRINT "Fin du script vital_user.sql"
PRINT "=============================="


