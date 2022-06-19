using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using secao14_interfaces.Entities;
using secao14_interfaces.Services;
using secao14_interfaces.Model.Entities;
using secao14_interfaces.Model.Entities.Enums;
using secao14_interfaces.Model.Entities.Interface;
using secao14_interfaces.Device;

namespace secao14_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Aula 208 */
            /*
            Console.WriteLine("Enter Rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService()); //<- injeção de dependencia por meio de construtor
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
            */
            /*Aula 209*/
            /* Console.WriteLine("Aula 209");
             IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
             IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

             Console.WriteLine(s1);
             Console.WriteLine(s2);

             Console.WriteLine("-------------");*/

            /*Aula 210 - Herança Multipla e o problema do diamante*/
            Console.WriteLine("Aula 210");
            Printer p = new Printer() { SerialNumber = 1008 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2008 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice comboDevice = new ComboDevice() { SerialNumber = 3921 };
            comboDevice.ProcessDoc("My dissertation ");
            comboDevice.Print("My dissertation");
            Console.WriteLine(comboDevice.Scan());
            Console.WriteLine("-------------");

            /*Aula 211 - IComparable*/
            Console.WriteLine("Aula 211");

            string path = @"c:\temp\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        //list.Add(sr.ReadLine());
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("-------------");

        }
    }
}
