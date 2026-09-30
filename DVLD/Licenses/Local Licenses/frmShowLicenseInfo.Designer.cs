namespace DVLD.Licenses.Local_Licenses
{
    partial class frmShowLicenseInfo
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
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            btnClose = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenseInfo1.Location = new Point(23, 48);
            ctrlDriverLicenseInfo1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenseInfo1.Size = new Size(1068, 425);
            ctrlDriverLicenseInfo1.TabIndex = 0;
            ctrlDriverLicenseInfo1.Text = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(955, 479);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 82;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // frmShowLicenseInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1093, 535);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(ctrlDriverLicenseInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowLicenseInfo";
            ShowIcon = false;
            Text = "Show License Info";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmShowLicenseInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private Sunny.UI.UIButton btnClose;
    }
}