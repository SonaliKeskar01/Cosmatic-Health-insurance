using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            string IsContinue = string.Empty;
            do
            {
                Console.WriteLine("Please Enter your choice: ");
                Console.WriteLine("\n 0-featch student count" +
                    "\n 1- Get All Student " +
                    "\n 2-Get All Student ID: " +
                    "\n3 3-Insert Student:" +
                    "\n 4-Get All Courses and Student " +
                    "\n 5-Insert student and take rows affected..");

                int choice;
               
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    
                    switch (choice)
                    {
                        case 0:
                            PrintStudentCount();
                            break;

                        case 1:
                            PrintAllStudent();
                            break;
                        case 2:
                            PrintStudent();
                            break;
                        case 3:
                            InsertStudent();
                            break;
                        case 4:
                            PrintAllDetails();
                            break;
                        case 5:
                            InsertStudentV1();
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice..");
                }
                Console.WriteLine("Do You Want To continue..");
                IsContinue = Console.ReadLine().ToUpper();
            } while (IsContinue == "Y" || IsContinue =="Yes");

            Console.ReadLine();
        }
        static void PrintAllDetails()
        {
            //StudentDB d = new StudentDB();
            //StudentDBV1 d = new StudentDBV1();
            StudentDBV2 d = new StudentDBV2();
            Console.WriteLine("You choosed :Get All Courses and Student..");

            var studentCourses = d.GetStudents();
            Console.WriteLine("All students from DB: ");
            foreach (Student s in studentCourses.Students)
            {
                Console.WriteLine($"{s.id} | {s.Name} |{s.CorseId}");
            }

            Console.WriteLine();

           Console.WriteLine("All Courses from DB: ");
            foreach (Course c in studentCourses.Courses)
            {
                Console.WriteLine($"{c.CourseId} | {c.CourseName} ");
            }
        }
        static void PrintAllStudent()
        {
            StudentDB d = new StudentDB();
            Console.WriteLine("You choosed :Get All Student..");

            List<Student> students = d.GetStudents();

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.id} | {s.Name} |{s.CorseId}");
            }
        }

        static void PrintStudent()
        {
            StudentDBV1 d = new StudentDBV1();

            Console.WriteLine("You choosed :Get Student By Id ");
            Console.WriteLine("Please Enter Id");
            // int id = int.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            Student s1 = d.GetStudentById(input);
            Console.WriteLine($"student hav rollnumber: {input}");
            Console.WriteLine($"{s1.id} | {s1.Name} |{s1.CorseId}");
        }
        static void InsertStudent()
        {
            Console.WriteLine("You choosed to create new Student");
            Student s = new Student();
            Console.WriteLine("Please Enter RollNumber");
            s.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Name");
        s.Name = Console.ReadLine();

            Console.WriteLine("Please Enter Courseid");
  s.CorseId =int.Parse(Console.ReadLine());

            StudentDB d = new StudentDB();

            if (d.Create(s))
            {
                Console.WriteLine("Student Created SuccessFully");
            }
            else
            {
                Console.WriteLine("Student creation Failed");
            }
        }
        static void InsertStudentV1()
        {
            Console.WriteLine("You choosed to create new Student");
            Student s = new Student();
            Console.WriteLine("Please Enter RollNumber");
            s.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Name");
            s.Name = Console.ReadLine();

            Console.WriteLine("Please Enter Courseid");
            s.CorseId = int.Parse(Console.ReadLine());

            StudentDBV1 d = new StudentDBV1();

         //int result=   d.Create(s);

            if (d.Create(s))
            {
                Console.WriteLine($"student created successfully");
            }
            else
            {
                Console.WriteLine("Student creation Failed");
            }
        }

        static void PrintStudentCount()
        {
            StudentDBV1 d = new StudentDBV1();
            Console.WriteLine("You choosed :To fetch number of Student..");

            int numberofstudents = d.StudentCount();

           if(numberofstudents>=0)
            {
                Console.WriteLine($"Number of Students: {numberofstudents}");
            }
            else
            {
                Console.WriteLine("Error in featching  Student..");
            }
        }
    }
}
