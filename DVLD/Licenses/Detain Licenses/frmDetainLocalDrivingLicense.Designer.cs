namespace DVLD.Applications.Detain_Local_License
{
    partial class frmDetainLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLocalDrivingLicense));
            ctrlDriverLicenseInfoWithFilter1 = new Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            llblShowPersonLicensesHistory = new LinkLabel();
            llblShowLicenseInfo = new LinkLabel();
            btnDetain = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            lblDetainID = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            lblLicenseID = new Label();
            lblDetainDate = new Label();
            lblCreatedBy = new Label();
            pictureBox8 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblPassword = new Label();
            pictureBox6 = new PictureBox();
            txtFineFees = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(3, 48);
            ctrlDriverLicenseInfoWithFilter1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1159, 548);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.Text = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // llblShowPersonLicensesHistory
            // 
            llblShowPersonLicensesHistory.AutoSize = true;
            llblShowPersonLicensesHistory.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblShowPersonLicensesHistory.Location = new Point(31, 785);
            llblShowPersonLicensesHistory.Name = "llblShowPersonLicensesHistory";
            llblShowPersonLicensesHistory.Size = new Size(234, 23);
            llblShowPersonLicensesHistory.TabIndex = 151;
            llblShowPersonLicensesHistory.TabStop = true;
            llblShowPersonLicensesHistory.Text = "Show Person Licenses History";
            llblShowPersonLicensesHistory.LinkClicked += llblShowLicensesHistory_LinkClicked;
            // 
            // llblShowLicenseInfo
            // 
            llblShowLicenseInfo.AutoSize = true;
            llblShowLicenseInfo.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblShowLicenseInfo.Location = new Point(265, 785);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(145, 23);
            llblShowLicenseInfo.TabIndex = 150;
            llblShowLicenseInfo.TabStop = true;
            llblShowLicenseInfo.Text = "Show License Info";
            llblShowLicenseInfo.LinkClicked += llblShowLicenseInfo_LinkClicked;
            // 
            // btnDetain
            // 
            btnDetain.Font = new Font("Microsoft Sans Serif", 12F);
            btnDetain.Location = new Point(545, 764);
            btnDetain.MinimumSize = new Size(1, 1);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(146, 44);
            btnDetain.TabIndex = 149;
            btnDetain.Text = "Detain License";
            btnDetain.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDetain.Click += btnDetain_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(414, 764);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 148;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.BackColor = Color.FromArgb(243, 249, 255);
            lblDetainID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetainID.Location = new Point(256, 612);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(54, 26);
            lblDetainID.TabIndex = 143;
            lblDetainID.Text = "[????]";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 607);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 142;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(243, 249, 255);
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 612);
            label9.Name = "label9";
            label9.Size = new Size(102, 26);
            label9.TabIndex = 141;
            label9.Text = "Detain ID:";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.BackColor = Color.FromArgb(243, 249, 255);
            lblLicenseID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseID.Location = new Point(787, 612);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(54, 26);
            lblLicenseID.TabIndex = 136;
            lblLicenseID.Text = "[????]";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.BackColor = Color.FromArgb(243, 249, 255);
            lblDetainDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetainDate.Location = new Point(256, 654);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(54, 26);
            lblDetainDate.TabIndex = 134;
            lblDetainDate.Text = "[????]";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.BackColor = Color.FromArgb(243, 249, 255);
            lblCreatedBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(787, 655);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(54, 26);
            lblCreatedBy.TabIndex = 133;
            lblCreatedBy.Text = "[????]";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(750, 650);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 31);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 130;
            pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(750, 607);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 126;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 649);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 124;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(243, 249, 255);
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 696);
            label5.Name = "label5";
            label5.Size = new Size(105, 26);
            label5.TabIndex = 120;
            label5.Text = "Fine Fees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 249, 255);
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(558, 612);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 117;
            label2.Text = "License ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 249, 255);
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 654);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 116;
            label1.Text = "Detain Date:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(243, 249, 255);
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(558, 655);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(118, 26);
            lblPassword.TabIndex = 115;
            lblPassword.Text = "Created By:";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(219, 691);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 128;
            pictureBox6.TabStop = false;
            // 
            // txtFineFees
            // 
            txtFineFees.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFineFees.Location = new Point(257, 686);
            txtFineFees.Margin = new Padding(4, 5, 4, 5);
            txtFineFees.MinimumSize = new Size(1, 16);
            txtFineFees.Name = "txtFineFees";
            txtFineFees.Padding = new Padding(5);
            txtFineFees.ShowText = false;
            txtFineFees.Size = new Size(137, 36);
            txtFineFees.TabIndex = 152;
            txtFineFees.TextAlignment = ContentAlignment.MiddleLeft;
            txtFineFees.Watermark = "";
            txtFineFees.TextChanged += txtFineFees_TextChanged;
            txtFineFees.KeyPress += txtFineFees_KeyPress;
            // 
            // frmDetainLocalDrivingLicense
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1167, 833);
            ControlBox = false;
            Controls.Add(txtFineFees);
            Controls.Add(llblShowPersonLicensesHistory);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(btnDetain);
            Controls.Add(btnClose);
            Controls.Add(lblDetainID);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(lblLicenseID);
            Controls.Add(lblDetainDate);
            Controls.Add(lblCreatedBy);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPassword);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetainLocalDrivingLicense";
            ShowIcon = false;
            Text = "Detain Local Driving License";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmDetainLocalDrivingLicense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private LinkLabel llblShowPersonLicensesHistory;
        private LinkLabel llblShowLicenseInfo;
        private Sunny.UI.UIButton btnDetain;
        private Sunny.UI.UIButton btnClose;
        private Label lblDetainID;
        private PictureBox pictureBox1;
        private Label label9;
        private Label lblLicenseID;
        private Label lblDetainDate;
        private Label lblCreatedBy;
        private PictureBox pictureBox8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label lblPassword;
        private PictureBox pictureBox6;
        private Sunny.UI.UITextBox txtFineFees;
    }
}