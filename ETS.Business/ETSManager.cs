using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ETS.Business
{
    public class ETSManager
    {
        static Sponsors mySponsors = new Sponsors();
        static Donors myDonors = new Donors();
        static Prizes myPrizes = new Prizes();
        static Donations myDonations = new Donations();

        #region Verifier
        //ID Exist verify
        public bool SponsorVerifier(string sID)
        {
            foreach (Sponsor sponsor in mySponsors)
            {
                if (sponsor.GetID() == sID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool DonorVerifier(string dID)
        {
            foreach (Donor donor in myDonors)
            {
                if (donor.DonorID == dID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool PrizeVerifier(string pID)
        {
            foreach (Prize prize in myPrizes)
            {
                if (prize.PrizeID.Equals(pID))
                {
                    return true;
                }
            }
            return false;
        }
        public bool DonationVerifier(string doID)
        {
            foreach (Donation donation in myDonations)
            {
                if (donation.DonationID == doID)
                {
                    return true;
                }
            }
            return false;
        }

        //reg-ex verify
        private bool ValidatePhone(string phone)
        {
            //Regex pattern for phone number 000 111-2222
            string pattern = @"^([2-9]([0-9]{2}))[\s]([2-9][\d]{2})[-]([\d]{4})$";

            //Regular Expression object (requires using System.Text.RegularExpressions)   
            Regex check = new Regex(pattern);

            //check to make sure a phone number was provided    
            if (string.IsNullOrEmpty(phone))
                //returns false if number is not provided    
                return false;

            else
                //Matching the pattern    
                return check.IsMatch(phone, 0);
        }
        private bool ValidateCard(string cardNumber)
        {
            //Regex pattern for 16 digit card number not starting with 0
            string pattern = @"^([1-9]([0-9]{15}))$";

            Regex check = new Regex(pattern);
            if (string.IsNullOrEmpty(cardNumber))
                return false;
            else
                return check.IsMatch(cardNumber, 0);
        }
        private bool ValidateDate(string cardExpiry)
        {
            //Regex pattern for exp date MM/20YY
            string Pattern = @"^(1[0-2]|0[1-9])\/(20[2-9]\d)$";

            Regex check = new Regex(Pattern);
            if (string.IsNullOrEmpty(cardExpiry))
                return false;
            else
                return check.IsMatch(cardExpiry, 0);
        }
        
        //CC expiry date verification for DateTime.Now  
        private bool IsValid(string cardExpiry)
        {
            var dateParts = cardExpiry.Split('/');
            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastday = DateTime.DaysInMonth(year, month);
            var cardExp = new DateTime(year, month, lastday, 23, 59, 59);

            //if (DateTime.TryParse(cardExpiry, out DateTime dateValue))
            //if (dateValue < DateTime.Now)
            if (cardExp < DateTime.Now)
                return false;
            else
                return true;
            //else
            //    return false;
        }

        #endregion

        #region Add
        public string AddSponsor(string sponsorID, string firstName, string lastName)
        {

            if (sponsorID.Length != 4)
            {
                return "Error! Sponsor ID should be 4 chars.";
            }

            if (SponsorVerifier(sponsorID))
            {
                return "Error! This sponsor ID already exists!";
            }

            if (firstName.Length > 15 || string.IsNullOrEmpty(firstName))
            {
                return "Error! Name should be 15 characters or less";
            }
            if (lastName.Length > 15 || string.IsNullOrEmpty(lastName))
            {
                return "Error.! Name should be 15 characters or less";
            }

            mySponsors.AddSponsor(new Sponsor(sponsorID, firstName, lastName));
            return $"Success! Sponsor {sponsorID} added";
        }
        public void CalculateValue(string sponsorID, double value, int originalAvailable)
        {
            foreach (Sponsor spon in mySponsors)
            {
                if (spon.SponsorID.Equals(sponsorID))
                {
                    spon.AddValue(value, originalAvailable);
                }
            }
        }

        public string AddPrize(string prizeID, string description, double value, double donationLimit, int originalAvailable, string sponsorID)
        {
            if (prizeID.Length != 4)
            {
                return "Error! Prize ID should be 4 chars.";
            }

            if (PrizeVerifier(prizeID))
            {
                return "Error! This ID already exists for another prize!";
            }

            if (description.Length > 15 || string.IsNullOrEmpty(description))
            {
                return "Error! Description should be 15 characters or less";
            }

            if (!SponsorVerifier(sponsorID))
            {
                return "Error! SponsorID is incorrect.";
            }

            if (value > 299.99 || value <= 0)
            {
                return "Error! Maximum prize value is $299.99";
            }

            if (originalAvailable > 999 || originalAvailable < 1)
            {
                return "Error! Maximum donation quantity for one prize is 999";
            }
            myPrizes.AddPrize(new Prize(prizeID, description, value, donationLimit, originalAvailable, sponsorID));
            CalculateValue(sponsorID, value, originalAvailable);
            return $"Success! The prize {prizeID} added to the list";
        }

        public string AddDonor(string donorID, string firstName, string lastName, string address, string phone, char cardType, string cardNumber, string cardExpiry)
        {

            if (donorID.Length != 4)
            {
                return "Error! Donor ID should be 4 chars.";
            }

            if (DonorVerifier(donorID))
            {
                return "Error! This ID already exists for another donor!";
            }

            if (firstName.Length > 15 || string.IsNullOrEmpty(firstName))
            {
                return "Error! First Name should be 15 characters or less";
            }
            if (lastName.Length > 15 || string.IsNullOrEmpty(lastName))
            {
                return "Error! Last Name should be 15 characters or less";
            }
            if (address.Length > 40 || string.IsNullOrEmpty(address))
            {
                return "Error! Address should be 40 characters or less";
            }
            if (!ValidatePhone(phone))
            {
                return "Error! The phone number is not valid\nEnter valid phone number in format 555 666-7777";
            }
            if (!ValidateCard(cardNumber))
            {
                return "Error! Enter a valid 16 digit credit card number";
            }
            if (!ValidateDate(cardExpiry))
            {
                return "Error! Enter valid expiration MM/YYYY";
            }
            if (!IsValid(cardExpiry))
            {
                return "Error! The card is expired.";
            }

            myDonors.AddDonor(new Donor(donorID, firstName, lastName, address, phone, cardType, cardNumber, cardExpiry));
            return $"Success! The donor {donorID} added to the list";
        }
        public void AddDonationTotal(string donorID, double amount)
        {
            foreach (Donor donor in myDonors)
            {
                if (donor.DonorID.Equals(donorID))
                {
                    donor.AddDonation(amount);
                }
            }
        }
        public bool RecordDonation(string prizeID, int number)
        {
            foreach (Prize prize in myPrizes)
            {
                if (prize.PrizeID == prizeID && number <= prize.CurrentAvailable)
                {
                    prize.Decrease(number);
                    return true;
                }
            }
            return false;
        }
        public string AddDonation(string donationID, string donorID, double donationAmount, string prizeID, int number)
        {
            if (donationID.Length != 4)
            {
                return "Error! Donation ID should be 4 chars.";
            }
            if (DonationVerifier(donationID))
            {
                return "Error! Donation ID already exists!";
            }
            if (!DonorVerifier(donorID))
            {
                return "Error! Donor ID does not exists!";
            }
            if (donationAmount < 5 || donationAmount > 999999.99)
            {
                return "Error! Minimum donation is $5, and maximum $999,999.99";
            }
            if (!PrizeVerifier(prizeID))
            {
                return "Error! Prize ID does not exists!";
            }
            if (!RecordDonation(prizeID, number))
            {
                return "Error! Select another Prize";
            }

            myDonations.AddDonation(new Donation(donationID, donorID, donationAmount, prizeID, number));
            AddDonationTotal(donorID, donationAmount);
            return $"Success! The donation {donationID} for {donationAmount} added";
        }

        #endregion

        #region List
        public string ListSponsors()
        {
            string msg = "";
            foreach (Sponsor sponsor in mySponsors)
            {
                msg += sponsor.toString();
            }
            return msg;
        }
        public string ListDonors()
        {
            string msg = "";
            foreach (Donor donor in myDonors)
            {
                msg += donor.toString();
            }
            return msg;
        }
        public string ListPrizes()
        {
            string msg = "";
            foreach (Prize prize in myPrizes)
            {
                msg += prize.toString();
            }
            return msg;
        }
        public string ListDonations()
        {
            string msg = "";
            foreach (Donation donation in myDonations)
            {
                msg += donation.toString();
            }
            return msg;
        }
        #endregion

        #region Read Write
        public string Write(string fPath, string textToFile)
        {
            try
            {
                //fs = new FileStream(fPath, FileMode.Append, FileAccess.Write); or true for append
                using (StreamWriter textOut = new StreamWriter(fPath, false))
                {
                    textOut.Write(textToFile);
                }
                return "List Saved to File";
            }
            catch (IOException ex)
            {
                return ex.Message.ToString();
            }
            //{ MessageBox.Show(ex.Message, "IOException"); }
        }
        public string WriteSponsor(string dirPath)
        {
            string filePath = dirPath + "Sponsor.txt";
            string msg = "No Sponsors to save to File";
            if (mySponsors.Count != 0)
            {
                string textToFile = "";
                for (int i = 0; i < mySponsors.Count; i++)
                {
                    textToFile += mySponsors[i].toString();
                }
                msg = Write(filePath, textToFile);
            }
            return msg;
        }
        public string WriteDonor(string dirPath)
        {
            string filePath = dirPath + "Donor.txt";
            string msg = "No Donors to Save to File";
            if (myDonors.Count != 0)
            {
                string textToFile = "";
                foreach (Donor donor in myDonors)
                {
                    textToFile += donor.toString();
                }
                msg = Write(filePath, textToFile);
            }
            return msg;
        }
        public string WritePrize(string dirPath)
        {
            string filePath = dirPath + "Prize.txt";
            string msg = "No Prizes to Save to File";
            if (myPrizes.Count != 0)
            {
                string textToFile = "";
                foreach (Prize prize in myPrizes)
                {
                    textToFile += prize.toString();
                }
                msg = Write(filePath, textToFile);
            }
            return msg;
        }
        public string WriteDonation(string dirPath)
        {
            string filePath = dirPath + "Donation.txt";
            string msg = "No Donations to Save to File";
            if (myDonations.Count != 0)
            {
                string textToFile = "";
                foreach (Donation donation in myDonations)
                {
                    textToFile += donation.toString();
                }
                msg = Write(filePath, textToFile);
            }
            return msg;
        }

        public void ReadSposor(string dirPath)
        {
            string filePath = dirPath + "Sponsor.txt";
            using (StreamReader textIn = new StreamReader(filePath))
            {
                while (textIn.Peek() != -1)
                {
                    string[] strArr;
                    strArr = textIn.ReadLine().Split(',');

                    mySponsors.AddSponsor(new Sponsor(strArr[0], strArr[1], strArr[2], double.Parse(strArr[3])));
                }
            }
        }
        public void ReadDonor(string dirPath)
        {
            string filePath = dirPath + "Donor.txt";
            using (StreamReader textIn = new StreamReader(filePath))
            {
                while (textIn.Peek() != -1)
                {
                    string[] strArr;
                    strArr = textIn.ReadLine().Split(',');

                    myDonors.AddDonor(new Donor(strArr[0], strArr[1], strArr[2], strArr[3], strArr[4], char.Parse(strArr[5]), strArr[6], strArr[7], double.Parse(strArr[8])));
                }
            }
        }
        public void ReadPrize(string dirPath)
        {
            string filePath = dirPath + "Prize.txt";
            using (StreamReader textIn = new StreamReader(filePath))
            {
                while (textIn.Peek() != -1)
                {
                    string[] strArr;
                    strArr = textIn.ReadLine().Split(',');

                    myPrizes.AddPrize(new Prize(strArr[0], strArr[1], double.Parse(strArr[2]), double.Parse(strArr[3]), int.Parse(strArr[4]), strArr[6]));
                }
            }
        }
        public void ReadDonation(string dirPath)
        {
            string filePath = dirPath + "Donation.txt";
            using (StreamReader textIn = new StreamReader(filePath))
            {
                while (textIn.Peek() != -1)
                {
                    string[] strArr;
                    strArr = textIn.ReadLine().Split(',');

                    myDonations.AddDonation(new Donation(strArr[0], strArr[1], strArr[2], double.Parse(strArr[3]), strArr[4], int.Parse(strArr[5])));
                }
            }
        }

        #endregion

        #region Remove entry
        /*remove donor by passing index number

        public string RemoveDonor(string donorID)
        {
            for (int i = 0; i < myDonors.Count; i++)
            {
                if (myDonors[i].DonorID.Equals(donorID))
                {
                    myDonors.RemoveDonor(i);
                    return $"Donor {donorID} removed";
                }
            }
            return $"Donor {donorID} not removed";
        }*/

        //remove donor by passing donor instance
        public string RemoveDonor(string donorID)
        {
            foreach (Donor donor in myDonors)
            {
                if (donor.DonorID.Equals(donorID))
                {
                    myDonors.RemoveDonor(donor);
                    return $"Donor {donorID} removed";
                }
            }
            return $"Donor {donorID} not removed";
        }
        //remove sponsor by passing sponsor instance
        public string RemoveSponsor(string sponsorID)
        {
            foreach (Sponsor sponsor in mySponsors)
            {
                if (sponsor.SponsorID.Equals(sponsorID))
                {
                    mySponsors.RemoveSponsor(sponsor);
                    return $"Sponsor {sponsorID} removed";
                }
            }
            return $"Sponsor {sponsorID} not removed";
        }
        #endregion

        #region Additional for Form Display

        //dashboard button display
        public int numberOfSponsors()
        {
            return mySponsors.Count;
        }
        public int numberOfDonors()
        {
            return myDonors.Count;
        }
        public int numberOfPrizes()
        {
            return myPrizes.Count;
        }
        public double donationTotal()
        {
            double total = 0;

            foreach (Donation donation in myDonations)
            {
                total += donation.DonationAmount;
            }
            return total;
        }

        //Display Sponsor and Donor in text boxes
        public string FindSponsor(string sponsorID)
        {
            string info = "";
            foreach (Sponsor sponsor in mySponsors)
            {
                if (sponsor.SponsorID == sponsorID)
                {
                    info = $"{sponsor.FirstName},{sponsor.LastName}";
                }
            }
            return info;
        }
        public Array FindSponsor1(string sponsorID)
        {
            string info = "";
            foreach (Sponsor sponsor in mySponsors)
            {
                if (sponsor.SponsorID == sponsorID)
                {
                    info = $"{sponsor.FirstName},{sponsor.LastName}";
                }
            }
            string[] strArr;
            strArr = info.Split(',');

            //string[] strArr = new string[2];
            //foreach (Sponsor sponsor in mySponsors)
            //{
            //    if (sponsor.SponsorID == sponsorID)
            //    {
            //        strArr[0] = sponsor.FirstName;
            //        strArr[1] = sponsor.LastName;
            //    }
            //}
            return strArr;
        }
        public string FindDonor(string donorID)
        {
            string info = "";
            foreach (Donor donor in myDonors)
            {
                if (donor.DonorID == donorID)
                {
                    info = $"{donor.FirstName},{donor.LastName},{donor.Address},{donor.Phone},{donor.CardType.ToString()},{donor.CardNumber},{donor.CardExpiry}";
                }
            }
            return info;
        }

        //display in DataGrid
        public List<List<string>> ListingSponsor()
        {
            List<List<string>> listSponsor = new List<List<string>>();

            foreach (Sponsor sponsor in mySponsors)
            {
                List<string> temp = new List<string>();
                temp.Add(sponsor.SponsorID);
                temp.Add(sponsor.FirstName);
                temp.Add(sponsor.LastName);
                temp.Add(sponsor.TotalPrizeValue.ToString("N2"));

                listSponsor.Add(temp);
            }
            return listSponsor;
        }
        public List<List<string>> ListingPrizes()
        {
            List<List<string>> listPrize = new List<List<string>>();

            foreach (Prize prize in myPrizes)
            {
                List<string> temp = new List<string>();
                temp.Add(prize.PrizeID);
                temp.Add(prize.Description);
                temp.Add(prize.Value.ToString("N2"));
                temp.Add(prize.DonationLimit.ToString("N2"));
                temp.Add(prize.CurrentAvailable.ToString());

                listPrize.Add(temp);
            }
            return listPrize;
        }
        public List<List<string>> ListingDonors()
        {
            List<List<string>> listDonor = new List<List<string>>();

            foreach (Donor donor in myDonors)
            {
                List<string> temp = new List<string>();
                temp.Add(donor.DonorID);
                temp.Add(donor.FirstName);
                temp.Add(donor.LastName);
                temp.Add(donor.Address);
                temp.Add(donor.Phone);
                temp.Add(donor.CardType.ToString());
                temp.Add(donor.DonationTotal.ToString("N2"));

                listDonor.Add(temp);
            }
            return listDonor;
        }
        public List<List<string>> ListingDonations()
        {
            List<List<string>> listDonation = new List<List<string>>();

            foreach (Donation donation in myDonations)
            {
                List<string> temp = new List<string>();
                temp.Add(donation.DonationID);
                temp.Add(donation.DonationDate);
                temp.Add(donation.DonationAmount.ToString("N2"));
                temp.Add(donation.DonorID);
                temp.Add(donation.PrizeID);
                temp.Add(donation.PrizeNum.ToString());

                listDonation.Add(temp);
            }
            return listDonation;
        }
        #endregion

    }
}
