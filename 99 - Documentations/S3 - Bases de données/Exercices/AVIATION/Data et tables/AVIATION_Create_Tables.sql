--   AVIATION                   
                 
CREATE DATABASE IF NOT EXISTS AVIATION; 
USE AVIATION;
-- ============================================================
--   Table : AVION                                             
-- ============================================================
DROP TABLE if exists VOL;
DROP TABLE if exists AVION;
DROP TABLE if exists PILOTE;
create table AVION
(   AVNO    CHAR(3),   
    AVNOM   VARCHAR(20),
    AVCAP   DECIMAL(3,0),
    AVLOC   VARCHAR(20),
    primary key(AVNO));

-- ============================================================
--   Table : PILOTE                                            
-- ============================================================
create table PILOTE
(   PILNO   CHAR(3),
    PILNOM  VARCHAR(20),
    PILADR  VARCHAR(20),
    PILSAL  DECIMAL(5,0),
    primary key(PILNO));

-- ============================================================
--   Table : VOL                                               
-- ============================================================
create table VOL
(   VOLNO   CHAR(3),
    PILNO   CHAR(3),
    AVNO    CHAR(3),
    VOLDEP  VARCHAR(20),
    VOLARR  VARCHAR(20),
    primary key (VOLNO));

alter table VOL
add constraint VOL_PILNO_PK foreign key(PILNO) references PILOTE(PILNO);

alter table VOL
add constraint VOL_AVNO_PK foreign key(AVNO) references AVION(AVNO);