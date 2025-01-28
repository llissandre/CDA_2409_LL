/*
Sous-langage : DML / MLD
Data Manipulation Language
Langage de Manipulation de Données
*/

-- Sélectionner la base de données 
USE kiloutout;

INSERT INTO type_de_bien
(type_de_bien_nom)
VALUES
("maison"),
("appartement");

INSERT INTO proprietaire
(proprietaire_id, proprietaire_nom, proprietaire_prenom, proprietaire_adresse, proprietaire_telephone)
VALUES
(1, "Durant", "Pascal", "10 rue de la marine, 68000 Colmar", "03.89.89.87.87"),
(2, "Martinez", "Joëlle", "18 avenue des peupliers, 68100 Mulhouse", "03.89.12.13.14"),
(3, "Bowé", "Samira", "21 rue du musée, 67000 Starsbourg", "07.32.21.16.65");

INSERT INTO bien
(bien_id, bien_situation, bien_surface, bien_loyer_mensuel, type_de_bien_id, proprietaire_id)
VALUES
(1, "32 rue de Cherbourg 68100 Mulhouse", 100, 800, 2, 1),
(2, "325 boulevard des majorettes 68000 Colmar", 65, 490, 2, 1),
(3, "11 rue de Mulhouse 68400 Riedisheim", 160, 1450, 1, 2),
(4, "17A avenue des peupliers 68100 Mulhouse", 85, 750, 2, 2),
(5, "17B avenue des peupliers 68100 Mulhouse", 70, 625, 2, 3);

INSERT INTO contrat
(bien_id, Kiloutout, contrat_id, contrat_pourcentage, contrat_duree)
VALUES
(2, "Kiloutout", 1, 8, 120),
(5, "Kiloutout", 2, 10, 96);

INSERT INTO locataire
(locataire_id, locataire_nom, locataire_prenom, locataire_telephone)
VALUES
(1, "Dubosc", "Jacqueline", "06.99.99.88.77"),
(2, "Di Marco", "Philippe", "09.72.73.74.75");

INSERT INTO bail
(bien_id, bail_id, bail_duree, bail_date_debut, locataire_id)
VALUES
(2, 1, 72, "2025-02-01", 1),
(5, 2, 36, "2024-11-01", 2);

