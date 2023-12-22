using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversity.Core
{
    public class ApplyOff
    {
        public static float Calculate(float price , float percent)
        {
            var newprice= price - (percent * price) / 100;

            return newprice;
        }
    }
}
