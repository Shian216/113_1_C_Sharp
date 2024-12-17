using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_By_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The SetToZero method accepts an int argument by reference
        // and sets its value to zero.
        private void SetToZero(ref int number)
        {
            number = 0; // 將傳入的變數設為 0
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // 宣告一些本地 int 變數
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;

            // 顯示原始值
            MessageBox.Show($"初始值:\nValue1 = {value1}\nValue2 = {value2}\nValue3 = {value3}", "Before Calling SetToZero");

            // 傳遞變數給 SetToZero 方法（by reference）
            SetToZero(ref value1);
            SetToZero(ref value2);
            SetToZero(ref value3);

            // 顯示修改後的值
            MessageBox.Show($"修改後:\nValue1 = {value1}\nValue2 = {value2}\nValue3 = {value3}", "After Calling SetToZero");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
