/*
REQUÊTES SQL Á IMPLÉMENTER 
Sous-langage : DQL / LRD
Data Query Language
Langage de requête sur les données

Principales instructions :
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/
use mini_faq;

/* 1. Sélectionner tous les utilisateurs (identifiant, nom, prénom, email). */
SELECT user_id, user_lastname, user_firstname, user_email
FROM users;

/* 2.Sélectionner toutes les questions (date, intitulé, réponse, identifiant utilisateur) triées par date de la plus ancienne à la plus récente. */
SELECT question_date, question_response, user_id
FROM questions
ORDER BY question_date;

/* 3. Sélectionner les questions (identifiant, date, intitulé, réponse) de l’utilisateur n°2. */
SELECT question_id, question_date, question_label, question_response
FROM questions
WHERE user_id=2;

/* 4. Sélectionner les questions (date, intitulé, réponse, identifiant utilisateur) de l’utilisateur Eva Satiti. */
SELECT question_date, question_label, question_response, q.user_id
FROM questions q
JOIN users u 
ON q.user_id = u.user_id
WHERE user_lastname='Satiti' && user_firstname='Eva';

/* 5. Sélectionner les questions (identifiant, date, intitulé, réponse, identifiant utilisateur) dont l’intitulé contient “SQL”. Le résultat est trié par le titre et par ordre décroissant. */
SELECT question_id, question_date, question_label, question_response, user_id
FROM questions
WHERE question_label LIKE '%SQL%'
ORDER BY question_label DESC;

/* 6. Sélectionner les catégories (nom, description) sans question associée. */
SELECT c.category_name, category_description
FROM categories c
LEFT JOIN categories_questions cq
ON c.category_name = cq.category_name
WHERE cq.category_name IS NULL;

/* 7. Sélectionner les questions triées par titre (ordre alphabétique) avec le nom et prénom de l’auteur (nécessite une jointure). */
SELECT question_id, question_date, question_label, question_response, u.user_id, user_lastname, user_firstname
FROM questions q
JOIN users u
ON u.user_id = q.user_id
ORDER BY question_label;

/* 8. Sélectionner les catégories (nom) avec, pour chaque catégorie le nombre de questions associées (nécessite une jointure). */
SELECT c.category_name, count(c.category_name)
FROM categories c
JOIN categories_questions cq
JOIN questions q
ON c.category_name = cq.category_name AND cq.question_id = q.question_id
GROUP BY c.category_name;