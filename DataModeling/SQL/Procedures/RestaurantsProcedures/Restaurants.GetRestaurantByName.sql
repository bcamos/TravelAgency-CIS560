/*
	Gets a restaurant given all information except its id
*/
CREATE OR ALTER PROCEDURE Restaurants.GetRestaurantByName
	@Name NVARCHAR(120),
	@CityID INT

AS

SELECT RestaurantID
FROM Restaurants.Restaurant
WHERE @Name = [Name] and @CityID = CityID
GO