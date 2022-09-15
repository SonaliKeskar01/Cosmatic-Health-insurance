using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.name);
            Console.ReadLine();
        } 
    }
   class Student
    {
        public static string name;
      static Student()
        {
            name = "vishal";
        }
    }
}
