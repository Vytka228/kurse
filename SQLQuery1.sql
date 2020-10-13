
USE master;

CREATE DATABASE Baseparking;

GO

USE [Baseparking];

GO

CREATE TABLE [Owners](
	Id INT PRIMARY KEY IDENTITY (1,1),
	FIO NVARCHAR(100) NOT NULL,
	NameFone NVARCHAR(50) NOT NULL
)

CREATE TABLE [Cars](
	Id INT PRIMARY KEY IDENTITY (1,1),
	Carbrands NVARCHAR(100) NOT NULL,
	Numberofthecar NVARCHAR(50) NOT NULL,
	OwnersId INT NOT NULL FOREIGN KEY REFERENCES [Owners] (Id) ON DELETE CASCADE
)
CREATE TABLE [Schedules](
	Id INT PRIMARY KEY IDENTITY (1,1),
	StartDate dateTime NOT NULL,
	EndDate dateTime NOT NULL,
	Salary Decimal NOT NULL
)

CREATE TABLE [Staffs](
	Id INT PRIMARY KEY IDENTITY (1,1),
	FIOStaffs NVARCHAR(100) NOT NULL,
	schedulesId INT NOT NULL FOREIGN KEY REFERENCES [schedules] (Id)
)

CREATE TABLE [Parkings](
	Id INT PRIMARY KEY IDENTITY (1,1),
	TypeParking NVARCHAR(60) NOT NULL,
	Dateentry dateTime NOT NULL,
	Datedeparture dateTime NOT NULL,
	CarsId INT NOT NULL FOREIGN KEY REFERENCES [Cars] (Id),
	Price DECIMAL NOT NULL,
	StaffsId INT NOT NULL FOREIGN KEY REFERENCES [Staffs] (Id)
)

GO



CREATE PROCEDURE [dbo].[AddCar]
    @Id INT,
	@Carbrand NVARCHAR(100),
	@Numberofthecar NVARCHAR(50),
	@Owners NVARCHAR(100)
AS
DECLARE @OwnId INT
SET @OwnId = (SELECT TOP(1) Id FROM Owners WHERE FIO = @Owners)
INSERT INTO Cars (Id,Carbrands, Numberofthecar, OwnersId) 
	VALUES(@Id, @Carbrand, @Numberofthecar, @OwnId)

GO

CREATE PROCEDURE [dbo].[UpdateCar]
    @Id INT,
	@Carbrands NVARCHAR(100),
	@Numberofthecar NVARCHAR(50),
	@Owners NVARCHAR(100)
AS
DECLARE @OwnId INT
SET @OwnId = (SELECT TOP(1) Id FROM Owners WHERE FIO = @Owners)
UPDATE Cars SET Carbrands = @Carbrands, Numberofthecar = @Numberofthecar, OwnersId = @OwnId
	WHERE Id = @Id

GO 

CREATE PROCEDURE [dbo].[AddParking]
    @Id INT,
	@TypeParking NVARCHAR(60),
	@Dateentry dateTime,
	@Datedeparture dateTime,
	@Car NVARCHAR(50),
	@Price DECIMAL,
	@Staff NVARCHAR(100)
AS
DECLARE @CarId INT, @StaffId INT
SET @CarId = (SELECT TOP(1) Id FROM Cars WHERE Numberofthecar = @Car)
SET @StaffId = (SELECT TOP(1) Id FROM Staffs WHERE FIOStaffs = @Staff)
INSERT INTO [Parkings] (Id, TypeParking, Dateentry, Datedeparture, CarsId, Price, StaffsId) 
	VALUES(@Id, @TypeParking, @Dateentry, @Datedeparture, @CarId, @Price, @StaffId)

GO

CREATE PROCEDURE [dbo].[UpdateParking]
    @Id INT,
	@TypeParking NVARCHAR(60),
	@Dateentry dateTime,
	@Datedeparture dateTime,
	@Car NVARCHAR(50),
	@Price DECIMAL,
	@Staff NVARCHAR(100)
AS
DECLARE @CarId INT, @StaffId INT
SET @CarId = (SELECT TOP(1) Id FROM Cars WHERE Numberofthecar = @Car)
SET @StaffId = (SELECT TOP(1) Id FROM Staffs WHERE FIOStaffs = @Staff)
UPDATE Parkings SET TypeParking = @TypeParking, Dateentry = @Dateentry, Datedeparture = @Datedeparture, CarsId = @CarId, Price = @Price, StaffsId = @StaffId
	WHERE Id = @Id

GO



CREATE VIEW CarView AS
SELECT Cars.Id, Cars.Carbrands, Cars.Numberofthecar, Owners.FIO As [Owner]
	FROM Cars
	JOIN Owners ON Owners.Id = Cars.OwnersId

GO

CREATE VIEW StaffView AS
SELECT Staffs.Id, Staffs.FIOStaffs, Schedules.StartDate As StartDate, Schedules.EndDate As EndDate, Schedules.Salary As Salary
	FROM Staffs
	JOIN Schedules ON Schedules.Id = Staffs.schedulesId

