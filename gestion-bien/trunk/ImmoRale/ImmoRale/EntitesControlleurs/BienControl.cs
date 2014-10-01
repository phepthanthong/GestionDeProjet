using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoRale.Entites;
using ImmoRale.Tools;

namespace ImmoRale.EntitesControlleurs
{
    public class BienControl
    {
        public Boolean ProcessusEnregistrementBien(string nomp, string prenomp, string adrp, string telfixe, string telmobile, string mailp, string adrbien, string quartierbien, 
            string typehabi, string surhabi, string surpar, int nbrchambres, int nbrtoilettes, string datemiseenvente, string dateventereelle, string prixsouhait,
            string prixrelle, string statut, string comment, /*string idvend,*/ string idache)
        {
            BIEN objetBien = new BIEN()
            {
                NomProprietaire = nomp,
                PrenomProprietaire = prenomp,
                AdresseProprietaire = adrp,
                TelephoneFixe = telfixe,
                TelephoneMobile = telmobile,
                Email = mailp,
                Adresse = adrbien,
                Quartier = quartierbien,
                TypeHabitation = typehabi,
                SurfaceHabitable = Aide.parseFloat(surhabi),
                SurfaceParcelle = Aide.parseFloat(surpar),
                NombreChambres = nbrchambres,
                NombreToilettes = nbrtoilettes,
                DateMiseEnVente = datemiseenvente,
                DateVenteReelle = dateventereelle,
                PrixVenteSouhaite = Aide.parseFloat(prixsouhait),
                PrixVenteReel = Aide.parseFloat(prixrelle),
                Statut = statut,
                Commentaires = comment,
                //IdVendeur = idvend,
                IdAcheteur = idache
            };
            return BIEN.save(objetBien);
        }

        public Boolean MiseAJourBien(BIEN bien)
        {
            return BIEN.save(bien);
        }
    }
}
