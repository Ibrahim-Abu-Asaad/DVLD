namespace DVLD.Users.Controls
{
    partial class ctrlShowUserDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlShowUserDetails));
            ctrlShowPersonDetails21 = new ctrlShowPersonDetails2();
            uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            lblIsActive = new Label();
            lblUsername = new Label();
            label2 = new Label();
            label1 = new Label();
            uiCheckBoxGroup1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlShowPersonDetails21
            // 
            ctrlShowPersonDetails21.BackColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetails21.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowPersonDetails21.Location = new Point(18, 9);
            ctrlShowPersonDetails21.MinimumSize = new Size(1, 1);
            ctrlShowPersonDetails21.Name = "ctrlShowPersonDetails21";
            ctrlShowPersonDetails21.RectColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetails21.Size = new Size(962, 352);
            ctrlShowPersonDetails21.TabIndex = 0;
            ctrlShowPersonDetails21.Text = "ctrlShowPersonDetails21";
            ctrlShowPersonDetails21.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiCheckBoxGroup1
            // 
            uiCheckBoxGroup1.Controls.Add(lblIsActive);
            uiCheckBoxGroup1.Controls.Add(lblUsername);
            uiCheckBoxGroup1.Controls.Add(label2);
            uiCheckBoxGroup1.Controls.Add(label1);
            uiCheckBoxGroup1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiCheckBoxGroup1.Location = new Point(20, 352);
            uiCheckBoxGroup1.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup1.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            uiCheckBoxGroup1.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup1.RectColor = Color.FromArgb(173, 178, 181);
            uiCheckBoxGroup1.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup1.SelectedIndexes");
            uiCheckBoxGroup1.Size = new Size(948, 159);
            uiCheckBoxGroup1.TabIndex = 1;
            uiCheckBoxGroup1.Text = "Login Information";
            uiCheckBoxGroup1.TextAlignment = ContentAlignment.MiddleLeft;
            uiCheckBoxGroup1.ValueChanged += uiCheckBoxGroup1_ValueChanged;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.BackColor = Color.FromArgb(243, 249, 255);
            lblIsActive.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsActive.ForeColor = Color.MediumBlue;
            lblIsActive.Location = new Point(633, 80);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(40, 26);
            lblIsActive.TabIndex = 3;
            lblIsActive.Text = "Yes";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(243, 249, 255);
            lblUsername.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MediumBlue;
            lblUsername.Location = new Point(272, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(57, 26);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "ibr17";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 249, 255);
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(531, 80);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 1;
            label2.Text = "Is Active:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 249, 255);
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(157, 80);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // ctrlShowUserDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiCheckBoxGroup1);
            Controls.Add(ctrlShowPersonDetails21);
            Name = "ctrlShowUserDetails";
            RectColor = Color.FromArgb(243, 249, 255);
            Size = new Size(986, 526);
            Load += ctrlShowUserDetails_Load;
            Click += ctrlShowUserDetails_Click;
            uiCheckBoxGroup1.ResumeLayout(false);
            uiCheckBoxGroup1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ctrlShowPersonDetails2 ctrlShowPersonDetails21;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Label label2;
        private Label label1;
        private Label lblIsActive;
        private Label lblUsername;
    }
}
