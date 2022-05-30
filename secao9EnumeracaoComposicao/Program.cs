using secao9EnumeracaoComposicao.Entities;
using secao9EnumeracaoComposicao.Entities.Enums;
using System;

namespace secao9EnumeracaoComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aula 126*/

            Console.WriteLine("Aula 126");
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };
            Console.WriteLine(order);

            // Conversões
            OrderStatus osInt = (OrderStatus)2;
            Console.WriteLine(osInt);
            int os1 = (int)OrderStatus.Processing;
            Console.WriteLine("convertido para inteiro:" + os1);

            // enum - string
            string osString = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(osString);

            OrderStatus osEnum = Enum.Parse<OrderStatus>("Delivered");
            //OrderStatus osEnumNonExist = Enum.Parse<OrderStatus>("Cancelled");
            Console.WriteLine(osEnum);

            Console.WriteLine("-------------------------------");

        }
    }
}
