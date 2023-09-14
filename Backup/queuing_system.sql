/*
 Navicat Premium Data Transfer

 Source Server         : DatabaseServer
 Source Server Type    : MySQL
 Source Server Version : 80034
 Source Host           : 172.31.240.127:3306
 Source Schema         : queuing_system

 Target Server Type    : MySQL
 Target Server Version : 80034
 File Encoding         : 65001

 Date: 14/09/2023 11:34:33
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for db_MTAnumber
-- ----------------------------
DROP TABLE IF EXISTS `db_MTAnumber`;
CREATE TABLE `db_MTAnumber`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Category` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `TableNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 41 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_MTAnumber
-- ----------------------------
INSERT INTO `db_MTAnumber` VALUES (31, '2023-09-04', 1, 'REGULAR LANE', 'None', 'None');
INSERT INTO `db_MTAnumber` VALUES (35, '2023-09-11', 4, 'REGULAR LANE', 'None', 'None');
INSERT INTO `db_MTAnumber` VALUES (36, '2023-09-11', 5, 'REGULAR LANE', 'None', 'None');
INSERT INTO `db_MTAnumber` VALUES (37, '2023-09-11', 6, 'REGULAR LANE', 'None', 'None');
INSERT INTO `db_MTAnumber` VALUES (38, '2023-09-10', 7, 'REGULAR LANE', 'None', 'None');
INSERT INTO `db_MTAnumber` VALUES (39, '2023-09-10', 8, 'REGULAR LANE', 'None', 'None');
INSERT INTO `db_MTAnumber` VALUES (41, '2023-09-14', 2, 'REGULAR LANE', 'None', 'None');

-- ----------------------------
-- Table structure for db_MTApriority
-- ----------------------------
DROP TABLE IF EXISTS `db_MTApriority`;
CREATE TABLE `db_MTApriority`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` date NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Category` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `TableNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_MTApriority
-- ----------------------------
INSERT INTO `db_MTApriority` VALUES (1, '2023-09-14', 0, 'REGULAR LANE', 'None', '');

-- ----------------------------
-- Table structure for db_MTAregular
-- ----------------------------
DROP TABLE IF EXISTS `db_MTAregular`;
CREATE TABLE `db_MTAregular`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` date NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Category` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `TableNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_MTAregular
-- ----------------------------
INSERT INTO `db_MTAregular` VALUES (1, '2023-09-14', 2, 'REGULAR LANE', 'None', '');

-- ----------------------------
-- Table structure for db_callerservice
-- ----------------------------
DROP TABLE IF EXISTS `db_callerservice`;
CREATE TABLE `db_callerservice`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `CallerStatus` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `TableNumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Lane` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_callerservice
-- ----------------------------
INSERT INTO `db_callerservice` VALUES (1, 'IDLE', 0, '-----', '-----');

-- ----------------------------
-- Table structure for db_confirmed
-- ----------------------------
DROP TABLE IF EXISTS `db_confirmed`;
CREATE TABLE `db_confirmed`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Number` int(0) NOT NULL,
  `Lane` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Category` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Surname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Status` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Information` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3761 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for db_doneMTA
-- ----------------------------
DROP TABLE IF EXISTS `db_doneMTA`;
CREATE TABLE `db_doneMTA`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Category` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 23 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_doneMTA
-- ----------------------------
INSERT INTO `db_doneMTA` VALUES (20, '2023-09-11', 2, 'REGULAR LANE', 'None');
INSERT INTO `db_doneMTA` VALUES (21, '2023-09-11', 3, 'REGULAR LANE', 'None');
INSERT INTO `db_doneMTA` VALUES (22, '2023-09-14', 1, 'REGULAR LANE', 'None');

-- ----------------------------
-- Table structure for db_extended
-- ----------------------------
DROP TABLE IF EXISTS `db_extended`;
CREATE TABLE `db_extended`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Category` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Surname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `TableNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Information` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 192 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_extended
-- ----------------------------
INSERT INTO `db_extended` VALUES (127, '2023-09-06', 7, 'PRIORITY LANE', 'Senior Citizen', 'LANCE', 'ON TABLE NUMBER 1', NULL, NULL);

-- ----------------------------
-- Table structure for db_generatepriority
-- ----------------------------
DROP TABLE IF EXISTS `db_generatepriority`;
CREATE TABLE `db_generatepriority`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` date NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Category` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Surname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_generatepriority
-- ----------------------------
INSERT INTO `db_generatepriority` VALUES (1, '2023-09-11', 17, 'PRIORITY LANE', 'Senior Citizen', '', 'ESPINA');

-- ----------------------------
-- Table structure for db_generateregular
-- ----------------------------
DROP TABLE IF EXISTS `db_generateregular`;
CREATE TABLE `db_generateregular`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` date NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Category` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Surname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_generateregular
-- ----------------------------
INSERT INTO `db_generateregular` VALUES (1, '2023-09-11', 38, 'REGULAR LANE', 'None', '', 'ESPINA');

-- ----------------------------
-- Table structure for db_missed
-- ----------------------------
DROP TABLE IF EXISTS `db_missed`;
CREATE TABLE `db_missed`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` date NULL DEFAULT NULL,
  `Number` int(0) NULL DEFAULT NULL,
  `Lane` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Category` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `TableNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3162 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for db_onhold
-- ----------------------------
DROP TABLE IF EXISTS `db_onhold`;
CREATE TABLE `db_onhold`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Number` int(0) NOT NULL,
  `Lane` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Category` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Surname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Status` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 24 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_onhold
-- ----------------------------
INSERT INTO `db_onhold` VALUES (19, '2023-08-08', 135, 'REGULAR LANE', 'None', NULL, 'ON TABLE NUMBER 8', 'CASE STUDY');
INSERT INTO `db_onhold` VALUES (20, '2023-08-09', 25, 'REGULAR LANE', 'None', NULL, 'ON TABLE NUMBER 12', 'no signature of price quotation!');
INSERT INTO `db_onhold` VALUES (21, '2023-08-14', 1, 'PRIORITY LANE', 'Senior Citizen', NULL, 'ON TABLE NUMBER 14', 'INCONSISTENT NAME OF THE BENE IN ABSTRACT AND STATEMENT OF ACCOUNT');

-- ----------------------------
-- Table structure for done_db
-- ----------------------------
DROP TABLE IF EXISTS `done_db`;
CREATE TABLE `done_db`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Number` int(0) NOT NULL,
  `Lane` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Category` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `TableNumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 967 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for number_db
-- ----------------------------
DROP TABLE IF EXISTS `number_db`;
CREATE TABLE `number_db`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Number` int(0) NOT NULL,
  `Lane` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Category` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Surname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6722 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of number_db
-- ----------------------------
INSERT INTO `number_db` VALUES (6612, '2023-09-07', 1, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6613, '2023-09-07', 2, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6614, '2023-09-07', 3, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6615, '2023-09-07', 4, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6616, '2023-09-07', 5, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6617, '2023-09-07', 6, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6618, '2023-09-07', 7, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6619, '2023-09-07', 8, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6620, '2023-09-07', 9, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6621, '2023-09-07', 10, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6622, '2023-09-07', 11, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6623, '2023-09-07', 12, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6624, '2023-09-07', 13, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6625, '2023-09-07', 14, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6626, '2023-09-07', 15, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6627, '2023-09-07', 16, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6628, '2023-09-07', 17, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6629, '2023-09-07', 18, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6630, '2023-09-07', 19, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6631, '2023-09-07', 20, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6632, '2023-09-07', 21, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6633, '2023-09-07', 22, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6634, '2023-09-07', 23, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6635, '2023-09-07', 24, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6636, '2023-09-07', 25, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6637, '2023-09-07', 26, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6638, '2023-09-07', 27, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6639, '2023-09-07', 28, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6640, '2023-09-07', 29, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6641, '2023-09-07', 30, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6642, '2023-09-07', 31, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6643, '2023-09-07', 32, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6644, '2023-09-07', 33, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6645, '2023-09-07', 34, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6646, '2023-09-07', 35, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6647, '2023-09-07', 36, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6648, '2023-09-07', 37, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6649, '2023-09-07', 38, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6650, '2023-09-07', 39, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6651, '2023-09-07', 40, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6652, '2023-09-07', 41, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6653, '2023-09-07', 42, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6654, '2023-09-07', 43, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6655, '2023-09-07', 44, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6656, '2023-09-07', 45, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6657, '2023-09-07', 46, 'REGULAR LANE', 'None', 'None', ' ');
INSERT INTO `number_db` VALUES (6658, '2023-09-07', 47, 'REGULAR LANE', 'None', 'None', 'JABIDO');

SET FOREIGN_KEY_CHECKS = 1;
