using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADOIntroDemo1
{
    class Program
    {
        static void Main(string[] args)
        { string IsContinue = string.Empty;
            do
            {
                Console.WriteLine("Please enter Choice..");
            Console.WriteLine("\n 1-Get all students.." +
                "\n 2-Get student by Id");
            int choice;

            if (int.TryParse(Console.ReadLine(), out choice))
            {
               
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You choose: Get all student..");
                            StudentDB db = new StudentDB();
                            List<Student> s1 = db.GetStudents();

                            foreach (Student item in s1)
                            {
                                Console.WriteLine($"{item.id} | {item.Name} |{item.CorseId}");
                            }
                            break;
                        case 2:

                        default:
                            Console.WriteLine("Invalid Choice..");
                            break;



                    }
                }
            else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.WriteLine("Do you want to continue..?");
                IsContinue = Console.ReadLine().ToUpper();
            }while (IsContinue=="Y" || IsContinue=="YES") ;
            Console.ReadLine();
        }
    }
}
