SELECT e.FirstName, e.LastName, d.Name, e.HireDate
	FROM Employees e
	RIGHT JOIN Departments d ON e.DepartmentID = d.DepartmentID
	WHERE (d.Name = 'Sales' OR d.Name = 'Finance') 
		AND e.HireDate BETWEEN '1994-12-31' AND '2006-01-01'