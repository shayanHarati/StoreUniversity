using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversity.Core
{
    public static class Fix
    {
        public static  string Normalize_2d(this string text)
        {
            return text.ToLower().Trim();
        }

        public static string Normalize_1d(this string text)
        {
            return text.Trim();
        }

    }
}
