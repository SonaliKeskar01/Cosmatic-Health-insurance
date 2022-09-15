using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    class Program
    {//6. Write a program to find if a given string is palindrome. 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String \n");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            Console.WriteLine();
            String r = "";
           for(int i=ch.Length-1;i>=0;i--)
            {
                r = r + ch[i];
            }
            // Console.WriteLine(r);
            Console.WriteLine();
           // if (r==s)or
           if(s.Equals(r))
            {
                Console.WriteLine("String Palindrome");
            }
            else
            {
                Console.WriteLine("String Not Palindrome");
            }
            Console.ReadLine();

        }
    }
}
