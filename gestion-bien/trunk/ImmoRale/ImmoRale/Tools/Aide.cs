using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoRale.Tools
{
    class Aide
    {
        public static Int16 parseInt(string num)
        {
            Int16 res;
            if (Int16.TryParse(num, out res))
                return res;
            else
                return 0;
        }
        public static float parseFloat(string num)
        {
            float res;
            if (float.TryParse(num, out res))
                return res;
            else
                return 0;
        }
        public static DateTime parseDate(string num)
        {
            DateTime res;
            if (DateTime.TryParse(num, out res))
                return res;
            else
                return DateTime.MinValue;
        }
    }
}
