using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevrseStringWithoutRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String s = Console.ReadLine();

            Console.WriteLine();
            char[] ch = s.ToCharArray();
            string r = "";

            Console.WriteLine();
            Console.WriteLine("Reverse String");
            for (int i=s.Length-1;i>=0;i--)
            {
                r = r + ch[i];
                
            }
            Console.WriteLine(r);


            Console.ReadLine();
        }
    }
}
