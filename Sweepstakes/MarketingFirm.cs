using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //Member Variables
        ISweepstakesManager _manager;

        //Constructor
        public MarketingFirm(ISweepstakesManager _manager) //Dependency Injection used to allow any type of ISweepstakes managager to be used to manage the Sweepstakes instead of defining that within the Marketing Firm class.
        {
            this._manager = _manager;
        }

        //Methods

        public void CreateSweepstakes()
        {

        }

    }
}
