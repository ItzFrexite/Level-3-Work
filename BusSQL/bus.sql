DROP DATABASE IF EXISTS bus;
CREATE DATABASE bus;
USE bus;

CREATE TABLE tbl_employee (
   employee_id VARCHAR (50) PRIMARY KEY NOT NULL,                                                                          	  
   title VARCHAR(5) NOT NULL,
   first_name VARCHAR(20) NOT NULL,
   last_name VARCHAR(20) NOT NULL,
   dob DATE NOT NULL,
   house_number VARCHAR(20) NOT NULL,
   town VARCHAR (50) NOT NULL,
   postcode VARCHAR (8) NOT NULL,
   street_name VARCHAR (50) NOT NULL,
   telephone VARCHAR (11) NOT NULL,
   country VARCHAR (10) NOT NULL,
   gender VARCHAR (10) NOT NULL,
   job_title  VARCHAR (20) NOT NULL,
   national_insurance_number VARCHAR (20) NOT NULL, 
   email_address VARCHAR (20),
   date_of_employment DATE NOT NULL
)engine=innodb;


INSERT INTO tbl_employee VALUES ('NR1538','Mr','Nigel','Roberts','1975-04-26','1','Walsall','WS11PM','Mock Road','07725489212','UK','Male','Driver','QQ123456A','Nigel@btinternet.com','2015-03-05');
INSERT INTO tbl_employee VALUES ('CP4434','Mr','Chris','Perry','1972-01-05','187','Birmingham','B36OUI','Cole Avenue','07829192513','UK','Male','Driver','FF12476A','chrisperry@hotmail.com','2013-05-05');
INSERT INTO tbl_employee VALUES ('JW9989','Ms','Jenny','Ward','1979-08-07','276','Walsall','WS11TY','Lancaster Way','07725489212','UK','Female','Driver','Xk153456C','Wardy@gmail.com','2015-01-28');
INSERT INTO tbl_employee VALUES ('SS129T','Miss','Sandeep','Singh','1981-11-05','8','Birmingham','B461TR','Rover Drive','07715419999','UK','Female','Driver','LN872456L','SSingh@outlook.com','2012-07-21');
INSERT INTO tbl_employee VALUES ('JE1221','Mr','Jacob','Edwards','1980-04-22','233','Walsall','WS17UY','Pool Street','01922458745','UK','Male','Driver','JK3748265V','Jacob@hotmail.com','2011-06-23');
INSERT INTO tbl_employee VALUES ('MG6730','Mr','Matthew','Crosby','1999-01-28','91','Walsall','WS99LW','Beechtree Road','01543829474','UK','Male','Driver','GHE534632','MattCrosby@hotmail.com','2015-02-14');

CREATE TABLE tbl_bus_driver (
       driver_id VARCHAR (50) PRIMARY KEY NOT NULL,                                                                  
	   licence_number VARCHAR (20) NOT NULL,
       expiry_date DATE NOT NULL,
       acquired_date DATE NOT NULL,
	   penalty_point INT NOT NULL, 
	   FOREIGN KEY (driver_id) REFERENCES tbl_employee(employee_id)ON DELETE CASCADE
 )engine=innodb;

 
INSERT INTO tbl_bus_driver VALUES ('NR1538','JH3454555','2025-05-01','1995-05-01','0');
INSERT INTO tbl_bus_driver VALUES ('CP4434','HG676765','2031-08-01','1981-08-01','0');
INSERT INTO tbl_bus_driver VALUES ('JW9989','KL867656','2045-03-01','1995-03-01','3');
INSERT INTO tbl_bus_driver VALUES ('SS129T','TY4355510','2051-01-01','2001-01-01','6');
INSERT INTO tbl_bus_driver VALUES ('JE1221','OI5676900','2019-07-01','1969-07-01','0');

SELECT*FROM tbl_employee;
SELECT*FROM tbl_bus_driver;
SELECT*FROM tbl_employee INNER JOIN tbl_bus_driver ON driver_id = employee_id;

CREATE TABLE tbl_bus (
       bus_registration VARCHAR (10) PRIMARY KEY NOT NULL,
	   manufacture VARCHAR (50) NOT NULL, 
	   model VARCHAR (50) NOT NULL,
	   facilities VARCHAR (50) NOT NULL 
 )engine=innodb;


