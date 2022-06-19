using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using secao14_interfaces.Model.Entities.Enums;
using secao14_interfaces.Model.Entities;

namespace secao14_interfaces.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }


        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
