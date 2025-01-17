/*
Sous-langage : DML / MLD
Data Manipulation Language
Langage de Manipulation de Données

Principales instructions :
INSERT : Ajouter des nouvelles données dans une table
UPDATE : Mettre à jour des données existantes dans une table
DELETE : Supprimer des données existantes dans une table
TRUNCATE : Vider une table
*/

-- Sélectionner la base de données 
USE tp2;

INSERT INTO AVION
(AV, AVMARQ, AVTYPE, CAP, LOC)
VALUES
(100, 'AIRBUS', 'A320', 300, 'Nice'),
(101, 'BOEING', 'B707', 250, 'Paris'),
(102, 'AIRBUS', 'A320', 300, 'Toulouse'),
(103, 'CARAVELLE', 'Caravelle', 200, 'Toulouse'),
(104, 'BOEING', 'B747', 400, 'Paris'),
(105, 'AIRBUS', 'A320', 300, 'Grenoble'),
(106, 'ATR', 'ATR42', 50, 'Paris'),
(107, 'BOEING', 'B727', 300, 'Lyon'),
(108, 'BOEING', 'B727', 300, 'Nantes'),
(109, 'AIRBUS', 'A340', 350, 'Bastia');

INSERT INTO PILOTE
(PILNOM, ADR)
VALUES 
('SERGE', 'Nice'),
('JEAN', 'Paris'),
('CLAUDE', 'Grenoble'),
('ROBERT', 'Nantes'),
('SIMON', 'Paris'),
('LUCIEN', 'Toulouse'),
('BERTRAND', 'Lyon'),
('HERVE', 'Bastia'),
('LUC', 'Paris');

INSERT INTO VOL
(VOL, AV, PIL, VD, VA, HD, HA)
VALUES 
('IT100', 100, 1, 'Nice', 'Paris', 7, 9),
('IT101', 102, 2, 'Paris', 'Toulouse', 11, 12),
('IT102', 101, 1, 'Paris', 'Nice', 12, 14),
('IT103', 105, 3, 'Grenoble', 'Toulouse', 9, 11),
('IT104', 109, 3, 'Toulouse', 'Grenoble', 17, 19),
('IT105', 107, 7, 'Lyon', 'Paris', 6, 7),
('IT106', 109, 8, 'Bastia', 'Paris', 10, 13),
('IT107', 106, 9, 'Paris', 'Brive', 7, 8),
('IT108', 106, 9, 'Brive', 'Paris', 19, 20),
('IT109', 107, 7, 'Paris', 'Lyon', 18, 19),
('IT110', 109, 2, 'Toulouse', 'Paris', 15, 16),
('IT111', 101, 4, 'Nice', 'Nantes', 17, 19),
('IT112', 103, 5, 'Paris', 'Nice', 11, 13),
('IT113', 104, 6, 'Nice', 'Paris', 13, 15);
