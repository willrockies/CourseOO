using System;
using System.Collections.Generic;
using System.Globalization;
using secao15_generics_set_dictionary.Service;
using secao15_generics_set_dictionary.Entities;

namespace secao15_generics_set_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aula 213 - generics parte 1 */
            Console.WriteLine("Aula 213 - generics parte 1");
            /* 
             PrintService printService = new PrintService();
             Console.WriteLine("How many values? ");
             int n = int.Parse(Console.ReadLine());

             for (int i = 0; i < n; i++)
             {
                 int x = int.Parse(Console.ReadLine());
                 printService.AddValue(x);

             }

             printService.Print();
             Console.WriteLine("First: " + printService.First());*/

            Console.WriteLine("-----");
            Console.WriteLine("Aula 214 - generics parte 2");
            //PrintService printService = new PrintService();
            // usando generics eu posso tipa o valor do meu objeto conforme a necessidade
            /*PrintService<int> printService = new PrintService<int>();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                //string x = Console.ReadLine();
                printService.AddValue(x);
            }
            //Utilizando generics o compilador aponta o erro
            //int a = (int)printService.First(); // problema ter que fazer o casting e complilador não pega, 
            int a = printService.First();
            int b = a + 2;
            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
            Console.WriteLine("-----");*/

            /*Aula 215 - Retrições de generics*/
            Console.WriteLine("Aula 215 - Retrições de generics");

            List<Product> list = new List<Product>();
            /* Console.WriteLine("Enter number of values");
             int nValues = int.Parse(Console.ReadLine());
             for (int i = 0; i < nValues; i++)
             {
                 string[] vect = Console.ReadLine().Split(',');
                 string name = vect[0];
                 double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                 list.Add(new Product(name, price));

             }

             CalculationService calculationService = new CalculationService();
             Product max = calculationService.Max(list);
             Console.WriteLine("Max: ");
             Console.WriteLine(max); 
 */

            Console.WriteLine("-----");
            /*Aula 216 - GetHashCode e Equals*/
            Console.WriteLine("Aula 216 - GetHashCode e Equals");

            string a = "Maria";
            string b = "Alex";
            //Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Client c1 = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client c2 = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine("Email é igual: " + c1.Equals(c2));
            Console.WriteLine("Email hashCode:" + c1.GetHashCode());
            Console.WriteLine("Email hashCode:" + c2.GetHashCode());


            Console.WriteLine("-----");

            /*Aula 217 - Conjuntos: HashSet e SortedSet parte 1*/
            Console.WriteLine("Aula 217 - Conjuntos: HashSet e SortedSet parte 1");

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine("O notebook esta no conjunto: " + set.Contains("Notebook"));
            Console.WriteLine("O Computer esta no conjunto: " + set.Contains("Computer"));

            foreach (string item in set)
            {
                Console.WriteLine("produto: " + item);
            }

            Console.WriteLine("-----");

            Console.WriteLine("Aula 218 - Conjuntos: HashSet e SortedSet parte 2");
            SortedSet<int> collectionSortedSetA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> collectionSortedSetB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //PrintCollection(collectionA);

            // Union 
            SortedSet<int> collectionSortedSetC = new SortedSet<int>(collectionSortedSetA);
            collectionSortedSetC.UnionWith(collectionSortedSetB);

            PrintCollection(collectionSortedSetC);

            // intersection
            SortedSet<int> collectionSortedSetD = new SortedSet<int>(collectionSortedSetA);
            collectionSortedSetD.IntersectWith(collectionSortedSetB);

            PrintCollection(collectionSortedSetD);

            //difference
            SortedSet<int> collectionSortedSetE = new SortedSet<int>(collectionSortedSetA);
            collectionSortedSetE.ExceptWith(collectionSortedSetB);

            PrintCollection(collectionSortedSetE);

            Console.WriteLine("-----");


            Console.WriteLine("Aula 219 - Como coleções hash comparam igualdade");

            HashSet<Product> productHashSet = new HashSet<Product>();

            productHashSet.Add(new Product("TV", 900.0));
            productHashSet.Add(new Product("Notebook", 1200.0));

            HashSet<Point> pointHashSet = new HashSet<Point>();
            pointHashSet.Add(new Point(3, 4));
            pointHashSet.Add(new Point(5, 10));


            Product prodRefencia = new Product("Notebook", 1200.0);
            Console.WriteLine(productHashSet.Contains(prodRefencia));

            Point pointRef = new Point(5, 10);
            Console.WriteLine(pointHashSet.Contains(pointRef));

            Console.WriteLine("-----");

            Console.WriteLine("Aula 222 - Dictionary & sorted dictionary");
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";

            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");
            Console.WriteLine("Phone Number: " + cookies["phone"]);



            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All cookies:");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // funciona tambem com var e menos verboso
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine("-----");

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
