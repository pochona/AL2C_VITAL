/*--------------------------------------------------------------------------*/
/* Application : VITL                                                       */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Definition des options de la base de donnees               */
/* Historique  : Creation le 25/05/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

-- "=============================="
-- "Debut du script vital_option.sql"
-- "=============================="


:on error exit

/* Authorisation des accès concurrents */
ALTER DATABASE VITL SET ALLOW_SNAPSHOT_ISOLATION ON;
GO
ALTER DATABASE VITL SET READ_COMMITTED_SNAPSHOT ON WITH NO_WAIT;
GO


-- "=============================="
-- "Fin du script vital_option.sql"
-- "=============================="

