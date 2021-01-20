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
-- Dumping data for table `tb_ADDRESS`
--

LOCK TABLES `tb_ADDRESS` WRITE;
/*!40000 ALTER TABLE `tb_ADDRESS` DISABLE KEYS */;
INSERT INTO `tb_ADDRESS` VALUES (1,'Brasil','04459110','SP','Sao Paulo','Pedreira','Av Batista Maciel',388,'casa2');
/*!40000 ALTER TABLE `tb_ADDRESS` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_BUSINNESS_SERVICE_ASSOCIATION`
--

LOCK TABLES `tb_BUSINNESS_SERVICE_ASSOCIATION` WRITE;
/*!40000 ALTER TABLE `tb_BUSINNESS_SERVICE_ASSOCIATION` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_BUSINNESS_SERVICE_ASSOCIATION` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_ESTABLISHMENT`
--

LOCK TABLES `tb_ESTABLISHMENT` WRITE;
/*!40000 ALTER TABLE `tb_ESTABLISHMENT` DISABLE KEYS */;
INSERT INTO `tb_ESTABLISHMENT` VALUES (3,'12488163000144','Barbearia Jhony','Barnearia Jhony','11988776655','1188778866','contato@contato.com.br','www.jhony.com.br','@jhony','logo.jpg','capa.jpg',1,1,1),(5,'227678899000188','Estudio de Tatuagem Kleber','Estudio de Kleber','1199999999','1177777777','contato@tatuagem.com.br','www.tatuagemjulio.com.br','@julio','logo.jpg','capa.jpg',1,1,1),(9,'9988778877000145','Estudio de Tatuagem Marcos','Estudio de Marcos','1199999999','1177777777','contato@tatuagem2.com.br','www.tatuagemmarcos.com.br','@julio','logo.jpg','capa.jpg',1,1,1),(10,'9988778807000145','Estudio de Tatuagem Marcos','Estudio de Marcos','1199999999','1177777777','contato@tatuagem3.com.br','www.tatuagemmarcos.com.br','@julio','logo.jpg','capa.jpg',1,1,1),(15,'12455676000189','Estudio de Tatuagem Maria','Estudio de Maria','1199999999','1177777777','contato@tatuagem79.com.br','www.tatuagemmarcos.com.br','@julio','logo.jpg','capa.jpg',1,1,1),(16,'12455676000154','Estudio de Tatuagem Aline','Estudio de Aline','1199999999','1177777777','contato@tatuagem80.com.br','www.tatuagemmarcos.com.br','@julio','logo.jpg','capa.jpg',1,1,1),(17,'12455676000159','Estudio de Tatuagem Kleiton','Estudio de Kleiton','1199999999','1177777777','kleiduda@gmail.com','www.tatuagemmarcos.com.br','@julio','logo.jpg','capa.jpg',1,1,1);
/*!40000 ALTER TABLE `tb_ESTABLISHMENT` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_ESTABLISHMENT_BUSINNESS`
--

LOCK TABLES `tb_ESTABLISHMENT_BUSINNESS` WRITE;
/*!40000 ALTER TABLE `tb_ESTABLISHMENT_BUSINNESS` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_ESTABLISHMENT_BUSINNESS` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_ESTABLISHMENT_CATEGORY`
--

LOCK TABLES `tb_ESTABLISHMENT_CATEGORY` WRITE;
/*!40000 ALTER TABLE `tb_ESTABLISHMENT_CATEGORY` DISABLE KEYS */;
INSERT INTO `tb_ESTABLISHMENT_CATEGORY` VALUES (1,'Barbearia','corte de cabelo e etc');
/*!40000 ALTER TABLE `tb_ESTABLISHMENT_CATEGORY` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_SCHEDULE_STATUS`
--

LOCK TABLES `tb_SCHEDULE_STATUS` WRITE;
/*!40000 ALTER TABLE `tb_SCHEDULE_STATUS` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_SCHEDULE_STATUS` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_SCHEDULES`
--

LOCK TABLES `tb_SCHEDULES` WRITE;
/*!40000 ALTER TABLE `tb_SCHEDULES` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_SCHEDULES` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_SERVICE`
--

LOCK TABLES `tb_SERVICE` WRITE;
/*!40000 ALTER TABLE `tb_SERVICE` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_SERVICE` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_USER`
--

LOCK TABLES `tb_USER` WRITE;
/*!40000 ALTER TABLE `tb_USER` DISABLE KEYS */;
INSERT INTO `tb_USER` VALUES (1,'Kleiton','Freitas','kleiduda@gmail.com','123456','32414576804','11953476594','@kleiduda','foto.jpg',1);
/*!40000 ALTER TABLE `tb_USER` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tb_USER_SCHEDULE`
--

LOCK TABLES `tb_USER_SCHEDULE` WRITE;
/*!40000 ALTER TABLE `tb_USER_SCHEDULE` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_USER_SCHEDULE` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-20  0:38:58
