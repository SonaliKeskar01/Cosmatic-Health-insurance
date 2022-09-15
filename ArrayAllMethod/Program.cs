using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Enter Array Size : ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
    }

     static void inputArrray()
    {
        



        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array Elements: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"{i} : {a[i]}");
        }
    }

    static void sumOfArray()
    {

        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum = sum + a[i];
        }
        Console.WriteLine("Sum of array: " + sum);
    }
}

