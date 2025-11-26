CREATE TABLE [dbo].[Rooms]
(
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomNumber VARCHAR(10) NOT NULL,
    RoomTypeID INT not null,
    RoomCapacity int not Null,
    Status VARCHAR(20) CHECK (Status IN ('Available', 'Occupied', 'Maintenance')) DEFAULT 'Available',
    FOREIGN KEY (RoomTypeID) REFERENCES RoomTypes(RoomTypeID)
);
