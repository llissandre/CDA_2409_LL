-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
-- 
-- Client :  127.0.0.1
-- Généré le :  Mar 03 Novembre 2020 à 09:27
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

-- /*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
-- /*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
-- /*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
-- /*!40101 SET NAMES utf8mb4 */;

-- 
-- Base de données :  `dl09`
--
CREATE DATABASE IF NOT EXISTS dl09; 
USE dl09;

-- --------------------------------------------------------

-- Suppression de toutes les tables en cascade
-- drop table if exists Ticket_Material cascade; pour le jalon 2
drop table if exists Utilisateurs cascade;


--
-- Structure de la table `Utilisateurs`
--
CREATE TABLE `Utilisateurs` (
  `Id` int(11) NOT NULL,
  `Nom` varchar(100) COLLATE utf8_bin NOT NULL,
  `Prenom` varchar(100) COLLATE utf8_bin NOT NULL,
  `DtNaiss` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `utilisateurs`
--
INSERT INTO `Utilisateurs` (`Id`, `Nom`, `Prenom`, `DtNaiss`) VALUES
(32, 'Daridon', 'Wilfrid', '1970-03-06'),
(29, 'Urthaler', 'Stephanes', '1970-11-27'),
(30, 'Vigier', 'Anthony', '1970-05-07');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `Utilisateurs`
--
ALTER TABLE `Utilisateurs`
  ADD PRIMARY KEY (`Id`),
  -- l'unique key ne permet pas de rentre deux fois un utilisateur avec les mêmes prénom, nom et date de naissance 
  ADD UNIQUE KEY `USER_UNIQ` (`Nom`,`Prenom`,`DtNaiss`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `utilisateurs`
--
ALTER TABLE `Utilisateurs` MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
ALTER TABLE dl09.Utilisateurs MODIFY COLUMN DtNaiss date NULL;