INSERT INTO tbl_bus VALUES ( 'S337 DJW','AEC','2003','47 seats');
INSERT INTO tbl_bus VALUES ( 'G77D JDW','Leyland','2002','47 seats + Disabled access');
INSERT INTO tbl_bus VALUES ( 'H977 OTR','ACMAT','2003','50 seats + Disabled access');
INSERT INTO tbl_bus VALUES ( 'Y150 NVB','Guy','2005','40 seats');
INSERT INTO tbl_bus VALUES ( 'F634 GTS','Midland','2015','40 seats + Disabled access');
INSERT INTO tbl_bus VALUES ( 'G846 FTS','IBC','2014','47 seats + Two fire doors');
 
 
 CREATE TABLE tbl_route(
     route_number VARCHAR (4) PRIMARY KEY NOT NULL, 
     route_name VARCHAR(50) NOT NULL,
     bus_stops TINYTEXT NOT NULL
 )engine=innodb;

INSERT INTO tbl_route VALUES ( '1','Old Birchills','The Drive, Abbey Drive, Abbey Square, The Glades, Red River Road, Roberts Road, Muirfield Close, Chandlers Keep, The Granary,  The Green, Wingate Road, Wisemore, Wolverhampton Road, Wolverhampton Road West');
INSERT INTO tbl_route VALUES ( '2','Walsall Road Via Bloxwich','Abingdon Road, Chapel Avenue, The Downs, The Grove, The Leasow, Mulberry Road, Myatt Way, Redbourn Road, Wolverhampton Street, Wolverson Road, Wood Common Grange, Chapel Drive, Mulberry Place, The Maltings, The Meadows, The Nook, Mouse Hill');
INSERT INTO tbl_route VALUES ( '19','Birmingham Road','Acacia Avenue, Chapel Avenue, Murdoch Way, Woodall Street, Wood Green, Reedswood Gardens, Reedswood Lane, The Cloisters, The Cutting, Wood Lane, Woodbridge Close, Achilles Close ');
INSERT INTO tbl_route VALUES ( '31','Alumwell Circular','Addenbrooke Street, The Butts, Ajax Street, The Bridge, The Orchard, Woodend Road, Woodhaven, The Chartway, Woodland Drive, Chapel Drive, Jesson Road, Jordan Way, Muxloe Close, The Berkshire, Chapel Square ');
INSERT INTO tbl_route VALUES ( '52A','Mosely Circular','Central Close, Central Drive, Remington Road, Reservoir Street, Telford Road, Tenbury Close, Woodruff Way, Wrekin View, Wrexham Avenue, Wych Elm Road, Wye Road');

 
 
CREATE TABLE tbl_timetable(
     employee_id_fk VARCHAR (50) NOT NULL,
     route_number_fk  VARCHAR(10) NOT NULL,
     bus_registration_fk VARCHAR (10) NOT NULL,
     departure_time  TIME NOT NULL, 
     day_of_departure VARCHAR(50) NOT NULL,
     FOREIGN KEY (employee_id_fk) REFERENCES tbl_bus_driver(driver_id) ON DELETE CASCADE,
     FOREIGN KEY (route_number_fk) REFERENCES tbl_route (route_number) ON DELETE CASCADE,
     FOREIGN KEY (bus_registration_fk) REFERENCES tbl_bus ( bus_registration )ON DELETE CASCADE
);    

INSERT INTO tbl_timetable VALUES ( 'NR1538','19','F634 GTS','16:20','Wednesday 25th April');
INSERT INTO tbl_timetable VALUES ( 'CP4434','31','Y150 NVB','12:30','Wednesday 25th April');
INSERT INTO tbl_timetable VALUES ( 'JW9989','1','S337 DJW','06:00','Wednesday 25th April');
INSERT INTO tbl_timetable VALUES ( 'SS129T','52A','F634 GTS','21:00','Wednesday 25th April');
INSERT INTO tbl_timetable VALUES ( 'JE1221','2','H977 OTR','05:45','Wednesday 25th April');

SELECT*FROM tbl_bus_driver;
SELECT*FROM tbl_route;
SELECT*FROM tbl_bus;
SELECT*FROM tbl_timetable;


SELECT * FROM tbl_timetable
INNER JOIN tbl_bus_driver ON employee_id_fk = driver_id
INNER JOIN tbl_route ON route_number_fk = route_number
INNER JOIN tbl_bus ON bus_registration_fk = bus_registration;







