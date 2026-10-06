namespace DVLD.Drivers
{
    partial class frmShowPersonLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonLicenseHistory));
            btnClose = new Sunny.UI.UIButton();
            ctrlDriverLicenses1 = new ctrlDriverLicenses();
            pictureBox1 = new PictureBox();
            ctrlShowPersonDetailsWithFilter1 = new People.Controls.ctrlShowPersonDetailsWithFilter();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(1172, 903);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 82;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // ctrlDriverLicenses1
            // 
            ctrlDriverLicenses1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenses1.Location = new Point(15, 529);
            ctrlDriverLicenses1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenses1.Size = new Size(1050, 427);
            ctrlDriverLicenses1.TabIndex = 84;
            ctrlDriverLicenses1.Text = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // ctrlShowPersonDetailsWithFilter1
            // 
            ctrlShowPersonDetailsWithFilter1.BackColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetailsWithFilter1.FilterEnabled = true;
            ctrlShowPersonDetailsWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowPersonDetailsWithFilter1.Location = new Point(241, 47);
            ctrlShowPersonDetailsWithFilter1.MinimumSize = new Size(1, 1);
            ctrlShowPersonDetailsWithFilter1.Name = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.ShowAddPersonIcon = true;
            ctrlShowPersonDetailsWithFilter1.Size = new Size(1043, 472);
            ctrlShowPersonDetailsWithFilter1.TabIndex = 86;
            ctrlShowPersonDetailsWithFilter1.Text = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmShowPersonLicenseHistory
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1300, 987);
            ControlBox = false;
            Controls.Add(ctrlShowPersonDetailsWithFilter1);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlDriverLicenses1);
            Controls.Add(btnClose);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowPersonLicenseHistory";
            ShowIcon = false;
            Text = "Show Person License History";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmShowPersonLicenseHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton btnClose;
        private ctrlDriverLicenses ctrlDriverLicenses1;
        private PictureBox pictureBox1;
        private People.Controls.ctrlShowPersonDetailsWithFilter ctrlShowPersonDetailsWithFilter1;
    }
}