namespace ATM_Final
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withDrawReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Totalcustmerlst = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstAccno = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Trclist = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xAccList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstDpst = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lstwithDraw = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.viewAccountToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.accountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountToolStripMenuItem.Image")));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newAccountToolStripMenuItem.BackgroundImage")));
            this.newAccountToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newAccountToolStripMenuItem.Text = "&New Account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // viewAccountToolStripMenuItem
            // 
            this.viewAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAccountToolStripMenuItem.Image")));
            this.viewAccountToolStripMenuItem.Name = "viewAccountToolStripMenuItem";
            this.viewAccountToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewAccountToolStripMenuItem.Text = "&View Account";
            this.viewAccountToolStripMenuItem.Click += new System.EventHandler(this.viewAccountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositeReportToolStripMenuItem,
            this.withDrawReportToolStripMenuItem,
            this.balanceReportToolStripMenuItem,
            this.exitToolStripMenuItem2});
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // depositeReportToolStripMenuItem
            // 
            this.depositeReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("depositeReportToolStripMenuItem.Image")));
            this.depositeReportToolStripMenuItem.Name = "depositeReportToolStripMenuItem";
            this.depositeReportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.depositeReportToolStripMenuItem.Text = "&Deposite Report";
            this.depositeReportToolStripMenuItem.Click += new System.EventHandler(this.depositeReportToolStripMenuItem_Click);
            // 
            // withDrawReportToolStripMenuItem
            // 
            this.withDrawReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("withDrawReportToolStripMenuItem.Image")));
            this.withDrawReportToolStripMenuItem.Name = "withDrawReportToolStripMenuItem";
            this.withDrawReportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.withDrawReportToolStripMenuItem.Text = "&WithDraw Report";
            this.withDrawReportToolStripMenuItem.Click += new System.EventHandler(this.withDrawReportToolStripMenuItem_Click);
            // 
            // balanceReportToolStripMenuItem
            // 
            this.balanceReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("balanceReportToolStripMenuItem.Image")));
            this.balanceReportToolStripMenuItem.Name = "balanceReportToolStripMenuItem";
            this.balanceReportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.balanceReportToolStripMenuItem.Text = "&Balance Report";
            this.balanceReportToolStripMenuItem.Click += new System.EventHandler(this.balanceReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem2.Image")));
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem2.Text = "&Exit";
            // 
            // logoutMenu
            // 
            this.logoutMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutMenu.Image = ((System.Drawing.Image)(resources.GetObject("logoutMenu.Image")));
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(73, 20);
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // lstDate
            // 
            this.lstDate.BackColor = System.Drawing.Color.Black;
            this.lstDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lstDate.FormattingEnabled = true;
            this.lstDate.Items.AddRange(new object[] {
            "Muhammad Nouman",
            "Syed Zohair Hassan Zaidi",
            "Aamir Ashraf",
            "Mohsin Soomroo",
            "Bilal ",
            "Muddabir",
            "Hassan",
            "Anil"});
            this.lstDate.Location = new System.Drawing.Point(6, 19);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(165, 160);
            this.lstDate.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstDate);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox5.Location = new System.Drawing.Point(849, 304);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 186);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date";
            // 
            // Totalcustmerlst
            // 
            this.Totalcustmerlst.BackColor = System.Drawing.Color.Black;
            this.Totalcustmerlst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Totalcustmerlst.FormattingEnabled = true;
            this.Totalcustmerlst.Items.AddRange(new object[] {
            "Muhammad Nouman",
            "Syed Zohair Hassan Zaidi",
            "Aamir Ashraf",
            "Mohsin Soomroo",
            "Bilal ",
            "Muddabir",
            "Hassan",
            "Anil"});
            this.Totalcustmerlst.Location = new System.Drawing.Point(6, 19);
            this.Totalcustmerlst.Name = "Totalcustmerlst";
            this.Totalcustmerlst.Size = new System.Drawing.Size(294, 186);
            this.Totalcustmerlst.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Totalcustmerlst);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox4.Location = new System.Drawing.Point(720, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 216);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Customers";
            // 
            // lstAccno
            // 
            this.lstAccno.BackColor = System.Drawing.Color.Black;
            this.lstAccno.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lstAccno.FormattingEnabled = true;
            this.lstAccno.Items.AddRange(new object[] {
            "6-2-2014 - 12:15 - Login",
            "7-2-2014 - 12:15 - Withdraw",
            "8-2-2014 - 12:15 - Deposite",
            "9-2-2014 - 12:15 - Withdraw",
            "10-2-2014 - 12:15 - Withdraw",
            "11-2-2014 - 12:15 - Deposite",
            "12-2-2014 - 12:15 - Deposite",
            "13-2-2014 - 12:15 - Deposite"});
            this.lstAccno.Location = new System.Drawing.Point(6, 19);
            this.lstAccno.Name = "lstAccno";
            this.lstAccno.Size = new System.Drawing.Size(169, 160);
            this.lstAccno.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstAccno);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(32, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Num";
            // 
            // Trclist
            // 
            this.Trclist.BackColor = System.Drawing.Color.Black;
            this.Trclist.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Trclist.FormattingEnabled = true;
            this.Trclist.Items.AddRange(new object[] {
            "6-2-2014 - 12:15",
            "7-2-2014 - 01:16",
            "8-2-2014 - 02:17",
            "9-2-2014 - 03:18",
            "10-2-2014 - 04:19",
            "11-2-2014 - 05:20",
            "12-2-2014 - 06:21"});
            this.Trclist.Location = new System.Drawing.Point(6, 19);
            this.Trclist.Name = "Trclist";
            this.Trclist.Size = new System.Drawing.Size(157, 160);
            this.Trclist.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Trclist);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(246, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // xAccList
            // 
            this.xAccList.BackColor = System.Drawing.Color.Black;
            this.xAccList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.xAccList.FormattingEnabled = true;
            this.xAccList.Items.AddRange(new object[] {
            "Muhammad Nouman",
            "Syed Zohair Hassan Zaidi",
            "Aamir Ashraf",
            "Mohsin Soomroo",
            "Bilal ",
            "Muddabir",
            "Hassan",
            "Anil"});
            this.xAccList.Location = new System.Drawing.Point(6, 19);
            this.xAccList.Name = "xAccList";
            this.xAccList.Size = new System.Drawing.Size(279, 186);
            this.xAccList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xAccList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(26, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Accounts";
            // 
            // xTimer
            // 
            this.xTimer.Enabled = true;
            this.xTimer.Interval = 50;
            this.xTimer.Tick += new System.EventHandler(this.xTimer_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstDpst);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox6.Location = new System.Drawing.Point(442, 304);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 186);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Deposit";
            // 
            // lstDpst
            // 
            this.lstDpst.BackColor = System.Drawing.Color.Black;
            this.lstDpst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lstDpst.FormattingEnabled = true;
            this.lstDpst.Items.AddRange(new object[] {
            "6-2-2014 - 12:15 - Login",
            "7-2-2014 - 12:15 - Withdraw",
            "8-2-2014 - 12:15 - Deposite",
            "9-2-2014 - 12:15 - Withdraw",
            "10-2-2014 - 12:15 - Withdraw",
            "11-2-2014 - 12:15 - Deposite",
            "12-2-2014 - 12:15 - Deposite",
            "13-2-2014 - 12:15 - Deposite"});
            this.lstDpst.Location = new System.Drawing.Point(6, 20);
            this.lstDpst.Name = "lstDpst";
            this.lstDpst.Size = new System.Drawing.Size(175, 160);
            this.lstDpst.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lstwithDraw);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox7.Location = new System.Drawing.Point(653, 304);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(176, 186);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Withdraw";
            // 
            // lstwithDraw
            // 
            this.lstwithDraw.BackColor = System.Drawing.Color.Black;
            this.lstwithDraw.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lstwithDraw.FormattingEnabled = true;
            this.lstwithDraw.Items.AddRange(new object[] {
            "6-2-2014 - 12:15 - Login",
            "7-2-2014 - 12:15 - Withdraw",
            "8-2-2014 - 12:15 - Deposite",
            "9-2-2014 - 12:15 - Withdraw",
            "10-2-2014 - 12:15 - Withdraw",
            "11-2-2014 - 12:15 - Deposite",
            "12-2-2014 - 12:15 - Deposite",
            "13-2-2014 - 12:15 - Deposite"});
            this.lstwithDraw.Location = new System.Drawing.Point(6, 19);
            this.lstwithDraw.Name = "lstwithDraw";
            this.lstwithDraw.Size = new System.Drawing.Size(164, 160);
            this.lstwithDraw.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 506);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Bank - Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withDrawReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox Totalcustmerlst;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstAccno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Trclist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox xAccList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer xTimer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstDpst;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lstwithDraw;
    }
}