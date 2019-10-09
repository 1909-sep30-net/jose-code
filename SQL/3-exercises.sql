-- exercises

-- 1. insert two new records into the employee table.

	INSERT INTO Employee (EmployeeId, LastName, FirstName) Values
	(10, 'Farra', 'Josa'),
	(11,'Ponty','Jean Luc');

-- 2. insert two new records into the tracks table.

	INSERT INTO Track (TrackId, Name, AlbumId, MediaTypeId, GenreId, Composer, Milliseconds, Bytes, UnitPrice) Values
	(3504, '21st Century Schizoid Man', 344, 2, 1, 'King Crimson', 333202, 1110202,  420.00),
	(3505, 'Dont Let The World Pass You By', 345, 2,1, 'Jean Luc Ponty', 333020, 1110102, 420.00);

-- 3. update customer Aaron Mitchell's name to Robert Walter
	
	UPDATE Customer
	SET 
    FirstName = 'Robert',
	LastName = 'Walter'
	WHERE FirstName + LastName LIKE 'Robert Walter%'; -- without the WHERE, would update every row

-- 4. delete one of the employees you inserted.

	Delete from Employee 
	Where FirstName + LastName like 'JosaFarra';

-- 5. delete customer Robert Walter.

-- ON DELETE CASCADE on foreign keys and deleted Robert Walter to avoid dealing with redundant operations
-- https://stackoverflow.com/questions/6260688/how-do-i-use-cascade-delete-with-sql-server/6260736

	Delete from Customer 
	where FirstName + LastName like 'RobertWalter%';


