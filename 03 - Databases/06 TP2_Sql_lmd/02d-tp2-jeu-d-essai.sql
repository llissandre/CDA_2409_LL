/*
Sous-langage : DML / MLD
Data Manipulation Language
Langage de Manipulation de Données

Principales instructions :
INSERT : Ajouter des nouvelles données dans une table
UPDATE : Mettre à jour des données existantes dans une table
DELETE : Supprimer des données existantes dans une table
TRUNCATE : Vider une table
*/

-- Sélectionner la base de données 
USE tp1;

INSERT INTO DEPT
(deptno, dname, loc)
VALUES
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

INSERT INTO EMP
(empno, ename, job, mgr, hiredate, sal, comm, deptno)
VALUES 
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-07-09', 2450, NULL, 10),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-04', 2975, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7788, 'SCOTT', 'ANALYST', 7566, '1982-12-09', 3000, NULL, 20),
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7876, 'ADAMS', 'CLERK', 7788, '1983-01-12', 1100, NULL, 20);