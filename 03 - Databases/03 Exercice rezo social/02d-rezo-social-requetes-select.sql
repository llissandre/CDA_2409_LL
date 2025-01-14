/*
REQUÊTES SQL Á IMPLÉMENTER 
Sous-langage : DQL / LRD
Data Query Language
Langage de requête sur les données

Principales instructions :
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/
use rezo_social;

/* Sélectionner toutes les colonnes et toutes les lignes */
SELECT * FROM utilisateur;
SELECT * FROM publication;
SELECT * FROM aimer;

/* 1. Sélectionner tous les utilisateurs (nom d'utilisateur + email) */
SELECT nom_utilisateur, email
FROM utilisateur;

/* 2. Sélectionner toutes les publications (titre, date, contenu, id utilisateur) triées par date de la plus récente à la plus ancienne. */
SELECT pub_titre AS Titre, pub_date AS `Date`, pub_contenu AS Contenu, id AS Identifiant_utilisateur
FROM publication
ORDER BY `Date` DESC;

-- Sélectionner toutes les publications (titre, date, contenu, id utilisateur) triées par id utilisateur, puis par date de la plus récente à la plus ancienne. */
-- EXPLAIN
SELECT pub_titre AS Titre, pub_date AS `Date`, pub_contenu AS Contenu, id AS Identifiant_utilisateur
FROM publication
ORDER BY id ASC, `Date` DESC;

/* 3. Sélectionner les publications (pub_id, date, titre) de l'utilisateur N°2. */
SELECT pub_id AS Identifiant_publication, pub_date AS `Date`, pub_titre AS Titre
FROM publication
WHERE id = 2;

/* 4. Sélectionner les publications (pub_id, titre, contenu) dont le titre contient la lettre "a". Le résultat est trié par le titre et par ordre décroissant. */
SELECT pub_id AS Identifiant_publication, pub_titre AS Titre, pub_contenu AS Contenu
FROM publication
WHERE pub_titre LIKE "%a%"
ORDER BY Titre DESC;

-- Sélectionner les publications (pub_id, titre, contenu) dont le titre NE contient PAS la lettre "a". Le résultat est trié par le titre et par ordre décroissant. */
SELECT pub_id AS Identifiant_publication, pub_titre AS Titre, pub_contenu AS Contenu
FROM publication
WHERE pub_titre NOT LIKE "%a%"
ORDER BY Titre DESC;

/* 5. Sélectionner les utilisateurs (id, nom, email) dont l'adresse email se termine par "com". */
SELECT id AS Identification_utilisateur, nom_utilisateur, email 
FROM utilisateur
WHERE email LIKE "%com";

/* 6. Sélectionner les publications triées par titre (ordre alphabétique) avec le nom de l'utilisateur. */
-- Version sans jointure
EXPLAIN
SELECT pub_id AS Identifiant_publication, pub_date AS `Date`, pub_titre AS Titre, pub_contenu AS Contenu, nom_utilisateur
FROM publication, utilisateur
WHERE publication.id = utilisateur.id
ORDER BY Titre;

-- Version avec jointure à privilégier pour des 
SELECT pub_id AS Identifiant_publication, pub_date AS `Date`, pub_titre AS Titre, pub_contenu AS Contenu, nom_utilisateur
FROM publication p
INNER JOIN utilisateur u ON p.id=u.id
ORDER BY Titre;