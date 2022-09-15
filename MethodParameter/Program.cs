using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            printSum(new int[] {2,2,2});

            printSum(null);

            printSum(new int[] { 0 });

            printSum(1, 2, 3,4);//comma separated values//using params 

            printSum();//no arguments -optional//using params
            
            Console.ReadLine();
        }

        //static void printSum(params int[]a)//possible
        // static void printSum(string name,params int[] a)//possible
        // static void printSum(params int[] a,string name)//not possible
        //static void printSum(params int[] a,params int[]b)//not possible
        static void printSum(params int[] a)//possible
        {
            int sum = 0;
            if(a!=null && a.Length>0)
            {
                for(int i=0;i<a.Length;i++)
                {
                    sum += a[i];
                }
                Console.WriteLine($"Sum of array:{sum}");
            }
            else
            {
                Console.WriteLine("elements are not availbale");
            }
        }

        static void reverseString(string message)
        {
            string[]words =
        }
        
         }
}
