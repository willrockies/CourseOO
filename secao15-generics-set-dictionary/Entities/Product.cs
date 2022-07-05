﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao15_generics_set_dictionary.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a product");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                return false;
            }

            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
