SELECT MIN(e.Salary) as MinSalary, e.JobTitle, d.Name FROM Employees e
	JOIN Departments d ON e.DepartmentID = d.DepartmentID
	GROUP BY e.JobTitle, e.Salary, d.Name
	ORDER BY MinSalary DESC
