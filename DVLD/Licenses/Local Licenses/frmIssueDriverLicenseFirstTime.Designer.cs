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
            ctrlLocalDrivingLicenseAppInfo1 = new Applications.LocalDrivingLicenseApplications.ctrlLocalDrivingLicenseAppInfo();
            lblPassword = new Label();
            rtxtNotes = new RichTextBox();
            btnIssue = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            ctrlLocalDrivingLicenseAppInfo1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlLocalDrivingLicenseAppInfo1.Location = new Point(21, 50);
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
            rtxtNotes.Location = new Point(134, 598);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(566, 120);
            rtxtNotes.TabIndex = 33;
            rtxtNotes.Text = "";
            // 
            // btnIssue
            // 
            btnIssue.Cursor = Cursors.Hand;
            btnIssue.Font = new Font("Microsoft Sans Serif", 12F);
            btnIssue.Location = new Point(706, 674);
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
            btnClose.Location = new Point(837, 674);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(969, 792);
            ControlBox = false;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.LocalDrivingLicenseApplications.ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
        private Label lblPassword;
        private RichTextBox rtxtNotes;
        private Sunny.UI.UIButton btnIssue;
        private Sunny.UI.UIButton btnClose;
    }
}