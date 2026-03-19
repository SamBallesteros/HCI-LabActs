using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLAB_ACT3_BALLESTEROS_SAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIDNo.Text == "" || txtName.Text == "" || txtDepartment.Text == "")
            {
                MessageBox.Show("Please Complete the information!");
            }
            else
            {
                Repair r = new Repair();
                r.txtRequest.Text = txtName.Text;

                txtIDNo.Clear();
                txtName.Clear();
                txtDepartment.Clear();

                r.txtRequest.Enabled = false;
                r.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIDNo.Text == "" || txtName.Text == "" || txtDepartment.Text == "")
            {
                MessageBox.Show("Please Complete the information!");
            }
            else
            {
                Installation i = new Installation();
                i.txtRequest.Text = txtName.Text;

                txtIDNo.Clear();
                txtName.Clear();
                txtDepartment.Clear();

                i.txtRequest.Enabled = false;
                i.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
