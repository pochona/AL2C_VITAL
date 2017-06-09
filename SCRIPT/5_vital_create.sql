/*--------------------------------------------------------------------------*/
/* Application : VITL                                                       */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Creation des objets                                        */
/* Historique  : Creation le 09/06/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

-- "=============================="
-- "Debut du script vital_create.sql"
-- "=============================="


-- "=============================="
-- "Creation des clefs primaires"
-- "=============================="

-- "Creation de la clef primaire de la table VITAL_ANIMALDOCS"
ALTER TABLE VITAL_ANIMALDOCS
ADD CONSTRAINT VITAL_ANIMALDOCS_PK PRIMARY KEY (ANIMALDOCS_ID)
GO

-- "Creation de la clef primaire de la table VTL_ADOPTER"
ALTER TABLE VTL_ADOPTER
ADD CONSTRAINT VTL_ADOPTER_PK PRIMARY KEY (VTL_ADOPTER_ID)
GO

-- "Creation de la clef primaire de la table VTL_ANIMAL"
ALTER TABLE VTL_ANIMAL
ADD CONSTRAINT VTL_ANIMAL_PK PRIMARY KEY (VTL_ANIMAL_ID)
GO

-- "Creation de la clef primaire de la table VTL_ASSURANCE"
ALTER TABLE VTL_ASSURANCE
ADD CONSTRAINT VTL_ASSURANCE_PK PRIMARY KEY (VTL_ASSURANCE_ID)
GO

-- "Creation de la clef primaire de la table VTL_ATTACHEMT"
ALTER TABLE VTL_ATTACHEMT
ADD CONSTRAINT VTL_ATTACHEMT_PK PRIMARY KEY (VTL_ATTACHEMT_ID)
GO

-- "Creation de la clef primaire de la table VTL_CARTE"
ALTER TABLE VTL_CARTE
ADD CONSTRAINT VTL_CARTE_PK PRIMARY KEY (VTL_CARTE_ID)
GO

-- "Creation de la clef primaire de la table VTL_CNSLDIET"
ALTER TABLE VTL_CNSLDIET
ADD CONSTRAINT VTL_CNSLDIET_PK PRIMARY KEY (CNSLDIET_ID)
GO

-- "Creation de la clef primaire de la table VTL_CONSULTATION"
ALTER TABLE VTL_CONSULTATION
ADD CONSTRAINT VTL_CONSULTATION_PK PRIMARY KEY (VTL_CONSULTATION_ID)
GO

-- "Creation de la clef primaire de la table VTL_CONTRAT"
ALTER TABLE VTL_CONTRAT
ADD CONSTRAINT VTL_CONTRAT_PK PRIMARY KEY (VTL_CONTRAT_ID)
GO

-- "Creation de la clef primaire de la table VTL_HISTO_POIDS"
ALTER TABLE VTL_HISTO_POIDS
ADD CONSTRAINT VTL_HISTO_POIDS_PK PRIMARY KEY (VTL_HISTO_POIDS_ID)
GO

-- "Creation de la clef primaire de la table VTL_HISTO_TAILLE"
ALTER TABLE VTL_HISTO_TAILLE
ADD CONSTRAINT VTL_HISTO_TAILLE_PK PRIMARY KEY (VTL_HISTO_TAILLE_ID)
GO

-- "Creation de la clef primaire de la table VTL_MEDICAMENT"
ALTER TABLE VTL_MEDICAMENT
ADD CONSTRAINT VTL_MEDICAMENT_PK PRIMARY KEY (VTL_MEDICAMENT_ID)
GO

-- "Creation de la clef primaire de la table VTL_POSITION"
ALTER TABLE VTL_POSITION
ADD CONSTRAINT VTL_POSITION_PK PRIMARY KEY (VTL_POSITION_ID)
GO

-- "Creation de la clef primaire de la table VTL_PROPRIETAIRE"
ALTER TABLE VTL_PROPRIETAIRE
ADD CONSTRAINT VTL_PROPRIETAIRE_PK PRIMARY KEY (VTL_PROPRIETAIRE_ID)
GO

-- "Creation de la clef primaire de la table VTL_RACE"
ALTER TABLE VTL_RACE
ADD CONSTRAINT VTL_RACE_PK PRIMARY KEY (VTL_RACE_ID)
GO

-- "Creation de la clef primaire de la table VTL_REMBOURSMT"
ALTER TABLE VTL_REMBOURSMT
ADD CONSTRAINT VTL_REMBOURSMT_PK PRIMARY KEY (VTL_REMBOURSMT_ID)
GO

-- "Creation de la clef primaire de la table VTL_STATUT"
ALTER TABLE VTL_STATUT
ADD CONSTRAINT VTL_STATUT_PK PRIMARY KEY (VTL_STATUT_ID)
GO

-- "Creation de la clef primaire de la table VTL_TRAITEMENT_MEDICAMENT"
ALTER TABLE VTL_TRAITEMENT_MEDICAMENT
ADD CONSTRAINT VTL_TRAITEMENT_MEDICAMENT_PK PRIMARY KEY (VTL_TRAITEMENT_MEDICAMENT_ID)
GO

-- "Creation de la clef primaire de la table VTL_TRAITREMENT"
ALTER TABLE VTL_TRAITREMENT
ADD CONSTRAINT VTL_TRAITREMENT_PK PRIMARY KEY (VTL_TRAITREMENT_ID)
GO

-- "Creation de la clef primaire de la table VTL_TYPE"
ALTER TABLE VTL_TYPE
ADD CONSTRAINT VTL_TYPE_PK PRIMARY KEY (VTL_TYPE_ID)
GO

-- "Creation de la clef primaire de la table VTL_USER"
ALTER TABLE VTL_USER
ADD CONSTRAINT VTL_USER_PK PRIMARY KEY (VTL_USER_ID)
GO

-- "Creation de la clef primaire de la table VTL_VACCIN"
ALTER TABLE VTL_VACCIN
ADD CONSTRAINT VTL_VACCIN_PK PRIMARY KEY (VTL_VACCIN_ID)
GO

-- "Creation de la clef primaire de la table VTL_VACCINATION"
ALTER TABLE VTL_VACCINATION
ADD CONSTRAINT VTL_VACCINATION_PK PRIMARY KEY (VTL_VACCINATION_ID)
GO

-- "Creation de la clef primaire de la table VTL_VETERINAIRE"
ALTER TABLE VTL_VETERINAIRE
ADD CONSTRAINT VTL_VETERINAIRE_PK PRIMARY KEY (VTL_VETERINAIRE_ID)
GO

-- "=============================="
-- "Creation des clefs etrangeres"
-- "=============================="

-- "Creation de la clef etrangere de la table VITAL_ANIMALDOCS vers la table VTL_ANIMAL"
ALTER TABLE VITAL_ANIMALDOCS
ADD CONSTRAINT VITAL_ANIMALDOCS_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (ANIMALDOCS_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ADOPTER vers la table VTL_PROPRIETAIRE"
ALTER TABLE VTL_ADOPTER
ADD CONSTRAINT VTL_ADOPTER_ID_PROPRIETAIRE_VTL_PROPRIETAIRE_FK FOREIGN KEY (VTL_ADOPTER_ID_PROPRIETAIRE)
	REFERENCES VTL_PROPRIETAIRE(VTL_PROPRIETAIRE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ADOPTER vers la table VTL_ANIMAL"
ALTER TABLE VTL_ADOPTER
ADD CONSTRAINT VTL_ADOPTER_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (VTL_ADOPTER_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ANIMAL vers la table VTL_RACE"
ALTER TABLE VTL_ANIMAL
ADD CONSTRAINT VTL_ANIMAL_ID_RACE_VTL_RACE_FK FOREIGN KEY (VTL_ANIMAL_ID_RACE)
	REFERENCES VTL_RACE(VTL_RACE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ANIMAL vers la table VTL_CARTE"
ALTER TABLE VTL_ANIMAL
ADD CONSTRAINT VTL_ANIMAL_ID_CARTE_VTL_CARTE_FK FOREIGN KEY (VTL_ANIMAL_ID_CARTE)
	REFERENCES VTL_CARTE(VTL_CARTE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ANIMAL vers la table VTL_TYPE"
ALTER TABLE VTL_ANIMAL
ADD CONSTRAINT VTL_ANIMAL_ID_TYPE_VTL_TYPE_FK FOREIGN KEY (VTL_ANIMAL_ID_TYPE)
	REFERENCES VTL_TYPE(VTL_TYPE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ANIMAL vers la table VTL_PROPRIETAIRE"
ALTER TABLE VTL_ANIMAL
ADD CONSTRAINT VTL_ANIMAL_ID_PROP_VTL_PROPRIETAIRE_FK FOREIGN KEY (VTL_ANIMAL_ID_PROP)
	REFERENCES VTL_PROPRIETAIRE(VTL_PROPRIETAIRE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ASSURANCE vers la table VTL_USER"
ALTER TABLE VTL_ASSURANCE
ADD CONSTRAINT VTL_ASSURANCE_ID_USER_VTL_USER_FK FOREIGN KEY (VTL_ASSURANCE_ID_USER)
	REFERENCES VTL_USER(VTL_USER_ID);
GO

-- "Creation de la clef etrangere de la table VTL_ATTACHEMT vers la table VTL_CONSULTATION"
ALTER TABLE VTL_ATTACHEMT
ADD CONSTRAINT VTL_ATTACHEMT_CONSULT_VTL_CONSULTATION_FK FOREIGN KEY (VTL_ATTACHEMT_CONSULT)
	REFERENCES VTL_CONSULTATION(VTL_CONSULTATION_ID);
GO

-- "Creation de la clef etrangere de la table VTL_CNSLDIET vers la table VTL_ANIMAL"
ALTER TABLE VTL_CNSLDIET
ADD CONSTRAINT VITAL_CNSLDIET_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (CNSLDIET_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_CONSULTATION vers la table VTL_VETERINAIRE"
ALTER TABLE VTL_CONSULTATION
ADD CONSTRAINT VTL_CONSULTATION_ID_VETERINAIRE_VTL_VETERINAIRE_FK FOREIGN KEY (VTL_CONSULTATION_ID_VETERINAIRE)
	REFERENCES VTL_VETERINAIRE(VTL_VETERINAIRE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_CONSULTATION vers la table VTL_ANIMAL"
ALTER TABLE VTL_CONSULTATION
ADD CONSTRAINT VTL_CONSULTATION_L_VTL_ANIMAL_FK FOREIGN KEY (VTL_CONSULTATION_L)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_CONTRAT vers la table VTL_ANIMAL"
ALTER TABLE VTL_CONTRAT
ADD CONSTRAINT VTL_CONTRAT_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (VTL_CONTRAT_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_CONTRAT vers la table VTL_PROPRIETAIRE"
ALTER TABLE VTL_CONTRAT
ADD CONSTRAINT VTL_CONTRAT_ID_PROPRIETAIRE_VTL_PROPRIETAIRE_FK FOREIGN KEY (VTL_CONTRAT_ID_PROPRIETAIRE)
	REFERENCES VTL_PROPRIETAIRE(VTL_PROPRIETAIRE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_CONTRAT vers la table VTL_ASSURANCE"
ALTER TABLE VTL_CONTRAT
ADD CONSTRAINT VTL_CONTRAT_ID_ASSURANCE_VTL_ASSURANCE_FK FOREIGN KEY (VTL_CONTRAT_ID_ASSURANCE)
	REFERENCES VTL_ASSURANCE(VTL_ASSURANCE_ID);
GO

-- "Creation de la clef etrangere de la table VTL_HISTO_POIDS vers la table VTL_ANIMAL"
ALTER TABLE VTL_HISTO_POIDS
ADD CONSTRAINT VTL_HISTO_POIDS_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (VTL_HISTO_POIDS_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_HISTO_TAILLE vers la table VTL_ANIMAL"
ALTER TABLE VTL_HISTO_TAILLE
ADD CONSTRAINT VTL_HISTO_TAILLE_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (VTL_HISTO_TAILLE_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_POSITION vers la table VTL_ANIMAL"
ALTER TABLE VTL_POSITION
ADD CONSTRAINT VTL_POSITION_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (VTL_POSITION_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_PROPRIETAIRE vers la table VTL_USER"
ALTER TABLE VTL_PROPRIETAIRE
ADD CONSTRAINT VTL_PROPRIETAIRE_ID_USER_VTL_USER_FK FOREIGN KEY (VTL_PROPRIETAIRE_ID_USER)
	REFERENCES VTL_USER(VTL_USER_ID);
GO

-- "Creation de la clef etrangere de la table VTL_REMBOURSMT vers la table VTL_CONSULTATION"
ALTER TABLE VTL_REMBOURSMT
ADD CONSTRAINT VTL_REMBOURSMT_CONSULT_VTL_CONSULTATION_FK FOREIGN KEY (VTL_REMBOURSMT_CONSULT)
	REFERENCES VTL_CONSULTATION(VTL_CONSULTATION_ID);
GO

-- "Creation de la clef etrangere de la table VTL_REMBOURSMT vers la table VTL_CONTRAT"
ALTER TABLE VTL_REMBOURSMT
ADD CONSTRAINT VTL_REMBOURSMT_CONTRAT_VTL_CONTRAT_FK FOREIGN KEY (VTL_REMBOURSMT_CONTRAT)
	REFERENCES VTL_CONTRAT(VTL_CONTRAT_ID);
GO

-- "Creation de la clef etrangere de la table VTL_REMBOURSMT vers la table VTL_STATUT"
ALTER TABLE VTL_REMBOURSMT
ADD CONSTRAINT VTL_REMBOURSMT_STATUT_VTL_STATUT_FK FOREIGN KEY (VTL_REMBOURSMT_STATUT)
	REFERENCES VTL_STATUT(VTL_STATUT_ID);
GO

-- "Creation de la clef etrangere de la table VTL_TRAITEMENT_MEDICAMENT vers la table VTL_TRAITREMENT"
ALTER TABLE VTL_TRAITEMENT_MEDICAMENT
ADD CONSTRAINT VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT_VTL_TRAITREMENT_FK FOREIGN KEY (VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT)
	REFERENCES VTL_TRAITREMENT(VTL_TRAITREMENT_ID);
GO

-- "Creation de la clef etrangere de la table VTL_TRAITEMENT_MEDICAMENT vers la table VTL_MEDICAMENT"
ALTER TABLE VTL_TRAITEMENT_MEDICAMENT
ADD CONSTRAINT VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT_VTL_MEDICAMENT_FK FOREIGN KEY (VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT)
	REFERENCES VTL_MEDICAMENT(VTL_MEDICAMENT_ID);
GO

-- "Creation de la clef etrangere de la table VTL_TRAITREMENT vers la table VTL_ANIMAL"
ALTER TABLE VTL_TRAITREMENT
ADD CONSTRAINT VTL_TRAITREMENT_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (VTL_TRAITREMENT_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_VACCINATION vers la table VTL_ANIMAL"
ALTER TABLE VTL_VACCINATION
ADD CONSTRAINT VTL_VACCINATION_ID_ANIMAL_VTL_ANIMAL_FK FOREIGN KEY (VTL_VACCINATION_ID_ANIMAL)
	REFERENCES VTL_ANIMAL(VTL_ANIMAL_ID);
GO

-- "Creation de la clef etrangere de la table VTL_VACCINATION vers la table VTL_VACCIN"
ALTER TABLE VTL_VACCINATION
ADD CONSTRAINT VTL_VACCINATION_ID_VACCIN_VTL_VACCIN_FK FOREIGN KEY (VTL_VACCINATION_ID_VACCIN)
	REFERENCES VTL_VACCIN(VTL_VACCIN_ID);
GO

-- "Creation de la clef etrangere de la table VTL_VACCINATION vers la table VTL_CONSULTATION"
ALTER TABLE VTL_VACCINATION
ADD CONSTRAINT VTL_VACCINATION_ID_CONSULTATION_VTL_CONSULTATION_FK FOREIGN KEY (VTL_VACCINATION_ID_CONSULTATION)
	REFERENCES VTL_CONSULTATION(VTL_CONSULTATION_ID);
GO

-- "Creation de la clef etrangere de la table VTL_VETERINAIRE vers la table VTL_USER"
ALTER TABLE VTL_VETERINAIRE
ADD CONSTRAINT VTL_VETERINAIRE_ID_USER_VTL_USER_FK FOREIGN KEY (VTL_VETERINAIRE_ID_USER)
	REFERENCES VTL_USER(VTL_USER_ID);
GO


-- "=============================="
-- "Fin du script vital_create.sql"
-- "=============================="

