using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

    }
}
