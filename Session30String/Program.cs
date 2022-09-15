using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session30String
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            //have we used customername or orders anywhere here ??No
            //then why we are loading that data??
            Console.WriteLine($"{c.CustomerName.Value}");

            foreach (var item in c.orders.Value)
            {
                Console.WriteLine($"{item.OrderId} - {item.OrderName}");
            }
            Console.ReadLine();
        }
    }
    class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }

    }

    class Customer
    {
        public Lazy<string> CustomerName { get; set; }
        public Lazy<List<Order>> orders;//has a relationship association

        public Customer()
        {
            CustomerName =new Lazy<string>(delegate()
            {
                return "sonali";
            });
            Func<List<Order>> d2 = GetOrders;
            orders = new Lazy<List<Order>>(d2);
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(){OrderId=1,OrderName="TV"},
                new Order(){OrderId=2,OrderName="Laptop"},
                new Order(){OrderId=3,OrderName="Mobile"},
            };
            return orders;
        }
    }
   
}
