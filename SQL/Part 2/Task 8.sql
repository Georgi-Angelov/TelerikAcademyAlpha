SELECT COUNT(*) AS [Employees without managers] FROM Employees e
WHERE e.ManagerID IS NULL