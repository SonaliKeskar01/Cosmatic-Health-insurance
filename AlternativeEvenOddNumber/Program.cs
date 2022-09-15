using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeEvenOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] a = new int[] { 2,4,5,3,7,9,8,10};

            int evenindex = 0;
            int oddindex = 1;

            int[]array=new int[a.Length];


            Console.WriteLine("Given array elements:\n  ");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write($" {a[i]} ");
            }


            Console.WriteLine();
            Console.WriteLine("Task 1 ans:\n  ");
            for (int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    array[evenindex] = a[i];
                   
                    evenindex += 2;
                   

                }
                if (a[i] % 2 == 1)
                {
                    array[oddindex] = a[i];
                    
                    oddindex += 2;
                    
                }
            }

            for(int i=0;i<a.Length;i++)
            {
                a[i]=array[i] ;
                Console.Write($" {a[i]} ");
            }
            
            Console.ReadLine();
        }
    }
}
