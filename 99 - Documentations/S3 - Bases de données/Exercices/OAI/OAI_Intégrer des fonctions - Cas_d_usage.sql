-- OAI – Fonctions cas d'usage

-- 1)	Simuler une augmentation de 2,45% des salaires
-- a)	Afficher le salaire actuel, le salaire augmenté.
SELECT  ename, SAL AS 'Salaire actuel', SAL * 1.0245 AS 'Salaire augmenté' FROM EMP;

-- b)	Arrondir le résultat à 1 décimale
SELECT ename, SAL AS 'Salaire actuel', round(SAL * 1.0245, 1) AS 'Salaire augmenté' FROM EMP;

-- 2)	Calculer la moyenne des salaires 
-- a)	Arrondir le résultat à 2 décimales
SELECT ROUND(AVG(SAL),2) FROM EMP;

SELECT DEPTNO, AVG(SAL), ROUND(AVG(SAL),2) FROM EMP GROUP BY DEPTNO;

-- 3)	Comportement de fonction ROUND ? Comparaison avec TRUNC
SELECT ROUND(2.1,0), ROUND(2.4, 0), ROUND(2.5, 0), ROUND(2.6) FROM DUAL;

SELECT TRUNCATE(2.1,0), TRUNCATE(2.45, 1), TRUNCATE(2.564, 2), TRUNCATE(2.6124,3) FROM DUAL;

-- 4)	Afficher l'identifiant des employés en concaténant CDA4 et les 4 premières lettres de chaque nom (ex : CDA4BLAK)
SELECT concat ('CDA4', SUBSTR(ENAME, 1, 4)) AS IDENTIFIANT FROM EMP;

-- 5)	Afficher tous les employés dont le nom commence par la lettre A 
SELECT ENAME FROM EMP WHERE ENAME LIKE 'A%';

SELECT ENAME FROM EMP WHERE SUBSTR (ENAME, 1,1) = 'A';

-- 6)	Afficher la rémunération de tous les salariés (salaire + commission)
SELECT ENAME, SAL, SAL + COALESCE(COMM, 0) FROM EMP;

-- 7)	Afficher la liste des salariés avec leur commission ou 'Pas de commission'.
SELECT ENAME, SAL + COALESCE(COMM, 0), NVL(COMM, '******') AS COMMISSION FROM EMP;

-- 8)	Compter année par année, combien de personnes ont été embauchées.
select year(hiredate), count(ename) from EMP where extract(year from hiredate) group by year(hiredate)

