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

CREATE TABLE users(
   user_id INT AUTO_INCREMENT PRIMARY KEY,
   user_email VARCHAR(128) NOT NULL UNIQUE,
   user_lastname VARCHAR(50) NOT NULL,
   user_firstname VARCHAR(50) NOT NULL
);

CREATE TABLE questions(
   question_id INT AUTO_INCREMENT PRIMARY KEY,
   question_date DATE NOT NULL,
   question_label VARCHAR(255) NOT NULL,
   question_response TEXT NOT NULL,
   user_id INT
);

CREATE TABLE categories(
   category_name VARCHAR(30) PRIMARY KEY,
   category_description VARCHAR(255),
   category_order INT NOT NULL UNIQUE 
);

CREATE TABLE categories_questions(
   question_id INT,
   category_name VARCHAR(30)
);

/* Modifier la table publication et y ajouter la clé étrangère */
ALTER TABLE questions ADD FOREIGN KEY (user_id) REFERENCES users(user_id);

/* CONTRAINTES */
ALTER TABLE categories_questions ADD CONSTRAINT fk_categories_questions_questions FOREIGN KEY(question_id) REFERENCES questions(question_id);
ALTER TABLE categories_questions ADD CONSTRAINT fk_categories_questions_categories FOREIGN KEY(category_name) REFERENCES categories(category_name);