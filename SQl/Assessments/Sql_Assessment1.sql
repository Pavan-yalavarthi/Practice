create table books 
( 
id  int primary key,
title varchar(20),
author varchar(20),
isbn varchar(20) unique not null,
published_date datetime)
 
insert into books values
(1,'My First SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My Third SQL book', 'Cary Flint',523120967812,'2015-10-18 14:05:44')

--To fetch
SELECT *
FROM books
WHERE Author LIKE '%er';


--Reviews Table
create table reviews
(
id int primary key,
book_id int ,
reviewer_name varchar(20),
content varchar(30),
rating int,
published_date datetime
Foreign key(book_id) references books(id))
 
insert into reviews(id,book_id, reviewer_name,content,rating,published_date)
values
(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','My second review',5,'2017-10-13 15:05:12'),
(3,2,'Alice Walker','Another review',1,'2017-10-22 23:47:10')

select title,author,reviewer_name
from books join reviews 
on 
books.id = reviews.book_id;

 
select reviewer_name,
COUNT(book_id) as Review_count
from reviews 
group by reviewer_name
having COUNT(book_id) > 1

--customer table
create table customer
(
  id int ,
  name varchar(20),
  age int,
  address varchar(20),
  salary float
)
insert into customer values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

select name 
from customer
where address like '%o%'
--Order table
create table orders
(
oid int,
date DateTime,
customer_id int,
amount int)

insert into orders values
(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060)

select date,count(*) as customer_count
from orders
group by date;

--Employee table
create table Employee
(
id int not null,
name varchar(20) not null,
age int not null,
addres varchar(20) not null,
salary int
)
insert into Employee values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

select lower(name) as 'Name' from Employee 
where Salary is null

--Student Table
create table student_details
(
register_no int primary key,
name varchar(25) not null,
age int not null,
qualification varchar(25),
mobile_no float not null,
mail_id varchar(25),
locationn varchar(25),
gender varchar(1)
)

insert into student_details values
(2,'Sai',22,'B.E',9952836779,'sai@gmail,com','Chennai','M'),
(3,'Kumar',20,'BSC',7252836779,'kumar@gmail,com','Madurai','M'),
(4,'Selvi',22,'B.TECH',8952836779,'selvi@gmail,com','Selam','F'),
(5,'Nisha',25,'M.E',6352836779,'nisha@gmail,com','Theni','F'),
(6,'SaiSaran',21,'B.A',9865836779,'saisaran@gmail,com','Madurai','F'),
(7,'Tom',23,'BCA',6552836779,'tom@gmail,com','Pune','M')

 select count(gender) as 'Genders' from student_details
 group by gender
 