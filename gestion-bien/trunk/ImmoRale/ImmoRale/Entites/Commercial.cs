using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoRale.NewDB;
using ImmoRale.Tools;

namespace ImmoRale.Entites
{
    public class COMMERCIAL
    {
        #region attributs

        Guid id = Guid.Empty;
        string nomCommercial;
        string prenomCommercial;
        string adresse;
        string telephoneFixePro;
        string telephoneMobilePro;
        string telephoneMobilePri;
        string email;
        string agenceLocale;
        string statut;

        #endregion

        #region preprietes

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NomCommercial
        {
            get { return nomCommercial; }
            set { nomCommercial = value; }
        }

        public string PrenomCommercial
        {
            get { return prenomCommercial; }
            set { prenomCommercial = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string TelephoneFixePro
        {
            get { return telephoneFixePro; }
            set { telephoneFixePro = value; }
        }

        public string TelephoneMobilePro
        {
            get { return telephoneMobilePro; }
            set { telephoneMobilePro = value; }
        }

        public string TelephoneMobilePri
        {
            get { return telephoneMobilePri; }
            set { telephoneMobilePri = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string AgenceLocale
        {
            get { return agenceLocale; }
            set { agenceLocale = value; }
        }

        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        #endregion

        private static string Table_Name = "COMMERCIAL";
        private static string[] Column = { "ID", "NomCommercial", "PrenomCommercial", "Adresse", "TelephoneFixePro", "TelephoneMobilePro", 
                                             "TelephoneMobilePri", "Email", "AgenceLocale", "Statut"};

        private static COMMERCIAL create(Dictionary<string, object> dict)
        {
            COMMERCIAL oj = new COMMERCIAL()
            {
                id = Guid.Parse((String)dict["id"]),
                NomCommercial = (String)dict["nomcommercial"],
                PrenomCommercial = (String)dict["prenomcommercial"],
                Adresse = (String)dict["adresse"],
                TelephoneFixePro = (String)dict["telephonefixepro"],
                TelephoneMobilePro = (String)dict["telephonemobilepro"],
                TelephoneMobilePri = (String)dict["telephonemobilepri"],
                Email = (String)dict["email"],
                AgenceLocale = (String)dict["agencelocale"],
                Statut = (String)dict["statut"]
                
            };
            return oj;
        }

        private String[] getValue()
        {
            return new String[] { "'" + ID.ToString() + "'", "'" + NomCommercial + "'", "'" + PrenomCommercial + "'", "'" + Adresse + "'", "'" + TelephoneFixePro + "'", "'" + TelephoneMobilePro + "'", "'" + TelephoneMobilePri + "'", 
                "'" + Email + "'", "'" + AgenceLocale + "'", "'" + Statut + "'", };
        }

        public static COMMERCIAL getFirst(string where)
        {
            COMMERCIAL res = null;
            var tmp = DbManager.getFirst(ImmoRale.Configuration.Config.CHEMIN, Table_Name, where);
            if (tmp != null)
            {
                res = create(tmp);
            }
            return res;
        }

        public static List<COMMERCIAL> getList(string where)
        {
            List<COMMERCIAL> res = null;
            var temp = DbManager.getList(ImmoRale.Configuration.Config.CHEMIN, Table_Name, where);
            if (temp != null)
            {
                res = new List<COMMERCIAL>();

                foreach (Dictionary<string, object> entry in temp)
                {
                    res.Add(create(entry));
                }
            }
            return res;
        }

        public static Boolean save(COMMERCIAL obj)
        {
            if (obj.ID == Guid.Empty)
            {
                return insert(obj);
            }
            else
            {
                return update(obj);
            }
        }

        private static Boolean insert(COMMERCIAL obj)
        {
            obj.id = Guid.NewGuid();
            return DbManager.insert(ImmoRale.Configuration.Config.CHEMIN, Table_Name, Column, obj.getValue());
        }

        private static Boolean update(COMMERCIAL obj)
        {
            return DbManager.update(ImmoRale.Configuration.Config.CHEMIN, Table_Name, Column, obj.getValue(), Table_Name + ".ID = '" + obj.ID + "'");
        }

        //public static Boolean delete(BIEN obj)
        //{
        //  return DbManager.delete(CHEMIN, Table_Name, Table_Name + ".ID = '" + obj.Id + "'");
        //}
    }
}
