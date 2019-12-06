﻿using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class LocationGetCityByCityIdDelegate: DataReaderDelegate<Cities>
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

        public override Cities Translate(SqlCommand command, IDataRowReader reader)
    {
        if (!reader.Read())
            return null;


         return new Cities(cityID,
                  reader.GetString("Country"),
                  reader.GetString("Region"),
                  reader.GetString("CityName"));

        }

       }
}