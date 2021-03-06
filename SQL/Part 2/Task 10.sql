SELECT d.Name AS Department, t.Name AS Town, COUNT(*) FROM Employees e
	JOIN Departments d ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID = t.TownID
	GROUP BY t.Name, d.Name