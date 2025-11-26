CREATE TABLE [dbo].[RoomTypes]
(
[RoomTypeID]	INT PRIMARY KEY IDENTITY (1,1),
[RoomTypeName]	VARCHAR(50),
[Description]	TEXT,	
[PricePerNight]	DECIMAL(10, 2),	
[MaxOccupancy]	INT
)

