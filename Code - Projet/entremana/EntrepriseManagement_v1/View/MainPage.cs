using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntrepriseManagement_v1.View.Employee;

namespace EntrepriseManagement_v1.View
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void changeView(UserControl uc)
        {
            //uc.Width = splitContainer1.Panel2.Width;
            //uc.Height = splitContainer1.Panel2.Height;
            uc.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(uc);
        }

        private void butEditEmployee_Click(object sender, EventArgs e)
        {
            changeView(new AddEditEmployee());
        }

        private void butShowEmployee_Click(object sender, EventArgs e)
        {
            ShowEmployee uc = new ShowEmployee();
            uc.EmployeeSelected += (s1, e1) =>
                {
                    changeView(new AddEditEmployee((EntrepriseManagement_v1.Entity.Employee)s1));
                };

            changeView(uc);
        }
    }
}
