using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        // 撲克牌圖片清單
        private List<Image> cards = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            LoadCards();
        }

        // 載入所有撲克牌圖片到清單
        private void LoadCards()
        {
            // 載入撲克牌圖片資源，確保這些資源在 Properties.Resources 中已經正確設置
            cards.Add(Properties.Resources._10_Hearts);
            cards.Add(Properties.Resources.Ace_Spades);
            cards.Add(Properties.Resources.King_Clubs);
            // 你可以繼續按照需要加入更多的圖片...
        }

        // 顯示隨機一張撲克牌
        private void showCardButton_Click(object sender, EventArgs e)
        {
            // 隨機選擇一張撲克牌並顯示
            Random rand = new Random();
            int index = rand.Next(cards.Count);  // 隨機選擇一張卡牌
            pictureBox1.Image = cards[index];    // 顯示選中的卡牌圖片

            // 確保每次顯示的都是一張不同的卡牌，並讓按鈕顯示更直觀
            showCardButton.Text = "顯示另一張卡牌";
        }

        // 退出按鈕
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}