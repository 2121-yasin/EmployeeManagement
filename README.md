# EmployeeManagement

1. mvc web api
2. entity framework

   CREATE DATABASE EmployeeManagementDB;
GO

USE EmployeeManagementDB;
GO

-- Create DepartmentMaster table
CREATE TABLE DepartmentMaster (
    DepartmentId INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(100) NOT NULL
);
GO

-- Create RoleMaster table
CREATE TABLE RoleMaster (
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(100) NOT NULL
);
GO

-- Create Employee table
CREATE TABLE Employee (
    EmployeeId INT PRIMARY KEY IDENTITY(1,1),
    EmployeeName NVARCHAR(100) NOT NULL,
    EmployeeCode NVARCHAR(50) NOT NULL,
    DepartmentId INT FOREIGN KEY REFERENCES DepartmentMaster(DepartmentId),
    RoleId INT FOREIGN KEY REFERENCES RoleMaster(RoleId)
);
GO

-- Create SalaryDetail table
CREATE TABLE SalaryDetail (
    SalaryDetailId INT PRIMARY KEY IDENTITY(1,1),
    Year INT NOT NULL,
    Amount DECIMAL(18, 2) NOT NULL,
    EmployeeId INT FOREIGN KEY REFERENCES Employee(EmployeeId)
);
GO

-- Insert sample departments
INSERT INTO DepartmentMaster (DepartmentName) VALUES ('HR'), ('Finance'), ('IT'), ('Sales');
GO

-- Insert sample roles
INSERT INTO RoleMaster (RoleName) VALUES ('Manager'), ('Developer'), ('Analyst'), ('Tester');
GO

-- Insert sample employees
INSERT INTO Employee (EmployeeName, EmployeeCode, DepartmentId, RoleId) VALUES 
('John Doe', 'E001', 1, 1),
('Jane Smith', 'E002', 2, 2),
('Emily Davis', 'E003', 3, 3),
('Michael Brown', 'E004', 4, 4);
GO

-- Insert sample salary details
INSERT INTO SalaryDetail (Year, Amount, EmployeeId) VALUES 
(2023, 60000, 1),
(2023, 55000, 2),
(2023, 70000, 3),
(2023, 50000, 4);
GO

or

create models, run ef commands for migrations
