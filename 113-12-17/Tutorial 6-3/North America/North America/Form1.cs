using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // getCountriesButton 按鈕事件
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 顯示檔案選擇對話框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "選擇國家檔案";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 取得使用者選擇的檔案名稱
                    string fileName = openFileDialog.FileName;

                    // 呼叫 GetCountries 方法來讀取檔案
                    GetCountries(fileName);
                }
                catch (Exception ex)
                {
                    // 顯示錯誤訊息
                    MessageBox.Show($"讀取檔案時發生錯誤: {ex.Message}");
                }
            }
        }

        // GetCountries 方法：讀取指定檔案並顯示內容
        private void GetCountries(string fileName)
        {
            // 清空 ListBox
            countriesListBox.Items.Clear();

            // 使用 StreamReader 讀取檔案內容
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // 將每一行加入 ListBox
                    countriesListBox.Items.Add(line);
                }
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
