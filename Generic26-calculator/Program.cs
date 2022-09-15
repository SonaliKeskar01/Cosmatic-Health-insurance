using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic26_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            bool b;
            b = c1.AreEqual(10, 10);
            Console.WriteLine(b);

            b = c1.AreEqual(10, 20);
            Console.WriteLine(b);

            b = c1.AreEqual("A", "B");
            Console.WriteLine(b);

            b = c1.AreEqual(10.0f, 10.0f);
            Console.WriteLine(b);

            b = c1.AreEqual<bool>(true, true);//generic -1
                  Console.WriteLine(b);

            c1.Sample<int, string>(10, "A");//generic-2

            c1.SampleA<int, string>("HUB", 100, "B");//generic-3
            int res=c1.SampleB<string, int>("C", 67);//4
            Console.WriteLine(res);

            CalculatorV<int> v1 = new CalculatorV<int>();
            v1.Add(10, 10);
            v1.Sub(100, 50);
            v1.Mul(10, 3);
            v1.Div(500, 2);

            //Not possible becuse v1 object datatype int..so we need to create neww object for float datatype
            //v1.Add(10.0f, 10.80f);
            //v1.Sub(100.2f, 50.4f);
            //v1.Mul(10.3f, 3.4f);
            //v1.Div(500.4f, 2.5f);

            CalculatorV<float> v2 = new CalculatorV<float>();
            v2.Add(10.0f, 10.80f);
            v2.Sub(100.2f, 50.4f);
            v2.Mul(10.3f, 3.4f);
            v2.Div(500.4f, 2.5f);

            Console.ReadLine();
        }
    }

    public class Calculator
    {
        //i will work with only int datatype
        //public bool AreEqual(int a, int b)
        //{
        //    return a.Equals(b);
        //}

        //but generic helps to solve problem

        public bool AreEqual<T>(T a, T b)//1
        {
            return a.Equals(b);
        }

        ////we want write multiple different type parameter-it is possible-cause generic
        public void Sample<T1,T2>(T1 a,T2 b)//2
        {
           //Logic
        }

        public void SampleA<T1, T2>(string partname,T1 a, T2 b)//3
        {
            //Logic
        }

        public TOut SampleB<TIn, TOut>(TIn a, TOut b)
        {
            //Logic
           dynamic d= a.ToString().Length;
           
            return d;
        }

    }

    //Create class generic

    public class CalculatorV<T>
    {
        public void Add(T a,T b)
        {
            //Console.WriteLine($"{a + b}");//Not possible becuse Datatype that time dynamic keyword helps
            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine($"Addition of: {n1 + n2}");

        }

        public void Sub(T a, T b)
        {
           
            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine($"Subtraction of: {n1 - n2}");

        }

        public void Mul(T a, T b)
        {

            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine($"Multiplication of: {n1 * n2}");

        }

        public void Div(T a, T b)
        {

            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine($"Division of: {n1 / n2}");

        }

    }

    interface IA<T>
    {
        void add(T a, T b);
    }

    class A<T> : IA<T>
    {
        public void add(T a, T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine($"{n1+n2}");
        }
    }

}
