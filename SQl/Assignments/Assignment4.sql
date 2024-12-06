--1.Write a T-SQL Program to find the factorial of a given number.
Begin Transaction factorial;
Declare @num int, @number int = 5
set @num = @number - 1
while(@num > 0)
begin
set @number = @number * @num
set @num = @num - 1
end
print 'Factorial of given num :'+cast(@number as varchar)
commit transaction factorial;

--2.Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 
Create proc Multiplication(@number int)
As
Begin
Declare @i int = 1, @result int;
while(@i <= @number)
begin
set @result = @number * @i
print cast(@number as varchar)+'*'+cast(@i as varchar)+'='+cast(@result as varchar);
set @i = @i + 1
end
end
Exec Multiplication 5

--3. Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly.
Create table Student (
    Studentid int primary key,
    Sname varchar(50)
);
Insert into Student
values(1, 'Jack'),
(2, 'Rithvik'),
(3, 'Jaspreeth'),
(4, 'Praveen'),
(5, 'Bisa'),
(6, 'Suraj')

Create table Marks (
    Markid int primary key,
    Studentid int,
    Score int,
    foreign key (Studentid) references Student(Studentid)
);

Insert into Marks (Markid, Studentid, Score)
values 
(1, 1, 23),
(2, 6, 95),
(3, 4, 98),
(4, 2, 17),
(5, 3, 53),
(6, 5, 13);
 

create function Student_Status (@Score int)
returns varchar(10)
as
begin
declare @status varchar(10);
    if @Score >= 50
	return 'Pass';
    else 
	return 'Fail';
	return @status;
end;

select 
s.Studentid as Student_Id,
s.Sname as StudentName,
m.score as Score,
dbo.Student_Status(m.score) as Status
from Student s Left Join
Marks m on s.Studentid = m.Studentid
order by s.Studentid
