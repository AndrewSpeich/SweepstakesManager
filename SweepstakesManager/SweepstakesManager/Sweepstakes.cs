using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Sweepstakes
    {
        Dictionary<int , Contestant> contestantholder;
        string sweepsname;
        Random rand;

        public Sweepstakes(string Name)
        {
            sweepsname = Name;
            contestantholder = new Dictionary<int , Contestant>();
            
        }

        public string getWinner()
        {
            Contestant winner;
            winner = produceWinner();

            return winner.name;
            
        }
        public Contestant produceWinner()
        {
            Contestant winner;
            List<int> key = new List<int>(this.contestantholder.Keys);

            winner = contestantholder[rand.Next(key.Count-1)];
            return winner;
        }
        public void printContestantInfo(Contestant contestant)
        {
            Console.WriteLine( contestant.ToString());
        }
    }
}
