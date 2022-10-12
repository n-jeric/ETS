using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Business
{
    class Prizes : CollectionBase
    {
        public void AddPrize(Prize prize)
        {
            List.Add(prize);
        }
        //remove prize by passing prize instance
        public void RemovePrize(Prize prize)
        {
            List.Remove(prize);
        }
        //remove prize by passing index
        public void RemovPrize(int index)
        {
            List.RemoveAt(index);
        }
        public Prize this[int index]
        {
            get { return (Prize)List[index]; }
            set { List[index] = value; }
        }
    }
}
