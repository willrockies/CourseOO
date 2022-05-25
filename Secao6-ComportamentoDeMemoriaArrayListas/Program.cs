using System;
using System.Collections.Generic;
using System.Globalization;
namespace Secao6_ComportamentoDeMemoriaArrayListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aula 66 - Tipos referência e tipos valor
            Console.WriteLine("aula 66");
            Point p;
            p.X = 20;
            p.Y = 20;
            Console.WriteLine(p);
            Console.WriteLine("______");
            /*string test;
            Console.WriteLine(test);*/

            // aula 67 - Desalocação de memória - garbage collector e escopo local
            Console.WriteLine("aula 67");
            Console.WriteLine("______");


            Console.WriteLine("aula 68");
            // aula 68 nullable
            //double x = null // erro
            Nullable<double> nullable = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y is null");
            }

            /*
             * Operador de coalescência nula
             * referencia: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-conditional-operator
            */
            double? coalescenciaNulaX = null;
            double? coalescenciaNulaY = 10;

            double a = coalescenciaNulaX ?? 5;
            double b = coalescenciaNulaY ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("______");

            Console.WriteLine("aula 69");
            /* int n  = int.Parse(Console.ReadLine());

             double[] vect = new double[n];

             for (int i = 0; i < n; i++)
             {
                 vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
             }

             double sum = 0.0;
             for (int i = 0; i < n; i++)
             {
                 sum += vect[i];
             }

             double avg = sum / n;

             Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("f2", CultureInfo.InvariantCulture));*/

            Console.WriteLine("______");

            Console.WriteLine("aula 70");
            /* int n = int.Parse(Console.ReadLine());

             Product[] vect = new Product[n];
             for (int i = 0; i < n; i++)
             {
                 string name = Console.ReadLine();
                 double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 vect[i] = new Product(name, price);
             }
             double sum = 0.0;
             for (int i = 0; i < n; i++)
             {
                 sum += vect[i].Price;
             }

             double avg = sum / n;

             Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));*/

            Console.WriteLine("______");

            /*aula 72 */

            Console.WriteLine("aula 72");
            // Solução com vetor é longo e verbose
            int result = Calculator.Sum(new int[] { 10, 20, 30 });
            Console.WriteLine(result);

            // Solução com parametro "params"
            int s1 = Calculator.SumWithParams(2, 3);
            int s2 = Calculator.SumWithParams(2, 4, 6);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("______");


            /*aula 73 */
            // A variável passada como parâmetro ref DEVE ter sido iniciada

            Console.WriteLine("aula 73");
            int aTriple = 10;
            Calculator.Triple(ref aTriple);
            Console.WriteLine("With Modificator ref {0}", aTriple);

            /*Modificador out -> guarda a variavel em outro ponto da memoria */
            // A variável passada como parâmetro out não precisa ter sido iniciada
            int aRef = 10;
            int outTriple;
            Calculator.TripleWithModificatorOut(aRef, out outTriple);
            Console.WriteLine("With modificator out {0}", outTriple);
            Console.WriteLine("______");


            /*aula 74 */

            Console.WriteLine("aula 74");
            int xBoxing = 20;
            Object obj = xBoxing;

            int yUnboxing = (int)obj;

            Console.WriteLine(yUnboxing);


            Console.WriteLine("______");

            /*aula 75*/

            Console.WriteLine("aula 75");

            string[] vectNames = new string[] { "Maria", "Alex", "Bob" };
            for (int i = 0; i < vectNames.Length; i++)
            {
                Console.WriteLine(vectNames[i]);
            }

            foreach (var objNames in vectNames)
            {
                Console.WriteLine(objNames);
            }

            Console.WriteLine("______");


            /*aula 76*/

            Console.WriteLine("aula 76");

            //List<string> list = new List<string>();

            //List<string> list2 = new List<string> { "Maria", "João"};

            Console.WriteLine("______");


            Console.WriteLine("aula 77");

            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");


            foreach (string objList in list)
            {
                Console.WriteLine(objList);
            }

            Console.WriteLine("List Count: " + list.Count);
            //string firstStringInitWith = list.Find(Test);
            string firstStringInitWith = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + firstStringInitWith);
            Console.WriteLine("______");

            string lastStringInitWith = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + lastStringInitWith);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("first position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> listEqualFiveChar = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------");
            foreach (string objEqualFiveChar in listEqualFiveChar)
            {
                Console.WriteLine("objEqualFiveChar: " + objEqualFiveChar);
            }

            list.Remove("Alex");
            //list.RemoveRange(2, 2);
            foreach (string objToRemoved in list)
            {
                Console.WriteLine("objToRemoved: " + objToRemoved);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------");
            foreach (string objRemovedWithM in list)
            {
                Console.WriteLine("objRemovedWithLetterM" + objRemovedWithM);
            }

            Console.WriteLine("______");


            Console.WriteLine("aula 79");

            /*Aula 79 - matriz*/
            double[,] matriz = new double[2, 3];
            Console.WriteLine(matriz.Length);
            Console.WriteLine(matriz.Rank);
            Console.WriteLine(matriz.GetLength(0));
            Console.WriteLine(matriz.GetLength(1));

            Console.WriteLine("______");

            Console.WriteLine("aula 80");

            /*Aula 80 - matriz*/

            int qtsRows = int.Parse(Console.ReadLine());
            int qtsCols = int.Parse(Console.ReadLine());
            int[,] mat = new int[qtsRows, qtsCols];

            for (int i = 0; i < qtsRows; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < qtsCols; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < qtsRows && i < qtsCols; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            int countNegativeNumbers = 0;
            for (int i = 0; i < qtsRows; i++)
            {

                for (int j = 0; j < qtsCols; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        countNegativeNumbers++;
                    }
                }
            }

            Console.WriteLine("Negative Numbers: {0}", countNegativeNumbers);

            Console.WriteLine("______");

        }

        /*static bool Test(string s)
        {
            return s[0] == 'A' || s[0] == 'a';
        }*/
    }
}
