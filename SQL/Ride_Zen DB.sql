----Create Ride_Zen Database--
Create database Ride_Zen


--Create Branch Table-------------------------
Create Table Branch(
	Branch_ID Varchar(10) Not Null Primary Key Check(Branch_ID Like 'B%'),
	Name varchar(100) Not Null,
	Location Varchar(100) Not Null
);

--Create Branch_Contact Table-------------------
Create Table Branch_Contact (
	Branch_ID Varchar(10) Not Null Foreign Key References Branch(Branch_ID) Check(Branch_ID Like 'B%'),
	Contact int not null Unique,
	Primary Key(Branch_ID,Contact)
);

--Create Category Table ------------------------
Create Table Category(
	Category_ID Varchar(10) Primary Key Not Null Check(Category_ID Like 'Cat%'),
	Name Varchar(50) Not Null,
	Description Varchar(500) Not Null
);

--Create Insurance_Plan Table ----------------------
Create Table Insurance_Plan(
	Insurance_ID Varchar(10) Not Null Primary Key Check(Insurance_ID Like 'I%'),
	Type Varchar(100) Not Null,
	Description Varchar(500) Not Null 
);

-- Create Car Table -------------------------------------
Create Table Car(
	Car_ID Varchar(10) Not Null Primary Key Check(Car_ID Like 'CAR%'),
	Model Varchar(50) Not Null,
	Rental_Rate Decimal(10,2) Not Null,
	Branch_ID Varchar(10) Not Null Foreign Key References Branch(Branch_ID) Check(Branch_ID Like 'B%'),
	Category_ID Varchar(10) Not Null Foreign Key References Category(Category_ID) Check(Category_ID Like 'Cat%'),
	Insurance_ID Varchar(10) Not Null Foreign Key References Insurance_Plan(Insurance_ID) Check(Insurance_ID Like 'I%')
);

--Create Driver Table ----------------------------------
Create Table Driver(
	Driver_ID Varchar(10) Not Null Primary Key Check(Driver_ID Like 'D%'),
	Name Varchar(100) Not Null,
	Contact Int Not Null
);

-- Create Customar Table ---------------------------------
Create Table Customer(
	Customer_ID Varchar(10) Not Null Primary Key Check(Customer_ID Like 'C%'),
	Name Varchar(100) Not Null,
	Contact int Not Null,
	NIC Varchar(12) Not Null Unique,
	Address Varchar(200) Not Null
);

--Create Reservation Table --------------------------------
Create Table Reservation(
	Reservation_Id Varchar(10) Not Null Primary Key Check(Reservation_ID Like 'R%'),
	Pickup_Date Date Not Null,
	Returan_Date Date Not Null,
	Rental_Amount Decimal(10,2) Not Null,
	Type Varchar(20) Not Null Check(Type IN('With Driver','Without Driver')),
	Driver_ID Varchar(10) Foreign Key References Driver(Driver_ID) Check(Driver_ID Like 'D%'),
	Customer_ID Varchar(10) Not Null Foreign Key References Customer(Customer_ID) Check(Customer_ID Like 'C%'),
	Car_ID Varchar(10) Not Null Foreign Key References Car(Car_ID) Check(Car_ID Like 'CAR%')
);

-- Create  Payment Table ----------------------------------
Create Table Payment(
	Payment_ID Varchar(10) Not Null Primary Key Check(Payment_ID Like 'P%'),
	Cost Decimal(10,2) Not Null Check(Cost > 1000),
	Type Varchar(20) Not Null Check(Type IN ('Full Payment','Down Payment')),
	Remaining_Amount Decimal(10,2) Not Null,
	Reservation_Id Varchar(10) Not Null Foreign Key References Reservation(Reservation_ID) Check(Reservation_ID Like 'R%'),
	Date Datetime Default Getdate()
);

