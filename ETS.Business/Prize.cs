using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Prize
    {
        string prizeID;
        string description;
        double value;
        double donationLimit;
        int originalAvailable;
        int currentAvailable;
        string sponsorID;

        public Prize(string prizeID, string description, double value, int originalAvailable, string sponsorID)
        {
            this.prizeID = prizeID;
            this.description = description;
            this.value = value; //value for a single prize

            double calc = value * 10;
            if (calc < 5)
            {
                calc = 5;
            }
            this.donationLimit = calc;
            this.originalAvailable = originalAvailable; //number of prizes supplied
            this.currentAvailable = originalAvailable;
            this.sponsorID = sponsorID;
        }
        public Prize(string prizeID, string description, double value, double donationLimit, int originalAvailable, string sponsorID)
        {
            this.prizeID = prizeID;
            this.description = description;
            this.value = value; //value for a single prize
            this.donationLimit = donationLimit;
            this.originalAvailable = originalAvailable; //number of prizes supplied
            this.currentAvailable = originalAvailable;
            this.sponsorID = sponsorID;
        }
        public Prize(string prizeID, string description, double value, double donationLimit, int originalAvailable, int currentAvailable, string sponsorID)
        {
            this.prizeID = prizeID;
            this.description = description;
            this.value = value; //value for a single prize
            this.donationLimit = donationLimit;
            this.originalAvailable = originalAvailable; //number of prizes supplied
            this.currentAvailable = currentAvailable;
            this.sponsorID = sponsorID;
        }

        #region Getter & Setter
        public string PrizeID { get => prizeID; set => prizeID = value; }
        public string Description { get => description; set => description = value; }
        public double Value { get => value; set => this.value = value; }
        public double DonationLimit { get => donationLimit; set => donationLimit = value; }
        public int OriginalAvailable { get => originalAvailable; set => originalAvailable = value; }
        public int CurrentAvailable { get => currentAvailable; /*set => currentAvailable = value;*/ }
        public string SponsorID { get => sponsorID; set => sponsorID = value; }
        #endregion

        public string toString()
        {
            return $"{prizeID},{description},{value},{donationLimit},{originalAvailable},{currentAvailable},{sponsorID}\n";
        }

        public string GetID()
        {
            return this.prizeID;
        }

        public void Decrease(int awarded)
        {
            currentAvailable -= awarded;
        }
    }
}
