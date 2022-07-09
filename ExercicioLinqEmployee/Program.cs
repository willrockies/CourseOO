using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ExercicioLinqEmployee.Entities;
using System.Globalization;
namespace ExercicioLinqEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    string name = line[0];
                    string email = line[1];
                    double salaries = double.Parse(line[2], CultureInfo.InvariantCulture);

                    Employee emp = new Employee(name, email, salaries);
                    list.Add(emp);
                }
            }

            var selectEmployessEmail = list.Where(emp => emp.Salary > salary).OrderBy(emp => emp.Email).Select(emp => emp.Email);

            var salaryWhichStartsWithM = list.Where(emp => emp.Name[0] == 'M').Sum(emp => emp.Salary);

            Console.WriteLine("Email of people whose salary is more than: " + salary.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string item in selectEmployessEmail)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + salaryWhichStartsWithM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
