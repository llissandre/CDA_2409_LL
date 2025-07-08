AVIATION – Requêtes

-- Q1 - Afficher les numéros de vols au départ de Paris
select volno from VOL where upper(voldep) = 'PARIS'

-- Q2 -	Afficher les numéros de pilotes en service sur des vols et la ville d'arrivée de leur vol
select pilno, volarr from VOL

-- Q3 -	Afficher les caractéristiques de tous les AIRBUS
select * from AVION where avnom like '%AIRBUS%'

-- Q4 - Afficher les noms des pilotes qui habitent PARIS (autre que JEAN)
select pilno,pilnom from PILOTE where upper(piladr) = 'PARIS' and upper(pilnom) <> 'JEAN'

-- Q5 - Afficher les avions de capacité supérieure à 250 localisés à PARIS
select * from AVION where avcap > 250 and trim(upper(avloc)) = 'PARIS'

-- Q6 -	Afficher les avions de capacité supérieure à 250 ou localisés à PARIS
select * from AVION where avcap > 250 or trim(upper(avloc)) = 'PARIS'

-- Q7 - Pour chaque pilote en service, afficher le nom du pilote, l'adresse du pilote et le numéro de l'avion piloté. Trier par nom de pilote
select pilnom as 'Nom du pilote', piladr as 'Adresse du pilote', avno as 'Numéro de l''avion' 
from PILOTE p 
inner join VOL v on p.pilno = v.pilno 
order by pilnom, avno

select pilnom as 'Nom du pilote', piladr as 'Adresse du pilote', a.avno as 'Numéro de l''avion', avnom
from PILOTE p 
inner join VOL v on p.pilno = v.pilno 
inner join AVION a on v.avno = a.avno 
order by pilnom, a.avno

-- Q8 - Afficher les noms des pilotes qui pilotent un avion au départ de PARIS
select pilnom as 'Nom du pilote' from PILOTE p inner join VOL v on p.pilno = v.pilno  where voldep = 'PARIS'

-- Q9 - Afficher les noms des pilotes qui pilotent un AIRBUS
select distinct pilnom as 'Nom du pilote' from VOL v inner join PILOTE p on v.pilno = p.pilno inner join AVION a on v.avno = a.avno where avnom like '%AIRBUS%'

-- Q10 - Afficher la liste des vols triés par nom de pilote croissant et par nom d'avion croissant
select distinct v.*, pilnom, avnom from VOL v inner join PILOTE p on v.pilno = p.pilno inner join AVION a on v.avno=a.avno order by pilnom, avnom

-- Q11 - Afficher pour chaque pilote de la base de données, la liste des villes à partir desquelles il n'a jamais décollé. Afficher le numéro du pilote, le nom du pilote et la ville.
select distinct p.pilno, pilnom, ville.voldep from VOL ville cross join PILOTE p left join VOL vol on ville.voldep = vol.voldep and p.pilno=vol.pilno where vol.voldep is null order by p.pilno

-- Q12 - Afficher la liste des vols qui correspondent à des allers-retours entre deux villes. Afficher le numéro de vol, la ville de départ et la ville d'arrivée
select a.volno, a.voldep, a.volarr, r.volno, r.voldep, r.volarr from VOL a join VOL r on a.voldep=r.volarr and a.volarr=r.voldep 

select a.volno, a.voldep, a.volarr, r.volno, r.voldep, r.volarr from VOL a, VOL r where a.voldep=r.volarr and a.volarr=r.voldep

-- Q13 - Afficher le nombre d’avions de type Airbus
select count(*) from AVION where avnom like '%AIRBUS%'

-- Q14 - Pour chaque avion afficher le nombre de vols sur lesquels il a été affecté
select a.*, count(*) from AVION a join VOL v on a.avno=v.avno group by a.avno, a.avnom, a.avcap, a.avloc

select a.avno as 'Numéro d''avion', count(*) as 'Nombre de vol' from VOL v join AVION a on v.avno = a.avno group by a.avno

