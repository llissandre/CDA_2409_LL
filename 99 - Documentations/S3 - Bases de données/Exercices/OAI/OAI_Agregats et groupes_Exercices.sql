-- Q1 – Affichez le salaire maximum, le salaire minimum, la somme des salaires et le salaire moyen de tous les employés. Renommez les colonnes
select max(sal) as 'Salaire maximum', min (sal) as 'Salaire minimum', sum(sal) as 'Somme des salaires', avg(sal) as 'Salaire moyen' from EMP

-- Q2 – Modifiez la requête précédente, pour afficher les mêmes informations, mais pour chaque type de poste.
select job as Emploi, count(*) as 'Nombre d''employé', max(sal) as 'Salaire maximum', min (sal) as 'Salaire minimum', sum(sal) as 'Somme des salaires', avg(sal) as 'Salaire moyen' from EMP group by job

-- Q3 – Afficher le nombre de personnes qui occupent le même poste.
select job as Emploi, count(*) as 'Nombre employés' from EMP group by job

-- Q4  – Déterminez le nombre de personnes ayant des subordonnés, sans en donner la liste.
select count(distinct mgr) from EMP

-- Q5 – Afficher la différence entre le salaire maximum, et le salaire minimum. Nommez la colonne Différence.
select max(sal)-min(sal) as 'Différence' from EMP 

select min(sal) as 'Salaire minimum', max(sal) as 'Salaire maximum', max(sal)-min(sal) as 'Différence' from EMP 

--  Q6 – Ecrire cette requête par étape :
--  afficher le matricule des différents chefs de service et le salaire minimum de leurs employés
select mgr, min(sal) from EMP group by mgr

-- 	exclure ensuite toute ligne où le manager n’est pas identifié
select mgr, min(sal) from EMP where mgr is not null group by mgr

select mgr, min(sal) from EMP group by mgr having mgr is not null

--  exclure tout groupe dans lequel le salaire minimum est inférieur à 1000
select mgr, min(sal) from EMP group by mgr having mgr is not null and min(sal) > 1000

-- 	enfin trier les résultats par ordre décroissant des minima de salaires.
select mgr, min(sal) from EMP group by mgr having mgr is not null and min(sal) > 1000 order by min(sal) desc

-- Q7 - Afficher département par département, le nom du département, la localisation, le nombre d’employés et le salaire moyen des employés du département.
select dname as 'Nom du département', loc 'Localisation du département', count(empno) as 'Nombre d''employé', avg(sal) as 'Salaire moyen' from EMP e inner join DEPT d on e.deptno = d.deptno group by e.deptno, dname

-- Q6 bis – Reprendre la question 6 pour afficher aussi le nom du manager
select m.job, m.empno as '#manager',m.ename as 'Nom manager',min(w.sal) as 'Salaire minimum employé' from EMP w join EMP m on w.mgr=m.empno group by w.mgr, m.ename having mgr is not null and min(w.sal) > 1000 order by min(w.sal) desc

select w.mgr, m.empno as '#manager',m.ename as 'Nom manager',min(w.sal) as 'Salaire minimum employé' from EMP w join EMP m on w.mgr=m.empno where w.mgr is not null group by w.mgr, m.ename having min(w.sal) > 1000 order by min(w.sal) desc

-- Q8 – Même requête en ne prenant en compte que les salariés qui ne sont pas PRESIDENT ou MANAGER.
select w.job, m.empno as '#manager',m.ename as 'Nom manager',min(w.sal) as 'Salaire minimum employé' 
from EMP w join EMP m on w.mgr=m.empno 
where w.job <> 'PRESIDENT' and w.job <> 'MANAGER'
group by w.mgr 
having mgr is not null and min(w.sal) > 1000
order by min(w.sal) desc

-- Q9 – Pour chaque grade, afficher le salaire plancher, le salaire plafond, le nombre de salariés concernés et la moyenne des salaires du grade.
select grade, losal, hisal, count(empno), avg(sal) from EMP e inner join SALGRADE s on sal between losal and hisal group by grade, losal, hisal

-- Q10 – Afficher les noms des départements dont le nombre de salariés est supérieur ou égal à 5.
select dname as 'Nom du département', count(empno) as 'Nombre d''employé' from EMP e inner join DEPT d on e.deptno = d.deptno group by dname having count(*)>5

