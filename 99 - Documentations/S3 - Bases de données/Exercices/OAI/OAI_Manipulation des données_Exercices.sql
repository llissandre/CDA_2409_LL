
set transaction isolation level read uncommitted;
set transaction isolation level read committed;
set transaction isolation level repeatable read;
set transaction isolation level serializable;

commit;
rollback;
insert into DEPT values(20, 'RESEARCH', 'DALLAS');

-- Les requêtes ci-après sont susceptibles de modifier l’état des données.
-- Passez en mode SET AUTOCOMMIT = false afin de pouvoir annuler les changements (ROLLBACK) pour conserver vos données dans l’état initial. 

set autocommit = false

start transaction

-- Parmi les requêtes proposées ci-dessous, certaines testent les contraintes d’intégrité mises en place dans la base de données et devraient  retourner une erreur à l’exécution. Si tel est le cas, vous relèverez le message et expliquerez la cause de l’erreur.
-- Q1 - Insérer un nouvel employé dans le département 10
insert into EMP (empno, ename, sal, job, comm, hiredate, mgr, deptno) values (7955, 'NOUVELEMPLOYE', 2500, 'ANALYST', 500, '1983-02-14', 7839, 10)

insert into EMP (empno, ename, sal, job, comm, hiredate, mgr, deptno) values (7956, 'NOUVELEMPLOYE2', 2500, 'ANALYST', 500, '1983-02-14', 7839, 10)

-- Q2 - Insérer un nouveau département avec pour numéro de département 30
insert into DEPT (deptno, dname, loc) values (30, 'BOUFFE', 'MILLAU')

-- Q3 - Insérer un nouvel employé dans le dépaent 50
insert into EMP (empno, ename, sal, job, comm, hiredate, mgr, deptno) values (7999, 'NOUVELEMPLOYE50', 2500, 'ANALYST', 500, '1983-02-14', 7839, 50)

-- Q4 - Supprimer le département 10
delete from DEPT where deptno = 10

-- Bonus : vous aurez besoin de sous-requêtes pour résoudre ces problèmes.
-- Q5 - Affecter l’employé dont le nom est BLAKE au département dont le nom RESEARCH
update EMP set deptno = (select deptno from DEPT d where dname = 'RESEARCH') where ename = 'BLAKE'

-- Q6 - Augmenter de 100€ les salariés qui gagnent le minimum
update EMP set sal = sal + 100 where sal = (select min(sal) from EMP)

-- Q7 – Supprimer les départements qui n’ont pas de salariés
delete from DEPT where deptno not in (select deptno from EMP)

delete from DEPT where deptno not in (select distinct deptno from EMP)

-- Q8 – Augmenter de 100€ les employés qui travaillent à DALLAS
update EMP set sal = sal + 100 where deptno = (select deptno from DEPT d where loc = 'DALLAS')

update EMP set sal = sal + 100 where deptno in (select deptno from DEPT d where loc = 'DALLAS')

update EMP set sal = sal + 100 where deptno = any (select deptno from DEPT d where loc = 'DALLAS')

-- Q9 - Réaliser les changements ci-après dans une même transaction. Prévoir la possibilité d'annuler ces changements :
set autocommit = false

start transaction

	-- e1 - Insérer un nouveau département (le numéro 50)
	-- v1
	insert into DEPT (deptno, dname, loc) values (50, 'NVDEPARTEMENT', 'MILLAU');
	-- v2
	insert into DEPT values (50, 'NVDEPARTEMENT', 'MILLAU');

	-- e2 - Affecter tous les employés du département 20 au département 50
	update EMP set deptno = 50 where deptno = 20

	-- Créer un point de restauration
	-- Permet d'effectuer ce qui est demander à l'étape e5
	savepoint jalon1

	-- e3 - Supprimer le département 20
	delete from DEPT where deptno not in (select deptno from EMP);
	delete from DEPT where deptno = 20;

	-- e4 - Vérifier en visualisant le contenu des tables
	-- vérification dans DEPT	
		select deptno from DEPT;
		-- Renvoie 1 s'il n'y a plus de département 20 dans deptno sinon 1  
		select count(*) = 0 from DEPT where deptno in (20)

	-- vérification dans EMP
		select deptno from EMP;
		-- Renvoie 1 s'il n'y a plus d'employé dans le département 20 sinon 1 
		select count(*) = 0 from EMP where deptno in (20)

	-- e5 - Annuler la suppression du département 20
	rollback to jalon1

	-- e6 - Valider les changements en suspens pour les rendre permanents
	commit;

	-- e7 - Vérifier en visualisant le contenu des tables.
	-- vérification dans DEPT
		select deptno from DEPT;
		-- Renvoie 0 s'il y a un département 20 dans deptno, sinon 1  
		select count(*) = 0 from DEPT where deptno in (20);

	-- vérification dans EMP
		select distinct deptno from EMP;
		-- Renvoie 0 s'il y a des employés dans le département 20, sinon 1 
		select count(*) = 0 from EMP where deptno in (20);
	

	

	