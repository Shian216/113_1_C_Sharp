using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method: 驗證並轉換輸入
        private bool InputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            bool isValid = true;

            // 驗證 Gross Pay
            if (!decimal.TryParse(grossPayTextBox.Text, out grossPay) || grossPay < 0)
            {
                isValid = false;
                MessageBox.Show("請輸入有效的工資金額。", "輸入錯誤");
            }

            // 驗證 Bonus
            if (!decimal.TryParse(bonusTextBox.Text, out bonus) || bonus < 0)
            {
                isValid = false;
                MessageBox.Show("請輸入有效的獎金金額。", "輸入錯誤");
            }

            return isValid;
        }

        // calculateButton 按鈕事件：計算獎金與總額
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0m;  // 工資
            decimal bonus = 0m;     // 獎金
            decimal contribution = 0m;  // 公司提撥額

            // 驗證輸入
            if (InputIsValid(ref grossPay, ref bonus))
            {
                // 計算公司提撥額
                contribution = (grossPay + bonus) * CONTRIB_RATE;

                // 顯示結果
                contributionLabel.Text = $"公司提撥額: {contribution:C}";
            }
        }

        // exitButton 按鈕事件：關閉視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}