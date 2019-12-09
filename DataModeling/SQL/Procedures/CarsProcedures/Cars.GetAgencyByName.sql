/*
	Gets a car agency given all information except its id
*/
CREATE OR ALTER PROCEDURE Cars.GetAgencyByName
	@AgencyName NVARCHAR(120),
	@CityID  int
AS

SELECT  CC.CarRentalID
FROM  Cars.CarRental CC 
WHERE CC.AgencyName = @AgencyName AND @CityID = CC.CityID
GO