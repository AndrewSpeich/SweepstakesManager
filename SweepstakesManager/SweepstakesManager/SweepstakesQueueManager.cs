using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> currentsweeps;

        public SweepstakesQueueManager()
        {
            currentsweeps = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetNextSweepstakesWinner()
        {
            Sweepstakes sweeps = currentsweeps.Dequeue();
            Console.WriteLine(sweeps.getWinner());
            return sweeps;
        }

        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            currentsweeps.Enqueue(sweepstakes);
        }
    }
}
