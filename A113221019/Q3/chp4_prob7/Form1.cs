using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
            decimal netIncome; //淨收入

            //以下作答
            int D;
            if (!int.TryParse(incomeTextBox.Text, out D))
            {
                label2.Text = "請輸入正確數值";
                return;
            }
            else if (D <= 590000)
            {
                label2.Text = "Payable Tax: NT$" + (D * 0.05 - 0);
                label3.Text = "Net Income: NT$" + (D-(D * 0.05 - 0));
            }  
            else if (D <= 1330000)
            {
                label2.Text = "Payable Tax: NT$" + (D * 0.12 - 41300);
                label3.Text = "Net Income: NT$" + (D - (D * 0.12 - 41300));
            }
            else if (D <= 2660000)
            {
                label2.Text = "Payable Tax: NT$" + (D * 0.2 - 147700);
                label3.Text = "Net Income NT$" + (D - (D * 0.2 - 147700));
            }
            else if (D <= 4980000)
            {
                label2.Text = "Payable Tax: NT$" + (D * 0.3 - 413700);
                label3.Text = "Net Income: NT$" + (D - (D * 0.3 - 413700));
            }
            else
            {
                label2.Text = "Payable Tax: NT$" + (D * 0.4 - 911700);
                label3.Text = "Net Income: NT$" + (D - (D * 0.4 - 911700));
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
