USE TravelAgency;
GO
CREATE OR ALTER PROC Agency.DetailByMonth
AS
SELECT
	MONTH(T.DateCreated) As [Month] , COUNT(DISTINCT T.TripID) As NumberOfTrips,
    COUNT(T.TripID)/ CAST(COUNT(DISTINCT AA.AgentID) AS FLOAT) AS AverageTripsPerAgent,
    SUM(AC.Budget) AS TotalSale
FROM Agency.Agents AA 
INNER JOIN  Agency.Trips T ON T.AgentID = AA.AgentID
INNER JOIN Agency.Customer AC ON AC.CustomerID = T.CustomerID
GROUP BY  MONTH(T.DateCreated)
ORDER BY  MONTH(T.DateCreated) DESC

