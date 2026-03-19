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
    public partial class Installation : Form
    {
        public Installation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtReason.Text == "" || txtRequest.Text == "" || txtSoftware.Text == "")
                MessageBox.Show("Please complete this information!");
            else
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRequest.Clear();
            txtReason.Clear();
            txtSoftware.Clear();
        }
    }
}
