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

namespace ImmoRale.Affichage
{
    public partial class AffichageAcheteur : UserControl
    {
        private List<ACHETEUR> lsObj;
        public List<COMMERCIAL> listCom;
        public event EventHandler AcheteurSelected;


        public AffichageAcheteur()
        {
            InitializeComponent();
            ChargerComboBox();
            listCom = Entites.COMMERCIAL.getList("");
            comboBox2.DataSource = listCom;
            comboBox2.DisplayMember = "NomCommercial";
        }

        private void ChargerComboBox()
        {            
            comboBox1.Items.Add("TOUS");
            foreach (String statut in Configuration.Config.STATUT_FICHESOUHAIT)
                comboBox1.Items.Add(statut);            
            comboBox1.SelectedIndex = 0;
        }

        private ACHETEUR getSelectedAcheteur(Guid id)
        {
            return lsObj.First(x => x.ID == id);
        }       

        private void dataGridViewAche_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = Guid.Parse(dataGridViewAche["ID", e.RowIndex].Value.ToString());

            if (AcheteurSelected != null)
            {
                AcheteurSelected(getSelectedAcheteur(id), null);
            }
        }

        private void butChercherAche_Click(object sender, EventArgs e)
        {                       
            if (checkBoxTous.Checked == true)
            {                
                lsObj = ACHETEUR.getList("");
                label1.Visible = true;
                label2.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                checkBoxTous.Checked = false;

            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "TOUS")
                    lsObj = ACHETEUR.getList(String.Format("Commercial = '{0}'", ((Entites.COMMERCIAL)comboBox2.SelectedItem).NomCommercial));
                else
                    lsObj = ACHETEUR.getList(String.Format("Statut = '{0}' AND Commercial = '{1}'", comboBox1.SelectedItem,((Entites.COMMERCIAL)comboBox2.SelectedItem).NomCommercial));
            }
               dataGridViewAche.DataSource = lsObj;
 
        }

        

        

            
    }
}
