namespace Municipal_Services_Application_for_South_Africa
{
    partial class ReportIssuesForm
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
            this.LocationInputTextBox = new System.Windows.Forms.TextBox();
            this.CategorySelectionListBox = new System.Windows.Forms.ListBox();
            this.DescriptionBoxRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MediaAttachmentDialogButton = new System.Windows.Forms.Button();
            this.SubmitReportButton = new System.Windows.Forms.Button();
            this.EngagementFeatureProgressBar = new System.Windows.Forms.ProgressBar();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryListBoxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LocationInputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MediaAttachmentDialog = new System.Windows.Forms.OpenFileDialog();
            this.ReportIssuesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ReportIssuesMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationInputTextBox
            // 
            this.LocationInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationInputTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LocationInputTextBox.Location = new System.Drawing.Point(6, 190);
            this.LocationInputTextBox.Name = "LocationInputTextBox";
            this.LocationInputTextBox.Size = new System.Drawing.Size(94, 20);
            this.LocationInputTextBox.TabIndex = 0;
            this.LocationInputTextBox.TextChanged += new System.EventHandler(this.LocationInputTextBox_TextChanged);
            // 
            // CategorySelectionListBox
            // 
            this.CategorySelectionListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategorySelectionListBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySelectionListBox.FormattingEnabled = true;
            this.CategorySelectionListBox.ItemHeight = 14;
            this.CategorySelectionListBox.Items.AddRange(new object[] {
            "Water & Sanitation",
            "Infrustracture",
            "Transportation",
            "Parks & Recreation",
            "Health ",
            "Education",
            "Public Safety"});
            this.CategorySelectionListBox.Location = new System.Drawing.Point(109, 190);
            this.CategorySelectionListBox.Name = "CategorySelectionListBox";
            this.CategorySelectionListBox.Size = new System.Drawing.Size(103, 32);
            this.CategorySelectionListBox.TabIndex = 1;
            this.CategorySelectionListBox.SelectedIndexChanged += new System.EventHandler(this.CategorySelectionListBox_SelectedIndexChanged);
            // 
            // DescriptionBoxRichTextBox
            // 
            this.DescriptionBoxRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionBoxRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DescriptionBoxRichTextBox.Location = new System.Drawing.Point(221, 190);
            this.DescriptionBoxRichTextBox.Name = "DescriptionBoxRichTextBox";
            this.DescriptionBoxRichTextBox.Size = new System.Drawing.Size(182, 52);
            this.DescriptionBoxRichTextBox.TabIndex = 2;
            this.DescriptionBoxRichTextBox.Text = "";
            this.DescriptionBoxRichTextBox.TextChanged += new System.EventHandler(this.DescriptionBoxRichTextBox_TextChanged);
            // 
            // MediaAttachmentDialogButton
            // 
            this.MediaAttachmentDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaAttachmentDialogButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MediaAttachmentDialogButton.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaAttachmentDialogButton.Location = new System.Drawing.Point(412, 190);
            this.MediaAttachmentDialogButton.Name = "MediaAttachmentDialogButton";
            this.MediaAttachmentDialogButton.Size = new System.Drawing.Size(146, 52);
            this.MediaAttachmentDialogButton.TabIndex = 3;
            this.MediaAttachmentDialogButton.Text = "Attach Photos or Documents";
            this.MediaAttachmentDialogButton.UseVisualStyleBackColor = false;
            this.MediaAttachmentDialogButton.Click += new System.EventHandler(this.MediaAttachmentDialogButton_Click);
            // 
            // SubmitReportButton
            // 
            this.SubmitReportButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitReportButton.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitReportButton.Location = new System.Drawing.Point(34, 35);
            this.SubmitReportButton.Name = "SubmitReportButton";
            this.SubmitReportButton.Size = new System.Drawing.Size(134, 32);
            this.SubmitReportButton.TabIndex = 4;
            this.SubmitReportButton.Text = "Submit Report";
            this.SubmitReportButton.UseVisualStyleBackColor = false;
            this.SubmitReportButton.Click += new System.EventHandler(this.SubmitReportButton_Click);
            // 
            // EngagementFeatureProgressBar
            // 
            this.EngagementFeatureProgressBar.Location = new System.Drawing.Point(567, 146);
            this.EngagementFeatureProgressBar.Name = "EngagementFeatureProgressBar";
            this.EngagementFeatureProgressBar.Size = new System.Drawing.Size(99, 23);
            this.EngagementFeatureProgressBar.TabIndex = 5;
            this.EngagementFeatureProgressBar.Click += new System.EventHandler(this.EngagementFeatureProgressBar_Click);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuButton.Location = new System.Drawing.Point(34, 85);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(134, 40);
            this.BackToMainMenuButton.TabIndex = 6;
            this.BackToMainMenuButton.Text = "Back to Main Menu";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Controls.Add(this.CategoryListBoxLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EngagementFeatureProgressBar, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.MediaAttachmentDialogButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.LocationInputTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LocationInputLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategorySelectionListBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionBoxRichTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 199);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 248);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // CategoryListBoxLabel
            // 
            this.CategoryListBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryListBoxLabel.AutoSize = true;
            this.CategoryListBoxLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.CategoryListBoxLabel.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListBoxLabel.Location = new System.Drawing.Point(109, 149);
            this.CategoryListBoxLabel.Name = "CategoryListBoxLabel";
            this.CategoryListBoxLabel.Size = new System.Drawing.Size(103, 28);
            this.CategoryListBoxLabel.TabIndex = 1;
            this.CategoryListBoxLabel.Text = "Select Issue Category:";
            this.CategoryListBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 114);
            this.label5.TabIndex = 12;
            this.label5.Text = "STEP 3\r\nWhat to Do: In the “Description” rich text box, provide a detailed descri" +
    "ption of the issue.\r\nExample: “There is a water leak on Elm Street causing a sig" +
    "nificant puddle.”";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select files to support your report (optional)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 137);
            this.label1.TabIndex = 10;
            this.label1.Text = "STEP 1: Location\r\nWhat to Do: In the “Location” text box,\r\n type the address or l" +
    "ocation where the issue has occurred.\r\nExample: \"123 Elm Street\" or \"Near Centra" +
    "l Park\"";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 137);
            this.label7.TabIndex = 13;
            this.label7.Text = "STEP 4\r\nWhat to Do:\r\n If you have any photos or documents related to the issue, \r" +
    "\nclick the “Attach Photo or Documents” button to attach files.";
            // 
            // LocationInputLabel
            // 
            this.LocationInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationInputLabel.AutoSize = true;
            this.LocationInputLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.LocationInputLabel.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationInputLabel.Location = new System.Drawing.Point(6, 143);
            this.LocationInputLabel.Name = "LocationInputLabel";
            this.LocationInputLabel.Size = new System.Drawing.Size(94, 41);
            this.LocationInputLabel.TabIndex = 0;
            this.LocationInputLabel.Text = "Enter the location where the issue found: ";
            this.LocationInputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 137);
            this.label2.TabIndex = 11;
            this.label2.Text = "STEP 2\r\nWhat to Do: choose the appropriate category for your issue.\r\nNote: Make s" +
    "ure to select a category from the list.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provide a Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(567, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 86);
            this.label9.TabIndex = 14;
            this.label9.Text = "In the meantime, look below to track your progress of reporting. \r\nYou are doing " +
    "a great job by helping better our communities.Thank you!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Submitting your report...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.SubmitReportButton);
            this.groupBox1.Controls.Add(this.BackToMainMenuButton);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(606, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Submit the issue and return to Main Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MediaAttachmentDialog
            // 
            this.MediaAttachmentDialog.FileName = "MediaAttachment";
            // 
            // ReportIssuesMenuStrip
            // 
            this.ReportIssuesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ReportIssuesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ReportIssuesMenuStrip.Name = "ReportIssuesMenuStrip";
            this.ReportIssuesMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ReportIssuesMenuStrip.TabIndex = 10;
            this.ReportIssuesMenuStrip.Text = "menuStrip1";
            this.ReportIssuesMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ReportIssuesMenuStrip_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.fileExplorerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileExplorerToolStripMenuItem
            // 
            this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
            this.fileExplorerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.fileExplorerToolStripMenuItem.Text = "File Explorer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.BackgroundImage = global::Municipal_Services_Application_for_South_Africa.Properties.Resources._078cea1f_3b72_4953_9be0_20a3dcc79518;
            this.pictureBox1.Image = global::Municipal_Services_Application_for_South_Africa.Properties.Resources._078cea1f_3b72_4953_9be0_20a3dcc79518;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReportIssuesMenuStrip);
            this.MainMenuStrip = this.ReportIssuesMenuStrip;
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ReportIssuesMenuStrip.ResumeLayout(false);
            this.ReportIssuesMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationInputTextBox;
        private System.Windows.Forms.ListBox CategorySelectionListBox;
        private System.Windows.Forms.RichTextBox DescriptionBoxRichTextBox;
        private System.Windows.Forms.Button MediaAttachmentDialogButton;
        private System.Windows.Forms.Button SubmitReportButton;
        private System.Windows.Forms.ProgressBar EngagementFeatureProgressBar;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CategoryListBoxLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LocationInputLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog MediaAttachmentDialog;
        private System.Windows.Forms.MenuStrip ReportIssuesMenuStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExplorerToolStripMenuItem;
        private System.Windows.Forms.Label label9;
    }
}