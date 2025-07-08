-- OAI – Sous requêtes

-- Q1 – Afficher le nom, la date d’embauche de tous les employés qui travaillent dans le même département que BLAKE (en excluant BLAKE).
select ename, hiredate from EMP where trim(upper(deptno = (select deptno from EMP where trim(upper(ename = 'blake'))) and ename <> 'blake'))

-- Q2 – Afficher le numéro et le nom de tous les employés qui ont un salaire supérieur à la moyenne. Trier les résultats par ordre de salaire décroissant.
select empno, ename, sal from EMP where sal > (select avg(sal) from EMP) order by sal desc

-- Q3 – Ecrire une requête qui affichera le numéro et le nom de tous les employés qui travaillent avec une personne dont le nom contient un T (dans le même département).
select empno, ename from EMP where deptno in (select deptno from EMP where ename like '%t%')
except
select empno, ename from EMP where ename like '%t%'

-- Q4 – Afficher le nom, le numéro de département, le poste de tous les employés dont la localisation du département est DALLAS.
select ename, deptno, job from EMP where deptno = (select deptno from DEPT where trim(upper(loc = 'dallas')))

-- Q5 – Afficher le nom et le salaire de tous les employés dont KING est directement responsable.
select w.ename, w.sal from EMP w join EMP m  on w.mgr = m.EMPNO where w.mgr = (select empno from EMP where trim(upper(ename)) ='king' )

-- Q6 – Afficher le numéro de département, le nom et le poste de tous les employés du département ventes : SALES.
select deptno, ename, job from EMP where deptno = (select deptno from DEPT d where trim(upper(dname = 'sales')))

-- Q7 – Modifier le requête de la question 3 pour afficher le numéro, le nom, le salaire de tous les employés dont le salaire est supérieur à la moyenne et qui travaillent avec une personne dont le nom contient un T.
select empno, ename, sal from EMP where sal > (select avg(sal) from EMP) and deptno in (select deptno from EMP where ename like '%t%')
except
select empno, ename, sal from EMP where ename like '%t%'

-- Q8 – Déterminez le nombre de personnes ayant des subordonnés, sans en donner la liste. 
-- v1 -
select count(*) from EMP where ename in
(select m.ename from EMP w join EMP m where w.mgr = m.empno)

-- v2 -
select count(*) from (select * from EMP except select * from EMP where ename not in (select m.ename from EMP w join EMP m where w.mgr = m.empno)) EMP

-- v3 -
select count(*) - (select count(*) from EMP where ename not in (select m.ename from EMP w join EMP m where w.mgr = m.empno)) from EMP
-- Contrainte : ne pas utiliser l'option DISTINCT dans la fonction COUNT.
