using System;
using System.IO;
using System.Collections.Generic;
namespace ExercicioPropostoDictonaryVotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> dictionaryCandidates = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] votesCandidates = sr.ReadLine().Split(',');
                        string name = votesCandidates[0];
                        int votes = int.Parse(votesCandidates[1]);

                        if (dictionaryCandidates.ContainsKey(name))
                        {

                            dictionaryCandidates[name] += votes;
                        }
                        else
                        {
                            dictionaryCandidates[name] = votes;
                        }

                    }

                    foreach (KeyValuePair<string, int> item in dictionaryCandidates)
                    {
                        Console.WriteLine(item.Key + ":" + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
