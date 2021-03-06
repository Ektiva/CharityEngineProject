﻿Use VehiclesTracking;

CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NULL,
	[PhoneNumber] NVARCHAR(50) NOT NULL,
	[UnitNumber] INT NOT NULL,
	[AptNumber] INT NOT NULL,
	[Make] NVARCHAR(50) NULL,
	[Model] NVARCHAR(50) NULL,
	[Color] NVARCHAR(50) NULL,
	[RegistrationNumber] INT NOT NULL UNIQUE,
	[DOR] DATETIME NOT NULL
)