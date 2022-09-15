using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberTill
{
    class Program
    {//4. Write a program to print all prime numbers till target. (take target from user) 

        static void Main()
        {

            #region prime 1 to 100
            //for(int i=1;i<=100;i++)
            //{
            //    int temp = 0;
            //    for (int j=2;j<=100-1;j++)
            //    {
            //        if(i %j==0)
            //        {
            //            temp = temp + 1;
            //        }
            //    }

            //    if(temp==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        temp = 0;
            //    }
            //}
            #endregion
            Console.WriteLine("Enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number1: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int temp = 0;int count = 0;
            Console.WriteLine();

            Console.WriteLine("Prime Number\n");
            for (int i=Number;i<=Number1;i++)
            {
                for(int j=2;j<=i-1;j++)
                { 
                    if(i%j==0)
                    {
                        temp = temp + 1;
                    }
                    
                }

                if(temp==0)
                {
                    Console.WriteLine(i);
                   
                }
                else
                {
                    temp = 0;
                }
               
            }
            Console.ReadLine();
            
        }
    }
}