--Create Damage_Report Table -------------------------------
Create Table Damage_Report(
	Report_ID Varchar(10) Not Null Primary Key Check(Report_ID Like 'DR%'),
	Date Date Not Null,
	Time Time Not Null,
	Description Varchar(500) Not Null,
	Car_ID Varchar(10) Not Null Foreign Key References Car(Car_ID) Check(Car_ID Like 'CAR%')
);

--Create Maintance_Log Table -------------------------------
Create Table Maintance_Log(
	Log_ID Varchar(10) Not Null Primary Key Check(Log_ID Like 'ML%'),
	Date Date Not Null,
	Time Time Not Null,
	Cost Decimal(12,2) Not Null,
	Description Varchar(500) Not Null,
	Report_ID Varchar(10) Not Null Foreign Key References Damage_Report(Report_ID) Check(Report_ID Like 'DR%')
);

---**********************************Insert Data*****************************************************************************************



-- Insert Data To Branch Table -----------------------------------
Insert into Branch(Branch_ID,Name,Location)
	Values	('B001','Colombo Central Branch','Colombo'),
			('B002','Kandy Main Branch','Kandy'),
			('B003','Galle South Branch','Galle'),
			('B004','Jaffna North Branch','Jaffna'),
			('B005','Mathara Coastal Branch','Mathara'),
			('B006','Negombo Beach Branch','Negombo'),
			('B007','Ella Hill Branch','Ella'),
			('B008','Trincomalee Port Branch','Trinkomalee'),
			('B009','Anuradhapura Ancient Branch','Anuradhapura'),
			('B010','Batticaloa East Branch','Batticaloa'),
			('B011','Polonnaruwa Heritage Branch','Polonnaruwa'),
			('B012','Kurunegala Western Branch','Kurunegala'),
			('B013','Hambantota Southern Branch','Hambantota'),
			('B014','Mannar Lagoon Branch','Mannar'),
			('B015','Rathnapura Main Branch','Rathnapura'),
			('B016','Kaluthara Coast Branch','Kaluthara'),
			('B017','Badulla Uva Branch','Badulla'),
			('B018','Ampara Beach Branch','Ampara'),
			('B019','Nuwara Eliya Hill Branch','Nuwara Eliya'),
			('B020','Vavuniya Northern Branch','Vavuniya') 
		;


-- Insert Data To Branch_Contact --------------------------------------
Insert Into Branch_Contact(Branch_ID,Contact)
	Values	('B001',0914025748),
			('B001',0774025749),
			('B002',0914596123),
			('B002',0774596124),
			('B003',0912581967),
			('B003',0772581968),
			('B004',0914578912),
			('B004',0774578913),
			('B005',0911231444),
			('B005',0771231444),
			('B006',0915555667),
			('B006',0775555668),
			('B007',0914545777),
			('B007',0774545778),
			('B008',0918833123),
			('B008',0778833124),
			('B009',0914564567),
			('B009',0774564568),
			('B010',0911111222),
			('B010',0771111223),
			('B011',0917821234),
			('B011',0777821235),
			('B012',0914874789),
			('B012',0774874788),
			('B013',0914564561),
			('B013',0774564561),
			('B014',0914217811),
			('B014',0774217822),
			('B015',0911281287),
			('B015',0771281288),
			('B016',0919191999),
			('B016',0779192000),
			('B017',0917777888),
			('B017',0777777889),
			('B018',0911567899),
			('B018',0771567900),
			('B019',0911591590),
			('B019',0771591591),
			('B020',0913573577),
			('B020',0773573588)
		;