-- Q15 - Pour chaque type d’avion (AVNOM) afficher le nombre de vols sur lesquels il a été affecté
select avnom as 'Nom de l''avion', count(*) as 'Nombre de vol' from VOL v join AVION a on v.avno = a.avno group by avnom

select substring(avnom, 1, 2) as 'Marques', count(*) as 'Nombre de vol' from VOL v join AVION a on v.avno = a.avno group by substring(avnom, 1, 2)

-- Q16 - Quels sont les pilotes qui n’ont jamais utilisé d’avion de type Airbus
select pilno as 'Numéro du pilote', pilnom as 'Nom du pilote', piladr as 'Adresse du pilote', pilsal as 'Salaire du pilote' from PILOTE p
where pilno not in
(select v.pilno from VOL v inner join PILOTE p on v.pilno = p.pilno left join AVION a on v.avno = a.avno)

select * from PILOTE
where pilno not in
(select v.pilno from VOL v inner join PILOTE p on v.pilno = p.pilno left join AVION a on v.avno = a.avno)

-- Q17 - Combien de pilotes n’ont jamais été affectés à des vols
select p.pilno, pilnom, piladr, pilsal from PILOTE p left join VOL v on p.pilno = v.pilno group by pilnom, p.pilno  having count(v.pilno) = 0 order by p.pilno

select * from PILOTE
where pilno not in
(select distinct p.pilno from PILOTE p join VOL v on p.pilno = v.pilno)

-- Q18 - Afficher tous les pilotes qui habitent dans une ville d’où part un vol
select distinct p.pilno, pilnom as Pilote, piladr as 'Ville du pilote', voldep as 'Ville d''arrivée' 
from PILOTE p 
join VOL v on piladr = voldep
order by p.pilno

select distinct p.* from PILOTE p, VOL v where p.piladr = v.voldep order by pilno

-- Q19 - Afficher pour chaque ville de départ le nombre de pilotes qui y habitent
select distinct v.voldep, count(*) from PILOTE p, (select distinct v2.voldep from VOL v2) v where p.piladr = v.voldep group by voldep order by voldep

select distinct v.voldep, count(p.piladr) from PILOTE p right join (select distinct v2.voldep from VOL v2) v on p.piladr = v.voldep group by v.voldep order by v.voldep

-- Q20 - Afficher la capacité minimale, maximale et moyenne des avions de la compagnie
select min(avcap) as 'Capacité minimale', max(avcap) as 'Capacité maximale', avg(avcap) 'Capacité moyenne' from AVION a 

-- Vol pour les 182 passagers du Millau St Afrique
select * from AVION a  where avcap >= 182 limit 1

-- on prend le pilote habitant Millau qui coûte le moins cher
select * from PILOTE p where piladr='MILLAU' order by pilsal limit 1

select * from PILOTE p where pilsal =
-- Le salaire minimum des pilotes de Millau
(select min(pilsal) from PILOTE p2 where piladr='MILLAU')
limit 1

-- Q21 - Afficher la liste des pilotes avec le nombre de vols qu’ils ont réalisé. Trier la liste dans l’ordre décroissant du nombre de vols réalisés
select pilnom as Pilote, p.pilno as 'Numéro de pilote', count(*) as 'Nombre de vol' from PILOTE p join VOL v on p.pilno = v.pilno group by pilnom, p.pilno order by count(p.pilno) desc

-- Q22 - Afficher pour chaque ville de destination le nombre d’avions différents qui ont été affectés
select volarr as 'Ville d''arrivée', count(distinct avno) as 'Nombre d''avion' from VOL group by volarr

select v.volarr as 'Ville d''arrivée', count(v.avno) as 'Nombre d''avion' from VOL v group by volarr

-- Q23 - Afficher pour chaque pilote le nombre de vols qu’ils ont effectué
select pilnom, count(p.pilno) from PILOTE p join VOL v on p.pilno = v.pilno group by p.pilno order by count(p.pilno) desc

