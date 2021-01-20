using System;

namespace ExContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());


            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(numero, titular, depositoInicial);
                contaBancaria.Deposito(depositoInicial);
                Console.WriteLine(contaBancaria);

            }
            else
            {
                contaBancaria = new ContaBancaria(numero, titular);
                Console.WriteLine(contaBancaria);
            }

            Console.WriteLine();

            /* Entrada de deposito */
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            contaBancaria.Deposito(quantia);
            Console.WriteLine("Dados da conta Atualizado: ");
            Console.WriteLine(contaBancaria);

            /* entrada de Saque */
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            contaBancaria.Saque(saque);
            Console.Write("Dados da conta Atualizado: ");
            Console.WriteLine(contaBancaria);
        }
    }
}
