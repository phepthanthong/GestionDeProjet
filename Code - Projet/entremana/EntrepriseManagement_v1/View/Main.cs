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
using EntrepriseManagement_v1.View.Project;
using EntrepriseManagement_v1.Entity;

namespace EntrepriseManagement_v1.View
{
    public partial class Main : Form
    {
        private UserControl current;
        private static TabControl tabControl;

        public Main()
        {
            InitializeComponent();
            tabControl = tabControl1;

            changeTab(tabPage1, new AddEditEmployee());
        }

        private void changeTab(TabPage tab, UserControl uc)
        {
            current = uc;
            current.Size = tab.Size;
            tab.Controls.Add(current);
        }

        //public static void showTab(int tabIndex, IEntity en)
        //{
        //    entity = en;
        //    tabControl.SelectedTab = tabControl.TabPages[tabIndex];
        //}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                changeTab(tabPage1, new AddEditEmployee());
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                changeTab(tabPage2, new AddEditProject());
            } 
            else if (tabControl1.SelectedTab == tabPage3)
            {
                changeTab(tabPage3, new ShowEmployee());
            }
        }
    }
}
