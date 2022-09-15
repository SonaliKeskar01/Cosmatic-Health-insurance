using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateDemo
{
    //declare delegate
    delegate void PrintDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            //multicast delegates

            //first way:using compound assignment operator += and -=

            //To create instance or object or delegates
            PrintDelegate pd = PrintA;//first way--Register method
            pd += PrintB;
            pd += PrintC;
            pd();//to call or invoke

            Console.WriteLine("\n De-register method-using compund operator");
            //De-register method from delegates
            pd -= PrintC;
            pd();//ans:PrinTA,PrintB

            Console.WriteLine();

            //2nd way-using + or - operator
            PrintDelegate pd1 = PrintA;
            PrintDelegate pd2 = PrintB;
            PrintDelegate pd3 = PrintC;

            PrintDelegate multicast = pd1 + pd2 + pd3;//it means register methods
            multicast();//to call or invoke

            //how to de rgister a method from delegates??

            Console.WriteLine("\n De Register methods from delegates");
            PrintDelegate dergister = pd1 + pd2 + pd3-pd1;
            dergister();//to call or invoke//ans:printB,PrintC

            Console.ReadLine();
        }
        static void PrintA()
        {
            Console.WriteLine("PrintA()");
        }

        static void PrintB()
        {
            Console.WriteLine("PrintB()");
        }
        static void PrintC()
        {
            Console.WriteLine("PrintC()");
        }
    }
}
