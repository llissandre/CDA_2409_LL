-- * - Requêtes à réaliser - * --

-- 1. Quelles sont les numéros de commandes adressées au fournisseur 00120 ? Les trier de la plus récente à la plus ancienne
select numcom from COMMANDE where numfour = '00120' order by datcom desc;

-- 2. Afficher les articles ayant un stock inférieur ou égal au stock d'alerte
select * from ARTICLE where qteart <= salart;

-- 3. Afficher tous les produits qui sont des pré-imprimés. Pour chacun d'entre eux, calculer l'écart entre la quantité en stock et le seuil d'alerte
select *, qteart - salart from ARTICLE where codcat in ('pre');

-- 4. Calculer le nombre de commandes passées en 2007 et le nombre de fournisseurs concernés
select count(*) 'nombre de commandes passées', count(distinct numfour) 'Nombre de fournisseurs différents' from COMMANDE where year(datcom) = 2007;

-- 5. Quels sont les fournisseurs situés dans les départements 75, 78, 92 ? L'affichage sera effectué par département croissant puis par ordre alphabétique
-- v1
select * from FOURNISSEUR where cpfour like '75%' or cpfour like '78%' or cpfour like '92%' order by cpfour, villefour;

-- v2
select * from FOURNISSEUR where SUBSTR(cpfour, 1, 2) IN ('75', '78', '92') order by cpfour, villefour;

-- v3 - extraction du code postal en utilisant une expression régulière -
select * from FOURNISSEUR where adrfour regexp '(75|78|92)[0-9]{3}'
order by regexp_substr(adrfour, '(75|78|92)[0-9]{3}'), nomfour; 

-- 6. Trouver les fournisseurs susceptibles de fournir le produit I100. Afficher le numéro, le nom du fournisseur et le prix pratiqué. Trier les résultats du moins cher au plus cher
select f.numfour, nomfour, prutar from TARIF t inner join FOURNISSEUR f on t.numfour = f.numfour where t.refart = 'I100' order by prutar asc;

-- 7. Afficher le numéro et le nom des fournisseurs auxquels des commandes ont été passées
-- v1
select c.numfour, nomfour from COMMANDE c inner join FOURNISSEUR f on c.numfour = f.numfour group by c.numfour, nomfour;
-- v2
select numfour, nomfour from FOURNISSEUR where numfour in (select numfour from COMMANDE);
-- v3
select numfour, nomfour from FOURNISSEUR where exists (select 1 from COMMANDE c where c.numfour = numfour);
-- v4 - A éviter -
select distinct c.numfour, (select nomfour from FOURNISSEUR f where c.numfour = f.numfour) as nomfour from COMMANDE c;

-- 7bis. Afficher le numéro et le nom des fournisseurs auxquels aucune  commande n'a été passée
-- v1
select distinct f.numfour, nomfour from COMMANDE c right outer join FOURNISSEUR f on c.numfour = f.numfour where c.numfour is null;
-- v2
select numfour, nomfour from FOURNISSEUR where numfour not in (select numfour from COMMANDE);
-- v3
select numfour, nomfour from FOURNISSEUR where not exists (select 1 from COMMANDE where numfour = numfour);

-- 8. Calculer le total de chaque commande. Pour chaque commande, afficher le numéro de commande, le total, les trier par total décroissant
select l.numcom, sum(prutar * qtelig) MontantCommande from COMMANDE c join LIGNE l on c.numcom = l.numcom 
join TARIF t on l.refart = t.refart and c.numfour = t.numfour group by l.numcom order by MontantCommande desc;

-- * Calcul du total pour chaque commande en affichant le numéro de commande et en plus le numéro et le nom du fournisseur 
select c.numcom, f.numfour, nomfour, sum(prutar * qtelig)
from COMMANDE c join TARIF t on c.numfour = t.numfour 
				join LIGNE l on t.refart = l.refart and l.numcom = c.numcom
				join FOURNISSEUR f on c.numfour = f.numfour
group by c.numcom;

-- * Ajout de l'article I105 au fournisseur 09150 dans la table TARIF pour correspondre avec la table la table LIGNE
insert into TARIF(REFART, NUMFOUR, PRUTAR, INQTAR) values ('I105', '09150', 6, 'B');

