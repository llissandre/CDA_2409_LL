/*
REQUÊTES SQL Á IMPLÉMENTER 
Sous-langage : DQL / LRD
Data Query Language
Langage de requête sur les données

Principales instructions :
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/
use tp2;

/* ------- */
/* Enoncés */
/* ------- */

/* 1 - quels sont les vols au départ de Paris entre 12h et 14h ? */
SELECT VOL
FROM VOL
WHERE HD BETWEEN 12 AND 14;

/* 2 - Quels sont les pilotes dont le nom commence par "S" ? */
SELECT PIL, PILNOM
FROM PILOTE
WHERE PILNOM LIKE 'S%';

/* 3 - Pour chaque ville, donner le nombre et les capacités minimum et maximum des avions qui s'y trouvent. */
SELECT LOC, count(AV) AS 'Nombre d\'avion', min(CAP) AS 'Capacité minimale', max(CAP) AS 'Capacité maximale'
FROM AVION
GROUP BY LOC;

/* 4 - Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et cela par type d'avion. */
SELECT LOC AS 'Localisation', AVTYPE AS 'Type d\'avion', round(avg(CAP)) AS 'Capacité moyenne des avions'
FROM AVION
GROUP BY LOC, AVTYPE;

/* 5 - Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1 avion ? */
SELECT LOC AS 'Localisation', count(AV) AS 'Nombre d\'avion', round(avg(CAP)) AS 'Capacité moyenne des avions'
FROM AVION
GROUP BY LOC
HAVING count(AV) > 1;

/* 6 - Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un Airbus */
SELECT PILNOM
FROM PILOTE, AVION
WHERE PILOTE.ADR = AVION.LOC AND AVION.AVMARQ = 'AIRBUS';

/* 7 - Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans la ville de localisation d'un Airbus ? */
SELECT PILNOM
FROM PILOTE, AVION
WHERE PILOTE.ADR = AVION.LOC AND AVION.AVMARQ = 'AIRBUS'
AND PILNOM IN (SELECT PILNOM FROM VOL v JOIN AVION a ON v.AV = a.AV JOIN PILOTE p ON p.PIL = v.PIL WHERE AVMARQ = 'AIRBUS');

/* 8 - Quels sont les noms des pilotes qui conduisent un Airbus ou qui habitent dans la ville de localisation d'un Airbus ? */
SELECT DISTINCT PILNOM
FROM PILOTE, AVION
WHERE PILOTE.ADR = AVION.LOC AND AVION.AVMARQ = 'AIRBUS'
OR PILNOM IN (SELECT PILNOM FROM VOL v JOIN AVION a ON v.AV = a.AV JOIN PILOTE p ON p.PIL = v.PIL WHERE AVMARQ = 'AIRBUS');

/* 9 - Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui habitent dans la ville de localisation d'un Airbus ? */
SELECT DISTINCT PILNOM 
FROM VOL v 
JOIN AVION a ON v.AV = a.AV 
JOIN PILOTE p ON p.PIL = v.PIL
WHERE AVMARQ = 'AIRBUS' AND PILNOM NOT IN (SELECT PILNOM FROM PILOTE, AVION WHERE PILOTE.ADR = AVION.LOC AND AVION.AVMARQ = 'AIRBUS');

/* 10 - Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par Serge ? */
SELECT VOL AS Vols
FROM PILOTE p
JOIN VOL v ON p.PIL = v.PIL
WHERE VD IN (SELECT VD FROM VOL v JOIN PILOTE p ON v.PIL = p.PIL WHERE PILNOM = 'SERGE')
AND VA IN (SELECT VA FROM VOL v JOIN PILOTE p ON v.PIL = p.PIL WHERE PILNOM = 'SERGE');

/* 11 - Donner toutes les paires de pilotes habitant la même ville ( sans doublon ). */
SELECT p.PILNOM, d.PILNOM
FROM PILOTE p
JOIN PILOTE d ON p.ADR = d.ADR
WHERE p.ADR = d.ADR AND p.PIL != d.PIL;

/* 12 - Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le pilote n°1 ? */
SELECT PILNOM
FROM PILOTE p
JOIN VOL v ON p.PIL = v.PIL
WHERE AV IN (SELECT AV FROM VOL WHERE PIL = 1) AND v.PIL != 1;

/* 13 - Donner toutes les paires de villes telles qu'un avion localisé dans la ville de départ soit conduit par un pilote résidant dans la ville d'arrivée. */
SELECT *
FROM VOL v
JOIN PILOTE p ON v.PIL = p.PIL
WHERE v.VA = p.ADR;

/* 14 - Sélectionner les numéros des pilotes qui conduisent tous les Airbus ? */
SELECT DISTINCT p.PIL
FROM PILOTE p
JOIN VOL v ON p.PIL = v.PIL
JOIN AVION a ON v.AV = a.AV
WHERE ADR = LOC AND AVMARQ = 'AIRBUS';