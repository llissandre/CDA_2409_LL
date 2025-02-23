drop table if exists TARIF;
drop table if exists LIGNE_COMMANDE;
drop table if exists COMMANDE;
drop table if exists FOURNISSEUR;
drop table if exists PRODUIT;

create table FOURNISSEUR (
	NUFOUR 	int,
	RAISOC 	varchar(30) not null,
	ADRES  	varchar(30),
	CDPOST 	char(5) not null,
	VILLE  	varchar(30) not null,
	CONTACT varchar(30),
	primary key (NUFOUR)
);

create table PRODUIT (
	REFPROD char(4),
	DESIG 	varchar(30) not null,
	STOCK  	decimal(4,0) not null,
	ALERT	decimal(4,0) not null,
	primary key (REFPROD)
);

create table TARIF (
	REFPROD char(4),
	NUFOUR 	int,
	PUACH 	decimal(7,2) not null,	
	primary key (REFPROD, NUFOUR)
);

create table COMMANDE (
	NUCOM	int,
	DTCOM 	date default sysdate(), 
	NUFOUR 	int,	
	primary key (NUCOM)
);

create table LIGNE_COMMANDE (
	NUCOM	int,
	REFPROD char(4),
	QTECOM 	decimal(4,0) not null,
	PU 		decimal(7,2) not null,
	primary key (NUCOM, REFPROD)
);

alter table COMMANDE
add constraint COMMANDE_NUFOUR_FK foreign key(NUFOUR) references FOURNISSEUR(NUFOUR);

alter table TARIF
add constraint TARIF_NUFOUR_FK foreign key(NUFOUR) references FOURNISSEUR(NUFOUR);

alter table TARIF
add constraint TARIF_REFPROD_FK foreign key(REFPROD) references PRODUIT(REFPROD);

alter table LIGNE_COMMANDE
add constraint LIGNE_COMMANDE_NUCOM_FK foreign key(NUCOM) references COMMANDE(NUCOM);

alter table LIGNE_COMMANDE
add constraint LIGNE_COMMANDE_REPROD_FK foreign key(REFPROD) references PRODUIT(REFPROD);


