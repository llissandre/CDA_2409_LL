/*
REQUÊTES SQL Á IMPLÉMENTER 
Sous-langage : DQL / LRD
Data Query Language
Langage de requête sur les données

Principales instructions :
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/
use tp1;


/* --------------- */
/* PREMIERE PARTIE */
/* --------------- */

/* 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10 */
SELECT ename, job, empno, sal
FROM EMP;

SELECT ename, job, empno, sal
FROM EMP
WHERE deptno = 10;

/* 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800 */
SELECT ename, job, sal
FROM EMP
WHERE job = 'MANAGER' AND sal > 2800;

/* 3. Donner la liste des MANAGER n'appartenant pas au département 30 */
SELECT ename
FROM EMP
WHERE job = 'MANAGER' AND deptno != 30;

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
SELECT ename, dname, sal
FROM EMP e
JOIN DEPT d
ON e.deptno = d.deptno
WHERE job = (SELECT job FROM EMP WHERE ename = 'JONES') AND ename != 'JONES';

/* 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires */
SELECT ename, sal
FROM EMP
WHERE sal > (SELECT round(avg(sal)) FROM EMP);

SELECT round(avg(sal)) FROM EMP;

/* 18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes: 
	101, ALPHA, 96000
	102, BETA, 82000
	103, GAMMA, 15000 */
CREATE TABLE PROJET(
num_proj SMALLINT AUTO_INCREMENT PRIMARY KEY,
nom_proj CHAR(5) NOT NULL,
bud_proj DECIMAL(8,2) NOT NULL
);    

ALTER TABLE PROJET AUTO_INCREMENT=101;

INSERT INTO PROJET
(nom_proj, bud_proj)
VALUES
('ALPHA', 96000),
('BETA', 82000),
('GAMMA', 15000);
    
SELECT * FROM PROJET;
DROP TABLE PROJET;
TRUNCATE TABLE PROJET;

/* 19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102 */
ALTER TABLE EMP ADD num_proj SMALLINT;

UPDATE EMP
SET num_proj = 101
WHERE deptno = 30 AND job = 'SALESMAN';

UPDATE EMP
SET num_proj = 102
WHERE num_proj IS NULL;


/* UPDATE EMP
SET num_proj = 102
WHERE NOT deptno = 30 AND job = 'SALESMAN';

UPDATE EMP
SET num_proj = 102
WHERE deptno = 30 AND NOT job = 'SALESMAN';

UPDATE EMP
SET num_proj = 102
WHERE NOT deptno = 30 AND NOT job = 'SALESMAN'; */

SELECT *
FROM EMP;

/* 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet */
CREATE VIEW V_employes
AS SELECT ename, job, dname, nom_proj FROM EMP e 
JOIN DEPT d ON e.deptno = d.deptno
JOIN PROJET p ON e.num_proj = p.num_proj;

DROP VIEW V_employes;

/* 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet */
SELECT *
FROM V_employes
ORDER BY dname, nom_proj;

SELECT *
FROM EMP;

/* 22.Donner le nom du projet associé à chaque manager */
SELECT ename, nom_proj
FROM V_employes
WHERE job = 'MANAGER';


/* --------------- */
/* DEUXIEME PARTIE */
/* --------------- */

/* 1. Afficher la liste des managers des départements 20 et 30 */
SELECT ename, job
FROM EMP
WHERE job = 'MANAGER' AND deptno IN(20, 30);

/* 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81 */
SELECT ename
FROM EMP
WHERE job != 'MANAGER' AND YEAR(hiredate) = 1981;

/* 3. Afficher la liste des employés ayant une commission */
SELECT ename
FROM EMP
WHERE comm != 0 OR comm IS NOT NULL;

/* 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord. */
SELECT ename, deptno, job, hiredate
FROM EMP
ORDER BY deptno, job, hiredate DESC;

/* 5. Afficher la liste des employés travaillant à DALLAS */
SELECT ename
FROM EMP e
JOIN DEPT d
ON e.deptno = d.deptno
WHERE loc = 'DALLAS';

/* 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager. */
SELECT e.ename AS 'employé', e.hiredate, m.ename AS 'manager', m.hiredate
FROM EMP e
JOIN EMP m
ON e.mgr = m.empno
WHERE e.hiredate < m.hiredate;

