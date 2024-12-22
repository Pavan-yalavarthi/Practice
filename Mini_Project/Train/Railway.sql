use Handson

--Users
create table Users(
UserId int Identity Primary Key,
Username Varchar(30) Not Null Unique,
Password Varchar(30) Not Null)
--Alter table users add Role Varchar(20) NoT Null Default 'User'
select * from users
--Trains
create table Trains(
TrainId int Identity Primary Key,
TrainName Varchar(30) Not Null,
Source Varchar(30) Not Null,
Destination Varchar(30) Not Null,
FirstClass int Not Null,
SecondClass int Not Null,
SleeperClass int Not Null,
)
Alter table trains alter column Destination Varchar(30) Not null

--Bookings
create table Bookings(
BookingId int Identity Primary Key,
TrainId int Foreign Key References Trains(TrainId),
UserID INT Not Null Foreign key references Users(UserId),
--UserName varchar(25) Not Null,
--TrainName Varchar(30),
--Source Varchar(30),
--Destination Varchar(30),
BookingClass varchar(25) Check (BookingClass in ('FirstClass','SecondClass','SleeperClass')),
NumberOfSeats int Not Null,
BookingDate DateTime Default GetDate())
select * from bookings
select * from trains
--Add Train
create or alter procedure sp_AddTrain
@TrainId int,
 @TrainName Varchar(30),
 @Source Varchar(30),
 @Destination Varchar(30),
 @FirstClass int,
 @SecondClass int,
 @SleeperClass int
 As
 Begin
 Set Identity_Insert Trains on;
 Insert Into Trains (TrainId,TrainName,Source,Destination,FirstClass,SecondClass,SleeperClass)
 Values (@TrainId,@TrainName,@Source,@Destination,@FirstClass,@SecondClass,@SleeperClass)
 Set Identity_Insert Trains off;
 End


 --Show All Trains
 create or Alter proc sp_ShowTrains
 As 
 Begin
 Select * From Trains where IsActive != 0
 End

 --Book Ticket
 Create or Alter Proc sp_BookTicket
	@UserId int,
    @TrainID INT,
    @UserName Varchar(25),
    @BookingClass nVarchar(20),
    @NumberOfSeats INT
	--@BookingId int output
AS
BEGIN
    DECLARE @AvailableSeats INT;
 
    IF @BookingClass = 'FirstClass'
        SELECT @AvailableSeats = FirstClass FROM Trains WHERE TrainID = @TrainID --AND IsActive = 1;
 
    ELSE IF @BookingClass = 'SecondClass'
        SELECT @AvailableSeats = SecondClass FROM Trains WHERE TrainID = @TrainID-- AND IsActive = 1;
 
    ELSE IF @BookingClass = 'SleeperClass'
        SELECT @AvailableSeats = SleeperClass FROM Trains WHERE TrainID = @TrainID-- AND IsActive = 1;
 
    IF @AvailableSeats >= @NumberOfSeats
    BEGIN
        INSERT INTO Bookings (UserId,TrainID, BookingClass, NumberOfSeats)
        VALUES (@UserId,@TrainID,@BookingClass, @NumberOfSeats);
 
        IF @BookingClass = 'FirstClass'
            UPDATE Trains SET FirstClass = FirstClass - @NumberOfSeats WHERE TrainID = @TrainID;
 
        ELSE IF @BookingClass = 'SecondClass'
            UPDATE Trains SET SecondClass = SecondClass - @NumberOfSeats WHERE TrainID = @TrainID;
 
        ELSE IF @BookingClass = 'SleeperClass'
            UPDATE Trains SET SleeperClass = SleeperClass - @NumberOfSeats WHERE TrainID = @TrainID;
    END
    ELSE
        PRINT 'Not enough seats available!';
END

--Cancel tickets

Create or Alter Proc sp_CancelTicket
    @BookingID INT
AS
BEGIN
    DECLARE @TrainID INT, @BookingClass NVARCHAR(20), @NumberOfSeats INT;
 
    SELECT @TrainID = TrainID, @BookingClass = BookingClass, @NumberOfSeats = NumberOfSeats
    FROM Bookings
    WHERE BookingID = @BookingID --AND IsCancelled = 0;
 
    IF @BookingClass = 'FirstClass'
        UPDATE Trains SET FirstClass = FirstClass + @NumberOfSeats WHERE TrainID = @TrainID;
 
    ELSE IF @BookingClass = 'SecondClass'
        UPDATE Trains SET SecondClass = SecondClass + @NumberOfSeats WHERE TrainID = @TrainID;
 
    ELSE IF @BookingClass = 'SleeperClass'
        UPDATE Trains SET SleeperClass = SleeperClass + @NumberOfSeats WHERE TrainID = @TrainID;
 
    --UPDATE Bookings SET IsCancelled = 1 WHERE BookingID = @BookingID;
	Delete from Bookings where Bookingid = @BookingId
	print 'Ticket cancelled Successfully'
END

--View Bookings
create or Alter proc sp_ViewBookings
@BookingId int
As
Begin
select BookingId,TrainId,UserID,BookingClass,NumberOfSeats,BookingDate from Bookings
where BookingId=@BookingId
End


--Modify Trains
Create or Alter proc sp_ModifyTrain
@TrainId int,
@TrainName Varchar(30),
@Source Varchar(30),
@Destination varchar(30),
@FirstClass int ,
@SecondClass int ,
@SleeperClass int 
As 
Begin
Update Trains
Set TrainName = @TrainName,
Source = @Source,
Destination = @Destination,
FirstClass = @FirstClass,
SecondClass = @SecondClass,
SleeperClass = @SleeperClass,
IsActive =1
Where TrainId = @TrainId
End

--Delete Trains
Create or Alter proc sp_DeleteTrain
@TrainId int
As
Begin
Update Trains 
Set IsActive = 0
Where TrainId = @TrainId
End
Select * from Trains
--Register User
Create or Alter Proc sp_Register
@Username varchar(30),
@Password Varchar(25) not null,
@Role Varchar(20) not null
As 
Begin
Insert into Users Values (@Username,@Password,@Role)
end

--User Login
create or alter proc sp_Login
@Username varchar(30),
@Password varchar(25)
As 
Begin
Select UserId,Role from users where Username = @Username and Password = @Password
End


select * from Trains
