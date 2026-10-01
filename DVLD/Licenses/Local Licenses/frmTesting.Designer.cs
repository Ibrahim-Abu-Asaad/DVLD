namespace DVLD.Licenses.Local_Licenses
{
    partial class frmTesting
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
            ctrlDriverLicenseInfoWithFilter1 = new Controls.ctrlDriverLicenseInfoWithFilter();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(13, 55);
            ctrlDriverLicenseInfoWithFilter1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1086, 551);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.Text = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmTesting
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1111, 613);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Name = "frmTesting";
            Text = "frmTesting";
            ZoomScaleRect = new Rectangle(19, 19, 1370, 586);
            Load += frmTesting_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}