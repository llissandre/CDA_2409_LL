/*
Création de la base de données
Sous-langage : DDL /LDD
Data Definition Language
Langage de définition des données
*/

DROP DATABASE IF EXISTS kiloutout;
CREATE DATABASE kiloutout;

USE kiloutout ;

CREATE TABLE proprietaire (
   proprietaire_id INT PRIMARY KEY AUTO_INCREMENT,
   proprietaire_nom VARCHAR (100) NOT NULL,
   proprietaire_prenom VARCHAR (100) NOT NULL,
   proprietaire_adresse VARCHAR (255) NOT NULL,
   proprietaire_telephone CHAR (14) NOT NULL
);

CREATE TABLE locataire (
   locataire_id INT PRIMARY KEY AUTO_INCREMENT,
   locataire_nom VARCHAR (100) NOT NULL,
   locataire_prenom VARCHAR (100) NOT NULL,
   locataire_telephone CHAR (14) NOT NULL
 );

CREATE TABLE agence (
   Kiloutout CHAR (9) PRIMARY KEY
);

CREATE TABLE type_de_bien (
   type_de_bien_id INT PRIMARY KEY AUTO_INCREMENT,
   type_de_bien_nom VARCHAR (20) NOT NULL
);

CREATE TABLE bien (
  bien_id INT PRIMARY KEY AUTO_INCREMENT,
   bien_situation VARCHAR (255) NOT NULL,
   bien_surface TINYINT UNSIGNED NOT NULL,
   bien_loyer_mensuel INT NOT NULL,
   type_de_bien_id INT NOT NULL,
   proprietaire_id INT NOT NULL
);

CREATE TABLE contrat (
   bien_id INT,
   Kiloutout CHAR (9),
   contrat_id SMALLINT NOT NULL UNIQUE AUTO_INCREMENT,
   contrat_pourcentage TINYINT NOT NULL,
   contrat_duree TINYINT NOT NULL,
    PRIMARY KEY (Kiloutout, bien_id)
);

CREATE TABLE bail (
   bien_id INT PRIMARY KEY,
   bail_id INT NOT NULL UNIQUE AUTO_INCREMENT,
   bail_duree TINYINT NOT NULL,
   bail_date_debut DATE NOT NULL,
   locataire_id INT
);

ALTER TABLE bien ADD CONSTRAINT FK_TYPE_DE_BIEN_BIEN FOREIGN KEY(type_de_bien_id) REFERENCES type_de_bien(type_de_bien_id);
ALTER TABLE bien ADD CONSTRAINT FK_PROPRIETAIRE_BIEN FOREIGN KEY (proprietaire_id) REFERENCES proprietaire(proprietaire_id);

ALTER TABLE contrat ADD CONSTRAINT FK_CONTRAT_AGENCE FOREIGN KEY(Kiloutout) REFERENCES agence (Kiloutout);
ALTER TABLE contrat ADD CONSTRAINT FK_CONTRAT_BIEN FOREIGN KEY (bien_id) REFERENCES bien(bien_id);

ALTER TABLE bail ADD CONSTRAINT FK_BIEN_LOCATAIRE FOREIGN KEY (bien_id) REFERENCES bien(bien_id);
ALTER TABLE bail ADD CONSTRAINT FK_LOCATAIRE_BIEN FOREIGN KEY (locataire_id) REFERENCES locataire(locataire_id);

