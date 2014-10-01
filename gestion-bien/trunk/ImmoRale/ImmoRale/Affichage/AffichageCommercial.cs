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
    public partial class AffichageCommercial : UserControl
    {
        private List<COMMERCIAL> lsObj;        
        public event EventHandler CommercialSelected;

        public AffichageCommercial()
        {
            InitializeComponent();
            ChargerComboBox();            
        }

        private void ChargerComboBox()
        {
            cbStaAffiCom.Items.Add("TOUS");
            cbAgenceAffiCom.Items.Add("TOUS");
            foreach (String statut in Configuration.Config.STATUT_COMMERCIAL)
                cbStaAffiCom.Items.Add(statut);
            foreach (String agence in Configuration.Config.AGENCELOCALE)
                cbAgenceAffiCom.Items.Add(agence);
            cbStaAffiCom.SelectedIndex = 0;
            cbAgenceAffiCom.SelectedIndex = 0;
        }

        private COMMERCIAL getSelectedCommercial(Guid id)
        {
            return lsObj.First(x => x.ID == id);
        }                   

        private void dataGridViewCom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = Guid.Parse(dataGridViewCom["ID", e.RowIndex].Value.ToString());

            if (CommercialSelected != null)
            {
                CommercialSelected(getSelectedCommercial(id), null);
            }
        }

        private void butChercherAche_Click(object sender, EventArgs e)
        {
            if (cbStaAffiCom.SelectedItem.ToString() == "TOUS")
            {
                if (cbAgenceAffiCom.SelectedItem.ToString() == "TOUS")
                    lsObj = COMMERCIAL.getList("");                
                else lsObj = COMMERCIAL.getList(String.Format("AgenceLocale = '{0}'", cbAgenceAffiCom.SelectedItem));
            }               
            else
            {
                if (cbAgenceAffiCom.SelectedItem.ToString() == "TOUS")
                    lsObj = COMMERCIAL.getList(String.Format("Statut = '{0}'", cbStaAffiCom.SelectedItem));
                else
                    lsObj = COMMERCIAL.getList(String.Format("Statut = '{0}' AND AgenceLocale = '{1}'", cbStaAffiCom.SelectedItem,cbAgenceAffiCom.SelectedItem));
            }
            dataGridViewCom.DataSource = lsObj;
        }        
    }
}
