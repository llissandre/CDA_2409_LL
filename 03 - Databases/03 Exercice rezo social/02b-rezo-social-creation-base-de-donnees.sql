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

/*
utilisateur = (id INT, nom_utilisateur VARCHAR(32), email VARCHAR(128));
publication = (pub_id INT AUTO_INCREMENT, pub_date DATE, pub_titre VARCHAR(255), pub_contenu TEXT, #id);
aimer = (#id, #pub_id);
*/

/* SUPPRIMER LA BASE DE DONNÉES SI ELLE EXISTE */
DROP DATABASE IF EXISTS rezo_social;

/* CRÉER UNE BASE DE DONNÉES NOMMÉE "videos" */
-- CREATE DATABASE videos;
CREATE DATABASE IF NOT EXISTS rezo_social;

/* SÉLECTIONNER/UTILISER LA BASE DE DONNÉES CRÉÉE */
USE rezo_social;

-- Les requêtes qui suivent utiliseront
-- la base de données sélectionnée ci-dessus

CREATE TABLE utilisateur(
   id INT,
   nom_utilisateur VARCHAR(32) NOT NULL UNIQUE,
   email VARCHAR(128) NOT NULL UNIQUE,
   PRIMARY KEY(id)
);

CREATE TABLE publication(
   pub_id INT AUTO_INCREMENT,
   pub_date DATE NOT NULL,
   pub_titre VARCHAR(255),
   pub_contenu TEXT,
   id INT,
   PRIMARY KEY(pub_id)
   -- FOREIGN KEY(id) REFERENCES utilisateur(id)
);

CREATE TABLE aimer(
   id INT,
   pub_id INT,
   PRIMARY KEY(id, pub_id)
   -- FOREIGN KEY(id) REFERENCES utilisateur(id),
   -- FOREIGN KEY(pub_id) REFERENCES publication(pub_id)
);

/* Modifier la table publication et y ajouter la clé étrangère */
ALTER TABLE publication ADD FOREIGN KEY (id) REFERENCES utilisateur(id);

/* CONTRAINTES */
ALTER TABLE aimer ADD CONSTRAINT fk_aimer_utilisateur FOREIGN KEY(id) REFERENCES utilisateur(id);
ALTER TABLE aimer ADD CONSTRAINT fk_aimer_publication FOREIGN KEY(pub_id) REFERENCES publication(pub_id);