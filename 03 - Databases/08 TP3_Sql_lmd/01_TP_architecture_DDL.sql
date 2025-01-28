/*
Création de la base de données
Sous-langage : DDL /LDD
Data Definition Language
Langage de définition des données

Principales instructions :
CREATE = Créer une structure (DATABASE, TABLE, VIEW, PROCEDURE, TRIGGER, FUNCTION)
ALTER =  Modifier une structure existante
DROP = Supprimer une structure existante
*/

DROP DATABASE IF EXISTS kiloutout;
CREATE DATABASE kiloutout;
USE kiloutout ;

CREATE TABLE proprietaire (
   proprietaire_id INT PRIMARY KEY,
   proprietaire_nom VARCHAR (100) NOT NULL,
   proprietaire_prenom VARCHAR (100) NOT NULL,
   proprietaire_adresse VARCHAR (255) NOT NULL,
   Proprietaire_telephone INT NOT NULL
);

CREATE TABLE locataire (
   locataire_id INT PRIMARY KEY,
   locataire_nom VARCHAR (100) NOT NULL,
   locataire_prenom VARCHAR (100) NOT NULL,
   locataire_telephone INT NOT NULL
 );

CREATE TABLE agence (
   Kiloutout CHAR (9) PRIMARY KEY
);

CREATE TABLE bien (
   bien_id INT PRIMARY KEY,
   bien_situation VARCHAR (255) NOT NULL,
   bien_surface TINYINT NOT NULL,
   bien_loyer_mensuel INT NOT NULL,
   proprietaire_id INT NOT NULL
);

CREATE TABLE contrat (
   bien_id INT,
   Kiloutout CHAR (9),
   PRIMARY KEY (Kiloutout, bien_id),
   contrat_id SMALLINT NOT NULL UNIQUE,
   contrat_pourcentage TINYINT NOT NULL,
   contrat_duree TINYINT NOT NULL   
);

CREATE TABLE bail (
   bien_id INT PRIMARY KEY,
   bail_id INT NOT NULL AUTO_INCREMENT,
   bail_duree TINYINT NOT NULL,
   locataire_id INT
);

ALTER TABLE bien ADD CONSTRAINT FK_PROPRIETAIRE_BIEN FOREIGN KEY (proprietaire_id) REFERENCES proprietaire(proprietaire_id);

ALTER TABLE contrat ADD CONSTRAINT FK_BIEN_AGENCE FOREIGN KEY(Kiloutout) REFERENCES agence (Kiloutout);
ALTER TABLE contrat ADD CONSTRAINT FK_BIEN_AGENCE FOREIGN KEY (bien_id) REFERENCES bien(bien_id);

ALTER TABLE contrat ADD CONSTRAINT FK_BIEN_LOCATAIRE FOREIGN KEY (bien_id) REFERENCES bien(bien_id);
ALTER TABLE contrat ADD CONSTRAINT FK_BIEN_LOCATAIRE FOREIGN KEY (locataire_id) REFERENCES locataire(locataire_id);

