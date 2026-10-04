namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceLostOrDamagedLicenseApplication));
            ctrlDriverLicenseInfoWithFilter1 = new Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            rbtnLost = new Sunny.UI.UIRadioButton();
            rbtnDamaged = new Sunny.UI.UIRadioButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            lblRLApplicationID = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            lblApplicationFees = new Label();
            lblApplicationDate = new Label();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            lblOldLicenseID = new Label();
            lblReplacedLicenseID = new Label();
            lblCreatedBy = new Label();
            pictureBox8 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            llblShowLicensesHistory = new LinkLabel();
            llblShowNewLicenseInfo = new LinkLabel();
            btnIssueReplacement = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            ctrlDriverLicenseInfoWithFilter1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Controls.Add(uiGroupBox2);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 47);
            ctrlDriverLicenseInfoWithFilter1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1157, 547);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.Text = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            ctrlDriverLicenseInfoWithFilter1.Click += ctrlDriverLicenseInfoWithFilter1_Click;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(rbtnLost);
            uiGroupBox2.Controls.Add(rbtnDamaged);
            uiGroupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox2.Location = new Point(600, 9);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(286, 104);
            uiGroupBox2.TabIndex = 12;
            uiGroupBox2.Text = "Replace For:";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // rbtnLost
            // 
            rbtnLost.Font = new Font("Microsoft Sans Serif", 12F);
            rbtnLost.Location = new Point(183, 44);
            rbtnLost.MinimumSize = new Size(1, 1);
            rbtnLost.Name = "rbtnLost";
            rbtnLost.Size = new Size(80, 36);
            rbtnLost.TabIndex = 37;
            rbtnLost.Text = "Lost";
            rbtnLost.CheckedChanged += rbtnLost_CheckedChanged;
            // 
            // rbtnDamaged
            // 
            rbtnDamaged.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnDamaged.Location = new Point(44, 44);
            rbtnDamaged.MinimumSize = new Size(1, 1);
            rbtnDamaged.Name = "rbtnDamaged";
            rbtnDamaged.Size = new Size(121, 36);
            rbtnDamaged.TabIndex = 36;
            rbtnDamaged.Text = "Damaged";
            rbtnDamaged.CheckedChanged += rbtnDamaged_CheckedChanged;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(lblRLApplicationID);
            uiGroupBox1.Controls.Add(pictureBox1);
            uiGroupBox1.Controls.Add(label9);
            uiGroupBox1.Controls.Add(lblApplicationFees);
            uiGroupBox1.Controls.Add(lblApplicationDate);
            uiGroupBox1.Controls.Add(pictureBox6);
            uiGroupBox1.Controls.Add(pictureBox2);
            uiGroupBox1.Controls.Add(label5);
            uiGroupBox1.Controls.Add(label6);
            uiGroupBox1.Controls.Add(lblOldLicenseID);
            uiGroupBox1.Controls.Add(lblReplacedLicenseID);
            uiGroupBox1.Controls.Add(lblCreatedBy);
            uiGroupBox1.Controls.Add(pictureBox8);
            uiGroupBox1.Controls.Add(pictureBox4);
            uiGroupBox1.Controls.Add(pictureBox3);
            uiGroupBox1.Controls.Add(label4);
            uiGroupBox1.Controls.Add(label2);
            uiGroupBox1.Controls.Add(label1);
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(29, 590);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(1129, 225);
            uiGroupBox1.TabIndex = 127;
            uiGroupBox1.Text = "Application Info For License Replacement";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblRLApplicationID
            // 
            lblRLApplicationID.AutoSize = true;
            lblRLApplicationID.BackColor = Color.FromArgb(243, 249, 255);
            lblRLApplicationID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRLApplicationID.Location = new Point(282, 54);
            lblRLApplicationID.Name = "lblRLApplicationID";
            lblRLApplicationID.Size = new Size(54, 26);
            lblRLApplicationID.TabIndex = 144;
            lblRLApplicationID.Text = "[????]";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 143;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(243, 249, 255);
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(57, 54);
            label9.Name = "label9";
            label9.Size = new Size(182, 26);
            label9.TabIndex = 142;
            label9.Text = "R.L.Application ID:";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.BackColor = Color.FromArgb(243, 249, 255);
            lblApplicationFees.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(282, 140);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(56, 26);
            lblApplicationFees.TabIndex = 141;
            lblApplicationFees.Text = "[$$$]";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.BackColor = Color.FromArgb(243, 249, 255);
            lblApplicationDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(282, 97);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(54, 26);
            lblApplicationDate.TabIndex = 140;
            lblApplicationDate.Text = "[????]";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(245, 135);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 139;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(245, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 138;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(243, 249, 255);
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 140);
            label5.Name = "label5";
            label5.Size = new Size(169, 26);
            label5.TabIndex = 137;
            label5.Text = "Application Fees:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(243, 249, 255);
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 97);
            label6.Name = "label6";
            label6.Size = new Size(170, 26);
            label6.TabIndex = 136;
            label6.Text = "Application Date:";
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.BackColor = Color.FromArgb(243, 249, 255);
            lblOldLicenseID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldLicenseID.Location = new Point(815, 97);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(54, 26);
            lblOldLicenseID.TabIndex = 135;
            lblOldLicenseID.Text = "[????]";
            // 
            // lblReplacedLicenseID
            // 
            lblReplacedLicenseID.AutoSize = true;
            lblReplacedLicenseID.BackColor = Color.FromArgb(243, 249, 255);
            lblReplacedLicenseID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReplacedLicenseID.Location = new Point(815, 54);
            lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            lblReplacedLicenseID.Size = new Size(54, 26);
            lblReplacedLicenseID.TabIndex = 134;
            lblReplacedLicenseID.Text = "[????]";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.BackColor = Color.FromArgb(243, 249, 255);
            lblCreatedBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(815, 140);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(54, 26);
            lblCreatedBy.TabIndex = 133;
            lblCreatedBy.Text = "[????]";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(778, 135);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 31);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 132;
            pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(778, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 131;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(243, 249, 255);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(778, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 130;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(243, 249, 255);
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(566, 54);
            label4.Name = "label4";
            label4.Size = new Size(198, 26);
            label4.TabIndex = 129;
            label4.Text = "Replaced License ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 249, 255);
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(566, 97);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 128;
            label2.Text = "Old License ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 249, 255);
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 140);
            label1.Name = "label1";
            label1.Size = new Size(118, 26);
            label1.TabIndex = 127;
            label1.Text = "Created By:";
            // 
            // llblShowLicensesHistory
            // 
            llblShowLicensesHistory.AutoSize = true;
            llblShowLicensesHistory.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblShowLicensesHistory.Location = new Point(656, 836);
            llblShowLicensesHistory.Name = "llblShowLicensesHistory";
            llblShowLicensesHistory.Size = new Size(179, 23);
            llblShowLicensesHistory.TabIndex = 131;
            llblShowLicensesHistory.TabStop = true;
            llblShowLicensesHistory.Text = "Show Licenses History";
            // 
            // llblShowNewLicenseInfo
            // 
            llblShowNewLicenseInfo.AutoSize = true;
            llblShowNewLicenseInfo.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblShowNewLicenseInfo.Location = new Point(467, 836);
            llblShowNewLicenseInfo.Name = "llblShowNewLicenseInfo";
            llblShowNewLicenseInfo.Size = new Size(183, 23);
            llblShowNewLicenseInfo.TabIndex = 130;
            llblShowNewLicenseInfo.TabStop = true;
            llblShowNewLicenseInfo.Text = "Show New License Info";
            // 
            // btnIssueReplacement
            // 
            btnIssueReplacement.Font = new Font("Microsoft Sans Serif", 12F);
            btnIssueReplacement.Location = new Point(971, 823);
            btnIssueReplacement.MinimumSize = new Size(1, 1);
            btnIssueReplacement.Name = "btnIssueReplacement";
            btnIssueReplacement.Size = new Size(187, 44);
            btnIssueReplacement.TabIndex = 129;
            btnIssueReplacement.Text = "Issue Replacement";
            btnIssueReplacement.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnIssueReplacement.Click += btnIssueReplacement_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(840, 823);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 128;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1186, 885);
            ControlBox = false;
            Controls.Add(llblShowLicensesHistory);
            Controls.Add(llblShowNewLicenseInfo);
            Controls.Add(btnIssueReplacement);
            Controls.Add(btnClose);
            Controls.Add(uiGroupBox1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReplaceLostOrDamagedLicenseApplication";
            ShowIcon = false;
            Text = "Replace Lost Or Damaged License Application";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmReplaceLostOrDamagedLicenseApplication_Load;
            ctrlDriverLicenseInfoWithFilter1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Label lblRLApplicationID;
        private PictureBox pictureBox1;
        private Label label9;
        private Label lblApplicationFees;
        private Label lblApplicationDate;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label lblOldLicenseID;
        private Label lblReplacedLicenseID;
        private Label lblCreatedBy;
        private PictureBox pictureBox8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label2;
        private Label label1;
        private LinkLabel llblShowLicensesHistory;
        private LinkLabel llblShowNewLicenseInfo;
        private Sunny.UI.UIButton btnIssueReplacement;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIRadioButton rbtnLost;
        private Sunny.UI.UIRadioButton rbtnDamaged;
    }
}