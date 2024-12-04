--Write a query to display your birthday( day of week)

declare @dateofbirth 
DATE = '2000-05-13';  
select datename(weekday, @dateofbirth)
AS dayofweek;
 

--Write a query to display your age in days
 
declare @dob DATE = '2000-05-13';  
select DATEDIFF(DAY, @dob, GETDATE()) AS ageindays;

--Write a query to display all employees information those who joined before 5 years in the current month
select * from emp
 select * from Emp where Hiredate <=Dateadd(year,-5,getdate()) 
 and month(Hiredate)=month(getdate())


--Create table Employee with empno, ename, sal, doj columns or use and perform the following operations in a single transaction

create database Assessment2

create table Employee
(
empno int primary key,
ename varchar(30),
sal float,
doj date
)

--	a. First insert 3 rows 
Begin Transaction
insert into Employee (empno,ename,sal,doj) values
(1,'sai',2000,'01-02-2001'),
(2,'ram',3500,'04-06-2001'),
(3,'siva',4500,'01-04-2001')

select * from Employee

--	b. Update the second row sal with 15% increment  
update Employee 
set sal = sal*1.15
where empno = 2

--  c. Delete first row.
delete from Employee
where empno = 1

commit

-- 5.Calculate bonus
create function Calculate_Bonus (@deptno int, @sal float)
Returns float
as
Begin
    Declare @bonus float
    IF @deptno = 10
        SET @bonus = @sal * 0.15;
 
    ELSE IF @deptno = 20
        SET @bonus = @sal * 0.20;
 
    ELSE
        SET @bonus = @sal * 0.05;
 
    Return @bonus
End
Go
 
select dbo.Calculate_Bonus(30, 1000.00) as Bonus


 -- 6.. Create a procedure to update the salary of employee
 Create Proc Update_Salary
AS
Begin
    Update Emp
    Set Sal = Sal + 500
    Where Deptno=(select Deptno from DEPT where Dname='sales') and Sal<1500
End;
Go
exec Update_Salary;
  select *from Emp