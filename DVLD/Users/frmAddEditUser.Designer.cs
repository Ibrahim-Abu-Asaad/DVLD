namespace DVLD.Users
{
    partial class frmAddEditUser
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
            lblAddNewUser = new Label();
            btnSave = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            tabControl1 = new TabControl();
            tbPersonalInfo = new TabPage();
            tbLoginInfo = new TabPage();
            ctrlShowPersonDetailsWithFilter1 = new People.Controls.ctrlShowPersonDetailsWithFilter();
            btnNext = new Sunny.UI.UIButton();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            txtConfirmPassword = new Sunny.UI.UITextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            uiCheckBox1 = new Sunny.UI.UICheckBox();
            tabControl1.SuspendLayout();
            tbPersonalInfo.SuspendLayout();
            tbLoginInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddNewUser
            // 
            lblAddNewUser.AutoSize = true;
            lblAddNewUser.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddNewUser.ForeColor = SystemColors.HotTrack;
            lblAddNewUser.Location = new Point(373, 71);
            lblAddNewUser.Name = "lblAddNewUser";
            lblAddNewUser.Size = new Size(282, 49);
            lblAddNewUser.TabIndex = 3;
            lblAddNewUser.Text = "Add New User";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(917, 788);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(786, 788);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPersonalInfo);
            tabControl1.Controls.Add(tbLoginInfo);
            tabControl1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(27, 162);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1015, 620);
            tabControl1.TabIndex = 22;
            // 
            // tbPersonalInfo
            // 
            tbPersonalInfo.BackColor = Color.FromArgb(243, 249, 255);
            tbPersonalInfo.Controls.Add(btnNext);
            tbPersonalInfo.Controls.Add(ctrlShowPersonDetailsWithFilter1);
            tbPersonalInfo.Location = new Point(4, 35);
            tbPersonalInfo.Name = "tbPersonalInfo";
            tbPersonalInfo.Padding = new Padding(3);
            tbPersonalInfo.Size = new Size(1007, 581);
            tbPersonalInfo.TabIndex = 0;
            tbPersonalInfo.Text = "Personal Info";
            // 
            // tbLoginInfo
            // 
            tbLoginInfo.BackColor = Color.FromArgb(243, 249, 255);
            tbLoginInfo.Controls.Add(uiCheckBox1);
            tbLoginInfo.Controls.Add(label3);
            tbLoginInfo.Controls.Add(label1);
            tbLoginInfo.Controls.Add(label2);
            tbLoginInfo.Controls.Add(txtPassword);
            tbLoginInfo.Controls.Add(txtConfirmPassword);
            tbLoginInfo.Controls.Add(txtUsername);
            tbLoginInfo.Location = new Point(4, 35);
            tbLoginInfo.Name = "tbLoginInfo";
            tbLoginInfo.Padding = new Padding(3);
            tbLoginInfo.Size = new Size(1007, 581);
            tbLoginInfo.TabIndex = 1;
            tbLoginInfo.Text = "Login Info";
            // 
            // ctrlShowPersonDetailsWithFilter1
            // 
            ctrlShowPersonDetailsWithFilter1.BackColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetailsWithFilter1.FilterEnabled = true;
            ctrlShowPersonDetailsWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowPersonDetailsWithFilter1.Location = new Point(16, 18);
            ctrlShowPersonDetailsWithFilter1.MinimumSize = new Size(1, 1);
            ctrlShowPersonDetailsWithFilter1.Name = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetailsWithFilter1.ShowAddPersonIcon = true;
            ctrlShowPersonDetailsWithFilter1.Size = new Size(974, 454);
            ctrlShowPersonDetailsWithFilter1.TabIndex = 0;
            ctrlShowPersonDetailsWithFilter1.Text = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 12F);
            btnNext.Location = new Point(856, 481);
            btnNext.MinimumSize = new Size(1, 1);
            btnNext.Name = "btnNext";
            btnNext.Radius = 10;
            btnNext.Size = new Size(125, 44);
            btnNext.TabIndex = 21;
            btnNext.Text = "Next";
            btnNext.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(400, 144);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.Radius = 10;
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(224, 43);
            txtUsername.TabIndex = 13;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(400, 216);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.Radius = 10;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(224, 43);
            txtPassword.TabIndex = 13;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(400, 288);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.MinimumSize = new Size(1, 16);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(5);
            txtConfirmPassword.Radius = 10;
            txtConfirmPassword.ShowText = false;
            txtConfirmPassword.Size = new Size(224, 43);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPassword.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 151);
            label2.Name = "label2";
            label2.Size = new Size(102, 26);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 224);
            label1.Name = "label1";
            label1.Size = new Size(94, 26);
            label1.TabIndex = 17;
            label1.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 296);
            label3.Name = "label3";
            label3.Size = new Size(172, 26);
            label3.TabIndex = 18;
            label3.Text = "Confirm Password";
            // 
            // uiCheckBox1
            // 
            uiCheckBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiCheckBox1.ForeColor = Color.FromArgb(48, 48, 48);
            uiCheckBox1.Location = new Point(400, 348);
            uiCheckBox1.MinimumSize = new Size(1, 1);
            uiCheckBox1.Name = "uiCheckBox1";
            uiCheckBox1.Size = new Size(188, 36);
            uiCheckBox1.TabIndex = 19;
            uiCheckBox1.Text = "Is Active";
            // 
            // frmAddEditUser
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1068, 880);
            Controls.Add(tabControl1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblAddNewUser);
            Name = "frmAddEditUser";
            ShowIcon = false;
            Text = "Add New User";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            tabControl1.ResumeLayout(false);
            tbPersonalInfo.ResumeLayout(false);
            tbLoginInfo.ResumeLayout(false);
            tbLoginInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddNewUser;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnClose;
        private TabControl tabControl1;
        private TabPage tbPersonalInfo;
        private TabPage tbLoginInfo;
        private Sunny.UI.UIButton btnNext;
        private People.Controls.ctrlShowPersonDetailsWithFilter ctrlShowPersonDetailsWithFilter1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Sunny.UI.UITextBox txtUsername;
        private Label label3;
        private Label label1;
        private Label label2;
        private Sunny.UI.UICheckBox uiCheckBox1;
    }
}