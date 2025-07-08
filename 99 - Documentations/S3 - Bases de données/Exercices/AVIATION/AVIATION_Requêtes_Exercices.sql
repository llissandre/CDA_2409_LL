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
select distinct volno, p.pilno, v.avno, voldep, volarr, pilnom from VOL v inner join PILOTE p on v.pilno = p.pilno inner join AVION a on v.avno=a.avno order by pilnom, avnom

-- Q11 - Afficher pour chaque pilote de la base de données, la liste des villes à partir desquelles il n'a jamais décollé. Afficher le numéro du pilote, le nom du pilote et la ville.

-- Q12 - Afficher la liste des vols qui correspondent à des allers-retours entre deux villes. Afficher le numéro de vol, la ville de départ et la ville d'arrivée.

-- Q13 - Afficher le nombre d’avions de type Airbus 

-- Q14 - Pour chaque avion afficher le nombre de vols sur lesquels il a été affecté

-- Q15 - Pour chaque type d’avion (AVNOM) afficher le nombre de vols sur lesquels il a été affecté

-- Q16 - Quels sont les pilotes qui n’ont jamais utilisé d’avion de type Airbus

-- Q17 - Combien de pilotes n’ont jamais été affectés à des vols

-- Q18 - Afficher tous les pilotes qui habitent dans une ville d’où part un vol

-- Q19 - Afficher pour chaque ville de départ le nombre de pilotes qui y habitent

-- Q20 - Afficher la capacité minimale, maximale et moyenne des avions de la compagnie

-- Q21 - Afficher la liste des pilotes avec le nombre de vols qu’ils ont réalisé. Trier la liste dans l’ordre décroissant du nombre de vols réalisés.

-- Q22 - Afficher pour chaque ville de destination le nombre d’avions différents qui ont été affectés

-- Q23 - Afficher pour chaque pilote le nombre de vols qu’ils ont effectué

-- Q24 - Afficher pour chaque pilote et avion le nombre de vols effectués (seul les vols ayant eu lieu sont pris en compte)

-- Q25 - Afficher pour chaque pilote et chaque avion le nombre de vols effectués. Si aucun vol n’a été effectué alors le nombre de vol devra être 0.

-- Q26 - Afficher le numéro et le nom du pilote qui a effectué le plus de vols

-- Q27 - Afficher la capacité moyenne des vols par ville de départ

-- Q28 - Afficher la capacité moyenne des vols effectués sur des Airbus par ville de départ

-- Q29 - Afficher la ville destination qui est la plus représentée parmi les vols

-- Q30 - Afficher les pilotes qui ont effectué moins de 3 vols

-- Q31 - Afficher les pilotes qui ont effectué plus de 3 vols

-- Q32 - Afficher les pilotes qui ont effectué plus de 3 vols sur un Airbus

-- Q33 - Ecrire une requête qui affiche tous les vols avec en première colonne nommée « Pilote Habite » la valeur ‘D’ si le pilote habite la ville de départ, ‘A’ si le pilote habite la ville d’arrivée et ‘’ sinon. 

-- Q34 - Retourner pour chaque pilote son nombre de vols et son salaire moyen par vol  (Salaire / nombre de vols)

-- Q35 - Combien d’avions ont une capacité entre 200 et 300

-- Q36 - Afficher pour chaque vol le nombre de passagers, le taux de remplissage par rapport à la capacité de l’avion.

-- Q37 - Afficher pour chaque avion le nombre total de passagers qu’il a transporté

-- Q38 - Afficher les vols qui ont transporté des employés du département 30

-- Q39 - Afficher par vol et département le nombre de passagers

-- Q40 - Quel est le salaire moyen des passagers des vols partant de Paris ?

-- Q41 - Quel est le passager le mieux payé qui est parti de Paris ?

-- Q42 - Combien de passager partis paris ont King comme manager ?

-- Q43 - Dans quel vol le nombre de ‘Clerck’ est-il le plus important ?

-- Q44 - Quels employés n’ont jamais pris de vols ?

-- Q45 - Combien d’employés n’ont jamais pris de vols ?

-- Q46 - Afficher pour chaque grade, le nombre d’employés, la masse salariale,  le salaire moyen.

-- Q47 - Afficher pour chaque service et grade, le nombre d’employés, la masse salariale,  le salaire moyen.

-- Q48 - Afficher pour chaque grade  et service, le nombre d’employés, la masse salariale,  le salaire moyen.

-- Q49 - Quels est l’avion pris le plus de fois par ‘Smith’

-- Q50 - Quelle est l’employé qui est allé le plus de fois vers la même ville de destination ?


