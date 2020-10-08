using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        //Member Variables

        //Constructor

        //Methods
        public void CreateMarketingFirmWithManager()
        {
            string type = UserInterface.GetUserInput("Would you like to use a Stack or Queue Manager to Manage Sweepstakes?");

            MarketingFirm newFirm;
            ISweepstakesManager manager = null;

            switch (type.ToLower())
            {
                case "queue":
                    manager = new SweepstatesQueueManager();
                    break;
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
            }
            newFirm = new MarketingFirm(manager);
        }
    }
}
