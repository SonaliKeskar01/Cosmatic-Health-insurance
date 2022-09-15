using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface123
{
    class Program
    {
        static void Main(string[] args)
        {
            Icustomer c1 = new Customer();
            c1.m1();
           int i1= c1.print();
            Console.WriteLine(i1);
            Console.ReadLine();
        }
    }

    public interface Icustomer
    {
         int print();
        void m1();
    }

    public  interface IA:Icustomer
    {
        void m2();
    }
    public class Customer : IA
    {
        public void m1()
        {
            Console.WriteLine("m1");
        }

        public void m2()
        {
            throw new NotImplementedException();
        }

        public int print()
        {
            return 10 + 10;
        }
    }
}
