namespace Tutorial3_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDayOfWeek = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(238, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "星期幾";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(238, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "日期";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(238, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "月份";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(238, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "年份";
            // 
            // txtDayOfWeek
            // 
            this.txtDayOfWeek.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDayOfWeek.Location = new System.Drawing.Point(345, 104);
            this.txtDayOfWeek.Name = "txtDayOfWeek";
            this.txtDayOfWeek.Size = new System.Drawing.Size(195, 43);
            this.txtDayOfWeek.TabIndex = 4;
            // 
            // txtDay
            // 
            this.txtDay.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDay.Location = new System.Drawing.Point(345, 165);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(195, 43);
            this.txtDay.TabIndex = 5;
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMonth.Location = new System.Drawing.Point(345, 236);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(195, 43);
            this.txtMonth.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(345, 295);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(195, 43);
            this.txtYear.TabIndex = 7;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(176, 367);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(438, 67);
            this.lblShow.TabIndex = 8;
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowDate
            // 
            this.btnShowDate.Font = new System.Drawing.Font("細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowDate.Location = new System.Drawing.Point(93, 472);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(190, 73);
            this.btnShowDate.TabIndex = 9;
            this.btnShowDate.Text = "顯示完整訊息";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(304, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 73);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清空內容";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(522, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 73);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtDayOfWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDayOfWeek;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

