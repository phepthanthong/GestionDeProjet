using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoRale.NewDB;
using ImmoRale.Tools;

namespace ImmoRale.Entites
{
    public class ACHETEUR
    {
        #region attributs
        private Guid id = Guid.Empty;
        private string nomAcheteur;
        private string prenomAcheteur;
        private string adresseAcheteur;
        private string telephoneFixe;
        private string telephoneMobile;
        private string email;
        private string ville;
        private string quartier;
        private string typeHabitation;
        private float surfaceHabitableMinimale;
        private float surfaceParcelleMinimale;
        private float prixMaximal;
        private string commercial;
        private string statut;

        #endregion

        #region propriétés
        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NomAcheteur
        {
            get { return nomAcheteur; }
            set { nomAcheteur = value; }
        }

        public string PrenomAcheteur
        {
            get { return prenomAcheteur; }
            set { prenomAcheteur = value; }
        }

        public string AdresseAcheteur
        {
            get { return adresseAcheteur; }
            set { adresseAcheteur = value; }
        }

        public string TelephoneFixe
        {
            get { return telephoneFixe; }
            set { telephoneFixe = value; }
        }

        public string TelephoneMobile
        {
            get { return telephoneMobile; }
            set { telephoneMobile = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }       

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public string Quartier
        {
            get { return quartier; }
            set { quartier = value; }
        }

        public string TypeHabitation
        {
            get { return typeHabitation; }
            set { typeHabitation = value; }
        }

        public float SurfaceHabitableMinimale
        {
            get { return surfaceHabitableMinimale; }
            set { surfaceHabitableMinimale = value; }
        }

        public float SurfaceParcelleMinimale
        {
            get { return surfaceParcelleMinimale; }
            set { surfaceParcelleMinimale = value; }
        }

        public float PrixMaximal
        {
            get { return prixMaximal; }
            set { prixMaximal = value; }
        }

        public string Commercial
        {
            get { return commercial; }
            set { commercial = value; }
        }        

        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }
        #endregion

        private static string Table_Name = "ACHETEUR";
        public static string Path = "C:\\Users\\Hieu\\Desktop\\GestionDeProjet\\gestion-bien\\trunk\\ImmoRale\\ImmoRale\\Database\\immoraledatabase.db";
        private static string[] Column = { "ID", "NomAcheteur", "PrenomAcheteur", "AdresseAcheteur", "TelephoneFixe", "TelephoneMobile", "Email",
                                             "Ville", "Quartier", "TypeHabitation", "SurfaceHabitableMinimale", "SurfaceParcelleMinimale", "PrixMaximal", "Commercial", "Statut" };

        private static ACHETEUR create(Dictionary<string, object> dict)
        {
            ACHETEUR oj = new ACHETEUR()
            {
                id = Guid.Parse((String)dict["id"]),
                NomAcheteur = (String)dict["nomacheteur"],
                PrenomAcheteur = (String)dict["prenomacheteur"],
                AdresseAcheteur = (String)dict["adresseacheteur"],
                TelephoneFixe = (String)dict["telephonefixe"],
                TelephoneMobile = (String)dict["telephonemobile"],
                Email = (String)dict["email"],
                Ville = (String)dict["ville"],
                Quartier = (String)dict["quartier"],
                TypeHabitation = (String)dict["typehabitation"],
                SurfaceHabitableMinimale = Aide.parseFloat(dict["surfacehabitableminimale"].ToString()),
                SurfaceParcelleMinimale = Aide.parseFloat(dict["surfaceparcelleminimale"].ToString()),
                PrixMaximal = Aide.parseFloat(dict["prixmaximal"].ToString()),
                Commercial = (String)dict["commercial"],
                Statut = (String)dict["statut"]
            };
            return oj;
        }

        private String[] getValue()
        {
            return new String[] { "'" + ID.ToString() + "'", "'" + nomAcheteur + "'", "'" + PrenomAcheteur + "'", "'" + AdresseAcheteur + "'", "'" + TelephoneFixe + "'", "'" + TelephoneMobile + "'", "'" + Email + "'", 
                "'" + Ville + "'","'" + Quartier + "'", "'" + TypeHabitation + "'", "'" + SurfaceHabitableMinimale + "'", "'" + SurfaceParcelleMinimale + "'", "'" + PrixMaximal + "'", "'" + Commercial + "'", "'" + Statut + "'" };
        }

        public static ACHETEUR getFirst(string where)
        {
            ACHETEUR res = null;
            var tmp = DbManager.getFirst(Path, Table_Name, where);
            if (tmp != null)
            {
                res = create(tmp);
            }
            return res;
        }

        public static List<ACHETEUR> getList(string where)
        {
            List<ACHETEUR> res = null;
            var temp = DbManager.getList(Path, Table_Name, where);
            if (temp != null)
            {
                res = new List<ACHETEUR>();

                foreach (Dictionary<string, object> entry in temp)
                {
                    res.Add(create(entry));
                }
            }
            return res;
        }

        public static Boolean save(ACHETEUR obj)
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

        private static Boolean insert(ACHETEUR obj)
        {
            obj.id = Guid.NewGuid();
            return DbManager.insert(Path, Table_Name, Column, obj.getValue());
        }

        private static Boolean update(ACHETEUR obj)
        {
            return DbManager.update(Path, Table_Name, Column, obj.getValue(), Table_Name + ".ID = '" + obj.ID + "'");
        }

        //public static Boolean delete(ACHETEUR obj)
        //{
        //  return DbManager.delete(Path, Table_Name, Table_Name + ".ID = '" + obj.Id + "'");
        //}
    }
}
