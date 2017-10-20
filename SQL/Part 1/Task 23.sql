SELECT e.firstName, e.LastName, (m.FirstName + ' ' + m.LastName) AS Manager
	FROM Employees m
	RIGHT JOIN Employees e ON m.EmployeeID = e.ManagerID