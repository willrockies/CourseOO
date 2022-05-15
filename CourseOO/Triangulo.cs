using System;

namespace CourseOO
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        // atribuindo delegação pelo metodo
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
