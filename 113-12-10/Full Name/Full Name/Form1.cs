using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The FullName method accepts arguments for a first name, 
        // a middle name, and a last name. It returns the full name.
        private string FullName(string firstName, string middleName, string lastName)
        {
            // 檢查中間名是否為空，避免多餘的空格
            if (string.IsNullOrWhiteSpace(middleName))
            {
                return $"{firstName} {lastName}";
            }
            else
            {
                return $"{firstName} {middleName} {lastName}";
            }
        }

        private void showFullNameButton_Click(object sender, EventArgs e)
        {
            // 變數來儲存使用者的輸入
            string firstName = firstNameTextBox.Text.Trim();
            string middleName = middleNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();

            // 驗證輸入是否完整
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("請輸入姓氏和名字！", "輸入錯誤");
                return;
            }

            // 呼叫 FullName 方法，取得完整名稱
            string fullName = FullName(firstName, middleName, lastName);

            // 顯示結果
            fullNameLabel.Text = $"全名: {fullName}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}