-- Insert Data to Category Table ---------------------------------------
Insert Into Category(Category_ID,Name,Description)
	Values	('Cat001', 'Sedan', 'Sedans are passenger cars with a three-box configuration, comprising an engine, passenger, and cargo areas.'),
			('Cat002', 'SUV', 'Sport Utility Vehicles (SUVs) are versatile vehicles with off-road capabilities and ample space for passengers and cargo.'),
			('Cat003', 'Hatchback', 'Hatchbacks are compact cars with a rear door that swings upward, offering easy access to the cargo area.'),
			('Cat004', 'Convertible', 'Convertibles have a retractable roof, providing an open-air driving experience.'),
			('Cat005', 'Coupe', 'Coupes are two-door cars, often sporty in design, with a sloping rear roofline.'),
			('Cat006', 'Minivan', 'Minivans are family-oriented vehicles with ample space for passengers and cargo.'),
			('Cat007', 'Truck', 'Trucks are vehicles designed for hauling cargo and often have an open cargo area.'),
			('Cat008', 'Electric', 'Electric cars are powered by electric motors and batteries, reducing reliance on traditional fuel.'),
			('Cat009', 'Hybrid', 'Hybrid cars combine traditional combustion engines with electric motors for increased fuel efficiency.'),
			('Cat010', 'Luxury', 'Luxury cars offer high-end features, comfort, and superior performance.')
	;

-- Insert Data To Insurance_Plane Table -----------------------------------
Insert Into Insurance_Plan(Insurance_ID,Type,Description) 
	VALUES	('I001', 'Comprehensive Coverage', 'Covers damage to your car from incidents other than collisions.'),
			('I002', 'Liability Coverage', 'Covers damage to others’ property and medical expenses.'),
			('I003', 'Collision Coverage', 'Covers damage to your car caused by collisions with other vehicles or objects.'),
			('I004', 'Personal Injury Protection', 'Covers medical expenses for you and your passengers in case of an accident.')
			;

-- Insert Data to Car Table -------------------------------------------------
Insert into Car (Car_ID, Model, Rental_Rate, Branch_ID, Category_ID, Insurance_ID)
	Values	('CAR001', 'Toyota Camry', 1500.00, 'B001', 'Cat001', 'I001'),
			('CAR002', 'Ford Explorer', 2000.00, 'B001', 'Cat002', 'I001'),
			('CAR003', 'Volkswagen Golf', 4000.00, 'B002', 'Cat003', 'I003'),
			('CAR004', 'Mazda MX-5 Miata', 5000.00, 'B002', 'Cat004', 'I001'),
			('CAR005', 'Audi A5', 6800.00, 'B003', 'Cat005', 'I003'),
			('CAR006', 'Chrysler Pacifica', 3000.00, 'B004', 'Cat006', 'I004'),
			('CAR007', 'Ford F-150', 3000.00, 'B005', 'Cat007', 'I003'),
			('CAR008', 'Tesla Model S', 9000.00, 'B006', 'Cat008', 'I001'),
			('CAR009', 'Toyota Prius', 2000.00, 'B007', 'Cat009', 'I003'),
			('CAR010', 'Mercedes-Benz S-Class', 7000.00, 'B008', 'Cat010', 'I004'),
			('CAR012', 'Honda Accord', 4000.00, 'B009', 'Cat001', 'I003'),
			('CAR013', 'Jeep Grand', 2500.00, 'B010', 'Cat002', 'I004'),
			('CAR014', 'BMW 4 Sierra', 9500.00, 'B011', 'Cat003', 'I003'),
			('CAR015', 'Chevrolet Camaro', 4000.00, 'B012', 'Cat004', 'I004'),
			('CAR016', 'Kia Sedona', 2000.00, 'B013', 'Cat005', 'I001'),
			('CAR017', 'GMC Sierra', 5000.00, 'B014', 'Cat006', 'I003'),
			('CAR018', 'Nissan Leaf', 4000.00, 'B015', 'Cat007', 'I002'),
			('CAR019', 'Lexus ES Hybrid', 3000.00, 'B016', 'Cat008', 'I003'),
			('CAR020', 'Rolls-Royce Phantom', 1800.00, 'B017', 'Cat009', 'I004'),
			('CAR021', 'Nissan Altima', 4000.00, 'B018', 'Cat010', 'I003'),
			('CAR022', 'Subaru Outback', 4000.00, 'B019', 'Cat001', 'I001'),
			('CAR023', 'Mini Cooper', 4800.00, 'B020', 'Cat002', 'I003'),
			('CAR024', 'Porsche 911', 2800.00, 'B011', 'Cat003', 'I001'),
			('CAR025', 'Ford Mustang', 4000.00, 'B002', 'Cat003', 'I003'),
			('CAR026', 'Chrysler Voyager', 2000.00, 'B003', 'Cat004', 'I004'),
			('CAR027', 'Chevrolet Silver', 4000.00, 'B004', 'Cat005', 'I003'),
			('CAR028', 'Tesla Model X', 2600.00, 'B005', 'Cat004', 'I002'),
			('CAR029', 'Toyota Prius Prime', 6000.00, 'B006', 'Cat005', 'I003'),
			('CAR030', 'BMW 7 Series', 4000.00, 'B007', 'Cat006', 'I001')
		;

