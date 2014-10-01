using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoRale.Entites;
using ImmoRale.Tools;

namespace ImmoRale.EntitesControlleurs
{
    public class CommercialControl
    {
        public Boolean ProcessusEnregistrementCommercial(string nomC, string prenomC, string adrC, string telFixeC, string telMobileProC,
            string telMobilePriC, string mailC, string agence, string statutC )
        {
            COMMERCIAL objetCom = new COMMERCIAL()
            {
                NomCommercial = nomC,
                PrenomCommercial = prenomC,
                TelephoneFixePro = telFixeC,
                TelephoneMobilePro = telMobileProC,
                TelephoneMobilePri = telMobilePriC,
                Email = mailC,
                AgenceLocale = agence,
                Statut = statutC,
            };
            return COMMERCIAL.save(objetCom);
        }

        public Boolean MiseAJourBien(COMMERCIAL info)
        {
            return COMMERCIAL.save(info);
        }
    }
}
