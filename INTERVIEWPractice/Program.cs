using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERVIEWPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = "Good Morning";
            string b = a as string;
            Console.WriteLine(b);

            //Ternary Operator-It is Simplified ways to write if else
            int input = 11;


          string r= ( input == 10)? "TEN" : "NOT TEN";

            Console.WriteLine($"\n Ternary oerator: {r}");

            //Nullable Type:
            string s = null;//it allows--it is nullable type
            //int i = null;//not allowed -because int is non nullable type

            int ? i = null;//allow=>nullable type

            //Convert non nullable to nullable-possible
            int? i1 = 10;
            int b1;
                b1= (int)i1;//it allow
            Console.WriteLine($"After Non Nullable to nullable: {b1}");

            //Convert non nullable to nullable-not opssible possible-gives exception
            //int? i2 = null;
            //int b2;
            //b2 = (int)i2;//it allow
            //Console.WriteLine($"After Non Nullable to nullable: {b2}");


//Convert Nullable to non nullable-1st way
            if(i1==null)
            {
                b1 = 0;
            }
            else
            {
                b1 = (int)i1;
            }

            Console.WriteLine($"After Nullable to non nullable: {b1}");

            //Convert Nullable to non nullable-2nd way
            //Nullable colesing operator

            int? oldage = null;
           int  newage = oldage ?? 0;

            Console.WriteLine(newage);

            Console.ReadLine();
        }
    }
}
