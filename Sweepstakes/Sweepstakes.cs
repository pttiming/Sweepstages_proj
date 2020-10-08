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
    class Sweepstakes : INotify
    {
        //Member Variables
        public Dictionary<int, Contestant> contestants;
        string name;
        string sweepstakesEmailAddress;
        Contestant contestWinner;

        public string Name
        {
            get
            {
                return name;
            }
        }

        //Constructor
        public Sweepstakes(string name, string sweepstakesEmailAddress)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
            this.sweepstakesEmailAddress = sweepstakesEmailAddress;
            contestWinner = null;
        }
        //Methods

        public void RegisterContestant(Contestant contestant)
        {
            int contestantIndex = contestants.Count + 1;
            contestants.Add(contestantIndex, contestant);
        }

        public Contestant PickWinner()
        {
            Contestant winner;
            Random rand = new Random();
            winner = contestants[rand.Next(1, (contestants.Count+1))];
            contestWinner = winner;
            return winner;
        }
        

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.FirstName}");
            Console.WriteLine($"Last Name: {contestant.LastName}");
            Console.WriteLine($"Email: {contestant.EmailAddress}");
            Console.WriteLine($"Registration Number: {contestant.RegistrationNumber}");
        }

        public void NotifyContestants() //Bonus UserStory 1
        {
            foreach(Contestant contestant in contestants.Values)
            {
                if(contestant != contestWinner)
                {
                    Console.WriteLine($"Thank you for playing the {name} SweepStakes.  We would like to announce our winner is {contestWinner.FirstName} {contestWinner.LastName}.  If you are reading this, you're a loser, get over it.");
                }
                else if (contestant == contestWinner)
                {
                    Console.WriteLine($"Congratulations {contestant.FirstName} {contestant.LastName}, you have won the {name} SweepStakes.  Come collect your prizes and show them off.");
                }
            }

        }

        public void EmailNotifyContestants()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress($"{name}", $"{sweepstakesEmailAddress}"));
            foreach (Contestant contestant in contestants.Values)
            {
                if (contestant != contestWinner)
                {
                    message.To.Add(new MailboxAddress($"{contestant.FirstName} {contestant.LastName}", $"{contestant.EmailAddress}"));
                    message.Subject = $"{name} Sweepstakes";
                    
                    message.Body = new TextPart("plain") 
                    {
                        Text = $@"Thank you for playing the {name} SweepStakes.  We would like to announce our winner is {contestWinner.FirstName} {contestWinner.LastName}.  If you are reading this, you're a loser, get over it." 
                    };
                }
                else if (contestant == contestWinner)
                {
                    message.To.Add(new MailboxAddress($"{contestant.FirstName} {contestant.LastName}", $"{contestant.EmailAddress}"));
                    message.Subject = $"{name} Sweepstakes WINNER!";

                    message.Body = new TextPart("plain")
                    {
                        Text = $@"Congratulations {contestant.FirstName} {contestant.LastName}, you have won the {name} SweepStakes.  Come collect your prizes and show them off."
                    };
                }
                using (var client = new SmtpClient())
                {
                    //Needs to be adjusted to function
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("emaillogin", "password");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
        }
    }
}