-- * Ajout du total par commande dans la colonne TOTCOM de la table COMMANDE
update COMMANDE
set totcom = (select sum(prutar * qtelig) MontantCommande from LIGNE l join COMMANDE c on c.numcom = l.numcom join TARIF t on l.refart = t.refart and c.numfour = t.numfour where COMMANDE.numcom = l.numcom);

-- 9. Lister les commandes dont le montant est supérieur à 1500
select l.numcom, sum(prutar * qtelig) MontantCommande from COMMANDE c join LIGNE l on c.numcom = l.numcom join TARIF t on l.refart = t.refart and c.numfour = t.numfour group by l.numcom having MontantCommande > 1500 order by MontantCommande desc;

-- 10. Calculer le chiffre d'affaires réalisé avec chaque fournisseur
-- v1 -
select c.numfour, sum(prutar * qtelig) MontantCommande from COMMANDE c join LIGNE l on c.numcom = l.numcom join TARIF t on l.refart = t.refart and c.numfour = t.numfour group by c.numfour order by MontantCommande desc;
-- v2 - Calcul du chiffre d'affaires réalisé pour chaque fournisseur
select numfour, sum(totcom) from COMMANDE group by numfour;

-- Bonus -

-- 11. Compter le nombre de commandes passées par fournisseur. Pour chaque fournisseur, afficher le numéro du fournisseur, son nom. Trier les résultats par nombre de commandes décroissant
select c.numfour, nomfour, count(*) as NbCommandes from COMMANDE c join FOURNISSEUR f on c.numfour = f.numfour group by c.numfour, nomfour order by count(*) desc;

-- 12. Lister les fournisseurs susceptibles de livrer au moins 2 produits
-- Avant le tri - Tous les fournisseurs
select f.numfour, nomfour, count(*) 'Nombre de colis' from TARIF t join FOURNISSEUR f on t.numfour = f.numfour group by f.numfour, nomfour order by count(*) desc;
-- Après le tri - Les fournisseurs susceptibles de livrer au moins 2 produits
select f.numfour, nomfour, count(*) 'Nombre de colis' from TARIF t join FOURNISSEUR f on t.numfour = f.numfour group by f.numfour, nomfour having count(*) >= 2 order by count(*) desc;

-- 13. Trouver la liste des fournisseurs susceptibles de fournir les produits I100 et I105
select distinct t.numfour, nomfour from TARIF t join FOURNISSEUR f on t.numfour = f.numfour where t.refart in ('I100', 'I105');

select distinct t.numfour, nomfour from TARIF t join FOURNISSEUR f on t.numfour = f.numfour and t.refart in ('I100', 'I105');

select distinct f.numfour, f.nomfour from FOURNISSEUR f where f.numfour in (select t.numfour from TARIF t where t.refart in ('I100', 'I105'));

-- 14. Le fournisseur 00120 vous informe de ses nouveaux tarifs : ils augmentent tous de 5%. Mettre à jour la table tarif suite à cette information
set autocommit = false;
start transaction;
update TARIF 
set  prutar = prutar * 1.05 where numfour = '00120';
rollback;
commit;

-- 15. On vous livre 100 unités du produit I105, vous vous empressez de mettre à jour la fiche stock
update ARTICLE set qteart = qteart + 100 where refart = 'I105';

-- Vues -

-- Créer une vue TOTAL_COMMANDE pour calculer le total de chaque commande 
-- avec comme colonne le numéro de commande, la date de commande, le numéro du fournisseur, la raison sociale du fournisseur et le total de la commande

drop view TOTAL_COMMANDE; -- Permet de supprimer la vue TOTAL_COMMANDE

-- v1
create or replace view TOTAL_COMMANDE
as
select c.numcom, c.numfour, nomfour, DATCOM, sum(prutar * qtelig) as MontantTotal
from COMMANDE c join LIGNE l on c.numcom = l.numcom 
join TARIF t on l.refart = t.refart and  c.numfour = t.numfour 
join FOURNISSEUR f on c.numfour = f.numfour group by l.numcom;

