using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReadingFiles.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public Product(string name, double preco, int quantidade)
        {
            Name = name;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double Total()
        {
            return Preco + Quantidade;
        }

        public override string ToString()
        {
            return Name + Preco + Quantidade; 
        }
    }
}
