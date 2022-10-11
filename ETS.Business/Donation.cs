using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Donation
    {
        string donationID;
        string donationDate;
        string donorID;
        double donationAmount;
        string prizeID;
        int prizeNum;

        public Donation(string donationID, string donorID, double donationAmount, string prizeID, int prizeNum)
        {
            this.donationID = donationID;
            //this.donationDate = DateTime.Now.ToShortDateString(); // Get the current date & display in default format
            this.donationDate = DateTime.Now.ToString("dd/MMM/yyyy"); // Get the current date & format 
            this.donorID = donorID;
            this.donationAmount = donationAmount;
            this.prizeID = prizeID;
            this.prizeNum = prizeNum;
        }
        public Donation(string donationID, string donationDate, string donorID, double donationAmount, string prizeID, int prizeNum)
        {
            this.donationID = donationID;
            this.donationDate = donationDate;
            this.donorID = donorID;
            this.donationAmount = donationAmount;
            this.prizeID = prizeID;
            this.prizeNum = prizeNum;
        }
        #region Getter & Setter
        public string DonationID { get => donationID; set => donationID = value; }
        public string DonationDate { get => donationDate; set => donationDate = value; }
        public string DonorID { get => donorID; set => donorID = value; }
        public double DonationAmount { get => donationAmount; set => donationAmount = value; }
        public string PrizeID { get => prizeID; set => prizeID = value; }
        public int PrizeNum { get => prizeNum; set => prizeNum = value; }
        #endregion

        public string toString()
        {
            return $"{donationID},{donationDate},{donorID},{donationAmount},{prizeID},{prizeNum}\n";
        }
    }
}
