using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoRale.NewDB;
using ImmoRale.Tools;
using ImmoRale.Configuration;

namespace ImmoRale.Entites
{
    public class BIEN
    {
        #region attributs
        private Guid id = Guid.Empty;
        private string nomProprietaire;
        private string prenomProprietaire;
        private string adresseProprietaire;
        private string telephoneFixe;
        private string telephoneMobile;
        private string email;
        private string adresse;
        private string quartier;
        private string typeHabitation;
        private float surfaceHabitable;
        private float surfaceParcelle;
        private int nombreChambres;
        private int nombreToilettes; 
        private string dateMiseEnVente;
        private string dateVenteReelle;
        private float prixVenteSouhaite;
        private float prixVenteReel;
        private string statut;
        private string commentaires;
        private string idVendeur;
        private string idAcheteur;
        #endregion

        #region propriétés
        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NomProprietaire
        {
            get { return nomProprietaire; }
            set { nomProprietaire = value; }
        }

        public string PrenomProprietaire
        {
            get { return prenomProprietaire; }
            set { prenomProprietaire = value; }
        }

        public string AdresseProprietaire
        {
            get { return adresseProprietaire; }
            set { adresseProprietaire = value; }
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

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
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

        public float SurfaceHabitable
        {
            get { return surfaceHabitable; }
            set { surfaceHabitable = value; }
        }

        public float SurfaceParcelle
        {
            get { return surfaceParcelle; }
            set { surfaceParcelle = value; }
        }

        public int NombreChambres
        {
            get { return nombreChambres; }
            set { nombreChambres = value; }
        }

        public int NombreToilettes
        {
            get { return nombreToilettes; }
            set { nombreToilettes = value; }
        }

        public string DateMiseEnVente
        {
            get { return dateMiseEnVente; }
            set { dateMiseEnVente = value; }
        }

        public string DateVenteReelle
        {
            get { return dateVenteReelle; }
            set { dateVenteReelle = value; }
        }

        public float PrixVenteSouhaite
        {
            get { return prixVenteSouhaite; }
            set { prixVenteSouhaite = value; }
        }

        public float PrixVenteReel
        {
            get { return prixVenteReel; }
            set { prixVenteReel = value; }
        }

        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        public string Commentaires
        {
            get { return commentaires; }
            set { commentaires = value; }
        }

        public string IdVendeur
        {
            get { return idVendeur; }
            set { idVendeur = value; }
        }

        public string IdAcheteur
        {
            get { return idAcheteur; }
            set { idAcheteur = value; }
        }

        
        #endregion

        private static string Table_Name = "BIEN";        
        private static string[] Column = { "ID", "NomProprietaire", "PrenomProprietaire", "AdresseProprietaire", "TelephoneFixe", "TelephoneMobile", "Email",
                                             "Adresse", "Quartier", "TypeHabitation", "SurfaceHabitable", "SurfaceParcelle", "NombreChambres", "NombreToilettes", 
                                             "DateMiseEnVente", "DateVenteReelle", "PrixVenteSouhaite", "PrixVenteReel", "Statut", "Commentaires", "IDVendeur", "IDAcheteur"  };

        private static BIEN create(Dictionary<string, object> dict)
        {
            BIEN oj = new BIEN()
            {
                id = Guid.Parse((String)dict["id"]),
                NomProprietaire = (String)dict["nomproprietaire"],
                PrenomProprietaire = (String)dict["prenomproprietaire"],
                AdresseProprietaire = (String)dict["adresseproprietaire"],
                TelephoneFixe = (String)dict["telephonefixe"],
                TelephoneMobile = (String)dict["telephonemobile"],
                Email = (String)dict["email"],
                Adresse = (String)dict["adresse"],
                Quartier = (String)dict["quartier"],
                TypeHabitation = (String)dict["typehabitation"],
                SurfaceHabitable = Aide.parseFloat(dict["surfacehabitable"].ToString()),
                SurfaceParcelle = Aide.parseFloat(dict["surfaceparcelle"].ToString()),
                NombreChambres = Aide.parseInt(dict["nombrechambres"].ToString()),
                NombreToilettes = Aide.parseInt(dict["nombretoilettes"].ToString()),
                DateMiseEnVente = (String)dict["datemiseenvente"],
                DateVenteReelle = (String)dict["dateventereelle"],
                PrixVenteSouhaite = Aide.parseInt(dict["prixventesouhaite"].ToString()),
                PrixVenteReel = Aide.parseInt(dict["prixventereel"].ToString()),
                Statut = (String)dict["statut"],
                Commentaires = (String)dict["commentaires"],
                IdVendeur = (String)dict["idvendeur"],
                IdAcheteur = (String)dict["idacheteur"]
            };
            return oj;
        }

        private String[] getValue()
        {
            return new String[] { "'" + ID.ToString() + "'", "'" + NomProprietaire + "'", "'" + PrenomProprietaire + "'", "'" + AdresseProprietaire + "'", "'" + TelephoneFixe + "'", "'" + TelephoneMobile + "'", "'" + Email + "'", 
                "'" + Adresse + "'", "'" + Quartier + "'", "'" + TypeHabitation + "'", "'" + SurfaceHabitable + "'", "'" + SurfaceParcelle + "'", "'" + NombreChambres + "'", "'" + NombreToilettes + "'", 
                "'" + DateMiseEnVente + "'", "'" + DateVenteReelle + "'", "'" + PrixVenteSouhaite + "'", "'" + PrixVenteReel + "'", "'" + Statut + "'", "'" + Commentaires + "'", "'" + IdVendeur + "'", "'" + IdAcheteur + "'", };
        }

        public static BIEN getFirst(string where)
        {
            BIEN res = null;
            var tmp = DbManager.getFirst(ImmoRale.Configuration.Config.CHEMIN, Table_Name, where);
            if (tmp != null)
            {
                res = create(tmp);
            }
            return res;
        }

        public static List<BIEN> getList(string where)
        {
            List<BIEN> res = null;
            var temp = DbManager.getList(ImmoRale.Configuration.Config.CHEMIN, Table_Name, where);
            if (temp != null)
            {
                res = new List<BIEN>();

                foreach (Dictionary<string, object> entry in temp)
                {
                    res.Add(create(entry));
                }
            }
            return res;
        }

        public static Boolean save(BIEN obj)
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

        private static Boolean insert(BIEN obj)
        {
            obj.id = Guid.NewGuid();
            return DbManager.insert(ImmoRale.Configuration.Config.CHEMIN, Table_Name, Column, obj.getValue());
        }

        private static Boolean update(BIEN obj)
        {
            return DbManager.update(ImmoRale.Configuration.Config.CHEMIN, Table_Name, Column, obj.getValue(), Table_Name + ".ID = '" + obj.ID + "'");
        }

        //public static Boolean delete(BIEN obj)
        //{
        //  return DbManager.delete(CHEMIN, Table_Name, Table_Name + ".ID = '" + obj.Id + "'");
        //}
    }
}
