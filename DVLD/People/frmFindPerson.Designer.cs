namespace DVLD.People
{
    partial class frmFindPerson
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
            lblTitle = new Sunny.UI.UILabel();
            btnClose = new Sunny.UI.UISymbolButton();
            ctrlShowPersonDetailsWithFilter1 = new Controls.ctrlShowPersonDetailsWithFilter();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(6, 57);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(995, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Find Person";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(860, 576);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // ctrlShowPersonDetailsWithFilter1
            // 
            ctrlShowPersonDetailsWithFilter1.BackColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetailsWithFilter1.FilterEnabled = true;
            ctrlShowPersonDetailsWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowPersonDetailsWithFilter1.Location = new Point(21, 105);
            ctrlShowPersonDetailsWithFilter1.MinimumSize = new Size(1, 1);
            ctrlShowPersonDetailsWithFilter1.Name = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetailsWithFilter1.ShowAddPersonIcon = true;
            ctrlShowPersonDetailsWithFilter1.Size = new Size(980, 460);
            ctrlShowPersonDetailsWithFilter1.TabIndex = 4;
            ctrlShowPersonDetailsWithFilter1.Text = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            ctrlShowPersonDetailsWithFilter1.Click += ctrlShowPersonDetailsWithFilter1_Click;
            // 
            // frmFindPerson
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1020, 679);
            Controls.Add(ctrlShowPersonDetailsWithFilter1);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Name = "frmFindPerson";
            ShowIcon = false;
            Text = "Find Person";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            FormClosing += frmFindPerson_FormClosing;
            Load += frmFindPerson_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UISymbolButton btnClose;
        private Controls.ctrlShowPersonDetailsWithFilter ctrlShowPersonDetailsWithFilter1;
    }
}