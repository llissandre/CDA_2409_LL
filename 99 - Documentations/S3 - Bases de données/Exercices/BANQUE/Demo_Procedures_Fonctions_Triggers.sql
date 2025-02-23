

-- -----------------------------------------------
--  Fonction solde compte à date
-- ------------------------------------------------
DROP FUNCTION IF EXISTS soldeADate;

-- Création d'une procédure pour effectuer les virements
DELIMITER $$
CREATE FUNCTION soldeADate(_cpt CHAR(10), _dateSolde Datetime)
RETURNS decimal(7,2)
BEGIN
	declare soldeResultat decimal(7,2);

	IF (_dateSolde IS NULL) THEN
		SET _dateSolde = sysdate();
	END IF;
	
	SELECT sum(montantOpe)
	INTO soldeResultat
	FROM OPERATION WHERE OPERATION.numCpt = _cpt  AND OPERATION.dateOpe <=_dateSolde limit 1;

	-- COALESCE retourne la première valeur non nulle de ses paramètres
	RETURN COALESCE(soldeResultat, 0);

END $$
DELIMITER ;

SELECT *, soldeADAte(COMPTE.numCpt, '2021-01-31') as soldeCalcule FROM COMPTE;

SELECT *, soldeADAte(COMPTE.numCpt, null) as soldeCalcule FROM COMPTE WHERE soldeADAte(COMPTE.numCpt, null) <> soldeCpt ;


-- -----------------------------------------------
--  Procédure pour effectuer un virement
-- ------------------------------------------------

DROP PROCEDURE IF EXISTS faireVirement;

-- Création d'une procédure pour effectuer les virements
DELIMITER $$
CREATE PROCEDURE faireVirement(_cptOrigine CHAR(10), _cptDestination CHAR(10), _montant decimal(7,2))
BEGIN
	
	INSERT INTO OPERATION 
	(description, montantOpe, numCpt, codeTypeOpe)
	VALUES (CONCAT('virement ', _montant, ' vers ', _cptDestination), -1 * _montant, _cptOrigine, 'VIR');

-- 	UPDATE COMPTE SET COMPTE.soldeCpt = COMPTE.soldeCpt - _montant WHERE numCpt = _cptOrigine;

	INSERT INTO OPERATION 
	(description, montantOpe, numCpt, codeTypeOpe)
	VALUES (CONCAT('virement ', _montant, ' de ', _cptOrigine), _montant, _cptDestination, 'VIR');
	
-- 	UPDATE COMPTE SET COMPTE.soldeCpt = COMPTE.soldeCpt + _montant WHERE numCpt = _cptDestination;

END $$
DELIMITER ;

-- appel de la procédure faireVirement
-- CALL faireVirement('CO00000007', 'CO00000010', 432);


-- -----------------------------------------------
--  Trigger pour maintenir le solde
-- ------------------------------------------------

DROP TRIGGER IF EXISTS majSolde_afterInsert_OPERATION;

DELIMITER $$
CREATE TRIGGER majSolde_afterInsert_OPERATION AFTER INSERT ON OPERATION
     FOR EACH ROW 
     BEGIN
         UPDATE COMPTE
         SET COMPTE.soldeCpt = COMPTE.soldeCpt + NEW.montantOpe
         WHERE COMPTE.numCpt = NEW.numCpt;
     END;
$$
DELIMITER ;


DROP TRIGGER IF EXISTS majSolde_afterUpdate_OPERATION;

DELIMITER $$
CREATE TRIGGER majSolde_afterUpdate_OPERATION AFTER UPDATE  ON OPERATION
     FOR EACH ROW 
     BEGIN
	     -- annulation ancienne opération
         UPDATE COMPTE
         SET COMPTE.soldeCpt = COMPTE.soldeCpt - OLD.montantOpe
         WHERE COMPTE.numCpt = OLD.numCpt;

       	 -- affectation nouvelle opération
         UPDATE COMPTE
         SET COMPTE.soldeCpt = COMPTE.soldeCpt + NEW.montantOpe
         WHERE COMPTE.numCpt = NEW.numCpt;

        END;
$$
DELIMITER ;


DROP TRIGGER IF EXISTS majSolde_afterDelete_OPERATION;

DELIMITER $$
CREATE TRIGGER majSolde_afterDelete_OPERATION AFTER DELETE  ON OPERATION
     FOR EACH ROW 
     BEGIN
         UPDATE COMPTE
         SET COMPTE.soldeCpt = COMPTE.soldeCpt - OLD.montantOpe
         WHERE COMPTE.numCpt = OLD.numCpt;
     END;
$$
DELIMITER ;

/*
UPDATE OPERATION SET montantOpe = 332 WHERE numOpe = 2150;

DELETE FROM OPERATION WHERE numCpt = 'LI00000001';


INSERT INTO OPERATION 
(montantOpe, numCpt, codeTypeOpe)
VALUES (55, 'LI00000001', 'DEP' );


