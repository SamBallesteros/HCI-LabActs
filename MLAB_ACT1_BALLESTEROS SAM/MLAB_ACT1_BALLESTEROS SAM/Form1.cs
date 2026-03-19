using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLAB_ACT1_BALLESTEROS_SAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text != "" && (chkCavity.Checked == true || chkCleaning.Checked == true || chkXray.Checked == true))
            {
                int intTotal = 0;
                if (chkCleaning.Checked == true)
                    intTotal += 250;
                if (chkCavity.Checked == true)
                    intTotal += 380;
                if (chkXray.Checked == true)
                    intTotal += 450;
                lblAmountDue.Text = "P" + String.Format("{0:F}", intTotal);
            }
            else MessageBox.Show("Missing information required!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPatientName.Text = " ";
            chkCavity.Checked = false; 
            chkXray.Checked = false;
            chkCleaning.Checked = false;
            lblAmountDue.Text = "P0.00";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblCurrentTime2.Text = String.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
