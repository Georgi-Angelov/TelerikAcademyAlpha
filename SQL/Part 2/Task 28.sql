SELECT t.Name, COUNT(*) as [Number of managers] FROM Towns t
	JOIN Addresses a ON t.TownID = a.TownID
	JOIN Employees e ON a.AddressID = e.AddressID
	WHERE e.EmployeeID IN 
	(SELECT DISTINCT ManagerID FROM Employees)
	GROUP BY t.Name
	ORDER BY [Number of managers] DESC