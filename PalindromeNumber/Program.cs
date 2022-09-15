using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int rem, result = 0;
            int temp = Number;
            Console.WriteLine("Reverse Number \n");
            while (Number != 0)
            {
                rem = Number % 10;
                result = result * 10 + rem;
                Number = Number / 10;

            }
            Console.WriteLine(result);
           if(result==temp)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not aPalindrome");
            }
            Console.ReadLine();
        }
    }
}