select * from TOTAL_COMMANDE; -- Affiche le contenu de la vue TOTAL_COMMANDE
select * from TOTAL_COMMANDE  where numcom in ('070001') ; -- Affiche le contenu de la vue TOTAL_COMMANDE

-- v2
create or replace view TOTAL_COMMANDE2
as
select numcom, c2.numfour, f.nomfour, DATCOM, 
(select sum(prutar * qtelig) from COMMANDE c join LIGNE l on c.numcom = l.numcom join TARIF t on l.refart = t.refart and c.numfour = t.numfour where c2.numcom = l.numcom) as TOTCOM 
from COMMANDE c2 join FOURNISSEUR f on c2.numfour = f.numfour;

select * from TOTAL_COMMANDE2; -- Affiche le contenu de la vue TOTAL_COMMANDE2
select TOTCOM from TOTAL_COMMANDE2; -- Affiche le total des commandes par la vue TOTAL_COMMANDE2 en sélionnant TOTCOM (Total des commandes)
select TOTCOM from TOTAL_COMMANDE2 where numcom in ('070001'); -- Affiche le total de la commande 070001

-- Reprendre les requêtes 8,9,10 en utilisant la vue TOTAL_COMMANDE
-- 8bis. Calculer le total de chaque commande. Pour chaque commande, afficher le numéro de commande, le total, les trier par total décroissant
select * from TOTAL_COMMANDE order by MontantTotal desc;
select * from TOTAL_COMMANDE2 order by TOTCOM desc;

-- 9bis. Lister les commandes dont le montant est supérieur à 1500
select * from TOTAL_COMMANDE where MontantTotal > 1500 order by MontantTotal desc;
select * from TOTAL_COMMANDE2 where TOTCOM > 1500 order by TOTCOM desc;

-- 10bis. Calculer le chiffre d'affaires réalisé avec chaque fournisseur
select * from TOTAL_COMMANDE group by numfour;
select * from TOTAL_COMMANDE2 group by numfour;

-- Créer une vue TARIF avec le numéro de l'article, le nom de l'article, le prix, le numéro et le nom du fournisseur. 
create or replace view TARIF_VIEW
as
select a.refart 'Numéro de l''article', desart 'Nom de l''article', prutar 'Prix de l''article', f.numfour 'Numéro du fournisseur', nomfour 'Nom du fournisseur' 
from FOURNISSEUR f join TARIF t on f.numfour = t.numfour join ARTICLE a on t.refart = a.refart;

select * from TARIF_VIEW;

-- Est-il possible de réaliser la requête 14 en utilisant la vue TARIF_VIEW ?
-- Une vue peut être utilisée pour mettre à jour les données d'une table
-- Les insert et les update si une vue est basée sur une seule table, sans calculs,
-- ni fonction de groupe, ni distinct
-- Les insert sont possibles, en plus des conditions ci-dessus, si la vue voit toutes 
-- les colonnes non nulles de la table

-- BONUS ++

-- Chaque mois on crée une table avec le nom TARIF_AAMM pour sauvegarder les tarif du mois
CREATE TEMPORARY TABLE IF NOT EXISTS TARIF202301  (SELECT 202301 as AAMM, TARIF.* FROM TARIF); 

SELECT * FROM TARIF202301

UPDATE TARIF SET PRUTAR = PRUTAR * 1.1;

CREATE TEMPORARY TABLE IF NOT EXISTS TARIF202302  (SELECT 202302 as AAMM, TARIF.* FROM TARIF); 
--

SELECT * FROM TARIF202301;
SELECT * FROM TARIF202302;

-- Union : Addition entre table
SELECT * FROM TARIF202301
UNION
SELECT * FROM TARIF202302
ORDER BY NUMFOUR, REFART, AAMM;


UPDATE TARIF202302 SET PRUTAR = 20 WHERE NUMFOUR = '09180' AND REFART = 'B001'; 

-- on recherche les tarifs qui ont changé:
-- les lignes qui sont les mêmes entre TARIF202302 et TARIF202301 seront retirées de TARIF202302
SELECT NUMFOUR, REFART, PRUTAR FROM TARIF202302
EXCEPT
SELECT NUMFOUR, REFART, PRUTAR FROM TARIF202301;