using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Student
    {
        public string FirstName;
        public string LastName;
        // public static string CompanyName="V#";
        public static string CompanyName;
        public Student(string FirstName,string LastName)
        {
            Console.WriteLine(" INSTANCE Student()");
            this.FirstName = FirstName;
            this.LastName = LastName;
           
        }
        static Student()
        {
            Console.WriteLine(" static Student()");
            CompanyName = "V#";
        }
        public void print()
        {
            Console.WriteLine($"FullName: {FirstName} {LastName} - {CompanyName}");
        }
    }
}
