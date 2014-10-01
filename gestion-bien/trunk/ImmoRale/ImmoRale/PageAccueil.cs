using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImmoRale;

namespace Maquette.cs
{
    public partial class PageAccueil : Form
    {        
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void butAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butEntrer_Click(object sender, EventArgs e)
        {            
            GestionBien a = new GestionBien();
            a.Show();
            
        }
    }
}
