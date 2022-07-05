using System;
using System.Collections.Generic;

namespace ExercicioPropostoConjuntosCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for Course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int course = int.Parse(Console.ReadLine());
                courseA.Add(course);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int course = int.Parse(Console.ReadLine());
                courseB.Add(course);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int course = int.Parse(Console.ReadLine());
                courseC.Add(course);
            }

            HashSet<int> courses = new HashSet<int>(courseA);
            courses.UnionWith(courseB);
            courses.UnionWith(courseC);
            Console.WriteLine("TotalStudents: " + courses.Count);
        }
    }
}
