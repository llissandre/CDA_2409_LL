-- OAI – Vues --

-- 1 - Créer une vue appelée EMP_VU comprenant le numéro d’employé, le nom, le numéro de département de la table EMP. 
-- Afficher le contenu de cette vue.
drop view EMP_VU;

create view EMP_VU
as
select empno, ename, deptno from EMP;

select * from EMP_VU;

-- 2 - En utilisant la vue EMP_VU, créer une requête pour afficher les noms et les numéros de département de tous les employés.
select ename, deptno from EMP_VU order by deptno asc, ename desc;

-- 3 - Créer une vue DEPT_VU montrant tous les départements avec le numéro de département, le nom du département, le nombre d’employés du département. 
-- Afficher le contenu de cette vue.
drop view DEPT_VU;
drop view DEPT_VU2;

create view DEPT_VU
as
select d.deptno, dname, count(*) from EMP e join DEPT d on e.deptno = d.deptno group by deptno;

create view DEPT_VU2
as
select e.deptno, (select dname from DEPT d where e.deptno = d.deptno), count(*) from EMP e group by deptno;

select * from DEPT_VU;
select * from DEPT_VU2;


-- 4 - Créer une vue SALGRADE_VU montrant tous les employés avec leur numéro, leur nom, leur salaire, leur poste et leur grade. 
-- En utilisant la vue SALGRADE_VU, compter le nombre d’employés par grade.
drop view SALGRADE_VU;

create view SALGRADE_VU
as
select empno, ename, sal, job, grade from EMP e join SALGRADE s on e.sal between losal and hisal order by empno;

select * from SALGRADE_VU;

select grade, count(*) NombreEmployeParGrade from SALGRADE_VU group by grade order by grade;

-- 5 – Créer une vue DEPT30_VU qui contiendra le numéro, le nom et le numéro de département de tous les employés du département 30.
-- Interdire de modifier la colonne numéro de département à partir de cette vue. 
-- Afficher le contenu de la vue DEPT30_VU. 
-- Tenter de modifier le numéro de département de l‘employé SMITH (nouvelle valeur 30).
drop view DEPT30_VU;

create view DEPT30_VU
as
select empno, ename, deptno from EMP
where deptno in (30)
with check option;

select * from DEPT30_VU;

update DEPT30_VU set deptno = 20;
