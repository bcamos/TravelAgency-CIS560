using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class CarRentalReservation : IReservation
    {
        /// <summary>
        /// reservation id
        /// </summary>
        public int ReservationID { get; }

        /// <summary>
        /// car rental id
        /// </summary>
        public int CarRentalID { get; }

        /// <summary>
        /// date of car rental
        /// </summary>
        public DateTime RentalDate { get; }

        /// <summary>
        /// model of car
        /// </summary>
        public string Model { get; }

        /// <summary>
        /// price of reservation
        /// </summary>
        public double Price { get; }

        public CarRentalReservation(int reservationID, int carRentalID, DateTime rentalDate, string model, double price)
        {
            ReservationID = reservationID;
            CarRentalID = carRentalID;
            RentalDate = rentalDate;
            Model = model;
            Price = price;
        }
        /// <summary>
        /// returns car rental reservation's properties between commas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ReservationID: {ReservationID}, CarRentalID: {CarRentalID}, RentalDate: {RentalDate.Date}, Model: {Model}, Price: {Price}";
        }

        public string ReservationInfo()
        {
            return $"Car Rental Reservation\n\t{ReservationID}, Car Rental Agency {CarRentalID}, Model {Model}, ${Price}, {RentalDate.Date}"; 
        }
    }
}
