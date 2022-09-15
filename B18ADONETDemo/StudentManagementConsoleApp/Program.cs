using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            StudentBL bl = new StudentBL();
            string isContinue = string.Empty;
            do {
                Console.WriteLine("Enter Choice For Student ");
                String choice = Console.ReadLine().ToUpper();

                switch (choice)
                {


                    case "GETALL":
                        Console.WriteLine("***All Students***");
                        var students = bl.Students();

                        foreach (Student s in students)
                        {
                            Console.WriteLine($" {s.id} | {s.Name} | {s.CorseId}");
                        }
                        break;

                    case "GETONE":
                        Console.WriteLine("Please Enter Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Student s1 = bl.StudentById(id);
                        Console.WriteLine($" {s1.id} | {s1.Name} | {s1.CorseId}");
                        break;

                    case "CREATE":
                        Student ss = new Student();
                        Console.WriteLine("Please Enter RollNumber");
                        ss.id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please Enter Name");
                        ss.Name = Console.ReadLine();

                        Console.WriteLine("Please Enter Courseid");
                        ss.CorseId = int.Parse(Console.ReadLine());

                        if(bl.Create(ss))
                        {
                            Console.WriteLine("CREATE SUCCESSFUL");
                        }
                        else
                        {
                            Console.WriteLine("CREATE Failed");
                        }
                        break;


                    case "UPDATE":
                        Student s2 = new Student();
                        Console.WriteLine("Please Enter RollNumber");
                        s2.id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please Enter Name");
                        s2.Name = Console.ReadLine();

                        Console.WriteLine("Please Enter Courseid");
                        s2.CorseId = int.Parse(Console.ReadLine());

                        if (bl.Update(s2.id,s2))
                        {
                            Console.WriteLine("Update SUCCESSFUL");
                        }
                        else
                        {
                            Console.WriteLine("UPDATE FAILED");
                        }
                        break;


                    case "DELETE":
                       
                        Console.WriteLine("Please Enter RollNumber");
                       
                        if (bl.Delete(int.Parse(Console.ReadLine())))
                        {
                            Console.WriteLine("DELETE SUCCESSFUL");
                        }
                        else
                        {
                            Console.WriteLine("DELETE FAILED");
                        }
                        break;

                    case "ARCHIVE":
                        Console.WriteLine($"Student archive process started..{DateTime.Now}");
                       bl.ArchieveStudents();
                        Console.WriteLine($"Student archive process Ended..{DateTime.Now}");
                        break;


                    case "HELP":
                        Console.WriteLine("Write Belows Commands..");
                        Console.WriteLine("GetALL, GetOne ,CREATE ,UPDAT,DELETE,ARCHIVE");
                        break;

                    

                    default:
                        Console.WriteLine("Invalid Command  - Please use \"hepls\" to see all command..");                    
                        break;
                }
                Console.WriteLine("Continue ??");
                isContinue = Console.ReadLine().ToUpper();

            } while (isContinue=="Y");

                Console.ReadLine();
            }
    }

    }