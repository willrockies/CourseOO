using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioHerancaProduto.Entities;

namespace ExercicioHerancaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char imported = char.Parse(Console.ReadLine());
                
                Console.Write("Name");
                string name = Console.ReadLine();
                Console.Write("Price");
                double price = double.Parse(Console.ReadLine());

                if (imported == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(imported == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

                Console.WriteLine("PRICE TAGS: ");
                foreach (Product item in list)
                {
                    Console.WriteLine(item.PriceTag());
                }
                

            }
        }
    }
}
