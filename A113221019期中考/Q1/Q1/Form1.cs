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

        // 計算田地面積
        private void button1_Click(object sender, EventArgs e)
        {
            if (TryGetDimensions(out double length, out double width))
            {
                double area = length * width;
                label4.Text = $"田地面積: {area} 平方單位";
            }
        }

        // 計算田地周長
        private void button2_Click(object sender, EventArgs e)
        {
            if (TryGetDimensions(out double length, out double width))
            {
                double perimeter = 2 * (length + width);
                label4.Text = $"田地周長: {perimeter} 單位";
            }
        }

        // 計算圍欄成本
        private void button3_Click(object sender, EventArgs e)
        {
            if (TryGetDimensions(out double length, out double width) && double.TryParse(textBox3.Text, out double costPerUnit))
            {
                double perimeter = 2 * (length + width);
                double totalCost = perimeter * costPerUnit;
                label4.Text = $"圍欄總成本:NT$ {totalCost}";
            }
            else
            {
                MessageBox.Show("請輸入有效的單位成本！");
            }
        }

        // 解析長度和寬度輸入值
        private bool TryGetDimensions(out double length, out double width)
        {
            bool isValidLength = double.TryParse(textBox1.Text, out length);
            bool isValidWidth = double.TryParse(textBox2.Text, out width);

            if (!isValidLength || !isValidWidth)
            {
                MessageBox.Show("請輸入有效的長度和寬度！");
                return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
