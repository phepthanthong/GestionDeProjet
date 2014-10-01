using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImmoRale.Configuration
{
    public class Config
    {
        public static string CHEMIN = "C:\\Users\\Hieu\\Desktop\\GestionDeProjet\\gestion-bien\\trunk\\ImmoRale\\ImmoRale\\Database\\immoraledatabase.db";
        public static String[] TYPEHABITATION = { "Maison", "Appartement" };
        public static String[] STATUT_BIEN = { "DISPONIBLE", "SOUS-SEING", "VENDU", "RETIRE" };
        public static String[] VILLES_SOUHAITEES = { "HO CHI MINH - VILLE", "HANOI", "CAN THO", "LONG AN", "TIEN GIANG" };
        public static String[] QUARTIERS_SOUHAITES = { "DISTRICT 1", "DISTRICT 2", "DISTRICT 3", "DISTRICT 4", "DISTRICT 5", "DISTRICT 7", };
        public static String[] STATUT_FICHESOUHAIT = { "EN COURS", "OBSOLETE" };
        public static String[] STATUT_COMMERCIAL = { "ACTIF", "ANCIEN" };
        public static String[] AGENCELOCALE = { "BORDEAUX", "TOULOUSE", "PARIS" };
    }
}
