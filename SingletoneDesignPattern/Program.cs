using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Singletone s1 = Singletone.Instance();
            Singletone s2 = Singletone.Instance();
            Singletone s3 = Singletone.Instance();

            if(s1==s2)
            {
                Console.WriteLine("s1 and s2 are equal");
            }
            else
            {
                Console.WriteLine("s1 and s2 are  not equal");
            }
            
             if(s2==s3)
            {
                Console.WriteLine("s2 and s3 are equal");
            }
            else
            {
                Console.WriteLine("s2 and s3 are  not equal");
            }

            Singletone s4 = Singletone.Instance();
            if(s4==null)
            {
                Console.WriteLine("S4 obj is not allowed");
            }
            Console.ReadLine();
        }
    }

    
    public class Singletone
    {
      static  Singletone _obj=null;
        static int _counter = 1;
        //private Singletone()
        //{

        //}

        public static Singletone Instance()
        {
            
            if(_counter<=3)
            {
                _obj = new Singletone();
                _counter++;
                return _obj;
            }
            else 
            {
                _obj = null;
                return _obj;
            }
            
        }

    }
}
