using DataAccess;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace DataModeling.C_.DataDelegates.AttractionsDelegates
{
    public class CreateAttractionDelegate : NonQueryDataDelegate<Attraction>
    {
        public readonly string name;
        public readonly int cityId;

        public CreateAttractionDelegate(string name, int cityId)
            : base("Attractions.CreateAttraction")
        {
            this.name = name;
            this.cityId = cityId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            
            command.Parameters.AddWithValue("CityID", cityId);

            var p = command.Parameters.Add("AttractionID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }


        public override Attraction Translate(SqlCommand command)
        {
            return new Attraction((int)command.Parameters["AttractionID"].Value, name, cityId);
        }
    }
}
