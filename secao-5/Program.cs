using System;
using System.Globalization;

namespace secao_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aula 51 - construtores
            //Console.WriteLine("Nome: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());


            // Produto produto = new Produto(nome, preco, quantidade);

            // aula 52 - sobrecarga
            // Produto produto = new Produto(nome, preco);
            Produto p = new Produto("TV", 500.00, 5); // chamando o construtor sem nenhum paramentro

            // aula 53 - sintaxe alternativa para inicializar valores
            /*Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };*/

            //aula 55 - encapsulamento acessando atributo privado nome
            //p.SetNome("T");

            //Console.WriteLine(p.getNome());
            //Console.Write(p.getPreco());


            //aula 56 - Properties
            p.Nome = "TV 4k";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            /*Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto.ToString());
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + produto);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);*/
        }
    }
}
