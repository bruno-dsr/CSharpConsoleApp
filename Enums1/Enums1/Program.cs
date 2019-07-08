using System;
using Enums1.Entities;
using Enums1.Entities.Enums;

namespace Enums1
{
    class Program
    {
        //EXERCICIO ENUMERAÇÕES
        static void Main(string[] args)
        {
            Order order = new Order { ID = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
            Console.WriteLine(order);

            string s1 = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(s1);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
