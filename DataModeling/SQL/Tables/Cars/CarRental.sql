﻿CREATE TABLE Cars.CarRental
(
    CarRentalID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    AgencyName NVARCHAR(120) NOT NULL,
    CityID INT NOT NULL FOREIGN KEY REFERENCES [Location].Cities(CityID)
)