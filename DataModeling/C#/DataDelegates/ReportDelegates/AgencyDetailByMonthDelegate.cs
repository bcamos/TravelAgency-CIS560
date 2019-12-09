﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataModeling.Model;
using System.Globalization;

namespace DataModeling
{
    public class AgencyDetailByMonthDelegate : DataReaderDelegate<IReadOnlyList<string>>
    {
        public AgencyDetailByMonthDelegate() : base("Agency.DetailByMonth")
        {

        }

        public override IReadOnlyList<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> rows = new List<string>();

            while (reader.Read())
            {
                rows.Add($"{reader.GetInt32("Month").ToString()}," +
                    $" {reader.GetInt32("NumberOfTrips")}, " +
                    $"{reader.GetDouble("AverageTripsPerAgent"):N2}, " +
                    $"{reader.GetDouble("TotalSale").ToString("C", CultureInfo.CurrentCulture)} ");

            }
            return rows;


        }
    }
}
