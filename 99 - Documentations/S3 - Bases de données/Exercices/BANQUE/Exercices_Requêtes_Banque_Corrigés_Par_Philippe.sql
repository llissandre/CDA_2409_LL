
-- Affecter à chaque compte comme date d'ouverture, la date de sa première opération

-- opération la plus vielle pour le compte 'LI00000003'
SELECT MIN(dateOpe)
FROM OPERATION
WHERE OPERATION.numCpt = 'LI00000003';


-- opération la plus vielle pour le compte 'CC00000001'
SELECT MIN(dateOpe)
FROM OPERATION
WHERE OPERATION.numCpt = 'CC00000001';

UPDATE COMPTE
SET COMPTE.dateOuvCpt = (
							SELECT MIN(dateOpe)
							FROM OPERATION
							WHERE OPERATION.numCpt = 'CC00000001'
						)
WHERE COMPTE.numCpt = 'CC00000001';



-- Mise à jour date ouverture de tous les comptes
UPDATE COMPTE
SET COMPTE.dateOuvCpt = (
							SELECT MIN(dateOpe)
							FROM OPERATION
							WHERE OPERATION.numCpt = COMPTE.numCpt 
						);
-- WHERE COMPTE.numCpt = 'CC00000001';


							
SELECT *, (SELECT MIN(dateOpe) FROM OPERATION WHERE OPERATION.numCpt = COMPTE.numCpt) as datePremiereOperation
FROM COMPTE;

UPDATE COMPTE
SET COMPTE.dateOuvCpt = (SELECT MIN(dateOpe) FROM OPERATION WHERE OPERATION.numCpt = COMPTE.numCpt);


-- Corriger erreurs des montants sur les dépots: ils sont négatifs il faut les passer en positif
UPDATE OPERATION
SET montantOpe = montantOpe * -1
WHERE codeTypeOpe = 'DEP';


-- Calculer et affecter à chaque compte son solde 

-- solde d'un compte = somme du montant de toutes les opérations
SELECT SUM(montantOpe)
FROM OPERATION
WHERE OPERATION.numCpt = 'LI00000003';

UPDATE COMPTE
SET soldeCpt  = (
					SELECT SUM(montantOpe)
					FROM OPERATION
					WHERE OPERATION.numCpt = COMPTE.numCpt 
				)
;


-- Quel compte a le plus grand nombre d'opérations

SELECT numCpt, count(*) 
FROM OPERATION
GROUP BY numCpt
ORDER BY count(*) DESC 
LIMIT 1;


SELECT numCpt, count(*) 
FROM OPERATION
GROUP BY numCpt
-- on ne garde que les groupe pour lesquels le nombre de ligne est égal au maximum
HAVING count(*) = ( 
					SELECT count(*) 
					FROM OPERATION
					GROUP BY numCpt
					ORDER BY count(*) DESC 
					LIMIT 1
				);

		
-- version trop complexe et pas indispensable			
SELECT numCpt, count(*) 
	  FROM OPERATION
	  GROUP BY numCpt
	  HAVING count(*) =			
		(SELECT max(nbOperation)
			FROM (	SELECT numCpt, count(*) nbOperation
				FROM OPERATION
				GROUP BY numCpt) opeRegroupee
		)
;

			


SELECT numCpt, count(*) 
	  FROM OPERATION
	  GROUP BY numCpt
	  HAVING count(*) =
		( SELECT max(nbOperation) FROM
			( SELECT numCpt, count(*) nbOperation
	  		  FROM OPERATION
	  		  GROUP BY numCpt
			) opeRegroupees
		)
;

-- Afficher le solde de tous les comptes au 31/01/2021
SELECT numCpt, SUM(montantOpe), '31/01/2021' 
FROM OPERATION
WHERE dateOpe < '2021-02-01'
GROUP BY numCpt
ORDER BY numCpt;


SELECT numCpt, SUM(montantOpe), '31/01/2021' 
FROM OPERATION
WHERE numCpt = parametre_Compte AND dateOpe <= parametre_datelimite



-- Afficher tous les mouvements entre le 01/03/2020 et le 30/06/2020
SELECT *
FROM OPERATION
WHERE dateOpe BETWEEN '2020-03-01' AND '2020-06-30'
ORDER BY dateOpe;

