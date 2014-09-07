CREATE DATABASE `laperla` /*!40100 DEFAULT CHARACTER SET utf8 */;

CREATE TABLE `district` (
  `DistrictId` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '自增主键',
  `Country` varchar(45) NOT NULL COMMENT '国家',
  `State` varchar(45) NOT NULL COMMENT '省',
  `City` varchar(45) NOT NULL COMMENT '城市',
  `DataChange_CreateTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '创建时间',
  `DataChange_LastTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '最后更新时间',
  PRIMARY KEY (`DistrictId`),
  KEY `Index_DataChange_LastTime` (`DataChange_LastTime`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='地区表';

CREATE TABLE `employee` (
  `EmployeeId` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '自增主键',
  `ChineseName` varchar(45) DEFAULT NULL COMMENT '中文名',
  `EnglishName` varchar(45) DEFAULT NULL COMMENT '英文名',
  `PositionId` bigint(20) NOT NULL COMMENT '职位Id',
  `ShopId` bigint(20) NOT NULL DEFAULT '0' COMMENT '店铺Id',
  `DataChange_CreateTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '创建时间',
  `DataChange_LastTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '最后更新时间',
  PRIMARY KEY (`EmployeeId`),
  KEY `Index_DataChange_LastTime` (`DataChange_LastTime`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='员工表';

CREATE TABLE `employeesale` (
  `EmployeeSaleId` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '自增主键',
  `EmployeeId` bigint(20) NOT NULL DEFAULT '0' COMMENT '员工Id',
  `ShopId` bigint(20) NOT NULL DEFAULT '0' COMMENT '店铺Id',
  `Week` int(11) NOT NULL DEFAULT '0' COMMENT '周序列',
  `SaleType` tinyint(4) NOT NULL DEFAULT '0' COMMENT '销售类型',
  `Sale` decimal(10,0) NOT NULL DEFAULT '0' COMMENT '销售额',
  `Days` int(11) NOT NULL DEFAULT '0' COMMENT '出勤天数',
  `DataChange_CreateTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '创建时间',
  `DataChange_LastTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '最后更新时间',
  PRIMARY KEY (`EmployeeSaleId`),
  KEY `Index_DataChange_LastTime` (`DataChange_LastTime`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='员工销售额表';

CREATE TABLE `rule` (
  `RuleId` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '自增主键',
  `PositionId` bigint(20) NOT NULL DEFAULT '0' COMMENT '职位Id',
  `ShopId` bigint(20) NOT NULL DEFAULT '0' COMMENT '店铺Id',
  `RuleType` tinyint(4) NOT NULL DEFAULT '0' COMMENT '规则类型',
  `RuleDescription` varchar(200) DEFAULT NULL COMMENT '规则描述',
  `Bonus` decimal(10,0) NOT NULL DEFAULT '0' COMMENT '提成金额',
  `DataChange_CreateTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '创建时间',
  `DataChange_LastTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '最后更新时间',
  PRIMARY KEY (`RuleId`),
  KEY `Index_DataChange_LastTime` (`DataChange_LastTime`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='提成规则表';

CREATE TABLE `shop` (
  `ShopId` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '自增主键',
  `ShopName` varchar(200) NOT NULL,
  `ShopType` tinyint(4) NOT NULL DEFAULT '0',
  `Target` decimal(10,0) NOT NULL DEFAULT '0' COMMENT '目标销售额',
  `ActualSalesWithTax` decimal(10,0) NOT NULL DEFAULT '0' COMMENT '实际销售额含税',
  `Tax` decimal(10,0) NOT NULL DEFAULT '0' COMMENT '税',
  `ActualSalesWithoutTax` decimal(10,0) NOT NULL DEFAULT '0' COMMENT '实际销售额不含税',
  `ShopPool` double NOT NULL DEFAULT '0' COMMENT '店铺集合比',
  `Month` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '生效月份',
  `DistrictId` bigint(20) NOT NULL DEFAULT '0' COMMENT '地区Id',
  `DataChange_CreateTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '创建时间',
  `DataChange_LastTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '最后更新时间',
  PRIMARY KEY (`ShopId`),
  KEY `Index_DataChange_LastTime` (`DataChange_LastTime`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='店铺表';
