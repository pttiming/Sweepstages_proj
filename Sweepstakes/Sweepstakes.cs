using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //Member Variables
        public Dictionary<int, Contestant> contestants;
        string name;

        public string Name
        {
            get
            {
                return name;
            }
        }

        //Constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
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
            return winner;
        }
        

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.FirstName}");
            Console.WriteLine($"Last Name: {contestant.LastName}");
            Console.WriteLine($"Email: {contestant.EmailAddress}");
            Console.WriteLine($"Registration Number: {contestant.RegistrationNumber}");
        }
    }
}