-- Quel(s) client(s) a (ont) le plus gros solde au 31/01/2021

-- calcul du solde de tous les clients au 31/01/2021
SELECT TITULAIRE.numTit , TITULAIRE.nomTit , SUM(montantOpe)
FROM OPERATION
INNER JOIN COMPTE ON OPERATION.numCpt = COMPTE.numCpt
INNER JOIN TITULAIRE ON COMPTE.numTit = TITULAIRE.numTit
WHERE dateOpe < '2021-02-01'
GROUP BY TITULAIRE.numTit , TITULAIRE.nomTit;

-- Sélection du plus gros solde de tous les clients au 31/01/2021
SELECT TITULAIRE.numTit , TITULAIRE.nomTit , SUM(montantOpe)
FROM OPERATION
INNER JOIN COMPTE ON OPERATION.numCpt = COMPTE.numCpt
INNER JOIN TITULAIRE ON COMPTE.numTit = TITULAIRE.numTit
WHERE dateOpe < '2021-02-01'
GROUP BY TITULAIRE.numTit , TITULAIRE.nomTit
ORDER BY SUM(montantOpe) DESC
LIMIT 1;


SELECT TITULAIRE.numTit , TITULAIRE.nomTit , SUM(montantOpe)
FROM OPERATION
INNER JOIN COMPTE ON OPERATION.numCpt = COMPTE.numCpt
INNER JOIN TITULAIRE ON COMPTE.numTit = TITULAIRE.numTit
WHERE dateOpe < '2021-02-01'
GROUP BY TITULAIRE.numTit , TITULAIRE.nomTit
HAVING SUM(montantOpe) = (
		-- sole le plus élevé au 31/01/2021
		SELECT SUM(montantOpe)
		FROM OPERATION
		INNER JOIN COMPTE ON OPERATION.numCpt = COMPTE.numCpt
		INNER JOIN TITULAIRE ON COMPTE.numTit = TITULAIRE.numTit
		WHERE dateOpe < '2021-02-01'
		GROUP BY TITULAIRE.numTit , TITULAIRE.nomTit
		ORDER BY SUM(montantOpe) DESC
		LIMIT 1
);


-- Quels titulaires n'ont pas de compte dans la banque
SELECT * FROM
TITULAIRE LEFT JOIN COMPTE ON COMPTE.numTit = TITULAIRE.numTit
WHERE COMPTE.numCpt IS NULL;

SELECT nomTit , numTit
FROM TITULAIRE 
WHERE numTit NOT IN (SELECT numtit FROM COMPTE);

SELECT nomTit , numTit
FROM TITULAIRE 
WHERE NOT EXISTS (SELECT 1 FROM COMPTE WHERE COMPTE.numTit = TITULAIRE.numTit);


-- Enregistrer un dépôt de 1000 sur le compte courant du titulaire n° '00001'

-- 	* recherche du compte courant du titulaire 00001
	SELECT * 
	FROM COMPTE
	WHERE numTit = '00001' AND codeTypeCpt = 'COC';

-- * enregistrement du dépot : opération de dépôt sur le compte
	
-- IL n'est pas autorisé par MYSQL dans une requête de lire une table qui sera modifiée par le trigger
-- On a donc dû utiliser une table temporaire pour stocker le résultat à utiliser

	CREATE TEMPORARY TABLE IF NOT EXISTS TempTableNumCPT AS (SELECT numCpt FROM COMPTE WHERE numTit = '00001' AND codeTypeCpt = 'COC');
	
    SELECT * FROM 	TempTableNumCPT;

	INSERT
	INTO OPERATION
	(description, montantOpe , numCpt, codeTypeOpe)
	VALUES ('Dépôt 1000€ sur le comte', 1000, (SELECT numCpt FROM TempTableNumCPT), 'DEP')
	;

	DROP TABLE TempTableNumCPT;


-- Ajout de comptes de type CAD pour tous les titulaires
INSERT INTO TYPECPT VALUES('CAD', 'Cadeau');

SELECT CONCAT('CA000', numTit), null, numTit , 'CAD', 0 
FROM TITULAIRE;

INSERT INTO COMPTE 
SELECT CONCAT('CA000', numTit), null, numTit , 'CAD', 0 FROM TITULAIRE WHERE numTit <> '00007';

