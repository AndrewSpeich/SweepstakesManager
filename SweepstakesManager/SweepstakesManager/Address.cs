using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Address
    {
        string housenumber;
        string streetaddress;
        string city;
        string state;
        string zipcode;

        public Address(string house, string street, string cityin, string statein, string zip)
        {
            housenumber = house;
            streetaddress = street;
            city = cityin;
            state = statein;
            zipcode = zip;
        }
        public Address(string street, string cityin, string statein, string zip)
        {
           
            streetaddress = street;
            city = cityin;
            state = statein;
            zipcode = zip;
        }

        public override string ToString()
        {
            return (housenumber + " " + streetaddress + "/n " + city + ", " + state + " " + zipcode);
        }
    }
}
