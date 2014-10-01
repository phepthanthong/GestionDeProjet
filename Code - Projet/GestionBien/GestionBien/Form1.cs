using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionBien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeInfoDataSet.EmployeInfo' table. You can move, or remove it, as needed.
            this.employeInfoTableAdapter.Fill(this.employeInfoDataSet.EmployeInfo);
            binding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::GestionBien.Properties.Settings.Default.EmployeInfoConnectionString);
            try
            {
                string text = "INSERT INTO EmployeInfo (Id,Identite,Adresse,Tel_fixe,Tel_mobile,Email) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlCommand ex = new SqlCommand(text, cn);
                cn.Open();
                ex.ExecuteNonQuery();
                MessageBox.Show("Enregistrement reussi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.employeInfoTableAdapter.Fill(this.employeInfoDataSet.EmployeInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERREUR !! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                cn.Close();
            }
        }

        private void binding()
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Id");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Identite");
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "Adresse");
            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "Tel_fixe");
            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("Text", dataGridView1.DataSource, "Tel_mobile");
            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("Text", dataGridView1.DataSource, "Email");            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
