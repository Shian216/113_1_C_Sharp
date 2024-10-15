using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            //double average;

            kms = double.Parse(txbKM.Text);
            liters = double.Parse(txbLiter.Text);
            //average = (kms / liters).ToString();

            lblShow.Text = (kms / liters).ToString("f3");
            //lblShow.Text = average.ToString("n3");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