-- afficher les pilotes qui n'ont pas volé
select p.pilno, pilnom, count(volno) from PILOTE p left join VOL v on p.pilno = v.pilno group by p.pilno order by count(volno) desc

-- left tous les pilotes associés à leurs vols ou null pas de vol associé au pilote
select p.pilno, pilnom, volno from PILOTE p left join VOL v on p.pilno = v.pilno group by p.pilno, pilnom, volno  order by count(volno) desc

-- Q24 - Afficher pour chaque pilote et avion le nombre de vols effectués (seul les vols ayant eu lieu sont pris en compte)
-- par modèle d'avion et par pilote sur la même ligne
select p.pilno as 'Numéro de pilote', pilnom as 'Nom du pilote', avnom as 'Nom de l''avion', count(p.pilno) as 'Nombre de vols effectués' 
from VOL v 
inner join PILOTE p on v.pilno = p.pilno 
inner join AVION a on v.avno = a.avno 
group by p.pilno, a.avno

-- par avion et par pilote sur la même ligne
select p.pilno as 'Numéro de pilote', pilnom as 'Nom du pilote', a.avno 'Numéro d''avion', a.avnom as 'Modèle de l''avion', count(p.pilno) as 'Nombre de vols effectués' 
from VOL v 
inner join PILOTE p on v.pilno = p.pilno 
inner join AVION a on v.avno = a.avno 
group by p.pilno, a.avno

-- pour chaque pilote et chaque avion
-- v1
select 'Un pilote' Objet, p.pilno as 'Numéro', pilnom Nom, count(p.pilno) as 'Nombre de vols effectués' 
from VOL v inner join PILOTE p on v.pilno = p.pilno 
group by p.pilno
union
select 'Un avion' Objet, a.avno 'Numéro', a.avnom Nom, count(a.avno) as 'Nombre de vols effectués' 
from VOL v inner join AVION a on v.avno = a.avno 
group by a.avno

-- v2
select p.pilno Numéro, pilnom Nom,'--------------' Numéro,'--------------' Nom, count(p.pilno) as 'Nombre de vols effectués'
from VOL v inner join PILOTE p on v.pilno = p.pilno 
group by p.pilno
union
select '--------------' Numéro,'--------------' Nom, a.avno Numéro, a.avnom Nom, count(a.avno) as 'Nombre de vols effectués' 
from VOL v inner join AVION a on v.avno = a.avno 
group by a.avno

-- Q25 - Afficher pour chaque pilote et chaque avion le nombre de vols effectués. Si aucun vol n’a été effectué alors le nombre de vol devra être 0
-- par modèle d'avion et par pilote sur la même ligne
select p.pilno, pilnom as 'Nom du pilote', a.avnom as 'Modèle de l''avion', count (volno) as 'Nombre de vol effectué'
from AVION a cross join PILOTE p
left join VOL v on a.avno=v.avno and p.pilno = v.pilno
group by p.pilno, a.avno

-- par modèle d'avion et par pilote
-- v1
select 'Un pilote' as 'L''objet', p.pilno Numéro, p.pilnom as Nom, count (volno) as 'Nombre de vol effectué'
from PILOTE p
left join VOL v on p.pilno = v.pilno
group by p.pilno
union
select 'Un avion' 'L''objet', a.avno Numéro, a.avnom Nom, count (volno) as 'Nombre de vol effectué'
from AVION a
left join VOL v on a.avno=v.avno
group by a.avno

-- v2
select p.pilno Numéro, pilnom Nom,'--------------' Numéro,'--------------' Nom, count(volno) as 'Nombre de vols effectués' 
from VOL v right join PILOTE p on v.pilno = p.pilno 
group by p.pilno
union
select '--------------' Numéro,'--------------' Nom, a.avno Numéro, a.avnom Nom, count(volno) as 'Nombre de vols effectués' 
from VOL v join AVION a on v.avno = a.avno 
group by a.avno


