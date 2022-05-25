using System;

namespace ExercicioVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartoVetor = new Estudante[10];
            Console.Write("Quantos quartos serão alugados: ");
            int qtdQuarto = int.Parse(Console.ReadLine());


            for (int i = 0; i < qtdQuarto; i++)
            {
                Console.WriteLine("Aluguel # " + i + 1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                quartoVetor[quarto] = new Estudante(nome, email, quarto);

            }

            Console.WriteLine();
            Console.WriteLine("Quarto ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quartoVetor[i] != null)
                {
                    Console.WriteLine("Quarto " + i + ": " + quartoVetor[i] );
                }
            }

        }
    }
}
