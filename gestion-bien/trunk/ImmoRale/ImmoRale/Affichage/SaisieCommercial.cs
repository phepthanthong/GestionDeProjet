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
using ImmoRale.EntitesControlleurs;

namespace ImmoRale.Affichage
{
    public partial class SaisieCommercial : UserControl
    {
        private COMMERCIAL com = new COMMERCIAL();

        public SaisieCommercial(COMMERCIAL c = null)
        {
            InitializeComponent();
            ChargerComboBox();
            if (c != null)
                ChargerDonneeCom(c);
        }

        private void ChargerComboBox()
        {
            foreach (String statut in Configuration.Config.STATUT_COMMERCIAL)
                cbStatutCom.Items.Add(statut);
            foreach (String agence in Configuration.Config.AGENCELOCALE)
                cbAgenceLocale.Items.Add(agence);
            cbStatutCom.SelectedItem = 0;
        }

        #region Regles TextBox
        // même regle pour tous les TextBox dont l'entree est un numero
        private void txtTelFixeCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("SEUL LES NUMEROS SONT ACCEPTES ! VEUILLEZ ENTRER DE NOUVEAU", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        #endregion

        private void ChargerDonneeCom(COMMERCIAL charger)
        {
            com = charger;
            butEnregistrerCom.Text = "Mise A Jour";
            txtNomCom.Text = charger.NomCommercial;
            txtPrenomCom.Text = charger.PrenomCommercial;
            txtAdrCom.Text = charger.Adresse;
            txtMailCom.Text = charger.Email;
            txtTelFixeCom.Text = charger.TelephoneFixePro;
            txtTelMobileProCom.Text = charger.TelephoneMobilePro;
            txtTelMobileProPrive.Text = charger.TelephoneMobilePri;
            cbAgenceLocale.SelectedItem = charger.AgenceLocale;
            cbStatutCom.SelectedItem = charger.Statut;
        }

        private void ProcessusEnregistrementCommercial(string nomC, string prenomC, string adrC, string telFixeC, string telMobileProC,
            string telMobilePriC, string mailC, string agence, string statutC)
        {
            if (nomC.Trim() == String.Empty || prenomC.Trim() == String.Empty || adrC.Trim() == String.Empty || telFixeC.Trim() == String.Empty || telMobileProC.Trim() == String.Empty ||
                telMobilePriC.Trim() == String.Empty || mailC.Trim() == String.Empty || agence.Trim() == String.Empty || statutC.Trim() == String.Empty) ;
            else
            {
                CommercialControl cc = new CommercialControl();
                if (com == null)
                {
                    if (!cc.ProcessusEnregistrementCommercial(nomC, prenomC, adrC, telFixeC, telMobileProC, telMobilePriC, mailC, agence, statutC))
                        MessageBox.Show("ERREUR D'ENREGISTREMENT", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Enregistrement reussi! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    com.NomCommercial = nomC;
                    com.PrenomCommercial = prenomC;
                    com.Adresse = adrC;
                    com.TelephoneFixePro = telFixeC;
                    com.TelephoneMobilePro = telMobileProC;
                    com.TelephoneMobilePri = telMobilePriC;
                    com.Email = mailC;
                    com.AgenceLocale = agence;
                    com.Statut = statutC;

                    if (!cc.MiseAJourBien(com))
                        MessageBox.Show("ERREUR DE LA MISE A JOUR D'UN NOUVEAU COMMERCIAL!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("Mise a jour reussi! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butEnregistrerCom_Click(object sender, EventArgs e)
        {
            ProcessusEnregistrementCommercial(txtNomCom.Text, txtPrenomCom.Text, txtAdrCom.Text, txtTelFixeCom.Text, txtTelMobileProCom.Text, txtTelMobileProPrive.Text, txtMailCom.Text, cbAgenceLocale.Text, cbStatutCom.Text);
        }

        private void butNouveauCom_Click(object sender, EventArgs e)
        {
            com = null;
            butEnregistrerCom.Text = "Enregistrer";
            txtNomCom.Text = "";
            txtPrenomCom.Text = "";
            txtAdrCom.Text = "";
            txtMailCom.Text = "";
            txtTelFixeCom.Text = "";
            txtTelMobileProCom.Text = "";
            txtTelMobileProPrive.Text = "";
            cbAgenceLocale.Text = "";
            cbStatutCom.Text = "";
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Parent.Parent.Parent.Parent.Parent.Visible = false;
        }

    }
        
}
