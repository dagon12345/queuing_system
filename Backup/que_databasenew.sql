/*
 Navicat Premium Data Transfer

 Source Server         : DatabaseServer
 Source Server Type    : MySQL
 Source Server Version : 80033
 Source Host           : 172.31.240.127:3306
 Source Schema         : queuing_system

 Target Server Type    : MySQL
 Target Server Version : 80033
 File Encoding         : 65001

 Date: 08/08/2023 11:49:33
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
) ENGINE = InnoDB AUTO_INCREMENT = 31 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

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
INSERT INTO `db_MTApriority` VALUES (1, '2023-08-08', 0, 'REGULAR LANE', 'None', '');

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
INSERT INTO `db_MTAregular` VALUES (1, '2023-08-08', 0, 'REGULAR LANE', 'None', '');

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
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Status` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 623 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_confirmed
-- ----------------------------
INSERT INTO `db_confirmed` VALUES (109, 'July 19, 2023', 1, 'EXPRESS LANE', 'Lactating', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (126, 'July 19, 2023', 2, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (127, 'July 19, 2023', 3, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (128, 'July 19, 2023', 4, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (130, 'July 19, 2023', 8, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (131, 'July 19, 2023', 5, 'EXPRESS LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (132, 'July 19, 2023', 4, 'EXPRESS LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (133, 'July 19, 2023', 9, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (134, 'July 19, 2023', 10, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 13', 'Complied');
INSERT INTO `db_confirmed` VALUES (135, 'July 19, 2023', 11, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (136, 'July 19, 2023', 4, 'EXPRESS LANE', 'Person with disability(PWD)', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (138, 'July 19, 2023', 14, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (139, 'July 19, 2023', 15, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (141, 'July 19, 2023', 18, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (142, 'July 19, 2023', 20, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (143, 'July 19, 2023', 25, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (144, 'July 19, 2023', 26, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (145, 'July 19, 2023', 23, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (146, 'July 19, 2023', 21, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (147, 'July 19, 2023', 29, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (148, 'July 19, 2023', 28, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (149, 'July 19, 2023', 7, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (156, 'July 20, 2023', 5, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (160, 'July 20, 2023', 7, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (161, 'July 20, 2023', 9, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (162, 'July 20, 2023', 6, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (167, 'July 20, 2023', 20, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (168, 'July 20, 2023', 11, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (179, 'July 20, 2023', 23, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (182, 'July 20, 2023', 21, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (183, 'July 20, 2023', 20, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (185, 'July 20, 2023', 25, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (192, 'July 20, 2023', 8, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (193, 'July 20, 2023', 49, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (195, 'July 20, 2023', 38, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (196, 'July 20, 2023', 26, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (200, 'July 20, 2023', 27, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (206, 'July 20, 2023', 55, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (207, 'July 20, 2023', 30, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (214, 'July 20, 2023', 64, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (215, 'July 20, 2023', 37, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (216, 'July 20, 2023', 66, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (219, 'July 20, 2023', 63, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (226, 'July 20, 2023', 7, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (227, 'July 20, 2023', 71, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (229, 'July 20, 2023', 82, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (230, 'July 20, 2023', 36, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (231, 'July 20, 2023', 72, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (232, 'July 20, 2023', 40, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (233, 'July 20, 2023', 78, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (235, 'July 20, 2023', 41, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (239, 'July 20, 2023', 80, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (241, 'July 20, 2023', 95, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (244, 'July 20, 2023', 90, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (246, 'July 20, 2023', 94, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (249, 'July 20, 2023', 32, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (252, 'July 20, 2023', 98, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (253, 'July 20, 2023', 47, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (255, 'July 20, 2023', 48, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (257, 'July 20, 2023', 96, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (258, 'July 20, 2023', 50, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (259, 'July 20, 2023', 85, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (261, 'July 20, 2023', 51, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (263, 'July 20, 2023', 54, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (264, 'July 20, 2023', 53, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (266, 'July 20, 2023', 105, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (268, 'July 20, 2023', 56, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (269, 'July 20, 2023', 59, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (272, 'July 20, 2023', 61, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (274, 'July 20, 2023', 79, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (276, 'July 20, 2023', 63, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (277, 'July 20, 2023', 29, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (278, 'July 20, 2023', 62, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (279, 'July 20, 2023', 81, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (280, 'July 20, 2023', 103, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (281, 'July 20, 2023', 31, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (282, 'July 20, 2023', 65, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (370, '2023-08-04', 72, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (371, '2023-08-04', 71, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 13', 'Complied');
INSERT INTO `db_confirmed` VALUES (372, '2023-08-04', 75, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (374, '2023-08-04', 76, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (376, '2023-08-04', 77, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (378, '2023-08-04', 79, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (379, '2023-08-04', 74, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (381, '2023-08-04', 127, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (382, '2023-08-04', 128, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (383, '2023-08-04', 130, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 13', 'Complied');
INSERT INTO `db_confirmed` VALUES (384, '2023-08-04', 83, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (385, '2023-08-04', 123, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (386, '2023-08-04', 92, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (388, '2023-08-04', 87, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (389, '2023-08-04', 85, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (390, '2023-08-04', 126, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (392, '2023-08-04', 134, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (393, '2023-08-04', 122, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (395, '2023-08-04', 90, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (397, '2023-08-04', 145, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (398, '2023-08-04', 140, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (399, '2023-08-04', 191, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (401, '2023-08-04', 147, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (402, '2023-08-04', 82, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (404, '2023-08-04', 141, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (405, '2023-08-04', 93, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (406, '2023-08-04', 94, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (407, '2023-08-04', 150, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (409, '2023-08-04', 101, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (411, '2023-08-04', 158, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (412, '2023-08-04', 168, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (413, '2023-08-04', 95, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (414, '2023-08-04', 167, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (415, '2023-08-04', 166, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (416, '2023-08-04', 165, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (417, '2023-08-04', 169, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (418, '2023-08-04', 171, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (420, '2023-08-04', 175, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (421, '2023-08-04', 151, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 13', 'Complied');
INSERT INTO `db_confirmed` VALUES (422, '2023-08-04', 176, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (423, '2023-08-04', 194, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (424, '2023-08-04', 185, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (425, '2023-08-04', 180, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (426, '2023-08-04', 153, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (428, '2023-08-04', 178, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (429, '2023-08-04', 182, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 13', 'Complied');
INSERT INTO `db_confirmed` VALUES (430, '2023-08-04', 102, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (431, '2023-08-04', 89, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (432, '2023-08-04', 189, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (433, '2023-08-04', 184, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (434, '2023-08-04', 186, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (435, '2023-08-04', 177, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (436, '2023-08-04', 173, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (437, '2023-08-04', 106, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (438, '2023-08-04', 104, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (439, '2023-08-04', 138, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (440, '2023-08-04', 160, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (441, '2023-08-04', 100, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (442, '2023-08-04', 192, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (443, '2023-08-04', 181, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (444, '2023-08-04', 195, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (445, '2023-08-04', 193, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (446, '2023-08-04', 98, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (447, '2023-08-04', 201, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (448, '2023-08-04', 187, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (449, '2023-08-04', 202, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (450, '2023-08-04', 183, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 13', 'Complied');
INSERT INTO `db_confirmed` VALUES (451, '2023-08-04', 209, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (452, '2023-08-04', 172, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (453, '2023-08-04', 200, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (454, '2023-08-04', 207, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (455, '2023-08-04', 203, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (456, '2023-08-04', 205, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (457, '2023-08-04', 107, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (458, '2023-08-04', 214, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (459, '2023-08-04', 210, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (460, '2023-08-04', 212, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (461, '2023-08-04', 211, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (462, '2023-08-04', 136, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (463, '2023-08-04', 213, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (464, '2023-08-04', 196, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (465, '2023-08-04', 215, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (466, '2023-08-04', 220, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (467, '2023-08-04', 223, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (468, '2023-08-04', 108, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (469, '2023-08-04', 218, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (470, '2023-08-04', 226, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (471, '2023-08-04', 228, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (472, '2023-08-04', 224, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (473, '2023-08-04', 227, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (474, '2023-08-04', 216, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (475, '2023-08-04', 221, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (476, '2023-08-04', 219, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (477, '2023-08-04', 199, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (478, '2023-08-04', 222, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (479, '2023-08-04', 144, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (480, '2023-08-07', 114, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (481, '2023-08-07', 57, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (482, '2023-08-07', 63, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (483, '2023-08-07', 61, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (484, '2023-08-07', 64, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (485, '2023-08-07', 65, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (486, '2023-08-07', 94, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (487, '2023-08-07', 86, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (488, '2023-08-07', 58, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (489, '2023-08-07', 67, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (490, '2023-08-07', 142, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (491, '2023-08-07', 69, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (492, '2023-08-07', 98, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (493, '2023-08-07', 100, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (494, '2023-08-07', 59, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (495, '2023-08-07', 102, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (496, '2023-08-07', 103, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (497, '2023-08-07', 88, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (498, '2023-08-07', 107, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (499, '2023-08-07', 62, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (500, '2023-08-07', 111, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (501, '2023-08-07', 110, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (502, '2023-08-07', 118, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (503, '2023-08-07', 113, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (504, '2023-08-07', 72, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (505, '2023-08-07', 71, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (506, '2023-08-07', 76, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (507, '2023-08-07', 70, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (508, '2023-08-07', 75, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (509, '2023-08-07', 82, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (510, '2023-08-07', 74, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (511, '2023-08-07', 121, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (512, '2023-08-07', 108, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (513, '2023-08-07', 125, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (514, '2023-08-07', 120, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (515, '2023-08-07', 124, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (516, '2023-08-07', 129, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (517, '2023-08-07', 119, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (518, '2023-08-07', 85, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (519, '2023-08-07', 84, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (520, '2023-08-07', 128, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (521, '2023-08-07', 126, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (522, '2023-08-07', 86, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (523, '2023-08-07', 83, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (524, '2023-08-07', 87, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (525, '2023-08-07', 135, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (526, '2023-08-07', 91, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (527, '2023-08-07', 156, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (528, '2023-08-07', 88, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (529, '2023-08-07', 93, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (530, '2023-08-07', 155, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (531, '2023-08-07', 133, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (532, '2023-08-07', 92, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (533, '2023-08-07', 139, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (534, '2023-08-07', 127, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (535, '2023-08-07', 140, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (536, '2023-08-07', 145, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (537, '2023-08-07', 105, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (538, '2023-08-07', 117, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (539, '2023-08-07', 151, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (540, '2023-08-07', 141, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (541, '2023-08-07', 137, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (542, '2023-08-07', 143, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (543, '2023-08-07', 147, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (544, '2023-08-07', 149, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (545, '2023-08-07', 148, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (546, '2023-08-07', 146, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (547, '2023-08-07', 96, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (548, '2023-08-07', 150, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (549, '2023-08-07', 97, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (550, '2023-08-07', 79, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (551, '2023-08-07', 99, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (552, '2023-08-07', 66, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (553, '2023-08-07', 95, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (554, '2023-08-07', 160, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (555, '2023-08-07', 101, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (556, '2023-08-07', 159, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (557, '2023-08-07', 102, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (558, '2023-08-07', 172, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (559, '2023-08-07', 166, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (560, '2023-08-07', 104, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (561, '2023-08-07', 164, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (562, '2023-08-07', 105, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (563, '2023-08-07', 174, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (564, '2023-08-07', 106, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (565, '2023-08-07', 175, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (566, '2023-08-07', 178, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (567, '2023-08-07', 108, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (568, '2023-08-07', 165, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (569, '2023-08-07', 109, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (570, '2023-08-07', 185, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (571, '2023-08-07', 176, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (572, '2023-08-07', 171, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (573, '2023-08-07', 110, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (574, '2023-08-07', 184, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (575, '2023-08-07', 182, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (576, '2023-08-07', 179, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (577, '2023-08-07', 183, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (578, '2023-08-07', 173, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (579, '2023-08-07', 180, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (580, '2023-08-07', 111, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (581, '2023-08-07', 186, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (582, '2023-08-07', 195, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (583, '2023-08-07', 196, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (584, '2023-08-07', 197, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (585, '2023-08-07', 91, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (586, '2023-08-07', 181, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (587, '2023-08-07', 202, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (588, '2023-08-07', 194, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (589, '2023-08-07', 169, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (590, '2023-08-07', 168, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (591, '2023-08-07', 203, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (592, '2023-08-07', 200, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (593, '2023-08-07', 113, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (594, '2023-08-07', 204, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (595, '2023-08-07', 208, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (596, '2023-08-07', 189, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (597, '2023-08-07', 112, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (598, '2023-08-07', 201, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (599, '2023-08-07', 114, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (600, '2023-08-07', 115, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (601, '2023-08-07', 209, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (602, '2023-08-07', 207, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (603, '2023-08-07', 89, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (604, '2023-08-07', 211, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 4', 'Complied');
INSERT INTO `db_confirmed` VALUES (605, '2023-08-07', 210, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (606, '2023-08-07', 116, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (607, '2023-08-07', 212, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (608, '2023-08-07', 213, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (609, '2023-08-08', 1, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (611, '2023-08-08', 2, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (614, '2023-08-08', 4, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (616, '2023-08-08', 8, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (618, '2023-08-08', 7, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (619, '2023-08-08', 10, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (620, '2023-08-08', 6, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (621, '2023-08-08', 7, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (622, '2023-08-08', 4, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (623, '2023-08-08', 11, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (624, '2023-08-08', 12, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (625, '2023-08-08', 10, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (626, '2023-08-08', 13, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (628, '2023-08-08', 3, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (630, '2023-08-08', 17, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (631, '2023-08-08', 14, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (632, '2023-08-08', 12, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (633, '2023-08-08', 17, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (634, '2023-08-08', 18, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (635, '2023-08-08', 19, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (636, '2023-08-08', 24, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (638, '2023-08-08', 16, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (641, '2023-08-08', 13, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (642, '2023-08-08', 27, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (643, '2023-08-08', 25, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (644, '2023-08-08', 20, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (645, '2023-08-08', 30, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (646, '2023-08-08', 18, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (647, '2023-08-08', 24, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (648, '2023-08-08', 6, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (649, '2023-08-08', 33, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (650, '2023-08-08', 36, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (651, '2023-08-08', 22, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (652, '2023-08-08', 23, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (653, '2023-08-08', 51, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (654, '2023-08-08', 29, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (655, '2023-08-08', 26, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (656, '2023-08-08', 34, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (657, '2023-08-08', 37, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (658, '2023-08-08', 31, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (659, '2023-08-08', 21, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 2', 'Complied');
INSERT INTO `db_confirmed` VALUES (660, '2023-08-08', 32, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (661, '2023-08-08', 30, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (662, '2023-08-08', 38, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (663, '2023-08-08', 54, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (664, '2023-08-08', 32, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (665, '2023-08-08', 39, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 1', 'Complied');
INSERT INTO `db_confirmed` VALUES (666, '2023-08-08', 52, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (667, '2023-08-08', 31, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 14', 'Complied');
INSERT INTO `db_confirmed` VALUES (668, '2023-08-08', 35, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 3', 'Complied');
INSERT INTO `db_confirmed` VALUES (669, '2023-08-08', 39, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (670, '2023-08-08', 41, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 5', 'Complied');
INSERT INTO `db_confirmed` VALUES (671, '2023-08-08', 40, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 6', 'Complied');
INSERT INTO `db_confirmed` VALUES (672, '2023-08-08', 44, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 7', 'Complied');
INSERT INTO `db_confirmed` VALUES (673, '2023-08-08', 36, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 8', 'Complied');
INSERT INTO `db_confirmed` VALUES (674, '2023-08-08', 46, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 9', 'Complied');
INSERT INTO `db_confirmed` VALUES (675, '2023-08-08', 52, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 10', 'Complied');
INSERT INTO `db_confirmed` VALUES (676, '2023-08-08', 54, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 11', 'Complied');
INSERT INTO `db_confirmed` VALUES (677, '2023-08-08', 56, 'REGULAR LANE', 'None', 'ON TABLE NUMBER 12', 'Complied');
INSERT INTO `db_confirmed` VALUES (678, '2023-08-08', 20, 'PRIORITY LANE', 'Senior Citizen', 'ON TABLE NUMBER 14', 'Complied');

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
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

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
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_generatepriority
-- ----------------------------
INSERT INTO `db_generatepriority` VALUES (1, '2023-08-08', 100, 'PRIORITY LANE', 'Senior Citizen', '');

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
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of db_generateregular
-- ----------------------------
INSERT INTO `db_generateregular` VALUES (1, '2023-08-08', 140, 'REGULAR LANE', 'None', '');

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
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

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
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Status` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

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
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 289 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of done_db
-- ----------------------------
INSERT INTO `done_db` VALUES (108, 'July 19, 2023', 1, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (110, 'July 19, 2023', 6, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (111, 'July 19, 2023', 13, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (112, 'July 19, 2023', 2, 'EXPRESS LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (113, 'July 19, 2023', 16, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (114, 'July 20, 2023', 3, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (115, 'July 20, 2023', 4, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (116, 'July 20, 2023', 1, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (117, 'July 20, 2023', 6, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (118, 'July 20, 2023', 17, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (119, 'July 20, 2023', 9, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (120, 'July 20, 2023', 3, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (121, 'July 20, 2023', 1, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (122, 'July 20, 2023', 8, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (123, 'July 20, 2023', 14, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (124, 'July 20, 2023', 15, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (125, 'July 20, 2023', 41, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (126, 'July 20, 2023', 5, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (127, 'July 20, 2023', 32, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (128, 'July 20, 2023', 16, 'PRIORITY LANE', 'Lactating');
INSERT INTO `done_db` VALUES (129, 'July 20, 2023', 48, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (130, 'July 20, 2023', 27, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (131, 'July 20, 2023', 11, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (132, 'July 20, 2023', 12, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (133, 'July 20, 2023', 29, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (134, 'July 20, 2023', 2, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (135, 'July 20, 2023', 22, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (136, 'July 20, 2023', 35, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (137, 'July 20, 2023', 56, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (138, 'July 20, 2023', 14, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (139, 'July 20, 2023', 19, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (140, 'July 20, 2023', 31, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (141, 'July 20, 2023', 33, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (142, 'July 20, 2023', 54, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (143, 'July 20, 2023', 36, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (144, 'July 20, 2023', 15, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (145, 'July 20, 2023', 18, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (146, 'July 20, 2023', 52, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (147, 'July 20, 2023', 43, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (148, 'July 20, 2023', 13, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (149, 'July 20, 2023', 51, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (150, 'July 20, 2023', 47, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (151, 'July 20, 2023', 2, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (152, 'July 20, 2023', 23, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (153, 'July 20, 2023', 23, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (154, 'July 20, 2023', 42, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (155, 'July 20, 2023', 46, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (156, 'July 20, 2023', 70, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (157, 'July 20, 2023', 28, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (158, 'July 20, 2023', 67, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (159, 'July 20, 2023', 34, 'PRIORITY LANE', 'Pregnant');
INSERT INTO `done_db` VALUES (160, 'July 20, 2023', 69, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (161, 'July 20, 2023', 76, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (162, 'July 20, 2023', 39, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (163, 'July 20, 2023', 75, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (164, 'July 20, 2023', 91, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (165, 'July 20, 2023', 59, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (166, 'July 20, 2023', 93, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (167, 'July 20, 2023', 99, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (168, 'July 20, 2023', 84, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (169, 'July 20, 2023', 83, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (170, 'July 20, 2023', 40, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (171, 'July 20, 2023', 39, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (172, 'July 20, 2023', 26, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (173, 'July 20, 2023', 89, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (174, 'July 20, 2023', 52, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (175, 'July 20, 2023', 33, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (176, 'July 20, 2023', 100, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (177, 'July 20, 2023', 101, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (178, 'July 20, 2023', 102, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (179, 'July 20, 2023', 60, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (180, 'July 20, 2023', 62, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (181, 'July 20, 2023', 44, 'PRIORITY LANE', 'Lactating');
INSERT INTO `done_db` VALUES (182, 'July 20, 2023', 68, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (183, 'July 20, 2023', 87, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (184, 'July 20, 2023', 55, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (185, 'July 20, 2023', 57, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (186, 'July 20, 2023', 30, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (187, 'July 20, 2023', 53, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (188, 'July 20, 2023', 58, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (189, 'July 20, 2023', 61, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (190, 'July 20, 2023', 92, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (191, 'July 20, 2023', 106, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (261, '2023-07-21', 83, 'PRIORITY LANE', 'Emergency');
INSERT INTO `done_db` VALUES (276, '2023-08-04', 80, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (277, '2023-08-04', 88, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (278, '2023-08-04', 135, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (279, '2023-08-04', 148, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (280, '2023-08-04', 143, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (281, '2023-08-04', 133, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (282, '2023-08-04', 91, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (283, '2023-08-04', 152, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (284, '2023-08-04', 139, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (285, '2023-08-04', 121, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (286, '2023-08-04', 159, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (287, '2023-08-04', 103, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (288, '2023-08-08', 5, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (289, '2023-08-08', 5, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (290, '2023-08-08', 9, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (291, '2023-08-08', 2, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (292, '2023-08-08', 15, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (293, '2023-08-08', 16, 'PRIORITY LANE', 'Senior Citizen');
INSERT INTO `done_db` VALUES (294, '2023-08-08', 19, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (295, '2023-08-08', 15, 'REGULAR LANE', 'None');
INSERT INTO `done_db` VALUES (296, '2023-08-08', 26, 'PRIORITY LANE', 'Senior Citizen');

-- ----------------------------
-- Table structure for number_db
-- ----------------------------
DROP TABLE IF EXISTS `number_db`;
CREATE TABLE `number_db`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `Date` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Number` int(0) NOT NULL,
  `Lane` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Category` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `TableNo` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1751 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of number_db
-- ----------------------------
INSERT INTO `number_db` VALUES (123, '2023-08-08', 45, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (182, 'July 13, 2023', 2, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (183, 'July 13, 2023', 3, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (184, 'July 13, 2023', 4, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (185, 'July 13, 2023', 1, 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (186, 'July 13, 2023', 2, 'EXPRESS LANE', 'Lactating', 'None');
INSERT INTO `number_db` VALUES (187, 'July 13, 2023', 3, 'REGULAR LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES (188, 'July 13, 2023', 4, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (189, 'July 13, 2023', 5, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (190, 'July 13, 2023', 3, 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES (191, 'July 13, 2023', 4, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (192, 'July 13, 2023', 5, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (193, 'July 13, 2023', 4, 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES (194, 'July 13, 2023', 5, 'EXPRESS LANE', 'Pregnant', '');
INSERT INTO `number_db` VALUES (195, 'July 13, 2023', 6, 'EXPRESS LANE', 'Pregnant', '');
INSERT INTO `number_db` VALUES (196, 'July 13, 2023', 6, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (197, 'July 13, 2023', 7, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (198, 'July 13, 2023', 8, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (199, 'July 13, 2023', 9, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (200, 'July 13, 2023', 10, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (201, 'July 13, 2023', 7, 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES (202, 'July 13, 2023', 11, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (203, 'July 13, 2023', 8, 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES (204, 'July 13, 2023', 12, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (205, 'July 13, 2023', 9, 'EXPRESS LANE', 'Person with disability(PWD)', '');
INSERT INTO `number_db` VALUES (206, 'July 13, 2023', 10, 'EXPRESS LANE', 'Lactating', '');
INSERT INTO `number_db` VALUES (207, 'July 13, 2023', 13, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (208, 'July 13, 2023', 14, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (209, 'July 13, 2023', 15, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (210, 'July 13, 2023', 16, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (211, 'July 13, 2023', 11, 'EXPRESS LANE', 'Lactating', '');
INSERT INTO `number_db` VALUES (212, 'July 13, 2023', 12, 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (213, 'July 13, 2023', 17, 'REGULAR LANE', 'None', '');
INSERT INTO `number_db` VALUES (214, 'July 13, 2023', 13, 'EXPRESS LANE', 'Lactating', '');
INSERT INTO `number_db` VALUES (414, 'July 17, 2023', 1, 'EXPRESS LANE', 'Person with disability(PWD)', 'None');
INSERT INTO `number_db` VALUES (415, 'July 17, 2023', 2, 'EXPRESS LANE', 'Pregnant', 'None');
INSERT INTO `number_db` VALUES (416, 'July 17, 2023', 1, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (482, 'July 19, 2023', 5, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (485, 'July 19, 2023', 3, 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (493, 'July 19, 2023', 12, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (495, 'July 19, 2023', 5, 'EXPRESS LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (500, 'July 19, 2023', 17, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (502, 'July 19, 2023', 19, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (505, 'July 19, 2023', 22, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (507, 'July 19, 2023', 24, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (510, 'July 19, 2023', 27, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (513, 'July 19, 2023', 28, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (830, '21/07/2023', 3, 'PRIORITY LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (831, '21/07/2023', 4, 'PRIORITY LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1078, 'July 21, 2023', 127, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1080, '2023-07-21', 81, 'PRIORITY LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1081, '2023-07-21', 82, 'PRIORITY LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1083, '2023-07-21', 84, 'PRIORITY LANE', 'Person with disability(PWD)', 'None');
INSERT INTO `number_db` VALUES (1084, '2023-07-21', 85, 'PRIORITY LANE', 'Pregnant', 'None');
INSERT INTO `number_db` VALUES (1085, '2023-07-21', 86, 'PRIORITY LANE', 'Emergency', 'None');
INSERT INTO `number_db` VALUES (1086, '2023-07-21', 87, 'PRIORITY LANE', 'Lactating', 'None');
INSERT INTO `number_db` VALUES (1087, '2023-07-21', 88, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1089, '2023-07-24', 2, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1090, '2023-07-25', 1, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1091, '2023-07-25', 2, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1092, '2023-07-25', 1, 'PRIORITY LANE', 'Emergency', 'None');
INSERT INTO `number_db` VALUES (1126, '2023-07-31', 1, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1127, '2023-07-31', 2, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1128, '2023-07-31', 3, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1129, '2023-07-31', 1, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1130, '2023-07-31', 4, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1131, '2023-07-31', 5, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1132, '2023-07-31', 6, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1133, '2023-07-31', 2, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1134, '2023-07-31', 3, 'PRIORITY LANE', 'Emergency', 'None');
INSERT INTO `number_db` VALUES (1135, '2023-07-31', 7, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1136, '2023-07-31', 8, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1137, '2023-07-31', 9, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1138, '2023-07-31', 2, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1139, '2023-07-31', 1, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1140, '2023-07-31', 3, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1141, '2023-07-31', 2, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1142, '2023-07-31', 4, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1143, '2023-07-31', 5, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1144, '2023-07-31', 6, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1145, '2023-07-31', 7, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1146, '2023-07-31', 10, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1147, '2023-07-31', 11, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1183, '2023-08-04', 124, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1184, '2023-08-04', 125, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1188, '2023-08-04', 129, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1190, '2023-08-04', 131, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1191, '2023-08-04', 132, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1196, '2023-08-04', 137, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1201, '2023-08-04', 142, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1205, '2023-08-04', 146, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1208, '2023-08-04', 149, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1213, '2023-08-04', 154, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1214, '2023-08-04', 155, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1215, '2023-08-04', 156, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1216, '2023-08-04', 157, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1222, '2023-08-04', 161, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1223, '2023-08-04', 162, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1224, '2023-08-04', 163, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1233, '2023-08-04', 81, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1236, '2023-08-04', 84, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1238, '2023-08-04', 86, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1248, '2023-08-04', 96, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1249, '2023-08-04', 97, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1251, '2023-08-04', 99, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1253, '2023-08-04', 164, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1259, '2023-08-04', 170, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1263, '2023-08-04', 174, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1268, '2023-08-04', 179, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1277, '2023-08-04', 188, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1279, '2023-08-04', 190, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1286, '2023-08-04', 197, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1287, '2023-08-04', 198, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1293, '2023-08-04', 204, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1299, '2023-08-04', 105, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1303, '2023-08-04', 109, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1304, '2023-08-04', 110, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1305, '2023-08-04', 111, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1306, '2023-08-04', 112, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1307, '2023-08-04', 113, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1308, '2023-08-04', 114, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1309, '2023-08-04', 115, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1310, '2023-08-04', 116, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1311, '2023-08-04', 117, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1312, '2023-08-04', 118, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1313, '2023-08-04', 119, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1314, '2023-08-04', 120, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1315, '2023-08-04', 206, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1317, '2023-08-04', 208, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1326, '2023-08-04', 217, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1334, '2023-08-04', 225, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1338, '2023-08-04', 229, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1339, '2023-08-04', 230, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1346, '2023-08-07', 56, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1350, '2023-08-07', 60, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1357, '2023-08-07', 87, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1360, '2023-08-07', 90, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1362, '2023-08-07', 92, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1363, '2023-08-07', 93, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1366, '2023-08-07', 96, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1367, '2023-08-07', 97, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1369, '2023-08-07', 99, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1371, '2023-08-07', 101, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1374, '2023-08-07', 104, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1376, '2023-08-07', 106, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1382, '2023-08-07', 112, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1385, '2023-08-07', 115, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1386, '2023-08-07', 116, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1392, '2023-08-07', 122, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1393, '2023-08-07', 123, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1400, '2023-08-07', 130, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1401, '2023-08-07', 131, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1402, '2023-08-07', 132, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1404, '2023-08-07', 134, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1406, '2023-08-07', 136, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1408, '2023-08-07', 138, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1414, '2023-08-07', 144, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1423, '2023-08-07', 68, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1428, '2023-08-07', 73, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1432, '2023-08-07', 77, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1433, '2023-08-07', 78, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1435, '2023-08-07', 80, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1436, '2023-08-07', 81, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1444, '2023-08-07', 89, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1445, '2023-08-07', 90, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1449, '2023-08-07', 94, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1450, '2023-08-07', 95, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1453, '2023-08-07', 98, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1455, '2023-08-07', 100, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1458, '2023-08-07', 103, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1463, '2023-08-07', 152, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1464, '2023-08-07', 153, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1465, '2023-08-07', 154, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1468, '2023-08-07', 157, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1469, '2023-08-07', 158, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1472, '2023-08-07', 161, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1473, '2023-08-07', 162, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1474, '2023-08-07', 163, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1478, '2023-08-07', 167, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1481, '2023-08-07', 170, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1488, '2023-08-07', 177, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1498, '2023-08-07', 187, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1499, '2023-08-07', 188, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1501, '2023-08-07', 190, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1502, '2023-08-07', 191, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1503, '2023-08-07', 192, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1504, '2023-08-07', 193, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1506, '2023-08-07', 107, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1508, '2023-08-07', 109, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1516, '2023-08-07', 117, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1517, '2023-08-07', 118, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1518, '2023-08-07', 119, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1519, '2023-08-07', 120, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1523, '2023-08-07', 198, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1524, '2023-08-07', 199, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1530, '2023-08-07', 205, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1531, '2023-08-07', 206, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1539, '2023-08-07', 214, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1540, '2023-08-07', 215, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1541, '2023-08-08', 1, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1548, '2023-08-08', 8, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1549, '2023-08-08', 9, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1551, '2023-08-08', 11, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1563, '2023-08-08', 3, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1574, '2023-08-08', 14, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1581, '2023-08-08', 21, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1585, '2023-08-08', 25, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1587, '2023-08-08', 27, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1588, '2023-08-08', 28, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1593, '2023-08-08', 33, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1602, '2023-08-08', 42, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1603, '2023-08-08', 43, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1607, '2023-08-08', 47, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1608, '2023-08-08', 48, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1609, '2023-08-08', 49, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1610, '2023-08-08', 50, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1612, '2023-08-08', 22, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1613, '2023-08-08', 23, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1618, '2023-08-08', 28, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1619, '2023-08-08', 29, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1624, '2023-08-08', 34, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1625, '2023-08-08', 35, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1627, '2023-08-08', 37, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1628, '2023-08-08', 38, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1630, '2023-08-08', 40, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1631, '2023-08-08', 41, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1632, '2023-08-08', 42, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1633, '2023-08-08', 43, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1634, '2023-08-08', 44, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1635, '2023-08-08', 45, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1636, '2023-08-08', 46, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1637, '2023-08-08', 47, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1638, '2023-08-08', 48, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1639, '2023-08-08', 49, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1640, '2023-08-08', 50, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1641, '2023-08-08', 51, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1643, '2023-08-08', 53, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1645, '2023-08-08', 55, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1647, '2023-08-08', 57, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1648, '2023-08-08', 58, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1649, '2023-08-08', 59, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1650, '2023-08-08', 60, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1651, '2023-08-08', 61, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1652, '2023-08-08', 62, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1653, '2023-08-08', 63, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1654, '2023-08-08', 64, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1655, '2023-08-08', 65, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1656, '2023-08-08', 66, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1657, '2023-08-08', 67, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1658, '2023-08-08', 68, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1659, '2023-08-08', 69, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1660, '2023-08-08', 70, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1661, '2023-08-08', 71, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1662, '2023-08-08', 72, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1663, '2023-08-08', 73, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1664, '2023-08-08', 74, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1665, '2023-08-08', 75, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1666, '2023-08-08', 76, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1667, '2023-08-08', 77, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1668, '2023-08-08', 78, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1669, '2023-08-08', 79, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1670, '2023-08-08', 80, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1671, '2023-08-08', 81, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1672, '2023-08-08', 82, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1673, '2023-08-08', 83, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1674, '2023-08-08', 84, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1675, '2023-08-08', 85, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1676, '2023-08-08', 86, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1677, '2023-08-08', 87, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1678, '2023-08-08', 88, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1679, '2023-08-08', 89, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1680, '2023-08-08', 90, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1681, '2023-08-08', 91, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1682, '2023-08-08', 92, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1683, '2023-08-08', 93, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1684, '2023-08-08', 94, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1685, '2023-08-08', 95, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1686, '2023-08-08', 96, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1687, '2023-08-08', 97, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1688, '2023-08-08', 98, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1689, '2023-08-08', 99, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1690, '2023-08-08', 100, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1691, '2023-08-08', 101, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1692, '2023-08-08', 102, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1693, '2023-08-08', 103, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1694, '2023-08-08', 104, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1695, '2023-08-08', 105, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1696, '2023-08-08', 106, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1697, '2023-08-08', 107, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1698, '2023-08-08', 108, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1699, '2023-08-08', 109, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1700, '2023-08-08', 110, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1703, '2023-08-08', 53, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1705, '2023-08-08', 55, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1706, '2023-08-08', 56, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1707, '2023-08-08', 57, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1708, '2023-08-08', 58, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1709, '2023-08-08', 59, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1710, '2023-08-08', 60, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1711, '2023-08-08', 61, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1712, '2023-08-08', 62, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1713, '2023-08-08', 63, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1714, '2023-08-08', 64, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1715, '2023-08-08', 65, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1716, '2023-08-08', 66, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1717, '2023-08-08', 67, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1718, '2023-08-08', 68, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1719, '2023-08-08', 69, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1720, '2023-08-08', 70, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1721, '2023-08-08', 71, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1722, '2023-08-08', 72, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1723, '2023-08-08', 73, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1724, '2023-08-08', 74, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1725, '2023-08-08', 75, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1726, '2023-08-08', 76, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1727, '2023-08-08', 77, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1728, '2023-08-08', 78, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1729, '2023-08-08', 79, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1730, '2023-08-08', 80, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1731, '2023-08-08', 81, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1732, '2023-08-08', 82, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1733, '2023-08-08', 83, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1734, '2023-08-08', 84, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1735, '2023-08-08', 85, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1736, '2023-08-08', 86, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1737, '2023-08-08', 87, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1738, '2023-08-08', 88, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1739, '2023-08-08', 89, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1740, '2023-08-08', 90, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1741, '2023-08-08', 91, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1742, '2023-08-08', 92, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1743, '2023-08-08', 93, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1744, '2023-08-08', 94, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1745, '2023-08-08', 95, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1746, '2023-08-08', 96, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1747, '2023-08-08', 97, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1748, '2023-08-08', 98, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1749, '2023-08-08', 99, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1750, '2023-08-08', 100, 'PRIORITY LANE', 'Senior Citizen', 'None');
INSERT INTO `number_db` VALUES (1751, '2023-08-08', 111, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1752, '2023-08-08', 112, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1753, '2023-08-08', 113, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1754, '2023-08-08', 114, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1755, '2023-08-08', 115, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1756, '2023-08-08', 116, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1757, '2023-08-08', 117, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1758, '2023-08-08', 118, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1759, '2023-08-08', 119, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1760, '2023-08-08', 120, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1761, '2023-08-08', 121, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1762, '2023-08-08', 122, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1763, '2023-08-08', 123, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1764, '2023-08-08', 124, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1765, '2023-08-08', 125, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1766, '2023-08-08', 126, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1767, '2023-08-08', 127, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1768, '2023-08-08', 128, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1769, '2023-08-08', 129, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1770, '2023-08-08', 130, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1771, '2023-08-08', 131, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1772, '2023-08-08', 132, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1773, '2023-08-08', 133, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1774, '2023-08-08', 134, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1775, '2023-08-08', 135, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1776, '2023-08-08', 136, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1777, '2023-08-08', 137, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1778, '2023-08-08', 138, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1779, '2023-08-08', 139, 'REGULAR LANE', 'None', 'None');
INSERT INTO `number_db` VALUES (1780, '2023-08-08', 140, 'REGULAR LANE', 'None', 'None');

SET FOREIGN_KEY_CHECKS = 1;
