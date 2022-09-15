using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session28_1
{//declare delegates
    delegate string PrintDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //instance
            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;

            //by default,multicast delegate it will reurn last returned value from last method 
           
            //string result=pd();
            //Console.WriteLine($"{result}");//ans:C

            //we want to return all method then delegates have one method getinvocationlist()

           Delegate[] multicast= pd.GetInvocationList();
            for (int i = 0; i <multicast.Length; i++)
            {
                try
                {
                    string res = multicast[i].DynamicInvoke().ToString();
                    Console.WriteLine(res);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
            
            Console.ReadLine();
        }
        static string PrintA()
        {
            return "A";
        }

        static string PrintB()
        {
            int i = 10, j = 0;
            int div = i / j;
            return "B";
        }

        static string PrintC()
        {
            return "C";
        }
    }
}
