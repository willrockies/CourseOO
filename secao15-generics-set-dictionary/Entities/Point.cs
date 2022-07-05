using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao15_generics_set_dictionary.Entities
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

    }
}