SELECT tbl_bus_driver.driver_id AS 'Bus Driver ID',tbl_employee.first_name AS'First Name',tbl_employee.last_name AS'Last Name',tbl_route.route_number AS'The Route Number',tbl_route.bus_stops AS 'Bus stops' ,tbl_bus.bus_registration AS'Bus Registration',tbl_timetable.day_of_departure AS 'Day of departure',tbl_timetable.departure_time  AS 'Departure Time'FROM tbl_timetable
INNER JOIN tbl_bus_driver ON employee_id_fk = driver_id
INNER JOIN tbl_route ON route_number_fk = route_number
INNER JOIN tbl_bus ON bus_registration_fk = bus_registration
INNER JOIN tbl_employee ON driver_id = employee_id;

SELECT * FROM tbl_route WHERE bus_stops LIKE '%Abbey Square%';
SELECT * FROM tbl_employee WHERE gender = 'Male';
SELECT * FROM tbl_bus_driver WHERE penalty_point BETWEEN 2 AND 6;
SELECT tbl_bus_driver.driver_id AS 'Bus Driver ID',tbl_employee.first_name AS'First Name',tbl_employee.last_name AS'Last Name',tbl_route.route_number AS'The Route Number',tbl_route.bus_stops AS 'Bus stops' ,tbl_bus.bus_registration AS'Bus Registration',tbl_timetable.day_of_departure AS 'Day of departure',tbl_timetable.departure_time  AS 'Departure Time'FROM tbl_timetable
INNER JOIN tbl_bus_driver ON employee_id_fk = driver_id
INNER JOIN tbl_route ON route_number_fk = route_number
INNER JOIN tbl_bus ON bus_registration_fk = bus_registration
INNER JOIN tbl_employee ON driver_id = employee_id WHERE bus_registration = 'F634 GTS' AND manufacture = 'Midland Red';
SELECT * FROM tbl_timetable WHERE day_of_departure = 'Wednesday 25th April';
/*  */

CREATE TABLE IF NOT EXISTS `tbl_audit` (
 `driver_id` VARCHAR (50)  NOT NULL,                                                                  
 `licence_number` VARCHAR (20) NOT NULL,
 `expiry_date` DATE NOT NULL,
 `acquired_date` DATE NOT NULL,
 `penalty_point` INT NOT NULL, 
 `Action_Performed` varchar(20) NOT NULL,
 `DatePerformed` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DELIMITER $$
USE `bus`$$
CREATE TRIGGER `after_insert`
AFTER INSERT ON `tbl_bus_driver` FOR EACH ROW
 BEGIN
 INSERT INTO tbl_audit (driver_id,licence_number,expiry_date, acquired_date,penalty_point,Action_Performed,DatePerformed)
 VALUES (NEW.driver_id, NEW.licence_number,NEW.expiry_date,NEW.acquired_date,NEW.penalty_point,'INSERT', NOW());
END
$$
DELIMITER ;



INSERT INTO tbl_bus_driver VALUES ('MG6730','GHE534632','2015-02-14','1999-01-28','0');
SELECT * FROM tbl_audit;





DELIMITER $$
USE `bus`$$
CREATE TRIGGER `after_delete`
AFTER DELETE ON `tbl_bus_driver` FOR EACH ROW
 BEGIN
 INSERT INTO tbl_audit (driver_id,licence_number,expiry_date, acquired_date,penalty_point,Action_Performed,DatePerformed)
 VALUES (OLD.driver_id, OLD.licence_number,OLD.expiry_date,OLD.acquired_date,OLD.penalty_point,'DELETE', NOW());
END
$$
DELIMITER ;

DELETE FROM tbl_bus_driver WHERE driver_id  = 'CP4434';
SELECT * FROM tbl_audit;


DELIMITER $$
USE `bus`$$
CREATE TRIGGER `after_update`
AFTER UPDATE ON `tbl_bus_driver` FOR EACH ROW
 BEGIN
 INSERT INTO tbl_audit (driver_id,licence_number,expiry_date, acquired_date,penalty_point,Action_Performed,DatePerformed)
 VALUES (OLD.driver_id, OLD.licence_number,OLD.expiry_date,OLD.acquired_date,OLD.penalty_point,'UPDATE', NOW());
END
$$
DELIMITER ;

UPDATE tbl_bus_driver
SET expiry_date='2045-05-01'
WHERE driver_id = 'SS129T';


SELECT * FROM tbl_audit;