using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CupsToOunces 方法：將杯數轉換為盎司
        private double CupsToOunces(double cups)
        {
            return cups * 8.0; // 1 cup = 8 fluid ounces
        }

        // convertButton 按鈕事件
        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 從文字方塊讀取使用者輸入的杯數
                double cups = double.Parse(cupsTextBox.Text);

                if (cups < 0)
                {
                    MessageBox.Show("請輸入一個非負數值。", "輸入錯誤");
                    return;
                }

                // 呼叫 CupsToOunces 方法進行轉換
                double ounces = CupsToOunces(cups);

                // 顯示結果
                ouncesLabel.Text = $"{ounces} 盎司";
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤");
            }
        }

        // exitButton 按鈕事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式
            this.Close();
        }
    }
}
