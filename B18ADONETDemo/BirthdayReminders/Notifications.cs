using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayReminders
{
   public  class Notifications
    {
        public bool SendEmail(Friends friend)
        {
            bool status = false;

            try
            {
                //1-send email
                string fromEmail = "dotnettestemail@gmail.com";
                string fromEmailPassword = "Welcome@123";

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(fromEmail);
                message.To.Add(new MailAddress(friend.Email));
                message.Subject = friend.EmailSubject;
                 message.IsBodyHtml = true;

                message.Body = $"Hello, <h2>{friend.NickName}</h2> \n\n" + friend.EmailBody;
                 //   $"<img alt='NO IMAGE' src='download.jpg'/>";
                message.Body = friend.EmailBody;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromEmail, fromEmailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

               
                // 2 - if success - update to db

                BithdayDB db = new BithdayDB();
                if (db.UpdateEmailWishesStatusToDB(friend))
                {
                    Console.WriteLine("DB STATUS UPDATED SUCCESS");
                }
                else
                {
                    Console.WriteLine("DB STATUS  FAILED");
                }
                status = true;
            }
            catch (Exception ex)
            {

            }
            
            return status;
        }
    }
}
