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
using Maquette.cs;
using ImmoRale.Tools;
using ImmoRale.Configuration;
using ImmoRale.EntitesControlleurs;

namespace ImmoRale.Affichage
{
    public partial class SaisieBien : UserControl
    {
        private BIEN bien = new BIEN();
        //private SaisieBien saisie = new SaisieBien();

        public SaisieBien(BIEN house = null)
        {
            InitializeComponent();
            ChargerComboBox();
            if(house != null)
            {
                ChargerDonneeBien(house);
            }            
        }

        private void ChargerComboBox()
        {
            foreach (String type in ImmoRale.Configuration.Config.TYPEHABITATION )
            {
                comboType.Items.Add(type);                
            }            
            foreach (String ville in ImmoRale.Configuration.Config.STATUT_BIEN)
            {
                comboStatut.Items.Add(ville);
            }
            comboStatut.SelectedIndex = 0;
            foreach (String ville in ImmoRale.Configuration.Config.VILLES_SOUHAITEES)
            {
                comboVille.Items.Add(ville);
            }
        }

        private void ChargerDonneeBien(BIEN charge)
        {            
            bien = charge;
            butEnregistrer.Text = "Mise a jour";
            txtNomPro.Text = charge.NomProprietaire;
            txtPrenomPro.Text = charge.PrenomProprietaire;
            txtAdrPro.Text = charge.AdresseProprietaire;
            txtTelFixePro.Text = charge.TelephoneFixe;
            txtTelMobilePro.Text = charge.TelephoneMobile;
            txtMailPro.Text = charge.Email;
            txtAdrBien.Text = charge.Adresse;
            comboVille.SelectedItem = charge.Quartier;
            comboType.SelectedItem = charge.TypeHabitation;
            txtSurHabi.Text = charge.SurfaceHabitable.ToString();
            txtSurPar.Text = charge.SurfaceParcelle.ToString();
            numNbrChambres.Value = charge.NombreChambres;
            numNbrToilettes.Value = charge.NombreToilettes;
            txtAcheteur.Text = charge.IdAcheteur;
            dateMiseEnVente.Value = Aide.parseDate(charge.DateMiseEnVente.ToString());
            dateVenteReelle.Value = Aide.parseDate(charge.DateVenteReelle.ToString());
            txtPrixSouhaite.Text = charge.PrixVenteSouhaite.ToString();
            txtPrixVenteReel.Text = charge.PrixVenteReel.ToString();
            txtCommentaires.Text = charge.Commentaires;
            comboStatut.SelectedItem = charge.Statut;
        }
        private void ProcessusEnregistrementBien(string nomp, string prenomp, string adrp, string telfixe, string telmobile, string mailp, string adrbien, string quartierbien, 
            string typehabi, string surhabi, string surpar, int nbrchambres, int nbrtoilettes, string datemiseenvente, string dateventereelle, string prixsouhait,
            string prixrelle, string statut, string comment, /*string idvend,*/ string idache)
        {
            if (nomp.Trim() == String.Empty || prenomp.Trim() == String.Empty || adrp.Trim() == String.Empty || telfixe.Trim() == String.Empty || telmobile.Trim() == String.Empty ||
                mailp.Trim() == String.Empty || adrbien.Trim() == String.Empty || quartierbien.Trim() == String.Empty || typehabi.Trim() == String.Empty || surhabi.Trim() == String.Empty ||
                surpar.Trim() == String.Empty || datemiseenvente.Trim() == String.Empty || prixsouhait.Trim() == String.Empty || statut.Trim() == String.Empty || comment.Trim() == String.Empty)
                MessageBox.Show("Certains champs sont vide ! Veuillez entrer de nouveau ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                BienControl bc = new BienControl();
                if (bien == null)
                {
                    if (!bc.ProcessusEnregistrementBien(nomp, prenomp, adrp, telfixe, telmobile, mailp, adrbien, quartierbien, typehabi, surhabi, surpar, nbrchambres, nbrtoilettes, datemiseenvente, dateventereelle, prixsouhait, prixrelle, statut, comment, idache))
                        MessageBox.Show("ERREUR D'ENREGISTREMENT", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Enregistrement reussi! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bien.NomProprietaire = nomp;
                    bien.PrenomProprietaire = prenomp;
                    bien.AdresseProprietaire = adrp;
                    bien.TelephoneFixe = telfixe;
                    bien.TelephoneMobile = telmobile;
                    bien.Email = mailp;
                    bien.Adresse = adrbien;
                    bien.Quartier = quartierbien;
                    bien.SurfaceHabitable = Aide.parseFloat(surhabi);
                    bien.SurfaceParcelle = Aide.parseFloat(surpar);
                    bien.TypeHabitation = typehabi;
                    bien.NombreChambres = nbrchambres;
                    bien.NombreToilettes = nbrtoilettes;
                    bien.DateMiseEnVente = datemiseenvente;
                    bien.DateVenteReelle = dateventereelle;
                    bien.PrixVenteSouhaite = Aide.parseFloat(prixsouhait);
                    bien.PrixVenteReel = Aide.parseFloat(prixrelle);
                    bien.Statut = statut;
                    bien.Commentaires = comment;
                    bien.IdAcheteur = idache;                    

                    if (!bc.MiseAJourBien(bien))
                        MessageBox.Show("ERREUR DE LA MISE A JOUR D'UN NOUVEAU BIEN!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("Mise a jour reussi! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butEnregistrer_Click(object sender, EventArgs e)
        {
            //bien.NomProprietaire = txtNomPro.Text;           

            ProcessusEnregistrementBien(txtNomPro.Text, txtPrenomPro.Text, txtAdrPro.Text, txtTelFixePro.Text, txtTelMobilePro.Text, txtMailPro.Text,
                txtAdrBien.Text, comboVille.SelectedItem.ToString(), comboType.Text, (String)txtSurHabi.Text, (String)txtSurPar.Text, (int)numNbrChambres.Value, (int)numNbrToilettes.Value,
                dateMiseEnVente.Text, dateVenteReelle.Text, txtPrixSouhaite.Text, txtPrixVenteReel.Text, comboStatut.Text, txtCommentaires.Text, txtAcheteur.Text);
        }
        

        private void butNouveau_Click(object sender, EventArgs e)
        {
            bien = null;
            butEnregistrer.Text = "Enregistrer";
            txtNomPro.Text = "";
            txtPrenomPro.Text = "";
            txtAdrPro.Text = "";
            txtTelFixePro.Text = "";
            txtTelMobilePro.Text = "";
            txtAdrBien.Text = "";
            comboType.Text = "";
            txtSurHabi.Text = "";
            txtSurPar.Text = "";
            numNbrChambres.Value = 0;
            numNbrToilettes.Value = 0;
            txtAcheteur.Text = "";
            txtPrixSouhaite.Text = "";
            txtPrixVenteReel.Text = "";
            txtCommentaires.Text = "";
            comboStatut.Text = "DISPONIBLE";
        }

        private void butAjoutFiche_Click(object sender, EventArgs e)
        {
            bien = null;
            txtAdrBien.Text = "";
            comboType.Text = "";
            txtSurHabi.Text = "";
            txtSurPar.Text = "";
            numNbrChambres.Value = 0;
            numNbrToilettes.Value = 0;
            txtAcheteur.Text = "";
            txtPrixSouhaite.Text = "";
            txtPrixVenteReel.Text = "";
            txtCommentaires.Text = "";
            comboStatut.Text = "";
        }

        private void butAnnuler_Click(object sender, EventArgs e)
        {
            Parent.Parent.Parent.Parent.Parent.Visible = false;
        }

        #region Regle pour Textbox

        private void txtTelFixePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("SEUL LES NUMEROS SONT ACCEPTES ! VEUILLEZ ENTRER DE NOUVEAU", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        

        




    }
}
