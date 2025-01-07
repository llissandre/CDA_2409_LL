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
users = (user_id, user_email, user_lastname, user_firstname);
questions = (question_id, question_date, question_label, question_response, #user_id);
categories = (category_name, category_description, category_order);
categories_questions = (#question_id, #category_name);
*/

/* SUPPRIMER LA BASE DE DONNÉES SI ELLE EXISTE */
DROP DATABASE IF EXISTS mini_faq;

/* CRÉER UNE BASE DE DONNÉES NOMMÉE "videos" */
-- CREATE DATABASE videos;
CREATE DATABASE IF NOT EXISTS mini_faq;

/* SÉLECTIONNER/UTILISER LA BASE DE DONNÉES CRÉÉE */
USE mini_faq;

-- Les requêtes qui suivent utiliseront
-- la base de données sélectionnée ci-dessus

CREATE TABLE user(
   user_id INT,
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