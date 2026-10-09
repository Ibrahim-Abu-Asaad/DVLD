namespace DVLD.Applications.International_Licenses
{
    partial class frmNewInternationalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewInternationalLicenseApplication));
            label1 = new Label();
            ctrlDriverLicenseInfoWithFilter1 = new Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            llblShowLicensesHistory = new LinkLabel();
            llblShowInternationalLicenseInfo = new LinkLabel();
            btnIssueInternationalLicense = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            lblCreatedBy = new Label();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            lblFees = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            lblIssueDate = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            lblExpirationDate = new Label();
            lblInternationalLicenseApplicationID = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            lblInternationalLicenseID = new Label();
            lblApplicationDate = new Label();
            lblLocalLicenseID = new Label();
            pictureBox8 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblPassword = new Label();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(299, 46);
            label1.Name = "label1";
            label1.Size = new Size(640, 49);
            label1.TabIndex = 2;
            label1.Text = "International License Application";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(17, 98);
            ctrlDriverLicenseInfoWithFilter1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1165, 553);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 3;
            ctrlDriverLicenseInfoWithFilter1.Text = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            ctrlDriverLicenseInfoWithFilter1.Click += ctrlDriverLicenseInfoWithFilter1_Click;
            // 
            // llblShowLicensesHistory
            // 
            llblShowLicensesHistory.AutoSize = true;
            llblShowLicensesHistory.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblShowLicensesHistory.Location = new Point(293, 856);
            llblShowLicensesHistory.Name = "llblShowLicensesHistory";
            llblShowLicensesHistory.Size = new Size(179, 23);
            llblShowLicensesHistory.TabIndex = 136;
            llblShowLicensesHistory.TabStop = true;
            llblShowLicensesHistory.Text = "Show Licenses History";
            llblShowLicensesHistory.LinkClicked += llblShowLicensesHistory_LinkClicked;
            // 
            // llblShowInternationalLicenseInfo
            // 
            llblShowInternationalLicenseInfo.AutoSize = true;
            llblShowInternationalLicenseInfo.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblShowInternationalLicenseInfo.Location = new Point(42, 856);
            llblShowInternationalLicenseInfo.Name = "llblShowInternationalLicenseInfo";
            llblShowInternationalLicenseInfo.Size = new Size(249, 23);
            llblShowInternationalLicenseInfo.TabIndex = 135;
            llblShowInternationalLicenseInfo.TabStop = true;
            llblShowInternationalLicenseInfo.Text = "Show International License Info";
            llblShowInternationalLicenseInfo.LinkClicked += llblShowInternationalLicenseInfo_LinkClicked;
            // 
            // btnIssueInternationalLicense
            // 
            btnIssueInternationalLicense.Font = new Font("Microsoft Sans Serif", 12F);
            btnIssueInternationalLicense.Location = new Point(613, 843);
            btnIssueInternationalLicense.MinimumSize = new Size(1, 1);
            btnIssueInternationalLicense.Name = "btnIssueInternationalLicense";
            btnIssueInternationalLicense.Size = new Size(257, 44);
            btnIssueInternationalLicense.TabIndex = 134;
            btnIssueInternationalLicense.Text = "Issue International License";
            btnIssueInternationalLicense.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnIssueInternationalLicense.Click += btnIssueInternationalLicense_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(482, 843);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 133;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.BackColor = Color.FromArgb(243, 249, 255);
            lblCreatedBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(798, 774);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(54, 26);
            lblCreatedBy.TabIndex = 205;
            lblCreatedBy.Text = "[????]";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(761, 769);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 204;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(243, 249, 255);
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(569, 772);
            label7.Name = "label7";
            label7.Size = new Size(118, 26);
            label7.TabIndex = 203;
            label7.Text = "Created By:";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.BackColor = Color.FromArgb(243, 249, 255);
            lblFees.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFees.Location = new Point(267, 774);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(66, 26);
            lblFees.TabIndex = 202;
            lblFees.Text = "[$$$$]";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(230, 769);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 201;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(243, 249, 255);
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 774);
            label6.Name = "label6";
            label6.Size = new Size(60, 26);
            label6.TabIndex = 200;
            label6.Text = "Fees:";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.BackColor = Color.FromArgb(243, 249, 255);
            lblIssueDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIssueDate.Location = new Point(267, 740);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(54, 26);
            lblIssueDate.TabIndex = 199;
            lblIssueDate.Text = "[????]";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(230, 735);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 198;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(243, 249, 255);
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 734);
            label4.Name = "label4";
            label4.Size = new Size(111, 26);
            label4.TabIndex = 197;
            label4.Text = "Issue Date:";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.BackColor = Color.FromArgb(243, 249, 255);
            lblExpirationDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpirationDate.Location = new Point(798, 740);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(54, 26);
            lblExpirationDate.TabIndex = 196;
            lblExpirationDate.Text = "[????]";
            // 
            // lblInternationalLicenseApplicationID
            // 
            lblInternationalLicenseApplicationID.AutoSize = true;
            lblInternationalLicenseApplicationID.BackColor = Color.FromArgb(243, 249, 255);
            lblInternationalLicenseApplicationID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInternationalLicenseApplicationID.Location = new Point(267, 658);
            lblInternationalLicenseApplicationID.Name = "lblInternationalLicenseApplicationID";
            lblInternationalLicenseApplicationID.Size = new Size(54, 26);
            lblInternationalLicenseApplicationID.TabIndex = 195;
            lblInternationalLicenseApplicationID.Text = "[????]";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 653);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 194;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(243, 249, 255);
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(42, 654);
            label9.Name = "label9";
            label9.Size = new Size(107, 26);
            label9.TabIndex = 193;
            label9.Text = "I.L.App ID:";
            // 
            // lblInternationalLicenseID
            // 
            lblInternationalLicenseID.AutoSize = true;
            lblInternationalLicenseID.BackColor = Color.FromArgb(243, 249, 255);
            lblInternationalLicenseID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInternationalLicenseID.Location = new Point(798, 658);
            lblInternationalLicenseID.Name = "lblInternationalLicenseID";
            lblInternationalLicenseID.Size = new Size(54, 26);
            lblInternationalLicenseID.TabIndex = 192;
            lblInternationalLicenseID.Text = "[????]";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.BackColor = Color.FromArgb(243, 249, 255);
            lblApplicationDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(267, 701);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(54, 26);
            lblApplicationDate.TabIndex = 191;
            lblApplicationDate.Text = "[????]";
            // 
            // lblLocalLicenseID
            // 
            lblLocalLicenseID.AutoSize = true;
            lblLocalLicenseID.BackColor = Color.FromArgb(243, 249, 255);
            lblLocalLicenseID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalLicenseID.Location = new Point(798, 701);
            lblLocalLicenseID.Name = "lblLocalLicenseID";
            lblLocalLicenseID.Size = new Size(54, 26);
            lblLocalLicenseID.TabIndex = 190;
            lblLocalLicenseID.Text = "[????]";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(761, 696);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 31);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 189;
            pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(230, 696);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 186;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(243, 249, 255);
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(569, 734);
            label5.Name = "label5";
            label5.Size = new Size(160, 26);
            label5.TabIndex = 185;
            label5.Text = "Expiration Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 249, 255);
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(569, 658);
            label2.Name = "label2";
            label2.Size = new Size(65, 26);
            label2.TabIndex = 184;
            label2.Text = "I.L ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(243, 249, 255);
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 694);
            label3.Name = "label3";
            label3.Size = new Size(170, 26);
            label3.TabIndex = 183;
            label3.Text = "Application Date:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(243, 249, 255);
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(569, 696);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(164, 26);
            lblPassword.TabIndex = 182;
            lblPassword.Text = "Local License ID:";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(761, 653);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 206;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(761, 735);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 207;
            pictureBox6.TabStop = false;
            // 
            // frmNewInternationalLicenseApplication
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1201, 902);
            ControlBox = false;
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(lblCreatedBy);
            Controls.Add(pictureBox7);
            Controls.Add(label7);
            Controls.Add(lblFees);
            Controls.Add(pictureBox5);
            Controls.Add(label6);
            Controls.Add(lblIssueDate);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(lblExpirationDate);
            Controls.Add(lblInternationalLicenseApplicationID);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(lblInternationalLicenseID);
            Controls.Add(lblApplicationDate);
            Controls.Add(lblLocalLicenseID);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblPassword);
            Controls.Add(llblShowLicensesHistory);
            Controls.Add(llblShowInternationalLicenseInfo);
            Controls.Add(btnIssueInternationalLicense);
            Controls.Add(btnClose);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewInternationalLicenseApplication";
            ShowIcon = false;
            Text = "International License Application";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmNewInternationalLicenseApplication_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private LinkLabel llblShowLicensesHistory;
        private LinkLabel llblShowInternationalLicenseInfo;
        private Sunny.UI.UIButton btnIssueInternationalLicense;
        private Sunny.UI.UIButton btnClose;
        private Label lblCreatedBy;
        private PictureBox pictureBox7;
        private Label label7;
        private Label lblFees;
        private PictureBox pictureBox5;
        private Label label6;
        private Label lblIssueDate;
        private PictureBox pictureBox3;
        private Label label4;
        private Label lblExpirationDate;
        private Label lblInternationalLicenseApplicationID;
        private PictureBox pictureBox1;
        private Label label9;
        private Label lblInternationalLicenseID;
        private Label lblApplicationDate;
        private Label lblLocalLicenseID;
        private PictureBox pictureBox8;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label lblPassword;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
    }
}