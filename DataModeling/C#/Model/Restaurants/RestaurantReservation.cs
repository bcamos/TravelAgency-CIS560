using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class RestaurantReservation : IReservation
    {
        /// <summary>
        /// id of reservation
        /// </summary>
        public int ReservationID { get; }
        /// <summary>
        /// date of reservation
        /// </summary>
        public DateTime ReservationDate { get; }
        /// <summary>
        /// restaurant id
        /// </summary>
        public int RestaurantID { get; }
        

        public RestaurantReservation(int reservationID, DateTime reservationDate, int restaurantID)
        {
            ReservationID = reservationID;
            ReservationDate = reservationDate;
            RestaurantID = restaurantID;            
        }

        /// <summary>
        /// properties with commas in between
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ReservationID: {ReservationID}, ReservationDate: {ReservationDate}, RestaurantID: {RestaurantID}";
        }
        /// <summary>
        /// reservation info
        /// </summary>
        /// <returns></returns>
        public string ReservationInfo()
        {
            return $"Restaurant Reservation\n\t {ReservationID}, Restaurant {ReservationID}, {ReservationDate}"; 
        }
    }
}