DELETE 
FROM COMPTE 
WHERE numCpt IN (SELECT CONCAT('CA000', numTit) FROM TITULAIRE WHERE numTit <> '00007');

INSERT INTO COMPTE 
SELECT CONCAT('CA000', numTit), sysdate(), numTit , 'CAD', 0 FROM TITULAIRE WHERE numTit <> '00007';



-- Enregistrer un virement de 333 du compte CO00000008 vers le compte CO00000002
-- on utilise une transaction car on doit faire plusieurs opérations et toutes doivent réussir pour garantir l'intégrité
SET AUTOCOMMIT = false;
START TRANSACTION;

-- débit du compte 8
INSERT INTO OPERATION (description, montantOpe , numCpt, codeTypeOpe)
	VALUES ('Virement vers CO00000002', -333, 'CO00000008' , 'VIR');

-- crédit du compte 2
INSERT INTO OPERATION (description, montantOpe , numCpt, codeTypeOpe)
	VALUES ('Virement en provenance du CO00000008', 333, 'CO00000002' , 'VIR');

COMMIT;


-- Le client 00002 quitte la banque, il vient fermer tous ses comptes. il faut donc supprimer de notre Bdd ce titulaire et tous ses comptes

-- comptes du client 00002
SELECT numCpt 
FROM COMPTE
WHERE numTit = '00002';


-- on doit supprimer en tenant compte des dépendances donc l'ordre sera : OPERATION, COMPTE, TITULAIRE

START TRANSACTION; 

CREATE TEMPORARY TABLE IF NOT EXISTS TempTableNumCPT002 AS (
															SELECT numCpt 
															FROM COMPTE
															WHERE numTit = '00002'
);

-- Suppression des opérations des comptes du client 00002
DELETE 
FROM OPERATION
WHERE numCpt IN (SELECT numCPT FROM TempTableNumCPT002);

-- Suppression des comptes du client 00002
DELETE
FROM COMPTE
WHERE numTit = '00002';

-- Suppression du client 00002
DELETE
FROM TITULAIRE 
WHERE numTit = '00002';

DROP TABLE TempTableNumCPT002;

COMMIT;


/*
SELECT numCpt , sum(montantOpe)
FROM OPERATION
WHERE numCpt IN (SELECT numCpt 
				FROM COMPTE
				WHERE numTit = '00002'
				)
group by numCpt;
*/

-- lignes pour solder tous les comptes du titulaire 2
SELECT null, null, 'SOLDE CPT', numCpt, - soldeCpt, CASE WHEN soldeCpt > 0 THEN 'RET' ELSE 'DEP' END 
FROM COMPTE
WHERE numTit = '00002';


-- C'est la fête la banque remet à 0 à ses frais tous les comptes qui ont un solde négatif : (enregistrement automatique d'un dépôt équivalent au découvert)
-- il faut enregistrer des opération de dépôt avec les montant permettant d'équilibrer les comptes négatif

-- lignes conformes à la table opération pour solder les comptes en solde négatif

CREATE TEMPORARY TABLE IF NOT EXISTS TempTableSoldeCPt AS (
		SELECT null as numeroOperationSolde, null dateOperationSolde, 'Erreur de la banque en votre faveur' as descriptionOperationSolde, - soldeCpt, numCpt, 'DEP' FROM COMPTE WHERE soldeCpt < 0 or true);

SELECT * FROM TempTableSoldeCPt;	
	
-- ajout de ces lignes en tant qu'opération
INSERT INTO OPERATION 
(SELECT * FROM TempTableSoldeCPt)
;

DROP TABLE TempTableSoldeCPt;

COMMIT;

UPDATE OPERATION 
SET dateOpe = SYSDATE()
WHERE dateOpe IS NULL;



-- Présenter la liste des opération sous la forme
-- N°, Date, n° compte, DEBIT, CREDIT    (DEBIT montant si négatif sinon vide, CREDIT montant si négatif sinon vide)

SELECT numOpe as "N°", dateOpe as "DATE OPERATION", numCpt  as "N° COMPTE", 
					CASE WHEN montantOpe  < 0 THEN montantOpe ELSE 0 END AS "DEBIT" ,  
					CASE WHEN montantOpe  >= 0 THEN montantOpe ELSE 0 END AS "CREDIT"
FROM OPERATION;




