﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace secao17_expressoesLambda_delegates_linq.Entities
{
    internal class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name;

        }
    }
}
