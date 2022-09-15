using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = null;
            Console.WriteLine($"Please Enter Type: ");
            string CustomerType = Console.ReadLine().ToUpper();
            string choice = string.Empty;
            do {
                switch (CustomerType)
                {
                    case "SILVER":
                        c = new SilverCustomer();
                        break;

                    case "GOLD":
                        c = new GoldCustomer();
                        break;

                    case "PLATINUM":
                        c = new PlatinumCustomer();
                        break;


                    default:
                        c = new Customer();
                        break;
                }
                c.Print();
                Console.WriteLine("Do You Want To Continue...");
                choice = Console.ReadLine().ToUpper();

            } while (choice =="Y" || choice =="YES");

            Console.ReadLine();
        }
    }
    class Customer
    {
        public virtual void Print()
        {
            Console.WriteLine("Normal Customer..");
        }
    }

    class SilverCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Silver Customer..");
        }
    }
    class GoldCustomer:Customer
    {
        public override void Print()
        {
            Console.WriteLine("Gold Customer..");
        }
    }
    class PlatinumCustomer:Customer
    {
        public override void Print()
        {
            Console.WriteLine("Platinum Customer..");
        }
    }
}
