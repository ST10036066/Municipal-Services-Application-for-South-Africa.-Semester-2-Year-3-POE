using System.Drawing;

namespace Municipal_Services_Application_for_South_Africa
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ToLocalEventsButton = new System.Windows.Forms.Button();
            this.ToServiceReqStatusButton = new System.Windows.Forms.Button();
            this.ReportIssueOptDescpt = new System.Windows.Forms.Label();
            this.LocalEventsOptDescrpt = new System.Windows.Forms.Label();
            this.ToReportIssueButton = new System.Windows.Forms.Button();
            this.ServiceReqStatusOptDescript = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainMenuGreetDescrp = new System.Windows.Forms.Label();
            this.TodaysDateMainMenu = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.30516F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.69484F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Controls.Add(this.ToLocalEventsButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ToServiceReqStatusButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReportIssueOptDescpt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ToReportIssueButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ServiceReqStatusOptDescript, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LocalEventsOptDescrpt, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.78355F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.21645F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 276);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ToLocalEventsButton
            // 
            this.ToLocalEventsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToLocalEventsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToLocalEventsButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLocalEventsButton.Location = new System.Drawing.Point(293, 141);
            this.ToLocalEventsButton.Name = "ToLocalEventsButton";
            this.ToLocalEventsButton.Size = new System.Drawing.Size(338, 129);
            this.ToLocalEventsButton.TabIndex = 1;
            this.ToLocalEventsButton.Text = "Local Events and Announcements";
            this.ToLocalEventsButton.UseVisualStyleBackColor = false;
            this.ToLocalEventsButton.Click += new System.EventHandler(this.ToLocalEventsButton_Click);
            // 
            // ToServiceReqStatusButton
            // 
            this.ToServiceReqStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToServiceReqStatusButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToServiceReqStatusButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToServiceReqStatusButton.Location = new System.Drawing.Point(640, 141);
            this.ToServiceReqStatusButton.Name = "ToServiceReqStatusButton";
            this.ToServiceReqStatusButton.Size = new System.Drawing.Size(261, 129);
            this.ToServiceReqStatusButton.TabIndex = 2;
            this.ToServiceReqStatusButton.Text = "Service Request Status";
            this.ToServiceReqStatusButton.UseVisualStyleBackColor = false;
            this.ToServiceReqStatusButton.Click += new System.EventHandler(this.ToServiceReqStatusButton_Click);
            // 
            // ReportIssueOptDescpt
            // 
            this.ReportIssueOptDescpt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportIssueOptDescpt.AutoSize = true;
            this.ReportIssueOptDescpt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReportIssueOptDescpt.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIssueOptDescpt.Location = new System.Drawing.Point(6, 3);
            this.ReportIssueOptDescpt.Name = "ReportIssueOptDescpt";
            this.ReportIssueOptDescpt.Size = new System.Drawing.Size(278, 132);
            this.ReportIssueOptDescpt.TabIndex = 3;
            this.ReportIssueOptDescpt.Text = "Tap \'Report Issues\' below to\r\nReport Issues faced by the community by recording\r\n" +
    "the location, What the issue affect and its description.\r\nThis helps the City Co" +
    "unsil analyse and mitagate ASAP  ";
            // 
            // LocalEventsOptDescrpt
            // 
            this.LocalEventsOptDescrpt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalEventsOptDescrpt.AutoSize = true;
            this.LocalEventsOptDescrpt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LocalEventsOptDescrpt.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalEventsOptDescrpt.Location = new System.Drawing.Point(293, 3);
            this.LocalEventsOptDescrpt.Name = "LocalEventsOptDescrpt";
            this.LocalEventsOptDescrpt.Size = new System.Drawing.Size(338, 132);
            this.LocalEventsOptDescrpt.TabIndex = 4;
            this.LocalEventsOptDescrpt.Text = "Tap \'Local Events and Announcements\' below\r\nto make announcemnts about events to " +
    "alert the \r\ncommunity \r\n";
            // 
            // ToReportIssueButton
            // 
            this.ToReportIssueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToReportIssueButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToReportIssueButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToReportIssueButton.Location = new System.Drawing.Point(6, 141);
            this.ToReportIssueButton.Name = "ToReportIssueButton";
            this.ToReportIssueButton.Size = new System.Drawing.Size(278, 129);
            this.ToReportIssueButton.TabIndex = 0;
            this.ToReportIssueButton.Text = "Report Issues";
            this.ToReportIssueButton.UseVisualStyleBackColor = false;
            this.ToReportIssueButton.Click += new System.EventHandler(this.ToReportIssueButton_Click);
            // 
            // ServiceReqStatusOptDescript
            // 
            this.ServiceReqStatusOptDescript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceReqStatusOptDescript.AutoSize = true;
            this.ServiceReqStatusOptDescript.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServiceReqStatusOptDescript.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceReqStatusOptDescript.Location = new System.Drawing.Point(640, 3);
            this.ServiceReqStatusOptDescript.Name = "ServiceReqStatusOptDescript";
            this.ServiceReqStatusOptDescript.Size = new System.Drawing.Size(261, 132);
            this.ServiceReqStatusOptDescript.TabIndex = 5;
            this.ServiceReqStatusOptDescript.Text = "Tap \'Service Request Status\' to manage/monitor the progress of the service \r\nyou " +
    "requested from the municipality\r\n";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.CadetBlue;
            this.LogoPictureBox.BackgroundImage = global::Municipal_Services_Application_for_South_Africa.Properties.Resources._078cea1f_3b72_4953_9be0_20a3dcc79518;
            this.LogoPictureBox.Image = global::Municipal_Services_Application_for_South_Africa.Properties.Resources._078cea1f_3b72_4953_9be0_20a3dcc79518;
            this.LogoPictureBox.Location = new System.Drawing.Point(3, 7);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(224, 131);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 3;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TodaysDateMainMenu);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 202);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.mainMenuGreetDescrp);
            this.panel2.Controls.Add(this.LogoPictureBox);
            this.panel2.Location = new System.Drawing.Point(14, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 141);
            this.panel2.TabIndex = 6;
            // 
            // mainMenuGreetDescrp
            // 
            this.mainMenuGreetDescrp.AutoSize = true;
            this.mainMenuGreetDescrp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainMenuGreetDescrp.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuGreetDescrp.Location = new System.Drawing.Point(233, 17);
            this.mainMenuGreetDescrp.Name = "mainMenuGreetDescrp";
            this.mainMenuGreetDescrp.Size = new System.Drawing.Size(419, 90);
            this.mainMenuGreetDescrp.TabIndex = 6;
            this.mainMenuGreetDescrp.Text = resources.GetString("mainMenuGreetDescrp.Text");
            this.mainMenuGreetDescrp.Click += new System.EventHandler(this.mainMenuGreetDescrp_Click);
            // 
            // TodaysDateMainMenu
            // 
            this.TodaysDateMainMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.TodaysDateMainMenu.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysDateMainMenu.Location = new System.Drawing.Point(690, 31);
            this.TodaysDateMainMenu.Name = "TodaysDateMainMenu";
            this.TodaysDateMainMenu.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplicationToolStripMenuItem1});
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exitApplicationToolStripMenuItem.Text = "Menu ";
            // 
            // exitApplicationToolStripMenuItem1
            // 
            this.exitApplicationToolStripMenuItem1.Name = "exitApplicationToolStripMenuItem1";
            this.exitApplicationToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.exitApplicationToolStripMenuItem1.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem1.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ToReportIssueButton;
        private System.Windows.Forms.Button ToLocalEventsButton;
        private System.Windows.Forms.Button ToServiceReqStatusButton;
        private System.Windows.Forms.Label ReportIssueOptDescpt;
        private System.Windows.Forms.Label LocalEventsOptDescrpt;
        private System.Windows.Forms.Label ServiceReqStatusOptDescript;
        private System.Windows.Forms.MonthCalendar TodaysDateMainMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mainMenuGreetDescrp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
    }
}

