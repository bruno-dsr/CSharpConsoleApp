using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Enums_Composition.Entities.Enums;

namespace Enums_Composition.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Itens)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Resumo de Pedido:");
            builder.AppendLine("Data: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.AppendLine("Status: " + Status.ToString());
            builder.AppendLine($"Cliente: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            builder.AppendLine("Produtos do pedido:");
            foreach(OrderItem item in Itens)
            {
                builder.AppendLine(item.ToString());
            }
            builder.AppendLine("Valor total: R$ " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return builder.ToString();
        }
    }
}
