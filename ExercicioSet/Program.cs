using System;
using System.IO;
using System.Collections.Generic;
using ExercicioSet.Entities;
namespace ExercicioSet
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream) 
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                        Console.WriteLine(name, instant);
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }

            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
