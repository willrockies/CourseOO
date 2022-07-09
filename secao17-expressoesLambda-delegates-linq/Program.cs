using System;
using System.Collections.Generic;
using System.Linq;
using secao17_expressoesLambda_delegates_linq.Entities;
using secao17_expressoesLambda_delegates_linq.Services;

namespace secao17_expressoesLambda_delegates_linq
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        delegate void BinaryNumericOperationMulticastDelegates(double n1, double n2);
        static void Main(string[] args)
        {
            /*Aula 228 - Uma Experiência com Comparison*/
            Console.WriteLine("Aula 228 - Uma Experiência com Comparison");
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = CompareProducts;
            //Comparison<Product> compLambda = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //list.Sort(comp);
            //list.Sort(compLambda);
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("----------");


            /*Aula 228 - Uma Experiência com Comparison*/
            Console.WriteLine("Aula 230 - Introdução a delegates");

            double a = 10;
            double b = 12;

            //double result = CalculationService.Sum(a, b);
            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation opMax = CalculationService.Max;


            double resultWithDelegate = op(a, b);
            double resultMaxWithDelegate = opMax(a, b);
            double resultMaxWithInvokeDelegate = opMax.Invoke(a, b);


            Console.WriteLine(resultWithDelegate);
            Console.WriteLine(resultMaxWithDelegate);
            Console.WriteLine(resultMaxWithInvokeDelegate);

            Console.WriteLine("----------");

            /*Aula 231 - MultiCast Delegates*/
            Console.WriteLine("Aula 231 - MulticastDelegate");

            double multicastDelegateA = 10;
            double multicastDelegateB = 12;


            BinaryNumericOperationMulticastDelegates opMulticastDelegate = CalculationMultiDelegateService.ShowSum;
            opMulticastDelegate += CalculationMultiDelegateService.ShowMax;

            opMulticastDelegate(multicastDelegateA, multicastDelegateB);

            Console.WriteLine("----------");


            /*Aula 232 - Predicates exemplo com removeAll*/
            Console.WriteLine("Aula 232 - Predicates exemplo com removeAll");
            List<Product> listPredicateDelegate = new List<Product>();
            listPredicateDelegate.Add(new Product("Tv", 900.00));
            listPredicateDelegate.Add(new Product("Mouse", 50.00));
            listPredicateDelegate.Add(new Product("Tablet", 350.50));
            listPredicateDelegate.Add(new Product("HD Case", 80.90));

            //listPredicateDelegate.RemoveAll(p => p.Price >= 100.00); //estrutura lambda 
            listPredicateDelegate.RemoveAll(ProductTest);
            foreach (Product product in listPredicateDelegate)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("----------");

            /*Aula 233 - Action (Exemplo com ForEach)*/
            Console.WriteLine("Aula 233 - Action (Exemplo com ForEach)");
            List<Product> listActionDelegate = new List<Product>();
            listActionDelegate.Add(new Product("Tv", 900.00));
            listActionDelegate.Add(new Product("Mouse", 50.00));
            listActionDelegate.Add(new Product("Tablet", 350.50));
            listActionDelegate.Add(new Product("HD Case", 80.90));

            //listActionDelegate.ForEach(UpdatePrice);
            //Action<Product> act = UpdatePrice;
            Action<Product> act = p => { p.Price += p.Price * 0.1; }; // expressão lambda esta entre chaves pq é um metodo void
            listActionDelegate.ForEach(act);
            foreach (Product p in listActionDelegate)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("----------");

            /*Aula 234 - Func (Exemplo com Select)*/
            Console.WriteLine("Aula 234 - Func (Exemplo com Select)");

            List<Product> listFuncDelegate = new List<Product>();
            listFuncDelegate.Add(new Product("Tv", 900.00));
            listFuncDelegate.Add(new Product("Mouse", 50.00));
            listFuncDelegate.Add(new Product("Tablet", 350.50));
            listFuncDelegate.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = NameToUpper;
            //Func<Product, string> func = p => p.Name.ToUpper();

            // List<string> result = listFuncDelegate.Select(NameToUpper).ToList();
            //List<string> result = listFuncDelegate.Select(func).ToList();
            List<string> result = listFuncDelegate.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------");


            /*Aula 235 - Introdução ao LINQ*/
            Console.WriteLine("Aula 235 - Introdução ao LINQ");

            //specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //define the query expression
            var resultQueryExpression = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //execute the query
            foreach (int x in resultQueryExpression)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------");

            /*Aula 237 & 238 - Demo LINQ e lambda*/
            Console.WriteLine("Aula 237 & 238 - Demo LINQ e lambda");
            LinqLambda.ExamplesLinqLambda();

            Console.WriteLine("----------");

            /*Aula 240 - Exercicio Resolvido*/
            Console.WriteLine("Aula 240 - Exercicio Resolvido");

            ExercicioResolvidoLinq.ProdutosAvaliado();
            
            Console.WriteLine("----------");

        }
        /*Aula 232 - Predicates exemplo com removeAll*/
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }

        /*Aula 233 - Action (Exemplo com ForEach)*/
        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        /*Aula 234 - Func (Exemplo com Select)*/
        static string NameToUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
