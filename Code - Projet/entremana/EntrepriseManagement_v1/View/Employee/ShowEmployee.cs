using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntrepriseManagement_v1.Entity;
using EntrepriseManagement_v1.Configuration;

namespace EntrepriseManagement_v1.View.Employee
{
    public partial class ShowEmployee : UserControl
    {
        private List<EntrepriseManagement_v1.Entity.Employee> lsObj;

        public event EventHandler EmployeeSelected;

        public ShowEmployee()
        {
            InitializeComponent();

            lsObj = EntrepriseManagement_v1.Entity.Employee.getList("wage");
            dataGridView1.DataSource = lsObj;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["FirstName"].Visible = false;
            dataGridView1.Columns["LastName"].Visible = false;
        }

        private EntrepriseManagement_v1.Entity.Employee getSelectedEmployee(Guid id)
        {
            return lsObj.First(x => x.Id == id);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = Guid.Parse(dataGridView1["ID", e.RowIndex].Value.ToString());

            if (EmployeeSelected != null)
                EmployeeSelected(getSelectedEmployee(id), null);
        }

        
    }
}
