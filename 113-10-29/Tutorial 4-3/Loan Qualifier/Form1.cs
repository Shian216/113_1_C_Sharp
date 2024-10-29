using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            decimal salary;
            int years;
            const decimal MIN_SALARY = 1300000m;
            const int MIN_YEARS = 2;

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                years = int.Parse(yearsTextBox.Text);

                if ( salary >= MIN_SALARY )
                {
                    if (years >= MIN_YEARS)
                    {
                        decisionLabel.Text = "條件符合，貸款通過";
                    }
                    else
                    {
                        decisionLabel.Text = "工作年資未達標準，貸款不通過";

                    }
                }
                else
                {
                    decisionLabel.Text = "薪資所得未達標準，貸款不通過";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
