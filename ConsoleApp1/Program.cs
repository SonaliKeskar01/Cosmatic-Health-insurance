using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //declare delegates
    delegate void Printdelegate();
    delegate string PrintBdelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of delegates
            // Printdelegate pd = PrintA;
            Program p = new Program();
           // p.PrintA();
           Printdelegate pd = p.PrintA;
           pd();

            PrintBdelegate pd1 = p.PrintB;
            string r=pd1();
            Console.WriteLine(r);
            Console.ReadLine();

        }

        //static method
        //public static void PrintA()
        //{
        //    Console.WriteLine("Hello ,Good Morning");
        //}

        //normal method
        public void PrintA()
        {
            Console.WriteLine("Hello ,Good Morning");
        }

        //Return type string
        public string PrintB()
        {
            return "good afternoon";
        }
    }
}