-- Insert Data to Driver Table ----------------------------------------------------------
Insert into Driver(Driver_ID, Name, Contact)
	Values	('D001', 'Kamal Perera',0711234567),
			('D002', 'Samantha Silva',0772345678),
			('D003', 'Nuwan Fernando',0763456789),
			('D004', 'Chathurika Rajapakse',0704567890),
			('D005', 'Ranil Jayawardena',0755678901),
			('D006', 'Malini de Silva',0786789012),
			('D007', 'Lakmal Gunasekara',0727890123),
			('D008', 'Tharindu Bandara',0798901234),
			('D009', 'Anusha Ratnayake',0769012345),
			('D010', 'Dilshan Perera',0701234567),
			('D011', 'Chamari Fernando',0712345678),
			('D012', 'Nishantha Silva',0773456789),
			('D013', 'Aruna Jayasuriya',0754567890),
			('D014', 'Madhavi de Mel',0784567891),
			('D015', 'Kasun Gunawardena',0726789012),
			('D016', 'Ishara Bandara',0777890123),
			('D017', 'Nimal Perera',0768901234),
			('D018', 'Chandani Fernando',0709012345),
			('D019', 'Roshan de Silva',0711234567),
			('D020', 'Sanduni Jayawardena',0772345678)
		;


-- Insert Data to Customer Table ---------------------------------------------------------
Insert into Customer (Customer_ID, Name, Contact, NIC, Address)
	Values	('C001', 'Aruna Perera',0711234567, '951234567V', '123 Main Street, Colombo'),
			('C002', 'Kamala Silva',0772345678, '871234567V', '456 Park Avenue, Kandy'),
			('C003', 'Nimal Rajapakse',0763456789, '921234567V', '789 Oak Lane, Galle'),
			('C004', 'Chathuri Gunaratne',0704567890, '841234567V', '101 Pine Road, Negombo'),
			('C005', 'Rajitha Fernando',0755670901, '781234567V', '202 Cedar Street, Jaffna'),
			('C006', 'Lakshmi de Silva',0786789012, '631234567V', '303 Elm Avenue, Matara'),
			('C007', 'Tharindu Bandara',0727890123, '541444567V', '404 Birch Lane, Trincomalee'),
			('C008', 'Anusha Ratnayake',0798901234, '471234567V', '505 Maple Road, Batticaloa'),
			('C009', 'Dilshan Perera',0769012345, '311234567V', '606 Pine Lane, Anuradhapura'),
			('C010', 'Chamari Fernando',0701234567, '291234567V', '707 Oak Street, Ratnapura'),
			('C011', 'Nishantha Silva',0712345678, '381234567V', '808 Cedar Avenue, Badulla'),
			('C012', 'Aruna Jayasuriya',0773456789, '261234567V', '909 Birch Road, Nuwara Eliya'),
			('C013', 'Madhavi de Mel',0754557890, '181234567V', '1010 Pine Lane, Polonnaruwa'),
			('C014', 'Kasun Gunawardena',0785678901, '925234567V', '1111 Elm Street, Kalutara'),
			('C015', 'Ishara Bandara',0797890123, '751234567V', '1212 Oak Avenue, Dambulla'),
			('C016', 'Nimal Perera',0768901234, '651234567V', '1313 Cedar Road, Hambantota'),
			('C017', 'Chandani Fernando',0709012345, '541234567V', '1414 Maple Lane, Vavuniya'),
			('C018', 'Roshan de Silva',0711234567, '981234567V', '1515 Pine Street, Ampara'),
			('C019', 'Sanduni Jayawardena',0772345678, '881234567V', '1616 Elm Road, Kurunegala'),
			('C020', 'Asanka Rajapakse',0763456789, '761234567V', '1717 Oak Lane, Gampaha')
	;


