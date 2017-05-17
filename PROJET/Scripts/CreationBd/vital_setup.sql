/*--------------------------------------------------------------------------*/
/* Application : VITAL                                                      */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Lancement principal des scripts                            */
/* Historique  : Creation le 16/05/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

PRINT "=============================="
PRINT "Debut du script vital_setup.sql"
PRINT "=============================="


:on error exit
/* Tentative de creation de l'utilisateur */
:r "VITAL_user.sql"

/* Suppression des objets existants */
:on error ignore
:r "VITAL_drop.sql"

:on error exit

/* Creation des tables */
:r "VITAL_table.sql"

/* Creation des autres objets */
:r "VITAL_create.sql"

/* Attribution des roles */
:r "VITAL_grant.sql"


/* Authorisation des accès concurrents */
ALTER DATABASE VITAL SET ALLOW_SNAPSHOT_ISOLATION ON;
GO
ALTER DATABASE VITAL SET READ_COMMITTED_SNAPSHOT ON;
GO


PRINT "=============================="
PRINT "Fin du script vital_setup.sql"
PRINT "=============================="

