using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class BoardingPass : IReservation
    {
        /// <summary>
        /// reservation id of boardingpass
        /// </summary>
        public int ReservationID { get; }

        /// <summary>
        /// id of flight
        /// </summary>
        public int FlightID { get; }

        /// <summary>
        /// price of ticket
        /// </summary>
        public double Price { get;  }

        public BoardingPass(int reservationID, int flightID, double price)
        {
            ReservationID = reservationID;
            Price = price;
            FlightID = flightID;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ReservationID: " + ReservationID);
            result.Append(", ");
            result.Append("FlightID: " + FlightID);
            result.Append(", ");
            result.Append("Price: " + Price);

            return result.ToString();
        }

        public string ReservationInfo()
        {
            return $"Boarding Pass\n\t {ReservationID}, Flight {FlightID}, ${Price}"; 
        }
    }
}
