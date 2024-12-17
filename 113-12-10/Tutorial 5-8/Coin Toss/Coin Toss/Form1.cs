using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            // 隨機產生 0 或 1
            int tossResult = random.Next(2);

            // 顯示正面或反面圖片
            if (tossResult == 0)
            {
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
            else
            {
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉程式
            this.Close();
        }
    }
}