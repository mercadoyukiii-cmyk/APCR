CREATE TABLE [dbo].[Reservations]
(
ReservationID INT PRIMARY KEY IDENTITY(1,1),
    GuestID INT NOT NULL,
    RoomID INT NOT NULL,
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    Status VARCHAR(20) 
        CHECK (Status IN ('Pending', 'Confirmed', 'Cancelled', 'CheckedOut')) 
        DEFAULT 'Pending',
    FOREIGN KEY (GuestID) REFERENCES Guest(GuestID),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID))
