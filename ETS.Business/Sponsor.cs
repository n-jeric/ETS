using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Sponsor : Person
    {
        string sponsorID;
        double totalPrizeValue;

        public Sponsor(string sponsorID, string firstName, string lastName) : base(firstName, lastName)
        {
            this.sponsorID = sponsorID;
            this.totalPrizeValue = 0;
        }

        public Sponsor(string sponsorID, string firstName, string lastName, double totalPrizeValue) : base(firstName, lastName)
        {
            this.sponsorID = sponsorID;
            this.totalPrizeValue = totalPrizeValue;

        }
        public string SponsorID { get => sponsorID; set => sponsorID = value; }
        public double TotalPrizeValue { get => totalPrizeValue; set => totalPrizeValue = value; }

        public override string toString()
        {
            return $"{sponsorID},{base.toString()},{totalPrizeValue}\n";
        }

        public string GetID()
        {
            return this.sponsorID;
        }
        public void AddValue(double value, int originalAvailable)
        {
            this.totalPrizeValue += (value * originalAvailable);
        }
    }
}
