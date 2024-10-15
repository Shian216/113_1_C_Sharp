using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string fullName; //變數一定要先宣告型態後，才可以使用
            string firstName;
            string lastName;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            fullName = lastName + " " + firstName;

            lblShow.Text = fullName;
        }
    }
}