/* 7. Lister les numéros des employés n'ayant pas de subordonné. */
SELECT m.empno, m.ename, m.job
FROM EMP m
LEFT JOIN EMP e
ON e.mgr = m.empno
WHERE e.empno IS NULL
ORDER BY job;

/* SELECT m.*, e.*
FROM EMP e
RIGHT JOIN EMP m
ON e.mgr = m.empno; */

/* 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE. */
SELECT ename, hiredate
FROM EMP
WHERE hiredate < (SELECT hiredate FROM EMP WHERE ename = 'BLAKE');

/* 9. Afficher les employés embauchés le même jour que FORD. */
SELECT ename
FROM EMP
WHERE hiredate = (SELECT hiredate FROM EMP WHERE ename = 'FORD') AND ename != 'FORD';

/* 10. Lister les employés ayant le même manager que CLARK. */
SELECT ename
FROM EMP
WHERE mgr = (SELECT mgr FROM EMP WHERE ename = 'CLARK') AND ename != 'CLARK';

/* 11. Lister les employés ayant même job et même manager que TURNER. */
SELECT ename
FROM EMP
WHERE mgr = (SELECT mgr FROM EMP WHERE ename = 'TURNER') AND ename != 'TURNER' AND job = (SELECT job FROM EMP WHERE ename = 'TURNER');

/* 12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES. */
SELECT ename, hiredate
FROM EMP e
JOIN DEPT d
ON e.deptno = d.deptno
WHERE dname = 'RESEARCH' AND hiredate IN(SELECT hiredate FROM EMP e JOIN DEPT d ON e.deptno = d.deptno WHERE dname = 'SALES');

/* Commande pour convertir la date au format français */ 
SET lc_time_names = 'fr_FR';

/* 13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche. */
SELECT ename, DATE_FORMAT(hiredate, '%a') AS 'Jour de la semaine'
FROM EMP;

/* 14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle. */
SELECT ename, ((year(now())-year(hiredate)) * 12 + month(now())-month(hiredate)) AS 'Nombre de mois écoulés'
FROM EMP;

/* 15. Afficher la liste des employés ayant un M et un A dans leur nom. */
SELECT ename
FROM EMP
WHERE ename LIKE '%M%' AND ename LIKE '%A%';

/* 16. Afficher la liste des employés ayant deux 'A' dans leur nom. */
SELECT ename
FROM EMP
WHERE ename LIKE '%A%A%';

/* 17. Afficher les employés embauchés avant tous les employés du département 10. */
SELECT ename
FROM EMP
WHERE hiredate < ALL(SELECT hiredate FROM EMP WHERE deptno = 10);

/* 18. Sélectionner le métier où le salaire moyen est le plus faible. */ -- !!!!
SELECT job AS 'Métiers', round(avg(sal)) AS 'Salaires moyens'
FROM EMP
GROUP BY job
HAVING round(avg(sal)) <= ALL (SELECT round(avg(sal)) FROM EMP GROUP BY job);

/* 19. Sélectionner le département ayant le plus d'employés. */
/* SELECT dname, count(dname) AS 'Nombre d\'employés'
FROM EMP e
JOIN DEPT d
ON e.deptno = d.deptno
GROUP BY dname; */

SELECT dname AS 'Département', count(dname) AS 'Nombre maximal d\'employés dans un département'
FROM EMP e
JOIN DEPT d
ON e.deptno = d.deptno
GROUP BY dname
HAVING count(dname) >= ALL (SELECT count(dname) FROM EMP e JOIN DEPT d ON e.deptno = d.deptno GROUP BY dname);
/* SELECT count(*) FROM EMP e JOIN DEPT d ON e.deptno = d.deptno GROUP BY dname; */

/* 20.Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous
	Département 	Répartition en %
	----------- 	----------------
	10 				21.43
	20 				35.71
	30 				42.86 */
SELECT deptno AS 'Département', round((count(empno) / (SELECT count(*) FROM EMP))*100, 2) AS 'Répartition en %'
FROM EMP
GROUP BY deptno;

/* SELECT count(*)
FROM EMP;

SELECT dname, count(dname) AS 'Nombre d\'employés'
FROM EMP e
JOIN DEPT d
ON e.deptno = d.deptno
GROUP BY dname; */

/* Quelques Fonctions SQL Server */
-- CONVERT: Effectue des conversion de types de données. Permet notamment le formatage de dates
-- SUBSTRING: Extrait une partie d'une chaîne de caractères
-- DATENAME, DATEDIFF …: Permet la manipulation de date
