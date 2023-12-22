using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversity.Core
{
    public  class Money
    {
        public static string formatMoney(float money)
        {
            return money.ToString("0,000");
        }
    }
}
