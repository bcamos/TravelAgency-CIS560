﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess;

namespace DataModeling
{
    public class AgencyTopTenAttractionsDelegate : DataReaderDelegate<IReadOnlyList<string>>
    {
        public AgencyTopTenAttractionsDelegate() : base("Agency.TopTenAttractions")
        {

        }

        public override IReadOnlyList<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> rows = new List<string>();

            while(reader.Read())
            {
                rows.Add($"{reader.GetInt32("AttractionID")}, {reader.GetString("Name")}, " +
                    $"{reader.GetInt32("NumberOfCustomers")}, {reader.GetString("CityName")}, " +
                    $"{reader.GetString("Country")}, {reader.GetDouble("Price")}");
            }

            return rows;
        }
    }
}