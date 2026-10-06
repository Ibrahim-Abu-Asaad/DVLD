namespace DVLD
{
    partial class TEST
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
            ctrlDriverLicenses1 = new Drivers.ctrlDriverLicenses();
            SuspendLayout();
            // 
            // ctrlDriverLicenses1
            // 
            ctrlDriverLicenses1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenses1.Location = new Point(37, 70);
            ctrlDriverLicenses1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenses1.Size = new Size(1058, 453);
            ctrlDriverLicenses1.TabIndex = 0;
            ctrlDriverLicenses1.Text = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TEST
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1113, 630);
            Controls.Add(ctrlDriverLicenses1);
            Name = "TEST";
            Text = "TEST";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += TEST_Load;
            ResumeLayout(false);
        }

        #endregion

        private Drivers.ctrlDriverLicenses ctrlDriverLicenses1;
    }
}