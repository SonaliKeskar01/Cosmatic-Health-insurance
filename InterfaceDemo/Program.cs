using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.PrintA();//IA:=>PrintA()
            ab.PrintB();//IB:=>PrintB()
            ab.PrintC();//Printc()

            //it gives complile time error
            //we cannot  directly call explicite implemented interface  members

            // ab.Print();//IA
            //so we need here typecast

            ((IA)ab).Print();
            ((IC)ab).Print();


            IA a = new AB();
            a.PrintA();
            a.PrintB();
           
            a.Print();

            Console.ReadLine();
        }
    }

    interface IA:IB//interface can inherit another interface
    {
        void PrintA();
        void Print();
    }

    interface IB
    {
        void PrintB();
    }

    interface IC
    {
        void PrintC();
        void Print();
    }
    class AB : IA,IC
    {
       void IA.Print()//Explicite implement interface
        {
            Console.WriteLine("IA ");
        }
        void IC.Print()//Explicite implement interface
        {
            Console.WriteLine("IC ");
        }
        public void PrintA()
        {
            Console.WriteLine("PrintA() ");
        }

        public void PrintB()
        {
            Console.WriteLine("PrintB() ");
        }

        public void PrintC()
        {
            Console.WriteLine("PrintC() ");
        }
    }
}
