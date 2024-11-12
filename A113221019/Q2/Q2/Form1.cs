using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program3_10
{
    public partial class Form1 : Form
    {
        const double BANANA = 115;
        const double APPLE = 80;
        const double ORANGE = 90;
        const double PEAR = 120;

        Boolean bananaClicked = false;
        Boolean appleClicked = false;
        Boolean orangeClicked = false;
        Boolean pearClicked = false;

        private double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += pictureBox1.Width;
            label2.Text = total.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

