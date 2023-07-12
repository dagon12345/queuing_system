/*
Navicat MySQL Data Transfer

Source Server         : desktop ip
Source Server Version : 50505
Source Host           : 172.31.242.29:3306
Source Database       : que_databasenew

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2023-07-12 09:15:29
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `db_confirmed`
-- ----------------------------
DROP TABLE IF EXISTS `db_confirmed`;
CREATE TABLE `db_confirmed` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) NOT NULL,
  `Number` int(11) NOT NULL,
  `Lane` varchar(250) NOT NULL,
  `Category` varchar(250) NOT NULL,
  `TableNo` varchar(250) NOT NULL,
  `Status` varchar(250) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of db_confirmed
-- ----------------------------

-- ----------------------------
-- Table structure for `db_onhold`
-- ----------------------------
DROP TABLE IF EXISTS `db_onhold`;
CREATE TABLE `db_onhold` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) NOT NULL,
  `Number` int(11) NOT NULL,
  `Lane` varchar(250) NOT NULL,
  `Category` varchar(250) NOT NULL,
  `TableNo` varchar(250) NOT NULL,
  `Status` varchar(250) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of db_onhold
-- ----------------------------

-- ----------------------------
-- Table structure for `done_db`
-- ----------------------------
DROP TABLE IF EXISTS `done_db`;
CREATE TABLE `done_db` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) NOT NULL,
  `Number` int(11) NOT NULL,
  `Lane` varchar(250) NOT NULL,
  `Category` varchar(250) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of done_db
-- ----------------------------

-- ----------------------------
-- Table structure for `number_db`
-- ----------------------------
DROP TABLE IF EXISTS `number_db`;
CREATE TABLE `number_db` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) NOT NULL,
  `Number` int(11) NOT NULL,
  `Lane` varchar(250) NOT NULL,
  `Category` varchar(250) NOT NULL,
  `TableNo` varchar(250) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of number_db
-- ----------------------------
