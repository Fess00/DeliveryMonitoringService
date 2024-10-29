using DeliveryMonitoringDataModel;
using System.Text.Json;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            var o = new Order();
            o.District = District.Kartfelt;
            o.Weight = 1.2;
            o.Id = Guid.NewGuid();
            orders.Add(o);
            orders.Add(o);
            orders.Add(o);
            var j = JsonSerializer.Serialize(orders);
            Console.WriteLine(j);
        }
    }
}
