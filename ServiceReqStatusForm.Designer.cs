namespace Municipal_Services_Application_for_South_Africa
{
    partial class ServiceReqStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceReqStatusForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LocationInputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RequestLocationTB = new System.Windows.Forms.RichTextBox();
            this.ServiceReqCategorySelectionListBox = new System.Windows.Forms.ListBox();
            this.RequestDescriptionTb = new System.Windows.Forms.RichTextBox();
            this.ReqStatusListBox = new System.Windows.Forms.ListBox();
            this.ReqDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ViewReqListBox = new System.Windows.Forms.ListBox();
            this.viewReq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubmitRequestButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request a service";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.LocationInputLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.RequestLocationTB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ServiceReqCategorySelectionListBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RequestDescriptionTb, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReqStatusListBox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReqDateTimePicker, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.7234F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.2766F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // LocationInputLabel
            // 
            this.LocationInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationInputLabel.AutoSize = true;
            this.LocationInputLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.LocationInputLabel.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationInputLabel.Location = new System.Drawing.Point(3, 199);
            this.LocationInputLabel.Name = "LocationInputLabel";
            this.LocationInputLabel.Size = new System.Drawing.Size(218, 28);
            this.LocationInputLabel.TabIndex = 16;
            this.LocationInputLabel.Text = "Enter the location where the issue found: ";
            this.LocationInputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 188);
            this.label2.TabIndex = 11;
            this.label2.Text = "STEP 1: Location\r\nWhat to Do: In the “Location” text box,\r\n type the address or l" +
    "ocation where the issue has occurred.\r\nExample: \"123 Elm Street\" or \"Near Centra" +
    "l Park\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label3.Location = new System.Drawing.Point(227, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 72);
            this.label3.TabIndex = 12;
            this.label3.Text = "STEP 2\r\nWhat to Do: choose the appropriate category for your issue.\r\nNote: Make s" +
    "ure to select a category from the list.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label4.Location = new System.Drawing.Point(451, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 142);
            this.label4.TabIndex = 13;
            this.label4.Text = "STEP 3\r\nWhat to Do: In the “Description” rich text box, provide a detailed descri" +
    "ption of the issue.\r\nExample: “There is a water leak on Elm Street causing a sig" +
    "nificant puddle.”\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label5.Location = new System.Drawing.Point(592, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 72);
            this.label5.TabIndex = 14;
            this.label5.Text = "STEP 4\r\nWhat to Do:\r\nChoose a date when you would like the service request fullfi" +
    "lled.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label6.Location = new System.Drawing.Point(763, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 188);
            this.label6.TabIndex = 15;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label7.Location = new System.Drawing.Point(227, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Select Issue Category:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label8.Location = new System.Drawing.Point(451, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 42);
            this.label8.TabIndex = 18;
            this.label8.Text = "Describe the service that the community needs";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CadetBlue;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label9.Location = new System.Drawing.Point(592, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Click on the calendar below";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.label10.Location = new System.Drawing.Point(763, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 50);
            this.label10.TabIndex = 20;
            this.label10.Text = "Has your service request been addressed? Choose the status from the list";
            // 
            // RequestLocationTB
            // 
            this.RequestLocationTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RequestLocationTB.Location = new System.Drawing.Point(3, 241);
            this.RequestLocationTB.Name = "RequestLocationTB";
            this.RequestLocationTB.Size = new System.Drawing.Size(218, 96);
            this.RequestLocationTB.TabIndex = 21;
            this.RequestLocationTB.Text = "";
            // 
            // ServiceReqCategorySelectionListBox
            // 
            this.ServiceReqCategorySelectionListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServiceReqCategorySelectionListBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.ServiceReqCategorySelectionListBox.FormattingEnabled = true;
            this.ServiceReqCategorySelectionListBox.ItemHeight = 14;
            this.ServiceReqCategorySelectionListBox.Items.AddRange(new object[] {
            "Water & Sanitation",
            "Infrustracture",
            "Transportation",
            "Parks & Recreation",
            "Health ",
            "Education",
            "Public Safety"});
            this.ServiceReqCategorySelectionListBox.Location = new System.Drawing.Point(227, 241);
            this.ServiceReqCategorySelectionListBox.Name = "ServiceReqCategorySelectionListBox";
            this.ServiceReqCategorySelectionListBox.Size = new System.Drawing.Size(218, 102);
            this.ServiceReqCategorySelectionListBox.TabIndex = 22;
            // 
            // RequestDescriptionTb
            // 
            this.RequestDescriptionTb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RequestDescriptionTb.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.RequestDescriptionTb.Location = new System.Drawing.Point(451, 241);
            this.RequestDescriptionTb.Name = "RequestDescriptionTb";
            this.RequestDescriptionTb.Size = new System.Drawing.Size(135, 96);
            this.RequestDescriptionTb.TabIndex = 23;
            this.RequestDescriptionTb.Text = "";
            // 
            // ReqStatusListBox
            // 
            this.ReqStatusListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReqStatusListBox.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.ReqStatusListBox.FormattingEnabled = true;
            this.ReqStatusListBox.ItemHeight = 14;
            this.ReqStatusListBox.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Completed",
            "On Hold",
            "Cancelled"});
            this.ReqStatusListBox.Location = new System.Drawing.Point(763, 241);
            this.ReqStatusListBox.Name = "ReqStatusListBox";
            this.ReqStatusListBox.Size = new System.Drawing.Size(139, 102);
            this.ReqStatusListBox.TabIndex = 25;
            // 
            // ReqDateTimePicker
            // 
            this.ReqDateTimePicker.Location = new System.Drawing.Point(592, 241);
            this.ReqDateTimePicker.Name = "ReqDateTimePicker";
            this.ReqDateTimePicker.Size = new System.Drawing.Size(165, 20);
            this.ReqDateTimePicker.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ViewReqListBox);
            this.tabPage2.Controls.Add(this.viewReq);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service request progress";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ViewReqListBox
            // 
            this.ViewReqListBox.FormattingEnabled = true;
            this.ViewReqListBox.Location = new System.Drawing.Point(169, 28);
            this.ViewReqListBox.Name = "ViewReqListBox";
            this.ViewReqListBox.Size = new System.Drawing.Size(584, 251);
            this.ViewReqListBox.TabIndex = 1;
            // 
            // viewReq
            // 
            this.viewReq.Location = new System.Drawing.Point(17, 32);
            this.viewReq.Name = "viewReq";
            this.viewReq.Size = new System.Drawing.Size(131, 56);
            this.viewReq.TabIndex = 0;
            this.viewReq.Text = "View Services requested";
            this.viewReq.UseVisualStyleBackColor = true;
            this.viewReq.Click += new System.EventHandler(this.ViewReq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.SubmitRequestButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(734, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Submit the issue and return to Main Menu";
            // 
            // SubmitRequestButton
            // 
            this.SubmitRequestButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitRequestButton.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitRequestButton.Location = new System.Drawing.Point(19, 34);
            this.SubmitRequestButton.Name = "SubmitRequestButton";
            this.SubmitRequestButton.Size = new System.Drawing.Size(134, 32);
            this.SubmitRequestButton.TabIndex = 4;
            this.SubmitRequestButton.Text = "Submit Request";
            this.SubmitRequestButton.UseVisualStyleBackColor = false;
            this.SubmitRequestButton.Click += new System.EventHandler(this.SubmitReqButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(19, 72);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 33);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear ";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // ServiceReqStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(934, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServiceReqStatusForm";
            this.Text = "Service Request ";
            this.Load += new System.EventHandler(this.ServiceReqStatusForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LocationInputLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox RequestLocationTB;
        private System.Windows.Forms.ListBox ServiceReqCategorySelectionListBox;
        private System.Windows.Forms.RichTextBox RequestDescriptionTb;
        private System.Windows.Forms.ListBox ReqStatusListBox;
        private System.Windows.Forms.DateTimePicker ReqDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SubmitRequestButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button viewReq;
        private System.Windows.Forms.ListBox ViewReqListBox;
    }
}