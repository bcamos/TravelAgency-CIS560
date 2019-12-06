﻿using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class LocationFetchCityDelegate : NonQueryDataDelegate<City>
    {        
        public readonly string cityname;
        public readonly string region;
        public readonly string country;

        public LocationFetchCityDelegate(string cityname, string region, string country)
            : base("Location.FetchCity")
        {
            this.cityname = cityname;
            this.region = region;
            this.country = country;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            
            command.Parameters.AddWithValue("CityName", cityname);
            command.Parameters.AddWithValue("Region", region);
            command.Parameters.AddWithValue("Country", country);


            var p = command.Parameters.Add("CityID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override City Translate(SqlCommand command)
        {
            return new City((int)command.Parameters["CityID"].Value, cityname, region, country);
        }

    }
}