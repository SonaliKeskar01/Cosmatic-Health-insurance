using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInstituteLibrary;
    namespace GetterSetterProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { RollNumber = 1, Name = "Sonali", Course = "Dot Net" };
            Student s2 = new Student() { RollNumber = 2, Name = "Indrajit", Course = "Paython" };
            Student s3 = new Student() { RollNumber = 3, Name = "Yash", Course = "Testing" };
            Student s4 = new Student() { RollNumber = 4, Name = "Riyansh", Course = "Dot Net" };
            Student s5 = new Student() { RollNumber = 5, Name = "Swara", Course = "Dot Net" };

            Student[] s = new Student[] { s1, s2, s3, s4, s5 };
            Institute CDAC = new Institute(s);
            CDAC.Name = "CDAC";
            CDAC.PrintDetails();

            Console.ReadLine();
        }
    }
   

    
        
    }


namespace MyInstituteLibrary
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

    }

    public class Institute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Student[] _Students;

        public Institute(Student[] student)
        {
            _Students = student;
        }

        public void PrintDetails()
        {
            if (_Students != null && _Students.Length > 0)
            {
                for (int i = 0; i < _Students.Length; i++)
                {
                    Console.WriteLine($"RollNumber:{_Students[i].RollNumber}\nName:{_Students[i].Name}\n" +
                        $"Course:{_Students[i].Course}");
                }
            }
            else
            {
                Console.WriteLine("No students in Institute..");
            }
        }
    }
}
