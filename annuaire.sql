-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 01 mai 2021 à 18:46
-- Version du serveur :  5.7.31
-- Version de PHP : 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `annuaire`
--

DELIMITER $$
--
-- Procédures
--
DROP PROCEDURE IF EXISTS `PS_I_PERSONNE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `PS_I_PERSONNE` (IN `Titre` VARCHAR(38), IN `Nom` VARCHAR(38), IN `Prenom` VARCHAR(38), IN `Telephone` VARCHAR(38), IN `Service` VARCHAR(38), IN `DateEntree` DATE, IN `Entreprise` VARCHAR(38))  NO SQL
INSERT INTO personne (Titre_Personne, Nom_Personne, Prenom_Personne,Telephone_Personne,Service_Personne,DateEntree_Personne
,Entreprise_Personne)
 VALUES (Titre,
         Nom,
         Prenom,
         Telephone,
         Service,
         DateEntree,
         Entreprise)$$

DROP PROCEDURE IF EXISTS `PS_S_PERSONNE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `PS_S_PERSONNE` ()  NO SQL
SELECT CONCAT (Titre_Personne," ",Nom_Personne) AS "Nom",
Prenom_Personne AS "Prénom",
Telephone_Personne AS "Telephone",
Service_Personne AS "Service",
DateEntree_Personne AS "Date d'entrée",
Entreprise_Personne AS "Entreprise"
FROM personne$$

DROP PROCEDURE IF EXISTS `PS_S_W_E_PERSONNE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `PS_S_W_E_PERSONNE` (IN `Code` VARCHAR(38))  NO SQL
SELECT CONCAT (Titre_Personne," ",Nom_Personne) AS "Nom",
Prenom_Personne AS "Prénom",
Telephone_Personne AS "Telephone",
Service_Personne AS "Service",
DateEntree_Personne AS "Date d'entrée",
Entreprise_Personne AS "Entreprise"
FROM personne WHERE Entreprise_Personne = Code$$

DROP PROCEDURE IF EXISTS `PS_S_W_N_PERSONNE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `PS_S_W_N_PERSONNE` (IN `Code` VARCHAR(38))  NO SQL
SELECT CONCAT (Titre_Personne," ",Nom_Personne) AS "Nom",
Prenom_Personne AS "Prénom",
Telephone_Personne AS "Telephone",
Service_Personne AS "Service",
DateEntree_Personne AS "Date d'entrée",
Entreprise_Personne AS "Entreprise"
FROM personne WHERE Nom_Personne = Code$$

DROP PROCEDURE IF EXISTS `PS_S_W_PERSONNE`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `PS_S_W_PERSONNE` (IN `Code` INT)  NO SQL
SELECT CONCAT (Titre_Personne," ",Nom_Personne) AS "Nom",
Prenom_Personne AS "Prénom",
Telephone_Personne AS "Telephone",
Service_Personne AS "Service",
DateEntree_Personne AS "Date d'entrée",
Entreprise_Personne AS "Entreprise"
FROM personne WHERE Id_Personne = Code$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

DROP TABLE IF EXISTS `personne`;
CREATE TABLE IF NOT EXISTS `personne` (
  `Id_Personne` int(11) NOT NULL AUTO_INCREMENT,
  `Titre_Personne` varchar(38) COLLATE utf8_unicode_ci NOT NULL,
  `Nom_Personne` varchar(38) COLLATE utf8_unicode_ci NOT NULL,
  `Prenom_Personne` varchar(38) COLLATE utf8_unicode_ci NOT NULL,
  `Telephone_Personne` varchar(38) COLLATE utf8_unicode_ci NOT NULL,
  `Service_Personne` varchar(38) COLLATE utf8_unicode_ci DEFAULT NULL,
  `DateEntree_Personne` date NOT NULL,
  `Entreprise_Personne` varchar(38) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Id_Personne`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`Id_Personne`, `Titre_Personne`, `Nom_Personne`, `Prenom_Personne`, `Telephone_Personne`, `Service_Personne`, `DateEntree_Personne`, `Entreprise_Personne`) VALUES
(1, 'Mr', 'Laine', 'Oliver', '06-476-034', 'NaNNA643undefined', '2012-06-30', 'HETU'),
(2, 'Miss', 'Korpi', 'Julia', '04-563-869', 'NaNNA368undefined', '2004-07-16', 'HETU'),
(3, 'Mrs', 'Slawa', 'Mia', '138-738-0031', NULL, '2004-01-27', ''),
(4, 'Miss', 'Hernandez', 'Irene', '980-086-600', '00395599-S', '2009-02-05', 'DNI'),
(5, 'Mrs', 'Gödecke', 'Hanny', '0096-1720231', NULL, '2010-03-14', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
