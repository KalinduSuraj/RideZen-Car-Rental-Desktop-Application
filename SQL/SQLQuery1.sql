
-- Create Database
create database RideZenDB

--Create Admin Table
create table Addmin_Login(
	username varchar(20) not null primary key,
	Password varchar (20) not null
);

--Insert Admin
insert into Addmin_Login(username,Password) values('admin','1234');
--Check Admin Password
select * from Addmin_Login where username= 'admin'AND Password='1234';

select Password from Addmin_Login
select Password from Logins



--Create Logins Table
Create table Logins(
	UserID varchar(20) not null primary key,
	First_Name varchar(15) not null,
	Last_Name Varchar(15) not null,
	Password varchar(20) not Null
);

--Create Customer Table
create table Customer(
	NIC varchar(30) not null primary key,
	First_Name varchar(50) not null ,
	Last_Name varchar(50) not null,
	Contact varchar(20) not null
);

--Create Car Table
create table Car(
	Car_ID varchar(10) not null primary key check(Car_ID like 'Car%'),
	Model varchar(20) not null ,
	Car_Owner varchar(30) not null,
	Contact varchar(20) not null,
	Rental_Rate decimal(10,2) not null,
	Car_Image Image 
);

--Create Booking Table
create table Booking(
	Booking_ID varchar(10) not null primary key check(Booking_ID like 'B%'),
	No_Of_Days int not null,
	StartDate date not null,
	EndDate date not null,
	Payment decimal(10,2) not null,
	Date datetime Default Getdate(),
	Car_ID varchar(10) not null Foreign key references Car(Car_ID) check (Car_ID like 'Car%'),
	NIC varchar(30) not null Foreign key references Customer(NIC) 
);

--insert Data to Logins Table
insert into Logins(UserID,First_Name,Last_Name,Password) values('U01','Kalindu','Suraj','1111');

--Update Logins Data 
Update Logins SET First_Name = 'Suraj', Last_Name = 'Rasitha' , Password = '1111' WHERE UserID= 'U01' ;

--Delete User
DELETE FROM Logins WHERE UserID='@UserID';

--User Loging
select * from Logins where UserID= 'u01' AND Password='1111';

--Search User
SELECT UserID, First_Name From Logins  WHERE UserID='';

--Search Coustomer using NIC
select * from Customer where NIC= '2003' ;

--Count Bookings
SELECT COUNT(*) FROM Booking;


--Dashboard view --
CREATE VIEW DashboardView AS 
	select Booking.Booking_ID,Booking.EndDate,Car.Car_ID,Customer.NIC,Customer.First_Name,Customer.Contact	
	from Booking 
		inner join Customer on Booking.NIC = Customer.NIC
		inner join Car on Booking.Car_ID = Car.Car_ID

		where CONVERT(Date,Booking.StartDate) = CONVERT(Date, GETDATE());

		select * from DashboardView


--Cars--
Select * from Car;

--Booking--

select B.Booking_ID,B.StartDate,B.EndDate,B.Car_ID,B.NIC,B.Payment,B.Date from Booking B;

--Customer--
Select *from Customer;

--Payment--
Select B.Booking_ID,B.Date,B.Car_ID,B.NIC,B.Payment
From Booking B;