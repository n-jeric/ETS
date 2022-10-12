using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Donations : CollectionBase
    {
        public void AddDonation(Donation donaton)
        {
            List.Add(donaton);
        }
        //remove donation by passing donation instance
        public void RemoveDonation(Donation donation)
        {
            List.Remove(donation);
        }
        //remove donation by passing index
        public void RemoveDonation(int index)
        {
            List.RemoveAt(index);
        }
        public Donation this[int index]
        {
            get { return (Donation)List[index]; }
            set { List[index] = value; }
        }


    }
}