-- par avion
select p.pilno as 'Numéro de pilote', pilnom as 'Nom du pilote', a.avno 'Numéro d''avion',  a.avnom as 'Nom de l''avion', count (volno) as 'Nombre de vol effectué'
from AVION a cross join PILOTE p
left join VOL v on a.avno=v.avno and p.pilno = v.pilno
group by p.pilno, p.pilnom, a.avno

-- Q26 - Afficher le numéro et le nom du pilote qui a effectué le plus de vols
select p.pilno as 'Numéro du pilote', pilnom as Pilote, count(p.pilno) as 'Nombre de vol' from PILOTE p join VOL v on p.pilno = v.pilno group by p.pilno order by count(p.pilno) desc limit 1

-- Q27 - Afficher la capacité moyenne des vols par ville de départ
select voldep as 'Ville de départ', avg(avcap) 'Capacité moyenne' from VOL v  join AVION a on v.avno = a.avno group by voldep

-- Q28 - Afficher la capacité moyenne des vols effectués sur des Airbus par ville de départ
select voldep as 'Ville de départ', avg(avcap) 'Capacité moyenne' from VOL v  join AVION a on v.avno = a.avno where upper(avnom) like '%AIRBUS%' group by voldep

-- Q29 - Afficher la ville destination qui est la plus représentée parmi les vols
-- toutes les villes les plus représentées avec le nombre de vols
select volarr as 'Ville d''arrivée', count(volarr) from VOL group by volarr 
having count(volarr) = (select count(volarr) from VOL group by volarr order by count(volarr) desc limit 1)

-- toutes les villes les plus représentées sans le nombre de vols
select volarr as 'Ville d''arrivée' from VOL group by volarr 
having count(volarr) = (select count(volarr) from VOL group by volarr order by count(volarr) desc limit 1)

-- toutes les villes les plus représentées sans le nombre de vols
select volarr as 'Ville d''arrivée', count(volarr) 'Nombre de fois desservie' from VOL group by volarr order by count(volarr) desc limit 1

-- Q30 - Afficher les pilotes qui ont effectué moins de 3 vols
select p.pilno 'Numéro du pilote', pilnom 'Nom du pilote', count(volno) as 'Nombre de vol' from PILOTE p left join VOL v on p.pilno = v.pilno group by p.pilno having Count(volno)<3 order by count (volno) desc

-- Q31 - Afficher les pilotes qui ont effectué plus de 3 vols
select  pilnom as Pilote, count(p.pilno) as 'Nombre de vol' from PILOTE p join VOL v on p.pilno = v.pilno group by p.pilno having Count(p.pilno)>3 order by Count(p.pilno) desc

-- Q32 - Afficher les pilotes qui ont effectué plus de 3 vols sur un Airbus -- ok
select pilnom as Pilote, count(p.pilno) as 'Nombre de vol' from PILOTE p join VOL v on p.pilno = v.pilno join AVION a on v.avno = a.avno where trim(upper(avnom)) like '%AIRBUS%' group by p.pilno having Count(p.pilno)>3 order by Count(p.pilno) desc

-- Q33 - Ecrire une requête qui affiche tous les vols avec en première colonne nommée « Pilote Habite » la valeur ‘D’ si le pilote habite la ville de départ, ‘A’ si le pilote habite la ville d’arrivée et ‘’ sinon
select case when v.voldep = p.piladr then 'D' when v.volarr = p.piladr then 'A' else '' end as 'Pilote Habite', v.volno 'Numéro de vol', v.voldep 'Ville de départ', v.volarr 'Ville d''arrivée', p.pilno 'Numéro d''identification du pilote', pilnom 'Nom du pilote' 
from PILOTE p join VOL v on p.pilno = v.pilno 

