namespace Program3_10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxBanana = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.pictureBoxApple = new System.Windows.Forms.PictureBox();
            this.pictureBoxPear = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalCalories = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPear)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBanana
            // 
            this.pictureBoxBanana.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanana.Image")));
            this.pictureBoxBanana.Location = new System.Drawing.Point(46, 30);
            this.pictureBoxBanana.Name = "pictureBoxBanana";
            this.pictureBoxBanana.Size = new System.Drawing.Size(187, 165);
            this.pictureBoxBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanana.TabIndex = 0;
            this.pictureBoxBanana.TabStop = false;
            this.pictureBoxBanana.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrange.Image")));
            this.pictureBoxOrange.Location = new System.Drawing.Point(46, 219);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(187, 165);
            this.pictureBoxOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrange.TabIndex = 1;
            this.pictureBoxOrange.TabStop = false;
            this.pictureBoxOrange.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxApple
            // 
            this.pictureBoxApple.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxApple.Image")));
            this.pictureBoxApple.Location = new System.Drawing.Point(265, 30);
            this.pictureBoxApple.Name = "pictureBoxApple";
            this.pictureBoxApple.Size = new System.Drawing.Size(187, 165);
            this.pictureBoxApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxApple.TabIndex = 2;
            this.pictureBoxApple.TabStop = false;
            this.pictureBoxApple.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxPear
            // 
            this.pictureBoxPear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPear.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxPear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPear.Image")));
            this.pictureBoxPear.Location = new System.Drawing.Point(265, 219);
            this.pictureBoxPear.Name = "pictureBoxPear";
            this.pictureBoxPear.Size = new System.Drawing.Size(187, 165);
            this.pictureBoxPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPear.TabIndex = 3;
            this.pictureBoxPear.TabStop = false;
            this.pictureBoxPear.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "總卡路里";
            // 
            // labelTotalCalories
            // 
            this.labelTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalCalories.Location = new System.Drawing.Point(537, 115);
            this.labelTotalCalories.Name = "labelTotalCalories";
            this.labelTotalCalories.Size = new System.Drawing.Size(100, 23);
            this.labelTotalCalories.TabIndex = 5;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(537, 316);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "重設";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTotalCalories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPear);
            this.Controls.Add(this.pictureBoxApple);
            this.Controls.Add(this.pictureBoxOrange);
            this.Controls.Add(this.pictureBoxBanana);
            this.Name = "Form1";
            this.Text = "卡路里計算機";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBanana;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.PictureBox pictureBoxApple;
        private System.Windows.Forms.PictureBox pictureBoxPear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalCalories;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button2;
    }
}

