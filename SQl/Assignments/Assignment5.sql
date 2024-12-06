Create Proc GeneratePaySlip
@EmployeeID int,
@Salary decimal(10, 2)
As
Begin
Declare
@HRA Decimal(10, 2),
@DA Decimal(10, 2),
@PF Decimal(10, 2),
@IT Decimal(10, 2),
@Deductions Decimal(10, 2),
@GrossSalary Decimal(10, 2),
@NetSalary Decimal(10, 2)
 
-- Calculate HRA, DA, PF, IT
Set @HRA = @Salary * 0.10
Set @DA = @Salary * 0.20
Set @PF = @Salary * 0.08
Set @IT = @Salary * 0.05
 
-- Calculate Deductions
Set @Deductions = @PF + @IT
 
-- Calculate Gross Salary
Set @GrossSalary = @Salary + @HRA + @DA
 
-- Calculate Net Salary
Set @NetSalary = @GrossSalary - @Deductions
 
-- Print Payslip
PRINT 'Payslip for Employee ID: ' + CONVERT(VARCHAR, @EmployeeID)
PRINT '--------'
PRINT 'Salary: ' + CONVERT(VARCHAR, @Salary)
PRINT 'HRA (10%): ' + CONVERT(VARCHAR, @HRA)
PRINT 'DA (20%): ' + CONVERT(VARCHAR, @DA)
PRINT 'PF (8%): ' + CONVERT(VARCHAR, @PF)
PRINT 'IT (5%): ' + CONVERT(VARCHAR, @IT)
PRINT 'Deductions: ' + CONVERT(VARCHAR, @Deductions)
PRINT 'Gross Salary: ' + CONVERT(VARCHAR, @GrossSalary)
PRINT 'Net Salary: ' + CONVERT(VARCHAR, @NetSalary)
End
Go
 
Exec GeneratePayslip @EmployeeID = 3, @Salary = 70000.00
 
 ---2.HOLIDAYS TABLE
 
 CREATE TABLE Holidays ( 
Holidaydate DATE PRIMARY KEY,
Holidayname VARCHAR(20) NOT NULL
);

INSERT INTO Holidays (Holidaydate, Holidayname) VALUES
('2024-01-26', 'Republic Day'),
('2024-03-29', 'Holi'),
('2024-08-15', 'Independence Day'),
('2024-11-12', 'Diwali');
 insert into holidays values('2024-12-06','Holiday');
CREATE or alter TRIGGER RestrictManipulationOnHolidays
ON Emp
for insert,update,delete
as
Begin
Declare @holidayname VARCHAR(20);
	declare @currentdate date = cast(getdate() as date)
Select @holidayname = holidayname
From Holidays
Where holidaydate = @currentdate;
If @holidayname IS NOT NULL
	begin
raiserror('Data manipulation is restricted due to %s',16,1, @holidayname)
		rollback transaction
END
END
update Emp set ename='SMITH' where EmpNo=7369
select * from emp
 