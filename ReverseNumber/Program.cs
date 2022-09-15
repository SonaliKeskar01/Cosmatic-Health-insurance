using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int rem, result = 0;
            Console.WriteLine("Reverse Number \n");
            while (Number!=0)
            {
                rem = Number % 10;
                result = result * 10 + rem;
                Number = Number / 10;

            }
            Console.WriteLine(result);

           
            Console.ReadLine();
        }
    }
}
