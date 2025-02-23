
-- Q1 – Affichez la structure de la table DEPT. Affichez le contenu de la table DEPT.
describe DEPT

select * from DEPT

-- Q2 – Affichez la structure de la table EMP. Créez une requête pour afficher le nom, le poste, la date d’embauche et le matricule de chaque employé, en plaçant le matricule en premier.
describe EMP

select empno, ename, job, hiredate from EMP  

-- Q3 – Créez une requête pour afficher les différents types de postes existants dans la table EMP.
select job from EMP

-- Q4 – Reprendre la requête Q2 en remplaçant les entêtes de colonnes par EMP#, Employé, Poste et date d’embauche.
select empno as 'EMP#', ename as 'Employé', job as Poste, hiredate as 'date d''embauche' from EMP  

-- Q5 – Affichez les départements et leurs postes. La requête ne doit pas avoir de doublons.
select distinct deptno, job from EMP order by deptno