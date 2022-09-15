using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("Please enter a name");
        String input  = Console.ReadLine();
        switch (input.ToUpper())
        {
            case "firstname":
            Console.WriteLine("yashwant");
                break;
            case "lastname":
                Console.WriteLine("kolekar");
                break;
            default:
                Console.WriteLine($"Invalid input name : {input}");
                break;
        }
        Console.ReadLine(); 
    }

}
