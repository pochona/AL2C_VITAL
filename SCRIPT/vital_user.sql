/*--------------------------------------------------------------------------*/
/* Application : VITL                                                       */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Tentative de creation de l'utilisateur                     */
/* Historique  : Creation le 03/05/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

-- "=============================="
-- "Debut du script vital_user.sql"
-- "=============================="


-- "Creation de la connexion 'VITL'"
IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE name = N'VITL')
CREATE LOGIN VITL WITH PASSWORD = 'VITL1234', CHECK_POLICY = OFF, DEFAULT_DATABASE=VITL;
GO

-- "Utilisation du schema 'VITL'"
USE VITL;
GO

-- "Creation de l'utilisateur 'VITL'"
IF NOT EXISTS (SELECT * FROM sys.sysusers WHERE name = N'VITL' AND ISSQLUSER = 1)
CREATE USER VITL FOR LOGIN VITL;
GO


-- "=============================="
-- "Fin du script vital_user.sql"
-- "=============================="


