using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntrepriseManagement_v1.Tools;
using EntrepriseManagement_v1.Controller;
using EntrepriseManagement_v1.Entity;

namespace EntrepriseManagement_v1.View.Employee
{
    public partial class AddEditEmployee : UserControl
    {
        private EntrepriseManagement_v1.Entity.Employee obj;

        public AddEditEmployee(IEntity em = null)
        {
            InitializeComponent();

            LoadInit();

            if (em != null)
            {
                BindingData((EntrepriseManagement_v1.Entity.Employee)em);
            }
        }

        private void LoadInit()
        {
            foreach (String role in Configuration.Config.ALL_ROLES)
            {
                cbRole.Items.Add(role);
                comboBox1.Items.Add(role);
            }
            cbRole.SelectedIndex = 0;
            tbFName.Focus();
        }

        private void BindingData(EntrepriseManagement_v1.Entity.Employee em)
        {
            this.obj = em;
            butSave.Text = "Cập nhật";

            tbFName.Text = em.FirstName;
            tbLName.Text = em.LastName;
            tbAddress.Text = em.Address;
            tbMobile.Text = em.Mobile;
            tbWage.Text = em.Wage.ToString("##,###");
            tbCMND.Text = em.CMND;
            tbMST.Text = em.MST;
            cbRole.SelectedItem = em.Role;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            tbFName.Text = tbLName.Text = tbAddress.Text = tbMobile.Text = tbWage.Text = tbCMND.Text = tbMST.Text = String.Empty;
            cbRole.SelectedIndex = 0;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            saveProcess(tbFName.Text, tbLName.Text, tbAddress.Text, tbMobile.Text, tbWage.Text, tbCMND.Text, tbMST.Text, (String)cbRole.SelectedItem);
        }

        private void saveProcess(string fname, string lname, string address, string mobile, string wage, string cmnd, string mst, string role)
        {
            if (fname.Trim() == String.Empty || lname.Trim() == String.Empty || address.Trim() == String.Empty ||
                mobile.Trim() == String.Empty || wage.Trim() == String.Empty || cmnd.Trim() == String.Empty || mst.Trim() == String.Empty)
            {
                MessageBox.Show("Không được để trống");
            }
            else 
            {
                EmployeeController ec = new EmployeeController();
                if (obj == null)
                {
                    if (!ec.saveEmployee(fname, lname, address, mobile, Helper.parseInt(wage), cmnd, mst, role))
                        MessageBox.Show("Lỗi khi lưu nhân viên");
                    else
                        MessageBox.Show("Lưu thành công");
                }
                else
                {
                    obj.FirstName = fname;
                    obj.LastName = lname;
                    obj.Address = address;
                    obj.Mobile = mobile;
                    obj.Wage = Helper.parseInt(wage);
                    obj.CMND = cmnd;
                    obj.MST = mst;
                    obj.Role = role;

                    if (!ec.updateEmployee(obj))
                        MessageBox.Show("Lỗi khi cập nhật nhân viên");
                    else
                        MessageBox.Show("Cập nhật thành công");
                }
            }
        }

        private void tbWage_TextChanged(object sender, EventArgs e)
        {
            int wage = Helper.parseInt(tbWage.Text.Replace(",",""));
            if (wage >= 1000)
            {
                int prefix = wage / 1000;
                int posfix = wage % 1000;
                tbWage.Text = prefix + "," + posfix;
                //tbWage.SelectionStart = tbWage.Text.Length;
            }
        }
    }
}
