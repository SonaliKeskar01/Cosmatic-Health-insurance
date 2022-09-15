using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { RollNumber = 1, Name = "sonali", Gender = "Female" };
            Student s2 = new Student() { RollNumber = 2, Name = "Yash", Gender = "Male" };
            Student s3 = new Student() { RollNumber = 3, Name = "Swara", Gender = "Female" };
            Student s4 = new Student() { RollNumber = 4, Name = "Vishal", Gender = "Male" };
            Student s5 = new Student() { RollNumber = 5, Name = "Indrajit", Gender = "Male" };

            ArrayList a = new ArrayList() { s1, s2, s3, s4, s5 };
            Console.WriteLine("Arraylist :\n");
            foreach (Student item in a)
            {
                Console.WriteLine($"{item.RollNumber}- {item.Name} - {item.Gender}");
            }

            Hashtable h = new Hashtable() ;
            h.Add(s1.RollNumber, s1);

            ///DictionaryEntry type mandatory to access key and value 
            Console.WriteLine("\n HashTable: ");
            foreach (DictionaryEntry item in h)
            {
                Student s = (Student)item.Value;//why??becuse value type is object
                Console.WriteLine($"{item.Key} -{s.Name}");
            }
            Console.ReadLine();
        }
    }
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}
