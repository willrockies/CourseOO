using System;
using System.Globalization;
using secao14_interfaces.Model.Entities.Enums;
using secao14_interfaces.Model.Entities;

namespace secao14_interfaces.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width
                + ", Height = "
                + Height
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
