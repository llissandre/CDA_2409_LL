-- 
-- ETUDIANTS_ET_NOTES - Insertion des données dans les tables
-- 

-- Les tables doivent être créées avant de lancer ce script 

-- Désactiver les contraintes de clé étrangère dans MySQL
set foreign_key_checks = 0;

-- Deux méthodes pour supprimer le contenu des tables
TRUNCATE TABLE ETUDIANT;
TRUNCATE TABLE MATIERE;
TRUNCATE TABLE EVALUATION;

-- Réactiver les contraintes de clé étrangère dans MySQL
SET foreign_key_checks = 1;

-- ============================================================
-- 1 - Génération des données pour la table ETUDIANT
-- ============================================================
insert into ETUDIANT (NumEtudiant, Nom, Prenom) values
('E1', 'DUBOIS', 'Pierre'),
('E2', 'DUPUIS', 'Paul'),
('E3', 'DUPOND', 'Marie'),
('E4', 'DURAND', 'Cecile');

-- ============================================================
-- 2 - Génération des données pour la table MATIERE
-- ============================================================
insert into MATIERE (CodeMat, LibelleMat, NomProf) values
('M1', 'MATHS',	'BG'),
('M2', 'ANGLAIS', 'SK'),
('M3', 'GESTION', 'CM'),
('M4', 'INFORMATIQUE', 'GG');

-- ============================================================
-- 3 - Génération des données pour la table EVALUATION
-- ============================================================
insert into EVALUATION (NumEtudiant, CodeMat, DateEval, Note) values
('E1', 'M1', '2018-01-10', 12),
('E2', 'M1', '2018-01-10', 14),
('E3', 'M1', '2018-01-10', 8),
('E1', 'M2', '2018-02-15', 8),
('E2', 'M2', '2018-02-15', 15),
('E3', 'M2', '2018-02-15', 11),
('E1', 'M2', '2018-03-25', 8),
('E2', 'M2', '2018-03-25', 9),
('E3', 'M2', '2018-03-25', 10),
('E1', 'M4', '2018-03-25', 14),
('E2', 'M4', '2018-03-25', 12),
('E3', 'M4', '2018-03-25', 13);

-- Validation des lignes ajoutées ci-dessus
commit;