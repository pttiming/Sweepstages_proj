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
        public MarketingFirm(ISweepstakesManager _manager) //Dependency Injection used 
        {
            this._manager = _manager;
        }

        //Methods

    }
}
