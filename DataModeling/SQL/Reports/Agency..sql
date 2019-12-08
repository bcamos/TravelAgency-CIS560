--USE TravelAgency;
--GO
CREATE OR ALTER PROC Agency.DetailByMonth
AS
SELECT
	MONTH(T.DateCreated) As Month , COUNT(DISTINCT T.TripID) As NumberOfTrips,
    COUNT(AC.CustomerID)/ COUNT(AA.AgentID) AS AverageCustomersPerAgent,
    Sum(AC.Budget) AS TotalSale
FROM Agency.Agents AA 
Left JOIN  Agency.Trips T ON T.AgentID = AA.AgentID
Left JOIN Agency.Customer AC ON AC.CustomerID = T.CustomerID
GROUP BY  Month(T.DateCreated)
ORDER BY  Month(T.DateCreated) DESC

