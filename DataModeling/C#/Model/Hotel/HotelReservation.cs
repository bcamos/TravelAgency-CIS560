using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class HotelReservation : IReservation
    {
        /// <summary>
        /// hotel reservation id
        /// </summary>
        public int ReservationID { get; }

        /// <summary>
        /// id of hotel
        /// </summary>
        public int HotelID { get; }

        /// <summary>
        /// check in date
        /// </summary>
        public DateTime CheckinDate { get; }

        /// <summary>
        /// price of hotel reservation
        /// </summary>
        public double Price { get; }

        public HotelReservation(int reservationID, int hotelID, DateTime checkinDate, double price)
        {
            ReservationID = reservationID;
            HotelID = hotelID;
            CheckinDate = checkinDate;
            Price = price;
        }
        /// <summary>
        /// returns hotel reservation properties with commas in between
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ReservationID: {ReservationID}, HotelID: {HotelID}, CheckinDate: {CheckinDate.Date}, Price: {Price}";

        }

        public string ReservationInfo()
        {
            return $"Hotel Reservation\n\t{ReservationID}, Hotel {HotelID}, ${Price}, {CheckinDate.Date}";
        }
    }
}