select case p.piladr when v.voldep then 'D' when v.volarr then 'A' else '' end as 'Pilote Habite', v.volno 'Numéro de vol', v.voldep 'Ville de départ', v.volarr 'Ville d''arrivée', p.pilno 'Numéro d''identification du pilote', pilnom 'Nom du pilote' 
from PILOTE p join VOL v on p.pilno = v.pilno 

-- Q34 - Retourner pour chaque pilote son nombre de vols et son salaire moyen par vol  (Salaire / nombre de vols)
select p.pilno 'Numéro pilote', pilnom as Pilote, count(*) as 'Nombre de vol', pilsal/count(*) as 'Salaire moyen par vol' from PILOTE p join VOL v on p.pilno = v.pilno group by p.pilno, p.pilnom, pilsal

-- Q35 - Combien d’avions ont une capacité entre 200 et 300
select count(*) as 'Avion ayant une capacité entre 200 et 300' from AVION a where avcap >= 200 and avcap < 300

select count(*) as 'Avion ayant une capacité entre 200 et 300' from AVION a where avcap between 200 and 300

-- Q36 - Afficher pour chaque vol le nombre de passagers, le taux de remplissage par rapport à la capacité de l’avion
select p.volno as 'Numéro de vol', v.voldep, v.volarr, avcap 'Capacité de l''avion', count(*) as 'Nombre de passager', count (*)/avcap*100 as 'Pourcentage d''occupation de l''avion' from VOL v inner join PASSAGER p on v.volno = p.volno inner join AVION a on v.avno = a.avno group by p.volno, v.voldep, v.volarr, avcap order by p.volno

-- Q37 - Afficher pour chaque avion le nombre total de passagers qu’il a transporté
select v.avno as 'Numéro d''avion', a.avnom 'Modèle d''avion', count (p.empno) as 'Nombre de passager' from VOL v left join PASSAGER p on v.volno = p.volno right join AVION a on v.avno = a.avno group by v.avno , a.avnom order by a.avno


-- Q38 - Afficher les vols qui ont transporté des employés du département 30
select distinct p.volno as Vol from EMP e inner join PASSAGER p on e.empno = p.empno where e.deptno in (30) order by p.volno

select distinct v.* from VOL v inner join PASSAGER p on v.volno = p.volno inner join EMP e on p.empno = e.empno where e.deptno = 30 order by v.volno

-- Q39 - Afficher par vol et département le nombre de passagers -- ok
select p.volno as Vol, e.deptno as Département, count (*) as 'Nombre de passager' from EMP e  join PASSAGER p on e.empno = p.empno join DEPT d on e.deptno = d.deptno group by p.volno, e.deptno

select p.volno as Vol, e.deptno as Département, count (*) as 'Nombre de passager' from VOL v inner join PASSAGER p on v.volno = p.volno inner join EMP e on p.empno = e.empno group by v.volno, e.deptno

-- Indique par vol le nombre de passager par département
select p.volno as Vol, e.deptno as Département, count (e.empno)  from VOL v cross join DEPT d left join PASSAGER p on v.volno = p.volno 
-- EMP si dans le vol et du département du cross join
left join EMP e on p.empno = e.empno and e.deptno = d.deptno order by v.volno, d.deptno

-- Q40 - Quel est le salaire moyen des passagers des vols partant de Paris ?
select avg(e.sal) as 'Salaire moyen' from PASSAGER p join EMP e on e.empno = p.empno join VOL v on p.volno = v.volno where voldep = 'PARIS'

select avg(sal) 'Moyenne des salaires', sum(sal) 'Somme des salaires', count(*) 'Nombre de pasager', sum(sal)/count(*) 'Résultat du calcul de la moyenne des salaires' from PASSAGER p join EMP e on e.empno = p.empno join VOL v on p.volno = v.volno where voldep = 'PARIS'

-- Q41 - Quel est le passager le mieux payé qui est parti de Paris ?
-- v1
select e.ename, e.sal from VOL v inner join PASSAGER p on p.volno = v.volno inner join EMP e on e.empno = p.empno  where voldep = 'PARIS' order by sal desc limit 1

