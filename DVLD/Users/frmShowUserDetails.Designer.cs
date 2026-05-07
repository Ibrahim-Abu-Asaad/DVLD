namespace DVLD.Users
{
    partial class frmShowUserDetails
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
            label1 = new Label();
            ctrlShowUserDetails2 = new Controls.ctrlShowUserDetails();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(338, 55);
            label1.Name = "label1";
            label1.Size = new Size(355, 49);
            label1.TabIndex = 3;
            label1.Text = "Show User Details";
            // 
            // ctrlShowUserDetails2
            // 
            ctrlShowUserDetails2.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowUserDetails2.Location = new Point(2, 107);
            ctrlShowUserDetails2.MinimumSize = new Size(1, 1);
            ctrlShowUserDetails2.Name = "ctrlShowUserDetails2";
            ctrlShowUserDetails2.RectColor = Color.FromArgb(243, 249, 255);
            ctrlShowUserDetails2.Size = new Size(981, 526);
            ctrlShowUserDetails2.TabIndex = 4;
            ctrlShowUserDetails2.Text = "ctrlShowUserDetails2";
            ctrlShowUserDetails2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmShowUserDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(994, 637);
            Controls.Add(ctrlShowUserDetails2);
            Controls.Add(label1);
            Name = "frmShowUserDetails";
            ShowIcon = false;
            Text = "Show User Details";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmShowUserDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlShowUserDetails ctrlShowUserDetails1;
        private Label label1;
        private Controls.ctrlShowUserDetails ctrlShowUserDetails2;
    }
}