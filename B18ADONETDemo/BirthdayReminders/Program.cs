using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayReminders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Fetching Todays Birthday From DB @{DateTime.Now}");

            BithdayDB db = new BithdayDB();

         var friends=   db.TodaysBirthdays();

            foreach (Friends frnd in friends)
            {
                Console.WriteLine($" {frnd.Name} | {frnd.NickName} | {frnd.DateOfBirth}");
                Console.WriteLine($" BIRTHDAY WISH SENDING  VIA EMAIL.TO {frnd.NickName} ");
                Notifications n = new Notifications();
                if(n.SendEmail(frnd))
                {
                    Console.WriteLine($" SUCCESS EMAIL TO :{frnd.NickName}");
                }
                else
                {
                    Console.WriteLine($" FAILED EMAIL TO:{frnd.NickName}");
                }
                Console.WriteLine($"Completed BIRTHDAY WISH SENDING  VIA EMAIL.TO {frnd.NickName} ");

            }

            Console.WriteLine($"Completed Fetching Todays Birthday From DB @{DateTime.Now}");

            Console.ReadLine();
        }
    }
}
