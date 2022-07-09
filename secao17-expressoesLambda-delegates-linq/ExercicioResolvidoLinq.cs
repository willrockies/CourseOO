using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using secao17_expressoesLambda_delegates_linq.Entities;
using System.Linq;

namespace secao17_expressoesLambda_delegates_linq
{
    internal class ExercicioResolvidoLinq
    {
        public static void ProdutosAvaliado()
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<ExercicioResolvidoLinqProducts> list = new List<ExercicioResolvidoLinqProducts>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");

                    string name = line[0];
                    double price = double.Parse(line[1], CultureInfo.InvariantCulture);


                    ExercicioResolvidoLinqProducts product = new ExercicioResolvidoLinqProducts(name, price);
                    list.Add(product);
                }
            }

            var average = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average Price: " + average.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
