-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema weather_station_app_db
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema weather_station_app_db
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `weather_station_app_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `weather_station_app_db` ;

-- -----------------------------------------------------
-- Table `weather_station_app_db`.`roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`roles` (
  `RoleId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NULL DEFAULT NULL,
  `Code` VARCHAR(50) NULL DEFAULT NULL,
  `IsActive` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`RoleId`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`users` (
  `UserId` INT NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(70) NULL DEFAULT NULL,
  `LastName` VARCHAR(70) NULL DEFAULT NULL,
  `EmailId` VARCHAR(100) NULL DEFAULT NULL,
  `ContactNumber` VARCHAR(40) NULL DEFAULT NULL,
  `Password` VARCHAR(200) NULL DEFAULT NULL,
  `IsDefaultPassword` TINYINT NULL DEFAULT '1',
  `CreatedBy` INT NULL DEFAULT NULL,
  `CreatedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `ModifiedBy` INT NULL DEFAULT NULL,
  `ModifiedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `IsActive` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`UserId`),
  INDEX `IDX_Users_CreatedBy` (`CreatedBy` ASC) VISIBLE,
  INDEX `IDX_Users_ModifiedBy` (`ModifiedBy` ASC) VISIBLE,
  CONSTRAINT `FK_Users_CreatedBy`
    FOREIGN KEY (`CreatedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_Users_ModifiedBy`
    FOREIGN KEY (`ModifiedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`))
ENGINE = InnoDB
AUTO_INCREMENT = 47
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`sensortype`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`sensortype` (
  `SensorTypeId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) NULL DEFAULT NULL,
  `Code` VARCHAR(70) NULL DEFAULT NULL,
  `IsActive` TINYINT NULL DEFAULT '1',
  `Units` VARCHAR(10) NULL DEFAULT NULL,
  PRIMARY KEY (`SensorTypeId`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`weatherstation`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`weatherstation` (
  `WeatherStationId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) NULL DEFAULT NULL,
  `Code` VARCHAR(70) NULL DEFAULT NULL,
  `Location` VARCHAR(100) NULL DEFAULT NULL,
  `Token` VARCHAR(255) NULL DEFAULT NULL,
  `IsActive` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`WeatherStationId`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`sensorconfig`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`sensorconfig` (
  `SensorConfigId` INT NOT NULL AUTO_INCREMENT,
  `SensorTypeId` INT NULL DEFAULT NULL,
  `MaxThreshold` FLOAT NULL DEFAULT NULL,
  `MinThreshold` FLOAT NULL DEFAULT NULL,
  `WeatherStationId` INT NULL DEFAULT NULL,
  `UserId` INT NULL DEFAULT NULL,
  `CreatedBy` INT NULL DEFAULT NULL,
  `CreatedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `ModifiedBy` INT NULL DEFAULT NULL,
  `ModifiedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `IsActive` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`SensorConfigId`),
  INDEX `IDX_SensorConfig_SensorTypeId` (`SensorTypeId` ASC) VISIBLE,
  INDEX `IDX_SensorConfig_WeatherStationId` (`WeatherStationId` ASC) VISIBLE,
  INDEX `IDX_SensorConfig_UserId` (`UserId` ASC) VISIBLE,
  INDEX `IDX_SensorConfig_CreatedBy` (`CreatedBy` ASC) VISIBLE,
  INDEX `IDX_SensorConfig_ModifiedBy` (`ModifiedBy` ASC) VISIBLE,
  CONSTRAINT `FK_SensorConfig_CreatedBy`
    FOREIGN KEY (`CreatedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_SensorConfig_ModifiedBy`
    FOREIGN KEY (`ModifiedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_SensorConfig_SensorTypeId`
    FOREIGN KEY (`SensorTypeId`)
    REFERENCES `weather_station_app_db`.`sensortype` (`SensorTypeId`),
  CONSTRAINT `FK_SensorConfig_UserId`
    FOREIGN KEY (`UserId`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_SensorConfig_WeatherStationId`
    FOREIGN KEY (`WeatherStationId`)
    REFERENCES `weather_station_app_db`.`weatherstation` (`WeatherStationId`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`sensorreading`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`sensorreading` (
  `SensorReadingId` INT NOT NULL AUTO_INCREMENT,
  `WeatherStationId` INT NULL DEFAULT NULL,
  `Reading` FLOAT NULL DEFAULT NULL,
  `ReadingDateTime` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `IsActive` TINYINT NULL DEFAULT '1',
  `SensorTypeId` INT NULL DEFAULT NULL,
  PRIMARY KEY (`SensorReadingId`),
  INDEX `IDX_SensorReading_WeatherStationId` (`WeatherStationId` ASC) VISIBLE,
  INDEX `FK_SensorReading_SensorTypeId` (`SensorTypeId` ASC) VISIBLE,
  CONSTRAINT `FK_SensorReading_SensorTypeId`
    FOREIGN KEY (`SensorTypeId`)
    REFERENCES `weather_station_app_db`.`sensortype` (`SensorTypeId`),
  CONSTRAINT `FK_SensorReading_WeatherStationId`
    FOREIGN KEY (`WeatherStationId`)
    REFERENCES `weather_station_app_db`.`weatherstation` (`WeatherStationId`))
ENGINE = InnoDB
AUTO_INCREMENT = 3530
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`userrolemap`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`userrolemap` (
  `UserRoleMapId` INT NOT NULL AUTO_INCREMENT,
  `UserId` INT NULL DEFAULT NULL,
  `RoleId` INT NULL DEFAULT NULL,
  `CreatedBy` INT NULL DEFAULT NULL,
  `CreatedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `ModifiedBy` INT NULL DEFAULT NULL,
  `ModifiedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `IsActive` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`UserRoleMapId`),
  INDEX `IDX_UserRoleMap_UserId` (`UserId` ASC) VISIBLE,
  INDEX `IDX_UserRoleMap_RoleId` (`RoleId` ASC) VISIBLE,
  INDEX `IDX_UserRoleMap_CreatedBy` (`CreatedBy` ASC) VISIBLE,
  INDEX `IDX_UserRoleMap_ModifiedBy` (`ModifiedBy` ASC) VISIBLE,
  CONSTRAINT `FK_Roles_RoleID`
    FOREIGN KEY (`RoleId`)
    REFERENCES `weather_station_app_db`.`roles` (`RoleId`),
  CONSTRAINT `FK_UserRoleMap_CreatedBy`
    FOREIGN KEY (`CreatedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_UserRoleMap_ModifiedBy`
    FOREIGN KEY (`ModifiedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_Users_UserID`
    FOREIGN KEY (`UserId`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`))
ENGINE = InnoDB
AUTO_INCREMENT = 36
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`userweatherstationmap`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`userweatherstationmap` (
  `UserWeatherStationMapId` INT NOT NULL AUTO_INCREMENT,
  `UserId` INT NULL DEFAULT NULL,
  `WeatherStationId` INT NULL DEFAULT NULL,
  `CreatedBy` INT NULL DEFAULT NULL,
  `CreatedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `ModifiedBy` INT NULL DEFAULT NULL,
  `ModifiedDate` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `IsActive` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`UserWeatherStationMapId`),
  INDEX `IDX_UserWeatherStationMap_UserId` (`UserId` ASC) VISIBLE,
  INDEX `IDX_UserWeatherStationMap_CreatedBy` (`CreatedBy` ASC) VISIBLE,
  INDEX `IDX_UserWeatherStationMap_ModifiedBy` (`ModifiedBy` ASC) VISIBLE,
  INDEX `IDX_UserWeatherStationMap_WeatherStationId` (`WeatherStationId` ASC) VISIBLE,
  CONSTRAINT `FK_WeatherStationMap_CreatedBy`
    FOREIGN KEY (`CreatedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_WeatherStationMap_ModifiedBy`
    FOREIGN KEY (`ModifiedBy`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_WeatherStationMap_UserId`
    FOREIGN KEY (`UserId`)
    REFERENCES `weather_station_app_db`.`users` (`UserId`),
  CONSTRAINT `FK_WeatherStationMap_WeatherStationID`
    FOREIGN KEY (`WeatherStationId`)
    REFERENCES `weather_station_app_db`.`weatherstation` (`WeatherStationId`))
ENGINE = InnoDB
AUTO_INCREMENT = 62
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `weather_station_app_db`.`weatherstationsensormap`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `weather_station_app_db`.`weatherstationsensormap` (
  `WeatherStationSensorMapId` INT NOT NULL AUTO_INCREMENT,
  `SensorTypeId` INT NULL DEFAULT NULL,
  `WeatherStationId` INT NULL DEFAULT NULL,
  `IsActive` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`WeatherStationSensorMapId`),
  INDEX `IDX_WeatherStationSensorMap_WeatherStationID` (`WeatherStationId` ASC) VISIBLE,
  INDEX `IDX_WeatherStationSensorMap_SensorTypeId` (`SensorTypeId` ASC) VISIBLE,
  CONSTRAINT `FK_WeatherStationSensorMap_SesnorTypeId`
    FOREIGN KEY (`SensorTypeId`)
    REFERENCES `weather_station_app_db`.`sensortype` (`SensorTypeId`),
  CONSTRAINT `FK_WeatherStationSensorMap_WeatherStationId`
    FOREIGN KEY (`WeatherStationId`)
    REFERENCES `weather_station_app_db`.`weatherstation` (`WeatherStationId`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `weather_station_app_db` ;

-- -----------------------------------------------------
-- procedure uspRoles_GetAll
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspRoles_GetAll`(
)
BEGIN
	Select RoleId,Name,Code from Roles where IsActive = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspSensorReading_GetReadingByWeatherStationId
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspSensorReading_GetReadingByWeatherStationId`(p_WeatherStationId int,p_StartDate datetime,p_EndDate datetime)
BEGIN
	SELECT DATE(sr.ReadingDateTime) AS ReadingDay, sr.SensorTypeId, AVG(sr.Reading) AS Reading, st.Name AS SensorTypeName,ws.WeatherStationId
	FROM SensorReading sr
	JOIN SensorType st ON (sr.SensorTypeId = st.SensorTypeId AND st.IsActive = 1)
	JOIN WeatherStation ws ON (sr.WeatherStationId = ws.WeatherStationId AND ws.WeatherStationId = p_WeatherStationId)
    where sr.ReadingDateTime between p_StartDate and p_EndDate
	GROUP BY DATE(sr.ReadingDateTime), sr.SensorTypeId, st.Name,ws.WeatherStationId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspSensorReading_InsertSensorReading
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspSensorReading_InsertSensorReading`(IN p_WeatherStationId int,IN p_SensorTypeId int,IN p_Reading float,IN p_ReadingDateTime datetime)
BEGIN
	INSERT INTO SensorReading(WeatherStationId,SensorTypeId,Reading,ReadingDateTime)
    VALUES(p_WeatherStationId,p_SensorTypeId,p_Reading,p_ReadingDateTime);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspSensor_GetAllSensorTypes
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspSensor_GetAllSensorTypes`()
BEGIN
	SELECT SensorTypeId,Name,Code,Units from SensorType where IsActive = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspSensor_GetSensorByTypeIdAndWeatherStationId
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspSensor_GetSensorByTypeIdAndWeatherStationId`(IN p_SensorTypeId int,p_WeatherStationId int)
BEGIN
	SELECT st.SensorTypeId,st.Name,st.Code,sc.MaxThreshold,sc.MinThreshold,ws.WeatherStationId,sc.UserId,st.Units,ws.Code as WeatherStationCode,ws.Name as WeatherStationName
    FROM SensorType st
    join weatherstationsensormap wsm on (st.SensortypeId = wsm.SensorTypeId and st.SensorTypeId = p_SensorTypeId and st.IsActive = 1 and wsm.IsActive = 1)
    join weatherstation ws on(wsm.WeatherStationId = ws.WeatherStationId and ws.WeatherStationId = p_WeatherStationId and ws.IsActive = 1)
    join sensorconfig sc on(st.SensorTypeId = sc.SensorTypeId and sc.IsActive = 1 and sc.WeatherStationId = p_WeatherStationId);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspSensor_GetSensorDetailsById
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspSensor_GetSensorDetailsById`(p_SensorTypeId int,p_WeatherStationId int)
BEGIN
	SELECT st.SensorTypeId,st.Name,st.Code,sc.MaxThreshold,sc.MinThreshold,ws.WeatherStationId,sc.UserId,st.Units,ws.Code as WeatherStationCode,ws.Name as WeatherStationName
    FROM SensorType st
    join weatherstationsensormap wsm on (st.SensortypeId = wsm.SensorTypeId and st.SensorTypeId = p_SensorTypeId and st.IsActive = 1 and wsm.IsActive = 1)
    join weatherstation ws on(wsm.WeatherStationId = ws.WeatherStationId and ws.WeatherStationId = p_WeatherStationId and ws.IsActive = 1)
    join sensorconfig sc on(st.SensorTypeId = sc.SensorTypeId and sc.IsActive = 1 and sc.WeatherStationId = p_WeatherStationId);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspSensor_GetSensorsByWeatherStationId
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspSensor_GetSensorsByWeatherStationId`(IN p_WeatherStationId int
)
BEGIN
	SELECT st.SensorTypeId,sc.SensorConfigId,st.Name,st.Code,sc.MaxThreshold,sc.MinThreshold,ws.WeatherStationId,sc.UserId,st.Units,ws.Code as WeatherStationCode,ws.Name as WeatherStationName
    FROM SensorType st
    join weatherstationsensormap wsm on (st.SensortypeId = wsm.SensorTypeId and st.IsActive = 1 and wsm.IsActive = 1)
    join weatherstation ws on(wsm.WeatherStationId = ws.WeatherStationId and ws.WeatherStationId = p_WeatherStationId and ws.IsActive = 1)
    join sensorconfig sc on(st.SensorTypeId = sc.SensorTypeId and sc.IsActive = 1 and sc.WeatherStationId = p_WeatherStationId);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspSensor_UpdateSensorThresholds
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspSensor_UpdateSensorThresholds`(IN p_SensorConfigId int,IN p_WeatherStationId int,IN p_UserId int ,IN p_MaxThreshold float,IN p_MinThreshold float)
BEGIN
	Update SensorConfig set UserId = p_UserId,MaxThreshold = p_MaxThreshold,MinThreshold = p_MinThreshold,ModifiedBy = p_UserId,ModifiedDate = current_timestamp()
    where WeatherstationId = p_WeatherStationId and SensorConfigId = p_SensorConfigId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_ChangePassword
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_ChangePassword`(IN p_UserId int,IN p_Password varchar(200))
BEGIN
	Update Users set Password = p_Password where UserId = p_UserId and IsActive = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_CheckUserExistence
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_CheckUserExistence`(p_EmailId VARCHAR(100), p_WeatherStationId INT)
BEGIN
   SELECT
    CASE
        WHEN EXISTS (
            SELECT 1
            FROM UserWeatherStationMap uwsm
            WHERE uwsm.UserId = u.UserId AND uwsm.IsActive = 1
                AND uwsm.WeatherStationId = p_WeatherStationId
        ) THEN 1
        ELSE 0
    END AS Result
FROM Users u
WHERE u.EmailId = p_EmailId AND u.IsActive = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_CreateUser
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_CreateUser`(
p_FirstName varchar(100),p_LastName varchar(100),p_EmailId varchar(100),p_Password varchar(100),
p_ContactNumber varchar(100),p_RoleId int,p_WeatherStationId int,p_CreatedBy int
)
BEGIN
	
	DECLARE InsertedUserID int;
-- Check if the user already exists
    SET @UserId = (SELECT UserId FROM Users WHERE EmailId = p_EmailId AND IsActive = 1);
    
    IF (@UserId IS NOT NULL) THEN
        SET InsertedUserID = @UserId;
    ELSE
        -- Insert the new user into the Users table
        INSERT INTO Users (FirstName, LastName, EmailId, Password, ContactNumber, CreatedBy, ModifiedBy)
        VALUES (p_FirstName, p_LastName, p_EmailId, p_Password, p_ContactNumber, p_CreatedBy, p_CreatedBy);
    
        SET InsertedUserID = LAST_INSERT_ID();
        
        -- Insert the user into the UserRoleMap table
        INSERT INTO UserRoleMap (UserId, RoleId, CreatedBy, ModifiedBy)
        VALUES (InsertedUserID, p_RoleId, p_CreatedBy, p_CreatedBy);
    END IF;
    
    -- Insert the user into the UserWeatherStationMap table
    INSERT INTO UserWeatherStationMap (UserId, WeatherStationId, CreatedBy, ModifiedBy)
    VALUES (InsertedUserID, p_WeatherStationId, p_CreatedBy, p_CreatedBy);
    
    SELECT InsertedUserID;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_DeleteUser
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_DeleteUser`(
p_UserId int,p_DeletedBy int
)
BEGIN
	Update Users set IsActive = 0,ModifiedBy = p_DeletedBy  where UserId = p_UserId;
	Update UserRoleMap set IsActive = 0,ModifiedBy = p_DeletedBy  where UserId = p_UserId;
	Update UserWeatherStationMap set IsActive = 0,ModifiedBy = p_DeletedBy  where UserId = p_UserId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_GetAllUsers
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_GetAllUsers`(
p_WeatherStationId int
)
BEGIN
		SELECT FirstName, LastName, EmailId, ContactNumber, IsDefaultPassword, Password,r.Name as RoleName,r.Code as RoleCode,u.IsActive,u.UserID,
    ws.Name as WeatherStationName,ws.WeatherStationId,ws.Location as WeatherStationLocation,ws.Code as WeatherStationCode
    FROM Users u
    join UserRoleMap urm on (u.UserID = urm.UserID and urm.IsActive = 1 and u.IsActive = 1)
    join Roles r on (urm.RoleId = r.RoleId and r.IsActive = 1)
    join userweatherstationmap wsum on (u.UserID = wsum.UserID and wsum.IsActive = 1)
    join WeatherStation ws on (wsum.WeatherStationId = ws.WeatherStationId and ws.IsActive = 1)
    where ws.WeatherStationId = p_WeatherStationId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_GetAllUsersNotInStation
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_GetAllUsersNotInStation`(IN p_WeatherStationId INT, IN p_Pattern VARCHAR(100))
BEGIN
SET @Pattern = CONCAT('%',p_Pattern,'%');

WITH ExistingUsers AS (
		SELECT UserId, WeatherStationId
		FROM UserWeatherStationMap
		WHERE WeatherStationId = p_WeatherStationId AND IsActive = 1
	)
	SELECT u.FirstName, u.LastName, u.EmailID, u.ContactNumber, u.UserID,r.Name as RoleName,r.RoleId
	FROM Users u
		JOIN UserRoleMap urm on (u.UserId = urm.UserId and urm.IsActive = 1)
        JOIN Roles r on (urm.Roleid = r.RoleId and r.IsActive = 1)
		LEFT JOIN ExistingUsers ex ON (u.UserID = ex.UserID)
	WHERE u.IsActive = 1 and ex.WeatherStationId IS NULL and (u.EmailID LIKE @Pattern OR u.FirstName LIKE @Pattern OR u.LastName LIKE @Pattern);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_GetUserByEmail
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_GetUserByEmail`(
IN p_EmailId VARCHAR(50)
)
BEGIN
	 SELECT FirstName, LastName, EmailId, ContactNumber, IsDefaultPassword, Password,r.Name as RoleName,r.Code as RoleCode,u.IsActive,u.UserID,
    ws.Name as WeatherStationName,ws.WeatherStationId,ws.Location as WeatherStationLocation,ws.Code as WeatherStationCode
    FROM Users u
    join UserRoleMap urm on (u.UserID = urm.UserID and urm.IsActive = 1 and u.IsActive = 1)
    join Roles r on (urm.RoleId = r.RoleId and r.IsActive = 1)
    join userweatherstationmap wsum on (u.UserID = wsum.UserID and wsum.IsActive = 1)
    join WeatherStation ws on (wsum.WeatherStationId = ws.WeatherStationId and ws.IsActive = 1)
    WHERE u.EmailId = p_EmailId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_GetUserById
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_GetUserById`(
p_UserId int
)
BEGIN
	SELECT FirstName, LastName, EmailId, ContactNumber, IsDefaultPassword, Password,r.Name as RoleName,r.Code as RoleCode,u.IsActive,u.UserID,
    ws.Name as WeatherStationName,ws.WeatherStationId,ws.Location as WeatherStationLocation,ws.Code as WeatherStationCode
    FROM Users u
    join UserRoleMap urm on (u.UserID = urm.UserID and urm.IsActive = 1 and u.IsActive = 1)
    join Roles r on (urm.RoleId = r.RoleId and r.IsActive = 1)
    join userweatherstationmap wsum on (u.UserID = wsum.UserID and wsum.IsActive = 1)
    join WeatherStation ws on (wsum.WeatherStationId = ws.WeatherStationId and ws.IsActive = 1)
    WHERE u.UserId = p_UserId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure uspUser_UpdateUser
-- -----------------------------------------------------

DELIMITER $$
USE `weather_station_app_db`$$
CREATE DEFINER=`weatherAdmin`@`%` PROCEDURE `uspUser_UpdateUser`(
p_FirstName varchar(100),p_LastName varchar(100),
p_ContactNumber varchar(100),p_UpdatedBy int,p_UserId int,p_RoleId int
)
BEGIN
	Update Users set FirstName = p_FirstName,LastName=p_LastName,ContactNumber = p_ContactNumber,ModifiedBy = p_UpdatedBy
	where UserId = p_UserId and IsActive = 1;
    
    Update UserRoleMap set RoleId = p_RoleId,ModifiedBy = p_UpdatedBy where UserId = p_UserId and IsActive = 1;
END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
