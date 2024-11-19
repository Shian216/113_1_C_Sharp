using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory; //熱量(卡路里)
            double gram;   //克數(脂肪重量)

            //以下作答，必須使用double.TryParse()方法
            // 取得使用者輸入值
            if (double.TryParse(textBox1.Text, out double totalCalories) &&
                double.TryParse(textBox2.Text, out double fatGrams))
            {
                // 計算來自脂肪的卡路里數
                double fatCalories = fatGrams * 9;

                // 計算來自脂肪的卡路里百分比
                double fatPercentage = (fatCalories / totalCalories) * 100;

                // 更新結果顯示
                label1.Text = $"來自脂肪的卡路里數: {fatCalories}";
                label2.Text = $"來自脂肪的卡路里百分比: {fatPercentage:F2}%";

                // 判斷是否為低脂食品
                radioButton1.Checked = fatPercentage < 30;
            }
            else
            {
                MessageBox.Show("請輸入有效的數值！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
