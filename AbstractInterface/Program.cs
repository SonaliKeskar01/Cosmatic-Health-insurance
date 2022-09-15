using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.Print();//A

            A a2 = new B();
            a2.Print();//B

            A a3 = new C();
            a3.Print();//C

            A a4 = new D();
            a4.Print();//D//B

            B b1 = new D();
            b1.Print();//D//B


            Console.ReadLine();
        }
    }

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }
    class B:A//single level inheritance
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }
    class C:A//Hierachical inheritance
    {
        public override void Print()
        {
            Console.WriteLine("C");
        }
    }
    //class D:B//Multilevel inheritance D:B:A
    //{
    //    //public override void Print()
    //    //{
    //    //    Console.WriteLine("D");
    //    //}

    //}//Output :B

    class D : B,C//Multiple inheritance //does not suppourt/compile time error
    {
        //public override void Print()
        //{
        //    Console.WriteLine("D");
        //}

    }//Output :B
}
