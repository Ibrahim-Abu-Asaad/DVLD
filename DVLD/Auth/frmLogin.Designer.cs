namespace DVLD.Auth
{
    partial class frmLogin
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
            btnLogin = new Sunny.UI.UIButton();
            lblTitle = new Label();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            chbShowPassword = new Sunny.UI.UICheckBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.Location = new Point(415, 362);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 10;
            btnLogin.Size = new Size(125, 44);
            btnLogin.TabIndex = 34;
            btnLogin.Text = "Login";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(29, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(948, 49);
            lblTitle.TabIndex = 33;
            lblTitle.Text = "Driving and Vehicle Licensing Department System";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(317, 258);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(94, 26);
            lblConfirmPassword.TabIndex = 32;
            lblConfirmPassword.Text = "Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(309, 204);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 26);
            lblPassword.TabIndex = 31;
            lblPassword.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(415, 197);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.Radius = 10;
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(224, 43);
            txtUsername.TabIndex = 28;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(415, 250);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '●';
            txtPassword.Radius = 10;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(224, 43);
            txtPassword.TabIndex = 29;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            // 
            // chbShowPassword
            // 
            chbShowPassword.Font = new Font("Microsoft Sans Serif", 12F);
            chbShowPassword.ForeColor = Color.FromArgb(48, 48, 48);
            chbShowPassword.Location = new Point(414, 293);
            chbShowPassword.MinimumSize = new Size(1, 1);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(188, 36);
            chbShowPassword.TabIndex = 35;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1006, 463);
            Controls.Add(chbShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "frmLogin";
            ShowIcon = false;
            Text = "Login";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnLogin;
        private Label lblTitle;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UICheckBox chbShowPassword;
        private ErrorProvider errorProvider1;
    }
}