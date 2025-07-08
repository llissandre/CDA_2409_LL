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

-- --------------------------------------------------------

--
-- Structure de la table `article`
--

DROP TABLE IF EXISTS `article`;
CREATE TABLE IF NOT EXISTS `article` (
  `IDArticle` bigint(20) NOT NULL AUTO_INCREMENT,
  `Titre` varchar(200) NOT NULL,
  `Corps` varchar(65000) NOT NULL,
  `Auteur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDArticle`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `article`
--

INSERT INTO `article` (`IDArticle`, `Titre`, `Corps`, `Auteur`) VALUES
(1, 'article1', 'corps 1', 'auteur1'),
(2, 'article2', 'corps2', NULL),
(5, 'article5', 'corps 19', 'auteur99'),
(6, 'article6', 'corps test', NULL),
(7, 'articleaaaaa', 'corps aaaaaa', 'auteuraaaaaaa');

-- --------------------------------------------------------

--
-- Structure de la table `composition`
--

DROP TABLE IF EXISTS `composition`;
CREATE TABLE IF NOT EXISTS `composition` (
  `IDJournal` bigint(20) NOT NULL DEFAULT '0',
  `IDArticle` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IDJournal`,`IDArticle`),
  KEY `composition_IDArticle` (`IDArticle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `composition`
--

INSERT INTO `composition` (`IDJournal`, `IDArticle`) VALUES
(30, 1),
(32, 1),
(33, 2),
(32, 5),
(33, 6);

-- --------------------------------------------------------

--
-- Structure de la table `journal`
--

DROP TABLE IF EXISTS `journal`;
CREATE TABLE IF NOT EXISTS `journal` (
  `IDJournal` bigint(20) NOT NULL AUTO_INCREMENT,
  `Titre` varchar(200) NOT NULL,
  `DtParution` date DEFAULT NULL,
  PRIMARY KEY (`IDJournal`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `journal`
--

INSERT INTO `journal` (`IDJournal`, `Titre`, `DtParution`) VALUES
(30, 'journal3', '2017-10-12'),
(32, 'journal19', '2016-09-27'),
(33, 'journal5', '2021-08-18'),
(34, 'journal5', '2021-08-13');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `v_journalarticle`
-- (Voir ci-dessous la vue réelle)
--
DROP VIEW IF EXISTS `v_journalarticle`;
CREATE TABLE IF NOT EXISTS `v_journalarticle` (
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
-- Structure de la vue `v_journalarticle`
--
DROP TABLE IF EXISTS `v_journalarticle`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_journalarticle`  AS  select `article`.`IDArticle` AS `IDArticle`,`article`.`Titre` AS `TitreArticle`,`article`.`Corps` AS `Corps`,`article`.`Auteur` AS `Auteur`,`journal`.`IDJournal` AS `IDJournal`,`journal`.`Titre` AS `TitreJournal`,`journal`.`DtParution` AS `DtParution` from ((`article` left join `composition` on((`article`.`IDArticle` = `composition`.`IDArticle`))) left join `journal` on((`composition`.`IDJournal` = `journal`.`IDJournal`))) union select `article_1`.`IDArticle` AS `IDArticle`,`article_1`.`Titre` AS `TitreArticle`,`article_1`.`Corps` AS `Corps`,`article_1`.`Auteur` AS `Auteur`,`journal_1`.`IDJournal` AS `IDJournal`,`journal_1`.`Titre` AS `TitreJournal`,`journal_1`.`DtParution` AS `DtParution` from (`journal` `journal_1` left join (`composition` `composition_1` left join `article` `article_1` on((`article_1`.`IDArticle` = `composition_1`.`IDArticle`))) on((`composition_1`.`IDJournal` = `journal_1`.`IDJournal`))) ;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `composition`
--
ALTER TABLE `composition`
  ADD CONSTRAINT `composition_IDArticle` FOREIGN KEY (`IDArticle`) REFERENCES `article` (`IDArticle`),
  ADD CONSTRAINT `composition_IDJournal` FOREIGN KEY (`IDJournal`) REFERENCES `journal` (`IDJournal`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
