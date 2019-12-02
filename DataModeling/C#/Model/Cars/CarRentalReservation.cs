﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class CarRentalReservation
    {
        public int ReservationID { get; }

        public int CarRentalID { get; }

        public DateTime RentalDate { get; }

        public string Model { get; }

        public float Price { get; }

        public CarRentalReservation(int reservationID, int carRentalID, DateTime rentalDate, string model, float price)
        {
            ReservationID = reservationID;
            CarRentalID = carRentalID;
            RentalDate = rentalDate;
            Model = model;
            Price = price;
        }
        public override string ToString()
        {
            return $"ReservationID: {ReservationID}, CarRentalID: {CarRentalID}, RentalDate: {RentalDate.Date}, Model: {Model}, Price: {Price}";

        }
    }
}
