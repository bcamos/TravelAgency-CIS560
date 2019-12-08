using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class AttractionTicket : IReservation
    {
        /// <summary>
        /// reservation id
        /// </summary>
        public int ReservationID { get; }

        /// <summary>
        /// attraction id
        /// </summary>
        public int AttractionID { get; }

        /// <summary>
        /// ticket date
        /// </summary>
        public DateTime TicketDate { get; }

        /// <summary>
        /// price of ticket
        /// </summary>
        public double Price { get; }

        public AttractionTicket(int reservationID, int attractionID, DateTime ticketDate, double price)
        {
            ReservationID = reservationID;
            AttractionID = attractionID;
            TicketDate = ticketDate;
            Price = price;
        }
        /// <summary>
        /// returns properties with commas in between
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ReservationID: {ReservationID}, AttractionID: {AttractionID}, TicketDate: {TicketDate.Date}, Price: ${Price}";
        }

        /// <summary>
        /// returns reservation info
        /// </summary>
        /// <returns></returns>
        public string ReservationInfo()
        {
            return "Attraction Ticket\n\t" + ReservationID + ", Attraction " + AttractionID + ", $" + Price + ", " + TicketDate.Date; 
        }
    }
}
