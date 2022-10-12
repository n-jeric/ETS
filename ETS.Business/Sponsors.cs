using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Sponsors : CollectionBase
    {
        public void AddSponsor(Sponsor sponsor)
        {
            List.Add(sponsor);
        }
        //remove sponsor by passing sponsor instance
        public void RemoveSponsor(Sponsor sponsor)
        {
            List.Remove(sponsor);
        }
        //remove sponsor by passing index
        public void RemovSponsor(int index)
        {
            List.RemoveAt(index);
        }
        public Sponsor this[int index]
        {
            get { return (Sponsor)List[index]; }
            set { List[index] = value; }
        }
    }
}
