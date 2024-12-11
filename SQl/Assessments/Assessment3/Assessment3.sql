
---Create Table
create table Coursedetails
(
C_id Varchar(15)Not null,
C_name Varchar(25),
Start_date Date ,
End_date Date,
Fee int Not null
)

Insert into Coursedetails values
('DN003','DotNet','2018-02-01','2018-02-28',15000),
('DV004','DataVisualization','2018-03-01','2018-04-15',15000),
('JA002','AdvancedJava','2018-01-02','2018-01-20',10000),
('JC001','CoreJava','2018-01-02','2018-01-12',3000)

select * from Coursedetails

--Create the function

Create or alter function dbo.CalculateCourseDuration
(@Start_date date,@End_date date)
  returns int
  as
  begin
  declare @duration int
  set @duration = datediff(day,@Start_date,@End_date)
  return @duration
  end
  select dbo.CalculateCourseDuration (Start_date,End_date) Course_Duration
  from Coursedetails

  --Create Trigger

CREATE TABLE T_CourseInfo
(
C_Name Varchar(25),
Start_date DATE)
 

Create Trigger Insertcourseinfo ON Coursedetails

After Insert 
As
Begin
Insert INTO T_CourseInfo(C_Name, Start_date)

Select C_Name, Start_date FROM inserted 
End
 
Insert into Coursedetails values ('DN005','CSharp','2024-09-05','2024-09-28',11000)
SELECT * FROM T_CourseInfo
 

--stored procedure

create table ProductsDetails(ProductId int, ProductName varchar(30), Price Float, DiscountedPrice Float);
create procedure sp_productdetails
@ProductId int,
@ProductName varchar(30),
@Price Float,
@DiscountedPrice Float
as
Begin
 
insert into ProductsDetails(ProductId, ProductName, Price, DiscountedPrice) values(@ProductId, @ProductName, @Price, @DiscountedPrice);
 
end
go

select * from ProductsDetails;


