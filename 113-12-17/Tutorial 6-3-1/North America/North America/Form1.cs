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

        // 使用 OpenFileDialog 顯示檔案選擇對話框並返回檔案名稱
        private string GetFileName()
        {
            string fileName = "";
            // 顯示檔案選擇對話框
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // 取得檔案名稱
                fileName = openFile.FileName;
            }
            return fileName; // 返回檔案名稱
        }

        // 讀取檔案並顯示內容
        private void GetCountries(string fileName)
        {
            try
            {
                // 使用 StreamReader 讀取檔案並顯示內容
                using (StreamReader inputFile = File.OpenText(fileName))
                {
                    countriesListBox.Items.Clear();

                    while (!inputFile.EndOfStream)
                    {
                        string countryName = inputFile.ReadLine();
                        countriesListBox.Items.Add(countryName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // getCountriesButton 按鈕事件，呼叫 GetFileName 並顯示檔案內容
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName = GetFileName();

            if (!string.IsNullOrEmpty(fileName))
            {
                GetCountries(fileName);
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



