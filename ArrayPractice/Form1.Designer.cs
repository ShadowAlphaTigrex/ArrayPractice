namespace ArrayPractice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblFruit = new System.Windows.Forms.Label();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.lblTotalFruit = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(127, 151);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(124, 41);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(0, 13);
            this.lblOutput1.TabIndex = 1;
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(124, 88);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(0, 13);
            this.lblOutput2.TabIndex = 2;
            // 
            // lblFruit
            // 
            this.lblFruit.AutoSize = true;
            this.lblFruit.Location = new System.Drawing.Point(366, 63);
            this.lblFruit.Name = "lblFruit";
            this.lblFruit.Size = new System.Drawing.Size(0, 13);
            this.lblFruit.TabIndex = 3;
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(369, 151);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(75, 23);
            this.btnShow2.TabIndex = 4;
            this.btnShow2.Text = "Show";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // lblTotalFruit
            // 
            this.lblTotalFruit.AutoSize = true;
            this.lblTotalFruit.Location = new System.Drawing.Point(366, 110);
            this.lblTotalFruit.Name = "lblTotalFruit";
            this.lblTotalFruit.Size = new System.Drawing.Size(0, 13);
            this.lblTotalFruit.TabIndex = 5;
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(124, 121);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(0, 13);
            this.lblTotalNum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 261);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lblTotalFruit);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.lblFruit);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label lblFruit;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Label lblTotalFruit;
        private System.Windows.Forms.Label lblTotalNum;
    }
}

