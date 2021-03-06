SELECT TOP 1 t.Name, COUNT(t.Name) as [Number of employees] FROM Towns t
	JOIN Addresses a ON t.TownID = a.TownID
	JOIN Employees e ON a.AddressID = e.AddressID
	GROUP BY t.Name
	ORDER BY [Number of employees] DESC