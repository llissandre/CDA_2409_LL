-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
-- 
-- Hôte : 127.0.0.1:3306
-- Généré le :  ven. 03 déc. 2021 à 09:33
-- Version du serveur :  8.0.18
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

-- 
-- Base de données :  `edito`
-- 
CREATE DATABASE IF NOT EXISTS edito; 
USE edito;

-- --------------------------------------------------------

-- Suppression de toutes les tables en cascade
DROP TABLE IF EXISTS `Composition` cascade;
DROP TABLE IF EXISTS `Article` cascade;
DROP TABLE IF EXISTS `Journal` cascade;

-- 
-- Structure de la table `Article`
-- 
CREATE TABLE IF NOT EXISTS `Article` (
  `IDArticle` bigint(20) NOT NULL AUTO_INCREMENT,
  `Titre` varchar(200) NOT NULL,
  `Corps` varchar(50) DEFAULT NULL,
  `Auteur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDArticle`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- 
-- Déchargement des données de la table `Article`
-- 
INSERT INTO `Article` (`IDArticle`, `Titre`, `Corps`, `Auteur`) VALUES
(1, 'article1', 'corps 1', 'auteur1'),
(2, 'article2', 'corps 2', NULL),
(5, 'article5', 'corps 19', 'auteur99'),
(6, 'article6', 'corps test', NULL),
(7, 'articleaaaaa', 'corps aaaaaa', 'auteuraaaaaaa');

-- --------------------------------------------------------

-- 
-- Structure de la table `Composition`
-- 
CREATE TABLE IF NOT EXISTS `Composition` (
  `IDJournal` bigint(20) NOT NULL DEFAULT '0',
  `IDArticle` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IDJournal`,`IDArticle`),
  KEY `composition_IDArticle` (`IDArticle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Déchargement des données de la table `Composition`
-- 
INSERT INTO `Composition` (`IDJournal`, `IDArticle`) VALUES
(30, 1),
(32, 1),
(33, 2),
(32, 5),
(33, 6);

-- --------------------------------------------------------

-- 
-- Structure de la table `Journal`
-- 
CREATE TABLE IF NOT EXISTS `Journal` (
  `IDJournal` bigint(20) NOT NULL AUTO_INCREMENT,
  `Titre` varchar(200) NOT NULL,
  `DtParution` date DEFAULT NULL,
  PRIMARY KEY (`IDJournal`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

-- 
-- Déchargement des données de la table `Journal`
-- 
INSERT INTO `Journal` (`IDJournal`, `Titre`, `DtParution`) VALUES
(30, 'journal3', '2017-10-12'),
(32, 'journal19', '2016-09-27'),
(33, 'journal5', '2021-08-18'),
(34, 'journal5', '2021-08-13');

-- --------------------------------------------------------

-- 
-- Doublure de structure pour la vue `V_journalarticle`
-- (Voir ci-dessous la vue réelle)
-- 
DROP VIEW IF EXISTS `V_journalarticle`;
CREATE TABLE IF NOT EXISTS `V_journalarticle` (
`IDArticle` bigint(20)
,`TitreArticle` varchar(200)
,`Corps` text
,`Auteur` varchar(50)
,`IDJournal` bigint(20)
,`TitreJournal` varchar(200)
,`DtParution` date
);

-- --------------------------------------------------------

-- 
-- Structure de la vue `V_journalarticle`
-- 
DROP TABLE IF EXISTS `V_journalarticle`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `V_journalarticle` AS  select `Article`.`IDArticle` AS `IDArticle`
,`Article`.`Titre` AS `TitreArticle`,`Article`.`Corps` AS `Corps`,`Article`.`Auteur` AS `Auteur`,`Journal`.`IDJournal` AS `IDJournal`,`Journal`.`Titre` AS `TitreJournal`
,`Journal`.`DtParution` AS `DtParution` from ((`Article` left join `Composition` on((`Article`.`IDArticle` = `Composition`.`IDArticle`)))
left join `Journal` on((`Composition`.`IDJournal` = `Journal`.`IDJournal`))) union select `Article_1`.`IDArticle` AS `IDArticle`,
`Article_1`.`Titre` AS `TitreArticle`,`Article_1`.`Corps` AS `Corps`,`Article_1`.`Auteur` AS `Auteur`,`Journal_1`.`IDJournal` AS `IDJournal`,
`Journal_1`.`Titre` AS `TitreJournal`,`Journal_1`.`DtParution` AS `DtParution` from (`Journal` `Journal_1` left join (`Composition` `Composition_1` left join `Article` `Article_1` 
on((`Article_1`.`IDArticle` = `Composition_1`.`IDArticle`))) on((`Composition_1`.`IDJournal` = `Journal_1`.`IDJournal`))) ;

-- 
-- Contraintes pour les tables déchargées
-- 

-- 
-- Contraintes pour la table `composition`
-- 
ALTER TABLE `Composition`
  ADD CONSTRAINT `Composition_IDArticle` FOREIGN KEY (`IDArticle`) REFERENCES `Article` (`IDArticle`),
  ADD CONSTRAINT `Composition_IDJournal` FOREIGN KEY (`IDJournal`) REFERENCES `Journal` (`IDJournal`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
