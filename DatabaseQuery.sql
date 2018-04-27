	CREATE TABLE accounting(
	accountId int IDENTITY(1,1) NOT NULL,
    accountType int ,
    accountUserid int ,
    accountRentid int ,
    accountMeId int ,
    accountMoney float ,
    accountDate DateTime ,
	PRIMARY KEY(accountId)
	FOREIGN KEY(accountUserid) REFERENCES users(userId),
	FOREIGN KEY(accountRentid) REFERENCES Rent(rentId),
	FOREIGN KEY(MeId) REFERENCES MeintanceExamintaion(meId)
	);
	
	CREATE TABLE cars(
	carId int IDENTITY(100000,1) NOT NULL,
    carGroup int, 
    carKm int,
    carModel nvarchar(max),
    carManufacturer nvarchar(max),
    carCare int,
    carExamination int, 
    carPrice float,
	PRIMARY KEY(carId)
	);
	
	CREATE TABLE gps(
	gpsId int identity(1,1) Not NULL,
	gpsXcord float,
	gpsYcord float,
	gpsCarId int,	
	primary key(gpsId),
	FOREIGN KEY(gpsCarId) REFERENCES cars(carId)
	);
	
	CREATE TABLE MeintanceExamintaion(
	meId int identity(1,1) NOt NULL,
    meintanceDate DateTime ,
    examinationsDate DateTime, 
    meCarId int,
    meintanceDateNext DateTime, 
    examinationsDateNext DateTime,
    primary key(meId)
	);	
	
	CREATE TABLE MemberShipType(
	memberId int NOT NULL,
	memberName nvarchar(MAX),
	discount float,
	primary key(memberId)
	);
	
	CREATE TABLE Rent(
	rentId int identity(1,1) NOT NULL,
	rentDate DateTime,
	RentFinishDate DateTime,
	carId int,
	userId int,
	primary key(rentId),
	FOREIGN KEY(carId) REFERENCES cars(carId),
	FOREIGN KEY(userId) REFERENCES users(userId)
	);
	
	CREATE TABLE users(
	userId int identity(1,1) NOT NULL,
	username nvarchar(MAX),
	password nvarchar(MAX),
    userNameSurname nvarchar(MAX),
    userAge DateTime,
    licenseId nvarchar(MAX),
    licenseYear DateTime,
    userTc nvarchar(MAX),
    userAdress nvarchar(MAX),
    userScore int,
    usermembership int,
    usergroup int,
    userAccountCreated DateTime,
    userMonthlyRent int,
	primary key(userId)
	FOREIGN KEY(usergroup) REFERENCES groups(groupsId)
	);	 
	
	CREATE TABLE groups(	 
	groupsId int identity(1,1) NOT NULL,
    string GroupName nvarchar(MAX),
	primary key(groupsId)
	);
	