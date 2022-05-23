using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace secao_5
{
    internal class Produto
    {

        // aula 55 - encapsulamento
        //private string _nome;
        //private double _preco;
        //private int _quantidade;

        /*aula 57 - auto properties */
        // digite prop e tab tem o auto complete
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // construtor padrão sem passar nenhum valor de paramentros


        public Produto()
        {
            // aula 54 this 
            //Quantidade = 10;
        }
        // aula 52 - sobrecarga
        public Produto(string nome, double preco) : this() //estou reaproveitando o constructor que somente passa quantidade sem ter que repetir
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5; // definindo a sobrecarga para a quantidade, ou seja um valor especifico, mas por default inicia como 0
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) //estou reaproveitando o constructor que somente passa quantidade sem ter que repetir referencia aula 54 'palavra this'
        {

            Quantidade = quantidade;
        }

        // aula 56 - properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {

                    _nome = value;
                }
            }
        }

        // aula 55 - dando acesso a um atributo privado
        /*public string getNome()
        {
            return _nome;
        }*/


        /*  public void SetNome(string nome)
          {
              if(nome != null && nome.Length > 1)
              {
                  this._nome = nome;
              }
          }*/

        // aula 56 - properties
        /*public double Preco
        {
            get { return _preco; }
        }*/

        /* public double getPreco()
         {
             return _preco;
         }*/
        // aula 56 - properties
        //public int Quantidade { get { return _quantidade; } }
        /*public int getQuantidade()
        {
            return _quantidade;
        }*/
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
