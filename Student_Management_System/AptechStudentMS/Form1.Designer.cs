namespace AptechStudentMS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstStudent = new System.Windows.Forms.ListView();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.LargeImg = new System.Windows.Forms.ImageList(this.components);
            this.SmallImg = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.GridLines = true;
            this.lstStudent.LargeImageList = this.LargeImg;
            this.lstStudent.Location = new System.Drawing.Point(12, 12);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(510, 451);
            this.lstStudent.SmallImageList = this.SmallImg;
            this.lstStudent.TabIndex = 0;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.DoubleClick += new System.EventHandler(this.lstStudent_DoubleClick);
            // 
            // cmbView
            // 
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Items.AddRange(new object[] {
            "Large Icon",
            "Small Icon",
            "Tile",
            "List",
            "Details"});
            this.cmbView.Location = new System.Drawing.Point(12, 469);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(121, 21);
            this.cmbView.TabIndex = 1;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(447, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LargeImg
            // 
            this.LargeImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeImg.ImageStream")));
            this.LargeImg.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeImg.Images.SetKeyName(0, "100.JPG");
            this.LargeImg.Images.SetKeyName(1, "101.JPG");
            this.LargeImg.Images.SetKeyName(2, "102.JPG");
            this.LargeImg.Images.SetKeyName(3, "103.JPG");
            this.LargeImg.Images.SetKeyName(4, "104.JPG");
            this.LargeImg.Images.SetKeyName(5, "105.JPG");
            this.LargeImg.Images.SetKeyName(6, "106.JPG");
            this.LargeImg.Images.SetKeyName(7, "107.JPG");
            this.LargeImg.Images.SetKeyName(8, "108.JPG");
            this.LargeImg.Images.SetKeyName(9, "109.JPG");
            this.LargeImg.Images.SetKeyName(10, "110.JPG");
            this.LargeImg.Images.SetKeyName(11, "111.JPG");
            this.LargeImg.Images.SetKeyName(12, "112.JPG");
            this.LargeImg.Images.SetKeyName(13, "113.JPG");
            this.LargeImg.Images.SetKeyName(14, "114.JPG");
            this.LargeImg.Images.SetKeyName(15, "115.JPG");
            this.LargeImg.Images.SetKeyName(16, "116.JPG");
            this.LargeImg.Images.SetKeyName(17, "117.JPG");
            this.LargeImg.Images.SetKeyName(18, "118.JPG");
            this.LargeImg.Images.SetKeyName(19, "119.JPG");
            // 
            // SmallImg
            // 
            this.SmallImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallImg.ImageStream")));
            this.SmallImg.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallImg.Images.SetKeyName(0, "100.JPG");
            this.SmallImg.Images.SetKeyName(1, "101.JPG");
            this.SmallImg.Images.SetKeyName(2, "102.JPG");
            this.SmallImg.Images.SetKeyName(3, "103.JPG");
            this.SmallImg.Images.SetKeyName(4, "104.JPG");
            this.SmallImg.Images.SetKeyName(5, "105.JPG");
            this.SmallImg.Images.SetKeyName(6, "106.JPG");
            this.SmallImg.Images.SetKeyName(7, "107.JPG");
            this.SmallImg.Images.SetKeyName(8, "108.JPG");
            this.SmallImg.Images.SetKeyName(9, "109.JPG");
            this.SmallImg.Images.SetKeyName(10, "110.JPG");
            this.SmallImg.Images.SetKeyName(11, "111.JPG");
            this.SmallImg.Images.SetKeyName(12, "112.JPG");
            this.SmallImg.Images.SetKeyName(13, "113.JPG");
            this.SmallImg.Images.SetKeyName(14, "114.JPG");
            this.SmallImg.Images.SetKeyName(15, "115.JPG");
            this.SmallImg.Images.SetKeyName(16, "116.JPG");
            this.SmallImg.Images.SetKeyName(17, "117.JPG");
            this.SmallImg.Images.SetKeyName(18, "118.JPG");
            this.SmallImg.Images.SetKeyName(19, "119.JPG");
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(139, 469);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 502);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.lstStudent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: APTECH Student App ::";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstStudent;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList LargeImg;
        private System.Windows.Forms.ImageList SmallImg;
        private System.Windows.Forms.Button btnRefresh;
    }
}

