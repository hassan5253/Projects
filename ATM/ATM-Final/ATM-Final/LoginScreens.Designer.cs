namespace ATM_Final
{
    partial class LoginScreens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreens));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Adminlgn = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdminUpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUSerLogin = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.UserLogn = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Adminlgn.SuspendLayout();
            this.UserLogn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 159);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Adminlgn
            // 
            this.Adminlgn.BackColor = System.Drawing.Color.Transparent;
            this.Adminlgn.Controls.Add(this.button1);
            this.Adminlgn.Controls.Add(this.txtAdminUpass);
            this.Adminlgn.Controls.Add(this.label1);
            this.Adminlgn.Controls.Add(this.txtAdminUName);
            this.Adminlgn.Controls.Add(this.label2);
            this.Adminlgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlgn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Adminlgn.Location = new System.Drawing.Point(179, 244);
            this.Adminlgn.Name = "Adminlgn";
            this.Adminlgn.Size = new System.Drawing.Size(347, 164);
            this.Adminlgn.TabIndex = 6;
            this.Adminlgn.TabStop = false;
            this.Adminlgn.Text = "Admin Login";
            this.Adminlgn.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(207, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdminUpass
            // 
            this.txtAdminUpass.Location = new System.Drawing.Point(122, 77);
            this.txtAdminUpass.Name = "txtAdminUpass";
            this.txtAdminUpass.Size = new System.Drawing.Size(209, 20);
            this.txtAdminUpass.TabIndex = 1;
            this.txtAdminUpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // txtAdminUName
            // 
            this.txtAdminUName.Location = new System.Drawing.Point(122, 41);
            this.txtAdminUName.Name = "txtAdminUName";
            this.txtAdminUName.Size = new System.Drawing.Size(209, 20);
            this.txtAdminUName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(470, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUSerLogin
            // 
            this.btnUSerLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnUSerLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUSerLogin.BackgroundImage")));
            this.btnUSerLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUSerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUSerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSerLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUSerLogin.Location = new System.Drawing.Point(80, 164);
            this.btnUSerLogin.Name = "btnUSerLogin";
            this.btnUSerLogin.Size = new System.Drawing.Size(64, 58);
            this.btnUSerLogin.TabIndex = 4;
            this.btnUSerLogin.Text = "User";
            this.btnUSerLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUSerLogin.UseVisualStyleBackColor = false;
            this.btnUSerLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Location = new System.Drawing.Point(13, 164);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(61, 58);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(37, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pin Code";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(101, 45);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(230, 20);
            this.txtAcc.TabIndex = 0;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAcc.Location = new System.Drawing.Point(17, 45);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(78, 13);
            this.lblAcc.TabIndex = 3;
            this.lblAcc.Text = "Account No ";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(101, 77);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(230, 20);
            this.txtPin.TabIndex = 1;
            this.txtPin.UseSystemPasswordChar = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdminLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminLogin.BackgroundImage")));
            this.btnAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(207, 103);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(124, 41);
            this.btnAdminLogin.TabIndex = 2;
            this.btnAdminLogin.Text = "&Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // UserLogn
            // 
            this.UserLogn.BackColor = System.Drawing.Color.Transparent;
            this.UserLogn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserLogn.Controls.Add(this.btnAdminLogin);
            this.UserLogn.Controls.Add(this.txtPin);
            this.UserLogn.Controls.Add(this.lblAcc);
            this.UserLogn.Controls.Add(this.txtAcc);
            this.UserLogn.Controls.Add(this.label4);
            this.UserLogn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserLogn.Location = new System.Drawing.Point(151, 206);
            this.UserLogn.Name = "UserLogn";
            this.UserLogn.Size = new System.Drawing.Size(347, 164);
            this.UserLogn.TabIndex = 7;
            this.UserLogn.TabStop = false;
            this.UserLogn.Text = "User Login";
            this.UserLogn.Enter += new System.EventHandler(this.UserLogn_Enter);
            // 
            // LoginScreens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 496);
            this.ControlBox = false;
            this.Controls.Add(this.UserLogn);
            this.Controls.Add(this.Adminlgn);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUSerLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginScreens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreens";
            this.Load += new System.EventHandler(this.LoginScreens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Adminlgn.ResumeLayout(false);
            this.Adminlgn.PerformLayout();
            this.UserLogn.ResumeLayout(false);
            this.UserLogn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAdminUpass;
        private System.Windows.Forms.TextBox txtAdminUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Adminlgn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUSerLogin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.GroupBox UserLogn;
    }
}