/*--------------------------------------------------------------------------*/
/* Application : VITAL                                                      */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Attribution des roles                                      */
/* Historique  : Creation le 16/05/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

PRINT "=============================="
PRINT "Debut du script vital_grant.sql"
PRINT "=============================="


PRINT "=============================="
PRINT "Roles sur les tables"
PRINT "=============================="
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_ADOPTER "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_ADOPTER TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_ANIMAL "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_ANIMAL TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_ASSURANCE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_ASSURANCE TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_CARTE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_CARTE TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_CONSULTATION "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_CONSULTATION TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_CONTRAT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_CONTRAT TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_HISTO_POIDS "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_HISTO_POIDS TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_HISTO_TAILLE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_HISTO_TAILLE TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_MEDICAMENT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_MEDICAMENT TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_POSITION "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_POSITION TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_PROPRIETAIRE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_PROPRIETAIRE TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_RACE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_RACE TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_TRAITEMENT_MEDICAMENT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_TRAITEMENT_MEDICAMENT TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_TRAITREMENT "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_TRAITREMENT TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_TYPE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_TYPE TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_USER "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_USER TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_VACCIN "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_VACCIN TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_VACCINATION "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_VACCINATION TO VITAL;
GO
PRINT "Ajout du role ROLE_VITAL_USER sur la table VTL_VETERINAIRE "
GRANT SELECT,INSERT,UPDATE,DELETE ON VTL_VETERINAIRE TO VITAL;
GO


PRINT "=============================="
PRINT "Fin du script vital_grant.sql"
PRINT "=============================="



