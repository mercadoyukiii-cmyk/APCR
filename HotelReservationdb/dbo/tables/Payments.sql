CREATE TABLE [dbo].[Payments]
(
 PaymentID INT PRIMARY KEY IDENTITY(1,1),
    BillingID INT NOT NULL,
    PaymentDate DATE NOT NULL,
    AmountPaid DECIMAL(10, 2) NOT NULL,
    PaymentMethod VARCHAR(20) 
        CHECK (PaymentMethod IN ('Bank Transfer')) 
        DEFAULT 'Bank Transfer',
    FOREIGN KEY (BillingID) REFERENCES Billing(BillingID)
)
