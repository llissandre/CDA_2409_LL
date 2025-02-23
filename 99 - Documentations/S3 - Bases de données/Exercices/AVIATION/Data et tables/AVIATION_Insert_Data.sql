
-- ============================================================
-- Génération des données de test pour la table "AVION".       
-- ============================================================
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('067', 'AIRBUS A300', 240, 'TOULOUSE');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('100', 'AIRBUS', 350, 'TOULOUSE');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('101', 'DOUGLAS',200, 'BORDEAUX');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('104', 'BOEING', 150, 'PARIS');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('105', 'CARAVELLE', 250, 'PARIS');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('124', 'AIRBUS A300', 233, 'TOULOUSE');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('125', 'AIRBUS A300', 251, 'LYON');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('143', 'AIRBUS A310', 230, 'PARIS');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('145', 'BOEING 707', 233, 'TOULOUSE');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('148', 'BOEING 727', 344, 'PARIS');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('177', 'DC8', 150, 'LYON');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('180', 'DC10', 350, 'TOULOUSE');
insert into AVION (AVNO, AVNOM, AVCAP, AVLOC) values ('194', 'BOEING 747', 350, 'PARIS');
-- ============================================================
-- Génération des données de test pour la table "PILOTE".      
-- ============================================================
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('011', 'DELAUNAY', 'MILLAU', 13000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('014', 'BRUDY', 'MILLAU', 18500);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('015', 'MARTIN', 'VALENCE', 17500);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('024', 'MONTOIS', 'LYON', 17680);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('028', 'JORY', 'LA CRESSE', 34000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('034', 'LOPEZ', 'LYON', 35000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('042', 'BECKER', 'LILLE', 21000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('056', 'ROUSSEAU', 'NICE', 17543);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('061', 'LEFEVRE', 'MARSEILLE', 1100);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('062', 'FOURNIER', 'ORLEANS', 12600);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('063', 'SCHMITT', 'BORDEAUX', 34900);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('067', 'GASTON', 'MILLAU', 12000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('068', 'HENRY', 'SAINT AFFRIQUE', 23000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('072', 'VINCENT', 'ARCACHON', 27400);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('082', 'COMMAULT', 'STASBOURG', 13800);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('099', 'ROY', 'MENDE', 8750);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('100', 'PIERRE', 'PARIS', 15000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('101', 'PIERRE', 'PARIS', 11000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('102', 'PAUL', 'PARIS', 12000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('109', 'JEAN', 'PARIS', 34000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('110', 'PAUL', 'PARIS', 25000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('120', 'HECTOR', 'LYON', 25000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('130', 'SERGE', 'TOULOUSE', 15000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('140', 'MICHEL', 'TOULOUSE', 20000);
insert into PILOTE (PILNO, PILNOM, PILADR, PILSAL) values ('163', 'GUYOMARD', 'RODEZ', 25000);
-- ============================================================
-- Génération des données de test pour la table "VOL".         
-- ============================================================
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('001', '109', '100', 'TORONTO', 'NEW-YORK');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('002', '110', '100', 'CARACAS', 'RIO');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('003', '109', '101', 'PARIS', 'NICE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('004', '120', '104', 'PARIS', 'LILLE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('005', '130', '105', 'PARIS', 'MOSCOU');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('006', '140', '105', 'PARIS', 'BREST');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('100', '024', '067', 'PARIS', 'ALGER');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('112', '063', '194', 'MARSEILLE', 'TOULOUSE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('120', '163', '145', 'BERLIN', 'PRAGUE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('125', '062', '125', 'LILLE', 'PARIS');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('130', '072', '105', 'MARSEILLE', 'PARIS');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('135', '102', '100', 'BAMAKO', 'ABIDJAN');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('140', '130', '101', 'GAO', 'ALGER');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('150', '028', '100', 'KATMANDOU', 'DELHI');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('161', '011', '124', 'SOFIA', 'LONDRES');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('165', '056', '177', 'PARIS', 'ROME');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('180', '130', '194', 'BRUXELLE', 'GENEVE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('201', '099', '125', 'LILLE', 'DUBLIN');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('341', '063', '143', 'MILLAU', 'SAINT AFFRIQUE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('400', '063', '067', 'PARIS', 'LONDRES');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('401', '067', '100', 'MARSEILLE', 'DUBLIN');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('402', '063', '100', 'MARSEILLE', 'BOHN');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('404', '063', '104', 'TOULOUSE', 'ROME');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('405', '063', '105', 'LILLE', 'MADRID');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('406', '063', '124', 'BORDEAUX', 'STOCKOLM');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('407', '063', '125', 'MARSEILLE', 'BRUXELLE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('409', '063', '145', 'PARIS', 'LISBONNE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('410', '063', '148', 'TOULOUSE', 'COPENHAGUE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('411', '063', '177', 'BORDEAUX', 'LUXEMBOURG');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('415', '063', '180', 'MILLAU', 'OSLO');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('420', '063', '101', 'DIEPPE', 'LE HAVRE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('421', '063', '101', 'PARIS', 'MARSEILLE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('430', '063', '101', 'DIEPPE', 'LE HAVRE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('500', '011', '125', 'DELHI', 'DJAKARTA');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('501', '011', '143', 'PEKIN', 'TOKYO');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('505', '011', '067', 'BANCKOK', 'HANOI');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('506', '011', '100', 'DJIBOUTI', 'BAGDAD');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('600', '109', '194', 'MADRID', 'LISBONNE');
insert into VOL (VOLNO, PILNO, AVNO, VOLDEP, VOLARR) values ('601', '109', '180', 'BALI', 'HAWAI');
commit;
                

