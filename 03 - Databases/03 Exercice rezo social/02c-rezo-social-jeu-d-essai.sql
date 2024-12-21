/* INSÉRER LE JEU D'ESSAI DANS LA TABLE "utilisateur" */

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
USE rezo_social;

TRUNCATE TABLE utilisateur_publication; -- vider la table publication_utilisateur
TRUNCATE TABLE publication; -- vider la table publication et réinitialise l'AUTO_INCREMENT
TRUNCATE TABLE utilisateur; -- vider la table utilisateur

/* Insertion des données dans la table "utilisateur" */
INSERT INTO utilisateur
(id, nom_utilisateur, email)
VALUES 
(1,	"Zorro", "zorb@example.com"),
(2,	"Patchouli", "patchouli@example.fr"),
(3,	"Eva", "eva.stt@example.com");

INSERT INTO publication
(pub_id, pub_date, pub_titre, pub_contenu, id)
VALUES 
(NULL, "2024-11-23 14:30", "Il fait beau", "Quel beau soleil aujourd'hui !", 3),
(NULL, "2024-11-23 09:15", "Les bonbons", "Les bonbons, c'est bon", "2"),
(NULL, "2024-11-27 08:17", "Super resto", "J'ai découvert un super restaurant hier soir.", 1),
(NULL, "2024-12-05 17:52", "Album disponible", "Nouvel album de mon groupe préféré !", 2),
(NULL, "2024-12-15 10:05", "Aidez-moi", "Je cherche une recette de gâteau au chocolat.", 3);