-- Insert Data to Reservation Table ----------------------------------------------------------
Insert into Reservation(Reservation_Id, Pickup_Date, Returan_Date, Rental_Amount, Type, Driver_ID, Customer_ID, Car_ID)
		Values	('R001', '2023-12-01', '2023-12-05', 2500.00, 'With Driver', 'D001', 'C001', 'CAR001'),
				('R002', '2023-12-03', '2023-12-08', 1800.00, 'Without Driver', NULL, 'C002', 'CAR002'),
				('R003', '2023-12-10', '2023-12-10', 3200.00, 'With Driver', 'D002', 'C003', 'CAR003'),
				('R004', '2023-12-10', '2023-12-12', 4200.00, 'Without Driver', NULL, 'C004', 'CAR004'),
				('R005', '2023-12-11', '2023-12-15', 6000.00, 'With Driver', 'D003', 'C005', 'CAR005'),
				('R006', '2023-12-12', '2023-12-18', 2800.00, 'Without Driver', NULL, 'C006', 'CAR006'),
				('R007', '2023-12-12', '2023-12-20', 3000.00, 'With Driver', 'D004', 'C007', 'CAR007'),
				('R008', '2023-12-13', '2023-12-24', 3200.00, 'Without Driver', NULL, 'C008', 'CAR008'),
				('R009', '2023-12-13', '2023-12-28', 2000.00, 'With Driver', 'D005', 'C009', 'CAR009'),
				('R010', '2023-12-22', '2023-12-30', 4800.00, 'Without Driver', NULL, 'C010', 'CAR010')
		;

-- Insert data to Payment Table --------------------------------------------------------------
Insert into Payment (Payment_ID, Cost, Type, Remaining_Amount, Reservation_Id)
	Values	('P001', 1500.00, 'Full Payment', 0.00, 'R001'),
			('P002', 1100.00, 'Down Payment', 500.00, 'R002'),
			('P003', 2500.00, 'Full Payment', 0.00, 'R003'),
			('P004', 4200.00, 'Full Payment', 0.00, 'R004'),
			('P005', 6000.00, 'Down Payment', 3000.00, 'R005'),
			('P006', 2800.00, 'Full Payment', 0.00, 'R006'),
			('P007', 3000.00, 'Down Payment', 2000.00, 'R007'),
			('P008', 3200.00, 'Full Payment', 0.00, 'R008'),
			('P009', 2000.00, 'Down Payment', 1000.00, 'R009'),
			('P010', 4800.00, 'Full Payment', 0.00, 'R010'),
			('P0011', 2500.00, 'Full Payment', 0.00, 'R001'),
			('P0012', 1600.00, 'Down Payment', 400.00, 'R002'),
			('P0013', 3200.00, 'Full Payment', 0.00, 'R003'),
			('P0014', 4200.00, 'Full Payment', 0.00, 'R004')
		;
		

