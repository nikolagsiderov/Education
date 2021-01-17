ALTER TABLE [dbo].[Employees] ALTER COLUMN [ManagerId] INT NULL;
ALTER TABLE [dbo].[Departments] ALTER COLUMN [ManagerId] INT NULL;

ALTER TABLE [dbo].[Departments]
DROP CONSTRAINT FK_Departments_Employees;

ALTER TABLE [dbo].[Employees]
DROP CONSTRAINT FK_Employees_Departments;

GO;

CREATE PROCEDURE usp_DeleteEmployeesFromDepartment(@departmentId INT) AS
BEGIN
DELETE FROM [dbo].[Employees] WHERE [dbo].[Employees].DepartmentID = @departmentId;
DELETE FROM [dbo].[Departments] WHERE [dbo].[Departments].DepartmentID = @departmentId;
END

GO;

EXEC usp_DeleteEmployeesFromDepartment @departmentId = 3;

ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT FK_Departments_Employees
FOREIGN KEY ([ManagerId]) REFERENCES [dbo].[Employees]([EmployeeID]);

ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT FK_Employees_Departments
FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Departments]([DepartmentID]);

SELECT * FROM [dbo].[Employees] WHERE DepartmentID = 3;