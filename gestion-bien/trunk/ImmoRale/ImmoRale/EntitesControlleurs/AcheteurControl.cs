using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoRale.Entites;
using ImmoRale.Tools;

namespace ImmoRale.EntitesControlleurs
{
    public class AcheteurControl
    {
        public Boolean ProcessusEnregistrementSouhait(string nomA, string prenomA, string adrA, string telFixeA, string telMobileA, string mailA, Entites.COMMERCIAL commer, 
            string typeHabiA, string surHabiA, string surParA, string prixA, string villeA,  string statutA)
        {
            ACHETEUR objetAcheteur = new ACHETEUR()
            {
                NomAcheteur = nomA,
                PrenomAcheteur = prenomA,
                AdresseAcheteur = adrA,
                TelephoneFixe = telFixeA,
                TelephoneMobile = telMobileA,
                Email = mailA,
                Commercial = commer.NomCommercial,
                TypeHabitation = typeHabiA,
                SurfaceHabitableMinimale = Aide.parseFloat(surHabiA),
                SurfaceParcelleMinimale = Aide.parseFloat(surParA),
                PrixMaximal = Aide.parseFloat(prixA),
                Ville = villeA,                
                Statut = statutA
            };
            return ACHETEUR.save(objetAcheteur);
        }

        public Boolean MiseAJourBien(ACHETEUR souhait)
        {
            return ACHETEUR.save(souhait);
        }
    }
}
