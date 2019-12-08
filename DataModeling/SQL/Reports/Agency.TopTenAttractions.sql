USE TravelAgency;
GO
CREATE OR ALTER PROC Agency.TopTenAttractions AS
WITH attraction(AttractionID, Customers, CityName, Country, Price) AS 
(
SELECT A.AttractionID, COUNT(T.CustomerID) AS Customers, C.CityName, C.Country, [AT].Price 
FROM [Location].Cities C
	INNER JOIN Attractions.Attraction A ON A.CityID = C.CityID
	INNER JOIN Attractions.AttractionTicket [AT] ON A.AttractionID = [AT].AttractionID
	INNER JOIN Agency.Reservations R ON R.ReservationID = [AT].ReservationID
	INNER JOIN Agency.Trips T ON T.TripID = R.TripID
	

GROUP BY A.AttractionID, C.CityName, C.Country, [AT].Price
)
SELECT TOP 10 A.CityName, A.Country, A.Price
FROM attraction A
ORDER BY A.Customers DESC;

