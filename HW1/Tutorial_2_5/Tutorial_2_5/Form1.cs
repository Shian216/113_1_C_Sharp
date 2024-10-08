using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;   
            ptxFront.Visible = false;
        }
        
        private void btnShowFront_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;
            ptxFront.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
