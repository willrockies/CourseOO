using System;
using secao10_herancapolimorfismo.Entities;
using System.Collections.Generic;
using secao10_herancapolimorfismo.Entitieshape;
using secao10_herancapolimorfismo.Entitieshape.Enums;
using System.Globalization;

namespace secao10_herancapolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aula 136 - Upcasting e downcasting*/
            Console.WriteLine("Aula 136 - Upcasting e downcasting");
            /*
            Account acc = new Account(1001, "Alex", 0.0);
            BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            BussinessAccount acc4 = (BussinessAccount)acc2;
            acc4.Loan(100.0);

            //BussinessAccount acc5 = (BussinessAccount)acc3;
            if (acc3 is BussinessAccount)
            {
                //BussinessAccount acc5 = (BussinessAccount)acc3;
                BussinessAccount acc5 = acc3 as BussinessAccount; //sintaxe alternativa para downcasting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }*/

            Console.WriteLine("------------");

            /*Aula 137 - Sobreposição , palavras virtual, override e base*/
            Console.WriteLine("Aula 137 - Sobreposição , palavras virtual, override e base");

            //Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            //acc1.Withdrawn(10.0);
            acc2.Withdrawn(10.0);

            //Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine("------------");

            Console.WriteLine("Aula 143 - Classes Abstratas");

            List<Account> list = new List<Account>();
            list.Add(new BussinessAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new SavingsAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new BussinessAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new SavingsAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account account in list)
            {
                account.Withdrawn(10.0);
            }
            foreach (Account account in list)
            {
                Console.WriteLine("Updated balance for account " +
                    +account.Number
                    + ": "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("------------");

            Console.WriteLine("Aula 143 - Métodos Abstratos");

            List<Shape> shapeList = new List<Shape>();

            Console.Write("Enter the of Shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapeList.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    shapeList.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in shapeList)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("------------");
        }

    }
}