-- v2
select distinct e.* from VOL v inner join PASSAGER p on p.volno = v.volno inner join EMP e on e.empno = p.empno where voldep = 'PARIS' and sal =
(select max(e.sal) as 'Salaire maximal' from  VOL v inner join PASSAGER p on p.volno = v.volno inner join EMP e on e.empno = p.empno  where voldep = 'PARIS')

-- Q42 - Combien de passager partis de Paris ont 'KING' comme manager ?
-- avec le nom
select count(distinct w.empno) as 'Passager partis de Paris ayant King comme manager' from PASSAGER p join EMP w on w.empno = p.empno join EMP m on w.mgr = m.empno join VOL v on p.volno = v.volno where voldep = 'PARIS' and m.ename='KING'

-- avec le mgr
select count(distinct p.empno) as 'Passager partis de Paris ayant King comme manager' from PASSAGER p join EMP e on e.empno = p.empno join VOL v on p.volno = v.volno where voldep = 'PARIS' and mgr = '7839'

-- Q43 - Dans quel vol le nombre de ‘CLERK’ est-il le plus important ?
select p.volno as Vol, count(job) as 'Nombre de ‘CLERK’ par vol' from EMP e join PASSAGER p on e.empno = p.empno where job = 'CLERK' group by p.volno order by count(job) desc limit 1

select p.volno as Vol, count(job) as 'Nombre de ‘CLERK’ par vol' from EMP e join PASSAGER p on e.empno = p.empno group by p.volno, e.job having e.job = 'CLERK' order by count(job) desc limit 1

-- Q44 - Quels employés n’ont jamais pris de vols ?
-- v1 - Semi-jointure, on ne garde que ceux pour lesquels il n'y a pas de correspondance
select e.* from PASSAGER p right join EMP e on e.empno = p.empno where p.volno is null

-- v2 - Avec une sous-requête, on ne garde que ceux qui ont volé
select * from EMP e 
where e.empno not in(select distinct p.empno from PASSAGER p)

-- v3 - Par soustraction à l'ensemble des employés de ceux qui ont volé
select * from EMP e 
except
select * from EMP e where e.empno in (select distinct p.empno from PASSAGER p)

-- Q45 - Combien d’employés n’ont jamais pris de vols ?
-- v1 - Semi-jointure, on ne garde que ceux pour lesquels il n'y a pas de correspondance
select count(*) from PASSAGER p right join EMP e on e.empno = p.empno where p.volno is null

-- v2 - Avec une sous-requête, on ne garde que ceux qui ont volé
select count(*) from EMP e 
where e.empno not in(select distinct p.empno from PASSAGER p)

-- v3 - Par soustraction à l'ensemble des employés de ceux qui ont volé
select count(*) from
(
select * from EMP e 
except
select * from EMP e where e.empno in (select distinct p.empno from PASSAGER p)
)nonVolant -- il faut donner un nom --

-- v4 - Par soustraction du nombre de lignes
select count(*) - (select count(*) from EMP e where e.empno in (select distinct p.empno from PASSAGER p))
from EMP

-- v5 - Avec not exists - L'employé ne doit pas faire partie des passagers (sous-requête corrélée)
select count(*) from EMP e 
where not exists (select 1 from PASSAGER p where p.empno = e.empno)
 
-- v6 - le nombre de fois où l'employé a été passager doit être 0 (sous-requête corrélée)
select count(*) from EMP e 
where (select count (*) from PASSAGER p where p.empno = e.empno)=0

-- Q46 - Afficher pour chaque grade, le nombre d’employés, la masse salariale,  le salaire moyen
select grade as Grade, count(*) as 'Nombre d''employé', sum(sal) as 'Masse salariale', avg(sal) as 'Salaire moyen' from EMP e join SALGRADE s on sal between losal and hisal group by grade

