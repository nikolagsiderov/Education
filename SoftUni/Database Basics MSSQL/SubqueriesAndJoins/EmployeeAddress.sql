SELECT TOP 5 Employees.EmployeeID, Employees.JobTitle, Addresses.AddressID, Addresses.AddressText
FROM Employees
INNER JOIN Addresses ON Employees.AddressID = Addresses.AddressID
ORDER BY AddressID ASC