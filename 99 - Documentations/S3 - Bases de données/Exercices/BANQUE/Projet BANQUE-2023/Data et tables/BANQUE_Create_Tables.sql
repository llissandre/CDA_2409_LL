--
-- BANQUE - Création des tables de la base de données
-- 

-- Création de la base de données
create database if not exists BANQUE;

-- Sélection de la base de données BANQUE pour travailler dessus
use BANQUE;

-- Désactiver les contraintes de clé étrangère dans MySQL
set foreign_key_checks = 0;

-- Suppression de toutes les tables en cascade
drop table if exists TYPECPT cascade;
drop table if exists COMPTE cascade;
drop table if exists TITULAIRE cascade;
drop table if exists TYPEOPERATION cascade;
drop table if exists OPERATION cascade;

select sysdate();
create table TYPECPT(
codeTypeCpt char(3),
libelleTypeCpt varchar(30) not null check (libelleTypeCpt <> ''),
primary key (codeTypeCpt)
);

create table COMPTE(
numCpt char(10),
dateOuvCpt date default sysdate(),
soldeCpt decimal(7,2) default 0,
codeTypeCpt char(3) not null,
numTit char(5) not null,
primary key (numCpt) 
);

create table TITULAIRE(
numTit char(5),
nomTit varchar(40) not null check (nomTit <> ''),
adrTit varchar(60),
primary key (numTit) 
);

create table OPERATION(
numOpe serial, -- Numéro incrémenté et affecté automatiquement
dateOpe datetime default sysdate(),
description varchar(100) default '',
montantOpe decimal(7,2) not null check (montantOpe <> 0),
numCpt char(10) not null check (numCpt <> ''),
codeTypeOpe char(3) not null check (codeTypeOpe <> ''),
primary key (numOpe) 
);

create table TYPEOPERATION(
codeTypeOpe char(3),
libelleTypeOpe varchar(30) not null check (libelleTypeOpe <> ''),
primary key (codeTypeOpe) 
);

-- Création des contraintes des clés étrangères
alter table COMPTE add constraint COMPTE_numTit_FK foreign key (numTit) references TITULAIRE(numTit);
alter table COMPTE add constraint COMPTE_codeTypeCpt_FK foreign key (codeTypeCpt) references TYPECPT(codeTypeCpt);
alter table OPERATION add constraint OPERATION_numCpt_FK foreign key (numCpt) references COMPTE(numCpt);
alter table OPERATION add constraint OPERATION_codeTypeOpe_FK foreign key (codeTypeOpe) references TYPEOPERATION(codeTypeOpe);

-- Réactiver les contraintes de clé étrangère dans MySQL
set foreign_key_checks = 1;