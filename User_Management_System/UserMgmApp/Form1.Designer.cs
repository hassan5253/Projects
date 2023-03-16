namespace UserMgmApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtUPass = new System.Windows.Forms.TextBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk11 = new System.Windows.Forms.CheckBox();
            this.chk12 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUPass);
            this.groupBox1.Controls.Add(this.txtUName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk12);
            this.groupBox2.Controls.Add(this.chk11);
            this.groupBox2.Controls.Add(this.chk10);
            this.groupBox2.Controls.Add(this.chk6);
            this.groupBox2.Controls.Add(this.chk5);
            this.groupBox2.Controls.Add(this.chk4);
            this.groupBox2.Controls.Add(this.chk9);
            this.groupBox2.Controls.Add(this.chk8);
            this.groupBox2.Controls.Add(this.chk7);
            this.groupBox2.Controls.Add(this.chk2);
            this.groupBox2.Controls.Add(this.chk1);
            this.groupBox2.Controls.Add(this.chk3);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(65, 31);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(143, 20);
            this.txtUName.TabIndex = 1;
            // 
            // txtUPass
            // 
            this.txtUPass.Location = new System.Drawing.Point(65, 57);
            this.txtUPass.Name = "txtUPass";
            this.txtUPass.Size = new System.Drawing.Size(143, 20);
            this.txtUPass.TabIndex = 1;
            this.txtUPass.UseSystemPasswordChar = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(6, 74);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(129, 17);
            this.chk3.TabIndex = 0;
            this.chk3.Text = "Print Customer Details";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(6, 28);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(117, 17);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "Add New Customer";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(6, 51);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(96, 17);
            this.chk2.TabIndex = 0;
            this.chk2.Text = "View Customer";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(149, 28);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(110, 17);
            this.chk7.TabIndex = 0;
            this.chk7.Text = "Add New Product";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(149, 51);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(89, 17);
            this.chk8.TabIndex = 0;
            this.chk8.Text = "View Product";
            this.chk8.UseVisualStyleBackColor = true;
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(149, 74);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(122, 17);
            this.chk9.TabIndex = 0;
            this.chk9.Text = "Print Product Details";
            this.chk9.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(6, 110);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(93, 17);
            this.chk4.TabIndex = 0;
            this.chk4.Text = "Add New Item";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(6, 133);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(77, 17);
            this.chk5.TabIndex = 0;
            this.chk5.Text = "View Items";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(6, 156);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(75, 17);
            this.chk6.TabIndex = 0;
            this.chk6.Text = "Print Items";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(129, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(149, 110);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(95, 17);
            this.chk10.TabIndex = 1;
            this.chk10.Text = "Add New User";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk11
            // 
            this.chk11.AutoSize = true;
            this.chk11.Location = new System.Drawing.Point(149, 133);
            this.chk11.Name = "chk11";
            this.chk11.Size = new System.Drawing.Size(74, 17);
            this.chk11.TabIndex = 1;
            this.chk11.Text = "View User";
            this.chk11.UseVisualStyleBackColor = true;
            // 
            // chk12
            // 
            this.chk12.AutoSize = true;
            this.chk12.Location = new System.Drawing.Point(149, 156);
            this.chk12.Name = "chk12";
            this.chk12.Size = new System.Drawing.Size(107, 17);
            this.chk12.TabIndex = 1;
            this.chk12.Text = "Print User Details";
            this.chk12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 340);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Add New User ::";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUPass;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chk12;
        private System.Windows.Forms.CheckBox chk11;
        private System.Windows.Forms.CheckBox chk10;
    }
}

