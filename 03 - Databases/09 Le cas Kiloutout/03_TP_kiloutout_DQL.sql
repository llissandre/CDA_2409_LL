-- Requêtes SQL à implémenter

/* 1. Sélectionner l’adresse, le montant du loyer, le pourcentage aloué à l’agence des logements sous gestion. Les logements sont triés par loyer du plus cher au moins cher. */
SELECT bien_situation, bien_loyer_mensuel, contrat_pourcentage
FROM bien
NATURAL JOIN souscrire
NATURAL JOIN contrat
ORDER BY bien_loyer_mensuel DESC;

/* 2. Sélectionner les logements qui sont loués avec pour chaque logement loué : */
/* a. L’adresse du logement et le montant du loyer */
SELECT bien_situation, bien_loyer_mensuel
FROM bien
NATURAL JOIN bail;

/* b. le nom et prénom du propriétaire */
SELECT proprietaire_nom, proprietaire_prenom
FROM proprietaire
NATURAL JOIN bien
NATURAL JOIN bail;

/* c. le nom, prénom et numéro de téléphone du locataire */
SELECT locataire_nom, locataire_prenom
FROM bien
NATURAL JOIN bail
NATURAL JOIN locataire;

/* d. La période de location */
SELECT bail_duree AS 'Durée du bail de location en mois', bail_date_debut AS 'Date de début du bail de location', concat((year(bail_date_debut) + round(bail_duree/12)),'-', month(bail_date_debut), '-', day(bail_date_debut)) AS 'Date de fin du bail de location'
FROM bien
NATURAL JOIN bail;

/* Note :
o les logements non loués ne doivent pas aparaitre dans les résultats !
o Les logements sont triés par date de démarrage du bail (ordre croissant) */


/* 3. Sélectionner toutes les informations des propriétaires avec, pour chaque propriétaire : */
/* a. Le nombre de logements qui lui appartiennent */
SELECT proprietaire_nom, proprietaire_prenom, count(bien_id)
FROM bien
NATURAL JOIN proprietaire
GROUP BY proprietaire_id;

/* b. Le montant total des loyers de ces logements (loués ou non). */
SELECT proprietaire_nom, proprietaire_prenom,
sum(bi.bien_loyer_mensuel) AS 'Montant total loyers mensuels des biens'
FROM bien bi
NATURAL JOIN proprietaire
LEFT JOIN bail ba ON bi.bien_id = ba.bien_id
GROUP BY proprietaire_id;

-- PROCEDURE STOKEE OU DECLENCHEUR SQL A IMPLEMENTER
/* Lors de la dernière réunion avec le client, il a été décidé qu’un propriétaire ne peut mettre sous gestion de l’agence que des logements dont le loyer est strictement inférieur à 2000€ / mois.
Lors de l’insertion d’un logement, cette limite doit obligatoirement être vérifiée par le SGBD. Si le loyer dépasse 2000€, le logement ne doit pas être inséré.
Implémenter une procédure stockée OU un déclencheur (à vous de décider) implémentant cette vérification.

Pour tester la vérification, vous devez essayer d’ajouter ces 2 logements (pour l’un des 2, l’insertion doit être refusée) :
Mr DEV Mike (637 rue Jean Jaurès 59690 Vieux-Condé ; 06.02.03.04.05) est propriétaire de deux
logement et donne gestion à l’agence pour 20 ans
- 1er logement (appartement)
o Situation : 23 rue des Macarons 68100 Mulhouse
o Surface : 30 m²
o Loyer mensuel : 320 €
o Pourcentage du loyer pour l’agence : 6%
- 2nd logement (maison)
o Situation : 97 rue de la frangipane 68270 Wittenheim
o Surface : 205 m²
o Loyer mensuel : 2050 €
o Pourcentage du loyer pour l’agence : 3%
Les 2 logements ne sont pas loués*/

-- creation du message d'erreur personnalisé qui sera affiché
CREATE TABLE Erreur (
id TINYINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
erreur VARCHAR(255) UNIQUE);

-- création du trigger sur la table projets
DELIMITER |
 CREATE TRIGGER before_insert_bien
 BEFORE INSERT
 ON bien FOR EACH ROW
 BEGIN
	IF 
	NEW.bien_loyer_mensuel IS NOT NULL
	AND
    NEW.bien_loyer_mensuel > 2000
 THEN
	INSERT INTO Erreur 
	(erreur) 
	VALUES
	('Erreur : Le montant du loyer dépasse 2000 euros !');
END IF;
END |
DELIMITER ;

-- test du déclenchement du trigger à l'insertion pour un loyer supérieur à 2000 euros
INSERT INTO proprietaire
(proprietaire_nom, proprietaire_prenom, proprietaire_adresse, proprietaire_telephone)
VALUES
("Dev", "Mike", "637 rue Jean Jaurès 59690 Vieux-Condé", "06.02.03.04.05");

INSERT INTO bien
(bien_situation, bien_surface, bien_loyer_mensuel, type_de_bien_id, proprietaire_id)
VALUES
("23 rue des Macarons 68100 Mulhouse", 30, 320, 2, 4),
("97 rue de la frangipane 68270 Wittenheim", 205, 2050, 1, 4);