-- Insert Data to Damage_Report Table -------------------------------------------------------------
Insert into Damage_Report (Report_ID, Date, Time, Description, Car_ID)
	Values	('DR001', '2023-12-02', '08:30:00', 'Scratch on the rear bumper', 'CAR001'),
			('DR002', '2023-12-05', '10:15:00', 'Dent on the driver-side door', 'CAR002'),
			('DR003', '2023-12-08', '13:45:00', 'Cracked windshield', 'CAR003'),
			('DR004', '2023-12-12', '15:20:00', 'Paint chipping on the hood', 'CAR004'),
			('DR005', '2023-12-15', '11:10:00', 'Broken side mirror', 'CAR005'),
			('DR006', '2023-12-18', '09:30:00', 'Scuff marks on the front bumper', 'CAR006'),
			('DR007', '2023-12-22', '14:00:00', 'Dent on the passenger-side door', 'CAR007'),
			('DR008', '2023-12-25', '12:45:00', 'Scratch on the rear quarter panel', 'CAR008'),
			('DR009', '2023-12-28', '16:20:00', 'Broken taillight', 'CAR009'),
			('DR010', '2024-01-02', '09:15:00', 'Dent on the roof', 'CAR010')
	;


-- Insert data to  Maintannce_Log ---------------------------------------------------------------------------
Insert into Maintance_Log (Log_ID, Date, Time, Cost, Description, Report_ID)
	Values	('ML001', '2023-12-03', '09:00:00', 350.00, 'Replace rear bumper', 'DR001'),
			('ML002', '2023-12-07', '11:30:00', 500.00, 'Repair driver-side door dent', 'DR002'),
			('ML003', '2023-12-10', '14:45:00', 700.00, 'Replace windshield', 'DR003'),
			('ML004', '2023-12-14', '16:20:00', 600.00, 'Repaint hood', 'DR004'),
			('ML005', '2023-12-17', '12:10:00', 350.00, 'Replace side mirror', 'DR005'),
			('ML006', '2023-12-21', '10:30:00', 450.00, 'Repair front bumper scuff marks', 'DR006'),
			('ML007', '2023-12-24', '15:00:00', 600.00, 'Repair passenger-side door dent', 'DR007'),
			('ML008', '2023-12-28', '13:45:00', 300.00, 'Fix rear quarter panel scratch', 'DR008'),
			('ML009', '2024-01-02', '17:20:00', 400.00, 'Replace broken taillight', 'DR009'),
			('ML010', '2024-01-06', '09:15:00', 550.00, 'Repair roof dent', 'DR010')
	;

-- ###################################################################################################################--


--------------------------------------------Simple SELECT Queries-----------------------------------------------

--(1)  Display all data from the Car table
			select * from Car;

--(2)  Display all data from the Driver Table
			select * from Driver;

--(3)  Display Name, Contact from the Customer Table
			select Name,Contact from Customer;

--(4)  Display Rental Rate less than 2500.00 Car Model and Rental Rate
			select Model,Rental_Rate from Car
			where Rental_Rate<2500.00;

---------------------------------SELECT queries using GROUP BY and HAVING clause-----------------------------

--(1)  Display Number of Reservation ,Sum of Rental Amount of Each Reservation Type from Reservation Table
			select Type,count(Reservation_ID) AS Reservation,sum(Rental_Amount) AS Income from Reservation
			group by  Type;

--(2)  Display number of Reservations ,Sum of Rental amount of Each Pickup Date and Sum of rental rate that are grater than 3000.00 
			select  Pickup_Date,count(Reservation_ID) AS Reservation,sum(Rental_Amount) AS Income
			from Reservation
			group by Pickup_Date
			having Sum(Rental_Amount)>3000;

--(3)  Display Full Maintance Cost for Each Date and the costs that are Grater than 500
			select Date,Sum(Cost) AS Full_Maintance_Cost 
			from Maintance_Log
			Group By Date
			Having Sum(Cost)>500;

--------------------------------------Join relevant tables and display different data--------------------------------------------------

