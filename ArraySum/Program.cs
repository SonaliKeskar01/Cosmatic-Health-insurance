using System;

class Program
{
    static void Main(string[] args)
    {
        //parameterized constructor
        //Student s1 = new Student("Sonali","Keskar","V#");
        //s1.print();

        //parameterless constructor
        // Student s2 = new Student();
        //s2.print();


        //copy constructor
        //Student s3 = new Student(s1);
        //s3.print();

        //private/protected
       // Student s1 = new Student();//not possible
        Console.ReadLine();
    }
}
//public class Student
//{
//    public string Firstname;
//    public string Lastname;
//    public static  string Companyname;

//    //parameterless constructor
//    public Student()
//    {
//        Firstname = "Vishal";
//        Lastname = "Keskar";
//       // Companyname = "KPIT";
//    }
//     static Student()
//    {
//        Companyname = "KPIT";
//    }
//    //Parameterized constructor
//    public Student(string fn,string ln,string con)
//    {
//        Firstname = fn;
//        Lastname = ln;
//        Companyname = con;

//    }

//    //copy constructor
//    public Student(Student s)
//    {
//        Firstname = s.Firstname;
//        Lastname = s.Lastname;
//      //  Companyname = s.Companyname;
//    }
//    public void print()
//    {
//        Console.WriteLine($"{Firstname} : {Lastname} -{Companyname}");
//    }

    
//}

public class Student
{
    // private Student()
  protected Student()
    {

    }
}