
Insert into EMP Values
(7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,NULL,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,NULL,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,NULL,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,NULL,20),
(7839,'KING','PRESIDENT',NULL,'17-NOV-81',5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,NULL,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,NULL,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,NULL,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10)

create table DEPT
(
DEPTNO int Primary Key,
DNAME VARCHAR(12),
LOC VARCHAR(10)
)

Insert into DEPT Values
(10,'ACCOUNTING','NEW YORK'), 
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')

create table EMP(empno int Primary Key, ename varchar(20), Job varchar(20), mgr_id int, hiredate Date, sal int, comm int, Deptno int Foreign Key References DEPT(DEPTNO));

select * from EMP
select * from DEPT

 --List all employees whose name begins with 'A'. 
select ename from EMP Where ename like 'A%'

--2 Select all those employees who don't have a manager.
select ename from EMP Where mgr_id is null

--3 List employee name, number and salary for those employees who earn in the range 1200 to 1400.
select ename,empno,sal
from EMP where sal between 1200 and 1400

--4 Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
select Sal,Sal*1.10 as 'pay_raise10%'
from EMP
where Deptno=(select Deptno from Dept where Dname='Research')
 
--5 Find the number of CLERKS employed. Give it a descriptive heading.
select count(*) as 'Clerks'              
from EMP
where job='Clerk'
 
--6 Find the average salary for each job type and the number of people employed in each job. 
select job,avg(sal) as Avg_Sal ,count(*) as Emp_Count   
from EMP
Group by job
 
--7 List the employees with the lowest and highest salary. 
select Ename from EMP
where  sal=(select MAX(sal) from EMP)
select Ename from EMP
where sal=(select MIN(sal) from EMP)
 
--8 List full details of departments that don't have any employees.
select *                               
from dept d Left join EMP e
on d.Deptno=e.Deptno
where e.Deptno IS NULL
 
--9 Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename,sal from emp                             
where job='Analyst' and sal>1200 and deptno=20
order by ename asc
 
--10 For each department, list its name and number together with the total salary paid to employees in that department.
select e.Ename,e.Deptno,sum(e1.Sal) as Total_sal  
from emp e join emp e1
on e.Deptno=e1.Deptno
group by e.ename,e.deptno,e.sal
 
--11 Find out salary of both MILLER and SMITH.
select ename,sal from emp                     
where ename in ('smith','miller')
 
--12  Find out the names of the employees whose name begin with ‘A’ or ‘M’.
select ename from EMP                        
where Ename like 'A%' or  Ename like 'M%'
 
--13 Compute yearly salary of SMITH. 
select ename,sal,sal*12 as Annual_sal   
from emp
where ename='Smith'
 
--14 List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select ename,sal from emp                   
where sal not between 1500 and 2850
 
--15 Find all managers who have more than 2 employees reporting to them.
select mgr_id,count(*) as Emp_Count          
from emp group by mgr_id
having  count(*)>2