GO


DECLARE @step INT = 1;
DECLARE @Symbol CHAR(52) = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz';
DECLARE @Numb CHAR(10) = '0123456789';
DECLARE @secondStep INT;
DECLARE @Position INT;
DECLARE @Length INT;
DECLARE @FIO NVARCHAR(100);
DECLARE @NameFone NVARCHAR(50);

WHILE @step <= 500
	BEGIN
		SET @Length = 5 + RAND()*(100-5)
		SET @FIO = '';
		SET @secondStep = 1;
		WHILE @secondStep <= @Length
		BEGIN
			SET @Position=RAND()*52;
			SET @FIO = @FIO + SUBSTRING(@Symbol, @secondStep, 1)
			SET @secondStep = @secondStep + 1
		END
	
		INSERT INTO Owners(FIO, NameFone) VALUES (@FIO,1 + RAND() * 10000000)
		SET @step = @step + 1;
	END;

SET @step = 501;
DECLARE @Carbrand NVARCHAR(100);
DECLARE @Numberofthecar NVARCHAR(50);
DECLARE @Empl INT;
WHILE @step <= 21500
	BEGIN
		SET @Empl = 1 + RAND() * 1000;
		WHILE @Empl > 500
		BEGIN
			SET @Empl = 1 + RAND() * 1000;
		END
		SET @Length = 5 + RAND()*(100-5)
		SET @Carbrand = '';
		SET @secondStep = 1;
		WHILE @secondStep <= @Length
		BEGIN
			SET @Position=RAND()*52;
			SET @Carbrand = @Carbrand + SUBSTRING(@Symbol, @secondStep, 1)
			SET @secondStep = @secondStep + 1
		END
		SET @Length = 5 + RAND()*(100-5)
		SET @Numberofthecar = '';
		SET @secondStep = 1;
		WHILE @secondStep <= @Length
		BEGIN
			SET @Position=RAND()*52;
			SET @Numberofthecar = @Numberofthecar + SUBSTRING(@Symbol, @secondStep, 1)
			SET @secondStep = @secondStep + 1
		END
		INSERT INTO Cars (Carbrands,Numberofthecar ,OwnersId) VALUES (@Carbrand, @Numberofthecar, @Empl);
		SET @step = @step + 1;
	END;
SET @step = 21501;
WHILE @step <= 41500
	BEGIN
		INSERT INTO Schedules(StartDate,EndDate,Salary) VALUES (DATEADD(d, RAND() * 100, GETDATE()), DATEADD(d, RAND() * 100, GETDATE()),1 + RAND() * 10000000)
		SET @step = @step + 1;
	END;


SET @step = 41501;
DECLARE @FIOStaffs NVARCHAR(100);
DECLARE @Emp12 INT;
WHILE @step <= 61500
	BEGIN
		
	
		SET @Emp12 = 21500 + RAND() * 1000;
	
		WHILE @Emp12 > 41500
		BEGIN
			SET @Emp12 = 21500 + RAND() * 1000;
		END
		SET @Length = 5 + RAND()*(100-5)
		SET @FIOStaffs = '';
		SET @secondStep = 1;
		WHILE @secondStep <= @Length
		BEGIN
			SET @Position=RAND()*52;
			SET @FIOStaffs = @FIOStaffs + SUBSTRING(@Symbol, @secondStep, 1)
			SET @secondStep = @secondStep + 1
		END
		INSERT INTO Staffs (FIOStaffs,schedulesId) VALUES (@FIOStaffs, @Emp12);
		SET @step = @step + 1;
	END;

SET @step = 61501;
DECLARE @TypeParking NVARCHAR(100);
DECLARE @Emp13 INT;
DECLARE @Emp14 INT;
WHILE @step <= 81500
	BEGIN
		
	
		SET @Emp13 = 500 + RAND() * 1000;
	
		WHILE @Emp13 > 21500
		BEGIN
			SET @Emp13 = 500 + RAND() * 1000;
		END


		SET @Emp14 = 41500 + RAND() * 1000;
	
		WHILE @Emp14 > 61500
		BEGIN
			SET @Emp14 =41500 + RAND() * 1000;
		END


		SET @Length = 5 + RAND()*(100-5)
		SET @TypeParking = '';
		SET @secondStep = 1;
		WHILE @secondStep <= @Length
		BEGIN
			SET @Position=RAND()*52;
			SET @TypeParking = @TypeParking + SUBSTRING(@Symbol, @secondStep, 1)
			SET @secondStep = @secondStep + 1
		END
		INSERT INTO Parkings(TypeParking,Dateentry,Datedeparture,CarsId,Price,StaffsId) VALUES (@TypeParking, DATEADD(d, RAND() * 100, GETDATE()),  DATEADD(d, RAND() * 100, GETDATE()),@Emp13,1 + RAND() * 1000, @Emp14);
		SET @step = @step + 1;
	END;