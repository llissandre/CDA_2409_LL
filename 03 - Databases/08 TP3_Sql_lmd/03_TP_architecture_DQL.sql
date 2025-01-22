/*
REQUÊTES SQL Á IMPLÉMENTER 
Sous-langage : DQL / LRD
Data Query Language
Langage de requête sur les données

Principales instructions :
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/

USE db_architecte;

/* Pour commencer l'entrainement  à l'ECF BDD MERISE  voici un TP à faire. (pour les CDA et les DWWM )
Avec les 2 scripts suivant vous installerez une base de données : "db_architecte"  avec un certain nombre de tables en relation.
Et vous y ajouterez un jeu de données à l'aide du 2ème fichiers SQL ( 02_TP_architecture_DML). 
Ensuite vous réaliserez les requêtes suivantes :  */

/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' */
SELECT client_ref, client_nom FROM clients WHERE client_telephone LIKE '04%';

/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers */
SELECT client_ref, client_nom FROM clients c NATURAL JOIN type_clients t WHERE type_client_libelle = 'Particulier';

/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers */
SELECT client_ref, client_nom FROM clients c NATURAL JOIN type_clients t WHERE type_client_libelle != 'Particulier';

/* 4. Sélectionner les projets qui ont été livrés en retard */
SELECT * FROM projets WHERE  projet_date_fin_effective > projet_date_fin_prevue;

/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets avec le nom du client et 
le nom de l'architecte associés au projet */
SELECT projet_date_depot, projet_date_fin_prevue, projet_superficie_totale, projet_superficie_batie, projet_prix, client_nom, emp_nom
FROM projets p 
JOIN clients c ON c.adresse_id = p.adresse_id
JOIN employes e ON e.emp_matricule = p.emp_matricule
JOIN fonctions f ON e.fonction_id = f.fonction_id
WHERE fonction_nom = 'Architecte'
ORDER BY projet_ref;

/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte */
SELECT projet_date_depot, projet_date_fin_prevue, projet_superficie_totale, projet_superficie_batie, projet_prix, count(pa.emp_matricule)
FROM projets p
JOIN participer pa ON pa.projet_ref = p.projet_ref
JOIN employes e ON e.emp_matricule = pa.emp_matricule
JOIN fonctions f ON e.fonction_id = f.fonction_id
GROUP BY pa.projet_ref, projet_date_depot, projet_date_fin_prevue, projet_superficie_totale, projet_superficie_batie, projet_prix
HAVING 'Architecte' NOT IN (SELECT DISTINCT fonction_nom FROM fonctions f NATURAL JOIN employes e NATURAL JOIN participer p)
ORDER BY pa.projet_ref;

/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué */
SELECT type_projet_id, type_projet_libelle, Count(p.type_projet_id), avg(projet_prix) FROM type_projets t
NATURAL JOIN projets p;

/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande */


/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. */


/* 10. Sélectionner les projets dont l'adresse est identique au client associé */