--(1)  Display Reservation ID,Pickup & Return Dates,Rental Amount,Reservation Type, Customer Name and Contact ,Car Id and Model And Branch Name

			SELECT R.Reservation_Id, R.Pickup_Date, R.Returan_Date, R.Rental_Amount, R.Type,
				   C.Name AS Customer_Name, C.Contact AS Customer_Contact,
				   Ca.Car_ID, Ca.Model AS Car_Model, 
				   B.Name AS Branch_Name
			FROM Reservation R
				INNER JOIN Customer C ON R.Customer_ID = C.Customer_ID
				INNER JOIN Car Ca ON R.Car_ID = Ca.Car_ID
				INNER JOIN Branch B ON Ca.Branch_ID = B.Branch_ID;

--(2) Display All payments Cost Remaining Amount,Payment Date,Reservation Id,Rental Amount,Customer Name And Customer Contact Number 

			SELECT P.Payment_ID, P.Cost,P.Remaining_Amount, P.Date AS Payment_Date,
				   R.Reservation_Id, R.Rental_Amount,
				   C.Name AS Customer_Name, C.Contact AS Customer_Contact
			FROM Payment P
				INNER JOIN Reservation R ON P.Reservation_Id = R.Reservation_Id
				INNER JOIN Customer C ON R.Customer_ID = C.Customer_ID;


--(3)  Display All Car ID,Damage Report Id,Damage Date,Damge Description,Maintance Log Id,Maintance Date and Cost

			SELECT	C.Car_ID,
					DR.Report_ID, DR.Date AS Damage_Date, DR.Description AS Damage_Description,
					ML.Log_ID, ML.Date AS Maintenance_Date, ML.Cost AS Maintenance_Cost
			FROM Damage_Report DR
				INNER JOIN Car C ON DR.Car_ID = C.Car_ID
				INNER JOIN Maintance_Log ML ON DR.Report_ID = ML.Report_ID;




---------------------------------------- -------Sub Queries ------ ------------------------------------------------------

--(1) Display Payment Id,Payment Cost,Remaining Amount Payment Date,Reservation id,Rental Rate,Customer Name and Contaact in reservations where a driver drives

			SELECT P.Payment_ID, P.Cost,P.Remaining_Amount, P.Date AS Payment_Date,
				   R.Reservation_Id, R.Rental_Amount,
				   C.Name AS Customer_Name, C.Contact AS Customer_Contact
			FROM Payment P
				INNER JOIN Reservation R ON P.Reservation_Id = R.Reservation_Id
				INNER JOIN Customer C ON R.Customer_ID = C.Customer_ID
				where Driver_ID in 
								(select Driver_ID from Reservation);


--(2)  Display All Car ID,Damage Report Id,Damage Date,Damge Description,Maintance Log Id,Maintance Date and Cost in Maintence Cost Grater than 500

			SELECT	C.Car_ID,
					DR.Report_ID, DR.Date AS Damage_Date, DR.Description AS Damage_Description,
					ML.Log_ID, ML.Date AS Maintenance_Date, ML.Cost AS Maintenance_Cost
			FROM Damage_Report DR
				INNER JOIN Car C ON DR.Car_ID = C.Car_ID
				INNER JOIN Maintance_Log ML ON DR.Report_ID = ML.Report_ID
				where Cost in 
						(select Cost from Maintance_Log
							where Cost>500);




---------------------------------------------------- VIEWS --------------------------------------------------

--(1)  View to display reservation details with customer information

			Create View ReservationDetails AS
				SELECT R.Reservation_Id, R.Pickup_Date, R.Returan_Date, R.Rental_Amount, R.Type,
					   C.Customer_ID, C.Name AS Customer_Name, C.Contact AS Customer_Contact,
					   Ca.Car_ID, Ca.Model AS Car_Model
				FROM Reservation R
						INNER JOIN Customer C ON R.Customer_ID = C.Customer_ID
						INNER JOIN Car Ca ON R.Car_ID = Ca.Car_ID;

			--view to get reservation details 
			SELECT * FROM ReservationDetails;

