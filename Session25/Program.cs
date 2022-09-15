using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
namespace Session25
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            //c1.Read();//functionalities within that library
            //c1.Write();Not Possible

            //You want to extends its functionalities
            //we want add extra methods to this class
            //we are not creating all together a new class because we want to access existing methods also

            //Option 1-Inheritance

            //GoldCustomer c2 = new GoldCustomer();
            //c2.Read();//customer method
            //c2.Write();//new method

            //Customer c3 = new GoldCustomer();//When we make Base class as sealed--then gives error
            //c3.Read();
            // c3.Write();//Not Possible

            //Customer.Write();//Not Possible+ because not static method+Not customer class method-we can write metod inside
            //customer class then it is possible

            //**Option 1 get failed--when we make base class as sealed-Customer class


            //But I want:
            //Customer c4 = new Customer();
            //c4.Read();
            //c4.Write();//we want to achieve

            //Customer class should have Write method -but how??

            //Option2-Extension method 
            //Extension method solve this problem

            Customer c5 = new Customer();
            c5.Read();
            c5.Write();//???Extension method


            Customer c6 = new Customer();
            c6.Read();
            c6.Write();//??? Extension method

            Console.ReadLine();
        }
       
        
    }
    //public class GoldCustomer : Customer//When we make Base class as sealed--then gives error
    //{
    //    public void Write()
    //    {
    //        Console.WriteLine("Write()");
    //    }
    //}

    //2 rule)class should be public static
    public static class CustomerHelper
    {
        //Extension method
        //1 rule)Method should be public static
        //3-method first parameter should of that type we want to extends
        //4-First parameter should prefix with this keyword
        public static void Write(this Customer c)
        {
            Console.WriteLine("Write()");
        }
    }
}

//we are not owner of this library/project/assembly
namespace MyLibrary
{
    public sealed class Customer
    {//there are some functionalities
        public void Read()
        {
            Console.WriteLine("Read()");
        }
    }
}