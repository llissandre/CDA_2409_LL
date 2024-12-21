/*
REQUÊTES SQL Á IMPLÉMENTER 
Sous-langage : DQL / LRD
Data Query Language
Langage de requête sur les données

Principales instructions :
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/

/* 1. Sélectionner tous les utilisateurs (nom d'utilisateur + email) */
SELECT nom_utilisateur, email
FROM utilisateur;

/* 2. Sélectionner toutes les publications (titre, date, contenu, id utilisateur) triées par date de la plus récente à la plus ancienne. */
SELECT pub_titre AS Titre, pub_date AS Date, pub_contenu AS Contenu, id AS Identifiant_utilisateur
FROM publication
ORDER BY Date DESC;

/* 3. Sélectionner les publications (pub_id, date, titre) de l'utilisateur N°2. */
SELECT pub_id AS Identifiant_publication, pub_date AS Date, pub_titre AS Titre
FROM publication
WHERE id = 2;

/* 4. Sélectionner les publications (pub_id, titre, contenu) dont le titre contient la lettre "a". Le résultat est trié par le titre et par ordre décroissant. */
SELECT pub_id AS Identifiant_publication, pub_titre AS Titre, pub_contenu AS Contenu
FROM publication
WHERE pub_titre LIKE "%a%"
ORDER BY Titre DESC;

/* 5. Sélectionner les utilisateurs (id, nom, email) dont l'adresse email se termine par "com". */
SELECT id AS Identification_utilisateur, nom_utilisateur, email 
FROM utilisateur
WHERE email LIKE "%com";

/* 6. Sélectionner les publications triées par titre (ordre alphabétique) avec le nom de l'utilisateur (nécessite une jointure). */
SELECT pub_id AS Identifiant_publication, pub_date AS Date, pub_titre AS Titre, pub_contenu AS Contenu, nom_utilisateur
FROM publication p
JOIN utilisateur u ON p.id=u.id
ORDER BY Titre;