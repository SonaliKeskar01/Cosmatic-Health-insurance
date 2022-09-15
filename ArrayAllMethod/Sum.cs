using System;

    public class Sum
    {

    public void inputArrray()
    {
        Console.WriteLine("Enter Array Size : ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[size];

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

    public void sumOfArray()
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum = sum + a[i];
        }
        Console.WriteLine("Sum of array: " + sum);
    }



}
