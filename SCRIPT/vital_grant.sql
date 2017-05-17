/*--------------------------------------------------------------------------*/
/* Application : VITL                                                       */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Attribution des roles                                      */
/* Historique  : Creation le 03/05/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

-- "=============================="
-- "Debut du script vital_grant.sql"
-- "=============================="


-- "=============================="
-- "Roles sur les tables"
-- "=============================="
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_ADOPTER "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_ADOPTER TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_ANIMAL "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_ANIMAL TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_ASSURANCE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_ASSURANCE TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_CARTE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_CARTE TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_CONSULTATION "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_CONSULTATION TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_CONTRAT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_CONTRAT TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_HISTO_POIDS "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_HISTO_POIDS TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_HISTO_TAILLE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_HISTO_TAILLE TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_MEDICAMENT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_MEDICAMENT TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_POSITION "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_POSITION TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_PROPRIETAIRE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_PROPRIETAIRE TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_RACE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_RACE TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_TRAITEMENT_MEDICAMENT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_TRAITEMENT_MEDICAMENT TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_TRAITREMENT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_TRAITREMENT TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_TYPE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_TYPE TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_VACCIN "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_VACCIN TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_VACCINATION "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_VACCINATION TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table VTL_VETERINAIRE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_VETERINAIRE TO VITL;
GO
-- "Ajout du role ROLE_VITAL_USER sur la table ~temp636291757526019432 "
GRANT SELECT,INSERT,UPDATE,DELETE ON ~temp636291757526019432 TO VITL;
GO


-- "=============================="
-- "Fin du script vital_grant.sql"
-- "=============================="



