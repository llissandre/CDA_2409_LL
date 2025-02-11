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
  contrat_id INT PRIMARY KEY AUTO_INCREMENT,
  contrat_pourcentage TINYINT UNSIGNED NOT NULL,
  contrat_duree TINYINT UNSIGNED NOT NULL
);

CREATE TABLE bail (
   locataire_id INT,   
   bien_id INT,
   bail_duree TINYINT UNSIGNED NOT NULL,
   bail_date_debut DATE NOT NULL
);

CREATE TABLE souscrire (
   bien_id INT,
   contrat_id INT,
   PRIMARY KEY(bien_id, contrat_id)
);

ALTER TABLE bien ADD CONSTRAINT FK_TYPE_DE_BIEN_BIEN FOREIGN KEY (type_de_bien_id) REFERENCES type_de_bien(type_de_bien_id);
ALTER TABLE bien ADD CONSTRAINT FK_PROPRIETAIRE_BIEN FOREIGN KEY (proprietaire_id) REFERENCES proprietaire(proprietaire_id);

ALTER TABLE bail ADD CONSTRAINT FK_LOCATAIRE_BIEN FOREIGN KEY (bien_id) REFERENCES bien(bien_id);
ALTER TABLE bail ADD CONSTRAINT FK_BIEN_LOCATAIRE FOREIGN KEY (locataire_id) REFERENCES locataire(locataire_id);

ALTER TABLE souscrire ADD CONSTRAINT FK_BIEN_CONTRAT FOREIGN KEY (bien_id) REFERENCES bien(bien_id);
ALTER TABLE souscrire ADD CONSTRAINT FK_CONTRAT_BIEN FOREIGN KEY (contrat_id) REFERENCES contrat(contrat_id);
