namespace ATM_Final
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo10K = new System.Windows.Forms.RadioButton();
            this.rdo2000 = new System.Windows.Forms.RadioButton();
            this.rdo5000 = new System.Windows.Forms.RadioButton();
            this.rdo3000 = new System.Windows.Forms.RadioButton();
            this.rdo1000 = new System.Windows.Forms.RadioButton();
            this.rdo500 = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Transparent;
            this.lblBalance.Location = new System.Drawing.Point(153, 33);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(161, 18);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "Current Balance: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo10K);
            this.groupBox1.Controls.Add(this.rdo2000);
            this.groupBox1.Controls.Add(this.rdo5000);
            this.groupBox1.Controls.Add(this.rdo3000);
            this.groupBox1.Controls.Add(this.rdo1000);
            this.groupBox1.Controls.Add(this.rdo500);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(40, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 144);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit Amount";
            // 
            // rdo10K
            // 
            this.rdo10K.AutoSize = true;
            this.rdo10K.Location = new System.Drawing.Point(232, 90);
            this.rdo10K.Name = "rdo10K";
            this.rdo10K.Size = new System.Drawing.Size(107, 22);
            this.rdo10K.TabIndex = 2;
            this.rdo10K.Text = "10,000 Rs.";
            this.rdo10K.UseVisualStyleBackColor = true;
            // 
            // rdo2000
            // 
            this.rdo2000.AutoSize = true;
            this.rdo2000.Location = new System.Drawing.Point(40, 90);
            this.rdo2000.Name = "rdo2000";
            this.rdo2000.Size = new System.Drawing.Size(93, 22);
            this.rdo2000.TabIndex = 2;
            this.rdo2000.Text = "2000 Rs.";
            this.rdo2000.UseVisualStyleBackColor = true;
            // 
            // rdo5000
            // 
            this.rdo5000.AutoSize = true;
            this.rdo5000.Location = new System.Drawing.Point(232, 67);
            this.rdo5000.Name = "rdo5000";
            this.rdo5000.Size = new System.Drawing.Size(93, 22);
            this.rdo5000.TabIndex = 2;
            this.rdo5000.Text = "5000 Rs.";
            this.rdo5000.UseVisualStyleBackColor = true;
            // 
            // rdo3000
            // 
            this.rdo3000.AutoSize = true;
            this.rdo3000.Location = new System.Drawing.Point(232, 44);
            this.rdo3000.Name = "rdo3000";
            this.rdo3000.Size = new System.Drawing.Size(93, 22);
            this.rdo3000.TabIndex = 2;
            this.rdo3000.Text = "3000 Rs.";
            this.rdo3000.UseVisualStyleBackColor = true;
            // 
            // rdo1000
            // 
            this.rdo1000.AutoSize = true;
            this.rdo1000.Location = new System.Drawing.Point(40, 67);
            this.rdo1000.Name = "rdo1000";
            this.rdo1000.Size = new System.Drawing.Size(93, 22);
            this.rdo1000.TabIndex = 2;
            this.rdo1000.Text = "1000 Rs.";
            this.rdo1000.UseVisualStyleBackColor = true;
            // 
            // rdo500
            // 
            this.rdo500.AutoSize = true;
            this.rdo500.Checked = true;
            this.rdo500.Location = new System.Drawing.Point(40, 44);
            this.rdo500.Name = "rdo500";
            this.rdo500.Size = new System.Drawing.Size(84, 22);
            this.rdo500.TabIndex = 2;
            this.rdo500.TabStop = true;
            this.rdo500.Text = "500 Rs.";
            this.rdo500.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(241, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Location = new System.Drawing.Point(40, 220);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(173, 40);
            this.btnWithdraw.TabIndex = 12;
            this.btnWithdraw.Text = "&Deposit";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 314);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWithdraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo10K;
        private System.Windows.Forms.RadioButton rdo2000;
        private System.Windows.Forms.RadioButton rdo5000;
        private System.Windows.Forms.RadioButton rdo3000;
        private System.Windows.Forms.RadioButton rdo1000;
        private System.Windows.Forms.RadioButton rdo500;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWithdraw;
    }
}