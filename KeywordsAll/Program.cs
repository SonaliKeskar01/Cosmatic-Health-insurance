using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsAll
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a1 = new A();
            //a1.getShowTiming();

            //A b1 = new B();
            //b1.printTicket();


            Console.ReadLine();
        }
    }
   public abstract class A
    {
     public   A()
        {

        }
     public void getShowTiming()
        {
            Console.WriteLine("ShowTime");
        }
        public virtual void printTicket1()
        {
            Console.WriteLine("printA");
        }

        public abstract void printTicket();//give error//
    }

 public   class B:A
    {

        public override void printTicket()
        {

        }
    }

    public class C:B
    {

        public void printTicket()
        {
            Console.WriteLine("printC");
        }
    }
}
