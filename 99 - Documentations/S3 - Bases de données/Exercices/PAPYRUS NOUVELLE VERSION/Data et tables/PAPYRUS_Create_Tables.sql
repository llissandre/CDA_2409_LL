-- 
-- PAPYRUS - Création des table de la base de données
-- 

-- Création de la base de données
create database if not exists PAPYRUS;

-- Sélection de la base de données PAPYRUS pour travailler dessus
use PAPYRUS;

-- Désactiver les contraintes de clé étrangère dans MySQL
set foreign_key_checks = 0;

-- Suppression de toutes les tables en cascade
-- la cascade permet la suppression des tables sans être dépendant de l'ordre 
drop table if exists CATEGORIE cascade; -- 1
drop table if exists ARTICLE cascade; -- 2
drop table if exists FOURNISSEUR cascade; -- 3
drop table if exists COMMANDE cascade; -- 4
drop table if exists TARIF cascade; -- 5
drop table if exists LIGNE cascade; -- 6
drop table if exists REPRESENTANT cascade; -- 7


create table CATEGORIE(
	CODCAT varchar(3), -- Code catégorie
	LIBCAT varchar(30), -- Libellé de la catégorie
	primary key(CODCAT)
);

create table ARTICLE(
	REFART varchar(5), -- Référence de la facture
	DESART varchar(40), -- Désignation de l'article
	QTEART int(4), -- Quantité en stock
	SALART int(4), -- Seuil d'alerte
	CODCAT varchar(3), -- Code catégorie
	primary key(REFART)
	-- constraint ARTICLE_CODCAT_FK foreign key(CODCAT) references CATEGORIE(CODCAT) -- Création de la clé étrangère pendant la création de la table ARTICLE
); 

create table FOURNISSEUR(
   NUMFOUR varchar(5), -- Numéro du fournisseur
   NOMFOUR varchar(30), -- Nom du fournisseur
   ADRFOUR varchar(50), -- Adresse du fournisseur
   CPFOUR varchar(10), -- Code postal du fournisseur
   VILLEFOUR varchar(50), -- Ville du fournisseur
   TELFOUR varchar(10), -- Numéro de téléphone du fournisseur
   primary key(NUMFOUR)
);

create table COMMANDE(
	NUMCOM int(5), -- Numéro de la commande
	DATCOM date, -- Date de la commande
	TOTCOM decimal(5,3), -- Montant total de la commande
	NUMFOUR varchar(5), -- Numéro du fournisseur
	primary key(NUMCOM)
	-- constraint COMMANDE_NUMFOUR_FK foreign key(NUMFOUR) references FOURNISSEUR(NUMFOUR) -- Création de la clé étrangère pendant la création de la table COMMANDE
);

create table TARIF(
	REFART varchar(5), -- Référence de la facture
	NUMFOUR varchar(5), -- Numéro du fournisseur   
	PRUTAR decimal(3,2), -- Prix unitaire
	INQTAR varchar(1), -- Indice qualité
	primary key(REFART,NUMFOUR)
	-- constraint TARIF_REFART_FK foreign key(REFART) references ARTICLE(REFART), -- Création de la clé étrangère pendant la création de la table TARIF
	-- constraint TARIF_NUMFOUR_FK foreign key(NUMFOUR) references FOURNISSEUR(NUMFOUR) -- Création de la clé étrangère pendant la création de la table TARIF
);

create table LIGNE(
	NUMCOM int(5), -- Numéro de la commande 
	REFART varchar(5), -- Référence de la facture
	QTELIG int(2), -- Quantité commandée
	primary key(NUMCOM, REFART)
	-- constraint LIGNE_NUMCOM_FK foreign key(NUMCOM) references COMMANDE(NUMCOM) -- Création de la clé étrangère pendant la création de la table LIGNE
	-- constraint LIGNE_REFART_FK foreign key(REFART) references ARTICLE(REFART), -- Création de la clé étrangère pendant la création de la table LIGNE
);

create table REPRESENTANT(
   NUMREP varchar(5), -- Numéro représentant
   NOMREP varchar(30), -- Nom du représentant
   TELREP varchar(10), -- Numéro de téléphone du représentant
   NUMFOUR varchar(5), -- Numéro du fournisseur
   primary key(NUMREP)
   -- constraint REPRESENTANT_NUMFOUR_FK foreign key(NUMFOUR) references FOURNISSEUR(NUMFOUR) -- Création de la clé étrangère pendant la création de la table REPRESENTANT
);

-- Création des contraintes des clés étrangères après création de la BDD et des tables
alter table ARTICLE add constraint ARTICLE_CODCAT_FK foreign key (CODCAT) references CATEGORIE(CODCAT);
alter table COMMANDE add constraint COMMANDE_NUMFOUR_FK foreign key (NUMFOUR) references FOURNISSEUR(NUMFOUR);
alter table TARIF add constraint TARIF_REFART_FK foreign key (REFART) references ARTICLE(REFART);
alter table TARIF add constraint TARIF_NUMFOUR_FK foreign key (NUMFOUR) references FOURNISSEUR(NUMFOUR);
alter table LIGNE add constraint LIGNE_REFART_FK foreign key (REFART) references ARTICLE(REFART);
alter table LIGNE add constraint LIGNE_NUMCOM_FK foreign key (NUMCOM) references COMMANDE(NUMCOM);
alter table REPRESENTANT add constraint REPRESENTANT_NUMFOUR_FK foreign key (NUMFOUR) references FOURNISSEUR(NUMFOUR);

alter table TARIF modify column PRUTAR decimal(5,2); -- Pour modifier le type de la variable PRUTAR
alter table COMMANDE modify column NUMCOM varchar(10); -- Pour modifier le type de variable de NUMCOM
alter table LIGNE modify column NUMCOM varchar(10); -- Pour modifier le type de variable de NUMCOM
alter table COMMANDE modify column TOTCOM decimal(10,3); -- Pour modifier le type de variable TOTCOM 

-- Réactiver les contraintes de clé étrangère dans MySQL
SET foreign_key_checks = 1;
