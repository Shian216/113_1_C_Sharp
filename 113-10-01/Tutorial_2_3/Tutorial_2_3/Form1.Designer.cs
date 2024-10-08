namespace Tutorial_2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblTranslation = new Label();
            btnItalian = new Button();
            btnSpanish = new Button();
            btnGerman = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(109, 47);
            label1.Name = "label1";
            label1.Size = new Size(339, 35);
            label1.TabIndex = 0;
            label1.Text = "選擇一個語言，我會說早安";
            // 
            // lblTranslation
            // 
            lblTranslation.BorderStyle = BorderStyle.Fixed3D;
            lblTranslation.Font = new Font("Microsoft JhengHei UI", 20F);
            lblTranslation.Location = new Point(64, 109);
            lblTranslation.Name = "lblTranslation";
            lblTranslation.Size = new Size(439, 71);
            lblTranslation.TabIndex = 1;
            lblTranslation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnItalian
            // 
            btnItalian.Font = new Font("Microsoft JhengHei UI", 16F);
            btnItalian.Location = new Point(64, 225);
            btnItalian.Name = "btnItalian";
            btnItalian.Size = new Size(113, 50);
            btnItalian.TabIndex = 2;
            btnItalian.Text = "義大利";
            btnItalian.UseVisualStyleBackColor = true;
            btnItalian.Click += btnItalian_Click;
            // 
            // btnSpanish
            // 
            btnSpanish.Font = new Font("Microsoft JhengHei UI", 16F);
            btnSpanish.Location = new Point(226, 225);
            btnSpanish.Name = "btnSpanish";
            btnSpanish.Size = new Size(113, 50);
            btnSpanish.TabIndex = 3;
            btnSpanish.Text = "西班牙";
            btnSpanish.UseVisualStyleBackColor = true;
            btnSpanish.Click += btnSpanish_Click;
            // 
            // btnGerman
            // 
            btnGerman.Font = new Font("Microsoft JhengHei UI", 16F);
            btnGerman.Location = new Point(390, 225);
            btnGerman.Name = "btnGerman";
            btnGerman.Size = new Size(113, 50);
            btnGerman.TabIndex = 4;
            btnGerman.Text = "德國";
            btnGerman.UseVisualStyleBackColor = true;
            btnGerman.Click += btnGerman_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 518);
            Controls.Add(btnGerman);
            Controls.Add(btnSpanish);
            Controls.Add(btnItalian);
            Controls.Add(lblTranslation);
            Controls.Add(label1);
            Name = "Form1";
            Text = "語言翻譯機";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTranslation;
        private Button btnItalian;
        private Button btnSpanish;
        private Button btnGerman;
    }
}
