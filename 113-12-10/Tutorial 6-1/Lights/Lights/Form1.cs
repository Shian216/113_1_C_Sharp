using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        // 用來追蹤燈光開關狀態的變數（開/關）
        private bool isLightOn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            // 切換燈光的開關狀態
            isLightOn = !isLightOn;

            // 根據燈光狀態來顯示不同的圖片並更新標籤文字
            if (isLightOn)
            {
                // 顯示 lightOnPictureBox，隱藏 lightOffPictureBox
                lightOnPictureBox.Visible = true;
                lightOffPictureBox.Visible = false;

                // 更新標籤文字為 "ON"
                lightStateLabel.Text = "ON";
            }
            else
            {
                // 顯示 lightOffPictureBox，隱藏 lightOnPictureBox
                lightOnPictureBox.Visible = false;
                lightOffPictureBox.Visible = true;

                // 更新標籤文字為 "OFF"
                lightStateLabel.Text = "OFF";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉窗體
            this.Close();
        }
    }
}

