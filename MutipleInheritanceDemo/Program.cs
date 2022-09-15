using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutipleInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.PrintA();
            ab.PrintB();
            Console.ReadLine();
        }
    }

    interface IA
    {
        void PrintA();
    }
    class A:IA
    {
        public void PrintA()
        {
            Console.WriteLine("Class A");
        }
    }

    interface IB
    {
        void PrintB();
    }
    class B:IB
    {
        public void PrintB()
        {
            Console.WriteLine("Class B");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void PrintA()
        {
            a.PrintA();
        }

        public void PrintB()
        {
            b.PrintB();  
        }
    }
}
