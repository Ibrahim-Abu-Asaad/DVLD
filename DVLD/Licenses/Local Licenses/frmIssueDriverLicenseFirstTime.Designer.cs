namespace DVLD.Licenses.Local_Licenses
{
    partial class frmIssueDriverLicenseFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDriverLicenseFirstTime));
            ctrlLocalDrivingLicenseAppInfo1 = new Applications.LocalDrivingLicenseApplications.ctrlLocalDrivingLicenseAppInfo();
            lblPassword = new Label();
            rtxtNotes = new RichTextBox();
            btnIssue = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            label7 = new Label();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            ctrlLocalDrivingLicenseAppInfo1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlLocalDrivingLicenseAppInfo1.Location = new Point(22, 107);
            ctrlLocalDrivingLicenseAppInfo1.MinimumSize = new Size(1, 1);
            ctrlLocalDrivingLicenseAppInfo1.Name = "ctrlLocalDrivingLicenseAppInfo1";
            ctrlLocalDrivingLicenseAppInfo1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlLocalDrivingLicenseAppInfo1.Size = new Size(926, 545);
            ctrlLocalDrivingLicenseAppInfo1.TabIndex = 0;
            ctrlLocalDrivingLicenseAppInfo1.Text = "ctrlLocalDrivingLicenseAppInfo1";
            ctrlLocalDrivingLicenseAppInfo1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(58, 598);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 26);
            lblPassword.TabIndex = 32;
            lblPassword.Text = "Notes:";
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(135, 655);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(566, 120);
            rtxtNotes.TabIndex = 33;
            rtxtNotes.Text = "";
            // 
            // btnIssue
            // 
            btnIssue.Cursor = Cursors.Hand;
            btnIssue.Font = new Font("Microsoft Sans Serif", 12F);
            btnIssue.Location = new Point(707, 731);
            btnIssue.MinimumSize = new Size(1, 1);
            btnIssue.Name = "btnIssue";
            btnIssue.Radius = 10;
            btnIssue.Size = new Size(125, 44);
            btnIssue.TabIndex = 35;
            btnIssue.Text = "Issue";
            btnIssue.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(838, 731);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(233, 55);
            label7.Name = "label7";
            label7.Size = new Size(497, 49);
            label7.TabIndex = 154;
            label7.Text = "Issue License (First Time)";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(717, 55);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(71, 52);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 155;
            pictureBox11.TabStop = false;
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(969, 792);
            ControlBox = false;
            Controls.Add(pictureBox11);
            Controls.Add(label7);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(rtxtNotes);
            Controls.Add(lblPassword);
            Controls.Add(ctrlLocalDrivingLicenseAppInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmIssueDriverLicenseFirstTime";
            ShowIcon = false;
            Text = "Issue Driver License First Time";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmIssueDriverLicenseFirstTime_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.LocalDrivingLicenseApplications.ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
        private Label lblPassword;
        private RichTextBox rtxtNotes;
        private Sunny.UI.UIButton btnIssue;
        private Sunny.UI.UIButton btnClose;
        private Label label7;
        private PictureBox pictureBox11;
    }
}