-- Q47 - Afficher pour chaque service et grade, le nombre d’employés, la masse salariale,  le salaire moyen
select e.deptno as Département, dname as 'Nom du département', grade as Grade, count(*) as 'Nombre d''employé', sum(sal) as 'Masse salariale', avg(sal) as 'Salaire moyen' from EMP e join SALGRADE s on sal between losal and hisal join DEPT d on e.deptno = d.deptno group by e.deptno, dname, grade

-- Q48 - Afficher pour chaque grade  et service, le nombre d’employés, la masse salariale,  le salaire moyen
select grade as Grade, e.deptno as Département, dname as 'Nom du département', count(*) as 'Nombre d''employé', sum(sal) as 'Masse salariale', avg(sal) as 'Salaire moyen' from EMP e join SALGRADE s on sal between losal and hisal join DEPT d on e.deptno = d.deptno group by grade, e.deptno, dname

-- Q49 - Quel est l’avion pris le plus de fois par ‘SMITH’
-- avec le nom
select a.*, count (*) 'Nombre de fois' From VOL v inner join PASSAGER p on v.volno = p.volno inner join EMP e on p.empno = e.empno inner join AVION a on v.avno = a.avno where trim(upper(e.ename = 'SMITH')) group by a.avno desc limit 1

-- pour afficher tous les résultats quand il y a plusieurs résultats le maximum
-- avec le nombre de vols
select a.avno 'Numéro de l''avion', avnom 'Nom de l''avnom', count (*) 'Nombre de fois' From VOL v inner join PASSAGER p on v.volno = p.volno inner join EMP e on p.empno = e.empno inner join AVION a on v.avno = a.avno where trim(upper(e.ename = 'SMITH')) group by a.avno
having count(*) = (select count(*) from VOL v inner join PASSAGER p on v.volno = p.volno inner join EMP e on p.empno = e.empno inner join AVION a on v.avno = a.avno where trim(upper(e.ename = 'SMITH')) group by a.avno order by count(*) desc limit 1)

-- pour afficher tous les résultats quand il y a plusieurs résultats le maximum
-- sans le nombre de vols
select a.avno 'Numéro de l''avion', avnom 'Nom de l''avnom' From VOL v inner join PASSAGER p on v.volno = p.volno inner join EMP e on p.empno = e.empno inner join AVION a on v.avno = a.avno where trim(upper(e.ename = 'SMITH')) group by a.avno
having count(*) = (select count(*) from VOL v inner join PASSAGER p on v.volno = p.volno inner join EMP e on p.empno = e.empno inner join AVION a on v.avno = a.avno where trim(upper(e.ename = 'SMITH')) group by a.avno order by count(*) desc limit 1)

-- avec le mgr
select a.*, count (*) 'Nombre de fois' From VOL v inner join PASSAGER p on v.volno = p.volno inner join AVION a on v.avno = a.avno where empno = 7369 group by a.avno order by count(*)

-- Q50 - Quelle est l’employé qui est allé le plus de fois vers la même ville de destination ?
select e.empno 'Identifiant de l''employé', ename as 'Nom de l''employé', volarr as 'Ville de destination', count(*) 'Nombre de fois' from PASSAGER p join EMP e on e.empno = p.empno join VOL v on p.volno = v.volno group by e.empno, e.ename, v.volarr order by count(*) desc limit 1


-- Exemples sous-requêtes --

-- non corrélée - la sous-requête n'est pas dépendante de la requête principale
-- elle est calculé une seule fois avant la requête principale
select * from EMP where mgr in (select empno from EMP where trim(upper(ename = 'king')))

-- corrélée - la sous-requête est dépendante de la valeur de mgr de la ligne traitée par la requête prinicpale
select * from EMP where 1 = (select distinct 1 from EMP m where trim(upper(m.ename = 'king')) and e.mgr = m.empno)

-- corrélée - la sous-requête est dépendante de la valeur de mgr de la ligne traitée par la requête prinicpale
select * from EMP where exists (select distinct 1 from EMP m where trim(upper(m.ename = 'king')) and e.mgr = m.empno)

