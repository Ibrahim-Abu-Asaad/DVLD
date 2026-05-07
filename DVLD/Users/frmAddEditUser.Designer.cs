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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            btnSave = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            tabControl1 = new TabControl();
            tbPersonalInfo = new TabPage();
            btnNext = new Sunny.UI.UIButton();
            ctrlShowPersonDetailsWithFilter1 = new People.Controls.ctrlShowPersonDetailsWithFilter();
            tbLoginInfo = new TabPage();
            llblChangePassword = new LinkLabel();
            btnBack = new Sunny.UI.UIButton();
            chbIsActive = new Sunny.UI.UICheckBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            label2 = new Label();
            txtPassword = new Sunny.UI.UITextBox();
            txtConfirmPassword = new Sunny.UI.UITextBox();
            txtUsername = new Sunny.UI.UITextBox();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tbPersonalInfo.SuspendLayout();
            tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(373, 71);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 49);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Add New User";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(917, 788);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(786, 788);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
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
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("Microsoft Sans Serif", 12F);
            btnNext.Location = new Point(856, 481);
            btnNext.MinimumSize = new Size(1, 1);
            btnNext.Name = "btnNext";
            btnNext.Radius = 10;
            btnNext.Size = new Size(125, 44);
            btnNext.TabIndex = 21;
            btnNext.Text = "Next";
            btnNext.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNext.Click += btnNext_Click;
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
            // tbLoginInfo
            // 
            tbLoginInfo.BackColor = Color.FromArgb(243, 249, 255);
            tbLoginInfo.Controls.Add(llblChangePassword);
            tbLoginInfo.Controls.Add(btnBack);
            tbLoginInfo.Controls.Add(chbIsActive);
            tbLoginInfo.Controls.Add(lblConfirmPassword);
            tbLoginInfo.Controls.Add(lblPassword);
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
            // llblChangePassword
            // 
            llblChangePassword.AutoSize = true;
            llblChangePassword.BackColor = Color.FromArgb(243, 249, 255);
            llblChangePassword.Location = new Point(655, 151);
            llblChangePassword.Name = "llblChangePassword";
            llblChangePassword.Size = new Size(166, 26);
            llblChangePassword.TabIndex = 23;
            llblChangePassword.TabStop = true;
            llblChangePassword.Text = "Change Password";
            llblChangePassword.LinkClicked += llblChangePassword_LinkClicked;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F);
            btnBack.Location = new Point(6, 481);
            btnBack.MinimumSize = new Size(1, 1);
            btnBack.Name = "btnBack";
            btnBack.Radius = 10;
            btnBack.Size = new Size(125, 44);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnBack.Click += btnBack_Click;
            // 
            // chbIsActive
            // 
            chbIsActive.Font = new Font("Microsoft Sans Serif", 12F);
            chbIsActive.ForeColor = Color.FromArgb(48, 48, 48);
            chbIsActive.Location = new Point(400, 348);
            chbIsActive.MinimumSize = new Size(1, 1);
            chbIsActive.Name = "chbIsActive";
            chbIsActive.Size = new Size(188, 36);
            chbIsActive.TabIndex = 16;
            chbIsActive.Text = "Is Active";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(223, 296);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(172, 26);
            lblConfirmPassword.TabIndex = 18;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(302, 224);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(94, 26);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password";
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
            txtPassword.TabIndex = 14;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            txtPassword.TextChanged += txtUsername_TextChanged;
            txtPassword.Leave += txt_Leave;
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
            txtConfirmPassword.TabIndex = 15;
            txtConfirmPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPassword.Watermark = "";
            txtConfirmPassword.TextChanged += txtUsername_TextChanged;
            txtConfirmPassword.Leave += txt_Leave;
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
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.Leave += txt_Leave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1068, 880);
            Controls.Add(tabControl1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Name = "frmAddEditUser";
            ShowIcon = false;
            Text = "Add New User";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmAddEditUser_Load;
            tabControl1.ResumeLayout(false);
            tbPersonalInfo.ResumeLayout(false);
            tbLoginInfo.ResumeLayout(false);
            tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
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
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Label label2;
        private Sunny.UI.UICheckBox chbIsActive;
        private Sunny.UI.UIButton btnBack;
        private ErrorProvider errorProvider1;
        private LinkLabel llblChangePassword;
    }
}