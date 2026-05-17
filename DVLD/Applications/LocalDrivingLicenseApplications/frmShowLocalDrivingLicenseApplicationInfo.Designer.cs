namespace DVLD.Applications.LocalDrivingLicenseApplications
{
    partial class frmShowLocalDrivingLicenseApplicationInfo
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
            ctrlLocalDrivingLicenseAppInfo1 = new ctrlLocalDrivingLicenseAppInfo();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            ctrlLocalDrivingLicenseAppInfo1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlLocalDrivingLicenseAppInfo1.Location = new Point(14, 55);
            ctrlLocalDrivingLicenseAppInfo1.MinimumSize = new Size(1, 1);
            ctrlLocalDrivingLicenseAppInfo1.Name = "ctrlLocalDrivingLicenseAppInfo1";
            ctrlLocalDrivingLicenseAppInfo1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlLocalDrivingLicenseAppInfo1.Size = new Size(925, 545);
            ctrlLocalDrivingLicenseAppInfo1.TabIndex = 0;
            ctrlLocalDrivingLicenseAppInfo1.Text = "ctrlLocalDrivingLicenseAppInfo1";
            ctrlLocalDrivingLicenseAppInfo1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmShowLocalDrivingLicenseApplicationInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(963, 622);
            Controls.Add(ctrlLocalDrivingLicenseAppInfo1);
            Name = "frmShowLocalDrivingLicenseApplicationInfo";
            ShowIcon = false;
            Text = "Show Local Driving License ApplicationInfo";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmShowLocalDrivingLicenseApplicationInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
    }
}