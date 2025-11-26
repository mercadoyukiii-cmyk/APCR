CREATE TABLE [dbo].[Billing]
(
   BillingID INT PRIMARY KEY IDENTITY(1,1),
    ReservationID INT NOT NULL,
    ServiceDate DATE NOT NULL,
    Description TEXT,
    Amount DECIMAL(10, 2) NOT NULL,
    BillingStatus VARCHAR(10) 
        CHECK (BillingStatus IN ('Unpaid', 'Paid')) 
        DEFAULT 'Unpaid',
    FOREIGN KEY (ReservationID) REFERENCES Reservations(ReservationID)
)