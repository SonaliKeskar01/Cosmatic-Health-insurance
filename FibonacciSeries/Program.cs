using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{//5. Write a program to print fibonacci series.=>fibonacci series means sum of privious two number
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;int b = 1;int c;

            Console.WriteLine("Fibnocci Series \n");
            for(int i=0;i<=10;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
