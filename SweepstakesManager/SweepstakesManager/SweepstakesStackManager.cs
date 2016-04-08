using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
   class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> currentsweeps;

        public SweepstakesStackManager()
        {
            currentsweeps = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetNextSweepstakesWinner()
        {
            Sweepstakes sweeps = currentsweeps.Pop();
            Console.WriteLine(sweeps.getWinner());
            return sweeps;
        }

        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            currentsweeps.Push(sweepstakes);
        }
    }
}
