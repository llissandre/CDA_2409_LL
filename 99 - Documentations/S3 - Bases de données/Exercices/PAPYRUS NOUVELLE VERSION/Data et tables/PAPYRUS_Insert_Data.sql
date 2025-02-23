-- 
-- PAPYRUS - Insertion des données dans les tables
-- 

-- Les tables doivent être créées avant de lancer ce script 

-- Désactiver les contraintes de clé étrangère dans MySQL
set foreign_key_checks = 0;

-- Deux méthodes pour supprimer le contenu des tables
TRUNCATE TABLE CATEGORIE;
TRUNCATE TABLE ARTICLE;
TRUNCATE TABLE FOURNISSEUR;
DELETE FROM COMMANDE;
DELETE FROM TARIF;
DELETE FROM LIGNE;

-- Réactiver les contraintes de clé étrangère dans MySQL
SET foreign_key_checks = 1;

-- ============================================================
-- 1 - Génération des données pour la table CATEGORIE
-- ============================================================
insert into CATEGORIE (CODCAT, LIBCAT) values
('CON', 'Papier en continu'),
('PRE', 'Pré-imprimé'),
('RUB', 'Ruban imprimante'),
('BMA', 'Bande magnétique'),
('CDR', 'CD réinscriptible');

-- ============================================================
-- 2 - Génération des données pour la table ARTICLE
-- ============================================================
insert into ARTICLE (REFART, DESART, QTEART, SALART, CODCAT) values
('I100','Papier 1 ex continu',550,100,'CON'),
('I105','Papier 2 ex continu',5,75,'CON'),
('I108','Papier 3 ex continu',550,100,'CON'),
('I110','Papier 4 ex continu',12,10,'CON'),
('P220','Pré-imprimé commande',500,500,'PRE'),
('P230','Pré-imprimé facture',250,500,'PRE'),
('P240','Pré-imprimé bulletin paie',3000,500,'PRE'),
('P250','Pré-imprimé bon livraison',2500,500,'PRE'),
('P270','Pré-imprimé bon fabrication',2500,500,'PRE'),
('R080','Ruban Epson 850',2,10,'RUB'),
('R132','Ruban Epson 950',5,5,'RUB'),
('B002','Bande magnétique 6250',12,20,'BMA'),
('B001','Bande magnétique 1200',40,30,'BMA'),
('D035','CD R slim 80',40,25,'CDR'),
('D050','CD R-W 80',4,5,'CDR');

-- ============================================================
-- 3 - Génération des données pour la table FOURNISSEUR
-- ============================================================
insert into FOURNISSEUR (NUMFOUR, NOMFOUR, ADRFOUR, CPFOUR, VILLEFOUR, TELFOUR) values
('00120','GROBRIGAN','20 rue du papier', '92200', 'PAPERCITY',''),
('00540','ECLIPSE','','78250', 'BUGVILLE',''),
('08700','MEDICIS','120 rue des plantes', '75014', 'PARIS',''),
('09120','DISCOBOL','11 rue de la république', '85100', 'LA ROCHE SUR YON',''),
('09150','DEPANPAP','17 Rue Stine','59000', 'LILLES',''),
('09180','HURRYTAPE','68 bd des octets', '04044', 'DUMPVILLE','');

-- ============================================================
-- 4 - Génération des données pour la table COMMANDE
-- ============================================================
insert into COMMANDE (NUMCOM, DATCOM, NUMFOUR, TOTCOM) values
('070001','2007-02-10','00120', 0),
('070002','2007-03-01','00540', 0),
('070003','2007-04-25','09180', 0),
('070004','2007-04-30','09150', 0),
('070005','2007-05-05','00120', 0),
('070006','2007-06-06','09120', 0),
('070007','2007-10-02','08700', 0),
('070008','2007-10-02','00540', 0),
('070009','2007-10-12','00120', 0),
('070010','2007-10-12','09180', 0);

-- ============================================================
-- 5 - Génération des données pour la table TARIF
-- ============================================================
insert into TARIF (REFART, NUMFOUR, PRUTAR, INQTAR) values
('I100','00120',10,'A'),
('I100','00540',11,'A'),
('I100','08700',12,'C'),
('I100','09120',13,'B'),
('I100','09150',14,'B'),
('I105','00120',10,'C'),
('I105','00540',20,'A'),
('I105','08700',15,'A'),
('I108','00120',5,'C'),
('I108','09120',10,'C'),
('I110','09180',5,'A'),
('I110','09120',10,'A'),
('D035','00120',5,'B'),
('D035','09120',6,'B'),
('I105','09120',10,'B'),
('P220','00120',10,'C'),
('P230','00120',20,'C'),
('P240','00120',20,'A'),
('P250','09120',10,'A'),
('P220','08700',20,'B'),
('P230','08700',25,'B'),
('R080','09120',30,'C'),
('R132','09120',40,'A'),
('B001','09180',20,'A'),
('B002','09180',30,'A');

-- ============================================================
-- 6 - Génération des données pour la table LIGNE
-- ============================================================
insert into LIGNE (NUMCOM, REFART, QTELIG) values
('070001','I100',100),
('070001','I105',200),
('070001','I108',100),
('070001','D035',200),
('070001','P220',100),
('070001','P240',300),
('070002','I105',100),
('070003','B001',10),
('070003','B002',10),
('070004','I100',100),
('070004','I105',200),
('070005','I100',100),
('070005','P220',100),
('070006','I110',50),
('070007','P230',150),
('070007','P220',100),
('070008','I105',50),
('070009','I100',50),
('070009','P220',100),
('070010','B001',200),
('070010','B002',200);

-- Validation des lignes ajoutées ci-dessus
commit;