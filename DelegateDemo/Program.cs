using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {//Step 1:Declare Delegate
        //delegate signature and method signature should be same
        delegate void PrintDelegate();//method 1,2
        delegate void PrintDelegate1(string msg);//method 3

        static void Main(string[] args)
        {
            //Print();
            //Step 2-To create instance or object or delegates
            //two ways to create instance or delegates or object
            //PrintDelegate pd = new PrintDelegate(Print);// first way

            PrintDelegate pd1 = Print;//2nd way//Print()-singlecast delegate
            //Step-3-To call delegate
           // pd();
            pd1();

            //****call 2nd method
            //  PrintDelegate pd2 = PrintA;//non static field we need create instance of class after that crete instance delegate
            //so we need to create fist object of program class;

            Program p = new Program();//PrintA()//singlecast delegates
            PrintDelegate pd3 = p.PrintA;//it is possible
            //to call delegates
            pd3();





            //***3rd method static with parameter 
            // PrintDelegate pd4 = new PrintDelegate(PrintB); //Not possible-
            //beacuse delegate signature and method signature are different so we need to create seprate delegate for
            //this method

            PrintDelegate1 pd5 = new PrintDelegate1(PrintB);//Type safe//PtintB()//singlecast delegates
            pd5("***Good Morning***");

            Console.ReadLine();
        }
        //we want to call/invoke this method using delegates
        static void Print()
        {
            Console.WriteLine("Print()");
        }
        //we can crreate another method 
        void PrintA()
        {
            Console.WriteLine("PrintA()");
        }

        //Too create another method with parameter and static also
       static void PrintB(string msg)
        {
            Console.WriteLine($"PrintB() {msg}");
        }

        
    }
}
