using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Donors : CollectionBase
    {
        public void AddDonor(Donor donor)
        {
            List.Add(donor);
        }
        //remove donor by passing donor instance (same principle as AddDonor)
        public void RemoveDonor(Donor donor)
        {
            List.Remove(donor);
        }
        //remove donor by passing index
        public void RemoveDonor(int index)
        {
            List.RemoveAt(index);
        }

        public Donor this[int index]
        {
            get { return (Donor)List[index]; }
            set { List[index] = value; }
        }
    }
}
