﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    interface ISweepstakesManager
    {
        void InsertSweepStakes(Sweepstakes sweepstakes);
        Sweepstakes GetNextSweepstakesWinner();
    }
}
