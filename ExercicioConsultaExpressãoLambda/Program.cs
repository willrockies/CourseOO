using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ExercicioConsultaExpressaoLambda.Entities;
using System.Globalization;

namespace ExercicioConsultaExpressaoLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salaryValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> emp = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    emp.Add(new Employee(name, email, salary));
                }
            }

            var emails = emp
                .Where(e => e.Salary > salaryValue)
                .OrderBy(e => e.Email)
                .Select(e => e.Email);

            var sum = emp
                .Where(e => e.Name[0] == 'M')
                .Sum(e => e.Salary);

            Console.WriteLine("Email of people whose salary is more than:", salaryValue);
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("Sum of salary of people whose name starts with 'M':" + sum.ToString("F2", CultureInfo.InvariantCulture));

            
            

        }
    }
}
