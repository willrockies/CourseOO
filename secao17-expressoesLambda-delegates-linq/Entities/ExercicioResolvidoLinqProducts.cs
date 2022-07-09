using System;
using System.Collections.Generic;
using System.Text;

namespace secao17_expressoesLambda_delegates_linq.Entities
{
    internal class ExercicioResolvidoLinqProducts
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ExercicioResolvidoLinqProducts(string name, double price)
        {
            Name = name; 
            Price = price;
        }
    }
}
