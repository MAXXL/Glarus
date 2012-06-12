CREATE DATABASE  IF NOT EXISTS `glarus_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `glarus_db`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: glarus_db
-- ------------------------------------------------------
-- Server version	5.5.25

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `Family` varchar(50) DEFAULT NULL,
  `Name` varchar(25) DEFAULT NULL,
  `SecondName` varchar(25) DEFAULT NULL,
  `Password` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Иванов','Иван','Иванович','1'),(2,'Петров','Петр','Петрович','2'),(3,'Сидоров','Сидор','Сидорович','3'),(4,'Николаев','Николай','Николаевич','4');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacient`
--

DROP TABLE IF EXISTS `pacient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacient` (
  `idPacient` int(11) NOT NULL AUTO_INCREMENT,
  `Family` varchar(50) DEFAULT NULL,
  `Name` varchar(25) DEFAULT NULL,
  `SecondName` varchar(25) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  PRIMARY KEY (`idPacient`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacient`
--

LOCK TABLES `pacient` WRITE;
/*!40000 ALTER TABLE `pacient` DISABLE KEYS */;
INSERT INTO `pacient` VALUES (4,'Агапкова','Марьяна','Федоровна','1970-06-10'),(5,'Пилипко','Татьяна','Сергеевна','1964-04-01'),(6,'Прохорова','Инна','Федоровна','1980-06-10');
/*!40000 ALTER TABLE `pacient` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-06-12 16:15:40
