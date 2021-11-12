-- Suppression d'une ancienne base
DROP DATABASE BD_Infirmerie;
GO
-- Création de la base de données
CREATE DATABASE BD_Infirmerie;
GO
-- Indique la BDD à utiliser et dans laquelle on exécute les requêtes
USE BD_Infirmerie;
GO
-- Création de la table et création et paramétrage des champs
CREATE TABLE T_Utilisateur
(
    Id_utilisateur INT NOT NULL IDENTITY(1,1),
    Login_utilisateur NVARCHAR(255) NOT NULL,
    Mdp_utilisateur NVARCHAR(255) NOT NULL,
    CONSTRAINT pk_id_utilisateur PRIMARY KEY (Id_utilisateur)
);
GO
-- Création de la table et création et paramétrage des champs
CREATE TABLE T_Medicament
(
    Id_medicament INT NOT NULL IDENTITY(1,1),
    Libelle_medicament NVARCHAR(255) NOT NULL,
    CONSTRAINT pk_id_medicament PRIMARY KEY (Id_medicament)
);
GO
-- Création de la table et création et paramétrage des champs
CREATE TABLE T_Classe
(
    Id_classe INT NOT NULL IDENTITY(1,1),
    Libelle_classe NVARCHAR(255) NOT NULL,
    CONSTRAINT pk_id_classe PRIMARY KEY (Id_classe)
);
GO
-- Création de la table et création et paramétrage des champs
CREATE TABLE T_Eleve
(
    Id_eleve INT NOT NULL IDENTITY(1,1),
    Nom_eleve NVARCHAR(255) NOT NULL,
    Prenom_eleve NVARCHAR(255) NOT NULL,
    Date_de_naissance_eleve DATE NOT NULL,
    Telephone_eleve INT NOT NULL,
    Telephone_parent_eleve INT NOT NULL,
    Tier_temps_eleve BIT NOT NULL,
    Commentaire_sante_eleve NVARCHAR(255) NOT NULL,
    Id_classe_eleve INT NOT NULL,
    CONSTRAINT pk_id_eleve PRIMARY KEY (Id_eleve),
    CONSTRAINT fk_id_classe FOREIGN KEY (Id_classe_eleve) REFERENCES T_Classe (Id_classe)
);
GO
-- Création de la table et création et paramétrage des champs
CREATE TABLE T_Visite
(
    Id_visite INT NOT NULL IDENTITY(1,1),
    Date_visite DATE NOT NULL,
    Heure_debut_visite TIME NOT NULL,
    Heure_fin_visite TIME NOT NULL,
    Motif_visite NVARCHAR(255) NOT NULL,
    Commentaire_visite NVARCHAR(255) NOT NULL,
    Suite_visite NVARCHAR(255) NOT NULL,
    Parents_prevenus_visite BIT NOT NULL,
    Id_eleve_visite INT NOT NULL,
    CONSTRAINT pk_id_visite PRIMARY KEY (Id_visite),
    CONSTRAINT fk_id_eleve FOREIGN KEY (Id_eleve_visite) REFERENCES T_Eleve (Id_eleve)
);
GO
-- Création de la table et création et paramétrage des champs
CREATE TABLE T_Quantite_Medic
(
    Id_visite_quantite_medic INT NOT NULL,
    Id_medicament_quantite_medic INT NOT NULL,
    Quantite_medic INT NOT NULL,
    CONSTRAINT pk_id_visite_medicament PRIMARY KEY (Id_visite_quantite_medic, Id_medicament_quantite_medic),
    CONSTRAINT fk_id_visite FOREIGN KEY (Id_visite_quantite_medic) REFERENCES T_Visite (Id_visite),
    CONSTRAINT fk_id_medicament FOREIGN KEY (Id_medicament_quantite_medic) REFERENCES T_Medicament (Id_medicament)
);
GO