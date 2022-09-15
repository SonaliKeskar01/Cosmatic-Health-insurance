using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {// Write a method which returns add, sub, division, reminder, multiplication.
     // class - Calculator method - Operations 

        static void Main()
        {
            Console.WriteLine("Enter Number1:\n");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2:\n");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int add, sub, division, reminder, multiplication;
           operation( number1,  number2,out add,out sub, out division,out reminder,out multiplication);

            Console.WriteLine($"Addition is : {add}");
            Console.WriteLine($"Subtraction is : {sub}");
            Console.WriteLine($"Division is : {division}");
            Console.WriteLine($"Reminder is : {reminder}");
            Console.WriteLine($"Multilpication is : {multiplication}");
            Console.ReadLine();
        }
        static void operation(int number1, int number2,out int add,out int sub, 
            out int division, out int reminder, out int multiplication)
        {
            add = number1 + number2;
            sub = number1 - number2;
            division = number1 / number2;
            reminder = number1 % number2;
            multiplication = number1 * number2;
        }
    }
}
