using System;
using System.Collections.Generic;
using System.Text;

namespace secao17_expressoesLambda_delegates_linq.Services
{
    class CalculationMultiDelegateService
    {
        public static void ShowSum(double x, double y)
        {
            double result = x + y;
            Console.WriteLine(result);
        }
        public static void ShowMax(double x, double y)
        {
            double result = (x > y) ? x : y;
            Console.WriteLine(result);
        }
    }
}
