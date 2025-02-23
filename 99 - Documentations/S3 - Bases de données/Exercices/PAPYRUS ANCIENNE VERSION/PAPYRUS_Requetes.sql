-- 1.	Quelles sont les numéros de commandes adressés au fournisseur 00120 ? 
--      Les trier de la plus récente à la plus ancienne
select NUCOM, DTCOM, NUFOUR
from COMMANDE 
where NUFOUR = 00120
order by DTCOM desc;

-- 2.	Afficher les produits ayant un stock inférieur ou égal au stock d'alerte
select * 
from PRODUIT
where STOCK <= ALERT
order by REFPROD;

-- 3.	Afficher tous les produits qui sont des pré-imprimés. 
--      Pour chacun d'entre eux, calculer l'écart entre la quantité en stock et le seuil d'alerte.
select REFPROD, DESIG, STOCK, ALERT, (STOCK - ALERT) as 'Ecart entre la quantité en stock et le seuil d''alerte'
from PRODUIT
where DESIG like '%Pré-imprimé%';

-- 4.	Calculer le nombre de commandes passées en 2007
--      et le nombre de fournisseurs concernés.
select  count(NUCOM) as "Nb commandes", 
		count(distinct NUFOUR) as "Nb Fournisseurs"
from 	COMMANDE
where 	YEAR(DTCOM) = 2007;

-- 5.	Quels sont les fournisseurs situés dans les départements 75, 78, 92 ? 
--      L'affichage sera effectué par département croissant puis par ordre alphabétique
select * from FOURNISSEUR order by CDPOST;

select NUFOUR, RAISOC , CDPOST , VILLE 
from FOURNISSEUR
where CDPOST like '75%' or CDPOST like '78%' or CDPOST like '92%'
order by CDPOST, VILLE;

-- On peut utiliser une fonction
select NUFOUR, RAISOC , CDPOST , VILLE
FROM FOURNISSEUR
where SUBSTR(CDPOST, 1, 2) IN ('75', '78', '92')
order by CDPOST, VILLE;

-- Pour tester
select SUBSTR('12100', 1, 2);

select SUBSTR(CDPOST, 1, 2)
from FOURNISSEUR;

-- 6.	Trouver les fournisseurs susceptibles de fournir le produit I100. 
--      Afficher le numéro, la raison sociale du fournisseur et le prix pratiqué.
--      Trier les résultats du moins cher au plus cher.
select f.NUFOUR, f.RAISOC, t.REFPROD, t.PUACH
from TARIF t join FOURNISSEUR f on t.NUFOUR = f.NUFOUR
where t.REFPROD = 'I100'
order by PUACH; 

-- 7.	Afficher le numéro et la raison sociale des fournisseurs 
--      auxquels des commandes ont été passées.
select distinct f.NUFOUR, f.RAISOC
from FOURNISSEUR f join COMMANDE c on f.NUFOUR = c.NUFOUR ; 

select NUFOUR, RAISOC, (select count(NUCOM) from COMMANDE c where c.nufour = f.nufour) 
-- Pas besoin de distinct car les fournisseurs sont uniques dans la table FOURNISSEUR
from FOURNISSEUR f
where NUFOUR in (select NUFOUR from COMMANDE);

-- Si en plus on veut afficher le nombre de commandes
select f.NUFOUR, f.RAISOC, count(c.NUCOM)
from FOURNISSEUR f join COMMANDE c on f.NUFOUR = c.NUFOUR 
group by f.NUFOUR, f.RAISOC;

-- 8.	Calculer le total de chaque commande. 
--      Pour chaque commande, afficher le numéro de commande, le total
--      les trier par total décroissant.
select NUCOM, sum(QTECOM * PU) as TOTAL
from LIGNE_COMMANDE
group by NUCOM 
order by TOTAL desc;

select c.NUCOM, c.DTCOM, c.NUFOUR, sum(lc.QTECOM * lc.PU) as TOTAL
from LIGNE_COMMANDE lc join COMMANDE c on c.NUCOM = lc.NUCOM 
group by c.NUCOM, c.DTCOM, c.NUFOUR 
order by TOTAL desc;

select c.NUCOM, c.DTCOM, c.NUFOUR, f.RAISOC, sum(lc.QTECOM * lc.PU) as TOTAL
from LIGNE_COMMANDE lc join COMMANDE c on c.NUCOM = lc.NUCOM 
                       join FOURNISSEUR f on f.NUFOUR = c.NUFOUR
group by c.NUCOM, c.DTCOM, c.NUFOUR 
order by TOTAL desc;

-- 9.	Lister les commandes dont le montant est supérieur à 1500.
select c.NUCOM, c.DTCOM, c.NUFOUR, sum(lc.QTECOM * lc.PU) as TOTAL
from LIGNE_COMMANDE lc join COMMANDE c on c.NUCOM = lc.NUCOM 
group by c.NUCOM, c.DTCOM, c.NUFOUR 
having TOTAL > 1500;

-- 10. Calculer le CA réalisé avec chaque fournisseur
select c.NUFOUR, f.RAISOC, sum(lc.QTECOM * lc.PU) as CA
from LIGNE_COMMANDE lc join COMMANDE c on c.NUCOM = lc.NUCOM 
                       join FOURNISSEUR f on f.NUFOUR = c.NUFOUR
group by c.NUFOUR, f.RAISOC; 

-- 11.	Compter le nombre de commandes passées par fournisseur. 
--      Pour chaque fournisseur, afficher le numéro du fournisseur, la raison sociale. 
--      Trier les résultats par nombre de commandes décroissant.
select count(nucom), c.nufour, f.raisoc from COMMANDE c join FOURNISSEUR f 
where c.nufour = f.nufour group by c.nufour order by count(nucom) desc

-- 12.	Lister les fournisseurs susceptibles de livrer au moins 2 produits
Select f.NUFOUR, f.RAISOC, count(*) as NbProduits
from FOURNISSEUR f join TARIF t on f.NUFOUR = t.NUFOUR
group by f.NUFOUR, f.RAISOC 
having count(*) >= 2; 

-- 13.	Trouver la liste des fournisseurs susceptibles de fournir
--      les produits I100 et I105
select f.nufour, f.raisoc, t.refprod, t.puach from TARIF t join 
FOURNISSEUR f on t.nufour = f.nufour where t.refprod = 'I100' or t.refprod = 'I105';

-- 14.	Le fournisseur 00120 vous informe de ses nouveaux tarifs pour 2008 : ils augmentent tous de 5%. 
--      Mettre à jour la table tarif suite à cette information.
update TARIF t
set puach = puach * 1.05 where nufour = 00120;

-- 15.	On vous livre 100 unités du produit I105, vous vous empressez de mettre à jour la fiche stock.
select refprod, stock from PRODUIT p where refprod = 'I105'

update PRODUIT 
set stock = stock + 100 where refprod = 'I105';


