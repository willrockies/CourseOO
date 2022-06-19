using System;
using secao14_interfaces.Entities;
namespace secao14_interfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        /*Aula 204/205 - solução sem interface */
        //private BrazilTaxService _brazilTaxService = new BrazilTaxService(); // service fortemente acoplada 

        /*Aula 206 - solução com interface*/

        private ITaxService _taxService; //Acoplamento fraco
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) 
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
