using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    /// <summary>
    /// Provides functionality for connecting to SQL procedure for getting an attraction ticket given its id
    /// </summary>
    public class GetAttractionTicketDelegate : DataReaderDelegate<AttractionTicket>
    {
        private readonly int reservationID;

        public GetAttractionTicketDelegate(int reservationID)
           : base("Attractions.GetAttractionTicket")
        {
            this.reservationID = reservationID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
        }

        public override AttractionTicket Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reservationID.ToString());

            return new AttractionTicket(reader.GetInt32("ReservationID"),
               reader.GetInt32("AttractionID"),
               reader.GetDateTime("TicketDate"),
               reader.GetDouble("Price"));
        }
    }
}