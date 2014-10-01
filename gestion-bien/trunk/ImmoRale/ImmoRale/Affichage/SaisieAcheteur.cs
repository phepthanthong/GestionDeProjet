using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImmoRale.Entites;
using ImmoRale.Tools;
using ImmoRale.EntitesControlleurs;

namespace ImmoRale.Affichage
{
    public partial class SaisieAcheteur : UserControl
    {
        private ACHETEUR souhait = new ACHETEUR();
        private List<COMMERCIAL> lsCom;

        public SaisieAcheteur(ACHETEUR ache = null) 
        {
            InitializeComponent();
            ChargerComboBox();
            if (ache != null)
                ChargerDonneeAche(ache);
        }

        private void ChargerComboBox()
        {
            foreach (String type in ImmoRale.Configuration.Config.TYPEHABITATION)                            
                cbTypeHabiAche.Items.Add(type);                        
            foreach (String ville in ImmoRale.Configuration.Config.VILLES_SOUHAITEES)
                cbVilleSouAche.Items.Add(ville);            
            foreach (String sta in Configuration.Config.STATUT_FICHESOUHAIT)
                cbStatutFicheSou.Items.Add(sta);
            cbStatutFicheSou.SelectedIndex = 0;            
            cbTypeHabiAche.SelectedIndex = 0;
            cbVilleSouAche.SelectedIndex = 0;
            lsCom = Entites.COMMERCIAL.getList("");
            cbCommercial.DataSource = lsCom;
            cbCommercial.DisplayMember = "NomCommercial";
        }

        private void ChargerDonneeAche(ACHETEUR charge)
        {
            souhait = charge;
            butEnregistrerAche.Text = "Mise A Jour";
            txtNomAche.Text = charge.NomAcheteur;
            txtPrenomAche.Text = charge.PrenomAcheteur;
            txtTelFixeAche.Text = charge.TelephoneFixe;
            txtTelMobileAche.Text = charge.TelephoneMobile;
            txtMailAche.Text = charge.Email;
            txtAdrAche.Text = charge.AdresseAcheteur;
            cbVilleSouAche.SelectedItem = charge.Ville;            
            cbTypeHabiAche.SelectedItem = charge.TypeHabitation;
            txtSurHabiAche.Text = charge.SurfaceHabitableMinimale.ToString();
            txtSurParAche.Text = charge.SurfaceParcelleMinimale.ToString();
            txtPrixMaxiAche.Text = charge.PrixMaximal.ToString();
            //txtComAche.Text = charge.Commercial;
            cbStatutFicheSou.SelectedItem = charge.Statut;            
        }

        public void ProcessusEnregistrementSouhait(string nom_A, string prenom_A, string adr_A, string telfixe_A, string telmobile_A, string mail_A, Entites.COMMERCIAL com,
            string typehabi_A, string surhabi_A, string surpar_A, string prix_A, string ville_A, string statut_A)
        {
            if (nom_A.Trim() == String.Empty || prenom_A.Trim() == String.Empty || adr_A.Trim() == String.Empty || telfixe_A.Trim() == String.Empty || telmobile_A.Trim() == String.Empty ||
                mail_A.Trim() == String.Empty || typehabi_A.Trim() == String.Empty || surhabi_A.Trim() == String.Empty || surpar_A.Trim() == String.Empty ||
                prix_A.Trim() == String.Empty || ville_A.Trim() == String.Empty || statut_A.Trim() == String.Empty )
                MessageBox.Show("Certains champs sont vide ! Veuillez entrer de nouveau ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                AcheteurControl ac = new AcheteurControl();
                if (souhait == null)
                {
                    if (!ac.ProcessusEnregistrementSouhait(nom_A, prenom_A, adr_A, telfixe_A, telmobile_A, mail_A, com, typehabi_A, surhabi_A, surpar_A, prix_A, ville_A,  statut_A))
                        MessageBox.Show("ERREUR D'ENREGISTREMENT", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    { 
                        MessageBox.Show("Enregistrement reussi! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChercherBien();
                    }                       
                }
                else
                {
                    souhait.NomAcheteur = nom_A;
                    souhait.PrenomAcheteur = prenom_A;
                    souhait.AdresseAcheteur = adr_A;
                    souhait.TelephoneFixe = telfixe_A;
                    souhait.TelephoneMobile = telmobile_A;
                    souhait.Email = mail_A;
                    souhait.Commercial = com.NomCommercial;
                    souhait.TypeHabitation = typehabi_A;
                    souhait.SurfaceHabitableMinimale = Aide.parseFloat(surhabi_A);
                    souhait.SurfaceParcelleMinimale = Aide.parseFloat(surpar_A);
                    souhait.PrixMaximal = Aide.parseFloat(prix_A);
                    souhait.Ville = ville_A;
                    souhait.Statut = statut_A;

                    if (!ac.MiseAJourBien(souhait))
                        MessageBox.Show("ERREUR DE LA MISE A JOUR D'UNE NOUVELLE FICHE DE SOUHAITS!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Mise a jour reussi! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChercherBien();
                    }
                }
            }
        }

        private void butEnregistrerAche_Click(object sender, EventArgs e)
        {            
            ProcessusEnregistrementSouhait(txtNomAche.Text, txtPrenomAche.Text, txtAdrAche.Text, txtTelFixeAche.Text, txtTelMobileAche.Text, txtMailAche.Text, (Entites.COMMERCIAL)cbCommercial.SelectedItem,
                cbTypeHabiAche.Text, txtSurHabiAche.Text, txtSurParAche.Text, txtPrixMaxiAche.Text, cbVilleSouAche.Text, cbStatutFicheSou.Text);
            
        }

        private void ChercherBien()
        {
            List<Entites.BIEN> lsbien;
            string str = "";
            if (txtPrixMaxiAche.Text != "0")
            {
                
                str += "AND PrixVenteSouhaite  < " + txtPrixMaxiAche.Text;
                
            }
                lsbien = Entites.BIEN.getList(String.Format("TypeHabitation = '{0}' AND SurfaceHabitable > {1} AND SurfaceParcelle > {2} AND Quartier = '{3}'" + str, cbTypeHabiAche.SelectedItem,txtSurHabiAche.Text,txtSurParAche.Text, cbVilleSouAche.SelectedItem));
                DGViewBienCorrespondant.DataSource = lsbien;
        }

        private void butAjoutFicheSou_Click(object sender, EventArgs e)
        {
            souhait = null;
            cbTypeHabiAche.Text = "";
            txtSurHabiAche.Text = "";
            txtSurParAche.Text = "";
            cbVilleSouAche.Text = "";
        }

        private void butNouveauFiche_Click(object sender, EventArgs e)
        {
            souhait = null;
            butEnregistrerAche.Text = "Enregistrer";
            txtNomAche.Text = "";
            txtPrenomAche.Text = "";
            txtAdrAche.Text = "";
            txtTelFixeAche.Text = "";
            txtTelMobileAche.Text = "";
            txtMailAche.Text = "";
            //txtComAche.Text = "";
            cbTypeHabiAche.Text = "";
            txtSurHabiAche.Text = "";
            txtSurParAche.Text = "";
            cbVilleSouAche.Text = "";
            cbStatutFicheSou.Text = "";
        }

        private void butAnnulerAche_Click(object sender, EventArgs e)
        {
            Parent.Parent.Parent.Parent.Parent.Visible = false;
        }

        private void txtTelFixeAche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("SEUL LES NUMEROS SONT ACCEPTES ! VEUILLEZ ENTRER DE NOUVEAU", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
