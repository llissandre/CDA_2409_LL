
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


-- Quel compte a le plus grand nombre d'opérations


-- Afficher le solde de tous les comptes au 31/01/2021


-- Afficher tous les mouvements entre le 01/03/2020 et le 30/06/2020


-- Quel(s) client(s) ont le plus gros solde au 31/01/2021


-- Enregistrer un dépôt de 1000 sur le compte courant du titulaire n° '00001'

-- Enregistrer un virement de 333 du compte CO00000008 vers le compte CO00000002

-- Le client 00002 quite la banque, il vient fermer tous ses comptes. il faut donc le supprimer de notre Bdd lui et tous ses comptes








