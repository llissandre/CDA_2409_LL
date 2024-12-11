/* commentaire */
-- commentaire

/* SUPPRIMER LA BASE DE DONNEES SI ELLE EXISTE */
DROP DATABASE IF EXISTS videos;

/* CREER UNE BASE DE DONNEES NOMMEE "videos" */
CREATE DATABASE IF NOT EXISTS videos;

/* UTILISER LA BASE DE DONNEES CREEE */
USE videos;

-- Les requêtes qui suivent utiliseront 
-- la base de données sélectionné ci-dessus


/* CREER UNE TABLE NOMMEE "film" */
CREATE TABLE IF NOT EXISTS film
( 
	film_id INT AUTO_INCREMENT PRIMARY KEY,
    film_titre VARCHAR(255) NOT NULL,
    film_duree SMALLINT NOT NULL
);

/* INSERER LE JEU D'ESSAI DANS LA TABLE FILMS */
INSERT INTO film 
VALUES 
(NULL, "Léon", 120),
(NULL, "E.T", 90),
(NULL, "ça", 103);

INSERT INTO film 
(film_titre, film_duree)
VALUES 
("L'exorciste", 240),
("Super Papa", 87),
("Gladiator 2", 117);

INSERT INTO film 
(film_duree, film_titre)
VALUES 
(98, "Loups-Garous");



/* AFFICHER LES DONNEES DE LA TABLE */

SELECT * FROM film;

SELECT film_id, film_titre FROM film;




