
-- Q1 – Afficher le nom, le numéro de département et le nom du département de tous les employés
select ename, e.deptno, d.dname from EMP e inner join DEPT d on e.deptno = d.deptno

-- Q2 - Afficher les différents postes du département 30 plus le nom du département. Vous prendrez le soin d’éliminer les postes en double
-- v1 Version après la jointure
select distinct job, dname from EMP e inner join DEPT d on e.deptno = d.deptno where e.deptno = 30

-- v2 Version dans la jointure
select distinct job, dname from EMP e inner join DEPT d on e.deptno = d.deptno and e.deptno = 30

-- Q3 - Créez une requête destinée à afficher le nom, le nom du département et la localisation de tous les employés qui touchent une commission
select ename, dname, loc from EMP e inner join DEPT d on e.deptno = d.deptno where comm is not null

-- Q4 - Afficher le nom, le nom du département pour tous les employés dont le nom contient la lettre A
select ename, dname from EMP e inner join DEPT d on e.deptno = d.deptno where ename like '%A%'

-- Q5 - Afficher le nom, le poste, le numéro et le nom du département de tous les employés basés à DALLAS
select ename, job, e.deptno, dname, loc from EMP e inner join DEPT d on e.deptno = d.deptno where loc = 'DALLAS'

-- Q6 - Afficher le nom, le matricule de chaque employé complété du nom et du matricule de son manager. Nommez les colonnes Employé, #Emp, Manager, #Manager respectivement
select w.ename as 'Nom employé', w.empno as '#employé', m.ename as 'Nom manager', m.empno as '#manager' from EMP w inner join EMP m on w.mgr=m.empno

-- Q7 -  Modifiez la requête précédente pour afficher tous les employés, y compris King, qui n’a pas de manager
-- v1 version avec left join
select w.ename as 'Nom employé', w.empno as '#employé', m.ename as 'Nom manager', m.empno as '#manager' from EMP w left outer join EMP m on w.mgr=m.empno

-- v2 version avec right join
select w.ename as 'Nom employé', w.empno as '#employé', m.ename as 'Nom manager', m.empno as '#manager' from EMP m right outer join EMP w on w.mgr=m.empno

-- Q8 - Créez une requête destinée à afficher le nom d’employé, le poste, le nom du département, le salaire et le grade de tous les employés
select ename, job, dname, sal, grade from EMP e join DEPT d on e.deptno = d.deptno inner join SALGRADE s on sal between losal and hisal

-- Q9 - Afficher le numéro de département et le nom de tous les employés qui travaillent dans le même département qu’un autre employé. Donnez à chaque colonne un entête approprié «Numéro de département», «Nom employé», «Nom collègue»
select e.deptno as 'Numéro de département', e.ename as 'Nom employé', c.ename as 'Nom collègue' from EMP e inner join EMP c where e.ename <> c.ename and e.deptno = c.deptno order by e.deptno, e.ename

-- Q10 - Créez une requête destinée à afficher le nom, et la date d’embauche de tous les employés arrivés avant l’employé dont le nom est BLAKE. Trier les lignes sur la date d’embauche
-- v1 extraction date par une première requête
select hiredate from EMP where ename = 'BLAKE'

select ename, hiredate from EMP where hiredate < '1981-05-01'

-- v2 jointure de chaque ligne employé avec la ligne employé de BLAKE
select e.ename, e.hiredate from EMP e inner join EMP b on b.ename = 'BLAKE' where e.hiredate < b.hiredate order by e.hiredate

-- v3 sous-requête pour obtenir la date d'embauche de BLAKE
select ename, hiredate from EMP where hiredate < (select hiredate from EMP where ename = 'BLAKE') order by hiredate

-- Q11 - Afficher le nom, la date d’embauche des employés et de leur manager, pour tous les employés ayant été embauchés avant leur manager. Renommez les colonnes pour les différencier
select w.ename as 'Nom employé', w.hiredate as 'Date d''embauche employé', m.hiredate as 'Date d''embauche manager' from EMP w inner join EMP m on w.mgr=m.empno where w.hiredate < m.hiredate

