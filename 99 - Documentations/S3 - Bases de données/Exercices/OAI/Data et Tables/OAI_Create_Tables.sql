--
-- OAI - Création des table de la base de données
--
CREATE DATABASE IF NOT EXISTS OAI; 
USE OAI;

drop table if exists EMP;
drop table if exists SALGRADE;
drop table if exists DEPT;


create table DEPT(
   DEPTNO int,
   DNAME varchar(15) not null,
   LOC varchar(15) not null,
   constraint DEPT_PK primary key(DEPTNO)  
) engine = InnoDB; 


create table EMP(
   EMPNO int,
   ENAME varchar(15) not null,
   SAL decimal(7,0) not null,
   JOB varchar(10)  not null,
   COMM decimal(7,0),
   HIREDATE date default NOW(),
   MGR int,
   DEPTNO int not null,
   constraint EMP_PK primary key(EMPNO),
   constraint EMP_MGR_FK foreign key(MGR) references EMP(EMPNO),
   constraint EMP_DEPTNO_FK foreign key(DEPTNO) references DEPT(DEPTNO)
) ENGINE=InnoDB;

CREATE TABLE SALGRADE(
   GRADE INT,
   HISAL DECIMAL(7,0)  ,
   LOSAL DECIMAL(7,0)   NOT NULL,
   CONSTRAINT SALGRADE_PK PRIMARY KEY(GRADE)
) ENGINE=InnoDB;
