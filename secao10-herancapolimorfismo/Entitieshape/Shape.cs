using System;
using secao10_herancapolimorfismo.Entitieshape.Enums;

namespace secao10_herancapolimorfismo.Entitieshape
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape (Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
