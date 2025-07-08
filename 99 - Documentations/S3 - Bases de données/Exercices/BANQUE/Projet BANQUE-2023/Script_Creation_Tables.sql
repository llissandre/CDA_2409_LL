-- 
-- BANQUE - Création des tables de la base de données
-- 

-- création Bdd
CREATE DATABASE IF NOT EXISTS BANQUE;

-- sélection de la Bdd BANQUE pour travailler dessus
USE BANQUE;

SET foreign_key_checks = 0;

-- supression de toutes les tables
DROP table IF EXISTS TYPECPT CASCADE;
DROP table IF EXISTS COMPTE CASCADE;
DROP table IF EXISTS TITULAIRE CASCADE;
DROP table IF EXISTS TYPEOPERATION CASCADE;
DROP table IF EXISTS OPERATION CASCADE;

CREATE table TYPECPT (
	codeTypeCpt Char(3),
	libelleTypeCpt varchar(30) not null CHECK (libelleTypeCpt <> ''),
	primary key (codeTypeCpt)
);

CREATE table COMPTE (
	numCpt Char(10),
	dateOuvCpt Date default sysdate(),
	numTit Char(5) not null,
	codeTypeCpt Char(3) not null,
	soldeCpt Decimal(7,2) default 0,	
	primary key (numCpt)
);

CREATE table TITULAIRE (
	numTit Char(5),
	nomTit varchar(40) not null CHECK (nomTit <> ''),
	adrTit varchar(60),
	primary key (numTit)
);

CREATE table TYPEOPERATION (
	codeTypeOpe Char(3),
	libelleTypeOpe varchar(30) not null CHECK (libelleTypeOpe <> ''),
	primary key (codeTypeOpe)
);

CREATE table OPERATION (
	numOpe Serial, -- numero incrémenté et affecté automatiquement
	dateOpe Datetime default sysdate(),
	description varchar(100) default '',
	montantOpe Decimal(7,2) CHECK (montantOpe <> 0),	
	numCpt Char(10),
	codeTypeOpe Char(3),
	primary key (numOpe)
);

-- création des contraintes de clés étrangères :
ALTER table COMPTE ADD constraint COMPTE_numTit_FK foreign key(numTit) references TITULAIRE(numtit);
ALTER table COMPTE ADD constraint COMPTE_codeTypeCpt_FK foreign key(codeTypeCpt) references TYPECPT(codeTypeCpt);

ALTER table OPERATION ADD constraint OPERATION_numCpt_FK foreign key(numCpt) references COMPTE(numCpt);
ALTER table OPERATION ADD constraint OPERATION_codeTypeOpe_FK foreign key(codeTypeOpe) references TYPEOPERATION(codeTypeOpe);

SET foreign_key_checks = 1;

