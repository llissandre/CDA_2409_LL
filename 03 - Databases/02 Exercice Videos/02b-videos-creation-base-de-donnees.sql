/* 
commentaire
 */
-- commentaire
/*
Création de la base de données
Sous langage : DDL / LDD
Data Definition Language
Langage de définition des données
Principales instructions : 
CREATE = Créer une structure (DATABASE, TABLE, VIEW, PROCEDURE, TRIGGER, FUNCTION)
ALTER = Modifier une structure existante
DROP = Supprimer une structure existante
*/

/*
realisateur = (realisateur_id INT AUTO_INCREMENT, realisateur_nom VARCHAR(100), realisateur_prenom VARCHAR(100));
acteur = (acteur_id INT AUTO_INCREMENT, acteur_nom VARCHAR(100), acteur_prenom VARCHAR(100));
film = (film_id INT AUTO_INCREMENT, film_titre VARCHAR(255), film_duree SMALLINT, #realisateur_id);
film_acteur = (#film_id, #acteur_id);
*/

/* SUPPRIMER LA BASE DE DONNEES SI ELLE EXISTE */
DROP DATABASE IF EXISTS videos;

/* CREER UNE BASE DE DONNEES NOMMEE "videos" */
-- CREATE DATABASE videos;
CREATE DATABASE IF NOT EXISTS videos;

/* SELECTIONNER/UTILISER LA BASE DE DONNEES CREEE */
USE videos;

-- Les requêtes qui suivent utiliseront 
-- la base de données sélectionné ci-dessus


/* CREER UNE TABLE NOMMEE "realisateur" */
CREATE TABLE realisateur
(
	realisateur_id INT PRIMARY KEY AUTO_INCREMENT,
    realisateur_nom VARCHAR(100) NOT NULL,
    realisateur_prenom VARCHAR(100) NOT NULL
);

CREATE TABLE acteur
(
	acteur_id INT AUTO_INCREMENT,
    acteur_nom VARCHAR(100) NOT NULL,
    acteur_prenom VARCHAR(100) NOT NULL,
    PRIMARY KEY (acteur_id)
);

CREATE TABLE film
(
	film_id INT AUTO_INCREMENT,
    film_titre VARCHAR(255) NOT NULL,
    film_duree SMALLINT NOT NULL,
    realisateur_id INT,
    PRIMARY KEY (film_id),
    FOREIGN KEY (realisateur_id) REFERENCES realisateur(realisateur_id)
);

CREATE TABLE film_acteur 
(
	film_id INT,
    acteur_id INT,
    PRIMARY KEY(film_id, acteur_id),
    FOREIGN KEY (film_id) REFERENCES film(film_id),
    FOREIGN KEY (acteur_id) REFERENCES acteur(acteur_id)
);


/* CONTRAINTES */
