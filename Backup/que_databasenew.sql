/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : que_databasenew

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2023-07-21 16:24:30
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
) ENGINE=InnoDB AUTO_INCREMENT=352 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of db_confirmed
-- ----------------------------
INSERT INTO `db_confirmed` VALUES ('109', 'July 19, 2023', '1', 'EXPRESS LANE', 'Lactating', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES ('126', 'July 19, 2023', '2', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('127', 'July 19, 2023', '3', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES ('128', 'July 19, 2023', '4', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('130', 'July 19, 2023', '8', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES ('131', 'July 19, 2023', '5', 'EXPRESS LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES ('132', 'July 19, 2023', '4', 'EXPRESS LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('133', 'July 19, 2023', '9', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES ('134', 'July 19, 2023', '10', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 13', 'Complied');
INSERT INTO `db_confirmed` VALUES ('135', 'July 19, 2023', '11', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES ('136', 'July 19, 2023', '4', 'EXPRESS LANE', 'Person with disability(PWD)', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('138', 'July 19, 2023', '14', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES ('139', 'July 19, 2023', '15', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('141', 'July 19, 2023', '18', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES ('142', 'July 19, 2023', '20', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES ('143', 'July 19, 2023', '25', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('144', 'July 19, 2023', '26', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES ('145', 'July 19, 2023', '23', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES ('146', 'July 19, 2023', '21', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('147', 'July 19, 2023', '29', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES ('148', 'July 19, 2023', '28', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('149', 'July 19, 2023', '7', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES ('156', 'July 20, 2023', '5', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES ('160', 'July 20, 2023', '7', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('161', 'July 20, 2023', '9', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('162', 'July 20, 2023', '6', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES ('167', 'July 20, 2023', '20', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('168', 'July 20, 2023', '11', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES ('179', 'July 20, 2023', '23', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('182', 'July 20, 2023', '21', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES ('183', 'July 20, 2023', '20', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES ('185', 'July 20, 2023', '25', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('192', 'July 20, 2023', '8', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('193', 'July 20, 2023', '49', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES ('195', 'July 20, 2023', '38', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('196', 'July 20, 2023', '26', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES ('200', 'July 20, 2023', '27', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES ('206', 'July 20, 2023', '55', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('207', 'July 20, 2023', '30', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES ('214', 'July 20, 2023', '64', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('215', 'July 20, 2023', '37', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('216', 'July 20, 2023', '66', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('219', 'July 20, 2023', '63', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('226', 'July 20, 2023', '7', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('227', 'July 20, 2023', '71', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES ('229', 'July 20, 2023', '82', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('230', 'July 20, 2023', '36', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('231', 'July 20, 2023', '72', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES ('232', 'July 20, 2023', '40', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES ('233', 'July 20, 2023', '78', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES ('235', 'July 20, 2023', '41', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('239', 'July 20, 2023', '80', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('241', 'July 20, 2023', '95', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('244', 'July 20, 2023', '90', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('246', 'July 20, 2023', '94', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES ('249', 'July 20, 2023', '32', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES ('252', 'July 20, 2023', '98', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('253', 'July 20, 2023', '47', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES ('255', 'July 20, 2023', '48', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('257', 'July 20, 2023', '96', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('258', 'July 20, 2023', '50', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES ('259', 'July 20, 2023', '85', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES ('261', 'July 20, 2023', '51', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('263', 'July 20, 2023', '54', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('264', 'July 20, 2023', '53', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('266', 'July 20, 2023', '105', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES ('268', 'July 20, 2023', '56', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('269', 'July 20, 2023', '59', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES ('272', 'July 20, 2023', '61', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES ('274', 'July 20, 2023', '79', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES ('276', 'July 20, 2023', '63', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES ('277', 'July 20, 2023', '29', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES ('278', 'July 20, 2023', '62', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES ('279', 'July 20, 2023', '81', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES ('280', 'July 20, 2023', '103', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES ('281', 'July 20, 2023', '31', 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES ('282', 'July 20, 2023', '65', 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');

-- ----------------------------
-- Table structure for `db_generatepriority`
-- ----------------------------
DROP TABLE IF EXISTS `db_generatepriority`;
CREATE TABLE `db_generatepriority` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Number` int(11) DEFAULT NULL,
  `Lane` varchar(250) DEFAULT NULL,
  `Category` varchar(250) DEFAULT NULL,
  `TableNo` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of db_generatepriority
-- ----------------------------
INSERT INTO `db_generatepriority` VALUES ('1', '2023-07-21', '79', 'PRIORITY LANE', 'None', '');

-- ----------------------------
-- Table structure for `db_generateregular`
-- ----------------------------
DROP TABLE IF EXISTS `db_generateregular`;
CREATE TABLE `db_generateregular` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Number` int(11) DEFAULT NULL,
  `Lane` varchar(250) DEFAULT NULL,
  `Category` varchar(250) DEFAULT NULL,
  `TableNo` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of db_generateregular
-- ----------------------------
INSERT INTO `db_generateregular` VALUES ('1', '2023-07-21', '124', 'REGULAR LANE', 'None', '');

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
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=257 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of done_db
-- ----------------------------
INSERT INTO `done_db` VALUES ('108', 'July 19, 2023', '1', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('110', 'July 19, 2023', '6', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('111', 'July 19, 2023', '13', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('112', 'July 19, 2023', '2', 'EXPRESS LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('113', 'July 19, 2023', '16', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('114', 'July 20, 2023', '3', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('115', 'July 20, 2023', '4', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('116', 'July 20, 2023', '1', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('117', 'July 20, 2023', '6', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('118', 'July 20, 2023', '17', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('119', 'July 20, 2023', '9', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('120', 'July 20, 2023', '3', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('121', 'July 20, 2023', '1', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('122', 'July 20, 2023', '8', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('123', 'July 20, 2023', '14', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('124', 'July 20, 2023', '15', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('125', 'July 20, 2023', '41', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('126', 'July 20, 2023', '5', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('127', 'July 20, 2023', '32', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('128', 'July 20, 2023', '16', 'PRIORITY LANE', 'Lactating');
INSERT INTO `done_db` VALUES ('129', 'July 20, 2023', '48', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('130', 'July 20, 2023', '27', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('131', 'July 20, 2023', '11', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('132', 'July 20, 2023', '12', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('133', 'July 20, 2023', '29', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('134', 'July 20, 2023', '2', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('135', 'July 20, 2023', '22', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('136', 'July 20, 2023', '35', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('137', 'July 20, 2023', '56', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('138', 'July 20, 2023', '14', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('139', 'July 20, 2023', '19', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('140', 'July 20, 2023', '31', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('141', 'July 20, 2023', '33', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('142', 'July 20, 2023', '54', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('143', 'July 20, 2023', '36', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('144', 'July 20, 2023', '15', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('145', 'July 20, 2023', '18', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('146', 'July 20, 2023', '52', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('147', 'July 20, 2023', '43', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('148', 'July 20, 2023', '13', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('149', 'July 20, 2023', '51', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('150', 'July 20, 2023', '47', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('151', 'July 20, 2023', '2', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('152', 'July 20, 2023', '23', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('153', 'July 20, 2023', '23', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('154', 'July 20, 2023', '42', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('155', 'July 20, 2023', '46', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('156', 'July 20, 2023', '70', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('157', 'July 20, 2023', '28', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('158', 'July 20, 2023', '67', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('159', 'July 20, 2023', '34', 'PRIORITY LANE', 'Pregnant');
INSERT INTO `done_db` VALUES ('160', 'July 20, 2023', '69', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('161', 'July 20, 2023', '76', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('162', 'July 20, 2023', '39', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('163', 'July 20, 2023', '75', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('164', 'July 20, 2023', '91', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('165', 'July 20, 2023', '59', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('166', 'July 20, 2023', '93', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('167', 'July 20, 2023', '99', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('168', 'July 20, 2023', '84', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('169', 'July 20, 2023', '83', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('170', 'July 20, 2023', '40', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('171', 'July 20, 2023', '39', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('172', 'July 20, 2023', '26', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('173', 'July 20, 2023', '89', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('174', 'July 20, 2023', '52', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('175', 'July 20, 2023', '33', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('176', 'July 20, 2023', '100', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('177', 'July 20, 2023', '101', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('178', 'July 20, 2023', '102', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('179', 'July 20, 2023', '60', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('180', 'July 20, 2023', '62', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('181', 'July 20, 2023', '44', 'PRIORITY LANE', 'Lactating');
INSERT INTO `done_db` VALUES ('182', 'July 20, 2023', '68', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('183', 'July 20, 2023', '87', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('184', 'July 20, 2023', '55', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('185', 'July 20, 2023', '57', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('186', 'July 20, 2023', '30', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('187', 'July 20, 2023', '53', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('188', 'July 20, 2023', '58', 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES ('189', 'July 20, 2023', '61', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('190', 'July 20, 2023', '92', 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES ('191', 'July 20, 2023', '106', 'REGULAR LANE', 'None');

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
) ENGINE=InnoDB AUTO_INCREMENT=1075 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of number_db
-- ----------------------------
INSERT INTO `number_db` VALUES ('181', '', '1', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('182', 'July 13, 2023', '2', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('183', 'July 13, 2023', '3', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('184', 'July 13, 2023', '4', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('185', 'July 13, 2023', '1', 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES ('186', 'July 13, 2023', '2', 'EXPRESS LANE', 'Lactating', 'None');
INSERT INTO `number_db` VALUES ('187', 'July 13, 2023', '3', 'REGULAR LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES ('188', 'July 13, 2023', '4', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('189', 'July 13, 2023', '5', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('190', 'July 13, 2023', '3', 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES ('191', 'July 13, 2023', '4', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('192', 'July 13, 2023', '5', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('193', 'July 13, 2023', '4', 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES ('194', 'July 13, 2023', '5', 'EXPRESS LANE', 'Pregnant', '');
INSERT INTO `number_db` VALUES ('195', 'July 13, 2023', '6', 'EXPRESS LANE', 'Pregnant', '');
INSERT INTO `number_db` VALUES ('196', 'July 13, 2023', '6', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('197', 'July 13, 2023', '7', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('198', 'July 13, 2023', '8', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('199', 'July 13, 2023', '9', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('200', 'July 13, 2023', '10', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('201', 'July 13, 2023', '7', 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES ('202', 'July 13, 2023', '11', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('203', 'July 13, 2023', '8', 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES ('204', 'July 13, 2023', '12', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('205', 'July 13, 2023', '9', 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES ('206', 'July 13, 2023', '10', 'EXPRESS LANE', 'Lactating', '');
INSERT INTO `number_db` VALUES ('207', 'July 13, 2023', '13', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('208', 'July 13, 2023', '14', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('209', 'July 13, 2023', '15', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('210', 'July 13, 2023', '16', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('211', 'July 13, 2023', '11', 'EXPRESS LANE', 'Lactating', '');
INSERT INTO `number_db` VALUES ('212', 'July 13, 2023', '12', 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES ('213', 'July 13, 2023', '17', 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES ('214', 'July 13, 2023', '13', 'EXPRESS LANE', 'Lactating', '');
INSERT INTO `number_db` VALUES ('414', 'July 17, 2023', '1', 'EXPRESS LANE', 'Person with disability(PWD)', 'None');
INSERT INTO `number_db` VALUES ('415', 'July 17, 2023', '2', 'EXPRESS LANE', 'Pregnant', 'None');
INSERT INTO `number_db` VALUES ('416', 'July 17, 2023', '1', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('482', 'July 19, 2023', '5', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('485', 'July 19, 2023', '3', 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES ('493', 'July 19, 2023', '12', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('495', 'July 19, 2023', '5', 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES ('500', 'July 19, 2023', '17', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('502', 'July 19, 2023', '19', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('505', 'July 19, 2023', '22', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('507', 'July 19, 2023', '24', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('510', 'July 19, 2023', '27', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('513', 'July 19, 2023', '28', 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('830', '21/07/2023', '3', 'PRIORITY LANE', 'None', 'None');
INSERT INTO `number_db` VALUES ('831', '21/07/2023', '4', 'PRIORITY LANE', 'None', 'None');
