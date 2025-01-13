/*
Création de la base de données
Sous-langage : DDL /LDD
Data Definition Language
Langage de définition des données

Principales instructions :
CREATE = Créer une structure (DATABASE, TABLE, VIEW, PROCEDURE, TRIGGER, FUNCTION)
ALTER =  Modifier une structure existante
DROP = Supprimer une structure existante
*/

/* SUPPRIMER LA BASE DE DONNÉES SI ELLE EXISTE */
DROP DATABASE IF EXISTS tp1;

/* CRÉER UNE BASE DE DONNÉES NOMMÉE "videos" */
-- CREATE DATABASE videos;
CREATE DATABASE IF NOT EXISTS tp1;

/* SÉLECTIONNER/UTILISER LA BASE DE DONNÉES CRÉÉE */
USE tp1;

-- Les requêtes qui suivent utiliseront
-- la base de données sélectionnée ci-dessus

CREATE TABLE DEPT(
   deptno TINYINT PRIMARY KEY,
   dname VARCHAR(20) NOT NULL,
   loc VARCHAR(20) NOT NULL
);

CREATE TABLE EMP(
   empno INT PRIMARY KEY,
   ename VARCHAR(50) NOT NULL,
   job VARCHAR(50) NOT NULL,
   mgr INT,
   hiredate DATE NOT NULL,
   sal INT NOT NULL,
   comm INT,
   deptno TINYINT NOT NULL
);

/* Modifier la table EMP et y ajouter la clé étrangère de la table DEPT*/
ALTER TABLE EMP ADD FOREIGN KEY (deptno) REFERENCES DEPT(deptno);
-- ALTER TABLE EMP ADD FOREIGN KEY (mgr) REFERENCES EMP(empno);