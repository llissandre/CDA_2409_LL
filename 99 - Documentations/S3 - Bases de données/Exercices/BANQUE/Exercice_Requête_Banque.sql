-- *Opération la plus vieille pour le compte 'CC00000001'
select min(dateOpe)
from OPERATION o 
where numCpt = 'CC00000001';

-- *Opération la plus vieille pour le compte 'LI00000003'
select min(dateOpe)
from OPERATION o 
where numCpt = 'LI00000003';

select *, (select min(dateOpe) from OPERATION o where o.numCpt = c.numCpt) as datePremiereOperation
from COMPTE c;
select numCpt, dateOuvCpt, (select min(dateOpe) from OPERATION o where o.numCpt = c.numCpt) as datePremiereOperation
from COMPTE c;
select (select min(dateOpe) from OPERATION o where o.numCpt = c.numCpt)
from COMPTE c;

-- 1 - Affecter à chaque compte comme date d'ouverture, la date de sa première opération
-- *Mise à jour de la date d'ouverture de tous les comptes
update COMPTE c
set c.dateOuvCpt = (select min(dateOpe) from OPERATION o where o.numCpt = c.numCpt);


-- 2 - Corriger erreurs sur les dépôts lorsqu'ils sont négatifs : Il faut les passer en positif
update OPERATION
set montantOpe = montantOpe * -1 where codeTypeOpe = 'DEP';

select * from COMPTE c; -- *Pour vérifier  
select * from OPERATION o where codeTypeOpe = 'DEP' order by montantOpe ; -- *Pour vérifier


-- 3 - Solde d'un compte = somme du montant de toutes les opérations
select sum(montantOpe) from OPERATION o where numCpt = 'CC00000001';


-- 4 - Calculer et affecter à chaque compte son solde
update COMPTE c
set c.soldeCpt = (select sum(montantOpe) from OPERATION o where o.numCpt = c.numCpt);

select * from COMPTE c; -- *Pour vérifier


-- 5 - Quel compte a le plus grand nombre d'opérations
	-- v1 -
	select numCpt, count(*)  from OPERATION group by numCpt order by count(*) desc limit 1;

	-- v2 -
	select numCpt, count(*) from OPERATION group by numCpt 
		-- * On ne garde que les groupes pour lesquels le nombre de lignes est égale au maximum
		having count(*) = (select count (*) from OPERATION group by numCpt order by count(*) desc limit 1);

	-- v3 - Version trop compliquée
	select numCpt, count(*) from OPERATION group by numCpt having count(*)  = 
	(select max(NombreDOperation) from (select count(*) as NombreDOperation from OPERATION group by numCpt)NombreMaxDOperation);

select count(*) as NombreDOperation from OPERATION group by numCpt;

-- 6 - Afficher le solde de tous les comptes au 31/01/2021
select numCpt, sum(montantOpe), '31-01-2021' as 'Date du jour' from OPERATION o where dateOpe <= '2021-01-31' group by numCpt;


-- 7 - Afficher tous les mouvements entre le 01/03/2020 et le 30/06/2020
select numCpt, montantOpe, dateOpe from OPERATION o where dateOpe between '2020-03-01' and '2020-06-30' order by dateOpe;
-- *Avec toutes les colonnes de la table opération
select * from OPERATION o where dateOpe between '2020-03-01' and '2020-06-30' order by dateOpe;


-- 8 - Quel(s) client(s) ont le plus gros solde au 31/01/2021
-- *Calcul du solde de tous les clients au 31/01/2021
select t.numTit, t.nomTit, sum(montantOpe)
from OPERATION o
inner join COMPTE c on o.numCpt = c.numCpt 
inner join TITULAIRE t on c.numTit = t.numTit
where  dateOpe <= '2021-01-31'
group by t.numTit, t.nomTit;

select t.*, sum(montantOpe)
from OPERATION o
inner join COMPTE c on o.numCpt = c.numCpt 
inner join TITULAIRE t on c.numTit = t.numTit
where  dateOpe <= '2021-01-31'
group by t.numTit, t.nomTit;

-- *Sélection du plus gros solde de tous les clients au 31/01/2021
-- *v1 - Avec desc et limit à 1
select t.numTit, t.nomTit, sum(montantOpe)
from OPERATION o
inner join COMPTE c on o.numCpt = c.numCpt 
inner join TITULAIRE t on c.numTit = t.numTit
where  dateOpe <= '2021-01-31'
group by t.numTit, t.nomTit
order by sum(montantOpe) desc
limit 1;

