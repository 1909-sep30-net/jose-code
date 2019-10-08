-- basics of SQL
-- Useful Shortcuts:
-- CTRL K CTRL U, CTRL K CTRL C

-- SQL all about making request to a database
-- SQL advantage is a very abstract languange, hiding all the nitty gritty operations that otherwise would seem complicated
-- SQL is declarative ->  We say what we want and let the software deal with it.

-- Categories for SQL queries:
-- DML -> Data Manipulation Language (Operations on individual rows)
--	      - SELECT -> Read access, you select a particular spot in order to perform modifications
-- Only highlighted lines will run if you do so before running the execute button.
-- SQL contains explicit and implict conversion too.


-- Select in this scenario only returns 1.
select 1;
select 1; 

-- Single quotes for String
select 2 + 3;
select 'str1' + ' ' + CONVERT(varchar, 2 + 3);


-- Ask for values you need, dont ask for everything every time to avoid losing time.
-- Displays all the values and all the rows in the Employee Table (* represents every column)
select *
FROM Employee;

-- Display First and Last names of all employees
select FirstName, LastName
from Employee;

-- Display all first names 5 letters long or shoater. Len(value)
select *
from Employee
where LEN(FirstName) <= 5;


select *
From employee
where FirstName = 'Steve' and LastName = 'Johnson';

-- Collations: Setting per-database where you set-up rules for formatting, comparisons, number format, etc.
-- Column aliases(as): [full name] results from query will be organized into a column named full name 
-- '' for values "" for identifiers (name of something)
select 
	FirstName + ' ' + LastName as [full name],
	len(FirstName + ' ' + LastName) as [length]
from employee;

-- DDL -> Data Definition Lnaguages (Operations on whole tables, table structure)
-- DCL -> Data Control Language (Database administration, allow users to have permisions)



