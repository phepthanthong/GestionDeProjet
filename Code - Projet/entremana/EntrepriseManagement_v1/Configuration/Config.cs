using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntrepriseManagement_v1.Configuration
{
    public class Config
    {
        //...\bin\Debug\Database\entreprise.db
        //public static string DB_PATH = Path.GetFullPath(".\\Database\\entreprise.db");

        //...\Datbase\entreprise.db
        public static string DB_PATH = ".\\Database\\entreprise.db";

        public static String[] ALL_ROLES = { "Thợ chính", "Thợ phụ" };

        //public static int TAP_ADD_EDIT_EMPLOYEE = 0;
    }
}
