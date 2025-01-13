/*
REQUÊTES SQL Á IMPLÉMENTER 
Sous-langage : DQL / LRD
Data Query Language
Langage de requête sur les données

Principales instructions :
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/
use tp1;

/* Première partie */
/* 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10 */
SELECT ename, job, empno, sal
FROM EMP;

SELECT ename, job, empno, sal
FROM EMP
WHERE deptno = 20;

/* 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800 */
SELECT ename, job, sal
FROM EMP
WHERE job = 'MANAGER' AND sal > 2800;

/* 3. Donner la liste des MANAGER n'appartenant pas au département 30 */
SELECT ename
FROM EMP
WHERE job != 'MANAGER';

/* 4. Liste des employés de salaire compris entre 1200 et 1400 */
SELECT ename
FROM EMP
WHERE sal BETWEEN 1200 AND 1400;

/* 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique */
SELECT ename
FROM EMP
WHERE deptno IN(10, 30)
ORDER BY ename;

/* 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants */
SELECT ename, sal
FROM EMP
WHERE deptno=30
ORDER BY sal;

/* 7. Liste de tous les employés classés par emploi et salaires décroissants */
SELECT ename, job, empno, sal
FROM EMP
ORDER BY job DESC, sal DESC;

/* 8. Liste des différents emplois */
SELECT DISTINCT job
FROM EMP;

/* 9. Donner le nom du département où travaille ALLEN */
SELECT job
FROM EMP
WHERE ename = 'ALLEN';

/* 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants. */
SELECT dname, ename, job, sal, e.deptno
FROM EMP e
JOIN DEPT d
ON e.deptno = d.deptno
ORDER BY dname DESC, sal DESC;

/* 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions */
SELECT ename, sal, comm, sal + comm
FROM EMP
WHERE job = 'SALESMAN';

/* Commande pour convertir la date au format français */ 
SET lc_time_names = 'fr_FR';

/* 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997' */
SELECT ename, job, DATE_FORMAT(hiredate, '%a %e %b %Y') AS date
FROM EMP
WHERE deptno = 20;

/* 13. Donner le salaire le plus élevé par département */
SELECT max(sal)
FROM EMP;

/* 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi */
SELECT deptno, job, sum(sal) AS 'Masse salariale', count(deptno) AS 'Nombre d\'employés', round(avg(sal)) AS 'Salaire moyen'
FROM EMP
GROUP BY deptno, job
ORDER BY deptno;

/* 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés */
SELECT deptno, job, sum(sal) AS 'Masse salariale', count(deptno) AS 'Nombre d\'employés', round(avg(sal)) AS 'Salaire moyen'
FROM EMP
GROUP BY deptno, job
HAVING count(deptno) > 1
ORDER BY deptno;

/* 16. Liste des employés (Nom, département, salaire) de même emploi que JONES */
SELECT ename, deptno, sal
FROM EMP
WHERE job = (SELECT job FROM EMP WHERE ename = 'JONES');

/* 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires */
SELECT ename, sal
FROM EMP
WHERE sal > (SELECT round(avg(sal)) FROM EMP);

/* 18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes: 
	101, ALPHA, 96000
	102, BETA, 82000
	103, GAMMA, 15000 */
CREATE TABLE PROJET(
num_proj SMALLINT AUTO_INCREMENT PRIMARY KEY,
nom_proj CHAR(5) NOT NULL,
bud_proj DECIMAL(8,2) NOT NULL
);    

INSERT INTO PROJET
(nom_proj, bud_proj)
VALUES
('ALPHA', 96000),
('BETA', 82000),
('GAMMA', 15000);
    
/* 19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102 */
ALTER TABLE EMP ADD num_proj SMALLINT;

UPDATE EMP 
SET num_proj = 101
WHERE deptno = 30 AND job = 'SALESMAN';

UPDATE EMP 
SET num_proj = 102
WHERE deptno != 30;

/* 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet */
DROP VIEW V_employes;

/* CREATE VIEW employes AS SELECT ename, job, dname, e.num_proj, nom_proj FROM EMP e JOIN DEPT d ON e.deptno = d.deptno JOIN PROJET p ON e.num_proj = p.num_proj; */

CREATE VIEW V_employes
AS SELECT ename, job, dname, e.num_proj
FROM EMP e 
JOIN DEPT d ON e.deptno = d.deptno;

/* 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet */
SELECT *
FROM V_employes;

/* 22.Donner le nom du projet associé à chaque manager */


/* Deuxième partie */
/* 1. Afficher la liste des managers des départements 20 et 30 */
/* 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81 */
/* 3. Afficher la liste des employés ayant une commission */
/* 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord. */
/* 5. Afficher la liste des employés travaillant à DALLAS */
/* 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager. */
/* 7. Lister les numéros des employés n'ayant pas de subordonné. */
/* 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE. */
/* 9. Afficher les employés embauchés le même jour que FORD. */
/* 10. Lister les employés ayant le même manager que CLARK. */
/* 11. Lister les employés ayant même job et même manager que TURNER. */
/* 12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES. */
/* 13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche. */
/* 14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle. */
/* 15. Afficher la liste des employés ayant un M et un A dans leur nom. */
/* 16. Afficher la liste des employés ayant deux 'A' dans leur nom. */
/* 17. Afficher les employés embauchés avant tous les employés du département 10. */
/* 18. Sélectionner le métier où le salaire moyen est le plus faible. */
/* 19. Sélectionner le département ayant le plus d'employés. */
/* 20.Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous
	Département 	Répartition en %
	----------- 	----------------
	10 				21.43
	20 				35.71
	30 				42.86 */

/* Quelques Fonctions SQL Server */
-- CONVERT: Effectue des conversion de types de données. Permet notamment le formatage de dates
-- SUBSTRING: Extrait une partie d'une chaîne de caractères
-- DATENAME, DATEDIFF …: Permet la manipulation de date
