-- * - Elaborerez les requêtes SQL pour répondre aux demandes ci-après - * --
-- *Quand ce sera pertinent, vous pourrez créer des vues.

-- 1.	Quel est le nombre d’étudiants ?
select count(*) from ETUDIANT;

-- 2.	Quel est le nombre d’étudiants notés ?
select count(distinct NumEtudiant) from EVALUATION;

-- 3.	Afficher le relevé de toutes les notes de l’étudiant nommé DUBOIS. Afficher le libellé de la matière, la date de l’évaluation et la note obtenue. Trier par libellé matière puis date d’évaluation.
select m.LibelleMat, DateEval, Note from MATIERE m join EVALUATION e on m.CodeMat = e.CodeMat join ETUDIANT e2 on e.NumEtudiant = e2.NumEtudiant where Nom in ('DUBOIS') order by m.LibelleMat, DateEval;

-- 4.	Afficher le nom et le prénom des étudiants qui ont au moins une note inférieure à 10 en MATHS ou en ANGLAIS. Trier les résultats par ordre alphabétique. Le nom et le prénom seront concaténés.
select distinct concat(Nom,' ', Prenom) as Identite from MATIERE m join EVALUATION e on m.CodeMat = e.CodeMat join ETUDIANT e2 on e.NumEtudiant = e2.NumEtudiant 
where Note < 10 and LibelleMat in ('MATHS', 'ANGLAIS') order by Identite;

-- 5.	Afficher les matières qui ont fait l'objet d’aucune évaluation ? Afficher le libellé de la matière et le nom du prof.
select LibelleMat, NomProf from MATIERE m left join EVALUATION e on m.CodeMat = e.CodeMat where e.CodeMat is null;

select LibelleMat, NomProf from MATIERE m where not exists (select 1 from EVALUATION e where m.CodeMat = e.CodeMat);

-- 6.	Quelles sont les matières qui ont fait l'objet d'au moins 2 évaluations ? Afficher le nom de Prof et Libellé de Matière. Les résultats seront triés par Nom de Prof et Libellé de Matière.
select LibelleMat, NomProf, count(*) from MATIERE m join EVALUATION e on m.CodeMat = e.CodeMat group by e.CodeMat having count(*) > 2 order by NomProf, LibelleMat;

-- 7.	Pour chaque évaluation, afficher le nombre d'étudiants qui ont été évalués, la moyenne des notes, la note la plus basse et la note la plus haute. Trier les évaluations d'une même matière de la plus récente à la plus ancienne.
select count(*) as NbEtudiant, round(avg(Note),2) as Moyenne, min(Note) as NoteMinale, Max(Note) as NoteMaximale from EVALUATION group by DateEval, CodeMat;

-- 8.	Les notes du dernier contrôle d'anglais ne sont pas bonnes, une erreur s'est glissée dans l'énoncé du dernier contrôle d'anglais. C'est pourquoi, pour ne pas pénaliser les étudiants, le professeur décide d'ajouter 2 points à toutes les notes de cette évaluation. Ecrire une requête pour ajouter 2 points aux notes du contrôle d’anglais du 25/03/2018.
update EVALUATION set Note = Note + 2 where DateEval in ('2018-03-25') and  CodeMat = (select distinct m.CodeMat from EVALUATION e join MATIERE m on e.CodeMat = m.CodeMat where LibelleMat in ('ANGLAIS'));

select distinct m.CodeMat from EVALUATION e join MATIERE m on e.CodeMat = m.CodeMat where LibelleMat in ('ANGLAIS');

-- 9.	L’étudiant E4 était absent. Il vient de rattraper son évaluation en INFORMATIQUE et a obtenu la note 15. Insérer la ligne correspondante dans la table Evaluation. La date de l’évaluation sera la date du jour.
insert into EVALUATION (NumEtudiant, CodeMat, DateEval, Note) values
('E4', (select distinct m.CodeMat from EVALUATION e join MATIERE m on e.CodeMat = m.CodeMat where LibelleMat in ('ANGLAIS')), sysdate(), 15);

-- 10.	L’étudiant E3 démissionne. Donner la ou les requêtes qui permettront de supprimer les informations qui lui sont associées.
delete from EVALUATION, EVALUATION where NumEtudiant in ('E3');
delete from ETUDIANT where NumEtudiant in ('E3');