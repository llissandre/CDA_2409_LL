-- Q1 – Afficher le nom et le salaire des employés gagnant plus de 2850
select ename, sal from EMP where sal > 2850

-- Q2 – Afficher le nom et le numéro de département de l’employé dont le matricule est 7566
select ename, deptno from EMP where empno= 7566

-- Q3 –Afficher le nom et le salaire de tous les employés dont le salaire n’est pas compris entre 1500 et 2850
-- v1
select ename, sal from EMP where sal between 1500 and 2850

-- v2
select ename, sal from EMP where sal < 1500 or sal > 2850

-- Q4 – Créez une requête destinée à afficher le nom, le poste et la date d’embauche des employés embauchés entre le 20 février 1981 et le 1 mai 1981. Classez le résultat par date d’embauche croissante
select ename, job, hiredate from EMP where hiredate between '1981-02-20' and '1981-05-01' order by hiredate

-- Q5 –Afficher le nom et le numéro de département de tous les employés des départements 10 et 30 classés par ordre alphabétique
-- v1
select ename, deptno from EMP where deptno in (10,30) order by ename

-- v2
select ename, deptno from EMP where deptno = 10 or deptno = 30 order by ename

-- Q6 –Afficher la liste des noms et salaires des employés gagnant plus de 1500 et travaillant dans le département 10 ou 30. Nommez les colonnes «Employé» et «Salaire mensuel».
select ename as 'Employé', sal as 'Salaire mensuel' from EMP where sal > 1500 and deptno in (10,30) order by ename 

-- Q7 –Afficher le nom et la date d’embauche de chaque employé entré en 1982
-- v1
select ename, hiredate from EMP where hiredate between '1982-01-01' and '1982-12-31'

-- v2
select ename, hiredate from EMP where year(hiredate) =1982

-- ex
select ename, hiredate from EMP where day(hiredate) between 1 and 15

-- Q8 –Afficher le nom et le poste de tous les employés n’ayant pas de manager
select ename, job from EMP where mgr is null

-- Q9 – Créez une requête destinée à afficher le nom, le salaire et la commission de tous les employés qui perçoivent des commissions. Triez les données dans l’ordre décroissant des salaires puis des commissions
select ename, sal, comm from EMP where comm is not null order by sal desc, comm desc

-- Q10 – Afficher le nom de tous les employés dont la troisième lettre du nom est A
select ename from EMP where ename like '__A%'

-- Q11 – Sélectionner le nom de tous les employés dont le nom contient deux L, travaillant dans le département 30 ou dont le manager est 7782
select ename, mgr from EMP where ename like '%L%L%' 

and (deptno = 30 or mgr = 7782)

-- ex
select ename from EMP where ename like '%L%L%' and instr (ename, 'L') <> 0

select ename, instr (ename, 'L') from EMP where ename like '%L%L%'

-- Q12 –Afficher le nom, le poste et le salaire de tous les CLERK ou ANALYST dont le salaire est différent de 1000, 3000 ou 5000
select ename, job, sal from EMP where job in ('clerk', 'analyst') and sal not in (1000, 3000, 5000)

-- ex1
select ename, lower(job), sal from EMP where job in ('clerk', 'analyst') and sal not in (1000, 3000, 5000)

-- ex2
select ename, upper(job), sal from EMP where job in ('clerk', 'analyst') and sal not in (1000, 3000, 5000)

-- Q13 – Afficher le nom, le salaire et la commission de tous les employés dont le montant de commission est  supérieur de plus de 10% au salaire
select ename, sal, comm from EMP where comm > 10% sal