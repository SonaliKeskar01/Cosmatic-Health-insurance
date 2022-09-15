using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session26_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            bool b;
            b=c1.AreEqual(10,10);
            Console.WriteLine(b);

            b = c1.AreEqual(10, 20);
            Console.WriteLine(b);

            b = c1.AreEqual("A", "B");
            Console.WriteLine(b);

            b = c1.AreEqual(10.0f, 10.0f);
            Console.WriteLine(b);

            int i = 10;
            object o = i;//here boxing-but interview said there is not boxing that time use 2nd way

            //2nd way
            object o1 = new object();
            o1 = i;//boxing -use hint


            Console.ReadLine();
        }
    }

    public class Calculator
    {
        //public bool AreEqual(int a,int b)
        //{
        //    return a.Equals(b);
        //}

        //public bool AreEqual(string a, string b)
        //{
        //    return a.Equals(b);
        //}

        //public bool AreEqual(float a, float b)
        //{
        //    return a.Equals(b);
        //}

        //Object Keyword:object is base type of all dot net classes

        public bool AreEqual(object a,object b)
        {
            return a.Equals(b);
        }
    }
}
