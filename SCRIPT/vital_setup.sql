/*--------------------------------------------------------------------------*/
/* Application : VITL                                                       */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Lancement principal des scripts                            */
/* Historique  : Creation le 03/06/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

-- "=============================="
-- "Debut du script vital_setup.sql"
-- "=============================="


:on error exit
/* Tentative de creation de l'utilisateur */
:r "1_vital_user.sql"

/* Suppression des objets existants */
:on error ignore
:r "2_vital_drop.sql"

:on error exit

/* Definition des options de la base de donnees */
:r "3_vital_option.sql"

/* Creation des tables */
:r "4_vital_table.sql"


/* Creation des autres objets */
:r "5_vital_create.sql"

/* Attribution des roles */
:r "6_vital_grant.sql"



-- "=============================="
-- "Fin du script vital_setup.sql"
-- "=============================="

