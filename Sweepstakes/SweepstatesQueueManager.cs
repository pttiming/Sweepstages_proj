using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstatesQueueManager : ISweepstakesManager
    {
        //Member Variables
        Queue<Sweepstakes> queue;

        //Constructor
        public SweepstatesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        //Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
