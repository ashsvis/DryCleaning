CREATE DATABASE  IF NOT EXISTS `drycleaner` /*!40100 DEFAULT CHARACTER SET cp1251 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `drycleaner`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: drycleaner
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `IdCategory` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `IdService` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Description` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `IdSentence` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Quantity` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES ('020b0f46-b489-4cab-a216-ea1522c52fbc','1d4ed115-02d4-4edb-8f39-8bbebf788ebf','','38e60379-7736-46cb-b681-786cba077314','1'),('5c3afdfd-2bc6-4d0c-892c-f6f3edde5eba','1d4ed115-02d4-4edb-8f39-8bbebf788ebf','','5f75f315-75dd-4484-82f4-4b695cdb0f8f','2'),('14374f64-ddfd-46db-9b46-9892a4bade52','2472033f-3475-4afd-bce2-83b7be5b4f7b','','ace150fa-3f84-4790-9bb7-97fcfcb8f9a1','10'),('89dd1e4d-3fc0-4c5e-9e62-e7dac069b88a','36f2194c-d98b-4948-9773-13bf2f63f084','','28297608-dbc5-4e3f-9dce-63224c16eab8','5'),('572cf23c-4edc-4be4-9036-df918ec8edfc','36f2194c-d98b-4948-9773-13bf2f63f084','','38e60379-7736-46cb-b681-786cba077314','1'),('9a059d60-ca0f-41d5-a73e-76ad3cf7db31','5a9d3261-6b34-4f89-a7b5-4054325997f2','','38e60379-7736-46cb-b681-786cba077314','1'),('6f024651-a355-479b-a276-5828fa2a111d','5a9d3261-6b34-4f89-a7b5-4054325997f2','','5f75f315-75dd-4484-82f4-4b695cdb0f8f','5'),('31e5b190-b139-48a2-9f3c-a00cd0111a00','6e9fe8fc-062f-4c3f-a01f-ad238bfd8dea','','38e60379-7736-46cb-b681-786cba077314','1'),('139dba46-fd7b-4cf3-90c7-b8015ecaff43','6e9fe8fc-062f-4c3f-a01f-ad238bfd8dea','','ace150fa-3f84-4790-9bb7-97fcfcb8f9a1','5'),('26932467-fc7a-4646-b70a-d492dd00f113','9624c8e3-8d60-4272-ac7a-024ca45048d1','','38e60379-7736-46cb-b681-786cba077314','1'),('956d5d81-4923-47e7-b725-a67a10bfd69b','bf160fae-f930-41a1-a042-d81a413e885b','','28297608-dbc5-4e3f-9dce-63224c16eab8','5');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-03 22:01:50
