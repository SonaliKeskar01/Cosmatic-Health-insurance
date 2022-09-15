using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session27_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student() { Name="Sonali",Gender="Female"};
            //Student s1 = new Student() { Name = "Sonali", Gender = 2 };//after integral 
            //Console.WriteLine($"Name: {s1.Name} ,Gender: {getGender(s1.Gender)}");

            //Student s1 = new Student() { Name = "Sonali", Gender = Gender.Female};//after integral 
            //Console.WriteLine($"Name: {s1.Name} ,Gender: {s1.Gender}");


            // Student s2 = new Student() { Name = "Vishal", Gender = "Male" };
            //Student s2 = new Student() { Name = "Vishal", Gender = Gender.Male};
            //Console.WriteLine($"Name: {s2.Name} ,Gender: {s2.Gender}");

            //Student s3 = new Student() { Name = "Sofiy", Gender = Gender.unknown };
            //Console.WriteLine($"Name: {s3.Name} , Gender:{s3.Gender}");
            //Student s4 = new Student() { Name = "Yash", Gender = "Male" };

            Console.WriteLine("Please Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter Gender:");
            int gender = int.Parse(Console.ReadLine());
          //Gender gender  =(Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

            Student s3 = new Student() {  Name = name , Gender = (Gender)gender };
            Console.WriteLine($"{s3.Name} , {s3.Gender}");

            Type type= Enum.GetUnderlyingType(typeof(Gender));//type of underlyingtype//int,
            Console.WriteLine(type.Name);

            //if we want to check all enum type then:
          string [] numbers=  Enum.GetNames(typeof(Gender));//enum name-male,female,unknown

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}");//male,female,unknown
            }

            Console.WriteLine();

          int[]values= (int[]) Enum.GetValues(typeof(Gender));
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{values[i]}");//0,1,2
            }

            Console.ReadLine();
        }

        static string getGender(int gender)
        {
            switch (gender)
            {
                case 1:
                    return "Male";

                case 2:
                    return "Female";
                default:
                    return "Unknown gender";

            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        // public string Gender { get; set; }//normal properties
        //public int Gender { get; set; }//to create integral type
        //public enum Gender:byte  //o/p:byte
        //can customize enum value-?? yes
        //By default value start from-0
        
        public Gender Gender { get; set; }//enum type
    }
    //default-underlying base type =int 
    //can we customize underlying base type??

    //public enum Gender:byte  //o/p:byte
    //{
    //    Male, Female,unknown
    //}
    //Integral type allow only-int,short,long,byte
    //public enum Gender //enum value--0,1,2
    //{
    //    Male, Female, unknown
    //}


    //If we want customize value 
    //public enum Gender //enum value //11,12,13
    //{
    //    Male=11, Female, unknown
    //}

    public enum Gender //enum value //0,11,12
    {
        Male , Female=11, unknown
    }

}