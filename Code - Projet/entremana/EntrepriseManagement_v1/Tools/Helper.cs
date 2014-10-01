using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrepriseManagement_v1.Tools
{
    public class Helper
    {
        public static Int16 parseInt(string num)
        {
            Int16 res;
            if (Int16.TryParse(num, out res))
                return res;
            else
                return 0;
        }
    }
}
