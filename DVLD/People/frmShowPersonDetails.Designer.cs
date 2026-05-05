namespace DVLD
{
    partial class frmShowPersonDetails
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
            ctrlShowPersonDetails2 = new ctrlShowPersonDetails2();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(348, 55);
            label1.Name = "label1";
            label1.Size = new Size(274, 49);
            label1.TabIndex = 0;
            label1.Text = "Person Details";
            // 
            // ctrlShowPersonDetails2
            // 
            ctrlShowPersonDetails2.BackColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetails2.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowPersonDetails2.Location = new Point(5, 107);
            ctrlShowPersonDetails2.MinimumSize = new Size(1, 1);
            ctrlShowPersonDetails2.Name = "ctrlShowPersonDetails2";
            ctrlShowPersonDetails2.RectColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetails2.Size = new Size(965, 350);
            ctrlShowPersonDetails2.TabIndex = 1;
            ctrlShowPersonDetails2.Text = "ctrlShowPersonDetails21";
            ctrlShowPersonDetails2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmShowPersonDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(973, 470);
            Controls.Add(ctrlShowPersonDetails2);
            Controls.Add(label1);
            Name = "frmShowPersonDetails";
            ShowIcon = false;
            Text = "frmShowPersonDetails";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmShowPersonDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ctrlShowPersonDetails2 ctrlShowPersonDetails2;
    }
}