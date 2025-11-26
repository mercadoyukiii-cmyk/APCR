CREATE TABLE [dbo].[Guest]
(
    GuestID INT not null PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NULL,
    LastName VARCHAR(50) NULL,
    MiddleInitial CHAR(1),
    DateOfBirth Datetime,
    Sex CHAR(1) CHECK (Sex IN ('M', 'F')),
    ContactNumber VARCHAR(15),
    Email VARCHAR(50),
    Address VARCHAR(100),
    EmergencyContact VARCHAR(50))
