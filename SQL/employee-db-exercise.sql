
create table Department (
	ID int NOT NULL,
	Name NVARCHAR(50) NOT NULL,
	Location NVARCHAR(50) NOT NULL,
	Primary Key(ID)
);

create table ExerciseEmployee (
	ID int NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL, 
	SSN INT NOT NULL, 
	DeptID INT NOT NULL FOREIGN KEY REFERENCES Department (ID),
	Primary Key (ID)
);

create table EmpDetails(
	ID int NOT NULL,
	EmployeeID INT NOT NULL FOREIGN KEY REFERENCES ExerciseEmployee (ID),
	Salary INT NOT NULL, 
	ADDRESS1 NVARCHAR(50) NOT NULL,
	ADDRESS2 NVARCHAR(50) NOT NULL, 
	CITY NVARCHAR(50) NOT NULL,
	STATE NVARCHAR(50) NOT NULL,
	COUNTRY NVARCHAR(50) NOT NULL,
);

--Inserting 3 values into Department
INSERT INTO Department (ID, Name, Location) 
	VALUES (1, 'Accounting' , 'Arlington');
INSERT INTO Department (ID, Name, Location) 
	VALUES (2, 'IT' , 'Houston');
INSERT INTO Department (ID, Name, Location) 
	VALUES (3, 'Sales' , 'Beaumont');

-- Inserting 3 values into Employee
INSERT INTO ExerciseEmployee (ID, FirstName, LastName, SSN, DeptID) 
	VALUES (1, 'Walter' , 'Schmitty', 12212123, 1);
INSERT INTO ExerciseEmployee (ID, FirstName, LastName, SSN, DeptID) 
	VALUES (2, 'Jose' , 'Farro', 32323123, 2);
INSERT INTO ExerciseEmployee (ID, FirstName, LastName, SSN, DeptID) 
	VALUES (3, 'Jean Luc' , 'Ponty', 420696660, 3);

-- Inserting 3 values into EmpDetails
INSERT INTO EmpDetails (ID, EmployeeID, Salary, ADDRESS1, ADDRESS2, CITY, STATE, COUNTRY)
	VALUES (1, 1, 55000 , '8485 Main St','3344 2nd Main St', 'Arlington', 'TX', 'USA');
INSERT INTO EmpDetails (ID, EmployeeID, Salary, ADDRESS1, ADDRESS2, CITY, STATE, COUNTRY)
	VALUES (2, 2, 55000 , '8486 Main St','3345 2nd Main St', 'Houston', 'TX', 'USA');
INSERT INTO EmpDetails (ID, EmployeeID, Salary, ADDRESS1, ADDRESS2, CITY, STATE, COUNTRY)
	VALUES (3, 3, 55000 , '123 Main St','321 2nd Main St', 'Beaumont', 'TX', 'USA');

-- Adding Employee Tina Smith
INSERT INTO ExerciseEmployee (ID, FirstName, LastName, SSN, DeptID) 
	VALUES (4, 'Tina' , 'Smith', 101191109, 1);
INSERT INTO EmpDetails (ID, EmployeeID, Salary, ADDRESS1, ADDRESS2, CITY, STATE, COUNTRY)
	VALUES (4, 4, 55000 , '666 Money St','1004 April St', 'Arlington', 'TX', 'USA');

-- Adding Department Marketing
INSERT INTO Department (ID, Name, Location) 
	VALUES (4, 'Marketing' , 'Dallas');

-- List all Employees in Marketing
select * from ExerciseEmployee where DeptID = 4;

--Report total salary of Markerting

--Report total employees by Department

--Increase salary of Tina Smith to $90,000
UPDATE EmpDetails
	SET Salary = 90000
	WHERE EmployeeID = 4;





