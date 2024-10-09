using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblShow.Text = "黑桃10";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblShow.Text = "黑桃J";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblShow.Text = "黑桃Q";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblShow.Text = "黑桃K";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblShow.Text = "黑桃A";
        }
    }
}
