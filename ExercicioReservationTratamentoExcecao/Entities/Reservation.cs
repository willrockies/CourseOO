using System;
using System.Collections.Generic;
using System.Text;
using ExercicioReservationTratamentoExcecao.Entities.Exceptions;
namespace ExercicioReservationTratamentoExcecao.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= CheckIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date!");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        //solução muito ruim
      /*  public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;

        }*/

        // solução ruim 
        /*public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                return "Error in reservation: Check-out date must be after check-in date";
            }
            if (checkOut <= checkIn)
            {
                return "Error in reservation: Check-out date must be after check-in date!";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;
        }*/

        // solução boa

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation: Check -out date must be after check -in date");
            }
            if(checkOut <= CheckIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }



        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in"
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out"
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "nights";
        }
    }
}