--(2)  View to display the total cost of maintenance for each car

			CREATE VIEW TotalMaintenanceCostEachCar AS
				SELECT D.Car_ID,C.Model ,SUM(M.Cost) AS TotalCost
				FROM Damage_Report D
						INNER JOIN Maintance_Log M ON D.Report_ID = M.Report_ID
						INNER JOIN Car C ON D.Car_ID=C.Car_ID
				GROUP BY D.Car_ID,C.Model;


			-- view to get the total maintenance cost for each car
			



------------------------------------------------- Stored Procedures------------------------------------------------
--(1)  Get Today All Reseravation-------------------------------------------------------------------------------

			Create Procedure Today_Reservations
			AS
			Begin
				Select R.Reservation_Id,R.Car_ID,R.Customer_ID,R.Pickup_Date,R.Type
				from Reservation R
				where  CONVERT(Date, R.Pickup_Date)=CONVERT(Date,Getdate());
			End;

			--Execute Reservation Procedure
			exec Today_Reservations



--(2)  Get Today Full Payments---------------------------------------------------------------------------------------------

			Create Procedure Today_Full_Payments
			AS
			Begin
				Select P.Payment_ID,P.Cost,P.Reservation_Id
				from Payment P
				Where P.Type='Full Payment' and CONVERT(Date,P.Date) = CONVERT(Date, GETDATE());
			End;

			--Execute Today_Full_Payments Procedure
			exec Today_Full_Payments


--(3)  Get Reservations Made By a specific Customer------------------------------------------------------------------------

			Create Procedure Get_Customer_Reservations @ID varchar(10)
			AS
			Begin
				Select
					R.Reservation_Id,R.Pickup_Date,R.Returan_Date, 
					C.Customer_ID,C.Name AS Customer_Name,
					Car.Car_ID,Car.Model AS Car_Model
				From Reservation R
					INNER Join Customer C ON R.Customer_ID = C.Customer_ID
					INNER Join Car ON R.Car_ID = Car.Car_ID
				Where C.Customer_ID = @ID; 
			End;


			--Get all reservations Made BY Customer (Using Procedure)
			exec Get_Customer_Reservations @ID='C002'
			exec Get_Customer_Reservations @ID='C003'
			exec Get_Customer_Reservations @ID='C005'

--(4)  Update the rental rate of a specific car------------------------------------------------------------------------------

		--View Currently Rental  Rate CAR001
		select Rental_Rate  From Car 
		where Car_ID='CAR001';

		--Procedure
		Create Procedure Update_Car_Rental_Rate @Car_ID varchar(10),@New_Rental_Rate Decimal(10,2) 
		AS
		Begin
			Update Car
			set Rental_Rate=@New_Rental_Rate
			Where Car_ID=@Car_ID
		End;

					-- Update CAR001 Rantal Rate Is 1600.00 (Using Procedure)
					exec Update_Car_Rental_Rate @Car_ID='CAR001',@New_Rental_Rate=1600.00


			--View After Updating Rental  Rate CAR001
			select Rental_Rate  From Car 
			where Car_ID='CAR001';



--(5) Get Payment Infomations by a specific Reservation--------------------------------------------------------------------------

			Create Procedure Payment_Info @Reservation_ID varchar(10)
			AS 
			Begin 
					SELECT	R.Reservation_Id, R.Rental_Amount,
							P.Payment_ID, P.Cost,P.Remaining_Amount, P.Date AS Payment_Date,
							C.Name AS Customer_Name, C.Contact AS Customer_Contact
					FROM Payment P
						INNER JOIN Reservation R ON P.Reservation_Id = R.Reservation_Id
						INNER JOIN Customer C ON R.Customer_ID = C.Customer_ID
						where R.Reservation_Id=@Reservation_ID;
			End;


			--View R001 Reservation Payment Infomations
			exec Payment_Info @Reservation_ID='R001'

			