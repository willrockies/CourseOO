using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using secao14_interfaces.Model.Entities.Interface;
using secao14_interfaces.Model.Entities.Enums;
namespace secao14_interfaces.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
