SELECT  FirstName + ' ' + LastName AS FullName, Salary FROM Employees
WHERE Salary = (SELECT MIN(SALARY) FROM Employees)