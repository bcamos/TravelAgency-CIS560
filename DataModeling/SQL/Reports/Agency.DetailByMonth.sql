CREATE OR ALTER PROC Agency.DetailByMonth
AS
SELECT
	MONTH(T.DateCreated) As [Month] , COUNT(DISTINCT T.TripID) As NumberOfTrips,
    CAST(COUNT(AC.CustomerID)/ COUNT(AA.AgentID) AS FLOAT) AS AverageCustomersPerAgent,
    SUM(AC.Budget) AS TotalSale
FROM Agency.Agents AA 
LEFT JOIN  Agency.Trips T ON T.AgentID = AA.AgentID
LEFT JOIN Agency.Customer AC ON AC.CustomerID = T.CustomerID
GROUP BY  MONTH(T.DateCreated)
ORDER BY  MONTH(T.DateCreated) DESC

