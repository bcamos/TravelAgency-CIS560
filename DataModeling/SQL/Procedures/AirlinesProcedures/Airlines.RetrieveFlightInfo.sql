/*
	Gets a particular flight givent the flight id
*/
CREATE OR ALTER PROCEDURE Airlines.RetrieveFlightInfo
	@FlightID INT
AS

SELECT 
	FL.FlightID,
	FL.AirlineName,
	FL.DepartureTime,
	FL.ArrivalTime,
	FL.DepartureTime,
	FL.CityDepartureID,
	FL.CityArrivalID	
FROM Airlines.Flight FL
WHERE FL.FlightID = @FlightID;
GO