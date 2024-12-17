using System;
using System.Windows.Forms;

namespace Load_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form1 的 Load 事件：將南美洲國家名稱加到 ListBox
        private void Form1_Load(object sender, EventArgs e)
        {
            // 南美洲國家的名稱清單
            string[] southAmericaCountries =
            {
                "阿根廷", "玻利維亞", "巴西", "智利",
                "哥倫比亞", "厄瓜多", "圭亞那", "巴拉圭",
                "秘魯", "蘇利南", "烏拉圭", "委內瑞拉"
            };

            // 將名稱添加到 ListBox
            countriesListBox.Items.AddRange(southAmericaCountries);
        }

        // 退出按鈕的 Click 事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