-- * v2 - Avec having : pour avoir tous les soldes ayant le plus gros solde
select t.numTit, t.nomTit, sum(montantOpe)
from OPERATION o
inner join COMPTE c on o.numCpt = c.numCpt 
inner join TITULAIRE t on c.numTit = t.numTit
where  dateOpe <= '2021-01-31'
group by t.numTit, t.nomTit
having sum(montantOpe) = (
						-- *Soldes les plus élevés au 31/01/2021
						select sum(montantOpe)
						from OPERATION o
						inner join COMPTE c on o.numCpt = c.numCpt 
						inner join TITULAIRE t on c.numTit = t.numTit
						where  dateOpe <= '2021-01-31'
						group by t.numTit, t.nomTit
						order by sum(montantOpe) desc
						limit 1
						);		
	

-- 9 - Quels titulaires n'ont pas de compte en banque
-- *Avec left join
select nomTit, c.numTit
from TITULAIRE t left join COMPTE c on c.numTit = c.numTit
where c.numTit is null
					
-- *Avec not in
select nomTit, numTit
from TITULAIRE
where numTit not in (select numTit from COMPTE)
					
-- *Avec exists - pour éditer les titulaires n'ayant pas de compte
select nomTit, numTit
from TITULAIRE t
where not exists (select 'Non' from COMPTE c where c.numTit = t.numTit);
-- *Avec Exists - pour éditer les titulaires ayant un compte
select nomTit, numTit
from TITULAIRE t
where exists (select 'Oui' from COMPTE c where c.numTit = t.numTit);


-- 10 - Enregistrer un dépôt de 1000 sur le compte courant du titulaire n° '00001'
-- *Recherche du compte courant du titulaire dont le numéro est 0001
select numCpt from COMPTE where numTit = 00001 and codeTypeCpt = 'COC'; -- *Pour trouver le numéro de compte courant depuis le numéro du titulaire

-- *Enregistrement du dépôt : opération de dépôt sur le compte
-- v1 -
INSERT INTO OPERATION
(description, montantOpe, numCpt, codeTypeOpe)
VALUES('Depôt de 1000€ sur le compte courant du titulaire 00001', +1000, (select c.numCpt from COMPTE c 
where c.numTit = 00001 and c.codeTypeCpt = 'COC'), 'DEP');

select * from OPERATION o where numCpt = (select c.numCpt from COMPTE c where c.numTit = 00001 and c.codeTypeCpt = 'COC') order by dateOpe desc; -- * - Pour vérifier

-- v2 -
-- Quand il n'est pas autorisé par Mysql de lire une table qui sera modifiée par le trigger
-- On doit utiliser une table temporaire pour stocker le résultat à utiliser : le numéro de compte

-- *Création d'une table temporaire 'TempTableNumCpt' 
create temporary table if not exists TempTableNumCpt  as (select numCpt from COMPTE where numTit = 00001 and codeTypeCpt = 'COC'); 

select * from TempTableNumCpt;

insert into OPERATION (description, montantOpe, numCpt, codeTypeOpe)
values('Depôt de 1000€ sur le compte courant du titulaire 00001', +1000, (select numCpt from TempTableNumCpt), 'DEP');

drop table TempTableNumCpt;

select * from OPERATION o where numCpt = (select c.numCpt from COMPTE c where c.numTit = 00001 and c.codeTypeCpt = 'COC') order by dateOpe desc; -- *Pour vérifier

-- *Maj du solde dans COMPTE
update COMPTE 
set soldeCpt = soldeCpt + 1000
where numTit = 00001 and codeTypeCpt = 'COC';

select * from COMPTE c where numTit = 00001 and codeTypeCpt = 'COC'; -- *Pour vérifier
	
-- *Ajout de comptes de type CAD pour tous les titulaires
insert into TYPECPT values ('CAD', 'Cadeau');

select concat ('CA000', numTit), nomTit,adrTit from TITULAIRE; -- *Exemple

insert into COMPTE
select concat ('CA000', numTit), sysdate(), 0, 'CAD', numTit from TITULAIRE where numTit <> '00007';

select * from TITULAIRE t ;
select * from COMPTE c order by numCpt;

-- *Pour supprimer des lignes dans COMPTE
delete from COMPTE 
where numCpt in select (concat ('CAD000', numTit), ,0, 'CAD' from TITULAIRE where numTit <> '00007');


-- 11 - Enregistrer un virement de 333 euros du compte CO00000008 vers le compte CO00000002

set autocommit = false

start transaction -- *Pour démarrer la transaction

-- Étape 1 - Créer les lignes des opérations dans OPERATION
-- *Retrait de 333 euros sur le compte CO00000008
INSERT INTO OPERATION
(dateOpe, description, montantOpe, numCpt, codeTypeOpe)
VALUES(sysdate(), 'Virement vers le compte CO00000002', -333, 'CO00000008', 'VIR');

