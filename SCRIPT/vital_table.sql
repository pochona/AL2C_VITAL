/*--------------------------------------------------------------------------*/
/* Application : VITL                                                       */
/* Version     : 1.0                                                        */
/* Societe     :                                                            */
/* Fonction    : Creation des tables                                        */
/* Historique  : Creation le 03/05/2017                                     */
/* Commentaire :                                                            */
/*------------------------------------------------------ www.desirade.fr ---*/

-- "=============================="
-- "Debut du script vital_table.sql"
-- "=============================="


-- "=============================="
-- "Creation des tables"
-- "=============================="

-- "Creation de la table VTL_ADOPTER"
CREATE TABLE VTL_ADOPTER (
	VTL_ADOPTER_ID INT IDENTITY(1,1) NOT NULL,
	VTL_ADOPTER_DT_DEBUT DATE NOT NULL,
	VTL_ADOPTER_DT_FIN DATE,
	VTL_ADOPTER_ID_PROPRIETAIRE INT,
	VTL_ADOPTER_ID_ANIMAL INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Adopter : Associations etre propriétaire et animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ADOPTER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ADOPTER', @level2type=N'COLUMN',@level2name=N'VTL_ADOPTER_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_debut', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ADOPTER', @level2type=N'COLUMN',@level2name=N'VTL_ADOPTER_DT_DEBUT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_fin', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ADOPTER', @level2type=N'COLUMN',@level2name=N'VTL_ADOPTER_DT_FIN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_proprietaire', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ADOPTER', @level2type=N'COLUMN',@level2name=N'VTL_ADOPTER_ID_PROPRIETAIRE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_animal', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ADOPTER', @level2type=N'COLUMN',@level2name=N'VTL_ADOPTER_ID_ANIMAL'
GO


-- "Creation de la table VTL_ANIMAL"
CREATE TABLE VTL_ANIMAL (
	VTL_ANIMAL_ID INT IDENTITY(1,1) NOT NULL,
	VTL_ANIMAL_NOM NVARCHAR(50) NOT NULL,
	VTL_ANIMAL_NUM_PUCE NVARCHAR(14),
	VTL_ANIMAL_DT_NAISSANCE DATE,
	VTL_ANIMAL_DT_DECES DATE,
	VTL_ANIMAL_ID_RACE INT,
	VTL_ANIMAL_ID_CARTE INT,
	VTL_ANIMAL_ID_TYPE INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nom', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_NOM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Num_puce', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_NUM_PUCE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_naissance', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_DT_NAISSANCE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_deces', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_DT_DECES'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_race', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_ID_RACE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_carte', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_ID_CARTE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_type', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ANIMAL', @level2type=N'COLUMN',@level2name=N'VTL_ANIMAL_ID_TYPE'
GO


-- "Creation de la table VTL_ASSURANCE"
CREATE TABLE VTL_ASSURANCE (
	VTL_ASSURANCE_ID INT IDENTITY(1,1) NOT NULL,
	VTL_ASSURANCE_NOM NVARCHAR(50) NOT NULL,
	VTL_ASSURANCE_SIRET NVARCHAR(50) NOT NULL
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Assurance', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ASSURANCE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ASSURANCE', @level2type=N'COLUMN',@level2name=N'VTL_ASSURANCE_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nom', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ASSURANCE', @level2type=N'COLUMN',@level2name=N'VTL_ASSURANCE_NOM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Siret', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_ASSURANCE', @level2type=N'COLUMN',@level2name=N'VTL_ASSURANCE_SIRET'
GO


-- "Creation de la table VTL_CARTE"
CREATE TABLE VTL_CARTE (
	VTL_CARTE_ID INT IDENTITY(1,1) NOT NULL,
	VTL_CARTE_NUMERO NVARCHAR(50) NOT NULL
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Carte vitale', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CARTE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CARTE', @level2type=N'COLUMN',@level2name=N'VTL_CARTE_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CARTE', @level2type=N'COLUMN',@level2name=N'VTL_CARTE_NUMERO'
GO


-- "Creation de la table VTL_CONSULTATION"
CREATE TABLE VTL_CONSULTATION (
	VTL_CONSULTATION_ID INT IDENTITY(1,1) NOT NULL,
	VTL_CONSULTATION_DT_CONSULTATION DATETIME2(0) NOT NULL,
	VTL_CONSULTATION_MONTANT NUMERIC(9,2),
	VTL_CONSULTATION_COMMENTAIRE VARBINARY(MAX),
	VTL_CONSULTATION_ID_VETERINAIRE INT,
	VTL_CONSULTATION_L INT,
	VTL_CONSULTATION_ID_PROPRIETAIRE INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Consultation vétérinaire d''un animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION', @level2type=N'COLUMN',@level2name=N'VTL_CONSULTATION_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_consultation', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION', @level2type=N'COLUMN',@level2name=N'VTL_CONSULTATION_DT_CONSULTATION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Montant', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION', @level2type=N'COLUMN',@level2name=N'VTL_CONSULTATION_MONTANT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Commentaire', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION', @level2type=N'COLUMN',@level2name=N'VTL_CONSULTATION_COMMENTAIRE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_veterinaire', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION', @level2type=N'COLUMN',@level2name=N'VTL_CONSULTATION_ID_VETERINAIRE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_animal', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION', @level2type=N'COLUMN',@level2name=N'VTL_CONSULTATION_L'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_proprietaire', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONSULTATION', @level2type=N'COLUMN',@level2name=N'VTL_CONSULTATION_ID_PROPRIETAIRE'
GO


-- "Creation de la table VTL_CONTRAT"
CREATE TABLE VTL_CONTRAT (
	VTL_CONTRAT_ID INT IDENTITY(1,1) NOT NULL,
	VTL_CONTRAT_NUM_CONTRAT NVARCHAR(50) NOT NULL,
	VTL_CONTRAT_DT_DEBUT DATE,
	VTL_CONTRAT_DT_FIN DATE,
	VTL_CONTRAT_ID_ANIMAL INT,
	VTL_CONTRAT_ID_PROPRIETAIRE INT,
	VTL_CONTRAT_ID_ASSURANCE INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contrat d''assurance', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT', @level2type=N'COLUMN',@level2name=N'VTL_CONTRAT_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Num_contrat', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT', @level2type=N'COLUMN',@level2name=N'VTL_CONTRAT_NUM_CONTRAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_debut', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT', @level2type=N'COLUMN',@level2name=N'VTL_CONTRAT_DT_DEBUT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_fin', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT', @level2type=N'COLUMN',@level2name=N'VTL_CONTRAT_DT_FIN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_animal', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT', @level2type=N'COLUMN',@level2name=N'VTL_CONTRAT_ID_ANIMAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_proprietaire', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT', @level2type=N'COLUMN',@level2name=N'VTL_CONTRAT_ID_PROPRIETAIRE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_assurance', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_CONTRAT', @level2type=N'COLUMN',@level2name=N'VTL_CONTRAT_ID_ASSURANCE'
GO


-- "Creation de la table VTL_HISTO_POIDS"
CREATE TABLE VTL_HISTO_POIDS (
	VTL_HISTO_POIDS_ID INT IDENTITY(1,1) NOT NULL,
	VTL_HISTO_POIDS_DT_HISTO DATETIME2(0) NOT NULL,
	VTL_HISTO_POIDS_POIDS NUMERIC(9,2) NOT NULL,
	VTL_HISTO_POIDS_ID_ANIMAL INT NOT NULL
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Historique du poids de l''animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_POIDS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_POIDS', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_POIDS_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_histo', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_POIDS', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_POIDS_DT_HISTO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Poids', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_POIDS', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_POIDS_POIDS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_animal', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_POIDS', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_POIDS_ID_ANIMAL'
GO


-- "Creation de la table VTL_HISTO_TAILLE"
CREATE TABLE VTL_HISTO_TAILLE (
	VTL_HISTO_TAILLE_ID INT IDENTITY(1,1) NOT NULL,
	VTL_HISTO_TAILLE_DT_HISTO DATETIME2(0) NOT NULL,
	VTL_HISTO_TAILLE_TAILLE NUMERIC(9,2) NOT NULL,
	VTL_HISTO_TAILLE_ID_ANIMAL INT NOT NULL
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Historique de la taille de l''animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_TAILLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_TAILLE', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_TAILLE_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_histo', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_TAILLE', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_TAILLE_DT_HISTO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Taille', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_TAILLE', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_TAILLE_TAILLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_animal', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_HISTO_TAILLE', @level2type=N'COLUMN',@level2name=N'VTL_HISTO_TAILLE_ID_ANIMAL'
GO


-- "Creation de la table VTL_MEDICAMENT"
CREATE TABLE VTL_MEDICAMENT (
	VTL_MEDICAMENT_ID INT IDENTITY(1,1) NOT NULL,
	VTL_MEDICAMENT_LIBELLE NVARCHAR(50) NOT NULL,
	VTL_MEDICAMENT_DOSAGE NVARCHAR(50),
	VTL_MEDICAMENT_DUREE_MOYENNE_JOUR INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Medicament', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_MEDICAMENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_MEDICAMENT_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Libelle', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_MEDICAMENT_LIBELLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dosage', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_MEDICAMENT_DOSAGE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Duree_moyenne_jour', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_MEDICAMENT_DUREE_MOYENNE_JOUR'
GO


-- "Creation de la table VTL_POSITION"
CREATE TABLE VTL_POSITION (
	VTL_POSITION_ID INT IDENTITY(1,1) NOT NULL,
	VTL_POSITION_DT_POSITION DATETIME2(0) NOT NULL,
	VTL_POSITION_COORD_LAT NVARCHAR(50),
	VTL_POSITION_COORD_LONG NVARCHAR(50),
	VTL_POSITION_TOP_COURANTE BIT DEFAULT 0,
	VTL_POSITION_ID_ANIMAL INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Position de l''animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_POSITION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_POSITION', @level2type=N'COLUMN',@level2name=N'VTL_POSITION_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_position', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_POSITION', @level2type=N'COLUMN',@level2name=N'VTL_POSITION_DT_POSITION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Coord_lat', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_POSITION', @level2type=N'COLUMN',@level2name=N'VTL_POSITION_COORD_LAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Coord_long', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_POSITION', @level2type=N'COLUMN',@level2name=N'VTL_POSITION_COORD_LONG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Top_courante', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_POSITION', @level2type=N'COLUMN',@level2name=N'VTL_POSITION_TOP_COURANTE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_animal', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_POSITION', @level2type=N'COLUMN',@level2name=N'VTL_POSITION_ID_ANIMAL'
GO


-- "Creation de la table VTL_PROPRIETAIRE"
CREATE TABLE VTL_PROPRIETAIRE (
	VTL_PROPRIETAIRE_ID INT IDENTITY(1,1) NOT NULL,
	VTL_PROPRIETAIRE_NOM NVARCHAR(50) NOT NULL,
	VTL_PROPRIETAIRE_PRENOM NVARCHAR(50)
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Propriétaire', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_PROPRIETAIRE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_PROPRIETAIRE', @level2type=N'COLUMN',@level2name=N'VTL_PROPRIETAIRE_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nom', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_PROPRIETAIRE', @level2type=N'COLUMN',@level2name=N'VTL_PROPRIETAIRE_NOM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Prenom', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_PROPRIETAIRE', @level2type=N'COLUMN',@level2name=N'VTL_PROPRIETAIRE_PRENOM'
GO


-- "Creation de la table VTL_RACE"
CREATE TABLE VTL_RACE (
	VTL_RACE_ID INT IDENTITY(1,1) NOT NULL,
	VTL_RACE_NOM NVARCHAR(50) NOT NULL
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Race de l''animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_RACE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_RACE', @level2type=N'COLUMN',@level2name=N'VTL_RACE_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nom', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_RACE', @level2type=N'COLUMN',@level2name=N'VTL_RACE_NOM'
GO


-- "Creation de la table VTL_TRAITEMENT_MEDICAMENT"
CREATE TABLE VTL_TRAITEMENT_MEDICAMENT (
	VTL_TRAITEMENT_MEDICAMENT_ID INT IDENTITY(1,1) NOT NULL,
	VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT INT NOT NULL,
	VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT INT,
	VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE INT,
	VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Liste des médicaments compris dans un traitement', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITEMENT_MEDICAMENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITEMENT_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITEMENT_MEDICAMENT_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_traitement', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITEMENT_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITEMENT_MEDICAMENT_ID_TRAITEMENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_medicament', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITEMENT_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITEMENT_MEDICAMENT_ID_MEDICAMENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Posologie', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITEMENT_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITEMENT_MEDICAMENT_POSOLOGIE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Duree_jour', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITEMENT_MEDICAMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITEMENT_MEDICAMENT_DUREE_JOUR'
GO


-- "Creation de la table VTL_TRAITREMENT"
CREATE TABLE VTL_TRAITREMENT (
	VTL_TRAITREMENT_ID INT IDENTITY(1,1) NOT NULL,
	VTL_TRAITREMENT_DUREE_JOUR INT NOT NULL,
	VTL_TRAITREMENT_DT_DEBUT DATETIME2(0)
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Traitrement', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITREMENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITREMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITREMENT_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Duree_jour', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITREMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITREMENT_DUREE_JOUR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_debut', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TRAITREMENT', @level2type=N'COLUMN',@level2name=N'VTL_TRAITREMENT_DT_DEBUT'
GO


-- "Creation de la table VTL_TYPE"
CREATE TABLE VTL_TYPE (
	VTL_TYPE_ID INT IDENTITY(1,1) NOT NULL,
	VTL_TYPE_LIBELLE NVARCHAR(50) NOT NULL
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Typede l''animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TYPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TYPE', @level2type=N'COLUMN',@level2name=N'VTL_TYPE_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Libelle', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_TYPE', @level2type=N'COLUMN',@level2name=N'VTL_TYPE_LIBELLE'
GO


-- "Creation de la table VTL_VACCIN"
CREATE TABLE VTL_VACCIN (
	VTL_VACCIN_ID INT IDENTITY(1,1) NOT NULL,
	VTL_VACCIN_LIBELLE NVARCHAR(50) NOT NULL,
	VTL_VACCIN_TOP_PERIODIQUE BIT DEFAULT 0,
	VTL_VACCIN_PERIODE_MOIS INT,
	VTL_VACCIN_TOP_RECOMMANDATION BIT DEFAULT 0
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vaccin', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCIN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCIN', @level2type=N'COLUMN',@level2name=N'VTL_VACCIN_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Libelle', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCIN', @level2type=N'COLUMN',@level2name=N'VTL_VACCIN_LIBELLE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Top_periodique', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCIN', @level2type=N'COLUMN',@level2name=N'VTL_VACCIN_TOP_PERIODIQUE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Periode_mois', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCIN', @level2type=N'COLUMN',@level2name=N'VTL_VACCIN_PERIODE_MOIS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Top_recommandation', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCIN', @level2type=N'COLUMN',@level2name=N'VTL_VACCIN_TOP_RECOMMANDATION'
GO


-- "Creation de la table VTL_VACCINATION"
CREATE TABLE VTL_VACCINATION (
	VTL_VACCINATION_ID INT IDENTITY(1,1) NOT NULL,
	VTL_VACCINATION_ID_ANIMAL INT NOT NULL,
	VTL_VACCINATION_ID_VACCIN INT,
	VTL_VACCINATION_DT_VACCIN DATE,
	VTL_VACCINATION_ID_CONSULTATION INT
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vaccination d''un animal', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCINATION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCINATION', @level2type=N'COLUMN',@level2name=N'VTL_VACCINATION_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_animal', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCINATION', @level2type=N'COLUMN',@level2name=N'VTL_VACCINATION_ID_ANIMAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_vaccin', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCINATION', @level2type=N'COLUMN',@level2name=N'VTL_VACCINATION_ID_VACCIN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dt_vaccin', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCINATION', @level2type=N'COLUMN',@level2name=N'VTL_VACCINATION_DT_VACCIN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id_consultation', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VACCINATION', @level2type=N'COLUMN',@level2name=N'VTL_VACCINATION_ID_CONSULTATION'
GO


-- "Creation de la table VTL_VETERINAIRE"
CREATE TABLE VTL_VETERINAIRE (
	VTL_VETERINAIRE_ID INT IDENTITY(1,1) NOT NULL,
	VTL_VETERINAIRE_NOM NVARCHAR(50) NOT NULL,
	VTL_VETERINAIRE_PRENOM NVARCHAR(50) NOT NULL,
	VTL_VETERINAIRE_SIRET NVARCHAR(50)
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Veterinaire', @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VETERINAIRE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VETERINAIRE', @level2type=N'COLUMN',@level2name=N'VTL_VETERINAIRE_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nom', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VETERINAIRE', @level2type=N'COLUMN',@level2name=N'VTL_VETERINAIRE_NOM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Prenom', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VETERINAIRE', @level2type=N'COLUMN',@level2name=N'VTL_VETERINAIRE_PRENOM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SIRET', @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'VTL_VETERINAIRE', @level2type=N'COLUMN',@level2name=N'VTL_VETERINAIRE_SIRET'
GO


-- "Creation de la table ~temp636291757526019432"
CREATE TABLE ~temp636291757526019432 (
)
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=NULL, @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE', @level1name=N'~temp636291757526019432'
GO



-- "=============================="
-- "Fin du script vital_table.sql"
-- "=============================="

