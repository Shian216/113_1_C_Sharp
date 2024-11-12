using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal length;
            decimal width;
            decimal unit;
            decimal area;
            decimal boundary;
            decimal cost;

            length = textBox1.Text.Length;
            width = textBox2.Text.Length;
            unit = textBox3.Text.Length;

            area = (length * width);
            boundary = ((length + width) * 2);
            cost = (unit*boundary);
            
            label4.Text = area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal length;
            decimal width;
            decimal unit;
            decimal area;
            decimal boundary;
            decimal cost;

            length = textBox1.Text.Length;
            width = textBox2.Text.Length;
            unit = textBox3.Text.Length;

            area = (length * width);
            boundary = ((length + width) * 2);
            cost = (unit * boundary);

            label4.Text = boundary.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal length;
            decimal width;
            decimal unit;
            decimal area;
            decimal boundary;
            decimal cost;

            length = textBox1.Text.Length;
            width = textBox2.Text.Length;
            unit = textBox3.Text.Length;

            area = (length * width);
            boundary = ((length + width) * 2);
            cost = (unit * boundary);

            label4.Text = "Total Cost NT$"+cost.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
