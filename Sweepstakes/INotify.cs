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
    interface INotify
    {
        void NotifyContestants();

        void EmailNotifyContestants();
    }

}
