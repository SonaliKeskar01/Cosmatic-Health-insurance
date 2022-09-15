using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionsClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            a.Add(10);
            a.Add(30);
            a.Add(0);
            a.Add(null);
            Console.WriteLine("All Arrray Elements: ");
            foreach (var item in a)
            {
                Console.Write($"{item} ");
               
            }

            ICollection c = new ArrayList() { 1, 2 };
            a.AddRange(c);
            Console.WriteLine("\n All Arrray Elements after addrange: ");
            foreach (var item in a)
            {
                Console.Write($"{item} ");

            }
            a.Reverse();
            Console.WriteLine("\n All Arrray Elements after reverse: ");
            foreach (var item in a)
            {
                Console.Write($"{item} ");

            }
            a.Sort();
            Console.WriteLine("\n All Arrray Elements after sort: ");
            foreach (var item in a)
            {
                Console.Write($"{item} ");

            }
            Console.ReadLine();
        }
    }
}
