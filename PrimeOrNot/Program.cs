using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            for(int i=2;i<=Number-1;i++)
            {
                if(Number%i==0)
                {
                    temp = temp + 1;
                }
            }

            if(temp==0)
            {
                Console.WriteLine($"Prime Number: {Number}");
            }
            else 
            {
                Console.WriteLine($"Not Prime Number: {Number}");
            }
           
            Console.ReadLine();
        }
    }
}
