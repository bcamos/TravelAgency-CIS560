using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    /// <summary>
    /// Provides functionality for connecting to SQL procedure for getting a city given its id
    /// </summary>
    public class LocationGetCityByCityIdDelegate: DataReaderDelegate<City>
    {

        private readonly int cityID;


        public LocationGetCityByCityIdDelegate(int cityID)
            : base("Location.GetCities")      
        {
            this.cityID = cityID;            
        }       

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("CityID", cityID);
        }

        public override City Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new City(cityID,
                  reader.GetString("CityName"),
                  reader.GetString("Region"),
                  reader.GetString("Country"));
        }
    }
}
