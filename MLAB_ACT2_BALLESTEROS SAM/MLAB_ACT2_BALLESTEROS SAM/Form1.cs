using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLAB_ACT2_BALLESTEROS_SAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = String.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int currentTime = DateTime.Now.Hour;
            double Amount = 0;

            bool isAM = (currentTime < 12);

            if (isAM)
            {
                if (rbTrailer.Checked)
                    Amount = 350;
                else if (rbBus.Checked)
                    Amount = 320;
                else if (rbCar.Checked)
                    Amount = 210;
                else if (rbOthers.Checked)
                    Amount = 150;
            }
            else
            {
                if (rbTrailer.Checked)
                    Amount = 500;
                else if (rbBus.Checked)
                    Amount = 400;
                else if (rbCar.Checked)
                    Amount = 380;
                else if (rbOthers.Checked)
                    Amount = 200;
            }

            lblAmountDue.Text = "P" + Amount.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbBus.Checked = false;
            rbTrailer.Checked = false;  
            rbCar.Checked = false;  
            rbOthers.Checked = false;

            lblAmountDue.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
