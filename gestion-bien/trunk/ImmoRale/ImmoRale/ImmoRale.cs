using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImmoRale.Affichage;
using ImmoRale.Entites;

namespace ImmoRale
{
    public partial class GestionBien : Form
    {
        private UserControl usercontrol;
        private TabControl tab;

        public GestionBien()
        {
            InitializeComponent();
            tabControlBiens.Visible = false;
            tabControlAcheteurs.Visible = false;
            tabControlCommerciaux.Visible = false;
            ChangerPage(tabPage1Biens, new SaisieBien());
            ChangerPage(tabPageInformationsAcheteurs, new SaisieAcheteur());
            ChangerPage(tabPageInformationsCom, new SaisieCommercial());
            
        }

        private void ChangerPage(TabPage table, UserControl uc)
        {
            uc.Size = table.Size;
            table.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            table.Controls.Add(uc);
        }        

        private void butBiens_Click(object sender, EventArgs e)
        {
            tabControlAcheteurs.Visible = false;
            tabControlBiens.Visible = true;
            tabControlCommerciaux.Visible = false;
        }

        private void butCommercial_Click(object sender, EventArgs e)
        {
            tabControlAcheteurs.Visible = false;
            tabControlBiens.Visible = false;
            tabControlCommerciaux.Visible = true;
        }

        private void butAcheteur_Click(object sender, EventArgs e)
        {
            tabControlAcheteurs.Visible = true;
            tabControlBiens.Visible = false;
            tabControlCommerciaux.Visible = false;
        }       

        private void tabControlBiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlBiens.SelectedTab == tabPage1Biens)
            {
                ChangerPage(tabPage1Biens, new SaisieBien());
            }
            else if (tabControlBiens.SelectedTab == tabPage2Biens)
            {
                AffichageBien a = new AffichageBien();
                ChangerPage(tabPage2Biens, a);
                a.BienSelected += (s1, e1) =>
                {
                    tabControlBiens.SelectedTab = tabPage1Biens;
                    ChangerPage(tabPage1Biens, new SaisieBien((BIEN)s1));
                };
            }
        }

        private void tabControlAcheteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAcheteurs.SelectedTab == tabPageInformationsAcheteurs)
            {
                ChangerPage(tabPageInformationsAcheteurs, new SaisieAcheteur());
            }
            else if (tabControlAcheteurs.SelectedTab == tabPageListeAcheteurs)
            {
                AffichageAcheteur a = new AffichageAcheteur();
                ChangerPage(tabPageListeAcheteurs, a);
                a.AcheteurSelected += (s1, e1) =>
                {
                    tabControlAcheteurs.SelectedTab = tabPageInformationsAcheteurs;
                    ChangerPage(tabPageInformationsAcheteurs, new SaisieAcheteur((ACHETEUR)s1));
                };
            }
        }

        private void tabControlCommerciaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCommerciaux.SelectedTab == tabPageInformationsCom)
            {
                ChangerPage(tabPageInformationsCom, new SaisieCommercial());
            }
            else if (tabControlCommerciaux.SelectedTab == tabPageListeCom)
            {
                AffichageCommercial a = new AffichageCommercial();
                ChangerPage(tabPageListeCom, a);
                a.CommercialSelected += (s1, e1) =>
                {
                    tabControlCommerciaux.SelectedTab = tabPageInformationsCom;
                    ChangerPage(tabPageInformationsCom, new SaisieCommercial((COMMERCIAL)s1));
                };
            }
        }        
    }
}
