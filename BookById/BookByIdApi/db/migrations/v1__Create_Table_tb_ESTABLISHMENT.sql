-- MySQL dump 10.13  Distrib 8.0.22, for macos10.15 (x86_64)
--
-- Host: 127.0.0.1    Database: db_agenda
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `tb_ADDRESS`
--

DROP TABLE IF EXISTS `tb_ADDRESS`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_ADDRESS` (
  `id` int NOT NULL AUTO_INCREMENT,
  `country` varchar(255) DEFAULT NULL,
  `postal_code` varchar(20) NOT NULL,
  `uf` varchar(45) DEFAULT NULL,
  `city` varchar(255) DEFAULT NULL,
  `neighborhood` varchar(255) DEFAULT NULL,
  `street` varchar(255) DEFAULT NULL,
  `number` int DEFAULT NULL,
  `complement` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_BUSINNESS_SERVICE_ASSOCIATION`
--

DROP TABLE IF EXISTS `tb_BUSINNESS_SERVICE_ASSOCIATION`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_BUSINNESS_SERVICE_ASSOCIATION` (
  `service_id` int DEFAULT NULL,
  `businness_id` int DEFAULT NULL,
  KEY `FK_1_idx` (`businness_id`),
  KEY `FK2_idx` (`service_id`),
  CONSTRAINT `FK2` FOREIGN KEY (`service_id`) REFERENCES `tb_SERVICE` (`id`) ON DELETE CASCADE,
  CONSTRAINT `FK_1` FOREIGN KEY (`businness_id`) REFERENCES `tb_ESTABLISHMENT_BUSINNESS` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_ESTABLISHMENT`
--

DROP TABLE IF EXISTS `tb_ESTABLISHMENT`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_ESTABLISHMENT` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cnpj_cpf` varchar(18) NOT NULL,
  `company_name` varchar(255) DEFAULT NULL,
  `company_fancy_name` varchar(255) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `cellphone` varchar(20) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `website` varchar(255) DEFAULT NULL,
  `social_network` varchar(45) DEFAULT NULL,
  `logo` varchar(45) DEFAULT NULL,
  `cover_photo` varchar(45) DEFAULT NULL,
  `establishment_category_id` int DEFAULT NULL,
  `address_id` int DEFAULT NULL,
  `user_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cnpj_cpf_UNIQUE` (`cnpj_cpf`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  KEY `FK_ESTABLISHMENT_CATEGORY_idx` (`establishment_category_id`),
  KEY `FK_ESTABLISHMENT_ADDRESS_idx` (`address_id`),
  KEY `FK_ESTABLISHMENT_USER_idx` (`user_id`),
  CONSTRAINT `FK_ESTABLISHMENT_ADDRESS` FOREIGN KEY (`address_id`) REFERENCES `tb_ADDRESS` (`id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ESTABLISHMENT_CATEGORY` FOREIGN KEY (`establishment_category_id`) REFERENCES `tb_ESTABLISHMENT_CATEGORY` (`id`),
  CONSTRAINT `FK_ESTABLISHMENT_USER` FOREIGN KEY (`user_id`) REFERENCES `tb_USER` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_ESTABLISHMENT_BUSINNESS`
--

DROP TABLE IF EXISTS `tb_ESTABLISHMENT_BUSINNESS`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_ESTABLISHMENT_BUSINNESS` (
  `id` int NOT NULL AUTO_INCREMENT,
  `opening_time` time DEFAULT NULL,
  `closing_time` time DEFAULT NULL,
  `opening_day` datetime DEFAULT NULL,
  `closing_day` datetime DEFAULT NULL,
  `about_us` varchar(255) DEFAULT NULL,
  `establishment_id` int DEFAULT NULL,
  `service_type` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_BUSSINNESS_ESTABLISHMENT_idx` (`establishment_id`),
  KEY `FK_BUSINNESS_SERVICE_TYPE_idx` (`service_type`),
  CONSTRAINT `FK_BUSINNESS_SERVICE_TYPE` FOREIGN KEY (`service_type`) REFERENCES `tb_SERVICE` (`id`),
  CONSTRAINT `FK_BUSSINNESS_ESTABLISHMENT` FOREIGN KEY (`establishment_id`) REFERENCES `tb_ESTABLISHMENT` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_ESTABLISHMENT_CATEGORY`
--

DROP TABLE IF EXISTS `tb_ESTABLISHMENT_CATEGORY`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_ESTABLISHMENT_CATEGORY` (
  `id` int NOT NULL AUTO_INCREMENT,
  `category_name` varchar(45) DEFAULT NULL,
  `category_description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_SCHEDULE_STATUS`
--

DROP TABLE IF EXISTS `tb_SCHEDULE_STATUS`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_SCHEDULE_STATUS` (
  `id` int NOT NULL AUTO_INCREMENT,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_SCHEDULES`
--

DROP TABLE IF EXISTS `tb_SCHEDULES`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_SCHEDULES` (
  `id` int NOT NULL AUTO_INCREMENT,
  `service_type_id` int DEFAULT NULL,
  `available_time` time DEFAULT NULL,
  `available_date` datetime DEFAULT NULL,
  `establishment_businness_id` int DEFAULT NULL,
  `schedule_status` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_SCHEDULES_STATUS_idx` (`schedule_status`),
  KEY `FK_SCHEDULES_ESTABLISHMENT_BUSINNESS_idx` (`establishment_businness_id`),
  CONSTRAINT `FK_SCHEDULES_ESTABLISHMENT_BUSINNESS` FOREIGN KEY (`establishment_businness_id`) REFERENCES `tb_ESTABLISHMENT_BUSINNESS` (`id`),
  CONSTRAINT `FK_SCHEDULES_STATUS` FOREIGN KEY (`schedule_status`) REFERENCES `tb_SCHEDULE_STATUS` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_SERVICE`
--

DROP TABLE IF EXISTS `tb_SERVICE`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_SERVICE` (
  `id` int NOT NULL AUTO_INCREMENT,
  `service_name` varchar(45) DEFAULT NULL,
  `service_description` varchar(255) DEFAULT NULL,
  `service_value` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_USER`
--

DROP TABLE IF EXISTS `tb_USER`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_USER` (
  `id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(255) DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `document` varchar(45) DEFAULT NULL,
  `cellphone` varchar(45) NOT NULL,
  `social_network` varchar(45) DEFAULT NULL,
  `picture` varchar(45) DEFAULT NULL,
  `address_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cellphone_UNIQUE` (`cellphone`),
  UNIQUE KEY `document_UNIQUE` (`document`),
  KEY `FK_USER_ADDRESS_idx` (`address_id`),
  CONSTRAINT `FK_USER_ADDRESS` FOREIGN KEY (`address_id`) REFERENCES `tb_ADDRESS` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_USER_SCHEDULE`
--

DROP TABLE IF EXISTS `tb_USER_SCHEDULE`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_USER_SCHEDULE` (
  `id` int NOT NULL AUTO_INCREMENT,
  `schedule_id` int DEFAULT NULL,
  `schedule_date` datetime DEFAULT NULL,
  `schedule_time` time DEFAULT NULL,
  `schedule_status_id` int DEFAULT NULL,
  `rating` varchar(45) DEFAULT NULL,
  `user_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_USER_SCHEDULE_SCHEDULE_idx` (`user_id`),
  CONSTRAINT `FK_USER_SCHEDULE_SCHEDULE` FOREIGN KEY (`user_id`) REFERENCES `tb_USER` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-20  0:36:27
