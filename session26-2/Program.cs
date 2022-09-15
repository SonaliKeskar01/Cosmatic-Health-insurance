using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session26_2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.Print("Indrajit");

            B b1 = new B();
            b1.Print("Vishal");

            Console.WriteLine();

            IA a2 = new A();
            a2.Print("Sonali");

            IA b2 = new B();
            b2.Print("Vaibhav");
            Console.ReadLine();
        }
    }

    public static class Helper
    {
        

        public static void Print(this IA a,string msg)
        {
            Console.WriteLine($"{a.GetType().Name}");
            Console.WriteLine("Hello a");
        }
    }

    public interface IA { }
    public class A:IA {  }

    public class B:IA{ }
}
