namespace UserMgmApp
{
    partial class MainApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintUser = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtUPass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomer,
            this.mnuProduct,
            this.mnuStock,
            this.mnuUsers,
            this.mnuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddCustomer,
            this.mnuViewCustomer,
            this.mnuPrintCustomer,
            this.mnuExit});
            this.mnuCustomer.Enabled = false;
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(71, 20);
            this.mnuCustomer.Text = "&Customer";
            // 
            // mnuProduct
            // 
            this.mnuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddProduct,
            this.mnuViewProduct,
            this.mnuPrintProduct});
            this.mnuProduct.Enabled = false;
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(61, 20);
            this.mnuProduct.Text = "&Product";
            // 
            // mnuStock
            // 
            this.mnuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddItem,
            this.mnuViewItem,
            this.mnuPrintItem});
            this.mnuStock.Enabled = false;
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(48, 20);
            this.mnuStock.Text = "&Stock";
            // 
            // mnuUsers
            // 
            this.mnuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddUser,
            this.mnuViewUser,
            this.mnuPrintUser});
            this.mnuUsers.Enabled = false;
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(47, 20);
            this.mnuUsers.Text = "&Users";
            // 
            // mnuAddCustomer
            // 
            this.mnuAddCustomer.Name = "mnuAddCustomer";
            this.mnuAddCustomer.Size = new System.Drawing.Size(178, 22);
            this.mnuAddCustomer.Text = "Add New Customer";
            // 
            // mnuViewCustomer
            // 
            this.mnuViewCustomer.Name = "mnuViewCustomer";
            this.mnuViewCustomer.Size = new System.Drawing.Size(178, 22);
            this.mnuViewCustomer.Text = "View Customer";
            // 
            // mnuPrintCustomer
            // 
            this.mnuPrintCustomer.Name = "mnuPrintCustomer";
            this.mnuPrintCustomer.Size = new System.Drawing.Size(178, 22);
            this.mnuPrintCustomer.Text = "Print Customer";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(178, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuAddProduct
            // 
            this.mnuAddProduct.Name = "mnuAddProduct";
            this.mnuAddProduct.Size = new System.Drawing.Size(152, 22);
            this.mnuAddProduct.Text = "Add Product";
            // 
            // mnuViewProduct
            // 
            this.mnuViewProduct.Name = "mnuViewProduct";
            this.mnuViewProduct.Size = new System.Drawing.Size(152, 22);
            this.mnuViewProduct.Text = "View Product";
            // 
            // mnuPrintProduct
            // 
            this.mnuPrintProduct.Name = "mnuPrintProduct";
            this.mnuPrintProduct.Size = new System.Drawing.Size(152, 22);
            this.mnuPrintProduct.Text = "Print Product";
            // 
            // mnuAddItem
            // 
            this.mnuAddItem.Name = "mnuAddItem";
            this.mnuAddItem.Size = new System.Drawing.Size(152, 22);
            this.mnuAddItem.Text = "Add Item";
            // 
            // mnuViewItem
            // 
            this.mnuViewItem.Name = "mnuViewItem";
            this.mnuViewItem.Size = new System.Drawing.Size(152, 22);
            this.mnuViewItem.Text = "View Item";
            // 
            // mnuPrintItem
            // 
            this.mnuPrintItem.Name = "mnuPrintItem";
            this.mnuPrintItem.Size = new System.Drawing.Size(152, 22);
            this.mnuPrintItem.Text = "Print Item";
            // 
            // mnuAddUser
            // 
            this.mnuAddUser.Name = "mnuAddUser";
            this.mnuAddUser.Size = new System.Drawing.Size(152, 22);
            this.mnuAddUser.Text = "Add User";
            this.mnuAddUser.Click += new System.EventHandler(this.mnuAddUser_Click);
            // 
            // mnuViewUser
            // 
            this.mnuViewUser.Name = "mnuViewUser";
            this.mnuViewUser.Size = new System.Drawing.Size(152, 22);
            this.mnuViewUser.Text = "View User";
            // 
            // mnuPrintUser
            // 
            this.mnuPrintUser.Name = "mnuPrintUser";
            this.mnuPrintUser.Size = new System.Drawing.Size(152, 22);
            this.mnuPrintUser.Text = "Print User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txtUPass);
            this.groupBox1.Controls.Add(this.txtUName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(73, 25);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(157, 20);
            this.txtUName.TabIndex = 1;
            // 
            // txtUPass
            // 
            this.txtUPass.Location = new System.Drawing.Point(73, 51);
            this.txtUPass.Name = "txtUPass";
            this.txtUPass.Size = new System.Drawing.Size(157, 20);
            this.txtUPass.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(155, 77);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(73, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(57, 20);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Main Appication ::";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuAddProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuViewProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuAddUser;
        private System.Windows.Forms.ToolStripMenuItem mnuViewUser;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUPass;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
    }
}