select * from OPERATION o where numCpt = 'CO00000008' order by dateOpe desc; -- Pour vérifier

-- *Versement des 333 euros sur le compte CO00000002

insert into OPERATION
(dateOpe, description, montantOpe, numCpt, codeTypeOpe)
values (sysdate(), 'Virement depuis le compte CO00000008', +333, 'CO00000002', 'VIR');

select * from OPERATION o where numCpt = 'CO00000002' order by dateOpe desc; -- Pour vérifier

-- Étape 2 - Maj du solde dans COMPTE
-- *Retrait de 333 euros sur le compte CO00000008
update COMPTE c
SET soldeCpt = soldeCpt - 333
where numCpt = 'CO00000008';

select * from COMPTE c where numCpt = 'CO00000008';
-- *Versement des 333 euros sur le compte CO00000002
update COMPTE c
SET soldeCpt = soldeCpt + 333
where numCpt = 'CO00000002';

select * from COMPTE c where numCpt = 'CO00000002';

rollback;
-- *ou -
Commit;


-- 12 - Le client 00002 quitte la banque, il vient fermer tous ses comptes, il faut donc le supprimer de notre Bdd lui et tous ses comptes
-- v1 -
set autocommit = false;
start transaction

select numCpt, soldeCpt from COMPTE where numTit = '00002'; -- *Permet de trouver les numéros de compte depuis le numTit du titulaire
 
-- *Lignes conformes à la table opération pour solder les comptes en solde négatif
select null as 'Numéro de l''opération', sysdate() as 'Date', 'Solde du compte' as Descriptions, - c.soldeCpt 'Montant de l''opération', c.numCpt 'Numéro du compte', 
case when c.soldeCpt > 0 then 'VIR' when c.soldeCpt = 0 then 'NUL' else 'DEP' end as 'Opération' from COMPTE c where c.numTit = '00002'

insert into TYPEOPERATION values ('NUL', 'Clôture Cpt avec soldeCpt à 0'); -- *Création pour identifier les opérations à 0 lors de clôture de compte avec un soldeCpt à 0 
delete from TYPEOPERATION where codeTypeOpe = 'NUL'; 

alter table OPERATION modify `montantOpe` decimal(7,2) NOT NULL; -- *Autorisation des montants à 0 pour pouvoir effectuer la requête suivante

-- *Ajout des lignes conformes à la table opération pour solder les comptes en solde négatif, en tant qu'opération
insert into OPERATION (select null as 'Numéro de l''opération', sysdate() as 'Date', 'Solde du compte' as Descriptions, - c.soldeCpt 'Montant de l''opération', c.numCpt 'Numéro du compte', 
case when c.soldeCpt > 0 then 'VIR' when c.soldeCpt = 0 then 'NUL' else 'DEP' end as 'Opération' from COMPTE c where c.numTit = '00002');

alter table OPERATION modify `montantOpe` decimal(7,2) NOT NULL CHECK (`montantOpe` <> 0); -- * Contrainte check remise en place

select * from OPERATION order by dateOpe desc; -- * Pour vérifier

-- *Mettre les soldes à 0 pour les soldes négatifs dans COMPTE
update COMPTE 
set soldeCpt = soldeCpt - soldeCpt 
where soldeCpt > 0 and numTit = 00002;

select * from COMPTE c where numTit = 00001 order by numCpt; -- * Pour vérifier

delete from OPERATION where numCpt in (select c.numCpt from COMPTE c where c.numTit = 00002);
select * from OPERATION o join COMPTE c on o.numCpt = c.numCpt where o.numCpt in (select c.numCpt from COMPTE c where c.numTit = 00002); -- *Pour vérification

delete from COMPTE where numTit = 00002;
select * from COMPTE c where numTit = 00002; -- *Pour vérification

delete from TITULAIRE where numTit = 00002;
select * from TITULAIRE t where numTit = 00002; -- *Pour vérification

rollback;
-- *Ou -
Commit;

-- v2 -
set autocommit = false
start transaction -- Démarre la transaction

-- *Comptes du client ayant le numTit 00002
select numCpt from COMPTE c where numTit = 00002;

delete from OPERATION where numCpt in (select c.numCpt from COMPTE c where c.numTit = 00002);
select * from OPERATION o join COMPTE c on o.numCpt = c.numCpt where o.numCpt in (select c.numCpt from COMPTE c where c.numTit = 00002); -- *Pour vérification

delete from COMPTE where numTit = 00002;
select * from COMPTE c where numTit = 00002; -- *Pour vérification

