using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Contestant
    {
        public string name { get; set; }
        Address home;

        public Contestant(string Name)
        {
            name = Name;
        }
        public Contestant(string Name, string housenum, string street, string city, string state, string zip)
        {
            name = Name;
            home = new Address(housenum, street, city, state, zip);

        }

        public override string ToString()
        {
            return (name + ", \n" + home.ToString());
        }





    }
}
