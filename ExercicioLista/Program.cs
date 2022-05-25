using System;
using System.Collections.Generic;

namespace ExercicioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");
            int NumberEmployeeRegistered = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for(int i = 0; i < NumberEmployeeRegistered; i++)
            {
                Console.WriteLine("Employee# {0}", i + 1, ":");
                Console.Write("ID: ");
                int id  = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employeeList.Add(new Employee(id, name, salary));

            }

            
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employeeSearch  = employeeList.Find(x => x.Id == searchId);

            if(employeeSearch != null)
            {
                Console.Write("Enter the percentage: ");
                double valueToIncreaseSalary = double.Parse(Console.ReadLine());
                employeeSearch.IncreaseSalary(valueToIncreaseSalary);

            }

            foreach(Employee employee in employeeList)
            {
                Console.WriteLine("Update list of employees: {0}", employee);
            }
        }
    }
}