delete from TITULAIRE where numTit = 00002;
select * from TITULAIRE t where numTit = 00002; -- *Pour vérification

rollback;
-- *Ou -
Commit;

-- v3 * -
-- *Comptes du client ayant le numTit 00002
select numCpt from COMPTE c where numTit = 00002;

-- *Quand il n'est pas autorisé par Mysql de lire une table qui sera modifiée par le trigger
-- *On doit supprimer en tenant compte des dépendances donc l'ordre sera : OPERATION, COMPTE et TITULAIRE

-- *Création d'une table temporaire 'TempTableNumCptEx12' 
create temporary table if not exists TempTableNumCptEx12  as (select numCpt from COMPTE where numTit = 00002); 

-- *Suppression des opérations des comptes du client ayant le numTit 00002
delete from OPERATION where numCpt in (select numCpt from TempTableNumCptEx12);

-- *Suppression des comptes du client ayant le numTit 00002
delete from COMPTE where numTit = 00002;

-- *Suppression du client ayant le numTit 00002
delete from TITULAIRE where numTit = 00002;

drop table TempTableNumCptEx12

rollback;
-- *Ou -
Commit;


-- 13 - C'est la fête la banque remet à 0 à ses frais tous les comptes qui ont un solde négatif : (enregistrement automatique d'un dépôt équivalent au découvert)
-- *Il faut enregistrer les opérations de dépôt avec les montants permettant d'équilibrer les comptes négatifs

-- * Sélectionner les comptes négatifs
select soldeCpt from COMPTE c where soldeCpt < 0;

-- *Exemple d'une présentation avec des colonnes que l'on souhaite 
select 'Erreur de la banque en votre faveur', - soldeCpt, numCpt, 'DEP' from COMPTE c where soldeCpt < 0;

-- *Lignes conformes à la table opération pour solder les comptes en solde négatif
select null, sysdate(), 'Erreur de la banque en votre faveur', - soldeCpt, numCpt, 'DEP' from COMPTE c where soldeCpt < 0;

-- v1 -
set autocommit = false;
start transaction

-- *Ajout des lignes conformes à la table opération pour solder les comptes en solde négatif, en tant qu'opération
insert into OPERATION (select null, sysdate(), 'Erreur de la banque en votre faveur' as description, - soldeCpt, numCpt, 'DEP' from COMPTE c where soldeCpt < 0);

select * from OPERATION order by dateOpe desc; -- * Pour vérifier

-- *Mettre les soldes à 0 pour les soldes négatifs dans COMPTE
update COMPTE 
set soldeCpt = soldeCpt - soldeCpt 
where soldeCpt < 0;

select * from COMPTE c order by numCpt; -- * Pour vérifier

rollback;
-- *Ou -
Commit;

-- v2 - 
-- *Quand il n'est pas autorisé par Mysql de lire une table qui sera modifiée par le trigger
-- *On doit supprimer en tenant compte des dépendances donc l'ordre sera : OPERATION, COMPTE et TITULAIRE
-- *Création d'une table temporaire 'TempTableNumCptEx12' 

set autocommit = false;
start transaction

-- *Lignes conformes à la table opération pour solder les comptes en solde négatif
select null, sysdate(), 'Erreur de la banque en votre faveur', - soldeCpt, numCpt, 'DEP' from COMPTE c where soldeCpt < 0;

create temporary table if not exists TempTableNumCptEx13 
as (select null as numeroOperationSolde, sysdate(), 'Erreur de la banque en votre faveur' as description , -soldeCpt, numCpt, 'DEP' from COMPTE c where soldeCpt < 0); 

select * from TempTableNumCptEx13;  -- Pour voir le contenu de table

-- *Ajout de ces lignes en tant qu'opération
insert into OPERATION (select * from TempTableNumCptEx13);

-- *Mettre les soldes à 0 pour les soldes négatifs dans COMPTE
update COMPTE 
set soldeCpt = soldeCpt - soldeCpt 
where soldeCpt < 0;

select * from COMPTE c order by numCpt; -- *Pour vérifier

drop table TempTableNumCptEx13;


-- 14 - Présenter la liste des opération sous la forme
-- N°, Date, n° compte, DEBIT, CREDIT    (DEBIT montant si négatif sinon vide, CREDIT montant si négatif sinon vide)
select numOpe 'Numéro d''opération', dateOpe 'Date d''opération', numCpt 'Numéro de l''operation', 
case when montantOpe <= 0 then montantOpe else 0 end 'DEBIT', 
case when montantOpe >= 0 then montantOpe else 0 end'CREDIT'
FROM OPERATION;








