using System;
using System.IO;
using System.Collections.Generic;
namespace ExercicioDicionario
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] votesCandidates = sr.ReadLine().Split(',');
                        string candidate = votesCandidates[0];
                        int votes = int.Parse(votesCandidates[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + " " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message); ;
            }
        }
    }
}
