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
    public partial class AffichageBien : UserControl
    {
        private List<BIEN> lsObj;        
        public event EventHandler BienSelected;

        public AffichageBien()
        {
            InitializeComponent();
            ChargerComboBox();
            
        }

        private BIEN getSelectedBien(Guid id)
        {
            return lsObj.First(x => x.ID == id);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = Guid.Parse(dataGridView2["ID", e.RowIndex].Value.ToString());

            if (BienSelected != null)
            {
                BienSelected(getSelectedBien(id), null);
            }
        }

        public void ChargerComboBox()
        {
            comboCriteres.Items.Add("TOUS");
            foreach (String critere in Configuration.Config.STATUT_BIEN)
                comboCriteres.Items.Add(critere);
            comboCriteres.SelectedIndex = 0;
        }

        private void butChercher_Click(object sender, EventArgs e)
        {
            if (comboCriteres.SelectedItem.ToString() == "TOUS")
                lsObj = BIEN.getList("");
            else
            {
                lsObj = BIEN.getList(String.Format("Statut = '{0}'", comboCriteres.SelectedItem));
                
            }
            dataGridView2.DataSource = lsObj;
        }
        
    }
}
