using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetUserIntInput(string question)
        {
            string response = GetUserInput(question);
            int intResponse;
            if (int.TryParse(response, out intResponse))
            {
               return intResponse;
            }
            else
            {
                throw new ApplicationException(string.Format("Not a valid response"));
            }
                
           
        }

    }
}
