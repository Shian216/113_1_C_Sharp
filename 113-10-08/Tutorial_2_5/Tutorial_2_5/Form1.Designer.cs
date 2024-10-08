namespace Tutorial_2_5
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
            this.ptxBack = new System.Windows.Forms.PictureBox();
            this.ptxFront = new System.Windows.Forms.PictureBox();
            this.btnShowBack = new System.Windows.Forms.Button();
            this.btnShowFront = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxFront)).BeginInit();
            this.SuspendLayout();
            // 
            // ptxBack
            // 
            this.ptxBack.Image = ((System.Drawing.Image)(resources.GetObject("ptxBack.Image")));
            this.ptxBack.Location = new System.Drawing.Point(125, 33);
            this.ptxBack.Name = "ptxBack";
            this.ptxBack.Size = new System.Drawing.Size(228, 301);
            this.ptxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxBack.TabIndex = 0;
            this.ptxBack.TabStop = false;
            this.ptxBack.Visible = false;
            // 
            // ptxFront
            // 
            this.ptxFront.Image = ((System.Drawing.Image)(resources.GetObject("ptxFront.Image")));
            this.ptxFront.Location = new System.Drawing.Point(418, 33);
            this.ptxFront.Name = "ptxFront";
            this.ptxFront.Size = new System.Drawing.Size(228, 301);
            this.ptxFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxFront.TabIndex = 1;
            this.ptxFront.TabStop = false;
            this.ptxFront.Visible = false;
            // 
            // btnShowBack
            // 
            this.btnShowBack.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowBack.Location = new System.Drawing.Point(125, 363);
            this.btnShowBack.Name = "btnShowBack";
            this.btnShowBack.Size = new System.Drawing.Size(228, 78);
            this.btnShowBack.TabIndex = 2;
            this.btnShowBack.Text = "背面";
            this.btnShowBack.UseVisualStyleBackColor = true;
            this.btnShowBack.Click += new System.EventHandler(this.btnShowBack_Click);
            // 
            // btnShowFront
            // 
            this.btnShowFront.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowFront.Location = new System.Drawing.Point(418, 363);
            this.btnShowFront.Name = "btnShowFront";
            this.btnShowFront.Size = new System.Drawing.Size(228, 78);
            this.btnShowFront.TabIndex = 3;
            this.btnShowFront.Text = "正面";
            this.btnShowFront.UseVisualStyleBackColor = true;
            this.btnShowFront.Click += new System.EventHandler(this.btnShowFront_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowFront);
            this.Controls.Add(this.btnShowBack);
            this.Controls.Add(this.ptxFront);
            this.Controls.Add(this.ptxBack);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)(this.ptxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxFront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptxBack;
        private System.Windows.Forms.PictureBox ptxFront;
        private System.Windows.Forms.Button btnShowBack;
        private System.Windows.Forms.Button btnShowFront;
        private System.Windows.Forms.Button btnExit;
    }
}

