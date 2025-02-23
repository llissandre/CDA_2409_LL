-- 
-- ETUDIANTS_ET_NOTES - Création des table de la base de données
-- 

-- Création de la base de données
create database if not exists ETUDIANTS_ET_NOTES; 

-- Sélection de la base de données ETUDIANTS_ET_NOTES
use ETUDIANTS_ET_NOTES;

-- Désactiver les contraintes de clé étrangère dans MySQL
set foreign_key_checks = 0;

-- Suppression de toutes les tables en cascade
drop table if exists ETUDIANT cascade;
drop table if exists MATIERE cascade;
drop table if exists EVALUATION cascade;


create table ETUDIANT(
   NumEtudiant varchar(2),
   Nom varchar(15) not null check (Nom <> ''),
   Prenom varchar(15) not null check (Prenom <> ''),
   primary key(NumEtudiant)
);

create table MATIERE(
   CodeMat varchar(2),
   LibelleMat varchar(15) not null check (LibelleMat <> ''),
   NomProf varchar(2) not null check (NomProf <> ''),
   primary key(CodeMat)  
); 

create table EVALUATION(
	NumEtudiant varchar(2),
	CodeMat varchar(2) not null check (CodeMat <> ''),
	DateEval date,
	Note decimal(4,2),
	primary key(NumEtudiant, CodeMat, DateEval)
);


-- Création des contraintes des clés étrangères après création de la BDD et des tables
alter table EVALUATION add constraint EVALUATION_NumEtudiant_FK foreign key (NumEtudiant) references ETUDIANT(NumEtudiant);
alter table EVALUATION add constraint EVALUATION_CodeMat_FK foreign key (CodeMat) references MATIERE(CodeMat);

-- Réactiver les contraintes de clé étrangère dans MySQL
SET foreign_key_checks = 1;