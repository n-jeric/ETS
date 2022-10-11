using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Donor : Person
    {

        string donorID;
        string address;
        string phone;
        char cardType;
        string cardNumber;
        string cardExpiry;
        double donationTotal;

        public Donor(string donorID, string firstName, string lastName, string address, string phone, char cardType, string cardNumber, string cardExpiry) : base(firstName, lastName)
        {
            this.donorID = donorID;
            this.address = address;
            this.phone = phone;
            this.cardType = cardType;
            this.cardNumber = cardNumber;
            this.cardExpiry = cardExpiry;
            this.donationTotal = 0.0;
        }
        public Donor(string donorID, string firstName, string lastName, string address, string phone, char cardType, string cardNumber, string cardExpiry, double donationTotal) : base(firstName, lastName)
        {
            this.donorID = donorID;
            this.address = address;
            this.phone = phone;
            this.cardType = cardType;
            this.cardNumber = cardNumber;
            this.cardExpiry = cardExpiry;
            this.donationTotal = donationTotal;
        }
       
        #region Getter & Setter
        public string DonorID { get => donorID; set => donorID = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public char CardType { get => cardType; set => cardType = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string CardExpiry { get => cardExpiry; set => cardExpiry = value; }
        public double DonationTotal { get => donationTotal; set => donationTotal = value; }
        #endregion

        public override string toString()
        {
            return $"{donorID},{base.toString()},{address},{phone},{cardType},{cardNumber},{cardExpiry},{donationTotal}\n";
        }
        public void AddDonation(double donation)
        {
            this.donationTotal += donation;
        }

    }
}
