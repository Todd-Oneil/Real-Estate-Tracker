-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema property
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema property
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `property` DEFAULT CHARACTER SET utf8 ;
USE `property` ;

-- -----------------------------------------------------
-- Table `property`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `property`.`users` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(65) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `property`.`properties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `property`.`properties` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `city` VARCHAR(45) NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `asking_price` INT NOT NULL,
  `purchase_price` INT NOT NULL,
  `down_payment` DECIMAL(10,2) NOT NULL,
  `mortgage_rate` DECIMAL(4,2) NOT NULL,
  `mortgage_term` INT NOT NULL,
  `mortgage_payment` DECIMAL(7,2) NOT NULL,
  `total_monthly_rent` DECIMAL(6,2) NOT NULL,
  `monthly_condo_fees` DECIMAL(6,2) NULL DEFAULT NULL,
  `monthly_mgmt_fee` DECIMAL(5,2) NULL DEFAULT NULL,
  `monthly_utilities` DECIMAL(6,2) NULL DEFAULT NULL,
  `monthly_prop_tax` DECIMAL(6,2) NOT NULL,
  `monthly_profit_loss` DECIMAL(6,2) NULL DEFAULT NULL,
  `users_ID` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `fk_properties_users_idx` (`users_ID` ASC) VISIBLE,
  CONSTRAINT `fk_properties_users`
    FOREIGN KEY (`users_ID`)
    REFERENCES `property`.`users` (`ID`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8mb3;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
