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
    public partial class Repair : Form
    {
        public Repair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDetails.Text == "" || txtRemarks.Text == "")
                MessageBox.Show("Please complete the information!");
            else
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDetails.Clear();
            txtRemarks.Clear();
        }
    }
}
