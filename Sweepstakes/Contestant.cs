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
    class Contestant
    {
        //Member Variables
        string firstName;
        string lastName;
        string emailAddress;
        int registrationNumber;

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
        }
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
        }

        //Constructor
        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }
        //Methods
    }
}
