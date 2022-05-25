

namespace Secao6_ComportamentoDeMemoriaArrayListas
{
    internal class Calculator
    {
        /*Aula 72*/
        // Solução ruim pois gera varios construtores com muitas sobrecarga
        /*        public static int Sum(int n1, int n2)
                {
                    return n1 + n2;
                }
                public static int Sum(int n1, int n2, int n3)
                {
                    return n1 + n2 + n3;
                }
                public static int Sum(int n1, int n2, int n3, int n4)
                {
                    return n1 + n2 + n3 + n4;
                }*/

        // Solução com vetor:
        // Porém verboso
        public static int Sum(int [] numbers)
        {
            int sum = 0;    
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static int SumWithParams(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }


        /*aula 73 - Modificador de parametros ref e out */

        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void TripleWithModificatorOut(int origin, out int result)
        {
            result = origin * 3;
        }



    }
}
