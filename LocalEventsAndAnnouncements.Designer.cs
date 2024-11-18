namespace Municipal_Services_Application_for_South_Africa
{
    partial class LocalEventsAndAnnouncements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEventsAndAnnouncements));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchResultsLB = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upcomingSearchByBtn = new System.Windows.Forms.Button();
            this.searchDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchCategoryCB = new System.Windows.Forms.ComboBox();
            this.keywordSearchTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewQueueDictBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ToSavingEventsandAnouc = new System.Windows.Forms.Button();
            this.viewEventsAndAnnoucements = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 181);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.searchResultsLB);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seearch Local Events and Announcements";
            // 
            // searchResultsLB
            // 
            this.searchResultsLB.FormattingEnabled = true;
            this.searchResultsLB.Location = new System.Drawing.Point(252, 10);
            this.searchResultsLB.Name = "searchResultsLB";
            this.searchResultsLB.Size = new System.Drawing.Size(658, 277);
            this.searchResultsLB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.upcomingSearchByBtn);
            this.groupBox1.Controls.Add(this.searchDateTimePicker1);
            this.groupBox1.Controls.Add(this.searchCategoryCB);
            this.groupBox1.Controls.Add(this.keywordSearchTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CategoryLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // upcomingSearchByBtn
            // 
            this.upcomingSearchByBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upcomingSearchByBtn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingSearchByBtn.ForeColor = System.Drawing.Color.Black;
            this.upcomingSearchByBtn.Location = new System.Drawing.Point(85, 155);
            this.upcomingSearchByBtn.Name = "upcomingSearchByBtn";
            this.upcomingSearchByBtn.Size = new System.Drawing.Size(75, 23);
            this.upcomingSearchByBtn.TabIndex = 7;
            this.upcomingSearchByBtn.Text = "SEARCH";
            this.upcomingSearchByBtn.UseVisualStyleBackColor = false;
            this.upcomingSearchByBtn.Click += new System.EventHandler(this.UpcomingSearchByBtn_Click);
            // 
            // searchDateTimePicker1
            // 
            this.searchDateTimePicker1.Location = new System.Drawing.Point(21, 111);
            this.searchDateTimePicker1.Name = "searchDateTimePicker1";
            this.searchDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.searchDateTimePicker1.TabIndex = 5;
            // 
            // searchCategoryCB
            // 
            this.searchCategoryCB.FormattingEnabled = true;
            this.searchCategoryCB.Items.AddRange(new object[] {
            "Water & Sanitation",
            "Infrustracture",
            "Transportation",
            "Parks & Recreation",
            "Health ",
            "Education",
            "Public Safety"});
            this.searchCategoryCB.Location = new System.Drawing.Point(6, 71);
            this.searchCategoryCB.Name = "searchCategoryCB";
            this.searchCategoryCB.Size = new System.Drawing.Size(215, 21);
            this.searchCategoryCB.TabIndex = 4;
            // 
            // keywordSearchTB
            // 
            this.keywordSearchTB.Location = new System.Drawing.Point(6, 32);
            this.keywordSearchTB.Name = "keywordSearchTB";
            this.keywordSearchTB.Size = new System.Drawing.Size(215, 20);
            this.keywordSearchTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "keyword, name etc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.ForeColor = System.Drawing.Color.Black;
            this.CategoryLabel.Location = new System.Drawing.Point(89, 55);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.viewEventsAndAnnoucements);
            this.tabPage2.ForeColor = System.Drawing.Color.Transparent;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Events and announcements";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewQueueDictBTN);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ToSavingEventsandAnouc);
            this.groupBox2.Location = new System.Drawing.Point(562, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What to do next:";
            // 
            // viewQueueDictBTN
            // 
            this.viewQueueDictBTN.ForeColor = System.Drawing.Color.Black;
            this.viewQueueDictBTN.Location = new System.Drawing.Point(217, 20);
            this.viewQueueDictBTN.Name = "viewQueueDictBTN";
            this.viewQueueDictBTN.Size = new System.Drawing.Size(97, 56);
            this.viewQueueDictBTN.TabIndex = 3;
            this.viewQueueDictBTN.Text = "Show me events and announcements";
            this.viewQueueDictBTN.UseVisualStyleBackColor = true;
            this.viewQueueDictBTN.Click += new System.EventHandler(this.viewQueueDictBTN_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(15, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear event details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToSavingEventsandAnouc
            // 
            this.ToSavingEventsandAnouc.ForeColor = System.Drawing.Color.Black;
            this.ToSavingEventsandAnouc.Location = new System.Drawing.Point(106, 19);
            this.ToSavingEventsandAnouc.Name = "ToSavingEventsandAnouc";
            this.ToSavingEventsandAnouc.Size = new System.Drawing.Size(104, 57);
            this.ToSavingEventsandAnouc.TabIndex = 2;
            this.ToSavingEventsandAnouc.Text = "Add another event";
            this.ToSavingEventsandAnouc.UseVisualStyleBackColor = true;
            this.ToSavingEventsandAnouc.Click += new System.EventHandler(this.ToSavingEventsandAnouc_Click);
            // 
            // viewEventsAndAnnoucements
            // 
            this.viewEventsAndAnnoucements.FormattingEnabled = true;
            this.viewEventsAndAnnoucements.Location = new System.Drawing.Point(6, 18);
            this.viewEventsAndAnnoucements.Name = "viewEventsAndAnnoucements";
            this.viewEventsAndAnnoucements.Size = new System.Drawing.Size(529, 264);
            this.viewEventsAndAnnoucements.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "The community Upcoming Events and Annoucement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(769, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "Click on Help to check out\r\nhow the Search By feature is useful \r\nfor  finding sp" +
    "ecific events or announcements";
            // 
            // LocalEventsAndAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(926, 522);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LocalEventsAndAnnouncements";
            this.Text = "Local Events And Announcements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keywordSearchTB;
        private System.Windows.Forms.DateTimePicker searchDateTimePicker1;
        private System.Windows.Forms.ComboBox searchCategoryCB;
        private System.Windows.Forms.Button upcomingSearchByBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ToSavingEventsandAnouc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox viewEventsAndAnnoucements;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button viewQueueDictBTN;
        private System.Windows.Forms.ListBox searchResultsLB;
    }
}